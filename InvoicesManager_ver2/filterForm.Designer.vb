<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class filterForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(filterForm))
        Me.bs_chk = New System.Windows.Forms.CheckBox()
        Me.bs_crt = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.noteSrch_lb = New System.Windows.Forms.Label()
        Me.note_crt = New System.Windows.Forms.TextBox()
        Me.note_chk = New System.Windows.Forms.CheckBox()
        Me.clearSrch_btn = New System.Windows.Forms.Button()
        Me.uses_crt = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.date_end = New System.Windows.Forms.DateTimePicker()
        Me.date_from = New System.Windows.Forms.DateTimePicker()
        Me.cust_crt = New System.Windows.Forms.TextBox()
        Me.custID_crt = New System.Windows.Forms.TextBox()
        Me.reptID_crt = New System.Windows.Forms.TextBox()
        Me.uses_chk = New System.Windows.Forms.CheckBox()
        Me.date_chk = New System.Windows.Forms.CheckBox()
        Me.reptID_chk = New System.Windows.Forms.CheckBox()
        Me.ok_btn = New System.Windows.Forms.Button()
        Me.cust_chk = New System.Windows.Forms.CheckBox()
        Me.custID_chk = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'bs_chk
        '
        Me.bs_chk.AutoSize = True
        Me.bs_chk.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.bs_chk.Location = New System.Drawing.Point(22, 70)
        Me.bs_chk.Name = "bs_chk"
        Me.bs_chk.Size = New System.Drawing.Size(64, 23)
        Me.bs_chk.TabIndex = 3
        Me.bs_chk.Text = "買/賣"
        Me.bs_chk.UseVisualStyleBackColor = True
        '
        'bs_crt
        '
        Me.bs_crt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.bs_crt.Enabled = False
        Me.bs_crt.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.bs_crt.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.bs_crt.FormattingEnabled = True
        Me.bs_crt.Items.AddRange(New Object() {"B : 買", "S : 賣"})
        Me.bs_crt.Location = New System.Drawing.Point(120, 66)
        Me.bs_crt.Name = "bs_crt"
        Me.bs_crt.Size = New System.Drawing.Size(101, 27)
        Me.bs_crt.TabIndex = 23
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label7.Location = New System.Drawing.Point(207, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 21)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "條件查詢"
        '
        'noteSrch_lb
        '
        Me.noteSrch_lb.AutoSize = True
        Me.noteSrch_lb.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.noteSrch_lb.ForeColor = System.Drawing.Color.DarkRed
        Me.noteSrch_lb.Location = New System.Drawing.Point(117, 422)
        Me.noteSrch_lb.Name = "noteSrch_lb"
        Me.noteSrch_lb.Size = New System.Drawing.Size(140, 16)
        Me.noteSrch_lb.TabIndex = 44
        Me.noteSrch_lb.Text = "多組關鍵字請用空白分開"
        Me.noteSrch_lb.Visible = False
        '
        'note_crt
        '
        Me.note_crt.Enabled = False
        Me.note_crt.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.note_crt.Location = New System.Drawing.Point(120, 340)
        Me.note_crt.Multiline = True
        Me.note_crt.Name = "note_crt"
        Me.note_crt.Size = New System.Drawing.Size(299, 79)
        Me.note_crt.TabIndex = 43
        '
        'note_chk
        '
        Me.note_chk.AutoSize = True
        Me.note_chk.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.note_chk.Location = New System.Drawing.Point(20, 342)
        Me.note_chk.Name = "note_chk"
        Me.note_chk.Size = New System.Drawing.Size(103, 23)
        Me.note_chk.TabIndex = 42
        Me.note_chk.Text = "備註關鍵字"
        Me.note_chk.UseVisualStyleBackColor = True
        '
        'clearSrch_btn
        '
        Me.clearSrch_btn.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.clearSrch_btn.Location = New System.Drawing.Point(282, 464)
        Me.clearSrch_btn.Name = "clearSrch_btn"
        Me.clearSrch_btn.Size = New System.Drawing.Size(75, 29)
        Me.clearSrch_btn.TabIndex = 41
        Me.clearSrch_btn.Text = "清除"
        Me.clearSrch_btn.UseVisualStyleBackColor = True
        '
        'uses_crt
        '
        Me.uses_crt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.uses_crt.Enabled = False
        Me.uses_crt.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.uses_crt.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.uses_crt.FormattingEnabled = True
        Me.uses_crt.Items.AddRange(New Object() {"P : 產品費", "M : 維護費", "S :  服務費", "I : 代開發票"})
        Me.uses_crt.Location = New System.Drawing.Point(120, 289)
        Me.uses_crt.Name = "uses_crt"
        Me.uses_crt.Size = New System.Drawing.Size(161, 27)
        Me.uses_crt.TabIndex = 40
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label6.Location = New System.Drawing.Point(278, 245)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 19)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "至"
        '
        'date_end
        '
        Me.date_end.Enabled = False
        Me.date_end.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.date_end.Location = New System.Drawing.Point(304, 239)
        Me.date_end.Name = "date_end"
        Me.date_end.Size = New System.Drawing.Size(158, 27)
        Me.date_end.TabIndex = 38
        '
        'date_from
        '
        Me.date_from.Enabled = False
        Me.date_from.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.date_from.Location = New System.Drawing.Point(117, 239)
        Me.date_from.Name = "date_from"
        Me.date_from.Size = New System.Drawing.Size(158, 27)
        Me.date_from.TabIndex = 37
        '
        'cust_crt
        '
        Me.cust_crt.Enabled = False
        Me.cust_crt.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cust_crt.Location = New System.Drawing.Point(117, 193)
        Me.cust_crt.MaxLength = 30
        Me.cust_crt.Name = "cust_crt"
        Me.cust_crt.Size = New System.Drawing.Size(299, 27)
        Me.cust_crt.TabIndex = 36
        Me.cust_crt.Tag = ""
        '
        'custID_crt
        '
        Me.custID_crt.Enabled = False
        Me.custID_crt.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.custID_crt.Location = New System.Drawing.Point(117, 149)
        Me.custID_crt.MaxLength = 8
        Me.custID_crt.Name = "custID_crt"
        Me.custID_crt.Size = New System.Drawing.Size(299, 27)
        Me.custID_crt.TabIndex = 35
        Me.custID_crt.Tag = ""
        '
        'reptID_crt
        '
        Me.reptID_crt.Enabled = False
        Me.reptID_crt.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.reptID_crt.Location = New System.Drawing.Point(117, 106)
        Me.reptID_crt.MaxLength = 10
        Me.reptID_crt.Name = "reptID_crt"
        Me.reptID_crt.Size = New System.Drawing.Size(299, 27)
        Me.reptID_crt.TabIndex = 34
        Me.reptID_crt.Tag = ""
        '
        'uses_chk
        '
        Me.uses_chk.AutoSize = True
        Me.uses_chk.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.uses_chk.Location = New System.Drawing.Point(20, 289)
        Me.uses_chk.Name = "uses_chk"
        Me.uses_chk.Size = New System.Drawing.Size(88, 23)
        Me.uses_chk.TabIndex = 33
        Me.uses_chk.Text = "費用類別"
        Me.uses_chk.UseVisualStyleBackColor = True
        '
        'date_chk
        '
        Me.date_chk.AutoSize = True
        Me.date_chk.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.date_chk.Location = New System.Drawing.Point(21, 243)
        Me.date_chk.Name = "date_chk"
        Me.date_chk.Size = New System.Drawing.Size(58, 23)
        Me.date_chk.TabIndex = 32
        Me.date_chk.Text = "日期"
        Me.date_chk.UseVisualStyleBackColor = True
        '
        'reptID_chk
        '
        Me.reptID_chk.AutoSize = True
        Me.reptID_chk.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.reptID_chk.Location = New System.Drawing.Point(20, 106)
        Me.reptID_chk.Name = "reptID_chk"
        Me.reptID_chk.Size = New System.Drawing.Size(88, 23)
        Me.reptID_chk.TabIndex = 31
        Me.reptID_chk.Text = "發票編號"
        Me.reptID_chk.UseVisualStyleBackColor = True
        '
        'ok_btn
        '
        Me.ok_btn.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ok_btn.Location = New System.Drawing.Point(146, 464)
        Me.ok_btn.Name = "ok_btn"
        Me.ok_btn.Size = New System.Drawing.Size(75, 29)
        Me.ok_btn.TabIndex = 30
        Me.ok_btn.Text = "確定"
        Me.ok_btn.UseVisualStyleBackColor = True
        '
        'cust_chk
        '
        Me.cust_chk.AutoSize = True
        Me.cust_chk.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cust_chk.Location = New System.Drawing.Point(21, 195)
        Me.cust_chk.Name = "cust_chk"
        Me.cust_chk.Size = New System.Drawing.Size(73, 23)
        Me.cust_chk.TabIndex = 29
        Me.cust_chk.Text = "買受人"
        Me.cust_chk.UseVisualStyleBackColor = True
        '
        'custID_chk
        '
        Me.custID_chk.AutoSize = True
        Me.custID_chk.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.custID_chk.Location = New System.Drawing.Point(20, 149)
        Me.custID_chk.Name = "custID_chk"
        Me.custID_chk.Size = New System.Drawing.Size(88, 23)
        Me.custID_chk.TabIndex = 28
        Me.custID_chk.Text = "統一編號"
        Me.custID_chk.UseVisualStyleBackColor = True
        '
        'filterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 515)
        Me.Controls.Add(Me.noteSrch_lb)
        Me.Controls.Add(Me.note_crt)
        Me.Controls.Add(Me.note_chk)
        Me.Controls.Add(Me.clearSrch_btn)
        Me.Controls.Add(Me.uses_crt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.date_end)
        Me.Controls.Add(Me.date_from)
        Me.Controls.Add(Me.cust_crt)
        Me.Controls.Add(Me.custID_crt)
        Me.Controls.Add(Me.reptID_crt)
        Me.Controls.Add(Me.uses_chk)
        Me.Controls.Add(Me.date_chk)
        Me.Controls.Add(Me.reptID_chk)
        Me.Controls.Add(Me.ok_btn)
        Me.Controls.Add(Me.cust_chk)
        Me.Controls.Add(Me.custID_chk)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.bs_crt)
        Me.Controls.Add(Me.bs_chk)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "filterForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "條件篩選"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bs_chk As System.Windows.Forms.CheckBox
    Friend WithEvents bs_crt As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents noteSrch_lb As System.Windows.Forms.Label
    Friend WithEvents note_crt As System.Windows.Forms.TextBox
    Friend WithEvents note_chk As System.Windows.Forms.CheckBox
    Friend WithEvents clearSrch_btn As System.Windows.Forms.Button
    Friend WithEvents uses_crt As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents date_end As System.Windows.Forms.DateTimePicker
    Friend WithEvents date_from As System.Windows.Forms.DateTimePicker
    Friend WithEvents cust_crt As System.Windows.Forms.TextBox
    Friend WithEvents custID_crt As System.Windows.Forms.TextBox
    Friend WithEvents reptID_crt As System.Windows.Forms.TextBox
    Friend WithEvents uses_chk As System.Windows.Forms.CheckBox
    Friend WithEvents date_chk As System.Windows.Forms.CheckBox
    Friend WithEvents reptID_chk As System.Windows.Forms.CheckBox
    Friend WithEvents ok_btn As System.Windows.Forms.Button
    Friend WithEvents cust_chk As System.Windows.Forms.CheckBox
    Friend WithEvents custID_chk As System.Windows.Forms.CheckBox
End Class
