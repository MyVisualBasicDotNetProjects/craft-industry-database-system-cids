<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomer
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPosition = New System.Windows.Forms.TextBox()
        Me.btnMoveLast = New System.Windows.Forms.Button()
        Me.btnMoveNext = New System.Windows.Forms.Button()
        Me.btnMovePrevious = New System.Windows.Forms.Button()
        Me.btnMoveFirst = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cboForiegn = New System.Windows.Forms.ComboBox()
        Me.cboNational = New System.Windows.Forms.ComboBox()
        Me.cboRegional = New System.Windows.Forms.ComboBox()
        Me.cboLocal = New System.Windows.Forms.ComboBox()
        Me.cboDirectSale = New System.Windows.Forms.ComboBox()
        Me.chkForiegn = New System.Windows.Forms.CheckBox()
        Me.chkNational = New System.Windows.Forms.CheckBox()
        Me.chkRegional = New System.Windows.Forms.CheckBox()
        Me.chkLocal = New System.Windows.Forms.CheckBox()
        Me.chkDirectSale = New System.Windows.Forms.CheckBox()
        Me.chkIntermediaries = New System.Windows.Forms.CheckBox()
        Me.cboIntermediaries = New System.Windows.Forms.ComboBox()
        Me.txtFormId = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCustomerId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txthowOften = New System.Windows.Forms.TextBox()
        Me.txtQuantity = New System.Windows.Forms.MaskedTextBox()
        Me.cboPointOfSale = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.chkAdvances = New System.Windows.Forms.CheckBox()
        Me.chkBuying = New System.Windows.Forms.CheckBox()
        Me.txtPresumed = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.message = New System.Windows.Forms.ToolStripStatusLabel()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 8
        '
        'txtPosition
        '
        Me.txtPosition.Location = New System.Drawing.Point(158, 15)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(100, 20)
        Me.txtPosition.TabIndex = 71
        Me.txtPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnMoveLast
        '
        Me.btnMoveLast.Image = Global.Craft_Industry_Database.My.Resources.Resources.Last
        Me.btnMoveLast.Location = New System.Drawing.Point(305, 12)
        Me.btnMoveLast.Name = "btnMoveLast"
        Me.btnMoveLast.Size = New System.Drawing.Size(29, 23)
        Me.btnMoveLast.TabIndex = 70
        Me.btnMoveLast.UseVisualStyleBackColor = True
        '
        'btnMoveNext
        '
        Me.btnMoveNext.Image = Global.Craft_Industry_Database.My.Resources.Resources._Next
        Me.btnMoveNext.Location = New System.Drawing.Point(265, 12)
        Me.btnMoveNext.Name = "btnMoveNext"
        Me.btnMoveNext.Size = New System.Drawing.Size(29, 23)
        Me.btnMoveNext.TabIndex = 69
        Me.btnMoveNext.UseVisualStyleBackColor = True
        '
        'btnMovePrevious
        '
        Me.btnMovePrevious.Image = Global.Craft_Industry_Database.My.Resources.Resources.Back
        Me.btnMovePrevious.Location = New System.Drawing.Point(123, 12)
        Me.btnMovePrevious.Name = "btnMovePrevious"
        Me.btnMovePrevious.Size = New System.Drawing.Size(29, 23)
        Me.btnMovePrevious.TabIndex = 68
        Me.btnMovePrevious.UseVisualStyleBackColor = True
        '
        'btnMoveFirst
        '
        Me.btnMoveFirst.Image = Global.Craft_Industry_Database.My.Resources.Resources.First
        Me.btnMoveFirst.Location = New System.Drawing.Point(79, 12)
        Me.btnMoveFirst.Name = "btnMoveFirst"
        Me.btnMoveFirst.Size = New System.Drawing.Size(29, 23)
        Me.btnMoveFirst.TabIndex = 67
        Me.btnMoveFirst.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.txtFormId)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtCustomerId)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(337, 348)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Information"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboForiegn)
        Me.GroupBox2.Controls.Add(Me.cboNational)
        Me.GroupBox2.Controls.Add(Me.cboRegional)
        Me.GroupBox2.Controls.Add(Me.cboLocal)
        Me.GroupBox2.Controls.Add(Me.cboDirectSale)
        Me.GroupBox2.Controls.Add(Me.chkForiegn)
        Me.GroupBox2.Controls.Add(Me.chkNational)
        Me.GroupBox2.Controls.Add(Me.chkRegional)
        Me.GroupBox2.Controls.Add(Me.chkLocal)
        Me.GroupBox2.Controls.Add(Me.chkDirectSale)
        Me.GroupBox2.Controls.Add(Me.chkIntermediaries)
        Me.GroupBox2.Controls.Add(Me.cboIntermediaries)
        Me.GroupBox2.Location = New System.Drawing.Point(36, 65)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(262, 228)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Type and Importance of Customers"
        '
        'cboForiegn
        '
        Me.cboForiegn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboForiegn.Enabled = False
        Me.cboForiegn.FormattingEnabled = True
        Me.cboForiegn.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.cboForiegn.Location = New System.Drawing.Point(148, 199)
        Me.cboForiegn.Name = "cboForiegn"
        Me.cboForiegn.Size = New System.Drawing.Size(60, 21)
        Me.cboForiegn.TabIndex = 5
        '
        'cboNational
        '
        Me.cboNational.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNational.Enabled = False
        Me.cboNational.FormattingEnabled = True
        Me.cboNational.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.cboNational.Location = New System.Drawing.Point(148, 166)
        Me.cboNational.Name = "cboNational"
        Me.cboNational.Size = New System.Drawing.Size(60, 21)
        Me.cboNational.TabIndex = 4
        '
        'cboRegional
        '
        Me.cboRegional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRegional.Enabled = False
        Me.cboRegional.FormattingEnabled = True
        Me.cboRegional.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.cboRegional.Location = New System.Drawing.Point(148, 133)
        Me.cboRegional.Name = "cboRegional"
        Me.cboRegional.Size = New System.Drawing.Size(60, 21)
        Me.cboRegional.TabIndex = 3
        '
        'cboLocal
        '
        Me.cboLocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLocal.Enabled = False
        Me.cboLocal.FormattingEnabled = True
        Me.cboLocal.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.cboLocal.Location = New System.Drawing.Point(148, 100)
        Me.cboLocal.Name = "cboLocal"
        Me.cboLocal.Size = New System.Drawing.Size(60, 21)
        Me.cboLocal.TabIndex = 2
        '
        'cboDirectSale
        '
        Me.cboDirectSale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDirectSale.Enabled = False
        Me.cboDirectSale.FormattingEnabled = True
        Me.cboDirectSale.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.cboDirectSale.Location = New System.Drawing.Point(148, 67)
        Me.cboDirectSale.Name = "cboDirectSale"
        Me.cboDirectSale.Size = New System.Drawing.Size(60, 21)
        Me.cboDirectSale.TabIndex = 1
        '
        'chkForiegn
        '
        Me.chkForiegn.AutoSize = True
        Me.chkForiegn.Location = New System.Drawing.Point(37, 201)
        Me.chkForiegn.Name = "chkForiegn"
        Me.chkForiegn.Size = New System.Drawing.Size(61, 17)
        Me.chkForiegn.TabIndex = 15
        Me.chkForiegn.Text = "Foriegn"
        Me.chkForiegn.UseVisualStyleBackColor = True
        '
        'chkNational
        '
        Me.chkNational.AutoSize = True
        Me.chkNational.Location = New System.Drawing.Point(37, 168)
        Me.chkNational.Name = "chkNational"
        Me.chkNational.Size = New System.Drawing.Size(65, 17)
        Me.chkNational.TabIndex = 14
        Me.chkNational.Text = "National"
        Me.chkNational.UseVisualStyleBackColor = True
        '
        'chkRegional
        '
        Me.chkRegional.AutoSize = True
        Me.chkRegional.Location = New System.Drawing.Point(37, 135)
        Me.chkRegional.Name = "chkRegional"
        Me.chkRegional.Size = New System.Drawing.Size(68, 17)
        Me.chkRegional.TabIndex = 13
        Me.chkRegional.Text = "Regional"
        Me.chkRegional.UseVisualStyleBackColor = True
        '
        'chkLocal
        '
        Me.chkLocal.AutoSize = True
        Me.chkLocal.Location = New System.Drawing.Point(37, 102)
        Me.chkLocal.Name = "chkLocal"
        Me.chkLocal.Size = New System.Drawing.Size(52, 17)
        Me.chkLocal.TabIndex = 12
        Me.chkLocal.Text = "Local"
        Me.chkLocal.UseVisualStyleBackColor = True
        '
        'chkDirectSale
        '
        Me.chkDirectSale.AutoSize = True
        Me.chkDirectSale.Location = New System.Drawing.Point(37, 69)
        Me.chkDirectSale.Name = "chkDirectSale"
        Me.chkDirectSale.Size = New System.Drawing.Size(78, 17)
        Me.chkDirectSale.TabIndex = 11
        Me.chkDirectSale.Text = "Direct Sale"
        Me.chkDirectSale.UseVisualStyleBackColor = True
        '
        'chkIntermediaries
        '
        Me.chkIntermediaries.AutoSize = True
        Me.chkIntermediaries.Location = New System.Drawing.Point(37, 36)
        Me.chkIntermediaries.Name = "chkIntermediaries"
        Me.chkIntermediaries.Size = New System.Drawing.Size(91, 17)
        Me.chkIntermediaries.TabIndex = 10
        Me.chkIntermediaries.Text = "Intermediaries"
        Me.chkIntermediaries.UseVisualStyleBackColor = True
        '
        'cboIntermediaries
        '
        Me.cboIntermediaries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboIntermediaries.Enabled = False
        Me.cboIntermediaries.FormattingEnabled = True
        Me.cboIntermediaries.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.cboIntermediaries.Location = New System.Drawing.Point(148, 34)
        Me.cboIntermediaries.Name = "cboIntermediaries"
        Me.cboIntermediaries.Size = New System.Drawing.Size(60, 21)
        Me.cboIntermediaries.TabIndex = 0
        '
        'txtFormId
        '
        Me.txtFormId.Location = New System.Drawing.Point(141, 306)
        Me.txtFormId.Name = "txtFormId"
        Me.txtFormId.Size = New System.Drawing.Size(103, 20)
        Me.txtFormId.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 309)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "Form Id"
        '
        'txtCustomerId
        '
        Me.txtCustomerId.Location = New System.Drawing.Point(143, 28)
        Me.txtCustomerId.Name = "txtCustomerId"
        Me.txtCustomerId.ReadOnly = True
        Me.txtCustomerId.Size = New System.Drawing.Size(103, 20)
        Me.txtCustomerId.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 80
        Me.Label1.Text = "Customer Id"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txthowOften)
        Me.GroupBox3.Controls.Add(Me.txtQuantity)
        Me.GroupBox3.Controls.Add(Me.cboPointOfSale)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.chkAdvances)
        Me.GroupBox3.Controls.Add(Me.chkBuying)
        Me.GroupBox3.Controls.Add(Me.txtPresumed)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Enabled = False
        Me.GroupBox3.Location = New System.Drawing.Point(410, 65)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(314, 215)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "If customers are mostly intermediaries"
        '
        'txthowOften
        '
        Me.txthowOften.Location = New System.Drawing.Point(128, 48)
        Me.txthowOften.Name = "txthowOften"
        Me.txthowOften.Size = New System.Drawing.Size(107, 20)
        Me.txthowOften.TabIndex = 1
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(128, 22)
        Me.txtQuantity.Mask = "0000000"
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(107, 20)
        Me.txtQuantity.TabIndex = 0
        '
        'cboPointOfSale
        '
        Me.cboPointOfSale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPointOfSale.FormattingEnabled = True
        Me.cboPointOfSale.Items.AddRange(New Object() {"Known", "Unknown"})
        Me.cboPointOfSale.Location = New System.Drawing.Point(128, 139)
        Me.cboPointOfSale.Name = "cboPointOfSale"
        Me.cboPointOfSale.Size = New System.Drawing.Size(156, 21)
        Me.cboPointOfSale.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 143)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Final point of sale"
        '
        'chkAdvances
        '
        Me.chkAdvances.AutoSize = True
        Me.chkAdvances.Location = New System.Drawing.Point(21, 109)
        Me.chkAdvances.Name = "chkAdvances"
        Me.chkAdvances.Size = New System.Drawing.Size(116, 17)
        Me.chkAdvances.TabIndex = 3
        Me.chkAdvances.Text = "Possible Advances"
        Me.chkAdvances.UseVisualStyleBackColor = True
        '
        'chkBuying
        '
        Me.chkBuying.AutoSize = True
        Me.chkBuying.Location = New System.Drawing.Point(21, 81)
        Me.chkBuying.Name = "chkBuying"
        Me.chkBuying.Size = New System.Drawing.Size(99, 17)
        Me.chkBuying.TabIndex = 2
        Me.chkBuying.Text = "Buying to Order"
        Me.chkBuying.UseVisualStyleBackColor = True
        '
        'txtPresumed
        '
        Me.txtPresumed.Location = New System.Drawing.Point(130, 172)
        Me.txtPresumed.Name = "txtPresumed"
        Me.txtPresumed.Size = New System.Drawing.Size(156, 20)
        Me.txtPresumed.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 175)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Presumed"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Quantity Bought"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "How Often"
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(416, 307)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(66, 23)
        Me.btnNew.TabIndex = 2
        Me.btnNew.Text = "&New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(500, 307)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(66, 23)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(584, 307)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(66, 23)
        Me.btnUpdate.TabIndex = 4
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(668, 307)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(66, 23)
        Me.btnDelete.TabIndex = 5
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(535, 381)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 6
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(649, 381)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 7
        Me.btnNext.Text = "Ne&xt"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.message})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 424)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(768, 22)
        Me.StatusStrip1.TabIndex = 79
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'message
        '
        Me.message.Name = "message"
        Me.message.Size = New System.Drawing.Size(39, 17)
        Me.message.Text = "Ready"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(37, 25)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox1.TabIndex = 10
        Me.CheckBox1.Text = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(668, 13)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(52, 23)
        Me.btnRefresh.TabIndex = 8
        Me.btnRefresh.Text = "&Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'frmCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(768, 446)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtPosition)
        Me.Controls.Add(Me.btnMoveLast)
        Me.Controls.Add(Me.btnMoveNext)
        Me.Controls.Add(Me.btnMovePrevious)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnMoveFirst)
        Me.Controls.Add(Me.Label3)
        Me.Name = "frmCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "CIDS - Customer"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPosition As System.Windows.Forms.TextBox
    Friend WithEvents btnMoveLast As System.Windows.Forms.Button
    Friend WithEvents btnMoveNext As System.Windows.Forms.Button
    Friend WithEvents btnMovePrevious As System.Windows.Forms.Button
    Friend WithEvents btnMoveFirst As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtFormId As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerId As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cboPointOfSale As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents chkAdvances As System.Windows.Forms.CheckBox
    Friend WithEvents chkBuying As System.Windows.Forms.CheckBox
    Friend WithEvents txtPresumed As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents message As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cboIntermediaries As System.Windows.Forms.ComboBox
    Friend WithEvents chkForiegn As System.Windows.Forms.CheckBox
    Friend WithEvents chkNational As System.Windows.Forms.CheckBox
    Friend WithEvents chkRegional As System.Windows.Forms.CheckBox
    Friend WithEvents chkLocal As System.Windows.Forms.CheckBox
    Friend WithEvents chkDirectSale As System.Windows.Forms.CheckBox
    Friend WithEvents chkIntermediaries As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents cboForiegn As System.Windows.Forms.ComboBox
    Friend WithEvents cboNational As System.Windows.Forms.ComboBox
    Friend WithEvents cboRegional As System.Windows.Forms.ComboBox
    Friend WithEvents cboLocal As System.Windows.Forms.ComboBox
    Friend WithEvents cboDirectSale As System.Windows.Forms.ComboBox
    Friend WithEvents txtQuantity As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents txthowOften As System.Windows.Forms.TextBox
End Class
