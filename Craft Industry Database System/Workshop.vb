Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Imports Craft_Industry_Database.frmUsers

Public Class frmWorkshop
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

        objDataAdapter = New SqlDataAdapter("SELECT * FROM tblWorkshop ORDER BY formId", connectionString)
        ' Initialize a new instance of the DataSet object...
        objDataSet = New DataSet()
        ' Fill the DataSet object with data...
        objDataAdapter.Fill(objDataSet, "workshop")
        ' Set the DataView object to the DataSet object...
        objDataView = New DataView(objDataSet.Tables("workshop"))
        ' Set our CurrencyManager object to the DataView object...
        objCurrencyManager = CType(Me.BindingContext(objDataView), CurrencyManager)

    End Sub

    Private Sub Clear()

        ' Clear any previous bindings...
        txtWorkshopId.DataBindings.Clear()
        cboSituation.DataBindings.Clear()
        cboBuilding.DataBindings.Clear()
        txtArea.DataBindings.Clear()
        txtFormId.DataBindings.Clear()
        txtTools.DataBindings.Clear()
        'chkTelephone.DataBindings.Clear()
        'chkElectricity.DataBindings.Clear()
        'chkWater.DataBindings.Clear()

    End Sub

    Public Sub validatation(ByVal i As Integer)

        If cboSituation.Text = String.Empty Or
            cboBuilding.Text = String.Empty Or
            txtArea.Text = String.Empty Or
            txtTools.Text = String.Empty Then

            MessageBox.Show("Please fill all the required fields.", "Fill Blank Fields", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        ElseIf IsNumeric(cboSituation.Text) Or IsNumeric(cboBuilding.Text) Then
            MessageBox.Show("Situation and Building can not be numeric.", "String Expected", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf IsNumeric(txtWorkshopId.Text) And i = 1 Then
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
        txtWorkshopId.DataBindings.Add("Text", objDataView, "workshopId")
        cboSituation.DataBindings.Add("SelectedItem", objDataView, "wsSituation")
        cboBuilding.DataBindings.Add("SelectedItem", objDataView, "wsBuilding")
        txtArea.DataBindings.Add("Text", objDataView, "wsArea")
        txtTools.DataBindings.Add("Text", objDataView, "wsTools")
        txtFormId.DataBindings.Add("Text", objDataView, "formId")

        'chkTelephone.DataBindings.Add("Checked", objDataView, "wsTelephone")
        'chkElectricity.DataBindings.Add("Checked", objDataView, "wsElectricity")
        'chkWater.DataBindings.Add("Checked", objDataView, "wsWater")

        Hid2.DataBindings.Clear()
        Hid2.DataBindings.Add("Text", objDataView, "wsTelephone")

        If Hid2.Text = "True" Then
            rdbYes.Checked = True
            rdbNo.Checked = False
        ElseIf Hid2.Text = "False" Then
            rdbYes.Checked = False
            rdbNo.Checked = True
        End If

        Hid2.DataBindings.Clear()
        Hid2.DataBindings.Add("Text", objDataView, "wsElectricity")

        If Hid2.Text = "True" Then
            rdbYes2.Checked = True
            rdbNo2.Checked = False
        ElseIf Hid2.Text = "False" Then
            rdbYes2.Checked = False
            rdbNo2.Checked = True
        End If

        Hid2.DataBindings.Clear()
        Hid2.DataBindings.Add("Text", objDataView, "wsWater")

        If Hid2.Text = "True" Then
            rdbYes3.Checked = True
            rdbNo3.Checked = False
        ElseIf Hid2.Text = "False" Then
            rdbYes3.Checked = False
            rdbNo3.Checked = True
        End If

    End Sub

    Private Sub ShowPosition()

        ' Display the current position and the number of records
        txtPosition.Text = objCurrencyManager.Position + 1 & " of " & objCurrencyManager.Count()

    End Sub

    Private Sub frmWorkshop_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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

        Dim telephone, elec, water As Boolean

        'If chkTelephone.Checked Then
        '    telephone = True
        'Else
        '    telephone = False
        'End If

        'If chkElectricity.Checked Then
        '    elec = True
        'Else
        '    elec = False
        'End If

        'If chkWater.Checked Then
        '    water = True
        'Else
        '    water = False
        'End If

        If rdbYes.Checked Then
            telephone = True
        ElseIf rdbNo.Checked = True Then
            telephone = False
        End If

        If rdbYes2.Checked Then
            elec = True
        ElseIf rdbNo2.Checked Then
            elec = False
        End If

        If rdbYes3.Checked Then
            water = True
        ElseIf rdbNo3.Checked Then
            water = False
        End If

        Using myConnection As SqlConnection = New SqlConnection(Me.connectionString)

            myConnection.Open()

            Using cmd As SqlCommand = myConnection.CreateCommand

                cmd.CommandType = CommandType.Text
                cmd.CommandText = "INSERT INTO tblWorkshop (wsBuilding, wsSituation, wsArea, wsTelephone, wsElectricity, wsWater, wstools, formId) " & _
                                  "VALUES (@wsBuilding, @wsSituation, @wsArea, @wsTelephone, @wsElectricity, @wsWater,@wstools, @formId)"

                'cmd.Parameters.Add(New SqlParameter("@workshopId", txtWorkshopId.Text))
                cmd.Parameters.Add(New SqlParameter("@wsBuilding", cboBuilding.Text))
                cmd.Parameters.Add(New SqlParameter("@wsSituation", cboSituation.Text))
                cmd.Parameters.Add(New SqlParameter("@wsArea", txtArea.Text))
                cmd.Parameters.Add(New SqlParameter("@wsTelephone", telephone))
                cmd.Parameters.Add(New SqlParameter("@wsElectricity", elec))
                cmd.Parameters.Add(New SqlParameter("@wsWater", water))
                cmd.Parameters.Add(New SqlParameter("@wstools", txtTools.Text))
                cmd.Parameters.Add(New SqlParameter("@formId", formId2))

                Try
                    cmd.ExecuteNonQuery()
                    Message.Text = "The data is Inserted Successfully."
                Catch ex As SqlException
                    MessageBox.Show(ex.Message)
                End Try

            End Using

        End Using

        Call frmWorkshop_Load(Nothing, Nothing)

    End Sub

    Private Sub UpdateForm(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim formId As String = frmForm.formId

        Dim telephone, elec, water As Boolean

        'If chkTelephone.Checked Then
        '    telephone = True
        'Else
        '    telephone = False
        'End If

        'If chkElectricity.Checked Then
        '    elec = True
        'Else
        '    elec = False
        'End If

        'If chkWater.Checked Then
        '    water = True
        'Else
        '    water = False
        'End If

        If rdbYes.Checked Then
            telephone = True
        ElseIf rdbNo.Checked = True Then
            telephone = False
        End If

        If rdbYes2.Checked Then
            elec = True
        ElseIf rdbNo2.Checked Then
            elec = False
        End If

        If rdbYes3.Checked Then
            water = True
        ElseIf rdbNo3.Checked Then
            water = False
        End If

        Using myConnection As SqlConnection = New SqlConnection(Me.connectionString)

            myConnection.Open()

            Using cmd As SqlCommand = myConnection.CreateCommand

                cmd.CommandType = CommandType.Text
                cmd.CommandText = "UPDATE tblWorkshop SET  wsBuilding=@wsBuilding, wsSituation=@wsSituation, wsArea=@wsArea, wsTelephone=@wsTelephone, wsElectricity=@wsElectricity, wsWater=@wsWater, wstools=@wstools, formId = @formId " & _
                                 "WHERE workshopId = @workshopId"

                cmd.Parameters.Add(New SqlParameter("@workshopId", txtWorkshopId.Text))
                cmd.Parameters.Add(New SqlParameter("@wsBuilding", cboBuilding.Text))
                cmd.Parameters.Add(New SqlParameter("@wsSituation", cboSituation.Text))
                cmd.Parameters.Add(New SqlParameter("@wsArea", txtArea.Text))
                cmd.Parameters.Add(New SqlParameter("@wsTelephone", telephone))
                cmd.Parameters.Add(New SqlParameter("@wsElectricity", elec))
                cmd.Parameters.Add(New SqlParameter("@wsWater", water))
                cmd.Parameters.Add(New SqlParameter("@wstools", txtTools.Text))
                cmd.Parameters.Add(New SqlParameter("@formId", txtFormId.Text))

                Try
                    cmd.ExecuteNonQuery()
                    message.Text = "The data is Updated Successfully."
                Catch ex As SqlException
                    MessageBox.Show(ex.Message)
                End Try

            End Using

        End Using

        Call frmWorkshop_Load(Nothing, Nothing)

    End Sub

    Private Sub Delete(ByVal deleteId As Integer)

        Using myConnection As SqlConnection = New SqlConnection(Me.connectionString)

            myConnection.Open()

            Using cmd As SqlCommand = myConnection.CreateCommand

                cmd.CommandType = CommandType.Text
                cmd.CommandText = "DELETE FROM tblWorkshop " & _
                                  "WHERE workshopId = '" & deleteId & "'"

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

        Dim form As New frmSocialPosition
        form.MdiParent = mdiHome
        frmSocialPosition.formId2 = frmWorkshop.formId2
        frmSocialPosition.position = position
        form.Show()
        Me.Close()

    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click

        Dim form As New frmDefinition
        form.MdiParent = mdiHome
        form.Show()
        Me.Close()

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        validatation(0)
        txtFormId.ReadOnly = True
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If (MessageBox.Show("Are you sure you want to delete this data?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) = True Then

            If txtWorkshopId.Text = "" Then
                MessageBox.Show("Can not delete an empty data.", "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim selectedId As Integer = txtWorkshopId.Text
                Delete(selectedId)
            End If

        End If

        frmWorkshop_Load(Nothing, Nothing)

    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        txtFormId.ReadOnly = True
        ' Clear any previous bindings...
        Clear()

        btnSave.Enabled = True
        btnUpdate.Enabled = False

        txtWorkshopId.Text = String.Empty
        cboSituation.Text = String.Empty
        cboBuilding.Text = String.Empty
        txtArea.Text = String.Empty
        txtTools.Text = String.Empty
        txtFormId.Text = String.Empty
        'chkTelephone.Checked = False
        'chkElectricity.Checked = False
        'chkWater.Checked = False

        rdbNo.Checked = True
        rdbNo2.Checked = True
        rdbNo3.Checked = True

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
        frmWorkshop_Load(sender, e)
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