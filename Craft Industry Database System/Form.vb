Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Imports Craft_Industry_Database.frmUsers

Public Class frmForm

    Public Shared formId As String
    Public Shared position As Integer

    Dim connectionString As String = String.Empty
    Dim objDataAdapter As New SqlDataAdapter
    Dim objDataSet As DataSet
    Dim objDataView As DataView
    Dim objCurrencyManager As CurrencyManager

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.connectionString = ConfigurationManager.ConnectionStrings("connectionString").ConnectionString

    End Sub

    Private Sub FillDataSetAndView()

        objDataAdapter = New SqlDataAdapter("SELECT * FROM tblForm ORDER BY formId", connectionString)
        ' Initialize a new instance of the DataSet object...
        objDataSet = New DataSet()
        ' Fill the DataSet object with data...
        objDataAdapter.Fill(objDataSet, "form")
        ' Set the DataView object to the DataSet object...
        objDataView = New DataView(objDataSet.Tables("form"))
        ' Set our CurrencyManager object to the DataView object...
        objCurrencyManager = CType(Me.BindingContext(objDataView), CurrencyManager)

    End Sub

    Private Sub Clear()

        ' Clear any previous bindings...
        txtFormNumber.DataBindings.Clear()
        txtFormPlace.DataBindings.Clear()
        cboFormRegion.DataBindings.Clear()
        dtpFormDate.DataBindings.Clear()
        cboCraftCategory.DataBindings.Clear()
      
    End Sub

    Private Sub BindFields()

        Clear()

        ' Add new bindings to the DataView object...
        txtFormNumber.DataBindings.Add("Text", objDataView, "formId")
        txtFormPlace.DataBindings.Add("Text", objDataView, "formPlace")
        cboFormRegion.DataBindings.Add("SelectedItem", objDataView, "formRegion")
        dtpFormDate.DataBindings.Add("Value", objDataView, "formDate")
        cboCraftCategory.DataBindings.Add("SelectedItem", objDataView, "craftCategory")

    End Sub

    Private Sub ShowPosition()

        ' Display the current position and the number of records
        txtPosition.Text = objCurrencyManager.Position + 1 & " of " & objCurrencyManager.Count()
       
    End Sub

    Private Sub frmForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If user = True Then
            btnNew.Enabled = False
            btnDelete.Enabled = False
            btnSave.Enabled = False
            btnUpdate.Enabled = False
        End If

        cboCraftCategory.SelectedIndex = 0

        ' Fill the DataSet and bind the fields...
        FillDataSetAndView()
        BindFields()

        ' Show the current record position...
        ShowPosition()
    End Sub

    Private Sub Save(ByVal sender As System.Object, ByVal e As System.EventArgs)

        formId = txtFormNumber.Text

        Using myConnection As SqlConnection = New SqlConnection(Me.connectionString)

            myConnection.Open()

            Using cmd As SqlCommand = myConnection.CreateCommand

                cmd.CommandType = CommandType.Text
                cmd.CommandText = "INSERT INTO tblForm (formId, formDate, formRegion, formPlace, craftCategory) " & _
                                  "VALUES(@formId, @formDate, @formRegion, @formPlace, @craftCategory)"

                cmd.Parameters.Add(New SqlParameter("@formId", formId))
                cmd.Parameters.Add(New SqlParameter("@formDate", dtpFormDate.Value))
                cmd.Parameters.Add(New SqlParameter("@formRegion", cboFormRegion.Text))
                cmd.Parameters.Add(New SqlParameter("@formPlace", txtFormPlace.Text))
                cmd.Parameters.Add(New SqlParameter("@craftCategory", cboCraftCategory.Text))

                Try
                    cmd.ExecuteNonQuery()
                    message.Text = "The data is Inserted Successfully."
                Catch ex As SqlException
                    MessageBox.Show(ex.Message)
                End Try

                ''''''''''''''''''''''''''''''''''''''''''''''''''
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "SELECT formId FROM tblForm WHERE formId = '" & txtFormNumber.Text & "'"

                Dim reader As SqlDataReader = cmd.ExecuteReader

                While reader.Read

                     formId = reader("formId")

                End While

                message.Text = "The data is Inserted Successfully."

            End Using

        End Using

        Call frmForm_Load(Nothing, Nothing)
        btnSave.Enabled = False

        'Show the last inserted form 
        btnMoveLast_Click(Nothing, Nothing)

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        validatation(0)
        txtFormNumber.ReadOnly = False
    End Sub

    Private Sub Delete(ByVal deleteId As String)

        formId = txtFormNumber.Text

        Using myConnection As SqlConnection = New SqlConnection(Me.connectionString)

            myConnection.Open()

            Using cmd As SqlCommand = myConnection.CreateCommand

                cmd.CommandType = CommandType.Text
                cmd.CommandText = "DELETE FROM tblForm " & _
                                  "WHERE formId = '" & deleteId & "'"

                Try
                    cmd.ExecuteScalar()
                    message.Text = "The data is Deleted Successfully."
                Catch ex As SqlException
                    MessageBox.Show(ex.Message)
                End Try

            End Using

        End Using

        Call frmForm_Load(Nothing, Nothing)

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        If (MessageBox.Show("Are you sure you want to delete this data?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) = True Then

            If txtFormNumber.Text = "" Then
                MessageBox.Show("Can not delete an empty data.", "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim selectedId As String = txtFormNumber.Text
                Delete(selectedId)
            End If

        End If

        frmForm_Load(Nothing, Nothing)

    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click

        Dim form As New frmDescription
        form.MdiParent = mdiHome
        ' MsgBox(formId)

        position = objCurrencyManager.Position
        'MsgBox(position)

        'If formId <> 0 Then
        If txtFormNumber.Text <> String.Empty Then

            If formId <> String.Empty Then

                'formId = txtFormNumber.Text

                frmDescription.formId2 = formId
                frmDescription.position = position
                form.Show()
                Me.Close()

                'frmDescription.mover(frmForm.position)
                'frmDescription.mover(2)
                'frmDescription.btnMoveNext_Click(Nothing, Nothing)
                'MsgBox(formId)

                'frmDescription.MoveTo(position)
               
            Else
                formId = txtFormNumber.Text
                frmDescription.formId2 = formId
                frmDescription.position = position
                form.Show()
                Me.Close()

                'frmDescription.mover(2)
                'frmDescription.btnMoveNext_Click(Nothing, Nothing)
                
            End If

        Else
            MessageBox.Show("You cannot skip without entering the Form ID", "Enter form id")
        End If

    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click

        txtFormNumber.ReadOnly = False
        btnSave.Enabled = True
        btnUpdate.Enabled = False

        Clear()

        txtFormNumber.Text = String.Empty
        txtFormPlace.Text = String.Empty
        cboCraftCategory.SelectedIndex = 0
        cboFormRegion.SelectedIndex = 0
        dtpFormDate.Value = Now.Date
        message.Text = "Ready."
    End Sub

    Private Sub UpdateFunction()
        formId = txtFormNumber.Text
        Using myConnection As SqlConnection = New SqlConnection(Me.connectionString)

            myConnection.Open()

            Using cmd As SqlCommand = myConnection.CreateCommand

                cmd.CommandType = CommandType.Text
                cmd.CommandText = "UPDATE tblForm SET formDate = @formDate, formRegion = @formRegion, formPlace = @formPlace, craftCategory = @craftCategory " & _
                                  "WHERE formId = @formId"

                cmd.Parameters.Add(New SqlParameter("@formId", formId))
                cmd.Parameters.Add(New SqlParameter("@formDate", dtpFormDate.Value))
                cmd.Parameters.Add(New SqlParameter("@formRegion", cboFormRegion.Text))
                cmd.Parameters.Add(New SqlParameter("@formPlace", txtFormPlace.Text))
                cmd.Parameters.Add(New SqlParameter("@craftCategory", cboCraftCategory.Text))

                Try
                    cmd.ExecuteNonQuery()
                    message.Text = "The data is Updated Successfully."
                Catch ex As SqlException
                    MessageBox.Show(ex.Message)
                End Try

            End Using

        End Using

        Call frmForm_Load(Nothing, Nothing)

        'Show the last inserted form 
        btnMoveLast_Click(Nothing, Nothing)

    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click

        validatation(1)

    End Sub

    Private Sub btnMoveFirst_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMoveFirst.Click
        ' Set the record position to the first record...
        objCurrencyManager.Position = 0
        ' Show the current record position...
        ShowPosition()
    End Sub

    Private Sub btnMovePrevious_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMovePrevious.Click
        ' Move to the previous record...
        objCurrencyManager.Position -= 1
        ' Show the current record position...
        ShowPosition()
    End Sub

    Private Sub btnMoveNext_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMoveNext.Click
        ' Move to the next record...
        objCurrencyManager.Position += 1
        ' Show the current record position...
        ShowPosition()
    End Sub

    Private Sub btnMoveLast_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMoveLast.Click
        ' Set the record position to the last record...
        objCurrencyManager.Position = objCurrencyManager.Count - 1
        ' Show the current record position...
        ShowPosition()
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        frmForm_Load(sender, e)
        btnSave.Enabled = False
        btnUpdate.Enabled = True
    End Sub

    Public Sub validatation(ByVal i As Integer)

        If txtFormNumber.Text.Equals(String.Empty) Or dtpFormDate.Value.ToString = "" Or txtFormPlace.Text.Equals(String.Empty) Or cboFormRegion.Text.Equals(String.Empty) Or cboCraftCategory.Text.Equals(String.Empty) Then
            MessageBox.Show("Please fill all the required fields.", "Fill Blank Fields", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else

            'Using myConnection As SqlConnection = New SqlConnection(Me.connectionString)

            '    myConnection.Open()

            '    Using cmd As SqlCommand = myConnection.CreateCommand
            '        'SELECT command to check for used ID
            '        cmd.CommandText = _
            '        "SELECT formId " & _
            '        "FROM tblForm " & _
            '        "WHERE formId = " & txtFormNumber.Text & ";"

            '        Dim objUsedID As Object = cmd.ExecuteScalar
            '        Dim strUsed As String = CType(objUsedID, String)

            '        If strUsed <> "" Then
            '            MessageBox.Show("Please use a different Form Id.", "Duplicate Form Id", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '            txtFormNumber.Text = String.Empty
            '        Else

            If i = 1 Then
                Call UpdateFunction()
            Else
                Call Save(Nothing, Nothing)
                btnUpdate.Enabled = True
            End If

        End If
        '    End Using
        'End Using
        'End If
    End Sub

    'Private Sub txtFormNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFormNumber.TextChanged
    '    If Not txtFormNumber.Text.Equals("") Then
    '        formId = CType(txtFormNumber.Text, Integer)
    '    End If
    'End Sub

    
End Class