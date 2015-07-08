<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class invInsertForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(invInsertForm))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.sellflg = New System.Windows.Forms.RadioButton()
        Me.buyflg = New System.Windows.Forms.RadioButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.typelist = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.clear_insert = New System.Windows.Forms.Button()
        Me.insert_btn = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.note_txt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.t_date = New System.Windows.Forms.DateTimePicker()
        Me.custID_txt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cust_txt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.reptID_txt = New System.Windows.Forms.TextBox()
        Me.title = New System.Windows.Forms.Label()
        Me.dtlShow_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 310)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 19)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "交易明細"
        '
        'sellflg
        '
        Me.sellflg.AutoSize = True
        Me.sellflg.Checked = True
        Me.sellflg.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.sellflg.Location = New System.Drawing.Point(225, 61)
        Me.sellflg.Name = "sellflg"
        Me.sellflg.Size = New System.Drawing.Size(57, 23)
        Me.sellflg.TabIndex = 25
        Me.sellflg.TabStop = True
        Me.sellflg.Text = "賣出"
        Me.sellflg.UseVisualStyleBackColor = True
        '
        'buyflg
        '
        Me.buyflg.AutoSize = True
        Me.buyflg.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.buyflg.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.buyflg.Location = New System.Drawing.Point(111, 63)
        Me.buyflg.Name = "buyflg"
        Me.buyflg.Size = New System.Drawing.Size(63, 24)
        Me.buyflg.TabIndex = 24
        Me.buyflg.Text = "買入"
        Me.buyflg.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 63)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 19)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "買 / 賣"
        '
        'typelist
        '
        Me.typelist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.typelist.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.typelist.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.typelist.FormattingEnabled = True
        Me.typelist.Items.AddRange(New Object() {"P : 產品費", "M : 維護費", "S :  服務費", "I : 代開發票"})
        Me.typelist.Location = New System.Drawing.Point(98, 257)
        Me.typelist.Name = "typelist"
        Me.typelist.Size = New System.Drawing.Size(161, 27)
        Me.typelist.TabIndex = 33
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 260)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 19)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "費用類別"
        '
        'clear_insert
        '
        Me.clear_insert.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.clear_insert.Location = New System.Drawing.Point(257, 485)
        Me.clear_insert.Name = "clear_insert"
        Me.clear_insert.Size = New System.Drawing.Size(75, 29)
        Me.clear_insert.TabIndex = 37
        Me.clear_insert.Text = "清除"
        Me.clear_insert.UseVisualStyleBackColor = True
        '
        'insert_btn
        '
        Me.insert_btn.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.insert_btn.Location = New System.Drawing.Point(98, 485)
        Me.insert_btn.Name = "insert_btn"
        Me.insert_btn.Size = New System.Drawing.Size(75, 29)
        Me.insert_btn.TabIndex = 36
        Me.insert_btn.Text = "新增"
        Me.insert_btn.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 395)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 19)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "備註"
        '
        'note_txt
        '
        Me.note_txt.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.note_txt.Location = New System.Drawing.Point(98, 365)
        Me.note_txt.MaxLength = 100
        Me.note_txt.Multiline = True
        Me.note_txt.Name = "note_txt"
        Me.note_txt.Size = New System.Drawing.Size(299, 91)
        Me.note_txt.TabIndex = 35
        Me.note_txt.Tag = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 215)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 19)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "日期"
        '
        't_date
        '
        Me.t_date.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.t_date.Location = New System.Drawing.Point(98, 209)
        Me.t_date.Name = "t_date"
        Me.t_date.Size = New System.Drawing.Size(161, 27)
        Me.t_date.TabIndex = 32
        '
        'custID_txt
        '
        Me.custID_txt.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.custID_txt.Location = New System.Drawing.Point(98, 168)
        Me.custID_txt.MaxLength = 8
        Me.custID_txt.Name = "custID_txt"
        Me.custID_txt.Size = New System.Drawing.Size(299, 27)
        Me.custID_txt.TabIndex = 31
        Me.custID_txt.Tag = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 19)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "統一編號"
        '
        'cust_txt
        '
        Me.cust_txt.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cust_txt.Location = New System.Drawing.Point(98, 130)
        Me.cust_txt.MaxLength = 30
        Me.cust_txt.Name = "cust_txt"
        Me.cust_txt.Size = New System.Drawing.Size(299, 27)
        Me.cust_txt.TabIndex = 29
        Me.cust_txt.Tag = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 19)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "買受人"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 19)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "發票號碼"
        '
        'reptID_txt
        '
        Me.reptID_txt.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.reptID_txt.Location = New System.Drawing.Point(98, 93)
        Me.reptID_txt.MaxLength = 10
        Me.reptID_txt.Name = "reptID_txt"
        Me.reptID_txt.Size = New System.Drawing.Size(299, 27)
        Me.reptID_txt.TabIndex = 26
        Me.reptID_txt.Tag = ""
        '
        'title
        '
        Me.title.AutoSize = True
        Me.title.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.title.Location = New System.Drawing.Point(160, 20)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(74, 21)
        Me.title.TabIndex = 46
        Me.title.Text = "發票新增"
        '
        'dtlShow_btn
        '
        Me.dtlShow_btn.BackgroundImage = Global.InvoicesManager_ver2.My.Resources.Resources.Programming_Add_Property_icon
        Me.dtlShow_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.dtlShow_btn.FlatAppearance.BorderSize = 0
        Me.dtlShow_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dtlShow_btn.ForeColor = System.Drawing.Color.Transparent
        Me.dtlShow_btn.Location = New System.Drawing.Point(149, 297)
        Me.dtlShow_btn.Name = "dtlShow_btn"
        Me.dtlShow_btn.Size = New System.Drawing.Size(56, 52)
        Me.dtlShow_btn.TabIndex = 34
        Me.dtlShow_btn.UseVisualStyleBackColor = True
        '
        'invInsertForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 538)
        Me.Controls.Add(Me.title)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtlShow_btn)
        Me.Controls.Add(Me.sellflg)
        Me.Controls.Add(Me.buyflg)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.typelist)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.clear_insert)
        Me.Controls.Add(Me.insert_btn)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.note_txt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.t_date)
        Me.Controls.Add(Me.custID_txt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cust_txt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.reptID_txt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "invInsertForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "發票新增"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtlShow_btn As System.Windows.Forms.Button
    Friend WithEvents sellflg As System.Windows.Forms.RadioButton
    Friend WithEvents buyflg As System.Windows.Forms.RadioButton
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents typelist As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents clear_insert As System.Windows.Forms.Button
    Friend WithEvents insert_btn As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents note_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents t_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents custID_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cust_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents reptID_txt As System.Windows.Forms.TextBox
    Friend WithEvents title As System.Windows.Forms.Label
End Class
