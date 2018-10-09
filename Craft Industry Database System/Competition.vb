Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Imports Craft_Industry_Database.frmUsers

Public Class frmCompetition
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

        objDataAdapter = New SqlDataAdapter("SELECT * FROM tblCompetition ORDER BY formId", connectionString)
        ' Initialize a new instance of the DataSet object...
        objDataSet = New DataSet()
        ' Fill the DataSet object with data...
        objDataAdapter.Fill(objDataSet, "competition")
        ' Set the DataView object to the DataSet object...
        objDataView = New DataView(objDataSet.Tables("competition"))
        ' Set our CurrencyManager object to the DataView object...
        objCurrencyManager = CType(Me.BindingContext(objDataView), CurrencyManager)

    End Sub

    Private Sub Clear()

        ' Clear any previous bindings...
        txtCompetitionId.DataBindings.Clear()
        chkLocal.DataBindings.Clear()
        chkRegional.DataBindings.Clear()
        chkNational.DataBindings.Clear()
        txtProducts.DataBindings.Clear()
        txtFormId.DataBindings.Clear()

    End Sub

    Private Sub BindFields()

        Clear()

        ' Add new bindings to the DataView object...
        txtCompetitionId.DataBindings.Add("Text", objDataView, "competitionId")
        chkLocal.DataBindings.Add("Checked", objDataView, "local")
        chkRegional.DataBindings.Add("Checked", objDataView, "regional")
        chkNational.DataBindings.Add("Checked", objDataView, "national")
        txtProducts.DataBindings.Add("Text", objDataView, "competingProducts")
        txtFormId.DataBindings.Add("Text", objDataView, "formId")

    End Sub

    Private Sub ShowPosition()

        ' Display the current position and the number of records
        txtPosition.Text = objCurrencyManager.Position + 1 & " of " & objCurrencyManager.Count()

    End Sub

    Private Sub frmCompetition_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If user = True Then
            btnNew.Enabled = False
            btnDelete.Enabled = False
            btnSave.Enabled = False
            btnUpdate.Enabled = False
        End If

        ' Fill the DataSet and bind the fields...
        FillDataSetAndView()
        BindFields()

        ' Show the current record position...
        ShowPosition()
        mover()
    End Sub

    Private Sub Save(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim formId As String = frmForm.formId

        Dim local, regional, national As Boolean

        If chkLocal.Checked Then
            local = True
        Else
            local = False
        End If

        If chkRegional.Checked Then
            regional = True
        Else
            regional = False
        End If

        If chkNational.Checked Then
            national = True
        Else
            national = False
        End If

        Using myConnection As SqlConnection = New SqlConnection(Me.connectionString)

            myConnection.Open()

            Using cmd As SqlCommand = myConnection.CreateCommand

                cmd.CommandType = CommandType.Text
                cmd.CommandText = "INSERT INTO tblCompetition (local, regional, [national], competingProducts, formId) " & _
                                  "VALUES (@local, @regional, @national, @competingProducts, @formId)"

                cmd.Parameters.Add(New SqlParameter("@local", local))
                cmd.Parameters.Add(New SqlParameter("@regional", regional))
                cmd.Parameters.Add(New SqlParameter("@national", national))
                cmd.Parameters.Add(New SqlParameter("@competingProducts", txtProducts.Text))
                cmd.Parameters.Add(New SqlParameter("@formId", formId2))

                Try
                    cmd.ExecuteNonQuery()
                    Message.Text = "The data is Inserted Successfully."
                Catch ex As SqlException
                    MessageBox.Show(ex.Message)
                End Try

            End Using

        End Using

        Call frmCompetition_Load(Nothing, Nothing)


    End Sub

    Private Sub UpdateForm(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim formId As String = frmForm.formId

        Dim local, regional, national As Boolean

        If chkLocal.Checked Then
            local = True
        Else
            local = False
        End If

        If chkRegional.Checked Then
            regional = True
        Else
            regional = False
        End If

        If chkNational.Checked Then
            national = True
        Else
            national = False
        End If

        Using myConnection As SqlConnection = New SqlConnection(Me.connectionString)

            myConnection.Open()

            Using cmd As SqlCommand = myConnection.CreateCommand

                cmd.CommandType = CommandType.Text
                cmd.CommandText = "UPDATE tblCompetition SET local=@local, regional=@regional, [national]=@national, competingProducts=@competingProducts, formId=@formId " & _
                                  "WHERE competitionId = @competitionId"

                cmd.Parameters.Add(New SqlParameter("competitionId", txtCompetitionId.Text))
                cmd.Parameters.Add(New SqlParameter("@local", local))
                cmd.Parameters.Add(New SqlParameter("@regional", regional))
                cmd.Parameters.Add(New SqlParameter("@national", national))
                cmd.Parameters.Add(New SqlParameter("@competingProducts", txtProducts.Text))
                cmd.Parameters.Add(New SqlParameter("@formId", txtFormId.Text))

                Try
                    cmd.ExecuteNonQuery()
                    message.Text = "The data is Updated Successfully."
                Catch ex As SqlException
                    MessageBox.Show(ex.Message)
                End Try

            End Using

        End Using

        Call frmCompetition_Load(Nothing, Nothing)

    End Sub

    Private Sub Delete(ByVal deleteId As Integer)

        Using myConnection As SqlConnection = New SqlConnection(Me.connectionString)

            myConnection.Open()

            Using cmd As SqlCommand = myConnection.CreateCommand

                cmd.CommandType = CommandType.Text
                cmd.CommandText = "DELETE FROM tblCompetition " & _
                                  "WHERE competitionId = '" & deleteId & "'"

                Try
                    cmd.ExecuteScalar()
                    message.Text = "The data is Deleted Successfully."
                Catch ex As SqlException
                    MessageBox.Show(ex.Message)
                End Try

            End Using

        End Using

        ' Me.TblFormTableAdapter.Fill(Me.CraftIndustryDataSet.tblForm)
        'Call frmForm_Load(Nothing, Nothing)

    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click

        Dim form As New frmTax
        form.MdiParent = mdiHome
        frmTax.formId2 = frmCompetition.formId2
        frmTax.position = position
        form.Show()
        Me.Close()

    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click

        Dim form As New frmDistribution
        form.MdiParent = mdiHome
        form.Show()
        Me.Close()

    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        txtFormId.ReadOnly = True
        ' Clear any previous bindings...
        Clear()

        btnSave.Enabled = True
        btnUpdate.Enabled = False

        txtCompetitionId.Text = String.Empty
        chkLocal.Checked = False
        chkRegional.Checked = False
        chkNational.Checked = False
        txtProducts.Text = String.Empty
        txtFormId.Text = String.Empty
        message.Text = "Ready."
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        validatation(0)
        txtFormId.ReadOnly = False
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        If (MessageBox.Show("Are you sure you want to delete this data?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) = True Then

            If txtCompetitionId.Text = "" Then
                MessageBox.Show("Can not delete an empty data.", "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim selectedId As Integer = txtCompetitionId.Text
                Delete(selectedId)
            End If

        End If

        frmCompetition_Load(Nothing, Nothing)

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

    Public Sub validatation(ByVal i As Integer)
        If txtProducts.Text = String.Empty Then
            MessageBox.Show("Please fill all the required fields.", "Fill Blank Fields", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf IsNumeric(txtProducts.Text) Then
            MessageBox.Show("Competing products can not be numeric.", "String Expected", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            If IsNumeric(txtCompetitionId.Text) And i = 1 Then
                Call UpdateForm(Nothing, Nothing)

            Else
                Call Save(Nothing, Nothing)
                btnSave.Enabled = False
                btnUpdate.Enabled = True
            End If
        End If

    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        frmCompetition_Load(sender, e)
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

End Class