<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsers
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
        Me.picClose = New System.Windows.Forms.PictureBox()
        Me.picMinimize = New System.Windows.Forms.PictureBox()
        Me.lblType = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.trVisible = New System.Windows.Forms.Timer(Me.components)
        Me.txtUserName = New System.Windows.Forms.TextBox()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picClose
        '
        Me.picClose.Image = Global.Craft_Industry_Database.My.Resources.Resources.close
        Me.picClose.Location = New System.Drawing.Point(748, 6)
        Me.picClose.Name = "picClose"
        Me.picClose.Size = New System.Drawing.Size(22, 19)
        Me.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picClose.TabIndex = 58
        Me.picClose.TabStop = False
        '
        'picMinimize
        '
        Me.picMinimize.Image = Global.Craft_Industry_Database.My.Resources.Resources.minimize
        Me.picMinimize.Location = New System.Drawing.Point(712, 6)
        Me.picMinimize.Name = "picMinimize"
        Me.picMinimize.Size = New System.Drawing.Size(21, 19)
        Me.picMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMinimize.TabIndex = 57
        Me.picMinimize.TabStop = False
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Location = New System.Drawing.Point(460, 227)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(66, 13)
        Me.lblType.TabIndex = 56
        Me.lblType.Text = "Type of user"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(582, 147)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(170, 20)
        Me.txtPassword.TabIndex = 1
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.No
        Me.btnCancel.Location = New System.Drawing.Point(680, 192)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(70, 23)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "&Cancel"
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(588, 193)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(78, 23)
        Me.btnOk.TabIndex = 2
        Me.btnOk.Text = "&OK"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkGray
        Me.Label2.Location = New System.Drawing.Point(579, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 14)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGray
        Me.Label1.Location = New System.Drawing.Point(579, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 14)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "User Account"
        '
        'trVisible
        '
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(582, 89)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtUserName.Size = New System.Drawing.Size(170, 20)
        Me.txtUserName.TabIndex = 60
        '
        'frmUsers
        '
        Me.AcceptButton = Me.btnOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Craft_Industry_Database.My.Resources.Resources.bguseraccount
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(796, 282)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.picClose)
        Me.Controls.Add(Me.picMinimize)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmUsers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Users"
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picClose As System.Windows.Forms.PictureBox
    Friend WithEvents picMinimize As System.Windows.Forms.PictureBox
    Friend WithEvents lblType As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    '   Friend WithEvents CraftIndustryDataSet As Craft_Industry_Database.CraftIndustryDataSet
    ' Friend WithEvents TblUserTableAdapter As Craft_Industry_Database.CraftIndustryDataSetTableAdapters.tblUserTableAdapter
    Friend WithEvents trVisible As System.Windows.Forms.Timer
    '  Friend WithEvents CraftIndustryDataSet1 As Craft_Industry_Database.CraftIndustryDataSet
    '  Friend WithEvents TblUserTableAdapter1 As Craft_Industry_Database.CraftIndustryDataSetTableAdapters.tblUserTableAdapter
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
End Class
