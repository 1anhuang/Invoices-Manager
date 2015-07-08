<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menuForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(menuForm))
        Me.invoiceMtn = New System.Windows.Forms.Button()
        Me.customMtn = New System.Windows.Forms.Button()
        Me.productMtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'invoiceMtn
        '
        Me.invoiceMtn.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.invoiceMtn.Location = New System.Drawing.Point(45, 36)
        Me.invoiceMtn.Name = "invoiceMtn"
        Me.invoiceMtn.Size = New System.Drawing.Size(127, 36)
        Me.invoiceMtn.TabIndex = 0
        Me.invoiceMtn.Text = "發票資料維護"
        Me.invoiceMtn.UseVisualStyleBackColor = True
        '
        'customMtn
        '
        Me.customMtn.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.customMtn.Location = New System.Drawing.Point(45, 99)
        Me.customMtn.Name = "customMtn"
        Me.customMtn.Size = New System.Drawing.Size(127, 36)
        Me.customMtn.TabIndex = 1
        Me.customMtn.Text = "客戶資料維護"
        Me.customMtn.UseVisualStyleBackColor = True
        '
        'productMtn
        '
        Me.productMtn.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.productMtn.Location = New System.Drawing.Point(45, 162)
        Me.productMtn.Name = "productMtn"
        Me.productMtn.Size = New System.Drawing.Size(127, 36)
        Me.productMtn.TabIndex = 2
        Me.productMtn.Text = "商品資料維護"
        Me.productMtn.UseVisualStyleBackColor = True
        '
        'menuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(214, 232)
        Me.Controls.Add(Me.productMtn)
        Me.Controls.Add(Me.customMtn)
        Me.Controls.Add(Me.invoiceMtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "menuForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "主選單"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents invoiceMtn As System.Windows.Forms.Button
    Friend WithEvents customMtn As System.Windows.Forms.Button
    Friend WithEvents productMtn As System.Windows.Forms.Button

End Class
