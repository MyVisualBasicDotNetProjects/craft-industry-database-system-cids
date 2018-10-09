<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearch
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
        Me.gvSearch = New System.Windows.Forms.DataGridView()
        Me.cboSearchBy = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.btnSearchGo = New System.Windows.Forms.Button()
        Me.txtSearchText = New System.Windows.Forms.TextBox()
        Me.cboSearchFrom = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboCriteria = New System.Windows.Forms.ComboBox()
        Me.btnExport = New System.Windows.Forms.Button()
        CType(Me.gvSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gvSearch
        '
        Me.gvSearch.AllowUserToAddRows = False
        Me.gvSearch.AllowUserToDeleteRows = False
        Me.gvSearch.AllowUserToOrderColumns = True
        Me.gvSearch.AllowUserToResizeColumns = False
        Me.gvSearch.AllowUserToResizeRows = False
        Me.gvSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.gvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvSearch.Location = New System.Drawing.Point(22, 113)
        Me.gvSearch.Name = "gvSearch"
        Me.gvSearch.ReadOnly = True
        Me.gvSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvSearch.Size = New System.Drawing.Size(929, 431)
        Me.gvSearch.TabIndex = 115
        '
        'cboSearchBy
        '
        Me.cboSearchBy.FormattingEnabled = True
        Me.cboSearchBy.Location = New System.Drawing.Point(267, 56)
        Me.cboSearchBy.Name = "cboSearchBy"
        Me.cboSearchBy.Size = New System.Drawing.Size(188, 21)
        Me.cboSearchBy.Sorted = True
        Me.cboSearchBy.TabIndex = 1
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(264, 36)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(59, 13)
        Me.Label22.TabIndex = 117
        Me.Label22.Text = "Search By:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(601, 36)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(62, 13)
        Me.Label23.TabIndex = 116
        Me.Label23.Text = "Search For:"
        '
        'btnSearchGo
        '
        Me.btnSearchGo.Location = New System.Drawing.Point(889, 54)
        Me.btnSearchGo.Name = "btnSearchGo"
        Me.btnSearchGo.Size = New System.Drawing.Size(37, 23)
        Me.btnSearchGo.TabIndex = 114
        Me.btnSearchGo.Text = "Go"
        Me.btnSearchGo.UseVisualStyleBackColor = True
        '
        'txtSearchText
        '
        Me.txtSearchText.Location = New System.Drawing.Point(604, 57)
        Me.txtSearchText.Name = "txtSearchText"
        Me.txtSearchText.Size = New System.Drawing.Size(264, 20)
        Me.txtSearchText.TabIndex = 3
        '
        'cboSearchFrom
        '
        Me.cboSearchFrom.FormattingEnabled = True
        Me.cboSearchFrom.Items.AddRange(New Object() {"Craft Worker", "Definition", "Description", "Distribution", "Form", "Management", "Production", "Social Position", "Supply"})
        Me.cboSearchFrom.Location = New System.Drawing.Point(43, 57)
        Me.cboSearchFrom.Name = "cboSearchFrom"
        Me.cboSearchFrom.Size = New System.Drawing.Size(175, 21)
        Me.cboSearchFrom.Sorted = True
        Me.cboSearchFrom.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 119
        Me.Label1.Text = "Search From:"
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(649, 564)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(67, 23)
        Me.btnRefresh.TabIndex = 5
        Me.btnRefresh.Text = "&Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Enabled = False
        Me.Label2.Location = New System.Drawing.Point(506, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 122
        Me.Label2.Text = "Criteria:"
        '
        'cboCriteria
        '
        Me.cboCriteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCriteria.Enabled = False
        Me.cboCriteria.FormattingEnabled = True
        Me.cboCriteria.Items.AddRange(New Object() {"!=", "<", "<=", "=", ">", ">="})
        Me.cboCriteria.Location = New System.Drawing.Point(509, 56)
        Me.cboCriteria.Name = "cboCriteria"
        Me.cboCriteria.Size = New System.Drawing.Size(43, 21)
        Me.cboCriteria.Sorted = True
        Me.cboCriteria.TabIndex = 2
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(788, 564)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(123, 23)
        Me.btnExport.TabIndex = 4
        Me.btnExport.Text = "&Export to Excel"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'frmSearch
        '
        Me.AcceptButton = Me.btnSearchGo
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 602)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.cboCriteria)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.cboSearchFrom)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gvSearch)
        Me.Controls.Add(Me.cboSearchBy)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.btnSearchGo)
        Me.Controls.Add(Me.txtSearchText)
        Me.Name = "frmSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "CIDS - Search"
        CType(Me.gvSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gvSearch As System.Windows.Forms.DataGridView
    Friend WithEvents cboSearchBy As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents btnSearchGo As System.Windows.Forms.Button
    Friend WithEvents txtSearchText As System.Windows.Forms.TextBox
    Friend WithEvents cboSearchFrom As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboCriteria As System.Windows.Forms.ComboBox
    Friend WithEvents btnExport As System.Windows.Forms.Button
End Class
