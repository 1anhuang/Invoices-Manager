<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class invInfoForm
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(invInfoForm))
        Me.invHeader_dgv = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.移至新增欄位ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.註銷發票ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.detail_dgv = New System.Windows.Forms.DataGridView()
        Me.insertShow_btn = New System.Windows.Forms.Button()
        Me.filter_btn = New System.Windows.Forms.Button()
        Me.note_txt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.dtlDwn_btn = New System.Windows.Forms.Button()
        Me.dtlUP_btn = New System.Windows.Forms.Button()
        Me.invDwn_btn = New System.Windows.Forms.Button()
        Me.invUp_btn = New System.Windows.Forms.Button()
        Me.delt_btn = New System.Windows.Forms.Button()
        Me.invSum_lb = New System.Windows.Forms.Label()
        Me.dtSum_Lb = New System.Windows.Forms.Label()
        Me.modeChange_btn = New System.Windows.Forms.Button()
        Me.modiShow_btn = New System.Windows.Forms.Button()
        CType(Me.invHeader_dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.detail_dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'invHeader_dgv
        '
        Me.invHeader_dgv.BackgroundColor = System.Drawing.SystemColors.Control
        Me.invHeader_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.invHeader_dgv.ContextMenuStrip = Me.ContextMenuStrip1
        Me.invHeader_dgv.Location = New System.Drawing.Point(12, 42)
        Me.invHeader_dgv.MultiSelect = False
        Me.invHeader_dgv.Name = "invHeader_dgv"
        Me.invHeader_dgv.ReadOnly = True
        Me.invHeader_dgv.RowTemplate.Height = 24
        Me.invHeader_dgv.Size = New System.Drawing.Size(685, 302)
        Me.invHeader_dgv.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.移至新增欄位ToolStripMenuItem, Me.註銷發票ToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(149, 48)
        '
        '移至新增欄位ToolStripMenuItem
        '
        Me.移至新增欄位ToolStripMenuItem.Name = "移至新增欄位ToolStripMenuItem"
        Me.移至新增欄位ToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.移至新增欄位ToolStripMenuItem.Text = "移至新增欄位"
        '
        '註銷發票ToolStripMenuItem
        '
        Me.註銷發票ToolStripMenuItem.Name = "註銷發票ToolStripMenuItem"
        Me.註銷發票ToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.註銷發票ToolStripMenuItem.Text = "註銷發票"
        '
        'detail_dgv
        '
        Me.detail_dgv.BackgroundColor = System.Drawing.SystemColors.Control
        Me.detail_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.detail_dgv.Location = New System.Drawing.Point(11, 398)
        Me.detail_dgv.MultiSelect = False
        Me.detail_dgv.Name = "detail_dgv"
        Me.detail_dgv.ReadOnly = True
        Me.detail_dgv.RowTemplate.Height = 24
        Me.detail_dgv.Size = New System.Drawing.Size(686, 151)
        Me.detail_dgv.TabIndex = 1
        '
        'insertShow_btn
        '
        Me.insertShow_btn.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.insertShow_btn.Location = New System.Drawing.Point(266, 679)
        Me.insertShow_btn.Name = "insertShow_btn"
        Me.insertShow_btn.Size = New System.Drawing.Size(70, 29)
        Me.insertShow_btn.TabIndex = 2
        Me.insertShow_btn.Text = "新增"
        Me.insertShow_btn.UseVisualStyleBackColor = True
        '
        'filter_btn
        '
        Me.filter_btn.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.filter_btn.Location = New System.Drawing.Point(172, 679)
        Me.filter_btn.Name = "filter_btn"
        Me.filter_btn.Size = New System.Drawing.Size(70, 29)
        Me.filter_btn.TabIndex = 3
        Me.filter_btn.Text = "過濾"
        Me.filter_btn.UseVisualStyleBackColor = True
        '
        'note_txt
        '
        Me.note_txt.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.note_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.note_txt.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.note_txt.Location = New System.Drawing.Point(11, 603)
        Me.note_txt.Multiline = True
        Me.note_txt.Name = "note_txt"
        Me.note_txt.ReadOnly = True
        Me.note_txt.Size = New System.Drawing.Size(686, 48)
        Me.note_txt.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 579)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 21)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "發票備註"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 374)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 21)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "發票明細"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 21)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "發票資料"
        '
        'dtlDwn_btn
        '
        Me.dtlDwn_btn.BackColor = System.Drawing.Color.Transparent
        Me.dtlDwn_btn.BackgroundImage = Global.InvoicesManager_ver2.My.Resources.Resources._1411426484_down_32
        Me.dtlDwn_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.dtlDwn_btn.FlatAppearance.BorderSize = 0
        Me.dtlDwn_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dtlDwn_btn.Location = New System.Drawing.Point(703, 476)
        Me.dtlDwn_btn.Name = "dtlDwn_btn"
        Me.dtlDwn_btn.Size = New System.Drawing.Size(40, 34)
        Me.dtlDwn_btn.TabIndex = 20
        Me.ToolTip1.SetToolTip(Me.dtlDwn_btn, "下一筆")
        Me.dtlDwn_btn.UseVisualStyleBackColor = False
        '
        'dtlUP_btn
        '
        Me.dtlUP_btn.BackColor = System.Drawing.Color.Transparent
        Me.dtlUP_btn.BackgroundImage = Global.InvoicesManager_ver2.My.Resources.Resources._1411426445_up_32
        Me.dtlUP_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.dtlUP_btn.FlatAppearance.BorderSize = 0
        Me.dtlUP_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dtlUP_btn.Location = New System.Drawing.Point(703, 427)
        Me.dtlUP_btn.Name = "dtlUP_btn"
        Me.dtlUP_btn.Size = New System.Drawing.Size(40, 34)
        Me.dtlUP_btn.TabIndex = 19
        Me.ToolTip1.SetToolTip(Me.dtlUP_btn, "上一筆")
        Me.dtlUP_btn.UseVisualStyleBackColor = False
        '
        'invDwn_btn
        '
        Me.invDwn_btn.BackColor = System.Drawing.Color.Transparent
        Me.invDwn_btn.BackgroundImage = Global.InvoicesManager_ver2.My.Resources.Resources._1411426484_down_32
        Me.invDwn_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.invDwn_btn.FlatAppearance.BorderSize = 0
        Me.invDwn_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.invDwn_btn.Location = New System.Drawing.Point(703, 218)
        Me.invDwn_btn.Name = "invDwn_btn"
        Me.invDwn_btn.Size = New System.Drawing.Size(40, 34)
        Me.invDwn_btn.TabIndex = 18
        Me.ToolTip1.SetToolTip(Me.invDwn_btn, "下一筆")
        Me.invDwn_btn.UseVisualStyleBackColor = False
        '
        'invUp_btn
        '
        Me.invUp_btn.BackColor = System.Drawing.Color.Transparent
        Me.invUp_btn.BackgroundImage = Global.InvoicesManager_ver2.My.Resources.Resources._1411426445_up_32
        Me.invUp_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.invUp_btn.FlatAppearance.BorderSize = 0
        Me.invUp_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.invUp_btn.Location = New System.Drawing.Point(703, 169)
        Me.invUp_btn.Name = "invUp_btn"
        Me.invUp_btn.Size = New System.Drawing.Size(40, 34)
        Me.invUp_btn.TabIndex = 17
        Me.ToolTip1.SetToolTip(Me.invUp_btn, "上一筆")
        Me.invUp_btn.UseVisualStyleBackColor = False
        '
        'delt_btn
        '
        Me.delt_btn.BackColor = System.Drawing.Color.Transparent
        Me.delt_btn.BackgroundImage = Global.InvoicesManager_ver2.My.Resources.Resources._1411229961_editor_trash_delete_recycle_bin__32
        Me.delt_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.delt_btn.FlatAppearance.BorderSize = 0
        Me.delt_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.delt_btn.Location = New System.Drawing.Point(703, 118)
        Me.delt_btn.Name = "delt_btn"
        Me.delt_btn.Size = New System.Drawing.Size(40, 34)
        Me.delt_btn.TabIndex = 25
        Me.ToolTip1.SetToolTip(Me.delt_btn, "上一筆")
        Me.delt_btn.UseVisualStyleBackColor = False
        Me.delt_btn.Visible = False
        '
        'invSum_lb
        '
        Me.invSum_lb.AutoSize = True
        Me.invSum_lb.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.invSum_lb.ForeColor = System.Drawing.Color.Firebrick
        Me.invSum_lb.Location = New System.Drawing.Point(8, 344)
        Me.invSum_lb.Name = "invSum_lb"
        Me.invSum_lb.Size = New System.Drawing.Size(0, 17)
        Me.invSum_lb.TabIndex = 21
        '
        'dtSum_Lb
        '
        Me.dtSum_Lb.AutoSize = True
        Me.dtSum_Lb.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.dtSum_Lb.ForeColor = System.Drawing.Color.Firebrick
        Me.dtSum_Lb.Location = New System.Drawing.Point(8, 549)
        Me.dtSum_Lb.Name = "dtSum_Lb"
        Me.dtSum_Lb.Size = New System.Drawing.Size(0, 17)
        Me.dtSum_Lb.TabIndex = 22
        '
        'modeChange_btn
        '
        Me.modeChange_btn.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.modeChange_btn.Location = New System.Drawing.Point(359, 679)
        Me.modeChange_btn.Name = "modeChange_btn"
        Me.modeChange_btn.Size = New System.Drawing.Size(70, 29)
        Me.modeChange_btn.TabIndex = 23
        Me.modeChange_btn.Text = "刪除"
        Me.modeChange_btn.UseVisualStyleBackColor = True
        '
        'modiShow_btn
        '
        Me.modiShow_btn.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.modiShow_btn.Location = New System.Drawing.Point(455, 679)
        Me.modiShow_btn.Name = "modiShow_btn"
        Me.modiShow_btn.Size = New System.Drawing.Size(70, 29)
        Me.modiShow_btn.TabIndex = 24
        Me.modiShow_btn.Text = "修改"
        Me.modiShow_btn.UseVisualStyleBackColor = True
        '
        'invInfoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 723)
        Me.Controls.Add(Me.delt_btn)
        Me.Controls.Add(Me.modiShow_btn)
        Me.Controls.Add(Me.modeChange_btn)
        Me.Controls.Add(Me.dtSum_Lb)
        Me.Controls.Add(Me.dtlDwn_btn)
        Me.Controls.Add(Me.invSum_lb)
        Me.Controls.Add(Me.dtlUP_btn)
        Me.Controls.Add(Me.invDwn_btn)
        Me.Controls.Add(Me.invUp_btn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.note_txt)
        Me.Controls.Add(Me.filter_btn)
        Me.Controls.Add(Me.insertShow_btn)
        Me.Controls.Add(Me.detail_dgv)
        Me.Controls.Add(Me.invHeader_dgv)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "invInfoForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "發票資訊"
        CType(Me.invHeader_dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.detail_dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents invHeader_dgv As System.Windows.Forms.DataGridView
    Friend WithEvents detail_dgv As System.Windows.Forms.DataGridView
    Friend WithEvents insertShow_btn As System.Windows.Forms.Button
    Friend WithEvents filter_btn As System.Windows.Forms.Button
    Friend WithEvents note_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents invUp_btn As System.Windows.Forms.Button
    Friend WithEvents invDwn_btn As System.Windows.Forms.Button
    Friend WithEvents dtlUP_btn As System.Windows.Forms.Button
    Friend WithEvents dtlDwn_btn As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents 移至新增欄位ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 註銷發票ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents invSum_lb As System.Windows.Forms.Label
    Friend WithEvents dtSum_Lb As System.Windows.Forms.Label
    Friend WithEvents modeChange_btn As System.Windows.Forms.Button
    Friend WithEvents modiShow_btn As System.Windows.Forms.Button
    Friend WithEvents delt_btn As System.Windows.Forms.Button
End Class
