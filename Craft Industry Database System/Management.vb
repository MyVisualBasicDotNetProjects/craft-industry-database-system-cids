Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Imports Craft_Industry_Database.frmUsers

Public Class frmManagement
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

        objDataAdapter = New SqlDataAdapter("SELECT * FROM tblManagement ORDER BY formId", connectionString)
        ' Initialize a new instance of the DataSet object...
        objDataSet = New DataSet()
        ' Fill the DataSet object with data...
        objDataAdapter.Fill(objDataSet, "management")
        ' Set the DataView object to the DataSet object...
        objDataView = New DataView(objDataSet.Tables("management"))
        ' Set our CurrencyManager object to the DataView object...
        objCurrencyManager = CType(Me.BindingContext(objDataView), CurrencyManager)

    End Sub

    Private Sub Clear()

        ' Clear any previous bindings...
        txtManagementId.DataBindings.Clear()
        cboFinancing.DataBindings.Clear()
        chkCustomerCredit.DataBindings.Clear()
        chkSupplierCredit.DataBindings.Clear()
        chkOutside.DataBindings.Clear()
        txtInterest.DataBindings.Clear()
        cboSource.DataBindings.Clear()
        chkDebt.DataBindings.Clear()
        txtDebtTO.DataBindings.Clear()
        chkAccount.DataBindings.Clear()
        txtKind.DataBindings.Clear()

        chkBank.DataBindings.Clear()
        chkCheque.DataBindings.Clear()
        txtCost10.DataBindings.Clear()
        txtCost50.DataBindings.Clear()
        txtCost100.DataBindings.Clear()
        txtExp1.DataBindings.Clear()
        txtExp2.DataBindings.Clear()
        txtExp3.DataBindings.Clear()
        txtExp4.DataBindings.Clear()
        txtCost.DataBindings.Clear()
        txtPrice.DataBindings.Clear()
        txtFormId.DataBindings.Clear()

        txtTurnOverPW.DataBindings.Clear()
        txtTurnOverPM.DataBindings.Clear()

        Hid2.DataBindings.Clear()

    End Sub

    Public Sub validatation(ByVal i As Integer)

        If cboFinancing.Text = String.Empty Or
            txtCost.Text = String.Empty Or
            txtPrice.Text = String.Empty Then

            MessageBox.Show("Please fill all the required fields.", "Fill Blank Fields", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If chkOutside.Checked = True Then
            If txtInterest.Text = String.Empty Or cboSource.Text = String.Empty Then
                MessageBox.Show("Please fill all the required fields.", "Fill Blank Fields", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
        End If

        'If chkDebt.Checked Then
        '    If txtDebtTO.Text = String.Empty Then
        '        MessageBox.Show("Please fill all the required fields.", "Fill Blank Fields", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '        Exit Sub
        '    End If
        'End If

        If chkAccount.Checked Then
            If txtKind.Text = String.Empty Then
                MessageBox.Show("Please fill all the required fields.", "Fill Blank Fields", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            ElseIf IsNumeric(txtKind.Text) Then
                MessageBox.Show("Kind of Account can not be numeric.", "String Expected", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

        If IsNumeric(txtManagementId.Text) And i = 1 Then
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
        txtManagementId.DataBindings.Add("Text", objDataView, "managementId")

        chkCustomerCredit.DataBindings.Add("Checked", objDataView, "customerCredit")
        chkSupplierCredit.DataBindings.Add("Checked", objDataView, "supplierCredit")
        chkOutside.DataBindings.Add("Checked", objDataView, "outsideFinancing")
        txtInterest.DataBindings.Add("Text", objDataView, "rateOfInterest")

        chkDebt.DataBindings.Add("Checked", objDataView, "debts")
        txtDebtTO.DataBindings.Add("Text", objDataView, "debtsTurnOver")
        chkAccount.DataBindings.Add("Checked", objDataView, "keepAccount")
        txtKind.DataBindings.Add("Text", objDataView, "kindOfAccount")

        chkBank.DataBindings.Add("Checked", objDataView, "bankAccount")
        chkCheque.DataBindings.Add("Checked", objDataView, "chequeBook")
        txtCost10.DataBindings.Add("Text", objDataView, "costFor10")
        txtCost50.DataBindings.Add("Text", objDataView, "costFor50")
        txtCost100.DataBindings.Add("Text", objDataView, "costFor100")

        txtExp1.DataBindings.Add("Text", objDataView, "otherExpenditure1")
        txtExp2.DataBindings.Add("Text", objDataView, "otherExpenditure2")
        txtExp3.DataBindings.Add("Text", objDataView, "otherExpenditure3")
        txtExp4.DataBindings.Add("Text", objDataView, "otherExpenditure4")
        txtTurnOverPW.DataBindings.Add("Text", objDataView, "turnOverPerWeek")
        txtTurnOverPM.DataBindings.Add("Text", objDataView, "turnOverPerMonth")

        txtCost.DataBindings.Add("Text", objDataView, "cost")
        txtPrice.DataBindings.Add("Text", objDataView, "sellingPrice")
        txtFormId.DataBindings.Add("Text", objDataView, "formId")

        cboFinancing.DataBindings.Add("SelectedItem", objDataView, "wayOfFinancing")
        cboSource.DataBindings.Add("SelectedItem", objDataView, "source")
     
        Hid2.DataBindings.Clear()
        Hid2.DataBindings.Add("Text", objDataView, "priceVaryQuantity")

        If Hid2.Text = "True" Then
            rdbYes.Checked = True
            rdbNo.Checked = False
        ElseIf Hid2.Text = "False" Then
            rdbYes.Checked = False
            rdbNo.Checked = True
        End If

        Hid2.DataBindings.Clear()
        Hid2.DataBindings.Add("Text", objDataView, "priceVaryCustomer")

        If Hid2.Text = "True" Then
            rdbYes2.Checked = True
            rdbNo2.Checked = False
        ElseIf Hid2.Text = "False" Then
            rdbYes2.Checked = False
            rdbNo2.Checked = True
        End If

    End Sub

    Private Sub ShowPosition()

        ' Display the current position and the number of records
        txtPosition.Text = objCurrencyManager.Position + 1 & " of " & objCurrencyManager.Count()

    End Sub

    Private Sub frmManagement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If user = True Then
            btnNew.Enabled = False
            btnDelete.Enabled = False
            btnSave.Enabled = False
            btnUpdate.Enabled = False
        End If

        cboFinancing.SelectedIndex = 0
        cboSource.SelectedIndex = 0

        ' Fill the DataSet and bind the fields...
        FillDataSetAndView()
        BindFields()

        Hid2.Visible = False

        ' Show the current record position...
        ShowPosition()
        mover()
    End Sub

    Private Sub Save(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim formId As String = frmForm.formId

        Dim customer, supplier, outiside, debts, account, bank, cheque, vpquantity, vpcustomer As Boolean

        If chkCustomerCredit.Checked Then
            customer = True
        Else
            customer = False
        End If

        If chkSupplierCredit.Checked Then
            supplier = True
        Else
            supplier = False
        End If

        If chkOutside.Checked Then
            outiside = True
        Else
            outiside = False
        End If

        If chkDebt.Checked Then
            debts = True
        Else
            debts = False
        End If

        If chkAccount.Checked Then
            account = True
        Else
            account = False
        End If

        If chkBank.Checked Then
            bank = True
        Else
            bank = False
        End If

        If chkCheque.Checked Then
            cheque = True
        Else
            cheque = False
        End If

        If rdbYes.Checked Then
            vpquantity = True
        ElseIf rdbNo.Checked = True Then
            vpquantity = False
        End If

        If rdbYes2.Checked Then
            vpcustomer = True
        ElseIf rdbNo2.Checked Then
            vpcustomer = False
        End If

        Using myConnection As SqlConnection = New SqlConnection(Me.connectionString)

            myConnection.Open()

            Using cmd As SqlCommand = myConnection.CreateCommand

                cmd.CommandType = CommandType.Text
                cmd.CommandText = "INSERT INTO tblManagement (costFor10, costFor50, costFor100, otherExpenditure1, otherExpenditure2, otherExpenditure3, otherExpenditure4, cost, sellingPrice, priceVaryQuantity, priceVaryCustomer, turnOverPerWeek, turnOverPerMonth, customerCredit, supplierCredit, wayOfFinancing, outsideFinancing, rateOfInterest, source, debts, debtsTurnOver, keepAccount, kindOfAccount, bankAccount, chequeBook, formId) " & _
                                  "VALUES (@costFor10, @costFor50, @costFor100, @otherExpenditure1, @otherExpenditure2, @otherExpenditure3, @otherExpenditure4, @cost, @sellingPrice, @priceVaryQuantity, @priceVaryCustomer, @turnOverPerWeek, @turnOverPerMonth, @customerCredit, @supplierCredit, @wayOfFinancing, @outsideFinancing, @rateOfInterest, @source, @debts, @debtsTurnOver, @keepAccount, @kindOfAccount, @bankAccount, @chequeBook, @formId)"

                cmd.Parameters.Add(New SqlParameter("@costFor10", txtCost10.Text))
                cmd.Parameters.Add(New SqlParameter("@costFor50", txtCost50.Text))
                cmd.Parameters.Add(New SqlParameter("@costFor100", txtCost100.Text))
                cmd.Parameters.Add(New SqlParameter("@otherExpenditure1", txtExp1.Text))
                cmd.Parameters.Add(New SqlParameter("@otherExpenditure2", txtExp2.Text))
                cmd.Parameters.Add(New SqlParameter("@otherExpenditure3", txtExp3.Text))
                cmd.Parameters.Add(New SqlParameter("@otherExpenditure4", txtExp4.Text))
                cmd.Parameters.Add(New SqlParameter("@cost", txtCost.Text))
                cmd.Parameters.Add(New SqlParameter("@sellingPrice", txtPrice.Text))
                cmd.Parameters.Add(New SqlParameter("@priceVaryQuantity", vpquantity))
                cmd.Parameters.Add(New SqlParameter("@priceVaryCustomer", vpcustomer))
                cmd.Parameters.Add(New SqlParameter("@turnOverPerWeek", txtTurnOverPW.Text))
                cmd.Parameters.Add(New SqlParameter("@turnOverPerMonth", txtTurnOverPM.Text))
                cmd.Parameters.Add(New SqlParameter("@customerCredit", customer))
                cmd.Parameters.Add(New SqlParameter("@supplierCredit", supplier))
                cmd.Parameters.Add(New SqlParameter("@wayOfFinancing", cboFinancing.Text))
                cmd.Parameters.Add(New SqlParameter("@outsideFinancing", outiside))
                cmd.Parameters.Add(New SqlParameter("@rateOfInterest", txtInterest.Text))
                cmd.Parameters.Add(New SqlParameter("@source", cboSource.Text))
                cmd.Parameters.Add(New SqlParameter("@debts", debts))
                cmd.Parameters.Add(New SqlParameter("@debtsTurnOver", txtDebtTO.Text))
                cmd.Parameters.Add(New SqlParameter("@keepAccount", account))
                cmd.Parameters.Add(New SqlParameter("@kindOfAccount", txtKind.Text))
                cmd.Parameters.Add(New SqlParameter("@bankAccount", bank))
                cmd.Parameters.Add(New SqlParameter("@chequeBook", cheque))
                cmd.Parameters.Add(New SqlParameter("@formId", formId2))

                Try
                    cmd.ExecuteNonQuery()
                    Message.Text = "The data is Inserted Successfully."
                Catch ex As SqlException
                    MessageBox.Show(ex.Message)
                End Try

            End Using

        End Using

        Call frmManagement_Load(Nothing, Nothing)

    End Sub

    Private Sub UpdateForm(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim formId As String = frmForm.formId

        Dim customer, supplier, outiside, debts, account, bank, cheque, vpquantity, vpcustomer As Boolean

        If chkCustomerCredit.Checked Then
            customer = True
        Else
            customer = False
        End If

        If chkSupplierCredit.Checked Then
            supplier = True
        Else
            supplier = False
        End If

        If chkOutside.Checked Then
            outiside = True
        Else
            outiside = False
        End If

        If chkDebt.Checked Then
            debts = True
        Else
            debts = False
        End If

        If chkAccount.Checked Then
            account = True
        Else
            account = False
        End If

        If chkBank.Checked Then
            bank = True
        Else
            bank = False
        End If

        If chkCheque.Checked Then
            cheque = True
        Else
            cheque = False
        End If

        If rdbYes.Checked Then
            vpquantity = True
        ElseIf rdbNo.Checked = True Then
            vpquantity = False
        End If

        If rdbYes2.Checked Then
            vpcustomer = True
        ElseIf rdbNo2.Checked Then
            vpcustomer = False
        End If

        Using myConnection As SqlConnection = New SqlConnection(Me.connectionString)

            myConnection.Open()

            Using cmd As SqlCommand = myConnection.CreateCommand

                cmd.CommandType = CommandType.Text
                cmd.CommandText = "UPDATE tblManagement SET costFor10=@costFor10, costFor50=@costFor50, costFor100=@costFor100, otherExpenditure1= @otherExpenditure1, otherExpenditure2= @otherExpenditure2, otherExpenditure3= @otherExpenditure3, otherExpenditure4= @otherExpenditure4, cost=@cost, sellingPrice=@sellingPrice, priceVaryQuantity=@priceVaryQuantity, priceVaryCustomer=@priceVaryCustomer, turnOverPerWeek=@turnOverPerWeek, turnOverPerMonth=@turnOverPerMonth, customerCredit=@customerCredit, supplierCredit=@supplierCredit, wayOfFinancing=@wayOfFinancing, outsideFinancing=@outsideFinancing, rateOfInterest=@rateOfInterest, source=@source, debts=@debts, debtsTurnOver=@debtsTurnOver, keepAccount=@keepAccount, kindOfAccount=@kindOfAccount, bankAccount=@bankAccount, chequeBook=@chequeBook, formId=@formId " & _
                                  "WHERE  managementId = @managementId;"

                cmd.Parameters.Add(New SqlParameter("@managementId", txtManagementId.Text))
                cmd.Parameters.Add(New SqlParameter("@costFor10", txtCost10.Text))
                cmd.Parameters.Add(New SqlParameter("@costFor50", txtCost50.Text))
                cmd.Parameters.Add(New SqlParameter("@costFor100", txtCost100.Text))
                cmd.Parameters.Add(New SqlParameter("@otherExpenditure1", txtExp1.Text))
                cmd.Parameters.Add(New SqlParameter("@otherExpenditure2", txtExp2.Text))
                cmd.Parameters.Add(New SqlParameter("@otherExpenditure3", txtExp3.Text))
                cmd.Parameters.Add(New SqlParameter("@otherExpenditure4", txtExp4.Text))
                cmd.Parameters.Add(New SqlParameter("@cost", txtCost.Text))
                cmd.Parameters.Add(New SqlParameter("@sellingPrice", txtPrice.Text))
                cmd.Parameters.Add(New SqlParameter("@priceVaryQuantity", vpquantity))
                cmd.Parameters.Add(New SqlParameter("@priceVaryCustomer", vpcustomer))
                cmd.Parameters.Add(New SqlParameter("@turnOverPerWeek", txtTurnOverPW.Text))
                cmd.Parameters.Add(New SqlParameter("@turnOverPerMonth", txtTurnOverPM.Text))
                cmd.Parameters.Add(New SqlParameter("@customerCredit", customer))
                cmd.Parameters.Add(New SqlParameter("@supplierCredit", supplier))
                cmd.Parameters.Add(New SqlParameter("@wayOfFinancing", cboFinancing.Text))
                cmd.Parameters.Add(New SqlParameter("@outsideFinancing", outiside))
                cmd.Parameters.Add(New SqlParameter("@rateOfInterest", txtInterest.Text))
                cmd.Parameters.Add(New SqlParameter("@source", cboSource.Text))
                cmd.Parameters.Add(New SqlParameter("@debts", debts))
                cmd.Parameters.Add(New SqlParameter("@debtsTurnOver", txtDebtTO.Text))
                cmd.Parameters.Add(New SqlParameter("@keepAccount", account))
                cmd.Parameters.Add(New SqlParameter("@kindOfAccount", txtKind.Text))
                cmd.Parameters.Add(New SqlParameter("@bankAccount", bank))
                cmd.Parameters.Add(New SqlParameter("@chequeBook", cheque))
                cmd.Parameters.Add(New SqlParameter("@formId", txtFormId.Text))


                Try
                    cmd.ExecuteNonQuery()
                    message.Text = "The data is Updated Successfully."
                Catch ex As SqlException
                    MessageBox.Show(ex.Message)
                End Try

            End Using

        End Using

        Call frmManagement_Load(Nothing, Nothing)

    End Sub

    Private Sub Delete(ByVal deleteId As Integer)

        Using myConnection As SqlConnection = New SqlConnection(Me.connectionString)

            myConnection.Open()

            Using cmd As SqlCommand = myConnection.CreateCommand

                cmd.CommandType = CommandType.Text
                cmd.CommandText = "DELETE FROM tblManagement " & _
                                  "WHERE managementId = '" & deleteId & "'"

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

        Dim form As New frmDistribution
        form.MdiParent = mdiHome
        frmDistribution.formId2 = frmManagement.formId2
        frmDistribution.position = position
        form.Show()
        Me.Close()

    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click

        Dim form As New frmRateOfProduction
        form.MdiParent = mdiHome
        form.Show()
        Me.Close()

    End Sub

    Private Sub chkOutside_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkOutside.CheckedChanged

        If chkOutside.Checked = False Then

            Label4.Enabled = False
            Label5.Enabled = False
            txtInterest.Enabled = False
            cboSource.Enabled = False

        Else

            Label4.Enabled = True
            Label5.Enabled = True
            txtInterest.Enabled = True
            cboSource.Enabled = True

        End If


    End Sub

    Private Sub chkDebt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDebt.CheckedChanged

        If chkDebt.Checked = False Then

            Label15.Enabled = False
            txtDebtTO.Enabled = False

        Else

            Label15.Enabled = True
            txtDebtTO.Enabled = True

        End If

    End Sub

    Private Sub chkAccount_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAccount.CheckedChanged

        If chkAccount.Checked = False Then

            Label3.Enabled = False
            txtKind.Enabled = False

        Else

            Label3.Enabled = True
            txtKind.Enabled = True

        End If

    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        txtFormId.ReadOnly = True
        ' Clear any previous bindings...
        Clear()

        btnSave.Enabled = True
        btnUpdate.Enabled = False

        txtManagementId.Text = String.Empty
        cboFinancing.SelectedIndex = 0
        chkCustomerCredit.Checked = False
        chkSupplierCredit.Checked = False
        chkOutside.Checked = False
        txtInterest.Text = String.Empty
        cboSource.SelectedIndex = 0
        chkDebt.Checked = False
        txtDebtTO.Text = String.Empty
        chkAccount.Checked = False
        txtKind.Text = String.Empty

        chkBank.Checked = False
        chkCheque.Checked = False
        txtCost10.Text = String.Empty
        txtCost50.Text = String.Empty
        txtCost100.Text = String.Empty
        txtExp1.Text = String.Empty
        txtExp2.Text = String.Empty
        txtExp3.Text = String.Empty
        txtExp4.Text = String.Empty
        txtCost.Text = String.Empty
        txtPrice.Text = String.Empty
        txtFormId.Text = String.Empty

        txtTurnOverPW.Text = String.Empty
        txtTurnOverPM.Text = String.Empty

        rdbNo.Checked = True
        rdbNo2.Checked = True

        Hid2.Text = String.Empty
        message.Text = "Ready."
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        validatation(0)
        txtFormId.ReadOnly = True
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        If (MessageBox.Show("Are you sure you want to delete this data?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) = True Then

            If txtManagementId.Text = "" Then
                MessageBox.Show("Can not delete an empty data.", "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim selectedId As Integer = txtManagementId.Text
                Delete(selectedId)
            End If

        End If

        frmManagement_Load(Nothing, Nothing)

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
        frmManagement_Load(sender, e)
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