Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Imports Craft_Industry_Database.frmUsers

Public Class frmSocialPosition
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

        objDataAdapter = New SqlDataAdapter("SELECT * FROM tblSocialPosition ORDER BY formId", connectionString)
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
        txtSocialPositionId.DataBindings.Clear()
        txtLocalStatus.DataBindings.Clear()
        txtMember.DataBindings.Clear()
        cboTransportation.DataBindings.Clear()
        cboHousing.DataBindings.Clear()

        chkHome.DataBindings.Clear()
        chkMobile.DataBindings.Clear()
        txtFormId.DataBindings.Clear()

        chkState.DataBindings.Clear()
        txtName.DataBindings.Clear()
        chkFinance.DataBindings.Clear()
        chkTraining.DataBindings.Clear()
        chkEquipment.DataBindings.Clear()

    End Sub

    Public Sub validatation(ByVal i As Integer)

        If txtLocalStatus.Text = String.Empty Or
            txtMember.Text = String.Empty Or
            cboTransportation.Text = String.Empty Or
            cboHousing.Text = String.Empty Then

            MessageBox.Show("Please fill all the required fields.", "Fill Blank Fields", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub

        ElseIf IsNumeric(txtLocalStatus.Text) Or IsNumeric(txtMember.Text) Then
            MessageBox.Show("Local status and member of organization can not be numeric.", "String Expected", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

        If chkState.Checked = True Then
            If txtName.Text = String.Empty Then
                MessageBox.Show("Please fill all the required fields.", "Fill Blank Fields", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub

            ElseIf IsNumeric(txtName.Text) Then
                MessageBox.Show("Name of contact organization can not be numeric.", "String Expected", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End If

        If IsNumeric(txtSocialPositionId.Text) And i = 1 Then
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
        txtSocialPositionId.DataBindings.Add("Text", objDataView, "socialPositionId")
        txtLocalStatus.DataBindings.Add("Text", objDataView, "localStatus")
        txtMember.DataBindings.Add("Text", objDataView, "memberOfOrganization")
        chkHome.DataBindings.Add("Checked", objDataView, "telHome")
        chkMobile.DataBindings.Add("Checked", objDataView, "telMobile")
        txtFormId.DataBindings.Add("Text", objDataView, "formId")
        chkState.DataBindings.Add("Checked", objDataView, "contactWithGovenment")
        txtName.DataBindings.Add("Text", objDataView, "nameOfContact")
        chkFinance.DataBindings.Add("Checked", objDataView, "stateAidFinance")
        chkTraining.DataBindings.Add("Checked", objDataView, "stateAidTraining")
        chkEquipment.DataBindings.Add("Checked", objDataView, "stateAidEquipement")

        cboTransportation.DataBindings.Add("SelectedItem", objDataView, "transportation")
        cboHousing.DataBindings.Add("SelectedItem", objDataView, "housing")

    End Sub

    Private Sub ShowPosition()

        ' Display the current position and the number of records
        txtPosition.Text = objCurrencyManager.Position + 1 & " of " & objCurrencyManager.Count()

    End Sub

    Private Sub frmSocialPosition_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load

        If user = True Then
            btnNew.Enabled = False
            btnDelete.Enabled = False
            btnSave.Enabled = False
            btnUpdate.Enabled = False
        End If

        cboTransportation.SelectedIndex = 0
        cboHousing.SelectedIndex = 0
        'GroupBox2.Enabled = False

        ' Fill the DataSet and bind the fields...
        FillDataSetAndView()
        BindFields()

        ' Show the current record position...
        ShowPosition()
        mover()
    End Sub

    Private Sub Save(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim formId As String = frmForm.formId

        Dim state, finance, training, equipment, home, mobile As Boolean

        If chkState.Checked Then
            state = True
        Else
            state = False
        End If

        If chkFinance.Checked Then
            finance = True
        Else
            finance = False
        End If

        If chkTraining.Checked Then
            training = True
        Else
            training = False
        End If

        If chkEquipment.Checked Then
            equipment = True
        Else
            equipment = False
        End If

        If chkHome.Checked Then
            home = True
        Else
            home = False
        End If

        If chkMobile.Checked Then
            mobile = True
        Else
            mobile = False
        End If

        Using myConnection As SqlConnection = New SqlConnection(Me.connectionString)

            myConnection.Open()

            Using cmd As SqlCommand = myConnection.CreateCommand

                cmd.CommandType = CommandType.Text
                cmd.CommandText = "INSERT INTO tblSocialPosition (transportation, housing, telHome, telMobile, localStatus, memberOfOrganization, contactWithGovenment, nameOfContact, stateAidFinance, stateAidTraining, stateAidEquipement, formId) " & _
                                  "VALUES (@transportation, @housing, @telHome, @telMobile, @localStatus, @memberOfOrganization, @contactWithGovenment, @nameOfContact, @stateAidFinance, @stateAidTraining, @stateAidEquipement, @formId)"

                cmd.Parameters.Add(New SqlParameter("@transportation", cboTransportation.Text))
                cmd.Parameters.Add(New SqlParameter("@housing", cboHousing.Text))
                cmd.Parameters.Add(New SqlParameter("@telHome", home))
                cmd.Parameters.Add(New SqlParameter("@telMobile", mobile))
                cmd.Parameters.Add(New SqlParameter("@localStatus", txtLocalStatus.Text))
                cmd.Parameters.Add(New SqlParameter("@memberOfOrganization", txtMember.Text))
                cmd.Parameters.Add(New SqlParameter("@contactWithGovenment", state))
                cmd.Parameters.Add(New SqlParameter("@nameOfContact", txtName.Text))
                cmd.Parameters.Add(New SqlParameter("@stateAidFinance", finance))
                cmd.Parameters.Add(New SqlParameter("@stateAidTraining", training))
                cmd.Parameters.Add(New SqlParameter("@stateAidEquipement", equipment))
                cmd.Parameters.Add(New SqlParameter("@formId", formId2))

                Try
                    cmd.ExecuteNonQuery()
                    Message.Text = "The data is Inserted Successfully."
                Catch ex As SqlException
                    MessageBox.Show(ex.Message)
                End Try

            End Using

        End Using

        Call frmSocialPosition_Load(Nothing, Nothing)

    End Sub

    Private Sub UpdateForm(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim formId As String = frmForm.formId

        Dim state, finance, training, equipment, home, mobile As Boolean

        If chkState.Checked Then
            state = True
        Else
            state = False
        End If

        If chkFinance.Checked Then
            finance = True
        Else
            finance = False
        End If

        If chkTraining.Checked Then
            training = True
        Else
            training = False
        End If

        If chkEquipment.Checked Then
            equipment = True
        Else
            equipment = False
        End If

        If chkHome.Checked Then
            home = True
        Else
            home = False
        End If

        If chkMobile.Checked Then
            mobile = True
        Else
            mobile = False
        End If

        Using myConnection As SqlConnection = New SqlConnection(Me.connectionString)

            myConnection.Open()

            Using cmd As SqlCommand = myConnection.CreateCommand

                cmd.CommandType = CommandType.Text
                cmd.CommandText = "UPDATE tblSocialPosition SET transportation=@transportation, housing=@housing, telHome=@telHome, telMobile=@telMobile, localStatus= @localStatus, memberOfOrganization=@memberOfOrganization, contactWithGovenment=@contactWithGovenment, nameOfContact=@nameOfContact, stateAidFinance=@stateAidFinance, stateAidTraining=@stateAidTraining, stateAidEquipement=@stateAidEquipement, formId=@formId " & _
                                  "WHERE socialPositionId = @socialPositionId"

                cmd.Parameters.Add(New SqlParameter("@socialPositionId", txtSocialPositionId.Text))
                cmd.Parameters.Add(New SqlParameter("@transportation", cboTransportation.Text))
                cmd.Parameters.Add(New SqlParameter("@housing", cboHousing.Text))
                cmd.Parameters.Add(New SqlParameter("@telHome", home))
                cmd.Parameters.Add(New SqlParameter("@telMobile", mobile))
                cmd.Parameters.Add(New SqlParameter("@localStatus", txtLocalStatus.Text))
                cmd.Parameters.Add(New SqlParameter("@memberOfOrganization", txtMember.Text))
                cmd.Parameters.Add(New SqlParameter("@contactWithGovenment", state))
                cmd.Parameters.Add(New SqlParameter("@nameOfContact", txtName.Text))
                cmd.Parameters.Add(New SqlParameter("@stateAidFinance", finance))
                cmd.Parameters.Add(New SqlParameter("@stateAidTraining", training))
                cmd.Parameters.Add(New SqlParameter("@stateAidEquipement", equipment))
                cmd.Parameters.Add(New SqlParameter("@formId", txtFormId.Text))

                Try
                    cmd.ExecuteNonQuery()
                    message.Text = "The data is Updated Successfully."
                Catch ex As SqlException
                    MessageBox.Show(ex.Message)
                End Try

            End Using

        End Using

        Call frmSocialPosition_Load(Nothing, Nothing)

    End Sub

    Private Sub Delete(ByVal deleteId As Integer)

        Using myConnection As SqlConnection = New SqlConnection(Me.connectionString)

            myConnection.Open()

            Using cmd As SqlCommand = myConnection.CreateCommand

                cmd.CommandType = CommandType.Text
                cmd.CommandText = "DELETE FROM tblSocialPosition " & _
                                  "WHERE socialPositionId = '" & deleteId & "'"

                Try
                    cmd.ExecuteScalar()
                    message.Text = "The data is Deleted Successfully."
                Catch ex As SqlException
                    MessageBox.Show(ex.Message)
                End Try

            End Using

        End Using

    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click

        Dim form As New frmSupply
        form.MdiParent = mdiHome
        frmSupply.formId2 = frmSocialPosition.formId2
        frmSupply.position = position
        form.Show()
        Me.Close()

    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click

        Dim form As New frmWorkshop
        form.MdiParent = mdiHome
        form.Show()
        Me.Close()

    End Sub

    Private Sub chkState_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkState.CheckedChanged

        If chkState.Checked = False Then
            GroupBox2.Enabled = False
        Else
            GroupBox2.Enabled = True
        End If

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        validatation(0)
        txtFormId.ReadOnly = True
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If (MessageBox.Show("Are you sure you want to delete this data?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) = True Then

            If txtSocialPositionId.Text = "" Then
                MessageBox.Show("Can not delete an empty data.", "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim selectedId As Integer = txtSocialPositionId.Text
                Delete(selectedId)
            End If

        End If

        frmSocialPosition_Load(Nothing, Nothing)

    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        txtFormId.ReadOnly = True
        ' Clear any previous bindings...
        Clear()

        btnSave.Enabled = True
        btnUpdate.Enabled = False

        txtSocialPositionId.Text = String.Empty
        txtLocalStatus.Text = String.Empty
        txtMember.Text = String.Empty
        cboTransportation.SelectedIndex = 0
        cboHousing.SelectedIndex = 0

        chkHome.Checked = False
        chkMobile.Checked = False
        txtFormId.Text = String.Empty

        chkState.Checked = False
        txtName.Text = String.Empty
        chkFinance.Checked = False
        chkTraining.Checked = False
        chkEquipment.Checked = False

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
        frmSocialPosition_Load(sender, e)
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