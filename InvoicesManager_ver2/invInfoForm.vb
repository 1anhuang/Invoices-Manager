Public Class invInfoForm
    Dim ControlDB As ControlDB = New ControlDB
    Dim invHeader_T As Object                  '發票檔頭 Table
    Dim invDtl_T As Object                     '發票明細
    Dim mode As String = "search"
    'Dim crtStm As String = "select r.receiptID as '發票編號', r.type as '買/賣', r.uses as 類別, r.customID as 統一編號, c.custom as 買受人, r.date as 日期, r.n_total as '銷售額合計', r.taxes as 營業稅, r.total as '總計', r.note as '備註' " & _
    '                       "from receipt r left join custom c on r.customID = c.customID Where logOut = 0"

    Sub RefreshInvH_T()
        If (Not TypeOf invHeader_T Is String And Not invHeader_T Is DBNull.Value And Not invHeader_T Is Nothing) Then
            invHeader_T.Clear()
            invHeader_T.Dispose()
            'MsgBox("invHeader_T 資源已清除")
        End If
        invHeader_T = ControlDB.Exe_talbe(SettingVars.curInvStm)
        invHeader_dgv.DataSource = invHeader_T

        If (TypeOf invHeader_T Is String) Then
            MsgBox("Error!" & vbCrLf & invDtl_T, 0 + 16)
            invSum_lb.Text = ""
            Exit Sub
        ElseIf (invHeader_T Is DBNull.Value) Then
            MsgBox("查無發票資料", 0 + 48)
            invSum_lb.Text = ""
            Exit Sub
        End If

        '設定欄位寬度
        invHeader_dgv.Columns(0).Width = 120        '發票編號
        invHeader_dgv.Columns(1).Width = 55         '買/賣
        invHeader_dgv.Columns(2).Width = 55         '類別
        invHeader_dgv.Columns(3).Width = 95         '統一編號
        invHeader_dgv.Columns(4).Width = 200        '買受人
        invHeader_dgv.Columns(5).Width = 100  '     '日期

        '隱藏欄位 僅供計算用
        invHeader_dgv.Columns("銷售額合計").Visible = False  '6
        invHeader_dgv.Columns("營業稅").Visible = False      '7
        invHeader_dgv.Columns("總計").Visible = False        '8
        invHeader_dgv.Columns("備註").Visible = False        '9

        invHeader_dgv.Rows(0).Selected = True
        invHeader_dgv.Rows(0).Selected = True

        '重新計算金額
        Dim invSum As String = "發票總結:   共有 @value1 筆   金額(未稅) @value2 元     營業稅 @value3 元     總計(含稅) @value4 元"
        '計算各欄位總和
        invSum = Replace(invSum, "@value1", invHeader_dgv.Rows.Count - 1)
        invSum = Replace(invSum, "@value2", invHeader_T.Compute("SUM(銷售額合計)", String.Empty))
        invSum = Replace(invSum, "@value3", invHeader_T.Compute("SUM(營業稅)", String.Empty))
        invSum = Replace(invSum, "@value4", invHeader_T.Compute("SUM(總計)", String.Empty))
        invSum_lb.Text = invSum
    End Sub

    Function CheckMsg(ByVal title As String, ByVal msg As String) As Boolean
        '彈出確認視窗()
        Dim respnCode = MsgBox(msg, 4 + 32, title)
        ' 是(6)  否(7)
        If (respnCode <> 6) Then
            Return False
        End If

        Return True
    End Function

    Function CmpType2Index(ByVal ch As Char) As Integer 'for typeList compare
        Dim chs As Char() = {"P", "M", "S", "I"}
        For i = 0 To chs.Length - 1
            If ch = chs(i) Then
                Return i

            End If
        Next
        Return -1
    End Function

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

    Private Sub invoiceInfo_EnabledChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.EnabledChanged
        If (Me.Enabled = True) Then
            RefreshInvH_T()
            'invHeader_dgv.DataSource = invHeader_T
        End If
    End Sub


    Private Sub invoiceRst_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        menuForm.Enabled = True
        SettingVars.curInvStm = "select r.receiptID as '發票編號', r.type as '買/賣', r.uses as 類別, r.customID as 統一編號, c.custom as 買受人, r.date as 日期, r.n_total as '銷售額合計', r.taxes as 營業稅, r.total as '總計', r.note as '備註' " & _
                                "from receipt r left join custom c on r.customID = c.customID Where logOut = 0"
    End Sub

    Private Sub insertShow_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles insertShow_btn.Click
        SettingVars.invInsertMode = "insert"
        Me.Enabled = False
        invInsertForm.Show()
    End Sub

    Private Sub filter_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles filter_btn.Click
        Me.Enabled = False
        filterForm.Show()
    End Sub

    Private Sub modiShow_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles modiShow_btn.Click
        If (invHeader_dgv.SelectedRows.Count <= 0) Then
            MsgBox("請選取有效列", 0 + 48)
            Exit Sub
        ElseIf (invHeader_dgv.SelectedRows(0).Index >= invHeader_dgv.Rows.Count - 1) Then
            MsgBox("請選取有效列", 0 + 48)
            Exit Sub
        End If

        Dim i As Integer = invHeader_dgv.SelectedRows(0).Index
        SettingVars.invInsertMode = "modify"
        Me.Enabled = False
        invInsertForm.Show()

        invInsertForm.sellflg.Checked = IIf(invHeader_dgv.Rows(i).Cells(1).Value = "S", True, False)
        invInsertForm.buyflg.Checked = IIf(invHeader_dgv.Rows(i).Cells(1).Value = "B", True, False)
        invInsertForm.reptID_txt.Text = invHeader_dgv.Rows(i).Cells(0).Value
        invInsertForm.custID_txt.Text = invHeader_dgv.Rows(i).Cells(3).Value
        invInsertForm.cust_txt.Text = invHeader_dgv.Rows(i).Cells(4).Value
        invInsertForm.t_date.Value = invHeader_dgv.Rows(i).Cells(5).Value
        invInsertForm.typelist.SelectedIndex = CmpType2Index(invHeader_dgv.Rows(i).Cells(2).Value)
        For i = 0 To detail_dgv.Rows.Count - 2
            invInsertForm.dtl_T.Rows.Add(detail_dgv.Rows(i).Cells(1).Value, detail_dgv.Rows(i).Cells(2).Value, detail_dgv.Rows(i).Cells(3).Value)
        Next
        invInsertForm.note_txt.Text = note_txt.Text
    End Sub

    Private Sub invoiceRst_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        curInvStm = "select r.receiptID as '發票編號', r.type as '買/賣', r.uses as 類別, r.customID as 統一編號, c.custom as 買受人, r.date as 日期, r.n_total as '銷售額合計', r.taxes as 營業稅, r.total as '總計', r.note as '備註' " & _
            "from receipt r left join custom c on r.customID = c.customID Where logOut = 0"
        RefreshInvH_T()
        Me.invHeader_dgv.DefaultCellStyle.Font = New Font("微軟正黑體", 12)
        Me.detail_dgv.DefaultCellStyle.Font = New Font("微軟正黑體", 12)
        'invHeader_dgv.DataSource = invHeader_T

        ''設定欄位寬度
        'invHeader_dgv.Columns(0).Width = 80         '發票編號
        'invHeader_dgv.Columns(1).Width = 55         '買/賣
        'invHeader_dgv.Columns(2).Width = 55         '類別
        'invHeader_dgv.Columns(3).Width = 78         '統一編號
        'invHeader_dgv.Columns(4).Width = 170        '買受人
        'invHeader_dgv.Columns(5).Width = 60         '日期

        ''隱藏欄位 僅供計算用
        'invHeader_dgv.Columns("銷售額合計").Visible = False  '6
        'invHeader_dgv.Columns("營業稅").Visible = False      '7
        'invHeader_dgv.Columns("總計").Visible = False        '8
        'invHeader_dgv.Columns("備註").Visible = False        '9

        'invHeader_dgv.Rows(0).Selected = True
    End Sub


    Private Sub invHeader_dgv_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles invHeader_dgv.SelectionChanged
        If (invHeader_dgv.SelectedRows.Count = 0) Then
            '選取cell自動將整行選取起來
            If (invHeader_dgv.SelectedCells.Count > 0) Then
                Dim cellRow As Integer = invHeader_dgv.SelectedCells(0).RowIndex
                invHeader_dgv.Rows(cellRow).Selected = True
                '選取的cell超過現有資料表的index則不做任何事
                If (cellRow >= invHeader_dgv.Rows.Count - 1) Then
                    Exit Sub
                End If
            Else
                Exit Sub
            End If
        ElseIf (invHeader_dgv.SelectedRows(0).Index >= invHeader_dgv.Rows.Count - 1) Then
            Exit Sub
        End If

        If (Not TypeOf invDtl_T Is String And Not invDtl_T Is DBNull.Value And Not invDtl_T Is Nothing) Then
            invDtl_T.Clear()
            invDtl_T.Dispose()
            'MsgBox("invDtl_T 資源已清除")
        End If

        Dim i As Integer = invHeader_dgv.SelectedRows(0).Index
        Dim custID As String = invHeader_dgv.Rows(i).Cells(0).Value
        Dim stm As String = "select d.receiptID 發票編號, p.product 品名, d.numOfProduct 數目, d.price 單價, d.price*d.numOfProduct 金額 " & _
                            "from detail d " & _
                            "left join product p on d.productID = p.productID " & _
                            "where d.receiptID = '@criteria'"

        stm = Replace(stm, "@criteria", custID)
        invDtl_T = ControlDB.Exe_talbe(stm)

        If (TypeOf invDtl_T Is String) Then
            MsgBox("Error!" & vbCrLf & invDtl_T, 0 + 16)
            Exit Sub
        ElseIf (invDtl_T Is DBNull.Value) Then
            MsgBox("查無此筆明細資料", 0 + 48)
            Exit Sub
        End If

        detail_dgv.DataSource = invDtl_T

        detail_dgv.Columns(0).Width = 120    '發票編號
        detail_dgv.Columns(1).Width = 270   '品名
        detail_dgv.Columns(2).Width = 65    '數目
        detail_dgv.Columns(3).Width = 80    '單價
        detail_dgv.Columns(4).Width = 90    '金額

        detail_dgv.Rows(0).Selected = True
        Dim dtSum As String = "明細總結:   共有 " & detail_dgv.Rows.Count - 1 & " 筆   金額(未稅) " & invHeader_dgv.Rows(i).Cells("銷售額合計").Value & " 元     營業稅 " & invHeader_dgv.Rows(i).Cells("營業稅").Value & " 元     總計(含稅) " & _
                         invHeader_dgv.Rows(i).Cells("總計").Value & "  元"
        dtSum_Lb.Text = dtSum
        note_txt.Text = invHeader_dgv.Rows(i).Cells("備註").Value
    End Sub

    Private Sub invUp_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles invUp_btn.Click
        'If (invHeader_dgv.SelectedRows.Count <= 0) Then
        '    Exit Sub
        'ElseIf (invHeader_dgv.SelectedRows(0).Index - 1 < 0) Then
        '    Exit Sub
        'End If

        'Dim i As Integer = invHeader_dgv.SelectedRows(0).Index
        'invHeader_dgv.Rows(i).Selected = False
        'invHeader_dgv.Rows(i - 1).Selected = True
        'invHeader_dgv.FirstDisplayedScrollingRowIndex = i - 1   '設定滾輪
        invHeader_dgv.Focus()
        SendKeys.Send("{UP}")
    End Sub

    Private Sub invDwn_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles invDwn_btn.Click
        'If (invHeader_dgv.SelectedRows.Count <= 0) Then
        '    Exit Sub
        If (invHeader_dgv.SelectedRows(0).Index + 1 >= invHeader_dgv.Rows.Count - 1) Then
            Exit Sub
        End If

        'Dim i As Integer = invHeader_dgv.SelectedRows(0).Index
        'invHeader_dgv.Rows(i).Selected = False
        'invHeader_dgv.Rows(i + 1).Selected = True
        'invHeader_dgv.FirstDisplayedScrollingRowIndex = i + 1   '設定滾輪
        invHeader_dgv.Focus()
        SendKeys.Send("{DOWN}")
    End Sub

    Private Sub dtlUP_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtlUP_btn.Click
        'If (detail_dgv.SelectedRows.Count <= 0) Then
        '    Exit Sub
        'ElseIf (detail_dgv.SelectedRows(0).Index - 1 < 0) Then
        '    Exit Sub
        'End If

        'Dim i As Integer = detail_dgv.SelectedRows(0).Index
        'detail_dgv.Rows(i).Selected = False
        'detail_dgv.Rows(i - 1).Selected = True
        'detail_dgv.FirstDisplayedScrollingRowIndex = i - 1   '設定滾輪
        dtlUP_btn.Enabled = False
        detail_dgv.Focus()
        SendKeys.Send("{UP}")
        dtlUP_btn.Enabled = True
    End Sub


    Private Sub dtlDwn_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtlDwn_btn.Click
        'If (detail_dgv.SelectedRows.Count <= 0) Then
        '    Exit Sub
        If (detail_dgv.SelectedRows(0).Index + 1 >= detail_dgv.Rows.Count - 1) Then
            Exit Sub
        End If

        'Dim i As Integer = detail_dgv.SelectedRows(0).Index
        'detail_dgv.Rows(i).Selected = False
        'detail_dgv.Rows(i + 1).Selected = True
        'detail_dgv.FirstDisplayedScrollingRowIndex = i + 1   '設定滾輪
        detail_dgv.Focus()
        SendKeys.Send("{DOWN}")
    End Sub

    Private Sub 註銷發票ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 註銷發票ToolStripMenuItem.Click
        If (invHeader_dgv.SelectedRows.Count < 0) Then
            Exit Sub
        ElseIf (invHeader_dgv.SelectedRows.Count >= invHeader_dgv.Rows.Count - 1) Then
            Exit Sub
        End If

        Dim i As Integer = invHeader_dgv.SelectedRows(0).Index
        Dim reptID As String = invHeader_dgv.Rows(i).Cells(0).Value

        If (CheckMsg("註銷確認", "確定要註銷 """ & reptID & """ 這張發票嗎?") = False) Then
            Exit Sub
        End If

        If (ControlDB.NonExe("Update receipt Set Logout = 1 Where receiptID = " & "'" & reptID & "'") = False) Then
            MsgBox("註銷失敗", 0 + 16)
            Exit Sub
        End If

        RefreshInvH_T()
        MsgBox("註銷成功", 0 + 64)
    End Sub

    Private Sub 移至新增欄位ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 移至新增欄位ToolStripMenuItem.Click
        If (invHeader_dgv.SelectedRows.Count <= 0) Then
            MsgBox("請選取有效列！", 0 + 48)
            Exit Sub
        ElseIf (invHeader_dgv.SelectedRows(0).Index > invHeader_dgv.Rows.Count - 2) Then
            MsgBox("請選取有效列！", 0 + 48)
            Exit Sub
        End If

        invInsertForm.Show()
        Dim i As Integer = invHeader_dgv.SelectedRows(0).Index
        Me.Enabled = False
        SettingVars.invInsertMode = "insert"

        invInsertForm.sellflg.Checked = IIf(invHeader_dgv.Rows(i).Cells(1).Value = "S", True, False)
        invInsertForm.buyflg.Checked = IIf(invHeader_dgv.Rows(i).Cells(1).Value = "B", True, False)
        invInsertForm.reptID_txt.Text = invHeader_dgv.Rows(i).Cells(0).Value
        invInsertForm.custID_txt.Text = invHeader_dgv.Rows(i).Cells(3).Value
        invInsertForm.cust_txt.Text = invHeader_dgv.Rows(i).Cells(4).Value
        invInsertForm.t_date.Value = invHeader_dgv.Rows(i).Cells(5).Value
        invInsertForm.typelist.SelectedIndex = CmpType2Index(invHeader_dgv.Rows(i).Cells(2).Value)
        For i = 0 To detail_dgv.Rows.Count - 2
            invInsertForm.dtl_T.Rows.Add(detail_dgv.Rows(i).Cells(1).Value, detail_dgv.Rows(i).Cells(2).Value, detail_dgv.Rows(i).Cells(3).Value)
        Next

        invInsertForm.note_txt.Text = note_txt.Text
    End Sub

    Private Sub modeChange_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles modeChange_btn.Click
        mode = IIf(modeChange_btn.Text = "刪除", "delete", "search")
        modeChange_btn.Text = IIf(mode = "delete", "查詢", "刪除")
        If (mode = "search") Then
            curInvStm = "select r.receiptID as '發票編號', r.type as '買/賣', r.uses as 類別, r.customID as 統一編號, c.custom as 買受人, r.date as 日期, r.n_total as '銷售額合計', r.taxes as 營業稅, r.total as '總計', r.note as '備註' " & _
                        "from receipt r left join custom c on r.customID = c.customID  Where logOut = 0"
            insertShow_btn.Enabled = True
            filter_btn.Enabled = True
            modiShow_btn.Enabled = True
            註銷發票ToolStripMenuItem.Visible = True
            delt_btn.Visible = True = False
        ElseIf (mode = "delete") Then
            curInvStm = "select r.receiptID as '發票編號', r.type as '買/賣', r.uses as 類別, r.customID as 統一編號, c.custom as 買受人, r.date as 日期, r.n_total as '銷售額合計', r.taxes as 營業稅, r.total as '總計', r.note as '備註' " & _
            "from receipt r left join custom c on r.customID = c.customID Where logOut = 1"
            delt_btn.Visible = True
            insertShow_btn.Enabled = False
            filter_btn.Enabled = False
            modiShow_btn.Enabled = False
            註銷發票ToolStripMenuItem.Visible = False
        End If
        RefreshInvH_T()
    End Sub

    Private Sub delt_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles delt_btn.Click
        If (invHeader_dgv.SelectedRows.Count <= 0) Then
            MsgBox("請選取有效列！", 0 + 48)
            Exit Sub
        ElseIf (invHeader_dgv.SelectedRows(0).Index > invHeader_dgv.Rows.Count - 2) Then
            MsgBox("請選取有效列！", 0 + 48)
            Exit Sub
        End If

        Dim i As Integer = invHeader_dgv.SelectedRows(0).Index
        Dim reptID As String = invHeader_dgv.Rows(i).Cells(0).Value
        If (CheckMsg("刪除確認", "確定要刪除""" & reptID & """這張發票?")) Then
            If (DeleteInvoice(reptID)) Then
                MsgBox("刪除成功", 0 + 48)
                RefreshInvH_T()
            End If
        Else
            Exit Sub
        End If
    End Sub

    Private Sub detail_dgv_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles detail_dgv.SelectionChanged
        If (detail_dgv.SelectedCells.Count > 0) Then
            detail_dgv.Rows(detail_dgv.SelectedCells(0).RowIndex).Selected = True
        End If
    End Sub

End Class