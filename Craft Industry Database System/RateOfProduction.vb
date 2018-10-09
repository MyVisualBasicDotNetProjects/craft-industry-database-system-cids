Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Imports Craft_Industry_Database.frmUsers

Public Class frmRateOfProduction
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

        objDataAdapter = New SqlDataAdapter("SELECT * FROM tblRateOfProduction ORDER BY formId", connectionString)
        ' Initialize a new instance of the DataSet object...
        objDataSet = New DataSet()
        ' Fill the DataSet object with data...
        objDataAdapter.Fill(objDataSet, "rate")
        ' Set the DataView object to the DataSet object...
        objDataView = New DataView(objDataSet.Tables("rate"))
        ' Set our CurrencyManager object to the DataView object...
        objCurrencyManager = CType(Me.BindingContext(objDataView), CurrencyManager)

    End Sub

    Private Sub Clear()

        ' Clear any previous bindings...
        txtRateId.DataBindings.Clear()
        txtMadePD.DataBindings.Clear()
        txtMadePM.DataBindings.Clear()
        txtMadePW.DataBindings.Clear()
        chkExtra.DataBindings.Clear()
        txtExtraPD.DataBindings.Clear()
        txtExtraPM.DataBindings.Clear()
        txtExtraPW.DataBindings.Clear()
        txtRawMaterial.DataBindings.Clear()
        txtFinished.DataBindings.Clear()
        txtFormId.DataBindings.Clear()
        txtTime1.DataBindings.Clear()
        txtTime2.DataBindings.Clear()
        txtTime3.DataBindings.Clear()
        txtTime4.DataBindings.Clear()

    End Sub

    Public Sub validatation(ByVal i As Integer)

        'If txtMadePD.Text = String.Empty Or
        '    txtMadePM.Text = String.Empty Or
        '    txtMadePW.Text = String.Empty Or
        '    txtRawMaterial.Text = String.Empty Or
        '    txtFinished.Text = String.Empty Or
        '    txtTime1.Text = String.Empty Or
        '    txtTime2.Text = String.Empty Or
        '    txtTime3.Text = String.Empty Or
        '    txtTime4.Text = String.Empty Then

        '    MessageBox.Show("Please fill all the required fields.", "Fill Blank Fields", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    Exit Sub
        'End If

        'If chkExtra.Checked = True Then
        '    If txtExtraPD.Text = String.Empty Or
        '        txtExtraPM.Text = String.Empty Or
        '        txtExtraPW.Text = String.Empty Then
        '        MessageBox.Show("Please fill all the required fields.", "Fill Blank Fields", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '        Exit Sub
        '    End If
        'End If

        If IsNumeric(txtRateId.Text) And i = 1 Then
            Call UpdateForm(Nothing, Nothing)

        Else
            Call Save(Nothing, Nothing)
            btnSave.Enabled = False
            btnUpdate.Enabled = True
        End If

    End Sub

    Private Sub BindFields()

        Clear()

        ' Add new bindings to the DataView object...
        txtRateId.DataBindings.Add("Text", objDataView, "rateId")
        txtMadePD.DataBindings.Add("Text", objDataView, "madePerDay")
        txtMadePM.DataBindings.Add("Text", objDataView, "madePerMonth")
        txtMadePW.DataBindings.Add("Text", objDataView, "madePerWeek")

        chkExtra.DataBindings.Add("Checked", objDataView, "extraProduction")
        txtExtraPD.DataBindings.Add("Text", objDataView, "extraPerDay")
        txtExtraPM.DataBindings.Add("Text", objDataView, "extraPerMonth")
        txtExtraPW.DataBindings.Add("Text", objDataView, "extraPerWeek")

        txtRawMaterial.DataBindings.Add("Text", objDataView, "stockRaw")
        txtFinished.DataBindings.Add("Text", objDataView, "stockFinished")
        txtFormId.DataBindings.Add("Text", objDataView, "formId")

        txtTime1.DataBindings.Add("Text", objDataView, "timeObj1")
        txtTime2.DataBindings.Add("Text", objDataView, "timeObj2")
        txtTime3.DataBindings.Add("Text", objDataView, "timeObj3")
        txtTime4.DataBindings.Add("Text", objDataView, "timeObj4")

        chkExtra_CheckedChanged(Nothing, Nothing)

    End Sub

    Private Sub ShowPosition()

        ' Display the current position and the number of records
        txtPosition.Text = objCurrencyManager.Position + 1 & " of " & objCurrencyManager.Count()

    End Sub

    Private Sub frmRateOfProduction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If user = True Then
            btnNew.Enabled = False
            btnDelete.Enabled = False
            btnSave.Enabled = False
            btnUpdate.Enabled = False
        End If

        ' Fill the DataSet and bind the fields...
        FillDataSetAndView()
        BindFields()
        'chkExtra.Checked = False
        'GroupBox5.Enabled = False

        ' Show the current record position...
        ShowPosition()
        mover()

    End Sub

    Private Sub Save(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim formId As String = frmForm.formId

        Dim extra As Boolean = False

        If chkExtra.Checked = True Then
            extra = True
        Else
            extra = False
        End If


        Using myConnection As SqlConnection = New SqlConnection(Me.connectionString)

            myConnection.Open()

            Using cmd As SqlCommand = myConnection.CreateCommand

                cmd.CommandType = CommandType.Text
                cmd.CommandText = "INSERT INTO tblRateOfProduction (madePerDay, madePerWeek, madePerMonth, timeObj1, timeObj2, timeObj3, timeObj4, stockRaw, stockFinished, extraProduction, extraPerDay, extraPerWeek, extraPerMonth, formId) " & _
                                  "VALUES (@madePerDay, @madePerWeek, @madePerMonth, @timeObj1, @timeObj2, @timeObj3, @timeObj4, @stockRaw, @stockFinished, @extraProduction, @extraPerDay, @extraPerWeek, @extraPerMonth, @formId)"

                cmd.Parameters.Add(New SqlParameter("@madePerDay", txtMadePD.Text))
                cmd.Parameters.Add(New SqlParameter("@madePerWeek", txtMadePW.Text))
                cmd.Parameters.Add(New SqlParameter("@madePerMonth", txtMadePM.Text))
                cmd.Parameters.Add(New SqlParameter("@timeObj1", txtTime1.Text))
                cmd.Parameters.Add(New SqlParameter("@timeObj2", txtTime2.Text))
                cmd.Parameters.Add(New SqlParameter("@timeObj3", txtTime3.Text))
                cmd.Parameters.Add(New SqlParameter("@timeObj4", txtTime4.Text))
                cmd.Parameters.Add(New SqlParameter("@stockRaw", txtRawMaterial.Text))
                cmd.Parameters.Add(New SqlParameter("@stockFinished", txtFinished.Text))
                cmd.Parameters.Add(New SqlParameter("@extraProduction", extra))
                cmd.Parameters.Add(New SqlParameter("@extraPerDay", txtExtraPD.Text))
                cmd.Parameters.Add(New SqlParameter("@extraPerWeek", txtExtraPW.Text))
                cmd.Parameters.Add(New SqlParameter("@extraPerMonth", txtExtraPM.Text))
                cmd.Parameters.Add(New SqlParameter("@formId", formId2))

                Try
                    cmd.ExecuteNonQuery()
                    Message.Text = "The data is Inserted Successfully."
                Catch ex As SqlException
                    MessageBox.Show(ex.Message)
                End Try

            End Using

        End Using

        Call frmRateOfProduction_Load(Nothing, Nothing)

    End Sub

    Private Sub UpdateForm(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim formId As String = frmForm.formId

        Dim extra As Boolean = False

        If chkExtra.Checked Then
            extra = True
        Else
            extra = False
        End If


        Using myConnection As SqlConnection = New SqlConnection(Me.connectionString)

            myConnection.Open()

            Using cmd As SqlCommand = myConnection.CreateCommand

                cmd.CommandType = CommandType.Text
                cmd.CommandText = "UPDATE tblRateOfProduction SET madePerDay=@madePerDay, madePerWeek=@madePerWeek, madePerMonth=@madePerMonth, timeObj1=@timeObj1, timeObj2=@timeObj2, timeObj3=@timeObj3, timeObj4=@timeObj4, stockRaw=@stockRaw, stockFinished=@stockFinished, extraProduction=@extraProduction, extraPerDay=@extraPerDay, extraPerWeek=@extraPerWeek, extraPerMonth=@extraPerMonth, formId=@formId " & _
                                  "WHERE rateId = @rateId;"

                cmd.Parameters.Add(New SqlParameter("@rateId", txtRateId.Text))
                cmd.Parameters.Add(New SqlParameter("@madePerDay", txtMadePD.Text))
                cmd.Parameters.Add(New SqlParameter("@madePerWeek", txtMadePW.Text))
                cmd.Parameters.Add(New SqlParameter("@madePerMonth", txtMadePM.Text))
                cmd.Parameters.Add(New SqlParameter("@timeObj1", txtTime1.Text))
                cmd.Parameters.Add(New SqlParameter("@timeObj2", txtTime2.Text))
                cmd.Parameters.Add(New SqlParameter("@timeObj3", txtTime3.Text))
                cmd.Parameters.Add(New SqlParameter("@timeObj4", txtTime4.Text))
                cmd.Parameters.Add(New SqlParameter("@stockRaw", txtRawMaterial.Text))
                cmd.Parameters.Add(New SqlParameter("@stockFinished", txtFinished.Text))
                cmd.Parameters.Add(New SqlParameter("@extraProduction", extra))
                cmd.Parameters.Add(New SqlParameter("@extraPerDay", txtExtraPD.Text))
                cmd.Parameters.Add(New SqlParameter("@extraPerWeek", txtExtraPW.Text))
                cmd.Parameters.Add(New SqlParameter("@extraPerMonth", txtExtraPM.Text))
                cmd.Parameters.Add(New SqlParameter("@formId", txtFormId.Text))

                Try
                    cmd.ExecuteNonQuery()
                    message.Text = "The data is Updated Successfully."
                Catch ex As SqlException
                    MessageBox.Show(ex.Message)
                End Try

            End Using

        End Using

        Call frmRateOfProduction_Load(Nothing, Nothing)

    End Sub

    Private Sub Delete(ByVal deleteId As Integer)

        Using myConnection As SqlConnection = New SqlConnection(Me.connectionString)

            myConnection.Open()

            Using cmd As SqlCommand = myConnection.CreateCommand

                cmd.CommandType = CommandType.Text
                cmd.CommandText = "DELETE FROM tblRateOfProduction " & _
                                  "WHERE rateId = '" & deleteId & "'"

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

        Dim form As New frmManagement
        form.MdiParent = mdiHome
        frmManagement.formId2 = frmRateOfProduction.formId2
        frmManagement.position = position
        form.Show()
        Me.Close()

    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click

        Dim form As New frmSupply
        form.MdiParent = mdiHome
        form.Show()
        Me.Close()

    End Sub

    Private Sub chkExtra_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkExtra.CheckedChanged

        If chkExtra.Checked = True Then

            GroupBox5.Enabled = True

        Else

            GroupBox5.Enabled = False

        End If

    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        txtFormId.ReadOnly = True
        ' Clear any previous bindings...
        Clear()

        btnSave.Enabled = True
        btnUpdate.Enabled = False

        txtRateId.Text = String.Empty
        txtMadePD.Text = String.Empty
        txtMadePM.Text = String.Empty
        txtMadePW.Text = String.Empty
        chkExtra.Checked = False
        txtExtraPD.Text = String.Empty
        txtExtraPM.Text = String.Empty
        txtExtraPW.Text = String.Empty
        txtRawMaterial.Text = String.Empty
        txtFinished.Text = String.Empty
        txtFormId.Text = String.Empty
        txtTime1.Text = String.Empty
        txtTime2.Text = String.Empty
        txtTime3.Text = String.Empty
        txtTime4.Text = String.Empty
        message.Text = "Ready."
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        validatation(0)
        txtFormId.ReadOnly = True
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        If (MessageBox.Show("Are you sure you want to delete this data?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) = True Then

            If txtRateId.Text = "" Then
                MessageBox.Show("Can not delete an empty data.", "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim selectedId As Integer = txtRateId.Text
                Delete(selectedId)
            End If

        End If

        frmRateOfProduction_Load(Nothing, Nothing)

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
        frmRateOfProduction_Load(sender, e)
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