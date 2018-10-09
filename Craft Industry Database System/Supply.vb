Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Imports Craft_Industry_Database.frmUsers

Public Class frmSupply
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

        objDataAdapter = New SqlDataAdapter("SELECT * FROM tblSupply ORDER BY formId", connectionString)
        ' Initialize a new instance of the DataSet object...
        objDataSet = New DataSet()
        ' Fill the DataSet object with data...
        objDataAdapter.Fill(objDataSet, "description")
        ' Set the DataView object to the DataSet object...
        objDataView = New DataView(objDataSet.Tables("description"))
        ' Set our CurrencyManager object to the DataView object...
        objCurrencyManager = CType(Me.BindingContext(objDataView), CurrencyManager)

    End Sub

    Private Sub Clear()

        ' Clear any previous bindings...
        txtSupplyId.DataBindings.Clear()
        txtLocation.DataBindings.Clear()
        chkOil.DataBindings.Clear()
        chkElectric.DataBindings.Clear()
        chkWater.DataBindings.Clear()
        chkNone.DataBindings.Clear()
        txtUsedD.DataBindings.Clear()
        txtUsedM.DataBindings.Clear()
        txtUsedW.DataBindings.Clear()
        txtFormId.DataBindings.Clear()

        txtBoughtD.DataBindings.Clear()
        txtBoughtM.DataBindings.Clear()
        txtBoughtW.DataBindings.Clear()

        cboDistance.DataBindings.Clear()
        cboOrigin.DataBindings.Clear()
        cboWhy.DataBindings.Clear()
        cboReasonOil.DataBindings.Clear()
        cboReasonElectric.DataBindings.Clear()
        cboReasonWater.DataBindings.Clear()

        Hid.DataBindings.Clear()

    End Sub

    Public Sub validatation(ByVal i As Integer)

        If cboOrigin.Text = String.Empty Or
            cboWhy.Text = String.Empty Then

            MessageBox.Show("Please fill all the required fields.", "Fill Blank Fields", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If chkNone.Checked = True Then
            If cboReasonOil.Text = String.Empty Or
                cboReasonElectric.Text = String.Empty Or
                cboReasonWater.Text = String.Empty Then

                MessageBox.Show("Please fill all the required fields.", "Fill Blank Fields", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
        End If

        If IsNumeric(txtSupplyId.Text) And i = 1 Then
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
        txtSupplyId.DataBindings.Add("Text", objDataView, "supplyId")
        txtLocation.DataBindings.Add("Text", objDataView, "location")
        chkOil.DataBindings.Add("Checked", objDataView, "oil")
        chkElectric.DataBindings.Add("Checked", objDataView, "electric")
        chkWater.DataBindings.Add("Checked", objDataView, "water")
        chkNone.DataBindings.Add("Checked", objDataView, "none")

        txtUsedD.DataBindings.Add("Text", objDataView, "usedPerDay")
        txtUsedM.DataBindings.Add("Text", objDataView, "usedPerMonth")
        txtUsedW.DataBindings.Add("Text", objDataView, "usedPerWeek")
        txtFormId.DataBindings.Add("Text", objDataView, "formId")

        txtBoughtD.DataBindings.Add("Text", objDataView, "boughtPerDay")
        txtBoughtM.DataBindings.Add("Text", objDataView, "boughtPerMonth")
        txtBoughtW.DataBindings.Add("Text", objDataView, "boughtPerWeek")

        cboDistance.DataBindings.Add("SelectedItem", objDataView, "distance")
        cboOrigin.DataBindings.Add("SelectedItem", objDataView, "origin")
        cboWhy.DataBindings.Add("SelectedItem", objDataView, "whyAbroad")
        cboReasonOil.DataBindings.Add("SelectedItem", objDataView, "reasonOil")
        cboReasonWater.DataBindings.Add("SelectedItem", objDataView, "reasonWater")
        cboReasonElectric.DataBindings.Add("SelectedItem", objDataView, "reasonElectric")

    End Sub

    Private Sub ShowPosition()

        ' Display the current position and the number of records
        txtPosition.Text = objCurrencyManager.Position + 1 & " of " & objCurrencyManager.Count()

    End Sub

    Private Sub frmSupply_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If user = True Then
            btnNew.Enabled = False
            btnDelete.Enabled = False
            btnSave.Enabled = False
            btnUpdate.Enabled = False
        End If

        cboOrigin.SelectedIndex = 0
        cboWhy.SelectedIndex = 0
        cboReasonOil.SelectedIndex = 0
        cboReasonElectric.SelectedIndex = 0
        cboReasonWater.SelectedIndex = 0

        ' Fill the DataSet and bind the fields...
        FillDataSetAndView()
        BindFields()
        Hid.Visible = False

        ' Show the current record position...
        ShowPosition()
        mover()
    End Sub

    Private Sub Save(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim formId As String = frmForm.formId

        Dim oil, elec, water, none As Boolean

        If chkOil.Checked Then
            oil = True
        Else
            oil = False
        End If

        If chkElectric.Checked Then
            elec = True
        Else
            elec = False
        End If

        If chkWater.Checked Then
            water = True
        Else
            water = False
        End If

        If chkNone.Checked Then
            none = True
        Else
            none = False
        End If

        Using myConnection As SqlConnection = New SqlConnection(Me.connectionString)

            myConnection.Open()

            Using cmd As SqlCommand = myConnection.CreateCommand

                cmd.CommandType = CommandType.Text
                cmd.CommandText = "INSERT INTO tblSupply (origin, distance, location, whyAbroad, usedPerDay, usedPerWeek, usedPerMonth,boughtPerDay, boughtPerWeek, boughtPerMonth,oil, water, electric, none, reasonOil, reasonWater, reasonElectric, formId) " & _
                                  "VALUES (@origin, @distance, @location, @whyAbroad, @usedPerDay, @usedPerWeek, @usedPerMonth, @boughtPerDay, @boughtPerWeek, @boughtPerMonth, @oil, @water, @electric, @none, @reasonOil, @reasonWater, @reasonElectric, @formId)"

                cmd.Parameters.Add(New SqlParameter("@origin", cboOrigin.Text))
                cmd.Parameters.Add(New SqlParameter("@distance", cboDistance.Text))
                cmd.Parameters.Add(New SqlParameter("@location", txtLocation.Text))
                cmd.Parameters.Add(New SqlParameter("@whyAbroad", cboWhy.Text))
                cmd.Parameters.Add(New SqlParameter("@usedPerDay", txtUsedD.Text))
                cmd.Parameters.Add(New SqlParameter("@usedPerWeek", txtUsedW.Text))
                cmd.Parameters.Add(New SqlParameter("@usedPerMonth", txtUsedM.Text))
                cmd.Parameters.Add(New SqlParameter("@boughtPerDay", txtBoughtD.Text))
                cmd.Parameters.Add(New SqlParameter("@boughtPerWeek", txtBoughtW.Text))
                cmd.Parameters.Add(New SqlParameter("@boughtPerMonth", txtBoughtM.Text))
                cmd.Parameters.Add(New SqlParameter("@oil", oil))
                cmd.Parameters.Add(New SqlParameter("@water", water))
                cmd.Parameters.Add(New SqlParameter("@electric", elec))
                cmd.Parameters.Add(New SqlParameter("@none", none))
                cmd.Parameters.Add(New SqlParameter("@reasonOil", cboReasonOil.Text))
                cmd.Parameters.Add(New SqlParameter("@reasonWater", cboReasonWater.Text))
                cmd.Parameters.Add(New SqlParameter("@reasonElectric", cboReasonElectric.Text))
                cmd.Parameters.Add(New SqlParameter("@formId", formId2))

                Try
                    cmd.ExecuteNonQuery()
                    Message.Text = "The data is Inserted Successfully."
                Catch ex As SqlException
                    MessageBox.Show(ex.Message)
                End Try

            End Using

        End Using

        Call frmSupply_Load(Nothing, Nothing)

    End Sub

    Private Sub UpdateForm(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim formId As String = frmForm.formId
      
        Dim oil, elec, water As Boolean

        If chkOil.Checked Then
            oil = True
        Else
            oil = False
        End If

        If chkElectric.Checked Then
            elec = True
        Else
            elec = False
        End If

        If chkWater.Checked Then
            water = True
        Else
            water = False
        End If
        Using myConnection As SqlConnection = New SqlConnection(Me.connectionString)

            myConnection.Open()

            Using cmd As SqlCommand = myConnection.CreateCommand

                cmd.CommandType = CommandType.Text
                cmd.CommandText = "UPDATE tblSupply SET origin=@origin, distance =@distance, location=@location, whyAbroad=@whyAbroad, usedPerDay= @usedPerDay, usedPerWeek=@usedPerWeek, usedPerMonth= @usedPerMonth,boughtPerDay=@boughtPerDay, boughtPerWeek=@boughtPerWeek, boughtPerMonth= @boughtPerMonth,oil=@oil, water=@water, electric=@electric, reasonOil=@reasonOil, reasonWater=@reasonWater, reasonElectric=@reasonElectric, formId=@formId " & _
                                  "WHERE supplyId = @supplyId"

                cmd.Parameters.Add(New SqlParameter("@supplyId", txtSupplyId.Text))
                cmd.Parameters.Add(New SqlParameter("@origin", cboOrigin.Text))
                cmd.Parameters.Add(New SqlParameter("@distance", cboDistance.Text))
                cmd.Parameters.Add(New SqlParameter("@location", txtLocation.Text))
                cmd.Parameters.Add(New SqlParameter("@whyAbroad", cboWhy.Text))
                cmd.Parameters.Add(New SqlParameter("@usedPerDay", txtUsedD.Text))
                cmd.Parameters.Add(New SqlParameter("@usedPerWeek", txtUsedW.Text))
                cmd.Parameters.Add(New SqlParameter("@usedPerMonth", txtUsedM.Text))
                cmd.Parameters.Add(New SqlParameter("@boughtPerDay", txtBoughtD.Text))
                cmd.Parameters.Add(New SqlParameter("@boughtPerWeek", txtBoughtW.Text))
                cmd.Parameters.Add(New SqlParameter("@boughtPerMonth", txtBoughtM.Text))
                cmd.Parameters.Add(New SqlParameter("@oil", oil))
                cmd.Parameters.Add(New SqlParameter("@water", water))
                cmd.Parameters.Add(New SqlParameter("@electric", elec))
                cmd.Parameters.Add(New SqlParameter("@reasonOil", cboReasonOil.Text))
                cmd.Parameters.Add(New SqlParameter("@reasonWater", cboReasonWater.Text))
                cmd.Parameters.Add(New SqlParameter("@reasonElectric", cboReasonElectric.Text))
                cmd.Parameters.Add(New SqlParameter("@formId", txtFormId.Text))
                Try
                    cmd.ExecuteNonQuery()
                    message.Text = "The data is Updated Successfully."
                Catch ex As SqlException
                    MessageBox.Show(ex.Message)
                End Try

            End Using

        End Using

        Call frmSupply_Load(Nothing, Nothing)

    End Sub

    Private Sub Delete(ByVal deleteId As Integer)

        Using myConnection As SqlConnection = New SqlConnection(Me.connectionString)

            myConnection.Open()

            Using cmd As SqlCommand = myConnection.CreateCommand

                cmd.CommandType = CommandType.Text
                cmd.CommandText = "DELETE FROM tblSupply " & _
                                  "WHERE supplyId = '" & deleteId & "'"

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

        Dim form As New frmCommunication
        form.MdiParent = mdiHome
        frmCommunication.formId2 = frmSupply.formId2
        frmCommunication.position = position
        form.Show()
        Me.Close()

    End Sub

    Private Sub cboOrigin_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboOrigin.SelectedIndexChanged

        'MsgBox(cboOrigin.Text)

        If cboOrigin.Text.Equals("Local") Then
            Label7.Enabled = True
            cboDistance.Enabled = True

            Label13.Enabled = False
            Label14.Enabled = False
            txtLocation.Enabled = False
            cboWhy.Enabled = False

        ElseIf cboOrigin.Text.Equals("Abroad") Then
            Label13.Enabled = True
            Label14.Enabled = True
            txtLocation.Enabled = True
            cboWhy.Enabled = True

            Label7.Enabled = False
            cboDistance.Enabled = False
        End If

    End Sub

    Private Sub cboNone_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNone.CheckedChanged, cboNone.CheckedChanged

        If chkNone.Checked = True Then

            chkOil.Checked = False
            chkElectric.Checked = False
            chkWater.Checked = False

            Label23.Enabled = True
            Label8.Enabled = True
            Label9.Enabled = True
            Label11.Enabled = True
            cboReasonOil.Enabled = True
            cboReasonWater.Enabled = True
            cboReasonElectric.Enabled = True

        Else

            Label23.Enabled = False
            Label8.Enabled = False
            Label9.Enabled = False
            Label11.Enabled = False
            cboReasonOil.Enabled = False
            cboReasonWater.Enabled = False
            cboReasonElectric.Enabled = False

        End If

    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click

        Dim form As New frmSocialPosition
        form.MdiParent = mdiHome
        form.Show()
        Me.Close()

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If (MessageBox.Show("Are you sure you want to delete this data?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) = True Then

            If txtSupplyId.Text = "" Then
                MessageBox.Show("Can not delete an empty data.", "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim selectedId As Integer = txtSupplyId.Text
                Delete(selectedId)
            End If

        End If

        frmSupply_Load(Nothing, Nothing)

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        validatation(0)
        txtFormId.ReadOnly = True
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        txtFormId.ReadOnly = True
        ' Clear any previous bindings...
        Clear()

        btnSave.Enabled = True
        btnUpdate.Enabled = False

        txtSupplyId.Text = String.Empty
        txtLocation.Text = String.Empty

        chkOil.Checked = False
        chkElectric.Checked = False
        chkWater.Checked = False
        chkNone.Checked = False

        txtUsedD.Text = String.Empty
        txtUsedM.Text = String.Empty
        txtUsedW.Text = String.Empty
        txtFormId.Text = String.Empty

        txtBoughtD.Text = String.Empty
        txtBoughtM.Text = String.Empty
        txtBoughtW.Text = String.Empty

        cboDistance.SelectedIndex = 0
        cboOrigin.SelectedIndex = 0
        cboWhy.SelectedIndex = 0
        cboReasonOil.SelectedIndex = 0
        cboReasonElectric.SelectedIndex = 0
        cboReasonWater.SelectedIndex = 0

        Hid.Text = String.Empty
        message.Text = "Ready."
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
        frmSupply_Load(sender, e)
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

    Private Sub chkOil_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkOil.CheckedChanged

        If chkOil.Checked = True Then
            chkNone.Checked = False
        End If

    End Sub

    Private Sub chkWater_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkWater.CheckedChanged
        If chkWater.Checked = True Then
            chkNone.Checked = False
        End If
    End Sub

    Private Sub chkElectric_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkElectric.CheckedChanged
        If chkElectric.Checked = True Then
            chkNone.Checked = False
        End If
    End Sub
End Class