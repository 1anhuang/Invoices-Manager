<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dtlForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dtlForm))
        Me.clear_btn = New System.Windows.Forms.Button()
        Me.ok_btn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.price_txt = New System.Windows.Forms.TextBox()
        Me.nOfProd_txt = New System.Windows.Forms.TextBox()
        Me.prod_txt = New System.Windows.Forms.TextBox()
        Me.dtl_dgv = New System.Windows.Forms.DataGridView()
        Me.add_btn = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.dtlDwn_btn = New System.Windows.Forms.Button()
        Me.dtlUp_btn = New System.Windows.Forms.Button()
        Me.delete_btn = New System.Windows.Forms.Button()
        CType(Me.dtl_dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'clear_btn
        '
        Me.clear_btn.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.clear_btn.Location = New System.Drawing.Point(306, 329)
        Me.clear_btn.Name = "clear_btn"
        Me.clear_btn.Size = New System.Drawing.Size(75, 29)
        Me.clear_btn.TabIndex = 23
        Me.clear_btn.Text = "清除"
        Me.clear_btn.UseVisualStyleBackColor = True
        '
        'ok_btn
        '
        Me.ok_btn.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ok_btn.Location = New System.Drawing.Point(156, 329)
        Me.ok_btn.Name = "ok_btn"
        Me.ok_btn.Size = New System.Drawing.Size(75, 29)
        Me.ok_btn.TabIndex = 21
        Me.ok_btn.Text = "確定"
        Me.ok_btn.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.Location = New System.Drawing.Point(184, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 21)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "目前明細清單"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.Location = New System.Drawing.Point(342, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 19)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "金額"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(219, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 19)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "數目"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(79, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 19)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "品名"
        '
        'price_txt
        '
        Me.price_txt.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.price_txt.Location = New System.Drawing.Point(288, 49)
        Me.price_txt.Name = "price_txt"
        Me.price_txt.Size = New System.Drawing.Size(155, 27)
        Me.price_txt.TabIndex = 15
        '
        'nOfProd_txt
        '
        Me.nOfProd_txt.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.nOfProd_txt.Location = New System.Drawing.Point(211, 49)
        Me.nOfProd_txt.Name = "nOfProd_txt"
        Me.nOfProd_txt.Size = New System.Drawing.Size(53, 27)
        Me.nOfProd_txt.TabIndex = 14
        '
        'prod_txt
        '
        Me.prod_txt.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.prod_txt.Location = New System.Drawing.Point(25, 49)
        Me.prod_txt.Name = "prod_txt"
        Me.prod_txt.Size = New System.Drawing.Size(155, 27)
        Me.prod_txt.TabIndex = 13
        '
        'dtl_dgv
        '
        Me.dtl_dgv.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dtl_dgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dtl_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtl_dgv.Location = New System.Drawing.Point(15, 134)
        Me.dtl_dgv.MultiSelect = False
        Me.dtl_dgv.Name = "dtl_dgv"
        Me.dtl_dgv.ReadOnly = True
        Me.dtl_dgv.RowTemplate.Height = 24
        Me.dtl_dgv.Size = New System.Drawing.Size(440, 181)
        Me.dtl_dgv.TabIndex = 12
        '
        'add_btn
        '
        Me.add_btn.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.add_btn.Location = New System.Drawing.Point(461, 49)
        Me.add_btn.Name = "add_btn"
        Me.add_btn.Size = New System.Drawing.Size(57, 27)
        Me.add_btn.TabIndex = 19
        Me.add_btn.Text = "加入"
        Me.add_btn.UseVisualStyleBackColor = True
        '
        'dtlDwn_btn
        '
        Me.dtlDwn_btn.BackColor = System.Drawing.Color.Transparent
        Me.dtlDwn_btn.BackgroundImage = Global.InvoicesManager_ver2.My.Resources.Resources._1411426484_down_32
        Me.dtlDwn_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.dtlDwn_btn.FlatAppearance.BorderSize = 0
        Me.dtlDwn_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dtlDwn_btn.Location = New System.Drawing.Point(471, 256)
        Me.dtlDwn_btn.Name = "dtlDwn_btn"
        Me.dtlDwn_btn.Size = New System.Drawing.Size(47, 34)
        Me.dtlDwn_btn.TabIndex = 25
        Me.ToolTip1.SetToolTip(Me.dtlDwn_btn, "向下一筆")
        Me.dtlDwn_btn.UseVisualStyleBackColor = False
        '
        'dtlUp_btn
        '
        Me.dtlUp_btn.BackColor = System.Drawing.Color.Transparent
        Me.dtlUp_btn.BackgroundImage = Global.InvoicesManager_ver2.My.Resources.Resources._1411426445_up_32
        Me.dtlUp_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.dtlUp_btn.FlatAppearance.BorderSize = 0
        Me.dtlUp_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dtlUp_btn.Location = New System.Drawing.Point(471, 144)
        Me.dtlUp_btn.Name = "dtlUp_btn"
        Me.dtlUp_btn.Size = New System.Drawing.Size(47, 34)
        Me.dtlUp_btn.TabIndex = 24
        Me.ToolTip1.SetToolTip(Me.dtlUp_btn, "向上一筆")
        Me.dtlUp_btn.UseVisualStyleBackColor = False
        '
        'delete_btn
        '
        Me.delete_btn.BackColor = System.Drawing.Color.Transparent
        Me.delete_btn.BackgroundImage = Global.InvoicesManager_ver2.My.Resources.Resources._1411229961_editor_trash_delete_recycle_bin__32
        Me.delete_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.delete_btn.FlatAppearance.BorderSize = 0
        Me.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.delete_btn.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.delete_btn.Location = New System.Drawing.Point(471, 196)
        Me.delete_btn.Name = "delete_btn"
        Me.delete_btn.Size = New System.Drawing.Size(47, 44)
        Me.delete_btn.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.delete_btn, "刪除明細")
        Me.delete_btn.UseVisualStyleBackColor = False
        '
        'dtlForm
        '
        Me.AcceptButton = Me.add_btn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 375)
        Me.Controls.Add(Me.dtlDwn_btn)
        Me.Controls.Add(Me.dtlUp_btn)
        Me.Controls.Add(Me.clear_btn)
        Me.Controls.Add(Me.delete_btn)
        Me.Controls.Add(Me.ok_btn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.add_btn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.price_txt)
        Me.Controls.Add(Me.nOfProd_txt)
        Me.Controls.Add(Me.prod_txt)
        Me.Controls.Add(Me.dtl_dgv)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "dtlForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "明細"
        CType(Me.dtl_dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents clear_btn As System.Windows.Forms.Button
    Friend WithEvents delete_btn As System.Windows.Forms.Button
    Friend WithEvents ok_btn As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents add_btn As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents price_txt As System.Windows.Forms.TextBox
    Friend WithEvents nOfProd_txt As System.Windows.Forms.TextBox
    Friend WithEvents prod_txt As System.Windows.Forms.TextBox
    Friend WithEvents dtl_dgv As System.Windows.Forms.DataGridView
    Friend WithEvents dtlDwn_btn As System.Windows.Forms.Button
    Friend WithEvents dtlUp_btn As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
