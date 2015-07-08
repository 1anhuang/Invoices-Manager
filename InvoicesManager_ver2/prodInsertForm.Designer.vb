<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class prodInsertForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(prodInsertForm))
        Me.insert_btn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.title = New System.Windows.Forms.Label()
        Me.price_txt = New System.Windows.Forms.TextBox()
        Me.prod_txt = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'insert_btn
        '
        Me.insert_btn.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.insert_btn.Location = New System.Drawing.Point(110, 170)
        Me.insert_btn.Name = "insert_btn"
        Me.insert_btn.Size = New System.Drawing.Size(75, 29)
        Me.insert_btn.TabIndex = 11
        Me.insert_btn.Text = "新增"
        Me.insert_btn.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 19)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "單價"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 19)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "產品名稱"
        '
        'title
        '
        Me.title.AutoSize = True
        Me.title.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.title.Location = New System.Drawing.Point(102, 17)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(74, 21)
        Me.title.TabIndex = 8
        Me.title.Text = "產品新增"
        '
        'price_txt
        '
        Me.price_txt.Enabled = False
        Me.price_txt.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.price_txt.Location = New System.Drawing.Point(85, 120)
        Me.price_txt.MaxLength = 8
        Me.price_txt.Name = "price_txt"
        Me.price_txt.Size = New System.Drawing.Size(189, 27)
        Me.price_txt.TabIndex = 7
        Me.price_txt.Text = "保留欄位"
        '
        'prod_txt
        '
        Me.prod_txt.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.prod_txt.Location = New System.Drawing.Point(85, 63)
        Me.prod_txt.Name = "prod_txt"
        Me.prod_txt.Size = New System.Drawing.Size(189, 27)
        Me.prod_txt.TabIndex = 6
        '
        'prodInsertForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 216)
        Me.Controls.Add(Me.insert_btn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.title)
        Me.Controls.Add(Me.price_txt)
        Me.Controls.Add(Me.prod_txt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "prodInsertForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "商品新增"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents insert_btn As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents title As System.Windows.Forms.Label
    Friend WithEvents price_txt As System.Windows.Forms.TextBox
    Friend WithEvents prod_txt As System.Windows.Forms.TextBox
End Class
