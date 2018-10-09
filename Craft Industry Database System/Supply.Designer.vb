<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSupply
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
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtLocation = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboOrigin = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cboWhy = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtFormId = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cboReasonElectric = New System.Windows.Forms.ComboBox()
        Me.cboReasonWater = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboReasonOil = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.chkNone = New System.Windows.Forms.CheckBox()
        Me.chkElectric = New System.Windows.Forms.CheckBox()
        Me.chkWater = New System.Windows.Forms.CheckBox()
        Me.chkOil = New System.Windows.Forms.CheckBox()
        Me.txtSupplyId = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtBoughtM = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBoughtW = New System.Windows.Forms.MaskedTextBox()
        Me.txtBoughtD = New System.Windows.Forms.MaskedTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtUsedM = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUsedW = New System.Windows.Forms.MaskedTextBox()
        Me.txtUsedD = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.message = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtPosition = New System.Windows.Forms.TextBox()
        Me.btnMoveLast = New System.Windows.Forms.Button()
        Me.btnMoveNext = New System.Windows.Forms.Button()
        Me.btnMovePrevious = New System.Windows.Forms.Button()
        Me.btnMoveFirst = New System.Windows.Forms.Button()
        Me.cboNone = New System.Windows.Forms.CheckBox()
        Me.Hid = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.cboDistance = New System.Windows.Forms.ComboBox()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnNew)
        Me.GroupBox4.Controls.Add(Me.btnSave)
        Me.GroupBox4.Controls.Add(Me.btnUpdate)
        Me.GroupBox4.Controls.Add(Me.btnDelete)
        Me.GroupBox4.Controls.Add(Me.GroupBox5)
        Me.GroupBox4.Controls.Add(Me.txtFormId)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.GroupBox3)
        Me.GroupBox4.Controls.Add(Me.txtSupplyId)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.GroupBox1)
        Me.GroupBox4.Controls.Add(Me.GroupBox2)
        Me.GroupBox4.Location = New System.Drawing.Point(23, 37)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(762, 510)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Supply"
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(230, 469)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(66, 23)
        Me.btnNew.TabIndex = 6
        Me.btnNew.Text = "&New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(314, 469)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(66, 23)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(398, 469)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(66, 23)
        Me.btnUpdate.TabIndex = 8
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(482, 469)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(66, 23)
        Me.btnDelete.TabIndex = 9
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.cboDistance)
        Me.GroupBox5.Controls.Add(Me.txtLocation)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Controls.Add(Me.cboOrigin)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.cboWhy)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Location = New System.Drawing.Point(45, 60)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(369, 175)
        Me.GroupBox5.TabIndex = 1
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Raw Material Information"
        '
        'txtLocation
        '
        Me.txtLocation.Location = New System.Drawing.Point(149, 102)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(190, 20)
        Me.txtLocation.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Raw Material Origin"
        '
        'cboOrigin
        '
        Me.cboOrigin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOrigin.FormattingEnabled = True
        Me.cboOrigin.Items.AddRange(New Object() {"Local", "Abroad"})
        Me.cboOrigin.Location = New System.Drawing.Point(149, 29)
        Me.cboOrigin.Name = "cboOrigin"
        Me.cboOrigin.Size = New System.Drawing.Size(195, 21)
        Me.cboOrigin.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 13)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "Distance (in Km)"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(20, 105)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 13)
        Me.Label13.TabIndex = 43
        Me.Label13.Text = "Location"
        '
        'cboWhy
        '
        Me.cboWhy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboWhy.FormattingEnabled = True
        Me.cboWhy.Items.AddRange(New Object() {"Not found locally", "The local product is expensive", "The local product has no quality", "The local product is not avialable easily", "Other"})
        Me.cboWhy.Location = New System.Drawing.Point(149, 135)
        Me.cboWhy.Name = "cboWhy"
        Me.cboWhy.Size = New System.Drawing.Size(195, 21)
        Me.cboWhy.TabIndex = 3
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(20, 138)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(104, 13)
        Me.Label14.TabIndex = 44
        Me.Label14.Text = "If from Abroad, why?"
        '
        'txtFormId
        '
        Me.txtFormId.Location = New System.Drawing.Point(533, 399)
        Me.txtFormId.Name = "txtFormId"
        Me.txtFormId.Size = New System.Drawing.Size(187, 20)
        Me.txtFormId.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(461, 402)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "Form Id"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cboReasonElectric)
        Me.GroupBox3.Controls.Add(Me.cboReasonWater)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.cboReasonOil)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.chkNone)
        Me.GroupBox3.Controls.Add(Me.chkElectric)
        Me.GroupBox3.Controls.Add(Me.chkWater)
        Me.GroupBox3.Controls.Add(Me.chkOil)
        Me.GroupBox3.Location = New System.Drawing.Point(45, 241)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(369, 206)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Type of Power used in production"
        '
        'cboReasonElectric
        '
        Me.cboReasonElectric.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboReasonElectric.Enabled = False
        Me.cboReasonElectric.FormattingEnabled = True
        Me.cboReasonElectric.Items.AddRange(New Object() {"Not found easily.", "It is expensive.", "It is not important."})
        Me.cboReasonElectric.Location = New System.Drawing.Point(140, 165)
        Me.cboReasonElectric.Name = "cboReasonElectric"
        Me.cboReasonElectric.Size = New System.Drawing.Size(204, 21)
        Me.cboReasonElectric.TabIndex = 7
        '
        'cboReasonWater
        '
        Me.cboReasonWater.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboReasonWater.Enabled = False
        Me.cboReasonWater.FormattingEnabled = True
        Me.cboReasonWater.Items.AddRange(New Object() {"Not found easily.", "It is expensive.", "It is not important."})
        Me.cboReasonWater.Location = New System.Drawing.Point(140, 132)
        Me.cboReasonWater.Name = "cboReasonWater"
        Me.cboReasonWater.Size = New System.Drawing.Size(204, 21)
        Me.cboReasonWater.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Enabled = False
        Me.Label11.Location = New System.Drawing.Point(39, 168)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 13)
        Me.Label11.TabIndex = 64
        Me.Label11.Text = "Electric"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Enabled = False
        Me.Label9.Location = New System.Drawing.Point(39, 135)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 13)
        Me.Label9.TabIndex = 63
        Me.Label9.Text = "Water"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Enabled = False
        Me.Label8.Location = New System.Drawing.Point(42, 98)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(19, 13)
        Me.Label8.TabIndex = 62
        Me.Label8.Text = "Oil"
        '
        'cboReasonOil
        '
        Me.cboReasonOil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboReasonOil.Enabled = False
        Me.cboReasonOil.FormattingEnabled = True
        Me.cboReasonOil.Items.AddRange(New Object() {"Not found easily.", "It is expensive.", "It is not important."})
        Me.cboReasonOil.Location = New System.Drawing.Point(140, 98)
        Me.cboReasonOil.Name = "cboReasonOil"
        Me.cboReasonOil.Size = New System.Drawing.Size(204, 21)
        Me.cboReasonOil.TabIndex = 5
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Enabled = False
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(20, 68)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(63, 13)
        Me.Label23.TabIndex = 4
        Me.Label23.Text = "Reasons?"
        '
        'chkNone
        '
        Me.chkNone.AutoSize = True
        Me.chkNone.Location = New System.Drawing.Point(292, 32)
        Me.chkNone.Name = "chkNone"
        Me.chkNone.Size = New System.Drawing.Size(52, 17)
        Me.chkNone.TabIndex = 3
        Me.chkNone.Text = "None"
        Me.chkNone.UseVisualStyleBackColor = True
        '
        'chkElectric
        '
        Me.chkElectric.AutoSize = True
        Me.chkElectric.Location = New System.Drawing.Point(207, 32)
        Me.chkElectric.Name = "chkElectric"
        Me.chkElectric.Size = New System.Drawing.Size(61, 17)
        Me.chkElectric.TabIndex = 2
        Me.chkElectric.Text = "Electric"
        Me.chkElectric.UseVisualStyleBackColor = True
        '
        'chkWater
        '
        Me.chkWater.AutoSize = True
        Me.chkWater.Location = New System.Drawing.Point(112, 32)
        Me.chkWater.Name = "chkWater"
        Me.chkWater.Size = New System.Drawing.Size(55, 17)
        Me.chkWater.TabIndex = 1
        Me.chkWater.Text = "Water"
        Me.chkWater.UseVisualStyleBackColor = True
        '
        'chkOil
        '
        Me.chkOil.AutoSize = True
        Me.chkOil.Location = New System.Drawing.Point(24, 32)
        Me.chkOil.Name = "chkOil"
        Me.chkOil.Size = New System.Drawing.Size(38, 17)
        Me.chkOil.TabIndex = 0
        Me.chkOil.Text = "Oil"
        Me.chkOil.UseVisualStyleBackColor = True
        '
        'txtSupplyId
        '
        Me.txtSupplyId.Location = New System.Drawing.Point(185, 27)
        Me.txtSupplyId.Name = "txtSupplyId"
        Me.txtSupplyId.ReadOnly = True
        Me.txtSupplyId.Size = New System.Drawing.Size(229, 20)
        Me.txtSupplyId.TabIndex = 0
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(42, 27)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(51, 13)
        Me.Label16.TabIndex = 51
        Me.Label16.Text = "Supply Id"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtBoughtM)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtBoughtW)
        Me.GroupBox1.Controls.Add(Me.txtBoughtD)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Location = New System.Drawing.Point(464, 251)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(256, 134)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Raw Material Bought (in Birr)"
        '
        'txtBoughtM
        '
        Me.txtBoughtM.Location = New System.Drawing.Point(90, 93)
        Me.txtBoughtM.Mask = "00000000"
        Me.txtBoughtM.Name = "txtBoughtM"
        Me.txtBoughtM.Size = New System.Drawing.Size(136, 20)
        Me.txtBoughtM.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "per day"
        '
        'txtBoughtW
        '
        Me.txtBoughtW.Location = New System.Drawing.Point(90, 58)
        Me.txtBoughtW.Mask = "00000000"
        Me.txtBoughtW.Name = "txtBoughtW"
        Me.txtBoughtW.Size = New System.Drawing.Size(136, 20)
        Me.txtBoughtW.TabIndex = 1
        '
        'txtBoughtD
        '
        Me.txtBoughtD.Location = New System.Drawing.Point(90, 24)
        Me.txtBoughtD.Mask = "00000000"
        Me.txtBoughtD.Name = "txtBoughtD"
        Me.txtBoughtD.Size = New System.Drawing.Size(136, 20)
        Me.txtBoughtD.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(20, 61)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 13)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "per week"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(20, 96)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(54, 13)
        Me.Label19.TabIndex = 12
        Me.Label19.Text = "per month"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtUsedM)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtUsedW)
        Me.GroupBox2.Controls.Add(Me.txtUsedD)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(464, 76)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(256, 134)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Raw Material Used (in Birr)"
        '
        'txtUsedM
        '
        Me.txtUsedM.Location = New System.Drawing.Point(90, 93)
        Me.txtUsedM.Mask = "00000000"
        Me.txtUsedM.Name = "txtUsedM"
        Me.txtUsedM.Size = New System.Drawing.Size(136, 20)
        Me.txtUsedM.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "per day"
        '
        'txtUsedW
        '
        Me.txtUsedW.Location = New System.Drawing.Point(90, 58)
        Me.txtUsedW.Mask = "00000000"
        Me.txtUsedW.Name = "txtUsedW"
        Me.txtUsedW.Size = New System.Drawing.Size(136, 20)
        Me.txtUsedW.TabIndex = 1
        '
        'txtUsedD
        '
        Me.txtUsedD.Location = New System.Drawing.Point(90, 24)
        Me.txtUsedD.Mask = "00000000"
        Me.txtUsedD.Name = "txtUsedD"
        Me.txtUsedD.Size = New System.Drawing.Size(136, 20)
        Me.txtUsedD.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "per week"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "per month"
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(577, 558)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 6
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(684, 558)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 5
        Me.btnNext.Text = "Ne&xt"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.message})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 591)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(844, 22)
        Me.StatusStrip1.TabIndex = 39
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'message
        '
        Me.message.Name = "message"
        Me.message.Size = New System.Drawing.Size(39, 17)
        Me.message.Text = "Ready"
        '
        'txtPosition
        '
        Me.txtPosition.Location = New System.Drawing.Point(321, 11)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(100, 20)
        Me.txtPosition.TabIndex = 49
        Me.txtPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnMoveLast
        '
        Me.btnMoveLast.Image = Global.Craft_Industry_Database.My.Resources.Resources.Last
        Me.btnMoveLast.Location = New System.Drawing.Point(468, 8)
        Me.btnMoveLast.Name = "btnMoveLast"
        Me.btnMoveLast.Size = New System.Drawing.Size(29, 23)
        Me.btnMoveLast.TabIndex = 48
        Me.btnMoveLast.UseVisualStyleBackColor = True
        '
        'btnMoveNext
        '
        Me.btnMoveNext.Image = Global.Craft_Industry_Database.My.Resources.Resources._Next
        Me.btnMoveNext.Location = New System.Drawing.Point(428, 8)
        Me.btnMoveNext.Name = "btnMoveNext"
        Me.btnMoveNext.Size = New System.Drawing.Size(29, 23)
        Me.btnMoveNext.TabIndex = 47
        Me.btnMoveNext.UseVisualStyleBackColor = True
        '
        'btnMovePrevious
        '
        Me.btnMovePrevious.Image = Global.Craft_Industry_Database.My.Resources.Resources.Back
        Me.btnMovePrevious.Location = New System.Drawing.Point(286, 8)
        Me.btnMovePrevious.Name = "btnMovePrevious"
        Me.btnMovePrevious.Size = New System.Drawing.Size(29, 23)
        Me.btnMovePrevious.TabIndex = 46
        Me.btnMovePrevious.UseVisualStyleBackColor = True
        '
        'btnMoveFirst
        '
        Me.btnMoveFirst.Image = Global.Craft_Industry_Database.My.Resources.Resources.First
        Me.btnMoveFirst.Location = New System.Drawing.Point(242, 8)
        Me.btnMoveFirst.Name = "btnMoveFirst"
        Me.btnMoveFirst.Size = New System.Drawing.Size(29, 23)
        Me.btnMoveFirst.TabIndex = 45
        Me.btnMoveFirst.UseVisualStyleBackColor = True
        '
        'cboNone
        '
        Me.cboNone.AutoSize = True
        Me.cboNone.Location = New System.Drawing.Point(292, 32)
        Me.cboNone.Name = "cboNone"
        Me.cboNone.Size = New System.Drawing.Size(52, 17)
        Me.cboNone.TabIndex = 3
        Me.cboNone.Text = "None"
        Me.cboNone.UseVisualStyleBackColor = True
        '
        'Hid
        '
        Me.Hid.AutoSize = True
        Me.Hid.Location = New System.Drawing.Point(-3, 259)
        Me.Hid.Name = "Hid"
        Me.Hid.Size = New System.Drawing.Size(39, 13)
        Me.Hid.TabIndex = 58
        Me.Hid.Text = "Label1"
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(627, 9)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(52, 23)
        Me.btnRefresh.TabIndex = 1
        Me.btnRefresh.Text = "&Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'cboDistance
        '
        Me.cboDistance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDistance.FormattingEnabled = True
        Me.cboDistance.Items.AddRange(New Object() {"Below 5 KMs", "Between 5 - 10 KMs", "Between 10 - 20 KMs", "Between 20 - 30 KMs", "Between 30 - 40 KMs", "Between 40 - 50 KMs", "Above 50 KMs"})
        Me.cboDistance.Location = New System.Drawing.Point(149, 62)
        Me.cboDistance.Name = "cboDistance"
        Me.cboDistance.Size = New System.Drawing.Size(195, 21)
        Me.cboDistance.TabIndex = 58
        '
        'frmSupply
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 613)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.Hid)
        Me.Controls.Add(Me.txtPosition)
        Me.Controls.Add(Me.btnMoveLast)
        Me.Controls.Add(Me.btnMoveNext)
        Me.Controls.Add(Me.btnMovePrevious)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnMoveFirst)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.btnNext)
        Me.Name = "frmSupply"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "CIDS - Supply"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboOrigin As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSupplyId As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents message As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents chkElectric As System.Windows.Forms.CheckBox
    Friend WithEvents chkWater As System.Windows.Forms.CheckBox
    Friend WithEvents chkOil As System.Windows.Forms.CheckBox
    Friend WithEvents txtFormId As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboWhy As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents chkNone As System.Windows.Forms.CheckBox
    Friend WithEvents cboReasonElectric As System.Windows.Forms.ComboBox
    Friend WithEvents cboReasonWater As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cboReasonOil As System.Windows.Forms.ComboBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents txtPosition As System.Windows.Forms.TextBox
    Friend WithEvents btnMoveLast As System.Windows.Forms.Button
    Friend WithEvents btnMoveNext As System.Windows.Forms.Button
    Friend WithEvents btnMovePrevious As System.Windows.Forms.Button
    Friend WithEvents btnMoveFirst As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents cboNone As System.Windows.Forms.CheckBox
    Friend WithEvents Hid As System.Windows.Forms.Label
    Friend WithEvents txtBoughtM As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtBoughtW As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtBoughtD As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtUsedM As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtUsedW As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtUsedD As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtLocation As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents cboDistance As System.Windows.Forms.ComboBox
End Class
