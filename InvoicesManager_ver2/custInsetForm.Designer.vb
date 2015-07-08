<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class custInsetForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(custInsetForm))
        Me.cust_txt = New System.Windows.Forms.TextBox()
        Me.custID_txt = New System.Windows.Forms.TextBox()
        Me.title = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.insert_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cust_txt
        '
        Me.cust_txt.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cust_txt.Location = New System.Drawing.Point(80, 125)
        Me.cust_txt.Name = "cust_txt"
        Me.cust_txt.Size = New System.Drawing.Size(189, 27)
        Me.cust_txt.TabIndex = 0
        '
        'custID_txt
        '
        Me.custID_txt.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.custID_txt.Location = New System.Drawing.Point(80, 68)
        Me.custID_txt.MaxLength = 8
        Me.custID_txt.Name = "custID_txt"
        Me.custID_txt.Size = New System.Drawing.Size(189, 27)
        Me.custID_txt.TabIndex = 1
        '
        'title
        '
        Me.title.AutoSize = True
        Me.title.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.title.Location = New System.Drawing.Point(97, 22)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(90, 21)
        Me.title.TabIndex = 2
        Me.title.Text = "買受人新增"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "買受人"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "統一編號"
        '
        'insert_btn
        '
        Me.insert_btn.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.insert_btn.Location = New System.Drawing.Point(105, 175)
        Me.insert_btn.Name = "insert_btn"
        Me.insert_btn.Size = New System.Drawing.Size(75, 29)
        Me.insert_btn.TabIndex = 5
        Me.insert_btn.Text = "新增"
        Me.insert_btn.UseVisualStyleBackColor = True
        '
        'custInsetForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 216)
        Me.Controls.Add(Me.insert_btn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.title)
        Me.Controls.Add(Me.custID_txt)
        Me.Controls.Add(Me.cust_txt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "custInsetForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "客戶新增"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cust_txt As System.Windows.Forms.TextBox
    Friend WithEvents custID_txt As System.Windows.Forms.TextBox
    Friend WithEvents title As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents insert_btn As System.Windows.Forms.Button
End Class
