Public Class invInsertForm
    Public dtl_T As DataTable = New DataTable("detail")
    Dim ControlDB As ControlDB = New ControlDB


    Function CheckMsg(ByVal title As String, ByVal msg As String) As Boolean
        '彈出確認視窗()
        Dim respnCode = MsgBox(msg, 4 + 32, title)
        ' 是(6)  否(7)
        If (respnCode <> 6) Then
            Return False
        End If

        Return True
    End Function


    Sub ClearInsertTxt()
        sellflg.Checked = True
        If (reptID_txt.Enabled = True) Then
            reptID_txt.Text = ""
        End If
        custID_txt.Text = ""
        cust_txt.Text = ""
        t_date.Value = Now().Date
        typelist.SelectedItem = Nothing
        dtl_T.Clear()
        note_txt.Text = ""
    End Sub

    Function DeleteInvoice(ByRef reptID As String) As Boolean
        Dim stm_format As String = "Delete From @table Where receiptID = @value"
        Dim stm As String = ""

        stm = Replace(stm_format, "@table", "receipt")
        stm = Replace(stm, "@value", "'" & reptID & "'")
        If (Controldb.NonExe(stm) = False) Then
            MsgBox("receipt table: 刪除失敗", 0 + 16)
            Return False
        End If

        stm = Replace(stm_format, "@table", "detail")
        stm = Replace(stm, "@value", "'" & reptID & "'")
        If (Controldb.NonExe(stm) = False) Then
            MsgBox("detail table: 刪除失敗", 0 + 16)
            Return False
        End If

        Return True
    End Function

    Private Function DtlList2Str(ByVal prod_l As List(Of String), ByVal nProd_l As IList(Of Integer), ByVal price_l As IList(Of Integer)) As String
        Dim str As String = ""
        For i = 0 To prod_l.Count - 1
            str = str & prod_l(i) & vbTab & nProd_l(i) & vbTab & price_l(i) & vbCrLf
        Next

        DtlList2Str = str
    End Function

    Private Sub insertForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        SettingVars.invInsertMode = ""
        invInfoForm.Enabled = True
    End Sub

    Private Sub invInsertForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dtl_T.Columns.Add("品名")
        dtl_T.Columns.Add("數目")
        dtl_T.Columns.Add("金額")
    End Sub


    Private Sub invInsertForm_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        'dtl_T.Columns.Add("品名")
        'dtl_T.Columns.Add("數目")
        'dtl_T.Columns.Add("金額")

        If (SettingVars.invInsertMode = "insert") Then
            Me.Text = "發票新增"
            title.Text = "發票新增"
            insert_btn.Text = "新增"
        ElseIf (SettingVars.invInsertMode = "modify") Then
            Me.Text = "發票修改"
            title.Text = "發票修改"
            insert_btn.Text = "修改"
            reptID_txt.Enabled = False
        End If
    End Sub

    Private Sub dtlShow_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtlShow_btn.Click
        Me.Enabled = False
        dtlForm.Show()
    End Sub

    Private Sub clear_insert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear_insert.Click
        If (CheckMsg("清除確認", "確定要清除目前所有欄位嗎?")) Then
            ClearInsertTxt()
        End If

    End Sub

    Private Sub custID_txt_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles custID_txt.DoubleClick
        Me.Enabled = False
        SettingVars.infoCaller = "invInsertForm"
        SettingVars.infoMode = "買受人資訊"
        infoForm.Show()
    End Sub

    Private Sub cust_txt_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles cust_txt.DoubleClick
        Me.Enabled = False
        SettingVars.infoCaller = "invInsertForm"
        SettingVars.infoMode = "買受人資訊"
        infoForm.Show()
    End Sub

    Private Sub insert_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles insert_btn.Click
        '檢查各個欄位是否都有資料
        If (reptID_txt.Text = "" Or custID_txt.Text = "" Or cust_txt.Text = "" Or typelist.Text = "") Then
            MsgBox("請確認資料欄位是否都填齊", 0 + 48)
            Exit Sub
        ElseIf (buyflg.Checked = False And sellflg.Checked = False) Then
            MsgBox("尚未勾選發票買/賣", 0 + 48)
            Exit Sub
        ElseIf (dtl_T.Rows.Count = 0) Then
            MsgBox("尚未新增交易明細", 0 + 48)
            Exit Sub
        ElseIf (reptID_txt.Text.Length <> 10) Then
            MsgBox("發票編號必須為10碼", 0 + 48)
            reptID_txt.Focus()
            Exit Sub
        ElseIf (custID_txt.Text.Length <> 8) Then
            MsgBox("統一編號必須為8碼", 0 + 48)
            custID_txt.Focus()
            Exit Sub
        ElseIf (Not ControlDB.Lookup("receiptID", "receipt", ("receiptID = " & """" & reptID_txt.Text & """")) Is DBNull.Value And SettingVars.invInsertMode <> "modify") Then
            MsgBox("發票編號已存在 請再確認一次", 0 + 48)
            Exit Sub
        End If

        '-------------------------------------------------------------------------------------------------------------
        insert_btn.Enabled = False
        Dim msg As String = IIf(SettingVars.invInsertMode = "modify", "修改", "新增")
        Dim reptID_str = reptID_txt.Text                 '發票編號
        Dim type As Char = IIf(buyflg.Checked, "B", "S") '發票類別(買/賣)
        Dim uses As Char = typelist.Text                 '發票費用用途
        Dim cust_str = cust_txt.Text                     '買受人(客戶名)
        Dim custID_str = custID_txt.Text                 '買受人編號(統一編號)
        Dim date_str = CStr(t_date.Value.Date)           '日期
        Dim prod_l As IList(Of String)                   '品名
        Dim nOfProd_l As List(Of Integer)                '數目(int)
        Dim price_l As List(Of Integer)                  '單價(int)
        Dim note_str = note_txt.Text                     '備註
        Dim n_total As Integer                           '未稅總價
        Dim taxes As Integer                             '稅金
        Dim total As Integer                             '總金額


        prod_l = New List(Of String)
        nOfProd_l = New List(Of Integer)
        price_l = New List(Of Integer)

        For i = 0 To dtl_T.Rows.Count - 1
            '檢查輸入是否為有效數字
            If (IsNumeric(dtl_T.Rows(i)(1)) And IsNumeric(dtl_T.Rows(i)(2))) Then
                '新增資料至list
                prod_l.Add(dtl_T.Rows(i)(0))
                nOfProd_l.Add(CInt(dtl_T.Rows(i)(1)))
                price_l.Add(dtl_T.Rows(i)(2))
                n_total = n_total + (CInt(dtl_T.Rows(i)(1)) * CInt(dtl_T.Rows(i)(2)))
            Else
                MsgBox("數目或金額輸入為無效數字 請再確認一次", 0 + 48)
                insert_btn.Enabled = True
                Exit Sub
            End If
        Next

        taxes = Format((n_total * 0.05), "0")
        total = Format((n_total * 1.05), "0")

        '確認表單無誤
        Dim detail_str = DtlList2Str(prod_l, nOfProd_l, price_l)
        Dim chkMsg As String = "統一編號: " & reptID_str & vbCrLf & "買/賣: " & vbTab & type & vbCrLf & "發票類型:" & vbTab & uses & vbCrLf & "買受人: " & vbTab & cust_str & vbCrLf & "統一編號: " & vbTab & custID_str & vbCrLf & _
                            "日期: " & vbTab & date_str & vbCrLf & vbCrLf & detail_str & vbCrLf & _
                            "未稅合計: " & vbTab & n_total & vbCrLf & "營業稅: " & vbTab & taxes & vbCrLf & "總計: " & vbTab & total

        '彈出確認視窗()
        Dim respnCode = MsgBox(chkMsg, 4 + 32, "表單確認")
        ' 是(6)  否(7)
        If (respnCode <> 6) Then
            insert_btn.Enabled = True
            Exit Sub
        End If

        If (SettingVars.invInsertMode = "modify") Then
            If (DeleteInvoice(reptID_txt.Text) = False) Then
                MsgBox("修改失敗，請再確認一次", 0 + 48)
            Else
                MsgBox("刪除成功，準備新增", 0 + 48)
            End If
        End If

        '將資料分別儲存至對應table
        Dim format_stm As String = "Insert into @table ( @field ) value ( @value )"
        Dim stm As String

        'insert into receipt
        stm = Replace(format_stm, "@field", "receiptID, type, uses, customID, date, n_total, taxes, total, note")
        stm = Replace(stm, "@table", "receipt")
        stm = Replace(stm, "@value", ("""" & reptID_str & """, """ & type & """, """ & uses & """, """ & custID_str & """, """ & date_str & """, " _
                                       & n_total & ", " & taxes & ", " & total & ", """ & note_str & """"))
        'MsgBox(stm)
        If (ControlDB.NonExe(stm) = False) Then
            MsgBox("receipt table: " & msg & "資料失敗!", 0 + 16)
        End If

        'insert into custom

        '不存在custom table的客戶才新增
        If (ControlDB.Lookup("customID", "custom", ("customID = " & """" & custID_str & """")) Is DBNull.Value) Then
            stm = Replace(format_stm, "@field", "customID, custom")
            stm = Replace(stm, "@table", "custom")
            stm = Replace(stm, "@value", """" & custID_str & """, """ & cust_str & """")
            If (ControlDB.NonExe(stm) = False) Then
                MsgBox("custom table: " & msg & "資料失敗!", 0 + 16)
            End If
            'MsgBox(stm)
        End If


        'insert into product & detail

        Dim prodID As Object '記錄prodID

        For i = 0 To prod_l.Count - 1
            prodID = ControlDB.Lookup("productID", "product", ("product = " & """" & prod_l(i) & """"))

            '不存在product table的產品才新增
            If (prodID Is DBNull.Value) Then
                Dim nOfRow As Integer = ControlDB.Lookup("count(*)", "product", "")
                prodID = nOfRow + 1
                'insert into product
                stm = Replace(format_stm, "@field", "productID, product")
                stm = Replace(stm, "@table", "product")
                stm = Replace(stm, "@value", prodID & ", """ & prod_l(i) & """")
                If (ControlDB.NonExe(stm) = False) Then
                    MsgBox("product table: " & msg & "資料失敗!", 0 + 16)
                End If
                'msgBox(stm)
            End If

            'insert into detail
            stm = Replace(format_stm, "@field", "receiptID, productID, numOfproduct, price")
            stm = Replace(stm, "@table", "detail")
            stm = Replace(stm, "@value", """" & reptID_str & """, " & prodID & ", " & nOfProd_l(i) & ", " & price_l(i))
            If (ControlDB.NonExe(stm) = False) Then
                MsgBox("detail table: " & msg & "資料失敗!", 0 + 16)
            End If
            'MsgBox(stm)
        Next

        ClearInsertTxt()
        MsgBox(msg & "完成", 0 + 64)
        insert_btn.Enabled = True

        If (SettingVars.invInsertMode = "modify") Then
            Me.Close()
        End If
    End Sub
End Class