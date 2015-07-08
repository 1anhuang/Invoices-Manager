Public Class filterForm
    Dim formatStm As String = "select r.receiptID as '發票編號', r.type as '買/賣', r.uses as 類別, r.customID as 統一編號, c.custom as 買受人, r.date as 日期, r.n_total as '銷售額合計', r.taxes as 營業稅, r.total as '總計', r.note as '備註' " & _
                            "from receipt r left join custom c on r.customID = c.customID Where logOut = 0"

    Function CheckMsg(ByVal title As String, ByVal msg As String) As Boolean
        '彈出確認視窗()
        Dim respnCode = MsgBox(msg, 4 + 32, title)
        ' 是(6)  否(7)
        If (respnCode <> 6) Then
            Return False
        End If

        Return True
    End Function

    Private Sub AddCriteria(ByRef crtStm As String, ByVal crt As String)
        crtStm = crtStm & " And " & crt
    End Sub

    Private Sub filterForm_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        bs_chk.Checked = SettingVars.bs_chk
        bs_crt.SelectedItem = SettingVars.bs_crt
        reptID_chk.Checked = SettingVars.reptID_chk
        reptID_crt.Text = SettingVars.reptID_crt
        custID_chk.Checked = SettingVars.custID_chk
        custID_crt.Text = SettingVars.custID_crt
        cust_chk.Checked = SettingVars.cust_chk
        cust_crt.Text = SettingVars.cust_crt
        date_chk.Checked = SettingVars.date_chk
        date_from.Value = SettingVars.date_from
        date_end.Value = SettingVars.date_end
        uses_chk.Checked = SettingVars.uses_chk
        uses_crt.SelectedItem = SettingVars.uses_crt
        note_chk.Checked = SettingVars.note_chk
        note_crt.Text = SettingVars.note_crt
    End Sub

    Private Sub filterForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        invInfoForm.Enabled = True
    End Sub

    Private Sub bs_chk_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bs_chk.CheckedChanged
        bs_crt.Enabled = bs_chk.Checked
    End Sub

    Private Sub reptID_chk_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reptID_chk.CheckedChanged
        reptID_crt.Enabled = reptID_chk.Checked
    End Sub

    Private Sub custID_chk_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles custID_chk.CheckedChanged
        custID_crt.Enabled = custID_chk.Checked
    End Sub

    Private Sub cust_chk_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cust_chk.CheckedChanged
        cust_crt.Enabled = cust_chk.Checked
    End Sub

    Private Sub date_chk_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles date_chk.CheckedChanged
        date_from.Enabled = date_chk.Checked
        date_end.Enabled = date_from.Enabled
    End Sub

    Private Sub uses_chk_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uses_chk.CheckedChanged
        uses_crt.Enabled = uses_chk.Checked
    End Sub

    Private Sub note_chk_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles note_chk.CheckedChanged
        note_crt.Enabled = note_chk.Checked
        noteSrch_lb.Visible = note_crt.Enabled
    End Sub

    Private Sub ok_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ok_btn.Click

        Dim crtStm As String = ""

        If (bs_chk.Checked = True And bs_crt.SelectedItem <> "") Then
            AddCriteria(crtStm, "r.type = " & "'" & bs_crt.SelectedItem.ToString.Chars(0) & "'")
            'MsgBox(crtStm)
        End If
        If (reptID_chk.Checked = True And reptID_crt.Text <> "") Then
            AddCriteria(crtStm, "r.receiptID = " & "'" & reptID_crt.Text & "'")
            'MsgBox(crtStm)
        End If
        If (custID_chk.Checked = True And custID_crt.Text <> "") Then
            AddCriteria(crtStm, "r.customID = " & "'" & custID_crt.Text & "'")
            'MsgBox(crtStm)
        End If
        If (cust_chk.Checked = True And cust_crt.Text <> "") Then
            AddCriteria(crtStm, "c.custom = " & "'" & cust_crt.Text & "'")
            'MsgBox(crtStm)
        End If
        If (date_chk.Checked = True And date_from.Value.Date > date_end.Value.Date) Then
            MsgBox("開始日期大於結束日期，請重新確認一次", 0 + 48)
            Exit Sub
        ElseIf (date_chk.Checked = True And date_from.Value.Date <= date_end.Value.Date) Then
            AddCriteria(crtStm, "r.date between " & "'" & CStr(date_from.Value.Date) & "'" & " And " & "'" & CStr(date_end.Value.Date) & "'")
            'MsgBox(crtStm)
        End If
        If (uses_chk.Checked = True And uses_crt.SelectedItem <> "") Then
            AddCriteria(crtStm, "r.uses = " & "'" & uses_crt.SelectedItem.ToString.Chars(0) & "'")
            'MsgBox(crtStm)
        End If
        If (note_chk.Checked = True And note_crt.Text <> "") Then
            '將關鍵字處理成SQL接受的語法
            Dim separators() As Char = {" "}
            Dim noteStr() As String = note_crt.Text.ToString.Split(separators, StringSplitOptions.RemoveEmptyEntries)
            Dim tmpStr As String = "%"
            For i = 0 To noteStr.Length - 1
                tmpStr = tmpStr & noteStr(i) & "%"
            Next
            If (tmpStr <> "%") Then
                AddCriteria(crtStm, "r.note Like " & "'" & tmpStr & "'")
            End If
        End If

        '儲存目前條件資訊
        SettingVars.bs_chk = bs_chk.Checked
        SettingVars.bs_crt = bs_crt.SelectedItem
        SettingVars.reptID_chk = reptID_chk.Checked
        SettingVars.reptID_crt = reptID_crt.Text
        SettingVars.custID_chk = custID_chk.Checked
        SettingVars.custID_crt = custID_crt.Text
        SettingVars.cust_chk = cust_chk.Checked
        SettingVars.cust_crt = cust_crt.Text
        SettingVars.date_chk = date_chk.Checked
        SettingVars.date_from = CStr(date_from.Value.Date)
        SettingVars.date_end = CStr(date_end.Value.Date)
        SettingVars.uses_chk = uses_chk.Checked
        SettingVars.uses_crt = uses_crt.SelectedItem
        SettingVars.note_chk = note_chk.Checked
        SettingVars.note_crt = note_crt.Text

        SettingVars.curInvStm = formatStm & crtStm
        Me.Close()
    End Sub

    Private Sub clearSrch_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearSrch_btn.Click
        If (CheckMsg("清除確認", "確定要清除目前條件嗎?") = True) Then
            bs_chk.Checked = False
            bs_crt.SelectedItem = Nothing
            reptID_chk.Checked = False
            reptID_crt.Text = ""
            custID_chk.Checked = False
            custID_crt.Text = ""
            cust_chk.Checked = False
            cust_crt.Text = ""
            date_chk.Checked = False
            date_from.Value = Now.Date()
            date_end.Value = Now.Date()
            uses_chk.Checked = False
            uses_crt.SelectedItem = Nothing
            note_chk.Checked = False
            note_crt.Text = ""
        End If
    End Sub


    Private Sub cust_crt_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles cust_crt.DoubleClick
        Me.Enabled = False
        SettingVars.infoCaller = "filterForm"
        SettingVars.infoMode = "買受人資訊"
        infoForm.Show()
    End Sub

    Private Sub custID_crt_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles custID_crt.DoubleClick
        Me.Enabled = False
        SettingVars.infoCaller = "filterForm"
        SettingVars.infoMode = "買受人資訊"
        infoForm.Show()
    End Sub
End Class