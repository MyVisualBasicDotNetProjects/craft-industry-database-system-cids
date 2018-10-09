Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Imports Craft_Industry_Database.frmUsers

Public Class frmCommunication
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

        objDataAdapter = New SqlDataAdapter("SELECT * FROM tblCommunication ORDER BY formId", connectionString)
        ' Initialize a new instance of the DataSet object...
        objDataSet = New DataSet()
        ' Fill the DataSet object with data...
        objDataAdapter.Fill(objDataSet, "communication")
        ' Set the DataView object to the DataSet object...
        objDataView = New DataView(objDataSet.Tables("communication"))
        ' Set our CurrencyManager object to the DataView object...
        objCurrencyManager = CType(Me.BindingContext(objDataView), CurrencyManager)

    End Sub

    Private Sub Clear()

        ' Clear any previous bindings...
        txtCommunicationId.DataBindings.Clear()
        cboTruck.DataBindings.Clear()
        cboMainRoad.DataBindings.Clear()
        cboTrain.DataBindings.Clear()
        cboNavigableWater.DataBindings.Clear()
        cboAirport.DataBindings.Clear()
        cboPort.DataBindings.Clear()
        
        txtFormId.DataBindings.Clear()

        cboTruck.DataBindings.Clear()
        cboMainRoad.DataBindings.Clear()
        cboTrain.DataBindings.Clear()
        cboNavigableWater.DataBindings.Clear()
        cboAirport.DataBindings.Clear()
        cboPort.DataBindings.Clear()

    End Sub

    Public Sub validatation(ByVal i As Integer)
        If cboTruck.Text = String.Empty Or
            cboMainRoad.Text = String.Empty Or
            cboTrain.Text = String.Empty Or
            cboNavigableWater.Text = String.Empty Or
            cboAirport.Text = String.Empty Or
            cboPort.Text = String.Empty Then

            MessageBox.Show("Please fill all the required fields.", "Fill Blank Fields", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else
            If IsNumeric(txtCommunicationId.Text) And i = 1 Then
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
        txtCommunicationId.DataBindings.Add("Text", objDataView, "communicationId")
        txtFormId.DataBindings.Add("Text", objDataView, "formId")

        cboTruck.DataBindings.Add("SelectedItem", objDataView, "truck")
        cboMainRoad.DataBindings.Add("SelectedItem", objDataView, "mainRoad")
        cboTrain.DataBindings.Add("SelectedItem", objDataView, "train")
        cboNavigableWater.DataBindings.Add("SelectedItem", objDataView, "navigableWater")
        cboAirport.DataBindings.Add("SelectedItem", objDataView, "airport")
        cboPort.DataBindings.Add("SelectedItem", objDataView, "port")

        'Hid.DataBindings.Add("Text", objDataView, "truck")

        'Dim i As Integer = 0
        'Dim t As String

        'For i = 0 To cboTruck.Items.Count - 1
        '    ' MsgBox(Hid.Text + " " + cboCraftCategory.Text)
        '    cboTruck.SelectedIndex = i
        '    t = cboTruck.Text
        '    If Hid.Text.Equals(t) Then
        '        cboTruck.Text = Hid.Text
        '        Exit For
        '    End If
        'Next

        'Hid.DataBindings.Clear()
        'Hid.DataBindings.Add("Text", objDataView, "mainRoad")

        'For i = 0 To cboMainRoad.Items.Count - 1
        '    ' MsgBox(Hid.Text + " " + cboCraftCategory.Text)
        '    cboMainRoad.SelectedIndex = i
        '    t = cboMainRoad.Text
        '    If Hid.Text.Equals(t) Then
        '        cboMainRoad.Text = Hid.Text
        '        Exit For
        '    End If
        'Next

        'Hid.DataBindings.Clear()
        'Hid.DataBindings.Add("Text", objDataView, "train")

        'For i = 0 To cboTrain.Items.Count - 1
        '    ' MsgBox(Hid.Text + " " + cboCraftCategory.Text)
        '    cboTrain.SelectedIndex = i
        '    t = cboTrain.Text
        '    If Hid.Text.Equals(t) Then
        '        cboTrain.Text = Hid.Text
        '        Exit For
        '    End If
        'Next

        'Hid.DataBindings.Clear()
        'Hid.DataBindings.Add("Text", objDataView, "navigableWater")
        'For i = 0 To cboNavigableWater.Items.Count - 1
        '    ' MsgBox(Hid.Text + " " + cboCraftCategory.Text)
        '    cboNavigableWater.SelectedIndex = i
        '    t = cboNavigableWater.Text
        '    If Hid.Text.Equals(t) Then
        '        cboNavigableWater.Text = Hid.Text
        '        Exit For
        '    End If
        'Next

        'Hid.DataBindings.Clear()
        'Hid.DataBindings.Add("Text", objDataView, "airport")
        'For i = 0 To cboAirport.Items.Count - 1
        '    ' MsgBox(Hid.Text + " " + cboCraftCategory.Text)
        '    cboAirport.SelectedIndex = i
        '    t = cboAirport.Text
        '    If Hid.Text.Equals(t) Then
        '        cboAirport.Text = Hid.Text
        '        Exit For
        '    End If
        'Next

        'Hid.DataBindings.Clear()
        'Hid.DataBindings.Add("Text", objDataView, "port")
        'For i = 0 To cboPort.Items.Count - 1
        '    ' MsgBox(Hid.Text + " " + cboCraftCategory.Text)
        '    cboPort.SelectedIndex = i
        '    t = cboPort.Text
        '    If Hid.Text.Equals(t) Then
        '        cboPort.Text = Hid.Text
        '        Exit For
        '    End If
        'Next

    End Sub

    Private Sub ShowPosition()

        ' Display the current position and the number of records
        txtPosition.Text = objCurrencyManager.Position + 1 & " of " & objCurrencyManager.Count()

    End Sub

    Private Sub frmCommunication_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If user = True Then
            btnNew.Enabled = False
            btnDelete.Enabled = False
            btnSave.Enabled = False
            btnUpdate.Enabled = False
        End If

        cboTruck.SelectedIndex = 0
        cboMainRoad.SelectedIndex = 0
        cboTrain.SelectedIndex = 0
        cboNavigableWater.SelectedIndex = 0
        cboAirport.SelectedIndex = 0
        cboPort.SelectedIndex = 0

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
                cmd.CommandText = "INSERT INTO tblCommunication (truck, mainRoad, train, navigableWater, airport, port , formId) " & _
                                  "VALUES (@truck, @mainRoad, @train, @navigableWater, @airport, @port , @formId)"

                cmd.Parameters.Add(New SqlParameter("@truck", cboTruck.Text))
                cmd.Parameters.Add(New SqlParameter("@mainRoad", cboMainRoad.Text))
                cmd.Parameters.Add(New SqlParameter("@train", cboTrain.Text))
                cmd.Parameters.Add(New SqlParameter("@navigableWater", cboNavigableWater.Text))
                cmd.Parameters.Add(New SqlParameter("@airport", cboAirport.Text))
                cmd.Parameters.Add(New SqlParameter("@port", cboPort.Text))
                '  MsgBox(formid2)
                cmd.Parameters.Add(New SqlParameter("@formId", formid2))

                Try
                    cmd.ExecuteNonQuery()
                    message.Text = "The data is Inserted Successfully."
                Catch ex As SqlException
                    MessageBox.Show(ex.Message)
                End Try

            End Using

        End Using

        frmCommunication_Load(Nothing, Nothing)
        btnSave.Enabled = True
    End Sub

    Private Sub UpdateForm(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim formId As String = frmForm.formId

        Using myConnection As SqlConnection = New SqlConnection(Me.connectionString)

            myConnection.Open()

            Using cmd As SqlCommand = myConnection.CreateCommand

                cmd.CommandType = CommandType.Text
                cmd.CommandText = "UPDATE tblCommunication SET truck=@truck, mainRoad=@mainRoad, train= @train, navigableWater=@navigableWater, airport=@airport, port=@port, formId=@formId " & _
                                  "WHERE communicationId = @communicationId;"

                cmd.Parameters.Add(New SqlParameter("@communicationId", txtCommunicationId.Text))
                cmd.Parameters.Add(New SqlParameter("@truck", cboTruck.Text))
                cmd.Parameters.Add(New SqlParameter("@mainRoad", cboMainRoad.Text))
                cmd.Parameters.Add(New SqlParameter("@train", cboTrain.Text))
                cmd.Parameters.Add(New SqlParameter("@navigableWater", cboNavigableWater.Text))
                cmd.Parameters.Add(New SqlParameter("@airport", cboAirport.Text))
                cmd.Parameters.Add(New SqlParameter("@port", cboPort.Text))

                cmd.Parameters.Add(New SqlParameter("@formId", txtFormId.Text))

                Try
                    cmd.ExecuteNonQuery()
                    message.Text = "The data is Updated Successfully."
                Catch ex As SqlException
                    MessageBox.Show(ex.Message)
                End Try

            End Using

        End Using

        frmCommunication_Load(Nothing, Nothing)
        btnSave.Enabled = True
    End Sub

    Private Sub Delete(ByVal deleteId As Integer)

        Using myConnection As SqlConnection = New SqlConnection(Me.connectionString)

            myConnection.Open()

            Using cmd As SqlCommand = myConnection.CreateCommand

                cmd.CommandType = CommandType.Text
                cmd.CommandText = "DELETE FROM tblCommunication " & _
                                  "WHERE communicationId = '" & deleteId & "'"

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

        Dim form As New frmRateOfProduction
        form.MdiParent = mdiHome
        frmRateOfProduction.formId2 = frmCommunication.formId2
        frmRateOfProduction.position = position
        form.Show()
        Me.Close()

    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click

        Dim form As New frmSupply
        form.MdiParent = mdiHome
        form.Show()
        Me.Close()

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        validatation(0)
        txtFormId.ReadOnly = False
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        If (MessageBox.Show("Are you sure you want to delete this data?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) = True Then

            If txtCommunicationId.Text = "" Then
                MessageBox.Show("Can not delete an empty data.", "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim selectedId As Integer = txtCommunicationId.Text
                Delete(selectedId)
            End If

        End If

        frmCommunication_Load(Nothing, Nothing)

    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        txtFormId.ReadOnly = True
        ' Clear any previous bindings...
        Clear()

        btnSave.Enabled = True
        btnUpdate.Enabled = False

        txtCommunicationId.Text = String.Empty
        cboTruck.SelectedIndex = 0
        cboMainRoad.SelectedIndex = 0
        cboTrain.SelectedIndex = 0
        cboNavigableWater.SelectedIndex = 0
        cboAirport.SelectedIndex = 0
        cboPort.SelectedIndex = 0
        txtFormId.Text = String.Empty


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
        frmCommunication_Load(sender, e)
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