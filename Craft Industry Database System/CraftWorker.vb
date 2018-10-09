Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Imports Craft_Industry_Database.frmUsers

Public Class frmCraftWorker
    Public Shared formId2 As String
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

        objDataAdapter = New SqlDataAdapter("SELECT * FROM tblCraftWorker ORDER BY formId", connectionString)
        ' Initialize a new instance of the DataSet object...
        objDataSet = New DataSet()
        ' Fill the DataSet object with data...
        objDataAdapter.Fill(objDataSet, "craftWorker")
        ' Set the DataView object to the DataSet object...
        objDataView = New DataView(objDataSet.Tables("craftWorker"))
        ' Set our CurrencyManager object to the DataView object...
        objCurrencyManager = CType(Me.BindingContext(objDataView), CurrencyManager)

    End Sub

    Private Sub Clear()

        ' Clear any previous bindings...
        txtCraftWorkerId.DataBindings.Clear()
        txtFirstName.DataBindings.Clear()
        txtSurName.DataBindings.Clear()
        txtAge.DataBindings.Clear()
        cboEthnicGroup.DataBindings.Clear()
        txtAddress.DataBindings.Clear()
        txtAddressWorkshop.DataBindings.Clear()
        txtNumber.DataBindings.Clear()
        cboNationality.DataBindings.Clear()
        cboSex.DataBindings.Clear()
        txtFormId.DataBindings.Clear()

        Hid2.DataBindings.Clear()

    End Sub

    Private Sub BindFields()

        Clear()

        ' Add new bindings to the DataView object...
        txtCraftWorkerId.DataBindings.Add("Text", objDataView, "craftWorkerId")
        txtFirstName.DataBindings.Add("Text", objDataView, "firstName")
        txtSurName.DataBindings.Add("Text", objDataView, "surName")
        txtAge.DataBindings.Add("Text", objDataView, "age")
        txtAddress.DataBindings.Add("Text", objDataView, "address")
        txtAddressWorkshop.DataBindings.Add("Text", objDataView, "addressOfWorkshop")
        txtNumber.DataBindings.Add("Text", objDataView, "dependents")
        txtFormId.DataBindings.Add("Text", objDataView, "formId")

        cboEthnicGroup.DataBindings.Add("SelectedItem", objDataView, "ethinicGroup")
        cboNationality.DataBindings.Add("SelectedItem", objDataView, "nationality")
        cboSex.DataBindings.Add("SelectedItem", objDataView, "sex")

        'Dim i As Integer = 0
        'Dim t As String

        'For i = 0 To cboNationality.Items.Count - 1
        '    ' MsgBox(Hid.Text + " " + cboCraftCategory.Text)
        '    cboNationality.SelectedIndex = i
        '    t = cboNationality.Text
        '    If Hid.Text.Equals(t) Then
        '        cboNationality.Text = Hid.Text
        '        Exit For
        '    End If
        'Next

        'If Hid2.Text = "True" Then
        '    rdbFemale.Checked = True
        '    rdbMale.Checked = False
        'ElseIf Hid2.Text = "False" Then
        '    rdbFemale.Checked = False
        '    rdbMale.Checked = True
        'End If

    End Sub

    Private Sub ShowPosition()

        ' Display the current position and the number of records
        txtPosition.Text = objCurrencyManager.Position + 1 & " of " & objCurrencyManager.Count()

    End Sub

    Private Sub frmCraftWorker_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If user = True Then
            btnNew.Enabled = False
            btnDelete.Enabled = False
            btnSave.Enabled = False
            btnUpdate.Enabled = False
        End If

        cboNationality.SelectedIndex = 0

        ' Fill the DataSet and bind the fields...
        FillDataSetAndView()
        BindFields()

        ' Show the current record position...
        ShowPosition()
        mover()
    End Sub

    Private Sub Save(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim formId As String = frmForm.formId

        'Dim sex As Boolean

        'If rdbMale.Checked Then
        '    sex = True
        'Else
        '    sex = False
        'End If

        If chkDiffAddress.Checked = False Then
            txtAddressWorkshop.Text = txtAddress.Text
        End If

        Using myConnection As SqlConnection = New SqlConnection(Me.connectionString)

            myConnection.Open()

            Using cmd As SqlCommand = myConnection.CreateCommand

                cmd.CommandType = CommandType.Text
                cmd.CommandText = "INSERT INTO tblCraftWorker (firstName, surName, age, sex, ethinicGroup, nationality, address, addressOfWorkshop, dependents, formId) " & _
                                  "VALUES (@firstName, @surName, @age, @sex, @ethinicGroup, @nationality, @address, @addressOfWorkshop, @dependents, @formId)"

                cmd.Parameters.Add(New SqlParameter("@firstName", txtFirstName.Text))
                cmd.Parameters.Add(New SqlParameter("@surName", txtSurName.Text))
                cmd.Parameters.Add(New SqlParameter("@age", txtAge.Text))
                cmd.Parameters.Add(New SqlParameter("@sex", cboSex.Text))
                cmd.Parameters.Add(New SqlParameter("@ethinicGroup", cboEthnicGroup.Text))
                cmd.Parameters.Add(New SqlParameter("@nationality", cboNationality.Text))
                cmd.Parameters.Add(New SqlParameter("@address", txtAddress.Text))
                cmd.Parameters.Add(New SqlParameter("@addressOfWorkshop", txtAddressWorkshop.Text))
                cmd.Parameters.Add(New SqlParameter("@dependents", txtNumber.Text))
                cmd.Parameters.Add(New SqlParameter("@formId", formId2))

                Try
                    cmd.ExecuteNonQuery()
                    message.Text = "The data is Inserted Successfully."
                Catch ex As SqlException
                    MessageBox.Show(ex.Message)
                End Try

            End Using

        End Using

        Call frmCraftWorker_Load(Nothing, Nothing)

    End Sub

    Private Sub UpdateForm(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim formId As String = frmForm.formId

        'Dim sex As Boolean

        'If rdbMale.Checked Then
        '    sex = True
        'Else
        '    sex = False
        'End If

        If chkDiffAddress.Checked = False Then
            txtAddressWorkshop.Text = txtAddress.Text
        End If

        Using myConnection As SqlConnection = New SqlConnection(Me.connectionString)

            myConnection.Open()

            Using cmd As SqlCommand = myConnection.CreateCommand

                cmd.CommandType = CommandType.Text
                cmd.CommandText = "UPDATE tblCraftWorker SET firstName =  @firstName, surName = @surName, age = @age, sex = @sex, ethinicGroup =  @ethinicGroup, nationality = @nationality, address = @address, addressOfWorkshop = @addressOfWorkshop, dependents = @dependents, formId = @formId " & _
                                  "WHERE craftWorkerId = @craftWorkerId"

                cmd.Parameters.Add(New SqlParameter("@craftWorkerId", txtCraftWorkerId.Text))
                cmd.Parameters.Add(New SqlParameter("@firstName", txtFirstName.Text))
                cmd.Parameters.Add(New SqlParameter("@surName", txtSurName.Text))
                cmd.Parameters.Add(New SqlParameter("@age", txtAge.Text))
                cmd.Parameters.Add(New SqlParameter("@sex", cboSex.Text))
                cmd.Parameters.Add(New SqlParameter("@ethinicGroup", cboEthnicGroup.Text))
                cmd.Parameters.Add(New SqlParameter("@nationality", cboNationality.Text))
                cmd.Parameters.Add(New SqlParameter("@address", txtAddress.Text))
                cmd.Parameters.Add(New SqlParameter("@addressOfWorkshop", txtAddressWorkshop.Text))
                cmd.Parameters.Add(New SqlParameter("@dependents", txtNumber.Text))
                cmd.Parameters.Add(New SqlParameter("@formId", txtFormId.Text))

                Try
                    cmd.ExecuteNonQuery()
                    message.Text = "The data is Updated Successfully."
                Catch ex As SqlException
                    MessageBox.Show(ex.Message)
                End Try

            End Using

        End Using

        Call frmCraftWorker_Load(Nothing, Nothing)

    End Sub

    Private Sub Delete(ByVal deleteId As Integer)

        Using myConnection As SqlConnection = New SqlConnection(Me.connectionString)

            myConnection.Open()

            Using cmd As SqlCommand = myConnection.CreateCommand

                cmd.CommandType = CommandType.Text
                cmd.CommandText = "DELETE FROM tblCraftWorker " & _
                                  "WHERE craftWorkerId = '" & deleteId & "'"

                Try
                    cmd.ExecuteScalar()
                    message.Text = "The data is Deleted Successfully."
                Catch ex As SqlException
                    MessageBox.Show(ex.Message)
                End Try

            End Using

        End Using

        Call frmCraftWorker_Load(Nothing, Nothing)

    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click

        Dim form As New frmDefinition
        form.MdiParent = mdiHome
        frmDefinition.formId2 = frmCraftWorker.formId2
        frmDefinition.position = position
        form.Show()
        Me.Close()

    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click

        Dim form As New frmProduction
        form.MdiParent = mdiHome
        form.Show()
        Me.Close()

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

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        txtFormId.ReadOnly = True
        ' Clear any previous bindings...
        Clear()

        btnSave.Enabled = True
        btnUpdate.Enabled = False

        txtCraftWorkerId.Text = String.Empty
        txtFirstName.Text = String.Empty
        txtSurName.Text = String.Empty
        txtAge.Text = String.Empty
        txtAddress.Text = String.Empty
        txtAddressWorkshop.Text = String.Empty
        txtNumber.Text = String.Empty

        cboEthnicGroup.SelectedIndex = 0
        cboNationality.SelectedIndex = 0
        cboSex.SelectedIndex = 0

        txtFormId.Text = String.Empty

        Hid2.Text = String.Empty
        message.Text = "Ready."
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        validatation(0)
        txtFormId.ReadOnly = False
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        If (MessageBox.Show("Are you sure you want to delete this data?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) = True Then

            If txtCraftWorkerId.Text = "" Then
                MessageBox.Show("Can not delete an empty data.", "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim selectedId As Integer = txtCraftWorkerId.Text
                Delete(selectedId)
            End If

        End If

        frmCraftWorker_Load(Nothing, Nothing)

    End Sub

    Public Sub validatation(ByVal i As Integer)
        If txtFirstName.Text = String.Empty Or
            txtSurName.Text = String.Empty Or
            txtAge.Text = String.Empty Or
            cboEthnicGroup.Text = String.Empty Or
            txtAddress.Text = String.Empty Or
            txtNumber.Text = String.Empty Or
            cboNationality.Text = String.Empty Then

            MessageBox.Show("Please fill all the required fields.", "Fill Blank Fields", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf IsNumeric(txtFirstName.Text) Or IsNumeric(txtSurName.Text) Or IsNumeric(cboEthnicGroup.Text) Or
                 IsNumeric(txtAddress.Text) Or IsNumeric(txtAddressWorkshop.Text) Then
            MessageBox.Show("First Name, Sur Name, Ethnic Group, Address and Address of workshop can not be numeric.", "String Expected", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If IsNumeric(txtCraftWorkerId.Text) And i = 1 Then
                Call UpdateForm(Nothing, Nothing)

            Else
                Call Save(Nothing, Nothing)
                btnSave.Enabled = False
                btnUpdate.Enabled = True
            End If
        End If

    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        frmCraftWorker_Load(sender, e)
        btnSave.Enabled = False
        btnUpdate.Enabled = True
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        validatation(1)
    End Sub

    Public Sub mover()
        ' Set the record position to the first record...
        objCurrencyManager.Position = position
        ' Show the current record position...
        ShowPosition()
        BindFields()
    End Sub


    Private Sub chkDiffAddress_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDiffAddress.CheckedChanged

        If chkDiffAddress.Checked = True Then

            Label8.Enabled = True
            txtAddressWorkshop.Enabled = True

        Else

            Label8.Enabled = False
            txtAddressWorkshop.Enabled = False

        End If

    End Sub

End Class