Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Imports Craft_Industry_Database.frmUsers

Public Class frmProduction
    Public Shared formId2 As String
    'Public formId As String
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

        objDataAdapter = New SqlDataAdapter("SELECT * FROM tblProduction ORDER BY formId", connectionString)
        ' Initialize a new instance of the DataSet object...
        objDataSet = New DataSet()
        ' Fill the DataSet object with data...
        objDataAdapter.Fill(objDataSet, "production")
        ' Set the DataView object to the DataSet object...
        objDataView = New DataView(objDataSet.Tables("production"))
        ' Set our CurrencyManager object to the DataView object...
        objCurrencyManager = CType(Me.BindingContext(objDataView), CurrencyManager)

    End Sub

    Private Sub Clear()

        ' Clear any previous bindings...
        txtProductionId.DataBindings.Clear()
        txtMadeIn.DataBindings.Clear()
        txtSoldIn.DataBindings.Clear()
        txtSeenIn.DataBindings.Clear()
        txtName.DataBindings.Clear()
        txtAddress.DataBindings.Clear()
        txtLocalPrice.DataBindings.Clear()
        txtObservation.DataBindings.Clear()
        txtFormId.DataBindings.Clear()

    End Sub

    Public Sub validatation(ByVal i As Integer)

        If txtMadeIn.Text = String.Empty Or
            txtSoldIn.Text = String.Empty Or
            txtSeenIn.Text = String.Empty Or
            txtName.Text = String.Empty Or
            txtAddress.Text = String.Empty Or
            txtLocalPrice.Text = String.Empty Then

            MessageBox.Show("Please fill all the required fields.", "Fill Blank Fields", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        ElseIf IsNumeric(txtMadeIn.Text) Or IsNumeric(txtSoldIn.Text) Or IsNumeric(txtSeenIn.Text) Or
                IsNumeric(txtName.Text) Or IsNumeric(txtAddress.Text) Or IsNumeric(txtObservation.Text) Then
            MessageBox.Show("Made in, sold in, seen in, name, address and observation can not be numeric.", "String Expected", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If IsNumeric(txtProductionId.Text) And i = 1 Then
                Call UpdateForm(Nothing, Nothing)

            Else
                Call Save(Nothing, Nothing)
                btnSave.Enabled = False
                btnUpdate.Enabled = True
            End If
        End If
    End Sub

    Private Sub BindFields()

        Clear()

        ' Add new bindings to the DataView object...
        txtProductionId.DataBindings.Add("Text", objDataView, "productionId")
        txtMadeIn.DataBindings.Add("Text", objDataView, "madeIn")
        txtSoldIn.DataBindings.Add("Text", objDataView, "soldIn")
        txtSeenIn.DataBindings.Add("Text", objDataView, "seenIn")
        txtName.DataBindings.Add("Text", objDataView, "nameOfCraftWorker")
        txtAddress.DataBindings.Add("Text", objDataView, "addressOfCraftWorker")
        txtLocalPrice.DataBindings.Add("Text", objDataView, "localPrice")
        txtObservation.DataBindings.Add("Text", objDataView, "observation")
        txtFormId.DataBindings.Add("Text", objDataView, "formId")

    End Sub

    Private Sub ShowPosition()

        ' Display the current position and the number of records
        txtPosition.Text = objCurrencyManager.Position + 1 & " of " & objCurrencyManager.Count()

    End Sub

    Private Sub frmProduction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load

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

        Using myConnection As SqlConnection = New SqlConnection(Me.connectionString)

            myConnection.Open()

            Using cmd As SqlCommand = myConnection.CreateCommand

                cmd.CommandType = CommandType.Text
                cmd.CommandText = "INSERT INTO tblProduction (madeIn, soldIn, seenIn, nameOfCraftWorker, addressOfCraftWorker, localPrice, observation, formId) " & _
                                  "VALUES (@madeIn, @soldIn, @seenIn, @nameOfCraftWorker, @addressOfCraftWorker, @localPrice, @observation, @formId)"

                cmd.Parameters.Add(New SqlParameter("@madeIn", txtMadeIn.Text))
                cmd.Parameters.Add(New SqlParameter("@soldIn", txtSoldIn.Text))
                cmd.Parameters.Add(New SqlParameter("@seenIn", txtSeenIn.Text))
                cmd.Parameters.Add(New SqlParameter("@nameOfCraftWorker", txtName.Text))
                cmd.Parameters.Add(New SqlParameter("@addressOfCraftWorker", txtAddress.Text))
                cmd.Parameters.Add(New SqlParameter("@localPrice", txtLocalPrice.Text))
                cmd.Parameters.Add(New SqlParameter("@observation", txtObservation.Text))
                cmd.Parameters.Add(New SqlParameter("@formId", formId2))

                Try
                    cmd.ExecuteNonQuery()
                    message.Text = "The data is Inserted Successfully."
                Catch ex As SqlException
                    MessageBox.Show(ex.Message)
                End Try

            End Using

        End Using

        Call frmProduction_Load(Nothing, Nothing)

    End Sub

    Private Sub UpdateForm(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim formId As String = frmForm.formId

        Using myConnection As SqlConnection = New SqlConnection(Me.connectionString)

            myConnection.Open()

            Using cmd As SqlCommand = myConnection.CreateCommand

                cmd.CommandType = CommandType.Text
                cmd.CommandText = "UPDATE tblProduction SET madeIn = @madeIn, soldIn = @soldIn, seenIn = @seenIn, nameOfCraftWorker = @nameOfCraftWorker, addressOfCraftWorker = @addressOfCraftWorker, localPrice = @localPrice, observation = @observation, formId =  @formId " & _
                                  "WHERE productionId = @productionId"

                cmd.Parameters.Add(New SqlParameter("@madeIn", txtMadeIn.Text))
                cmd.Parameters.Add(New SqlParameter("@soldIn", txtSoldIn.Text))
                cmd.Parameters.Add(New SqlParameter("@seenIn", txtSeenIn.Text))
                cmd.Parameters.Add(New SqlParameter("@nameOfCraftWorker", txtName.Text))
                cmd.Parameters.Add(New SqlParameter("@addressOfCraftWorker", txtAddress.Text))
                cmd.Parameters.Add(New SqlParameter("@localPrice", txtLocalPrice.Text))
                cmd.Parameters.Add(New SqlParameter("@observation", txtObservation.Text))
                cmd.Parameters.Add(New SqlParameter("@formId", txtFormId.Text))
                cmd.Parameters.Add(New SqlParameter("@productionId", txtProductionId.Text))

                Try
                    cmd.ExecuteNonQuery()
                    message.Text = "The data is Updated Successfully."
                Catch ex As SqlException
                    MessageBox.Show(ex.Message)
                End Try

            End Using

        End Using

        Call frmProduction_Load(Nothing, Nothing)

    End Sub

    Private Sub Delete(ByVal deleteId As Integer)

        Using myConnection As SqlConnection = New SqlConnection(Me.connectionString)

            myConnection.Open()

            Using cmd As SqlCommand = myConnection.CreateCommand

                cmd.CommandType = CommandType.Text
                cmd.CommandText = "DELETE FROM tblProduction " & _
                                  "WHERE productionId = '" & deleteId & "'"

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

        Dim form As New frmCraftWorker
        form.MdiParent = mdiHome
        frmCraftWorker.formId2 = frmProduction.formId2
        frmCraftWorker.position = position
        form.Show()
        Me.Close()


    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click

        Dim form As New frmDescription
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

        txtProductionId.Text = String.Empty
        txtMadeIn.Text = String.Empty
        txtSoldIn.Text = String.Empty
        txtSeenIn.Text = String.Empty
        txtName.Text = String.Empty
        txtAddress.Text = String.Empty
        txtLocalPrice.Text = String.Empty
        txtObservation.Text = String.Empty
        txtFormId.Text = String.Empty
        message.Text = "Ready."

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        validatation(0)
        txtFormId.ReadOnly = True
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If (MessageBox.Show("Are you sure you want to delete this data?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) = True Then

            If txtProductionId.Text = "" Then
                MessageBox.Show("Can not delete an empty data.", "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim selectedId As Integer = txtProductionId.Text
                Delete(selectedId)
            End If

        End If

        frmProduction_Load(Nothing, Nothing)

    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        frmProduction_Load(sender, e)
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