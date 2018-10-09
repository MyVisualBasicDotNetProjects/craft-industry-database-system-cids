Imports System.Windows.Forms
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports Craft_Industry_Database.frmUsers
Imports System.IO

'Imports Craft_Industry_Database.frmEdit

Public Class mdiHome

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub

    'Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
    '    Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    'End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    'Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
    '    ' Close all child forms of the parent.
    '    For Each ChildForm As frmForm In Me.MdiChildren
    '        ChildForm.Close()
    '    Next
    'End Sub

    Private m_ChildFormNumber As Integer

    Private Sub FormToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FormToolStripMenuItem1.Click

        Dim form As New frmForm
        form.MdiParent = Me
        form.Show()

        If user = True Then
            form.btnNew.Enabled = False
            form.btnDelete.Enabled = False
            form.btnSave.Enabled = False
            form.btnUpdate.Enabled = False
        End If

    End Sub

    Private Sub FormToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FormToolStripMenuItem2.Click

        Dim form As New frmForm
        form.MdiParent = Me
        form.Show()

        ' If user = True Then
        form.btnNew.Enabled = False
        form.btnDelete.Enabled = False
        form.btnSave.Enabled = False
        form.btnUpdate.Enabled = False
        '   End If

    End Sub

    Private Sub DescriptionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DescriptionToolStripMenuItem.Click

        Dim form As New frmDescription
        form.MdiParent = Me
        form.Show()

        ' If user = True Then
        form.btnNew.Enabled = False
        form.btnDelete.Enabled = False
        form.btnSave.Enabled = False
        form.btnUpdate.Enabled = False
        '   End If

    End Sub

    Private Sub ProductionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductionToolStripMenuItem.Click

        Dim form As New frmProduction
        form.MdiParent = Me
        form.Show()

        '  If user = True Then
        form.btnNew.Enabled = False
        form.btnDelete.Enabled = False
        form.btnSave.Enabled = False
        form.btnUpdate.Enabled = False
        '  End If

    End Sub

    Private Sub CraftWorkerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CraftWorkerToolStripMenuItem.Click

        Dim form As New frmCraftWorker
        form.MdiParent = Me
        form.Show()

        '   If user = True Then
        form.btnNew.Enabled = False
        form.btnDelete.Enabled = False
        form.btnSave.Enabled = False
        form.btnUpdate.Enabled = False
        '  End If

    End Sub

    Private Sub DefinitionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefinitionToolStripMenuItem.Click

        Dim form As New frmDefinition
        form.MdiParent = Me
        form.Show()

        '    If user = True Then
        form.btnNew.Enabled = False
        form.btnDelete.Enabled = False
        form.btnSave.Enabled = False
        form.btnUpdate.Enabled = False
        '  End If

    End Sub

    Private Sub WorkshopToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WorkshopToolStripMenuItem1.Click

        Dim form As New frmWorkshop
        form.MdiParent = Me
        form.Show()

        '  If user = True Then
        form.btnNew.Enabled = False
        form.btnDelete.Enabled = False
        form.btnSave.Enabled = False
        form.btnUpdate.Enabled = False
        ' End If

    End Sub

    Private Sub SocialPositionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SocialPositionToolStripMenuItem.Click

        Dim form As New frmSocialPosition
        form.MdiParent = Me
        form.Show()

    End Sub

    Private Sub SupplyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupplyToolStripMenuItem.Click

        Dim form As New frmSupply
        form.MdiParent = Me
        form.Show()

        '  If user = True Then
        form.btnNew.Enabled = False
        form.btnDelete.Enabled = False
        form.btnSave.Enabled = False
        form.btnUpdate.Enabled = False
        '  End If

    End Sub

    Private Sub BackgroundToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackgroundToolStripMenuItem.Click

        Dim form As New frmEdit
        form.MdiParent = Me
        form.Show()

    End Sub

    Private Sub RateOfProductionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RateOfProductionToolStripMenuItem.Click

        Dim form As New frmRateOfProduction
        form.MdiParent = Me
        form.Show()

        '   If user = True Then
        form.btnNew.Enabled = False
        form.btnDelete.Enabled = False
        form.btnSave.Enabled = False
        form.btnUpdate.Enabled = False
        '  End If

    End Sub

    Private Sub ManagementToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManagementToolStripMenuItem.Click

        Dim form As New frmManagement
        form.MdiParent = Me
        form.Show()

        '     If user = True Then
        form.btnNew.Enabled = False
        form.btnDelete.Enabled = False
        form.btnSave.Enabled = False
        form.btnUpdate.Enabled = False
        '   End If

    End Sub

    Private Sub CompetitionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompetitionToolStripMenuItem.Click

        Dim form As New frmCompetition
        form.MdiParent = Me
        form.Show()

        '   If user = True Then
        form.btnNew.Enabled = False
        form.btnDelete.Enabled = False
        form.btnSave.Enabled = False
        form.btnUpdate.Enabled = False
        '  End If

    End Sub

    Private Sub TaxToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TaxToolStripMenuItem1.Click

        Dim form As New frmTax
        form.MdiParent = Me
        form.Show()

        '    If user = True Then
        form.btnNew.Enabled = False
        form.btnDelete.Enabled = False
        form.btnSave.Enabled = False
        form.btnUpdate.Enabled = False
        '   End If

    End Sub

    Private Sub UserLoginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserLoginToolStripMenuItem.Click

        Dim form As New frmUsers
        form.Show()
        Me.Hide()
    End Sub

    Private Sub mdiHome_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frmUsers.Dispose()
        frmUsers.Close()
    End Sub

    Private Sub mdiHome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If admin = True Then

            BackgroundToolStripMenuItem.Enabled = True

        End If

        ToolStripStatusLabel.Text = "Today is: " & Now.Date.ToString

        'Dim connectionString As String = String.Empty
        'connectionString = ConfigurationManager.ConnectionStrings("connectionString").ConnectionString

        'Dim fileName As String = String.Empty
        'Dim lay_out As String = String.Empty

        'Using myConnection As SqlConnection = New SqlConnection(connectionString)

        '    myConnection.Open()

        '    Using cmd As SqlCommand = myConnection.CreateCommand

        '        cmd.CommandType = CommandType.Text
        '        cmd.CommandText = "SELECT * FROM tblImage"

        '        Dim reader As SqlDataReader = cmd.ExecuteReader

        '        While reader.Read

        '            fileName = reader("path")
        '            lay_out = reader("lay")

        '        End While

        '    End Using

        'End Using

        'Me.BackgroundImage = Image.FromFile(fileName)

        'If lay_out.Equals("Stretch") Then
        '    Me.BackgroundImageLayout = ImageLayout.Stretch
        'ElseIf lay_out.Equals("Tile") Then
        '    Me.BackgroundImageLayout = ImageLayout.Tile
        'ElseIf lay_out.Equals("Center") Then
        '    Me.BackgroundImageLayout = ImageLayout.Center
        'ElseIf lay_out.Equals("Zoom") Then
        '    Me.BackgroundImageLayout = ImageLayout.Zoom
        'ElseIf lay_out.Equals("None") Then
        '    Me.BackgroundImageLayout = ImageLayout.None
        'End If

        Try
            Dim newFile As String = "C:\CIDS Image\background.jpg"

            Me.BackgroundImage = Image.FromFile(newFile)
            Me.BackgroundImageLayout = ImageLayout.Stretch
        Catch ex As FileNotFoundException
            MessageBox.Show("Please copy the folder named 'C:\CIDS Image\background.jpg' to Local Disk C." & vbNewLine & "Thank you!")
        End Try



    End Sub

    Private Sub CommunicationToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CommunicationToolStripMenuItem1.Click

        Dim form As New frmCommunication
        form.MdiParent = Me
        form.Show()

        '   If user = True Then
        form.btnNew.Enabled = False
        form.btnDelete.Enabled = False
        form.btnSave.Enabled = False
        form.btnUpdate.Enabled = False
        ' End If

    End Sub

    Private Sub DistributionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DistributionToolStripMenuItem.Click

        Dim form As New frmDistribution
        form.MdiParent = Me
        form.Show()

        '   If user = True Then
        form.btnNew.Enabled = False
        form.btnDelete.Enabled = False
        form.btnSave.Enabled = False
        form.btnUpdate.Enabled = False
        '   End If

    End Sub

    Private Sub CustomerToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerToolStripMenuItem1.Click

        Dim form As New frmCustomer
        form.MdiParent = Me
        form.Show()

        '  If user = True Then
        form.btnNew.Enabled = False
        form.btnDelete.Enabled = False
        form.btnSave.Enabled = False
        form.btnUpdate.Enabled = False
        ' End If

    End Sub

    Private Sub ChangePasswordToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangePasswordToolStripMenuItem1.Click

        Dim form As New frmChangePassword
        form.MdiParent = Me
        form.Show()

    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click

        Dim form As New About
        form.MdiParent = Me
        form.Show()

    End Sub

    Private Sub ExitProgramToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitProgramToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub SearchToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchToolStripMenuItem.Click

        Dim form As New frmSearch
        form.MdiParent = Me
        form.Show()

    End Sub
End Class
