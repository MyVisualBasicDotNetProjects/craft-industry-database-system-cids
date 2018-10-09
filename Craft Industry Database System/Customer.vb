Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Imports Craft_Industry_Database.frmUsers

Public Class frmCustomer
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

        objDataAdapter = New SqlDataAdapter("SELECT * FROM tblCustomer ORDER BY formId", connectionString)
        ' Initialize a new instance of the DataSet object...
        objDataSet = New DataSet()
        ' Fill the DataSet object with data...
        objDataAdapter.Fill(objDataSet, "customer")
        ' Set the DataView object to the DataSet object...
        objDataView = New DataView(objDataSet.Tables("customer"))
        ' Set our CurrencyManager object to the DataView object...
        objCurrencyManager = CType(Me.BindingContext(objDataView), CurrencyManager)

    End Sub

    Private Sub Clear()

        ' Clear any previous bindings...
        txtCustomerId.DataBindings.Clear()
        chkIntermediaries.DataBindings.Clear()
        chkDirectSale.DataBindings.Clear()
        chkLocal.DataBindings.Clear()
        chkRegional.DataBindings.Clear()
        chkNational.DataBindings.Clear()
        chkForiegn.DataBindings.Clear()

        cboIntermediaries.DataBindings.Clear()
        cboDirectSale.DataBindings.Clear()
        cboLocal.DataBindings.Clear()
        cboRegional.DataBindings.Clear()
        cboNational.DataBindings.Clear()
        cboForiegn.DataBindings.Clear()

        txtQuantity.DataBindings.Clear()
        txthowOften.DataBindings.Clear()
        chkBuying.DataBindings.Clear()
        chkAdvances.DataBindings.Clear()

        cboPointOfSale.DataBindings.Clear()
        txtPresumed.DataBindings.Clear()
        txtFormId.DataBindings.Clear()

    End Sub

    Public Sub validatation(ByVal i As Integer)
        If GroupBox3.Enabled = True Then
            If txtQuantity.Text = String.Empty Or
                txthowOften.Text = String.Empty Or
                cboPointOfSale.Text = String.Empty Or
                txtPresumed.Text = String.Empty Then

                MessageBox.Show("Please fill all the required fields.", "Fill Blank Fields", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            ElseIf IsNumeric(txtPresumed.Text) Then
                MessageBox.Show("Presumed can not be numeric.", "String Expected", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else
                If IsNumeric(txtCustomerId.Text) And i = 1 Then
                    Call UpdateForm(Nothing, Nothing)

                Else
                    Call Save(Nothing, Nothing)
                    btnSave.Enabled = False
                    btnUpdate.Enabled = True
                End If
            End If
        End If
    End Sub

    Private Sub BindFields()

        Clear()

        ' Add new bindings to the DataView object...
        txtCustomerId.DataBindings.Add("Text", objDataView, "customerId")

        chkIntermediaries.DataBindings.Add("Checked", objDataView, "tIntermediaries")
        chkDirectSale.DataBindings.Add("Checked", objDataView, "tDirectSale")
        chkLocal.DataBindings.Add("Checked", objDataView, "tLocal")
        chkRegional.DataBindings.Add("Checked", objDataView, "tRegional")
        chkNational.DataBindings.Add("Checked", objDataView, "tNational")
        chkForiegn.DataBindings.Add("Checked", objDataView, "tForiegn")

        txtQuantity.DataBindings.Add("Text", objDataView, "quantityBought")
        txthowOften.DataBindings.Add("Text", objDataView, "howOften")

        chkBuying.DataBindings.Add("Checked", objDataView, "buyingToOrder")
        chkAdvances.DataBindings.Add("Checked", objDataView, "possibleAdvance")
        cboPointOfSale.DataBindings.Add("Text", objDataView, "pointOfSale")
        txtPresumed.DataBindings.Add("Text", objDataView, "presumed")

        txtFormId.DataBindings.Add("Text", objDataView, "formId")

        cboIntermediaries.DataBindings.Add("SelectedItem", objDataView, "nIntermediaries")
        cboDirectSale.DataBindings.Add("SelectedItem", objDataView, "nDirectSale")
        cboLocal.DataBindings.Add("SelectedItem", objDataView, "nLocal")
        cboRegional.DataBindings.Add("SelectedItem", objDataView, "nRegional")
        cboNational.DataBindings.Add("SelectedItem", objDataView, "nNational")
        cboForiegn.DataBindings.Add("SelectedItem", objDataView, "nForiegn")
        cboPointOfSale.DataBindings.Add("SelectedItem", objDataView, "pointOfSale")

    End Sub

    Private Sub ShowPosition()

        ' Display the current position and the number of records
        txtPosition.Text = objCurrencyManager.Position + 1 & " of " & objCurrencyManager.Count()

    End Sub

    Private Sub frmCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load

        If user = True Then
            btnNew.Enabled = False
            btnDelete.Enabled = False
            btnSave.Enabled = False
            btnUpdate.Enabled = False
        End If

        cboIntermediaries.SelectedIndex = 0
        cboDirectSale.SelectedIndex = 0
        cboLocal.SelectedIndex = 0
        cboRegional.SelectedIndex = 0
        cboNational.SelectedIndex = 0
        cboForiegn.SelectedIndex = 0
        cboPointOfSale.SelectedIndex = 0

        ' Fill the DataSet and bind the fields...
        FillDataSetAndView()
        BindFields()
      
        ' Show the current record position...
        ShowPosition()
        mover()
    End Sub

    Private Sub Save(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim formId As String = frmForm.formId

        Dim intetmediaries, directSale, local, regional, national, foriegn, buying, advances As Boolean

        If chkBuying.Checked Then
            buying = True
        Else
            buying = False
        End If

        If chkAdvances.Checked Then
            advances = True
        Else
            advances = False
        End If

        If chkIntermediaries.Checked Then
            intetmediaries = True
        Else
            intetmediaries = False
        End If

        If chkDirectSale.Checked Then
            directSale = True
        Else
            directSale = False
        End If

        If chkNational.Checked Then
            national = True
        Else
            national = False
        End If

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

        If chkForiegn.Checked Then
            foriegn = True
        Else
            foriegn = False
        End If

        Using myConnection As SqlConnection = New SqlConnection(Me.connectionString)

            myConnection.Open()

            Using cmd As SqlCommand = myConnection.CreateCommand

                cmd.CommandType = CommandType.Text
                cmd.CommandText = "INSERT INTO tblCustomer (tIntermediaries, tDirectSale, tLocal, tRegional, tNational, tForiegn, nIntermediaries, nDirectSale, nLocal, nRegional, nNational, nForiegn, quantityBought, howOften, buyingToOrder, possibleAdvance, pointOfSale, presumed, formId) " & _
                                  "VALUES (@tIntermediaries, @tDirectSale, @tLocal, @tRegional, @tNational, @tForiegn, @nIntermediaries, @nDirectSale, @nLocal, @nRegional, @nNational, @nForiegn, @quantityBought, @howOften, @buyingToOrder, @possibleAdvance, @pointOfSale, @presumed, @formId)"

                cmd.Parameters.Add(New SqlParameter("@tIntermediaries", intetmediaries))
                cmd.Parameters.Add(New SqlParameter("@tDirectSale", directSale))
                cmd.Parameters.Add(New SqlParameter("@tLocal", local))
                cmd.Parameters.Add(New SqlParameter("@tRegional", regional))
                cmd.Parameters.Add(New SqlParameter("@tNational", national))
                cmd.Parameters.Add(New SqlParameter("@tForiegn", foriegn))

                cmd.Parameters.Add(New SqlParameter("@nIntermediaries", cboIntermediaries.Text))
                cmd.Parameters.Add(New SqlParameter("@nDirectSale", cboDirectSale.Text))
                cmd.Parameters.Add(New SqlParameter("@nLocal", cboLocal.Text))
                cmd.Parameters.Add(New SqlParameter("@nRegional", cboRegional.Text))
                cmd.Parameters.Add(New SqlParameter("@nNational", cboNational.Text))
                cmd.Parameters.Add(New SqlParameter("@nForiegn", cboForiegn.Text))

                cmd.Parameters.Add(New SqlParameter("@quantityBought", txtQuantity.Text))
                cmd.Parameters.Add(New SqlParameter("@howOften", txthowOften.Text))
                cmd.Parameters.Add(New SqlParameter("@buyingToOrder", buying))
                cmd.Parameters.Add(New SqlParameter("@possibleAdvance", advances))
                cmd.Parameters.Add(New SqlParameter("@pointOfSale", cboPointOfSale.Text))
                cmd.Parameters.Add(New SqlParameter("@presumed", txtPresumed.Text))

                cmd.Parameters.Add(New SqlParameter("@formId", formid2))

                Try
                    cmd.ExecuteNonQuery()
                    message.Text = "The data is Inserted Successfully."
                Catch ex As SqlException
                    MessageBox.Show(ex.Message)
                End Try

            End Using

        End Using

        Call frmCustomer_Load(Nothing, Nothing)

    End Sub

    Private Sub UpdateForm(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim formId As String = frmForm.formId

        Dim intetmediaries, directSale, local, regional, national, foriegn, buying, advances As Boolean

        If chkBuying.Checked Then
            buying = True
        Else
            buying = False
        End If

        If chkAdvances.Checked Then
            advances = True
        Else
            advances = False
        End If

        If chkIntermediaries.Checked Then
            intetmediaries = True
        Else
            intetmediaries = False
        End If

        If chkDirectSale.Checked Then
            directSale = True
        Else
            directSale = False
        End If

        If chkNational.Checked Then
            national = True
        Else
            national = False
        End If

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

        If chkForiegn.Checked Then
            foriegn = True
        Else
            foriegn = False
        End If

        Using myConnection As SqlConnection = New SqlConnection(Me.connectionString)

            myConnection.Open()

            Using cmd As SqlCommand = myConnection.CreateCommand

                cmd.CommandType = CommandType.Text
                cmd.CommandText = "UPDATE tblCustomer SET tIntermediaries=@tIntermediaries, tDirectSale=@tDirectSale, tLocal=@tLocal, tRegional=@tRegional, tNational= @tNational, tForiegn=@tForiegn, nIntermediaries=@nIntermediaries, nDirectSale=@nDirectSale, nLocal=@nLocal, nRegional=@nRegional, nNational=@nNational, nForiegn=@nForiegn, quantityBought= @quantityBought, howOften=@howOften, buyingToOrder=@buyingToOrder, possibleAdvance=@possibleAdvance, pointOfSale=@pointOfSale, presumed=@presumed, formId=@formId " & _
                                  "WHERE customerId = @customerId;"

                cmd.Parameters.Add(New SqlParameter("@customerId", txtCustomerId.Text))
                cmd.Parameters.Add(New SqlParameter("@tIntermediaries", intetmediaries))
                cmd.Parameters.Add(New SqlParameter("@tDirectSale", directSale))
                cmd.Parameters.Add(New SqlParameter("@tLocal", local))
                cmd.Parameters.Add(New SqlParameter("@tRegional", regional))
                cmd.Parameters.Add(New SqlParameter("@tNational", national))
                cmd.Parameters.Add(New SqlParameter("@tForiegn", foriegn))

                cmd.Parameters.Add(New SqlParameter("@nIntermediaries", cboIntermediaries.Text))
                cmd.Parameters.Add(New SqlParameter("@nDirectSale", cboDirectSale.Text))
                cmd.Parameters.Add(New SqlParameter("@nLocal", cboLocal.Text))
                cmd.Parameters.Add(New SqlParameter("@nRegional", cboRegional.Text))
                cmd.Parameters.Add(New SqlParameter("@nNational", cboNational.Text))
                cmd.Parameters.Add(New SqlParameter("@nForiegn", cboForiegn.Text))

                cmd.Parameters.Add(New SqlParameter("@quantityBought", txtQuantity.Text))
                cmd.Parameters.Add(New SqlParameter("@howOften", txthowOften.Text))
                cmd.Parameters.Add(New SqlParameter("@buyingToOrder", buying))
                cmd.Parameters.Add(New SqlParameter("@possibleAdvance", advances))
                cmd.Parameters.Add(New SqlParameter("@pointOfSale", cboPointOfSale.Text))
                cmd.Parameters.Add(New SqlParameter("@presumed", txtPresumed.Text))

                cmd.Parameters.Add(New SqlParameter("@formId", txtFormId.Text))

                Try
                    cmd.ExecuteNonQuery()
                    message.Text = "The data is Updated Successfully."
                Catch ex As SqlException
                    MessageBox.Show(ex.Message)
                End Try

            End Using

        End Using

        Call frmCustomer_Load(Nothing, Nothing)

    End Sub

    Private Sub Delete(ByVal deleteId As Integer)

        Using myConnection As SqlConnection = New SqlConnection(Me.connectionString)

            myConnection.Open()

            Using cmd As SqlCommand = myConnection.CreateCommand

                cmd.CommandType = CommandType.Text
                cmd.CommandText = "DELETE FROM tblCustomer " & _
                                  "WHERE customerId = '" & deleteId & "'"

                Try
                    cmd.ExecuteScalar()
                    Message.Text = "The data is Deleted Successfully."
                Catch ex As SqlException
                    MessageBox.Show(ex.Message)
                End Try

            End Using

        End Using

    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click

        Dim form As New frmCompetition
        form.MdiParent = mdiHome
        frmCompetition.formId2 = frmDistribution.formId2
        frmCompetition.position = position
        form.Show()
        Me.Close()

    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click

        Dim form As New frmDistribution
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

        txtCustomerId.Text = String.Empty
        chkIntermediaries.Checked = False
        chkDirectSale.Checked = False
        chkLocal.Checked = False
        chkRegional.Checked = False
        chkNational.Checked = False
        chkForiegn.Checked = False

        cboIntermediaries.SelectedIndex = 0
        cboDirectSale.SelectedIndex = 0
        cboLocal.SelectedIndex = 0
        cboRegional.SelectedIndex = 0
        cboNational.SelectedIndex = 0
        cboForiegn.SelectedIndex = 0

        txtQuantity.Text = String.Empty
        txthowOften.Text = String.Empty
        chkBuying.Checked = False
        chkAdvances.Checked = False

        cboPointOfSale.SelectedIndex = 0
        txtPresumed.Text = String.Empty
        txtFormId.Text = String.Empty

        message.Text = "Ready."
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        validatation(0)
        txtFormId.ReadOnly = False
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        If (MessageBox.Show("Are you sure you want to delete this data?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) = True Then

            If txtCustomerId.Text = "" Then
                MessageBox.Show("Can not delete an empty data.", "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim selectedId As Integer = txtCustomerId.Text
                Delete(selectedId)
            End If

        End If

        frmCustomer_Load(Nothing, Nothing)

    End Sub

    Private Sub chkIntermediaries_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIntermediaries.CheckedChanged

        If chkIntermediaries.Checked = True Then

            cboIntermediaries.Enabled = True
            GroupBox3.Enabled = True

        Else

            cboIntermediaries.Enabled = False
            GroupBox3.Enabled = False

        End If

    End Sub

    Private Sub chkDirectSale_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDirectSale.CheckedChanged

        If chkDirectSale.Checked = True Then
            cboDirectSale.Enabled = True
        Else
            cboDirectSale.Enabled = False
        End If

    End Sub

    Private Sub chkLocal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkLocal.CheckedChanged
        If chkLocal.Checked = True Then
            cboLocal.Enabled = True
        Else
            cboLocal.Enabled = False
        End If
    End Sub

    Private Sub chkNational_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNational.CheckedChanged
        If chkNational.Checked = True Then
            cboNational.Enabled = True
        Else
            cboNational.Enabled = False
        End If
    End Sub

    Private Sub chkRegional_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRegional.CheckedChanged
        If chkRegional.Checked = True Then
            cboRegional.Enabled = True
        Else
            cboRegional.Enabled = False
        End If
    End Sub

    Private Sub chkForiegn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkForiegn.CheckedChanged
        If chkForiegn.Checked = True Then
            cboForiegn.Enabled = True
        Else
            cboForiegn.Enabled = False
        End If
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        frmCustomer_Load(sender, e)
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