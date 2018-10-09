Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Imports Craft_Industry_Database.frmUsers

Public Class frmDefinition
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

        objDataAdapter = New SqlDataAdapter("SELECT * FROM tblDefinition ORDER BY formId", connectionString)
        ' Initialize a new instance of the DataSet object...
        objDataSet = New DataSet()
        ' Fill the DataSet object with data...
        objDataAdapter.Fill(objDataSet, "definition")
        ' Set the DataView object to the DataSet object...
        objDataView = New DataView(objDataSet.Tables("definition"))
        ' Set our CurrencyManager object to the DataView object...
        objCurrencyManager = CType(Me.BindingContext(objDataView), CurrencyManager)

    End Sub

    Private Sub Clear()

        ' Clear any previous bindings...
        txtDefinitionId.DataBindings.Clear()
        txtExper.DataBindings.Clear()
        txtObjectsMade.DataBindings.Clear()
        cboActivity.DataBindings.Clear()
        txtRawMaterialUsed.DataBindings.Clear()
        cboTypeOfProduct.DataBindings.Clear()
        txtFormId.DataBindings.Clear()
        txtFamily.DataBindings.Clear()
        txtApprentice.DataBindings.Clear()
        txtEmployees.DataBindings.Clear()
        dtpTrain1.DataBindings.Clear()
        txtLength.DataBindings.Clear()
        txtTrainedBy.DataBindings.Clear()
        txtPlace.DataBindings.Clear()
        dtpTrain2.DataBindings.Clear()
        txtLength2.DataBindings.Clear()
        txtTrainedBy2.DataBindings.Clear()
        txtPlace2.DataBindings.Clear()


    End Sub

    Public Sub validatation(ByVal i As Integer)

        If txtExper.Text = String.Empty Or
            txtObjectsMade.Text = String.Empty Or
            cboActivity.Text = String.Empty Or
            txtRawMaterialUsed.Text = String.Empty Or
            cboTypeOfProduct.Text = String.Empty Or
            txtFamily.Text = String.Empty Or
            txtApprentice.Text = String.Empty Or
            txtEmployees.Text = String.Empty Then

            MessageBox.Show("Please fill all the required fields.", "Fill Blank Fields", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf IsNumeric(txtObjectsMade.Text) Or IsNumeric(txtRawMaterialUsed.Text) Or IsNumeric(cboTypeOfProduct.Text) Or
             IsNumeric(txtTrainedBy.Text) Or IsNumeric(txtPlace.Text) Or IsNumeric(txtTrainedBy2.Text) Or IsNumeric(txtPlace2.Text) Then
            MessageBox.Show("Objects made, Raw material used, type of product, trained by and place can not be numeric.", "String Expected", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If IsNumeric(txtDefinitionId.Text) Then
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
        txtDefinitionId.DataBindings.Add("Text", objDataView, "definitionId")
        txtExper.DataBindings.Add("Text", objDataView, "experience")
        txtObjectsMade.DataBindings.Add("Text", objDataView, "objectsMade")
        txtRawMaterialUsed.DataBindings.Add("Text", objDataView, "rawMaterialsUsed")
        txtFormId.DataBindings.Add("Text", objDataView, "formId")

        txtFamily.DataBindings.Add("Text", objDataView, "familyHelp")
        txtApprentice.DataBindings.Add("Text", objDataView, "apprenticeHelp")
        txtEmployees.DataBindings.Add("Text", objDataView, "employeeHelp")

        dtpTrain1.DataBindings.Add("Text", objDataView, "iDate")
        txtLength.DataBindings.Add("Text", objDataView, "iLength")
        txtTrainedBy.DataBindings.Add("Text", objDataView, "iResponsible")
        txtPlace.DataBindings.Add("Text", objDataView, "iPlace")

        dtpTrain2.DataBindings.Add("Text", objDataView, "laDate")
        txtLength2.DataBindings.Add("Text", objDataView, "laLength")
        txtTrainedBy2.DataBindings.Add("Text", objDataView, "laResponsible")
        txtPlace2.DataBindings.Add("Text", objDataView, "laPlace")

        cboActivity.DataBindings.Add("SelectedItem", objDataView, "activity")
        cboTypeOfProduct.DataBindings.Add("SelectedItem", objDataView, "typeOfProduct")

    End Sub

    Private Sub ShowPosition()

        ' Display the current position and the number of records
        txtPosition.Text = objCurrencyManager.Position + 1 & " of " & objCurrencyManager.Count()

    End Sub

    Private Sub frmDefinition_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If user = True Then
            btnNew.Enabled = False
            btnDelete.Enabled = False
            btnSave.Enabled = False
            btnUpdate.Enabled = False
        End If

        cboActivity.SelectedIndex = 0

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

                If txtLength.Text <> String.Empty And txtTrainedBy.Text <> String.Empty And txtPlace.Text <> String.Empty Then

                    If txtLength2.Text <> String.Empty And txtTrainedBy2.Text <> String.Empty And txtPlace2.Text <> String.Empty Then

                        cmd.CommandText = "INSERT INTO tblDefinition (experience, iDate, iPlace, iLength, iResponsible, laDate, laPlace, laLength, laResponsible, objectsMade, rawMaterialsUsed, typeOfProduct, activity, familyHelp, apprenticeHelp, employeeHelp, formId) " & _
                                          "VALUES (@experience, @iDate, @iPlace, @iLength, @iResponsible, @laDate, @laPlace, @laLength, @laResponsible, @objectsMade, @rawMaterialsUsed, @typeOfProduct, @activity, @familyHelp, @apprenticeHelp, @employeeHelp, @formId)"

                        cmd.Parameters.Add(New SqlParameter("@laDate", dtpTrain2.Value))
                        cmd.Parameters.Add(New SqlParameter("@laPlace", txtPlace2.Text))
                        cmd.Parameters.Add(New SqlParameter("@laLength", txtLength2.Text))
                        cmd.Parameters.Add(New SqlParameter("@laResponsible", txtTrainedBy2.Text))

                        cmd.Parameters.Add(New SqlParameter("@iDate", dtpTrain1.Value))
                        cmd.Parameters.Add(New SqlParameter("@iPlace", txtPlace.Text))
                        cmd.Parameters.Add(New SqlParameter("@iLength", txtLength.Text))
                        cmd.Parameters.Add(New SqlParameter("@iResponsible", txtTrainedBy.Text))
                    Else

                        cmd.CommandText = "INSERT INTO tblDefinition (experience, iDate, iPlace, iLength, iResponsible, objectsMade, rawMaterialsUsed, typeOfProduct, activity, familyHelp, apprenticeHelp, employeeHelp, formId) " & _
                                          "VALUES (@experience, @iDate, @iPlace, @iLength, @iResponsible, @objectsMade, @rawMaterialsUsed, @typeOfProduct, @activity, @familyHelp, @apprenticeHelp, @employeeHelp, @formId)"

                        cmd.Parameters.Add(New SqlParameter("@iDate", dtpTrain1.Value))
                        cmd.Parameters.Add(New SqlParameter("@iPlace", txtPlace.Text))
                        cmd.Parameters.Add(New SqlParameter("@iLength", txtLength.Text))
                        cmd.Parameters.Add(New SqlParameter("@iResponsible", txtTrainedBy.Text))

                    End If
                Else

                    cmd.CommandText = "INSERT INTO tblDefinition (experience, objectsMade, rawMaterialsUsed, typeOfProduct, activity, familyHelp, apprenticeHelp, employeeHelp, formId) " & _
                                      "VALUES (@experience, @objectsMade, @rawMaterialsUsed, @typeOfProduct, @activity, @familyHelp, @apprenticeHelp, @employeeHelp, @formId)"

                End If

                cmd.Parameters.Add(New SqlParameter("@experience", txtExper.Text))

                cmd.Parameters.Add(New SqlParameter("@objectsMade", txtObjectsMade.Text))
                cmd.Parameters.Add(New SqlParameter("@rawMaterialsUsed", txtRawMaterialUsed.Text))
                cmd.Parameters.Add(New SqlParameter("@typeOfProduct", cboTypeOfProduct.Text))
                cmd.Parameters.Add(New SqlParameter("@activity", cboActivity.Text))
                cmd.Parameters.Add(New SqlParameter("@familyHelp", txtFamily.Text))
                cmd.Parameters.Add(New SqlParameter("@apprenticeHelp", txtApprentice.Text))
                cmd.Parameters.Add(New SqlParameter("@employeeHelp", txtEmployees.Text))
                cmd.Parameters.Add(New SqlParameter("@formId", formId2))

                Try
                    cmd.ExecuteNonQuery()
                    message.Text = "The data is Inserted Successfully."
                Catch ex As SqlException
                    MessageBox.Show(ex.Message)
                End Try


            End Using

        End Using

        Call frmDefinition_Load(Nothing, Nothing)

    End Sub

    Private Sub UpdateForm(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim formId As String = frmForm.formId

        Using myConnection As SqlConnection = New SqlConnection(Me.connectionString)

            myConnection.Open()

            Using cmd As SqlCommand = myConnection.CreateCommand

                cmd.CommandType = CommandType.Text
                cmd.CommandText = "UPDATE tblDefinition  SET experience=@experience, iDate=@iDate, iPlace=@iPlace, iLength=@iLength, iResponsible=@iResponsible, laDate=@laDate, laPlace=@laPlace, laLength=@laLength, laResponsible=@laResponsible, objectsMade=@objectsMade, rawMaterialsUsed=@rawMaterialsUsed, typeOfProduct=@typeOfProduct, activity= @activity, familyHelp= @familyHelp, apprenticeHelp=@apprenticeHelp, employeeHelp= @employeeHelp, formId= @formId " & _
                                  "WHERE definitionId = @definition"

                cmd.Parameters.Add(New SqlParameter("@definition", txtDefinitionId.Text))
                cmd.Parameters.Add(New SqlParameter("@experience", txtExper.Text))
                cmd.Parameters.Add(New SqlParameter("@iDate", dtpTrain1.Value))
                cmd.Parameters.Add(New SqlParameter("@iPlace", txtPlace.Text))
                cmd.Parameters.Add(New SqlParameter("@iLength", txtLength.Text))
                cmd.Parameters.Add(New SqlParameter("@iResponsible", txtTrainedBy.Text))
                cmd.Parameters.Add(New SqlParameter("@laDate", dtpTrain2.Value))
                cmd.Parameters.Add(New SqlParameter("@laPlace", txtPlace2.Text))
                cmd.Parameters.Add(New SqlParameter("@laLength", txtLength2.Text))
                cmd.Parameters.Add(New SqlParameter("@laResponsible", txtTrainedBy2.Text))
                cmd.Parameters.Add(New SqlParameter("@objectsMade", txtObjectsMade.Text))
                cmd.Parameters.Add(New SqlParameter("@rawMaterialsUsed", txtRawMaterialUsed.Text))
                cmd.Parameters.Add(New SqlParameter("@typeOfProduct", cboTypeOfProduct.Text))
                cmd.Parameters.Add(New SqlParameter("@activity", cboActivity.Text))
                cmd.Parameters.Add(New SqlParameter("@familyHelp", txtFamily.Text))
                cmd.Parameters.Add(New SqlParameter("@apprenticeHelp", txtApprentice.Text))
                cmd.Parameters.Add(New SqlParameter("@employeeHelp", txtEmployees.Text))
                cmd.Parameters.Add(New SqlParameter("@formId", txtFormId.Text))

                Try
                    cmd.ExecuteNonQuery()
                    message.Text = "The data is Updated Successfully."
                Catch ex As SqlException
                    MessageBox.Show(ex.Message)
                End Try

            End Using

        End Using

        Call frmDefinition_Load(Nothing, Nothing)

    End Sub

    Private Sub Delete(ByVal deleteId As Integer)

        Using myConnection As SqlConnection = New SqlConnection(Me.connectionString)

            myConnection.Open()

            Using cmd As SqlCommand = myConnection.CreateCommand

                cmd.CommandType = CommandType.Text
                cmd.CommandText = "DELETE FROM tblDefinition " & _
                                  "WHERE definitionId = '" & deleteId & "'"

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

        Dim form As New frmWorkshop
        form.MdiParent = mdiHome
        frmWorkshop.formId2 = frmDefinition.formId2
        frmWorkshop.position = position
        form.Show()
        Me.Close()

    End Sub

    Private Sub txtFamily_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFamily.KeyPress

        If Not IsNumeric(txtFamily.Text) Then
            txtFamily.Text = vbBack
        End If

        If Not IsNumeric(txtFamily.Text) Then
            Beep()
        End If

    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click

        Dim form As New frmCraftWorker
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

        txtDefinitionId.Text = String.Empty
        txtExper.Text = String.Empty
        txtObjectsMade.Text = String.Empty
        cboActivity.SelectedIndex = 0
        cboTypeOfProduct.SelectedIndex = 0
        txtRawMaterialUsed.Text = String.Empty
        txtFormId.Text = String.Empty
        txtFamily.Text = String.Empty
        txtApprentice.Text = String.Empty
        txtEmployees.Text = String.Empty
        dtpTrain1.Value = Now.Date
        txtLength.Text = String.Empty
        txtTrainedBy.Text = String.Empty
        txtPlace.Text = String.Empty
        dtpTrain2.Value = Now.Date
        txtLength2.Text = String.Empty
        txtTrainedBy2.Text = String.Empty
        txtPlace2.Text = String.Empty

        message.Text = "Ready."
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        validatation(0)
        txtFormId.ReadOnly = False
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        If (MessageBox.Show("Are you sure you want to delete this data?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) = True Then

            If txtDefinitionId.Text = "" Then
                MessageBox.Show("Can not delete an empty data.", "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim selectedId As Integer = txtDefinitionId.Text
                Delete(selectedId)
            End If

        End If

        frmDefinition_Load(Nothing, Nothing)

    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        frmDefinition_Load(sender, e)
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