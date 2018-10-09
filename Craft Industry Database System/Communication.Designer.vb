<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCommunication
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtFormId = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboPort = New System.Windows.Forms.ComboBox()
        Me.cboAirport = New System.Windows.Forms.ComboBox()
        Me.cboNavigableWater = New System.Windows.Forms.ComboBox()
        Me.cboTrain = New System.Windows.Forms.ComboBox()
        Me.cboMainRoad = New System.Windows.Forms.ComboBox()
        Me.cboTruck = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtPosition = New System.Windows.Forms.TextBox()
        Me.btnMoveLast = New System.Windows.Forms.Button()
        Me.btnMoveNext = New System.Windows.Forms.Button()
        Me.btnMovePrevious = New System.Windows.Forms.Button()
        Me.btnMoveFirst = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.message = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCommunicationId = New System.Windows.Forms.TextBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtFormId)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.btnNew)
        Me.GroupBox3.Controls.Add(Me.btnSave)
        Me.GroupBox3.Controls.Add(Me.btnUpdate)
        Me.GroupBox3.Controls.Add(Me.btnDelete)
        Me.GroupBox3.Controls.Add(Me.cboPort)
        Me.GroupBox3.Controls.Add(Me.cboAirport)
        Me.GroupBox3.Controls.Add(Me.cboNavigableWater)
        Me.GroupBox3.Controls.Add(Me.cboTrain)
        Me.GroupBox3.Controls.Add(Me.cboMainRoad)
        Me.GroupBox3.Controls.Add(Me.cboTruck)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Location = New System.Drawing.Point(40, 89)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(347, 301)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Distance from"
        '
        'txtFormId
        '
        Me.txtFormId.Location = New System.Drawing.Point(131, 215)
        Me.txtFormId.Name = "txtFormId"
        Me.txtFormId.Size = New System.Drawing.Size(100, 20)
        Me.txtFormId.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(25, 218)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 64
        Me.Label7.Text = "Form Id"
        '
        'cboPort
        '
        Me.cboPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPort.FormattingEnabled = True
        Me.cboPort.Items.AddRange(New Object() {"Below 1 KM", "Between 1 - 10 KM", "Unknown"})
        Me.cboPort.Location = New System.Drawing.Point(131, 179)
        Me.cboPort.Name = "cboPort"
        Me.cboPort.Size = New System.Drawing.Size(176, 21)
        Me.cboPort.TabIndex = 5
        '
        'cboAirport
        '
        Me.cboAirport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAirport.FormattingEnabled = True
        Me.cboAirport.Items.AddRange(New Object() {"Below 1 KM", "Between 1 - 10 KM", "Unknown"})
        Me.cboAirport.Location = New System.Drawing.Point(131, 146)
        Me.cboAirport.Name = "cboAirport"
        Me.cboAirport.Size = New System.Drawing.Size(176, 21)
        Me.cboAirport.TabIndex = 4
        '
        'cboNavigableWater
        '
        Me.cboNavigableWater.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNavigableWater.FormattingEnabled = True
        Me.cboNavigableWater.Items.AddRange(New Object() {"Below 1 KM", "Between 1 - 10 KM", "Unknown"})
        Me.cboNavigableWater.Location = New System.Drawing.Point(131, 116)
        Me.cboNavigableWater.Name = "cboNavigableWater"
        Me.cboNavigableWater.Size = New System.Drawing.Size(176, 21)
        Me.cboNavigableWater.TabIndex = 3
        '
        'cboTrain
        '
        Me.cboTrain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTrain.FormattingEnabled = True
        Me.cboTrain.Items.AddRange(New Object() {"Below 1 KM", "Between 1 - 10 KM", "Unknown"})
        Me.cboTrain.Location = New System.Drawing.Point(131, 86)
        Me.cboTrain.Name = "cboTrain"
        Me.cboTrain.Size = New System.Drawing.Size(176, 21)
        Me.cboTrain.TabIndex = 2
        '
        'cboMainRoad
        '
        Me.cboMainRoad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMainRoad.FormattingEnabled = True
        Me.cboMainRoad.Items.AddRange(New Object() {"Below 1 KM", "Between 1 - 10 KM", "Unknown"})
        Me.cboMainRoad.Location = New System.Drawing.Point(131, 56)
        Me.cboMainRoad.Name = "cboMainRoad"
        Me.cboMainRoad.Size = New System.Drawing.Size(176, 21)
        Me.cboMainRoad.TabIndex = 1
        '
        'cboTruck
        '
        Me.cboTruck.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTruck.FormattingEnabled = True
        Me.cboTruck.Items.AddRange(New Object() {"Below 1 KM", "Between 1 - 10 KM", "Unknown"})
        Me.cboTruck.Location = New System.Drawing.Point(131, 30)
        Me.cboTruck.Name = "cboTruck"
        Me.cboTruck.Size = New System.Drawing.Size(176, 21)
        Me.cboTruck.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 179)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Port"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Airport"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Navigable water"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Main road"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Train"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(25, 33)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Track"
        '
        'txtPosition
        '
        Me.txtPosition.Location = New System.Drawing.Point(167, 21)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(100, 20)
        Me.txtPosition.TabIndex = 54
        Me.txtPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnMoveLast
        '
        Me.btnMoveLast.Image = Global.Craft_Industry_Database.My.Resources.Resources.Last
        Me.btnMoveLast.Location = New System.Drawing.Point(314, 18)
        Me.btnMoveLast.Name = "btnMoveLast"
        Me.btnMoveLast.Size = New System.Drawing.Size(29, 23)
        Me.btnMoveLast.TabIndex = 53
        Me.btnMoveLast.UseVisualStyleBackColor = True
        '
        'btnMoveNext
        '
        Me.btnMoveNext.Image = Global.Craft_Industry_Database.My.Resources.Resources._Next
        Me.btnMoveNext.Location = New System.Drawing.Point(274, 18)
        Me.btnMoveNext.Name = "btnMoveNext"
        Me.btnMoveNext.Size = New System.Drawing.Size(29, 23)
        Me.btnMoveNext.TabIndex = 52
        Me.btnMoveNext.UseVisualStyleBackColor = True
        '
        'btnMovePrevious
        '
        Me.btnMovePrevious.Image = Global.Craft_Industry_Database.My.Resources.Resources.Back
        Me.btnMovePrevious.Location = New System.Drawing.Point(132, 18)
        Me.btnMovePrevious.Name = "btnMovePrevious"
        Me.btnMovePrevious.Size = New System.Drawing.Size(29, 23)
        Me.btnMovePrevious.TabIndex = 51
        Me.btnMovePrevious.UseVisualStyleBackColor = True
        '
        'btnMoveFirst
        '
        Me.btnMoveFirst.Image = Global.Craft_Industry_Database.My.Resources.Resources.First
        Me.btnMoveFirst.Location = New System.Drawing.Point(88, 18)
        Me.btnMoveFirst.Name = "btnMoveFirst"
        Me.btnMoveFirst.Size = New System.Drawing.Size(29, 23)
        Me.btnMoveFirst.TabIndex = 50
        Me.btnMoveFirst.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(215, 402)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 1
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(314, 402)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 2
        Me.btnNext.Text = "Ne&xt"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.message})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 440)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(439, 22)
        Me.StatusStrip1.TabIndex = 57
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'message
        '
        Me.message.Name = "message"
        Me.message.Size = New System.Drawing.Size(39, 17)
        Me.message.Text = "Ready"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(52, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 13)
        Me.Label6.TabIndex = 58
        Me.Label6.Text = "Communication Id"
        '
        'txtCommunicationId
        '
        Me.txtCommunicationId.Location = New System.Drawing.Point(153, 53)
        Me.txtCommunicationId.Name = "txtCommunicationId"
        Me.txtCommunicationId.ReadOnly = True
        Me.txtCommunicationId.Size = New System.Drawing.Size(100, 20)
        Me.txtCommunicationId.TabIndex = 59
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(364, 19)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(52, 23)
        Me.btnRefresh.TabIndex = 61
        Me.btnRefresh.Text = "&Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(267, 258)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(66, 23)
        Me.btnDelete.TabIndex = 10
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(183, 258)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(66, 23)
        Me.btnUpdate.TabIndex = 9
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(99, 258)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(66, 23)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(15, 258)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(66, 23)
        Me.btnNew.TabIndex = 7
        Me.btnNew.Text = "&New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'frmCommunication
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 462)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.txtCommunicationId)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.txtPosition)
        Me.Controls.Add(Me.btnMoveLast)
        Me.Controls.Add(Me.btnMoveNext)
        Me.Controls.Add(Me.btnMovePrevious)
        Me.Controls.Add(Me.btnMoveFirst)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "frmCommunication"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "CIDS - Communication"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cboPort As System.Windows.Forms.ComboBox
    Friend WithEvents cboAirport As System.Windows.Forms.ComboBox
    Friend WithEvents cboNavigableWater As System.Windows.Forms.ComboBox
    Friend WithEvents cboTrain As System.Windows.Forms.ComboBox
    Friend WithEvents cboMainRoad As System.Windows.Forms.ComboBox
    Friend WithEvents cboTruck As System.Windows.Forms.ComboBox
    Friend WithEvents txtPosition As System.Windows.Forms.TextBox
    Friend WithEvents btnMoveLast As System.Windows.Forms.Button
    Friend WithEvents btnMoveNext As System.Windows.Forms.Button
    Friend WithEvents btnMovePrevious As System.Windows.Forms.Button
    Friend WithEvents btnMoveFirst As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents message As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCommunicationId As System.Windows.Forms.TextBox
    Friend WithEvents txtFormId As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
End Class
