<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mdiHome
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
            frmUsers.Close()
        End Try
    End Sub


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.NewToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GoToToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DescriptionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CraftWorkerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DefinitionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WorkshopToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SocialPositionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupplyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RateOfProductionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CommunicationToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DistributionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompetitionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TaxToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserLoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackgroundToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowsMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.CascadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileVerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileHorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem1, Me.GoToToolStripMenuItem, Me.EditToolStripMenuItem, Me.WindowsMenu, Me.HelpMenu})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.MdiWindowListItem = Me.WindowsMenu
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(632, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'NewToolStripMenuItem1
        '
        Me.NewToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FormToolStripMenuItem1, Me.SearchToolStripMenuItem})
        Me.NewToolStripMenuItem1.Name = "NewToolStripMenuItem1"
        Me.NewToolStripMenuItem1.Size = New System.Drawing.Size(37, 20)
        Me.NewToolStripMenuItem1.Text = "File"
        '
        'FormToolStripMenuItem1
        '
        Me.FormToolStripMenuItem1.Name = "FormToolStripMenuItem1"
        Me.FormToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.FormToolStripMenuItem1.Text = "&All Forms"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SearchToolStripMenuItem.Text = "&Search"
        '
        'GoToToolStripMenuItem
        '
        Me.GoToToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FormToolStripMenuItem2, Me.DescriptionToolStripMenuItem, Me.ProductionToolStripMenuItem, Me.CraftWorkerToolStripMenuItem, Me.DefinitionToolStripMenuItem, Me.WorkshopToolStripMenuItem1, Me.SocialPositionToolStripMenuItem, Me.SupplyToolStripMenuItem, Me.RateOfProductionToolStripMenuItem, Me.CommunicationToolStripMenuItem1, Me.ManagementToolStripMenuItem, Me.DistributionToolStripMenuItem, Me.CustomerToolStripMenuItem1, Me.CompetitionToolStripMenuItem, Me.TaxToolStripMenuItem1, Me.UserLoginToolStripMenuItem})
        Me.GoToToolStripMenuItem.Name = "GoToToolStripMenuItem"
        Me.GoToToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.GoToToolStripMenuItem.Text = "Go To"
        '
        'FormToolStripMenuItem2
        '
        Me.FormToolStripMenuItem2.Name = "FormToolStripMenuItem2"
        Me.FormToolStripMenuItem2.Size = New System.Drawing.Size(173, 22)
        Me.FormToolStripMenuItem2.Text = "Form"
        '
        'DescriptionToolStripMenuItem
        '
        Me.DescriptionToolStripMenuItem.Name = "DescriptionToolStripMenuItem"
        Me.DescriptionToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.DescriptionToolStripMenuItem.Text = "Description"
        '
        'ProductionToolStripMenuItem
        '
        Me.ProductionToolStripMenuItem.Name = "ProductionToolStripMenuItem"
        Me.ProductionToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.ProductionToolStripMenuItem.Text = "Production"
        '
        'CraftWorkerToolStripMenuItem
        '
        Me.CraftWorkerToolStripMenuItem.Name = "CraftWorkerToolStripMenuItem"
        Me.CraftWorkerToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.CraftWorkerToolStripMenuItem.Text = "Craft Worker"
        '
        'DefinitionToolStripMenuItem
        '
        Me.DefinitionToolStripMenuItem.Name = "DefinitionToolStripMenuItem"
        Me.DefinitionToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.DefinitionToolStripMenuItem.Text = "Definition"
        '
        'WorkshopToolStripMenuItem1
        '
        Me.WorkshopToolStripMenuItem1.Name = "WorkshopToolStripMenuItem1"
        Me.WorkshopToolStripMenuItem1.Size = New System.Drawing.Size(173, 22)
        Me.WorkshopToolStripMenuItem1.Text = "Workshop"
        '
        'SocialPositionToolStripMenuItem
        '
        Me.SocialPositionToolStripMenuItem.Name = "SocialPositionToolStripMenuItem"
        Me.SocialPositionToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.SocialPositionToolStripMenuItem.Text = "Social Position"
        '
        'SupplyToolStripMenuItem
        '
        Me.SupplyToolStripMenuItem.Name = "SupplyToolStripMenuItem"
        Me.SupplyToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.SupplyToolStripMenuItem.Text = "Supply"
        '
        'RateOfProductionToolStripMenuItem
        '
        Me.RateOfProductionToolStripMenuItem.Name = "RateOfProductionToolStripMenuItem"
        Me.RateOfProductionToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.RateOfProductionToolStripMenuItem.Text = "Rate of Production"
        '
        'CommunicationToolStripMenuItem1
        '
        Me.CommunicationToolStripMenuItem1.Name = "CommunicationToolStripMenuItem1"
        Me.CommunicationToolStripMenuItem1.Size = New System.Drawing.Size(173, 22)
        Me.CommunicationToolStripMenuItem1.Text = "Communication"
        '
        'ManagementToolStripMenuItem
        '
        Me.ManagementToolStripMenuItem.Name = "ManagementToolStripMenuItem"
        Me.ManagementToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.ManagementToolStripMenuItem.Text = "Management"
        '
        'DistributionToolStripMenuItem
        '
        Me.DistributionToolStripMenuItem.Name = "DistributionToolStripMenuItem"
        Me.DistributionToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.DistributionToolStripMenuItem.Text = "Distribution"
        '
        'CustomerToolStripMenuItem1
        '
        Me.CustomerToolStripMenuItem1.Name = "CustomerToolStripMenuItem1"
        Me.CustomerToolStripMenuItem1.Size = New System.Drawing.Size(173, 22)
        Me.CustomerToolStripMenuItem1.Text = "Customer"
        '
        'CompetitionToolStripMenuItem
        '
        Me.CompetitionToolStripMenuItem.Name = "CompetitionToolStripMenuItem"
        Me.CompetitionToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.CompetitionToolStripMenuItem.Text = "Competition"
        '
        'TaxToolStripMenuItem1
        '
        Me.TaxToolStripMenuItem1.Name = "TaxToolStripMenuItem1"
        Me.TaxToolStripMenuItem1.Size = New System.Drawing.Size(173, 22)
        Me.TaxToolStripMenuItem1.Text = "Tax"
        '
        'UserLoginToolStripMenuItem
        '
        Me.UserLoginToolStripMenuItem.Name = "UserLoginToolStripMenuItem"
        Me.UserLoginToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.UserLoginToolStripMenuItem.Text = "User Login"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackgroundToolStripMenuItem, Me.ChangePasswordToolStripMenuItem1})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(136, 20)
        Me.EditToolStripMenuItem.Text = "System Administraton"
        '
        'BackgroundToolStripMenuItem
        '
        Me.BackgroundToolStripMenuItem.Enabled = False
        Me.BackgroundToolStripMenuItem.Name = "BackgroundToolStripMenuItem"
        Me.BackgroundToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.BackgroundToolStripMenuItem.Text = "Background"
        '
        'ChangePasswordToolStripMenuItem1
        '
        Me.ChangePasswordToolStripMenuItem1.Name = "ChangePasswordToolStripMenuItem1"
        Me.ChangePasswordToolStripMenuItem1.Size = New System.Drawing.Size(168, 22)
        Me.ChangePasswordToolStripMenuItem1.Text = "Change Password"
        '
        'WindowsMenu
        '
        Me.WindowsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CascadeToolStripMenuItem, Me.TileVerticalToolStripMenuItem, Me.TileHorizontalToolStripMenuItem, Me.ExitProgramToolStripMenuItem})
        Me.WindowsMenu.Name = "WindowsMenu"
        Me.WindowsMenu.Size = New System.Drawing.Size(68, 20)
        Me.WindowsMenu.Text = "&Windows"
        '
        'CascadeToolStripMenuItem
        '
        Me.CascadeToolStripMenuItem.Name = "CascadeToolStripMenuItem"
        Me.CascadeToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.CascadeToolStripMenuItem.Text = "&Cascade"
        '
        'TileVerticalToolStripMenuItem
        '
        Me.TileVerticalToolStripMenuItem.Name = "TileVerticalToolStripMenuItem"
        Me.TileVerticalToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.TileVerticalToolStripMenuItem.Text = "Tile &Vertical"
        '
        'TileHorizontalToolStripMenuItem
        '
        Me.TileHorizontalToolStripMenuItem.Name = "TileHorizontalToolStripMenuItem"
        Me.TileHorizontalToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.TileHorizontalToolStripMenuItem.Text = "Tile &Horizontal"
        '
        'ExitProgramToolStripMenuItem
        '
        Me.ExitProgramToolStripMenuItem.Name = "ExitProgramToolStripMenuItem"
        Me.ExitProgramToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.ExitProgramToolStripMenuItem.Text = "E&xit Program"
        '
        'HelpMenu
        '
        Me.HelpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpMenu.Name = "HelpMenu"
        Me.HelpMenu.Size = New System.Drawing.Size(44, 20)
        Me.HelpMenu.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.AboutToolStripMenuItem.Text = "&About ..."
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 431)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(632, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'mdiHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "mdiHome"
        Me.Text = "Craft Industry Database System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HelpMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents NewToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FormToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GoToToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FormToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DescriptionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CraftWorkerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DefinitionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WorkshopToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SocialPositionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupplyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RateOfProductionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManagementToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DistributionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CompetitionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TaxToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserLoginToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackgroundToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CommunicationToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WindowsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CascadeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileVerticalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileHorizontalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitProgramToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
