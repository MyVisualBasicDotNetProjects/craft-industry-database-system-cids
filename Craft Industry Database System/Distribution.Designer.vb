<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDistribution
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
        Me.cboSellingMethod = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkInternational = New System.Windows.Forms.CheckBox()
        Me.chkNational = New System.Windows.Forms.CheckBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.chkExport = New System.Windows.Forms.CheckBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.cboTransportation = New System.Windows.Forms.ComboBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cboTypeOfPackaging = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.chkPackaging = New System.Windows.Forms.CheckBox()
        Me.txtDistributionId = New System.Windows.Forms.TextBox()
        Me.txtFormId = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtSurfaceArea = New System.Windows.Forms.MaskedTextBox()
        Me.chkDisplay = New System.Windows.Forms.CheckBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboPlace = New System.Windows.Forms.ComboBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.message = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.txtPosition = New System.Windows.Forms.TextBox()
        Me.btnMoveLast = New System.Windows.Forms.Button()
        Me.btnMoveNext = New System.Windows.Forms.Button()
        Me.btnMovePrevious = New System.Windows.Forms.Button()
        Me.btnMoveFirst = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboSellingMethod
        '
        Me.cboSellingMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSellingMethod.FormattingEnabled = True
        Me.cboSellingMethod.Items.AddRange(New Object() {"Advertising", "Special offers", "Shop windows", "None"})
        Me.cboSellingMethod.Location = New System.Drawing.Point(139, 68)
        Me.cboSellingMethod.Name = "cboSellingMethod"
        Me.cboSellingMethod.Size = New System.Drawing.Size(182, 21)
        Me.cboSellingMethod.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Distribution Id"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Selling Method"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnNew)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.chkExport)
        Me.GroupBox1.Controls.Add(Me.btnUpdate)
        Me.GroupBox1.Controls.Add(Me.cboTransportation)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.txtDistributionId)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtFormId)
        Me.GroupBox1.Controls.Add(Me.cboSellingMethod)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(694, 359)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Distribution / Commercialization Information"
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(351, 321)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(66, 23)
        Me.btnNew.TabIndex = 8
        Me.btnNew.Text = "&New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkInternational)
        Me.GroupBox2.Controls.Add(Me.chkNational)
        Me.GroupBox2.Location = New System.Drawing.Point(402, 32)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(224, 78)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Experience at trade fairs and exhibitions"
        '
        'chkInternational
        '
        Me.chkInternational.AutoSize = True
        Me.chkInternational.Location = New System.Drawing.Point(58, 48)
        Me.chkInternational.Name = "chkInternational"
        Me.chkInternational.Size = New System.Drawing.Size(84, 17)
        Me.chkInternational.TabIndex = 1
        Me.chkInternational.Text = "International"
        Me.chkInternational.UseVisualStyleBackColor = True
        '
        'chkNational
        '
        Me.chkNational.AutoSize = True
        Me.chkNational.Location = New System.Drawing.Point(58, 25)
        Me.chkNational.Name = "chkNational"
        Me.chkNational.Size = New System.Drawing.Size(65, 17)
        Me.chkNational.TabIndex = 0
        Me.chkNational.Text = "National"
        Me.chkNational.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(435, 321)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(66, 23)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'chkExport
        '
        Me.chkExport.AutoSize = True
        Me.chkExport.Location = New System.Drawing.Point(460, 118)
        Me.chkExport.Name = "chkExport"
        Me.chkExport.Size = New System.Drawing.Size(112, 17)
        Me.chkExport.TabIndex = 6
        Me.chkExport.Text = "Export Experience"
        Me.chkExport.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(519, 321)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(66, 23)
        Me.btnUpdate.TabIndex = 10
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'cboTransportation
        '
        Me.cboTransportation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTransportation.FormattingEnabled = True
        Me.cboTransportation.Items.AddRange(New Object() {"On foot", "Road", "Train", "Plane", "Boat", "Animal"})
        Me.cboTransportation.Location = New System.Drawing.Point(152, 283)
        Me.cboTransportation.Name = "cboTransportation"
        Me.cboTransportation.Size = New System.Drawing.Size(186, 21)
        Me.cboTransportation.TabIndex = 4
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(603, 321)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(66, 23)
        Me.btnDelete.TabIndex = 11
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(29, 286)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(122, 13)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "Means of Transportation"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cboTypeOfPackaging)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.chkPackaging)
        Me.GroupBox4.Location = New System.Drawing.Point(399, 148)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(270, 106)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Packaging"
        '
        'cboTypeOfPackaging
        '
        Me.cboTypeOfPackaging.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTypeOfPackaging.Enabled = False
        Me.cboTypeOfPackaging.FormattingEnabled = True
        Me.cboTypeOfPackaging.Items.AddRange(New Object() {"Made locally by the craft worker", "Made locally by another worker", "Purchased in the country", "Purchased abroad "})
        Me.cboTypeOfPackaging.Location = New System.Drawing.Point(61, 77)
        Me.cboTypeOfPackaging.Name = "cboTypeOfPackaging"
        Me.cboTypeOfPackaging.Size = New System.Drawing.Size(195, 21)
        Me.cboTypeOfPackaging.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Enabled = False
        Me.Label12.Location = New System.Drawing.Point(29, 52)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(97, 13)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Type of Packaging"
        '
        'chkPackaging
        '
        Me.chkPackaging.AutoSize = True
        Me.chkPackaging.Location = New System.Drawing.Point(32, 23)
        Me.chkPackaging.Name = "chkPackaging"
        Me.chkPackaging.Size = New System.Drawing.Size(195, 17)
        Me.chkPackaging.TabIndex = 0
        Me.chkPackaging.Text = "Packaging is used for transportation"
        Me.chkPackaging.UseVisualStyleBackColor = True
        '
        'txtDistributionId
        '
        Me.txtDistributionId.Location = New System.Drawing.Point(139, 32)
        Me.txtDistributionId.Name = "txtDistributionId"
        Me.txtDistributionId.ReadOnly = True
        Me.txtDistributionId.Size = New System.Drawing.Size(156, 20)
        Me.txtDistributionId.TabIndex = 0
        '
        'txtFormId
        '
        Me.txtFormId.Location = New System.Drawing.Point(113, 243)
        Me.txtFormId.Name = "txtFormId"
        Me.txtFormId.Size = New System.Drawing.Size(145, 20)
        Me.txtFormId.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(29, 243)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 13)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "Form Id"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtSurfaceArea)
        Me.GroupBox5.Controls.Add(Me.chkDisplay)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.cboPlace)
        Me.GroupBox5.Location = New System.Drawing.Point(21, 104)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(317, 119)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        '
        'txtSurfaceArea
        '
        Me.txtSurfaceArea.Enabled = False
        Me.txtSurfaceArea.Location = New System.Drawing.Point(175, 81)
        Me.txtSurfaceArea.Mask = "00000000"
        Me.txtSurfaceArea.Name = "txtSurfaceArea"
        Me.txtSurfaceArea.Size = New System.Drawing.Size(124, 20)
        Me.txtSurfaceArea.TabIndex = 3
        '
        'chkDisplay
        '
        Me.chkDisplay.AutoSize = True
        Me.chkDisplay.Location = New System.Drawing.Point(12, 19)
        Me.chkDisplay.Name = "chkDisplay"
        Me.chkDisplay.Size = New System.Drawing.Size(173, 17)
        Me.chkDisplay.TabIndex = 1
        Me.chkDisplay.Text = "I have a place to display goods"
        Me.chkDisplay.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Enabled = False
        Me.Label13.Location = New System.Drawing.Point(33, 85)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(136, 13)
        Me.Label13.TabIndex = 44
        Me.Label13.Text = "Surface area (in sq. meters)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Enabled = False
        Me.Label9.Location = New System.Drawing.Point(33, 51)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Place:"
        '
        'cboPlace
        '
        Me.cboPlace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPlace.Enabled = False
        Me.cboPlace.FormattingEnabled = True
        Me.cboPlace.Items.AddRange(New Object() {"In the workplace", "Shop ", "Windows display", "Airport"})
        Me.cboPlace.Location = New System.Drawing.Point(92, 47)
        Me.cboPlace.Name = "cboPlace"
        Me.cboPlace.Size = New System.Drawing.Size(207, 21)
        Me.cboPlace.TabIndex = 2
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.message})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 460)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(750, 22)
        Me.StatusStrip1.TabIndex = 39
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'message
        '
        Me.message.Name = "message"
        Me.message.Size = New System.Drawing.Size(39, 17)
        Me.message.Text = "Ready"
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(605, 422)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 2
        Me.btnNext.Text = "Ne&xt"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(58, 48)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(84, 17)
        Me.CheckBox2.TabIndex = 10
        Me.CheckBox2.Text = "International"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(491, 422)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 1
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'txtPosition
        '
        Me.txtPosition.Location = New System.Drawing.Point(333, 11)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(100, 20)
        Me.txtPosition.TabIndex = 66
        Me.txtPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnMoveLast
        '
        Me.btnMoveLast.Image = Global.Craft_Industry_Database.My.Resources.Resources.Last
        Me.btnMoveLast.Location = New System.Drawing.Point(480, 8)
        Me.btnMoveLast.Name = "btnMoveLast"
        Me.btnMoveLast.Size = New System.Drawing.Size(29, 23)
        Me.btnMoveLast.TabIndex = 65
        Me.btnMoveLast.UseVisualStyleBackColor = True
        '
        'btnMoveNext
        '
        Me.btnMoveNext.Image = Global.Craft_Industry_Database.My.Resources.Resources._Next
        Me.btnMoveNext.Location = New System.Drawing.Point(440, 8)
        Me.btnMoveNext.Name = "btnMoveNext"
        Me.btnMoveNext.Size = New System.Drawing.Size(29, 23)
        Me.btnMoveNext.TabIndex = 64
        Me.btnMoveNext.UseVisualStyleBackColor = True
        '
        'btnMovePrevious
        '
        Me.btnMovePrevious.Image = Global.Craft_Industry_Database.My.Resources.Resources.Back
        Me.btnMovePrevious.Location = New System.Drawing.Point(298, 8)
        Me.btnMovePrevious.Name = "btnMovePrevious"
        Me.btnMovePrevious.Size = New System.Drawing.Size(29, 23)
        Me.btnMovePrevious.TabIndex = 63
        Me.btnMovePrevious.UseVisualStyleBackColor = True
        '
        'btnMoveFirst
        '
        Me.btnMoveFirst.Image = Global.Craft_Industry_Database.My.Resources.Resources.First
        Me.btnMoveFirst.Location = New System.Drawing.Point(254, 8)
        Me.btnMoveFirst.Name = "btnMoveFirst"
        Me.btnMoveFirst.Size = New System.Drawing.Size(29, 23)
        Me.btnMoveFirst.TabIndex = 62
        Me.btnMoveFirst.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(657, 9)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(52, 23)
        Me.btnRefresh.TabIndex = 3
        Me.btnRefresh.Text = "&Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'frmDistribution
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 482)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.txtPosition)
        Me.Controls.Add(Me.btnMoveLast)
        Me.Controls.Add(Me.btnMoveNext)
        Me.Controls.Add(Me.btnMovePrevious)
        Me.Controls.Add(Me.btnMoveFirst)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmDistribution"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "CIDS - Distribution"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboSellingMethod As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDistributionId As System.Windows.Forms.TextBox
    Friend WithEvents cboPlace As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents chkDisplay As System.Windows.Forms.CheckBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents message As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtFormId As System.Windows.Forms.TextBox
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    'Friend WithEvents CraftIndustryDataSet As Craft_Industry_Database.CraftIndustryDataSet
    'Friend WithEvents TblDistributionTableAdapter As Craft_Industry_Database.CraftIndustryDataSetTableAdapters.tblDistributionTableAdapter
    'Friend WithEvents TableAdapterManager As Craft_Industry_Database.CraftIndustryDataSetTableAdapters.TableAdapterManager
    'Friend WithEvents CraftIndustryDataSet1 As Craft_Industry_Database.CraftIndustryDataSet
    'Friend WithEvents TblDistributionTableAdapter1 As Craft_Industry_Database.CraftIndustryDataSetTableAdapters.tblDistributionTableAdapter
    'Friend WithEvents TableAdapterManager1 As Craft_Industry_Database.CraftIndustryDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPosition As System.Windows.Forms.TextBox
    Friend WithEvents btnMoveLast As System.Windows.Forms.Button
    Friend WithEvents btnMoveNext As System.Windows.Forms.Button
    Friend WithEvents btnMovePrevious As System.Windows.Forms.Button
    Friend WithEvents btnMoveFirst As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkInternational As System.Windows.Forms.CheckBox
    Friend WithEvents chkNational As System.Windows.Forms.CheckBox
    Friend WithEvents chkExport As System.Windows.Forms.CheckBox
    Friend WithEvents cboTransportation As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cboTypeOfPackaging As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents chkPackaging As System.Windows.Forms.CheckBox
    Friend WithEvents txtSurfaceArea As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
End Class
