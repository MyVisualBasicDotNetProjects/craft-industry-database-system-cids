Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Imports Craft_Industry_Database.frmUsers

Public Class frmDescription

    Public Shared formId2 As String
    Public Shared position As Integer

    Dim myPicture As String

    Dim connectionString As String = String.Empty
    Dim objDataAdapter As New SqlDataAdapter
    Dim objDataSet As DataSet
    Dim objDataView As DataView
    Dim objCurrencyManager As CurrencyManager

    Public Shared newFile As String

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.connectionString = ConfigurationManager.ConnectionStrings("connectionString").ConnectionString

        newFile = "Nothing"

    End Sub

    Private Sub FillDataSetAndView()

        objDataAdapter = New SqlDataAdapter("SELECT * FROM tblDescription ORDER BY formId", connectionString)
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
        txtDescriptionId.DataBindings.Clear()
        txtUsualName.DataBindings.Clear()
        txtLocalName.DataBindings.Clear()
        txtType.DataBindings.Clear()
        txtShape.DataBindings.Clear()
        txtMeasurement.DataBindings.Clear()
        cboRawMaterial.DataBindings.Clear()
        cboDecoration.DataBindings.Clear()
        cboColor.DataBindings.Clear()
        cboUse.DataBindings.Clear()

        PictureBox1.DataBindings.Clear()

        txtFormId.DataBindings.Clear()
    
    End Sub

    Private Sub BindFields()

        Clear()

        ' Add new bindings to the DataView object...
        txtDescriptionId.DataBindings.Add("Text", objDataView, "descriptionId")
        txtUsualName.DataBindings.Add("Text", objDataView, "usualName")
        txtLocalName.DataBindings.Add("Text", objDataView, "localName")
        txtType.DataBindings.Add("Text", objDataView, "type")
        txtShape.DataBindings.Add("Text", objDataView, "shape")
        txtMeasurement.DataBindings.Add("Text", objDataView, "measurement")

        PictureBox1.DataBindings.Add("ImageLocation", objDataView, "pictureLocation")
        ' MsgBox(PictureBox1.ImageLocation)
        If PictureBox1.ImageLocation = Nothing Then
            newFile = "Nothing"
        Else
            newFile = PictureBox1.ImageLocation.ToString
        End If

        txtFormId.DataBindings.Add("Text", objDataView, "formId")

        cboRawMaterial.DataBindings.Add("SelectedItem", objDataView, "rawMaterial")
        cboDecoration.DataBindings.Add("SelectedItem", objDataView, "decoration")
        cboColor.DataBindings.Add("SelectedItem", objDataView, "color")
        cboUse.DataBindings.Add("SelectedItem", objDataView, "used")

    End Sub

    Private Sub ShowPosition()

        ' Display the current position and the number of records
        txtPosition.Text = objCurrencyManager.Position + 1 & " of " & objCurrencyManager.Count()

    End Sub

    Private Sub frmDescription_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If user = True Then
            btnNew.Enabled = False
            btnDelete.Enabled = False
            btnSave.Enabled = False
            btnUpdate.Enabled = False
        End If

        cboRawMaterial.SelectedIndex = 0
        cboDecoration.SelectedIndex = 0
        cboColor.SelectedIndex = 0
        cboUse.SelectedIndex = 0

        ' Fill the DataSet and bind the fields...
        FillDataSetAndView()
        BindFields()
     
        ' Show the current record position...
        ShowPosition()
        mover()

        mover()

    End Sub

    Private Sub Save(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim formId As String = frmForm.formId
        'MsgBox(formId2)

        'If newFile.Equals("Nothing") Then

        '    MessageBox.Show("Please select a picture file with a unique file name.", "CIDS", MessageBoxButtons.OK, MessageBoxIcon.Error)

        'Else

        Using myConnection As SqlConnection = New SqlConnection(Me.connectionString)

            myConnection.Open()


            Using cmd As SqlCommand = myConnection.CreateCommand


                If newFile = "Nothing" Then

                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = "INSERT INTO tblDescription (usualName, localName, type, shape, measurement, rawMaterial, decoration, used, color, formId ) " & _
                                      "VALUES (@usualName, @localName, @type, @shape, @measurement, @rawMaterial, @decoration, @used, @color, @formId)"

                    cmd.Parameters.Add(New SqlParameter("@usualName", txtUsualName.Text))
                    cmd.Parameters.Add(New SqlParameter("@localName", txtLocalName.Text))
                    cmd.Parameters.Add(New SqlParameter("@type", txtLocalName.Text))
                    cmd.Parameters.Add(New SqlParameter("@shape", txtShape.Text))
                    cmd.Parameters.Add(New SqlParameter("@measurement", txtMeasurement.Text))
                    cmd.Parameters.Add(New SqlParameter("@rawMaterial", cboRawMaterial.Text))
                    cmd.Parameters.Add(New SqlParameter("@decoration", cboDecoration.Text))
                    cmd.Parameters.Add(New SqlParameter("@used", cboUse.Text))
                    cmd.Parameters.Add(New SqlParameter("@color", cboColor.Text))
                    cmd.Parameters.Add(New SqlParameter("@formId", formId2))

                    'MsgBox(newFile)
                    ' If newFile <> "Nothing" Then
                Else

                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = "INSERT INTO tblDescription (usualName, localName, type, shape, measurement, rawMaterial, decoration, used, color, formId, pictureLocation) " & _
                                      "VALUES (@usualName, @localName, @type, @shape, @measurement, @rawMaterial, @decoration, @used, @color, @formId, @pictureLocation)"

                    cmd.Parameters.Add(New SqlParameter("@usualName", txtUsualName.Text))
                    cmd.Parameters.Add(New SqlParameter("@localName", txtLocalName.Text))
                    cmd.Parameters.Add(New SqlParameter("@type", txtLocalName.Text))
                    cmd.Parameters.Add(New SqlParameter("@shape", txtShape.Text))
                    cmd.Parameters.Add(New SqlParameter("@measurement", txtMeasurement.Text))
                    cmd.Parameters.Add(New SqlParameter("@rawMaterial", cboRawMaterial.Text))
                    cmd.Parameters.Add(New SqlParameter("@decoration", cboDecoration.Text))
                    cmd.Parameters.Add(New SqlParameter("@used", cboUse.Text))
                    cmd.Parameters.Add(New SqlParameter("@color", cboColor.Text))
                    cmd.Parameters.Add(New SqlParameter("@formId", formId2))
                    cmd.Parameters.Add(New SqlParameter("@pictureLocation", newFile))

                End If

                Try
                    cmd.ExecuteNonQuery()
                    message.Text = "The data is Inserted Successfully."
                Catch ex As SqlException
                    MessageBox.Show(ex.Message)
                End Try

            End Using

        End Using
        'End If

        frmDescription_Load(Nothing, Nothing)

    End Sub

    Private Sub UpdateForm(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim formId As String = frmForm.formId

        Using myConnection As SqlConnection = New SqlConnection(Me.connectionString)

            myConnection.Open()

            Using cmd As SqlCommand = myConnection.CreateCommand

                cmd.CommandType = CommandType.Text
                cmd.CommandText = "UPDATE tblDescription SET usualName = @usualName, localName = @localName, type = @type, shape = @shape, measurement = @measurement, " & _
                                  "rawMaterial = @rawMaterial, decoration = @decoration, color = @color, used = @used, formId = @formId, pictureLocation=@pictureLocation " & _
                                  "WHERE descriptionId = @descriptionId"

                cmd.Parameters.Add(New SqlParameter("@descriptionId", txtDescriptionId.Text))
                cmd.Parameters.Add(New SqlParameter("@usualName", txtUsualName.Text))
                cmd.Parameters.Add(New SqlParameter("@localName", txtLocalName.Text))
                cmd.Parameters.Add(New SqlParameter("@type", txtType.Text))
                cmd.Parameters.Add(New SqlParameter("@shape", txtShape.Text))
                cmd.Parameters.Add(New SqlParameter("@measurement", txtMeasurement.Text))
                cmd.Parameters.Add(New SqlParameter("@rawMaterial", cboRawMaterial.Text))
                cmd.Parameters.Add(New SqlParameter("@used", cboUse.Text))
                cmd.Parameters.Add(New SqlParameter("@color", cboColor.Text))
                cmd.Parameters.Add(New SqlParameter("@formId", txtFormId.Text))
                cmd.Parameters.Add(New SqlParameter("@decoration", cboDecoration.Text))
                cmd.Parameters.Add(New SqlParameter("@pictureLocation", newFile))

                Try
                    cmd.ExecuteNonQuery()
                    message.Text = "The data is Updated Successfully."
                Catch ex As SqlException
                    MessageBox.Show(ex.Message)
                End Try

            End Using

        End Using

        Call frmDescription_Load(Nothing, Nothing)
        btnUpdate.Enabled = True
    End Sub

    Private Sub Delete(ByVal deleteId As Integer)

        Using myConnection As SqlConnection = New SqlConnection(Me.connectionString)

            myConnection.Open()

            Using cmd As SqlCommand = myConnection.CreateCommand

                cmd.CommandType = CommandType.Text
                cmd.CommandText = "DELETE FROM tblDescription " & _
                                  "WHERE descriptionId = '" & deleteId & "'"

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

        Dim form As New frmProduction
        form.MdiParent = mdiHome
        frmProduction.formId2 = frmDescription.formId2
        frmProduction.position = position
        'MsgBox(frmDescription.formId2)
        form.Show()
        Me.Close()

    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click

        Dim form As New frmForm
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

            If txtDescriptionId.Text = "" Then
                MessageBox.Show("Can not delete an empty data.", "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim selectedId As Integer = txtDescriptionId.Text
                Delete(selectedId)
            End If

        End If

        frmDescription_Load(sender, e)

    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click

        ' Clear any previous bindings...
        Clear()

        btnSave.Enabled = True
        btnUpdate.Enabled = False

        txtDescriptionId.Text = String.Empty
        txtUsualName.Text = String.Empty
        txtLocalName.Text = String.Empty
        txtType.Text = String.Empty
        txtShape.Text = String.Empty
        txtMeasurement.Text = String.Empty
        cboRawMaterial.SelectedIndex = 0
        cboDecoration.SelectedIndex = 0
        cboColor.SelectedIndex = 0
        cboUse.SelectedIndex = 0
        txtFormId.Text = String.Empty

        message.Text = "Ready."

        PictureBox1.ImageLocation = Nothing
        newFile = "Nothing"

        txtFormId.ReadOnly = True

    End Sub

    Private Sub btnMoveFirst_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMoveFirst.Click
        ' Set the record position to the first record...
        objCurrencyManager.Position = 0
        ' Show the current record position...
        ShowPosition()
        BindFields()
    End Sub

    Private Sub btnMovePrevious_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMovePrevious.Click
        ' Move to the previous record...
        objCurrencyManager.Position -= 1
        ' Show the current record position...
        ShowPosition()
        BindFields()
    End Sub

    Private Sub btnMoveNext_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMoveNext.Click

        ' Move to the next record...
        objCurrencyManager.Position += 1
        ' Show the current record position...
        ShowPosition()
        BindFields()
    End Sub

    Private Sub btnMoveLast_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMoveLast.Click
        ' Set the record position to the last record...
        objCurrencyManager.Position = objCurrencyManager.Count - 1
        ' Show the current record position...
        ShowPosition()
        BindFields()
    End Sub

    Public Sub validatation(ByVal i As Integer)

        If txtUsualName.Text = String.Empty Or
            txtLocalName.Text = String.Empty Or
            txtType.Text = String.Empty Or
            txtShape.Text = String.Empty Or
            txtMeasurement.Text = String.Empty Or
            cboRawMaterial.Text = String.Empty Or
            cboDecoration.Text = String.Empty Or
            cboColor.Text = String.Empty Or
            cboUse.Text = String.Empty Then

            MessageBox.Show("Please fill all the required fields.", "Fill Blank Fields", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf IsNumeric(txtUsualName.Text) Or IsNumeric(txtLocalName.Text) Or IsNumeric(txtType.Text) Or IsNumeric(txtShape.Text) Then
            MessageBox.Show("Usual name, local name, type and shape can not be numeric.", "String Expected", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If IsNumeric(txtDescriptionId.Text) And i = 1 Then
                Call UpdateForm(Nothing, Nothing)

            Else
                Call Save(Nothing, Nothing)
                btnSave.Enabled = False
                btnUpdate.Enabled = True
            End If
        End If

    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        frmDescription_Load(sender, e)
        btnSave.Enabled = False
        btnUpdate.Enabled = True
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        validatation(1)
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click

        With OpenFileDialog1
            .Filter = "JPEG (*.jpg,*.jpeg)|*.jpg;*.jpeg|PNG (*.png)|*.png|Monochrome bitmap (*.bmp)|*.jpg|All files (*.*)| *.*"
            .FilterIndex = 1
            .Title = "Open a picture"
            .FileName = String.Empty
        End With
        '192.168.80.139
        'Show the open dialog and if the user clicks the open button load the file

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

            Dim sourceName As String
         
            Try
                'Save the file name
                myPicture = OpenFileDialog1.FileName

                sourceName = OpenFileDialog1.SafeFileName

                Dim file As New IO.FileInfo(myPicture)

                newFile = "C:\Program Files\Craft Industry\CRAFT INDUSTRY DATABASE SYSTEM - CIDS\Pictures\" & sourceName

                IO.Directory.CreateDirectory("C:\Program Files\Craft Industry\CRAFT INDUSTRY DATABASE SYSTEM - CIDS\Pictures\")
                file.CopyTo(newFile, False)

                PictureBox1.ImageLocation = myPicture

            Catch ex As Exception
                MessageBox.Show("Please select a picture file or a different file name.", "CIDS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

 
    Public Sub mover()
        ' Set the record position to the first record...
        objCurrencyManager.Position = position
        ' Show the current record position...
        ShowPosition()
        BindFields()
    End Sub
End Class