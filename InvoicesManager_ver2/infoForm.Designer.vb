<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class infoForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(infoForm))
        Me.info_dgv = New System.Windows.Forms.DataGridView()
        Me.title = New System.Windows.Forms.Label()
        Me.insertInfo_btn = New System.Windows.Forms.Button()
        Me.Select_btn = New System.Windows.Forms.Button()
        Me.updInfo_btn = New System.Windows.Forms.Button()
        Me.invDwn_btn = New System.Windows.Forms.Button()
        Me.invUp_btn = New System.Windows.Forms.Button()
        Me.numOfRow_lb = New System.Windows.Forms.Label()
        CType(Me.info_dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'info_dgv
        '
        Me.info_dgv.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.info_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.info_dgv.Location = New System.Drawing.Point(12, 41)
        Me.info_dgv.MultiSelect = False
        Me.info_dgv.Name = "info_dgv"
        Me.info_dgv.ReadOnly = True
        Me.info_dgv.RowTemplate.Height = 24
        Me.info_dgv.Size = New System.Drawing.Size(420, 257)
        Me.info_dgv.TabIndex = 0
        '
        'title
        '
        Me.title.AutoSize = True
        Me.title.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.title.Location = New System.Drawing.Point(12, 17)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(90, 21)
        Me.title.TabIndex = 17
        Me.title.Text = "買受人資訊"
        '
        'insertInfo_btn
        '
        Me.insertInfo_btn.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.insertInfo_btn.Location = New System.Drawing.Point(131, 339)
        Me.insertInfo_btn.Name = "insertInfo_btn"
        Me.insertInfo_btn.Size = New System.Drawing.Size(65, 29)
        Me.insertInfo_btn.TabIndex = 21
        Me.insertInfo_btn.Text = "新增"
        Me.insertInfo_btn.UseVisualStyleBackColor = True
        '
        'Select_btn
        '
        Me.Select_btn.Enabled = False
        Me.Select_btn.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Select_btn.Location = New System.Drawing.Point(205, 339)
        Me.Select_btn.Name = "Select_btn"
        Me.Select_btn.Size = New System.Drawing.Size(65, 29)
        Me.Select_btn.TabIndex = 22
        Me.Select_btn.Text = "確認"
        Me.Select_btn.UseVisualStyleBackColor = True
        Me.Select_btn.Visible = False
        '
        'updInfo_btn
        '
        Me.updInfo_btn.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.updInfo_btn.Location = New System.Drawing.Point(279, 339)
        Me.updInfo_btn.Name = "updInfo_btn"
        Me.updInfo_btn.Size = New System.Drawing.Size(65, 29)
        Me.updInfo_btn.TabIndex = 23
        Me.updInfo_btn.Text = "修改"
        Me.updInfo_btn.UseVisualStyleBackColor = True
        '
        'invDwn_btn
        '
        Me.invDwn_btn.BackColor = System.Drawing.Color.Transparent
        Me.invDwn_btn.BackgroundImage = Global.InvoicesManager_ver2.My.Resources.Resources._1411426484_down_32
        Me.invDwn_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.invDwn_btn.FlatAppearance.BorderSize = 0
        Me.invDwn_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.invDwn_btn.Location = New System.Drawing.Point(443, 167)
        Me.invDwn_btn.Name = "invDwn_btn"
        Me.invDwn_btn.Size = New System.Drawing.Size(51, 49)
        Me.invDwn_btn.TabIndex = 20
        Me.invDwn_btn.UseVisualStyleBackColor = False
        '
        'invUp_btn
        '
        Me.invUp_btn.BackColor = System.Drawing.Color.Transparent
        Me.invUp_btn.BackgroundImage = Global.InvoicesManager_ver2.My.Resources.Resources._1411426445_up_32
        Me.invUp_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.invUp_btn.FlatAppearance.BorderSize = 0
        Me.invUp_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.invUp_btn.Location = New System.Drawing.Point(444, 120)
        Me.invUp_btn.Name = "invUp_btn"
        Me.invUp_btn.Size = New System.Drawing.Size(50, 41)
        Me.invUp_btn.TabIndex = 19
        Me.invUp_btn.UseVisualStyleBackColor = False
        '
        'numOfRow_lb
        '
        Me.numOfRow_lb.AutoSize = True
        Me.numOfRow_lb.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.numOfRow_lb.Location = New System.Drawing.Point(179, 306)
        Me.numOfRow_lb.Name = "numOfRow_lb"
        Me.numOfRow_lb.Size = New System.Drawing.Size(0, 21)
        Me.numOfRow_lb.TabIndex = 24
        '
        'infoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 388)
        Me.Controls.Add(Me.numOfRow_lb)
        Me.Controls.Add(Me.updInfo_btn)
        Me.Controls.Add(Me.Select_btn)
        Me.Controls.Add(Me.insertInfo_btn)
        Me.Controls.Add(Me.invDwn_btn)
        Me.Controls.Add(Me.invUp_btn)
        Me.Controls.Add(Me.title)
        Me.Controls.Add(Me.info_dgv)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "infoForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "custInfo"
        CType(Me.info_dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents info_dgv As System.Windows.Forms.DataGridView
    Friend WithEvents title As System.Windows.Forms.Label
    Friend WithEvents invDwn_btn As System.Windows.Forms.Button
    Friend WithEvents invUp_btn As System.Windows.Forms.Button
    Friend WithEvents insertInfo_btn As System.Windows.Forms.Button
    Friend WithEvents Select_btn As System.Windows.Forms.Button
    Friend WithEvents updInfo_btn As System.Windows.Forms.Button
    Friend WithEvents numOfRow_lb As System.Windows.Forms.Label
End Class
