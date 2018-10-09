Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Class frmEdit

    Public Shared newFile As String
    Public Shared lay_out As String

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click

        With OpenFileDialog1
            .Filter = "Picture Files (*.jpg)|*.jpg|All files (*.*)| *.*"
            .FilterIndex = 1
            .Title = "Open a background picture"
            .FileName = String.Empty
        End With

        'Show the open dialog and if the user clicks the open button load the file

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim myPicture As String

            Try
                'Save the file name
                myPicture = OpenFileDialog1.FileName

                ' FileCopy(myPicture, "C:\Windows")

                txtLocation.Text = myPicture

            Catch ex As Exception
                MessageBox.Show("Please select a picture file", "CIDS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click

        If txtLocation.Text = String.Empty Then

            MessageBox.Show("Please select a picture file", "CIDS Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            Dim file As New IO.FileInfo(txtLocation.Text)

            newFile = "C:\CIDS Image\background.jpg"
            lay_out = cboLayout.Text

            IO.Directory.CreateDirectory("C:\CIDS Image")
            ' mdiHome.BackgroundImage.Dispose()
            file.CopyTo(newFile, True)

            mdiHome.BackgroundImage = Image.FromFile(newFile)

            If lay_out.Equals("Stretch") Then
                mdiHome.BackgroundImageLayout = ImageLayout.Stretch
            ElseIf lay_out.Equals("Tile") Then
                mdiHome.BackgroundImageLayout = ImageLayout.Tile
            ElseIf lay_out.Equals("Center") Then
                mdiHome.BackgroundImageLayout = ImageLayout.Center
            ElseIf lay_out.Equals("Zoom") Then
                mdiHome.BackgroundImageLayout = ImageLayout.Zoom
            ElseIf lay_out.Equals("None") Then
                mdiHome.BackgroundImageLayout = ImageLayout.None
            End If

        End If

        'Dim connectionString As String = String.Empty
        'connectionString = ConfigurationManager.ConnectionStrings("connectionString").ConnectionString

        'Using myConnection As SqlConnection = New SqlConnection(connectionString)

        '    myConnection.Open()

        '    Using cmd As SqlCommand = myConnection.CreateCommand

        '        cmd.CommandType = CommandType.Text
        '        cmd.CommandText = "INSERT INTO tblImage (path, lay) " & _
        '                          "VALUES(@path, @lay)"

        '        cmd.Parameters.Add(New SqlParameter("@path", newFile))
        '        cmd.Parameters.Add(New SqlParameter("@lay", lay_out))

        '        Try
        '            cmd.ExecuteNonQuery()
        '            MessageBox.Show("The data is Inserted Successfully.", "CIDS")
        '        Catch ex As SqlException
        '            MessageBox.Show(ex.Message)
        '        End Try
        '    End Using
        'End Using

        'Me.Close()

    End Sub

    Private Sub frmEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cboLayout.SelectedIndex = 0

    End Sub
End Class