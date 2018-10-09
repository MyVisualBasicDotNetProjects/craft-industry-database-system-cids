Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Imports Craft_Industry_Database.frmUsers

Public Class frmTax
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

        objDataAdapter = New SqlDataAdapter("SELECT * FROM tblTax ORDER BY formId", connectionString)
        ' Initialize a new instance of the DataSet object...
        objDataSet = New DataSet()
        ' Fill the DataSet object with data...
        objDataAdapter.Fill(objDataSet, "tax")
        ' Set the DataView object to the DataSet object...
        objDataView = New DataView(objDataSet.Tables("tax"))
        ' Set our CurrencyManager object to the DataView object...
        objCurrencyManager = CType(Me.BindingContext(objDataView), CurrencyManager)

    End Sub

    Private Sub Clear()

        ' Clear any previous bindings...
        txtTaxId.DataBindings.Clear()
        chkOfficial.DataBindings.Clear()
        txtPlace.DataBindings.Clear()
        txtBody.DataBindings.Clear()
        txtTaxaton.DataBindings.Clear()
        txtPayment.DataBindings.Clear()
        txtFrequency.DataBindings.Clear()
        txtAmount.DataBindings.Clear()
        txtFormId.DataBindings.Clear()

    End Sub

    Public Sub validatation(ByVal i As Integer)

        If txtPlace.Text = String.Empty Or
            txtBody.Text = String.Empty Or
            txtTaxaton.Text = String.Empty Or
            txtPayment.Text = String.Empty Or
            txtFrequency.Text = String.Empty Or
            txtAmount.Text = String.Empty Then

            MessageBox.Show("Please fill all the required fields.", "Fill Blank Fields", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        ElseIf IsNumeric(txtPlace.Text) Or IsNumeric(txtBody.Text) Or IsNumeric(txtTaxaton.Text) Or IsNumeric(txtPayment.Text) Then
            MessageBox.Show("Place of registration, tax recieving body, method of taxation and payment can not be numeric.", "String Expected", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf IsNumeric(txtTaxId.Text) And i = 1 Then
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
        txtTaxId.DataBindings.Add("Text", objDataView, "taxId")
        chkOfficial.DataBindings.Add("Checked", objDataView, "officialRegistration")
        txtPlace.DataBindings.Add("Text", objDataView, "placeOfRegistration")
        txtBody.DataBindings.Add("Text", objDataView, "name")
        txtTaxaton.DataBindings.Add("Text", objDataView, "methodOfTaxation")
        txtPayment.DataBindings.Add("Text", objDataView, "methodOfPayment")
        txtFrequency.DataBindings.Add("Text", objDataView, "frequency")
        txtAmount.DataBindings.Add("Text", objDataView, "amount")
        txtFormId.DataBindings.Add("Text", objDataView, "formId")

    End Sub

    Private Sub ShowPosition()

        ' Display the current position and the number of records
        txtPosition.Text = objCurrencyManager.Position + 1 & " of " & objCurrencyManager.Count()

    End Sub

    Private Sub frmTax_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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

        Dim off As Boolean = False

        If chkOfficial.Checked Then
            off = True
        Else
            off = False
        End If

        Using myConnection As SqlConnection = New SqlConnection(Me.connectionString)

            myConnection.Open()

            Using cmd As SqlCommand = myConnection.CreateCommand

                cmd.CommandType = CommandType.Text
                cmd.CommandText = "INSERT INTO tblTax (officialRegistration, placeOfRegistration, name, methodOfTaxation, methodOfPayment, frequency, amount, formId) " & _
                                  "VALUES (@officialRegistration, @placeOfRegistration, @name, @methodOfTaxation, @methodOfPayment, @frequency, @amount, @formId)"

                cmd.Parameters.Add(New SqlParameter("@officialRegistration", off))
                cmd.Parameters.Add(New SqlParameter("@placeOfRegistration", txtPlace.Text))
                cmd.Parameters.Add(New SqlParameter("@name", txtBody.Text))
                cmd.Parameters.Add(New SqlParameter("@methodOfTaxation", txtTaxaton.Text))
                cmd.Parameters.Add(New SqlParameter("@methodOfPayment", txtPlace.Text))
                cmd.Parameters.Add(New SqlParameter("@frequency", txtFrequency.Text))
                cmd.Parameters.Add(New SqlParameter("@amount", txtAmount.Text))
                cmd.Parameters.Add(New SqlParameter("@formId", formId2))

                Try
                    cmd.ExecuteNonQuery()
                    message.Text = "The data is Inserted Successfully."
                Catch ex As SqlException
                    MessageBox.Show(ex.Message)
                End Try

            End Using

        End Using

        Call frmTax_Load(Nothing, Nothing)

    End Sub

    Private Sub UpdateForm(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim formId As String = frmForm.formId

        Dim off As Boolean = False

        If chkOfficial.Checked Then
            off = True
        Else
            off = False
        End If

        Using myConnection As SqlConnection = New SqlConnection(Me.connectionString)

            myConnection.Open()

            Using cmd As SqlCommand = myConnection.CreateCommand

                cmd.CommandType = CommandType.Text
                cmd.CommandText = "UPDATE tblTax SET officialRegistration=@officialRegistration, placeOfRegistration=@placeOfRegistration, name= @name, methodOfTaxation=@methodOfTaxation, methodOfPayment=@methodOfPayment, frequency=@frequency, amount=@amount, formId=@formId " & _
                                  "WHERE taxId= @taxId;"

                cmd.Parameters.Add(New SqlParameter("@taxId", txtTaxId.Text))
                cmd.Parameters.Add(New SqlParameter("@officialRegistration", off))
                cmd.Parameters.Add(New SqlParameter("@placeOfRegistration", txtPlace.Text))
                cmd.Parameters.Add(New SqlParameter("@name", txtBody.Text))
                cmd.Parameters.Add(New SqlParameter("@methodOfTaxation", txtTaxaton.Text))
                cmd.Parameters.Add(New SqlParameter("@methodOfPayment", txtPlace.Text))
                cmd.Parameters.Add(New SqlParameter("@frequency", txtFrequency.Text))
                cmd.Parameters.Add(New SqlParameter("@amount", txtAmount.Text))
                cmd.Parameters.Add(New SqlParameter("@formId", txtFormId.Text))

                Try
                    cmd.ExecuteNonQuery()
                    message.Text = "The data is Updated Successfully."
                Catch ex As SqlException
                    MessageBox.Show(ex.Message)
                End Try

            End Using

        End Using

        Call frmTax_Load(Nothing, Nothing)

    End Sub

    Private Sub Delete(ByVal deleteId As Integer)

        Using myConnection As SqlConnection = New SqlConnection(Me.connectionString)

            myConnection.Open()

            Using cmd As SqlCommand = myConnection.CreateCommand

                cmd.CommandType = CommandType.Text
                cmd.CommandText = "DELETE FROM tblTax " & _
                                  "WHERE taxId = '" & deleteId & "'"

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

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click

        Dim form As New frmCompetition
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

        txtTaxId.Text = String.Empty
        chkOfficial.Checked = False
        txtPlace.Text = String.Empty
        txtBody.Text = String.Empty
        txtTaxaton.Text = String.Empty
        txtPayment.Text = String.Empty
        txtFrequency.Text = String.Empty
        txtAmount.Text = String.Empty
        txtFormId.Text = String.Empty
        message.Text = "Ready."
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        validatation(0)
        txtFormId.ReadOnly = True
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If (MessageBox.Show("Are you sure you want to delete this data?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) = True Then

            If txtTaxId.Text = "" Then
                MessageBox.Show("Can not delete an empty data.", "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim selectedId As Integer = txtTaxId.Text
                Delete(selectedId)
            End If

        End If

        frmTax_Load(Nothing, Nothing)
       
    End Sub

    Private Sub btnFinish_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinish.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        frmTax_Load(sender, e)
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

    Private Sub chkOfficial_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkOfficial.CheckedChanged

        If chkOfficial.Checked = True Then

            Label2.Enabled = True
            Label3.Enabled = True
            Label5.Enabled = True
            Label15.Enabled = True
            Label17.Enabled = True
            Label18.Enabled = True

            txtPlace.Enabled = True
            txtBody.Enabled = True
            txtTaxaton.Enabled = True
            txtPayment.Enabled = True
            txtFrequency.Enabled = True
            txtAmount.Enabled = True

        Else

            Label2.Enabled = False
            Label3.Enabled = False
            Label5.Enabled = False
            Label15.Enabled = False
            Label17.Enabled = False
            Label18.Enabled = False

            txtPlace.Enabled = False
            txtBody.Enabled = False
            txtTaxaton.Enabled = False
            txtPayment.Enabled = False
            txtFrequency.Enabled = False
            txtAmount.Enabled = False

        End If

    End Sub
End Class