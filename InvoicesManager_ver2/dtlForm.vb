Public Class dtlForm

    Function CheckMsg(ByVal title As String, ByVal msg As String) As Boolean
        '彈出確認視窗()
        Dim respnCode = MsgBox(msg, 4 + 32, title)
        ' 是(6)  否(7)
        If (respnCode <> 6) Then
            Return False
        End If

        Return True
    End Function

    Private Sub dtlForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        invInsertForm.Enabled = True
    End Sub

    Private Sub dtlForm_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        dtl_dgv.DataSource = invInsertForm.dtl_T
        Me.dtl_dgv.DefaultCellStyle.Font = New Font("微軟正黑體", 12)
        dtl_dgv.Columns(0).Width = 150  '品名
        dtl_dgv.Columns(1).Width = 80   '數目
        dtl_dgv.Columns(2).Width = 150  '單價
        dtl_dgv.Rows(0).Selected = True
        prod_txt.Focus()
    End Sub

    Private Sub add_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add_btn.Click
        If (prod_txt.Text() = "" Or nOfProd_txt.Text() = "" Or price_txt.Text() = "") Then
            MsgBox("請確認資料欄位是否都填齊", 0 + 48)
            Exit Sub
        ElseIf (IsNumeric(nOfProd_txt.Text()) = False Or IsNumeric(price_txt.Text()) = False) Then
            MsgBox("數目與金額欄位必須為有效數字", 0 + 48)
            Exit Sub
        End If

        invInsertForm.dtl_T.Rows.Add(prod_txt.Text(), nOfProd_txt.Text(), price_txt.Text())
        prod_txt.Text() = ""
        nOfProd_txt.Text() = ""
        price_txt.Text() = ""
        prod_txt.Focus()

        dtl_dgv.Rows(dtl_dgv.Rows.Count - 2).Selected = True
        dtl_dgv.FirstDisplayedScrollingRowIndex = dtl_dgv.Rows.Count - 2
    End Sub

    Private Sub clear_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear_btn.Click
        If (CheckMsg("清除確認", "確定要清除所有明細嗎?")) Then
            invInsertForm.dtl_T.Clear()
        End If
    End Sub

    Private Sub delete_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles delete_btn.Click
        If (dtl_dgv.SelectedRows.Count = 0) Then
            Exit Sub
        ElseIf (dtl_dgv.SelectedRows(0).Index >= dtl_dgv.Rows.Count - 1) Then
            MsgBox("選取列中包含無效列", 0 + 48)
            Exit Sub
        End If

        Dim i As Integer = dtl_dgv.SelectedRows(0).Index
        invInsertForm.dtl_T.Rows.RemoveAt(i)
        If (i - 1 < 0) Then
            i = 0
        Else
            i = i - 1
        End If
        dtl_dgv.Rows(i).Selected = True
        dtl_dgv.FirstDisplayedScrollingRowIndex = i
    End Sub

    Private Sub dtlUp_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtlUp_btn.Click
        If (dtl_dgv.SelectedRows.Count <= 0) Then
            Exit Sub
        ElseIf (dtl_dgv.SelectedRows(0).Index - 1 < 0) Then
            Exit Sub
        End If

        Dim i As Integer = dtl_dgv.SelectedRows(0).Index
        dtl_dgv.Rows(i).Selected = False
        dtl_dgv.Rows(i - 1).Selected = True
        dtl_dgv.FirstDisplayedScrollingRowIndex = i - 1   '設定滾輪
    End Sub

    Private Sub dtlDwn_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtlDwn_btn.Click
        If (dtl_dgv.SelectedRows.Count <= 0) Then
            Exit Sub
        ElseIf (dtl_dgv.SelectedRows(0).Index + 1 > dtl_dgv.Rows.Count - 1) Then
            Exit Sub
        End If

        Dim i As Integer = dtl_dgv.SelectedRows(0).Index
        dtl_dgv.Rows(i).Selected = False
        dtl_dgv.Rows(i + 1).Selected = True
        dtl_dgv.FirstDisplayedScrollingRowIndex = i + 1   '設定滾輪
    End Sub

    Private Sub prod_txt_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles prod_txt.DoubleClick
        Me.Enabled = False
        SettingVars.infoCaller = "dtlForm"
        SettingVars.infoMode = "商品資訊"
        infoForm.Show()
    End Sub

    Private Sub ok_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ok_btn.Click
        Me.Close()
    End Sub

    Private Sub dtl_dgv_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtl_dgv.SelectionChanged
        If (dtl_dgv.SelectedRows.Count = 0) Then
            If (dtl_dgv.SelectedCells.Count > 0) Then
                dtl_dgv.Rows(dtl_dgv.SelectedCells(0).RowIndex).Selected = True
            End If
        End If
    End Sub
End Class