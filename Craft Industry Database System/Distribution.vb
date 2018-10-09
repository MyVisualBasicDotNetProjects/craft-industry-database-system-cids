Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Imports Craft_Industry_Database.frmUsers

Public Class frmDistribution
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

        objDataAdapter = New SqlDataAdapter("SELECT * FROM tblDistribution ORDER BY formId", connectionString)
        ' Initialize a new instance of the DataSet object...
        objDataSet = New DataSet()
        ' Fill the DataSet object with data...
        objDataAdapter.Fill(objDataSet, "distribution")
        ' Set the DataView object to the DataSet object...
        objDataView = New DataView(objDataSet.Tables("distribution"))
        ' Set our CurrencyManager object to the DataView object...
        objCurrencyManager = CType(Me.BindingContext(objDataView), CurrencyManager)

    End Sub

    Private Sub Clear()

        ' Clear any previous bindings...
        txtDistributionId.DataBindings.Clear()
        cboSellingMethod.DataBindings.Clear()
        chkDisplay.DataBindings.Clear()
        cboPlace.DataBindings.Clear()
        txtSurfaceArea.DataBindings.Clear()
        chkNational.DataBindings.Clear()
        chkInternational.DataBindings.Clear()
        chkExport.DataBindings.Clear()
        chkPackaging.DataBindings.Clear()
        cboTypeOfPackaging.DataBindings.Clear()
        cboTransportation.DataBindings.Clear()
        txtFormId.DataBindings.Clear()

    End Sub

    Public Sub validatation(ByVal i As Integer)

        If cboSellingMethod.Text = String.Empty Or cboTransportation.Text = String.Empty Then
            MessageBox.Show("Please fill all the required fields.", "Fill Blank Fields", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If chkDisplay.Checked Then
            If cboPlace.Text = String.Empty Or txtSurfaceArea.Text = String.Empty Then
                MessageBox.Show("Please fill all the required fields.", "Fill Blank Fields", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
        End If

        If chkPackaging.Checked Then
            If cboTypeOfPackaging.Text = String.Empty Then
                MessageBox.Show("Please fill all the required fields.", "Fill Blank Fields", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
        End If

        If IsNumeric(txtDistributionId.Text) And i = 1 Then
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
        txtDistributionId.DataBindings.Add("Text", objDataView, "distributionId")
        chkDisplay.DataBindings.Add("Checked", objDataView, "havePlaceToDisplay")
        txtSurfaceArea.DataBindings.Add("Text", objDataView, "surfaceArea")

        chkNational.DataBindings.Add("Checked", objDataView, "experienceNational")
        chkInternational.DataBindings.Add("Checked", objDataView, "experienceInternational")
        chkExport.DataBindings.Add("Checked", objDataView, "experienceExport")
        chkPackaging.DataBindings.Add("Checked", objDataView, "packaging")

        txtFormId.DataBindings.Add("Text", objDataView, "formId")

        cboSellingMethod.DataBindings.Add("SelectedItem", objDataView, "sellingMethod")
        cboPlace.DataBindings.Add("SelectedItem", objDataView, "placeToDisplay")
        cboTypeOfPackaging.DataBindings.Add("SelectedItem", objDataView, "typeOfPackaging")
        cboTransportation.DataBindings.Add("SelectedItem", objDataView, "meansOfTransportation")

    End Sub

    Private Sub ShowPosition()

        ' Display the current position and the number of records
        txtPosition.Text = objCurrencyManager.Position + 1 & " of " & objCurrencyManager.Count()

    End Sub

    Private Sub frmDistribution_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If user = True Then
            btnNew.Enabled = False
            btnDelete.Enabled = False
            btnSave.Enabled = False
            btnUpdate.Enabled = False
        End If

        cboSellingMethod.SelectedIndex = 0
        cboPlace.SelectedIndex = 0
        cboTypeOfPackaging.SelectedIndex = 0
        cboTransportation.SelectedIndex = 0

        ' Fill the DataSet and bind the fields...
        FillDataSetAndView()
        BindFields()

        ' Show the current record position...
        ShowPosition()
        mover()
    End Sub

    Private Sub Save(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim formId As String = frmForm.formId

        Dim national, international, export, packaging, display As Boolean

        If chkNational.Checked Then
            national = True
        Else
            national = False
        End If

        If chkInternational.Checked Then
            international = True
        Else
            international = False
        End If

        If chkExport.Checked Then
            export = True
        Else
            export = False
        End If

        If chkPackaging.Checked Then
            packaging = True
        Else
            packaging = False
        End If

        If chkDisplay.Checked Then
            display = True
        Else
            display = False
        End If


        Using myConnection As SqlConnection = New SqlConnection(Me.connectionString)

            myConnection.Open()

            Using cmd As SqlCommand = myConnection.CreateCommand

                cmd.CommandType = CommandType.Text
                cmd.CommandText = "INSERT INTO tblDistribution (sellingMethod, experienceNational, experienceInternational, experienceExport, havePlaceToDisplay, placeToDisplay, surfaceArea, packaging, typeOfPackaging, meansOfTransportation, formId) " & _
                                  "VALUES (@sellingMethod, @experienceNational, @experienceInternational, @experienceExport, @havePlaceToDisplay, @placeToDisplay, @surfaceArea, @packaging, @typeOfPackaging, @meansOfTransportation, @formId)"

                cmd.Parameters.Add(New SqlParameter("@sellingMethod", cboSellingMethod.Text))
                cmd.Parameters.Add(New SqlParameter("@experienceNational", national))
                cmd.Parameters.Add(New SqlParameter("@experienceInternational", international))
                cmd.Parameters.Add(New SqlParameter("@experienceExport", export))
                cmd.Parameters.Add(New SqlParameter("@havePlaceToDisplay", display))
                cmd.Parameters.Add(New SqlParameter("@placeToDisplay", cboPlace.Text))
                cmd.Parameters.Add(New SqlParameter("@surfaceArea", txtSurfaceArea.Text))
                cmd.Parameters.Add(New SqlParameter("@packaging", packaging))
                cmd.Parameters.Add(New SqlParameter("@typeOfPackaging", cboTypeOfPackaging.Text))
                cmd.Parameters.Add(New SqlParameter("@meansOfTransportation", cboTransportation.Text))
                cmd.Parameters.Add(New SqlParameter("@formId", formId2))

                Try
                    cmd.ExecuteNonQuery()
                    message.Text = "The data is Inserted Successfully."
                Catch ex As SqlException
                    MessageBox.Show(ex.Message)
                End Try

            End Using

        End Using

        Call frmDistribution_Load(Nothing, Nothing)

    End Sub

    Private Sub UpdateForm(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim formId As String = frmForm.formId

        Dim national, international, export, packaging, display As Boolean

        If chkNational.Checked Then
            national = True
        Else
            national = False
        End If

        If chkInternational.Checked Then
            international = True
        Else
            international = False
        End If

        If chkExport.Checked Then
            export = True
        Else
            export = False
        End If

        If chkPackaging.Checked Then
            packaging = True
        Else
            packaging = False
        End If

        If chkDisplay.Checked Then
            display = True
        Else
            display = False
        End If


        Using myConnection As SqlConnection = New SqlConnection(Me.connectionString)

            myConnection.Open()

            Using cmd As SqlCommand = myConnection.CreateCommand

                cmd.CommandType = CommandType.Text
                cmd.CommandText = "UPDATE tblDistribution SET sellingMethod=@sellingMethod, experienceNational=@experienceNational, experienceInternational=@experienceInternational, experienceExport=@experienceExport, havePlaceToDisplay=@havePlaceToDisplay, placeToDisplay=@placeToDisplay, packaging=@packaging, typeOfPackaging=@typeOfPackaging, meansOfTransportation=@meansOfTransportation, surfaceArea=@surfaceArea, formId=@formId " & _
                                  "WHERE distributionId = @distributionId"

                cmd.Parameters.Add(New SqlParameter("@distributionId", txtDistributionId.Text))
                cmd.Parameters.Add(New SqlParameter("@sellingMethod", cboSellingMethod.Text))
                cmd.Parameters.Add(New SqlParameter("@experienceNational", national))
                cmd.Parameters.Add(New SqlParameter("@experienceInternational", international))
                cmd.Parameters.Add(New SqlParameter("@experienceExport", export))
                cmd.Parameters.Add(New SqlParameter("@havePlaceToDisplay", display))
                cmd.Parameters.Add(New SqlParameter("@placeToDisplay", cboPlace.Text))
                cmd.Parameters.Add(New SqlParameter("@packaging", packaging))
                cmd.Parameters.Add(New SqlParameter("@typeOfPackaging", cboTypeOfPackaging.Text))
                cmd.Parameters.Add(New SqlParameter("@meansOfTransportation", cboTransportation.Text))
                cmd.Parameters.Add(New SqlParameter("@surfaceArea", txtSurfaceArea.Text))
                cmd.Parameters.Add(New SqlParameter("@formId", txtFormId.Text))

                Try
                    cmd.ExecuteNonQuery()
                    message.Text = "The data is Updated Successfully."
                Catch ex As SqlException
                    MessageBox.Show(ex.Message)
                End Try

            End Using

        End Using

        Call frmDistribution_Load(Nothing, Nothing)

    End Sub

    Private Sub Delete(ByVal deleteId As Integer)

        Using myConnection As SqlConnection = New SqlConnection(Me.connectionString)

            myConnection.Open()

            Using cmd As SqlCommand = myConnection.CreateCommand

                cmd.CommandType = CommandType.Text
                cmd.CommandText = "DELETE FROM tblDistribution " & _
                                  "WHERE distributionId = '" & deleteId & "'"

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

        Dim form As New frmCustomer
        form.MdiParent = mdiHome
        frmCustomer.formId2 = frmDistribution.formId2
        frmCustomer.position = position
        form.Show()
        Me.Close()

    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click

        Dim form As New frmManagement
        form.MdiParent = mdiHome
        form.Show()
        Me.Close()

    End Sub

    Private Sub chkDisplay_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDisplay.CheckedChanged

        If chkDisplay.Checked = False Then

            Label9.Enabled = False
            Label13.Enabled = False
            txtSurfaceArea.Enabled = False
            cboPlace.Enabled = False

        Else

            Label9.Enabled = True
            Label13.Enabled = True
            txtSurfaceArea.Enabled = True
            cboPlace.Enabled = True

        End If

    End Sub

    Private Sub chkPackaging_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If chkPackaging.Enabled = False Then

            Label12.Enabled = False
            cboTypeOfPackaging.Enabled = False

        Else

            Label12.Enabled = True
            cboTypeOfPackaging.Enabled = True

        End If

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

        txtDistributionId.Text = String.Empty
        cboSellingMethod.SelectedIndex = 0
        chkDisplay.Checked = False
        cboPlace.SelectedIndex = 0
        txtSurfaceArea.Text = String.Empty
        chkNational.Checked = False
        chkInternational.Checked = False
        chkExport.Checked = False
        chkPackaging.Checked = False
        cboTypeOfPackaging.SelectedIndex = 0
        cboTransportation.SelectedIndex = 0
        txtFormId.Text = String.Empty

        message.Text = "Ready."
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        validatation(0)
        txtFormId.ReadOnly = False
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        If (MessageBox.Show("Are you sure you want to delete this data?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) = True Then

            If txtDistributionId.Text = "" Then
                MessageBox.Show("Can not delete an empty data.", "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim selectedId As Integer = txtDistributionId.Text
                Delete(selectedId)
            End If

        End If

        frmDistribution_Load(Nothing, Nothing)

    End Sub

    Private Sub chkPackaging_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPackaging.CheckedChanged

        If chkPackaging.Checked = True Then

            Label12.Enabled = True
            cboTypeOfPackaging.Enabled = True

        Else

            Label12.Enabled = False
            cboTypeOfPackaging.Enabled = False

        End If

    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        frmDistribution_Load(sender, e)
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