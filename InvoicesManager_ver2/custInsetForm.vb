Public Class custInsetForm
    Dim ControlDB As ControlDB = New ControlDB

    Private Sub insert_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles insert_btn.Click
        If (cust_txt.Text = "" Or custID_txt.Text = "") Then
            MsgBox("請確認欄位已填齊", 0 + 48)
            Exit Sub
        ElseIf (custID_txt.Text.Length < 8) Then
            MsgBox("統一編號必需為八碼", 0 + 48)
            Exit Sub
        ElseIf (IsNumeric(custID_txt.Text) = False) Then
            MsgBox("統一編號必須為有效數字", 0 + 48)
            Exit Sub
        ElseIf (SettingVars.custInsertMode = "modify") Then
            ControlDB.NonExe("Delete From custom Where customID = " & custID_txt.Text)
            'If (ControlDB.NonExe("Delete From custom Where customID = " & custID_txt.Text) = 0) Then
            '    MsgBox("修改失敗，請再確認一次", 0 + 48)
            '    Exit Sub
            'Else
            '    MsgBox("刪除成功，準備新增", 0 + 48)
            'End If
        ElseIf (Not ControlDB.Lookup("customID", "custom", "customID = '" & custID_txt.Text & "'") Is DBNull.Value) Then
            MsgBox("統一編號已存在，請再確認一次", 0 + 48)
            Exit Sub
        End If

        Dim stm As String = "Insert into @table ( @field ) value ( @value )"
        stm = Replace(stm, "@table", "custom")
        stm = Replace(stm, "@field", "customID, custom")
        stm = Replace(stm, "@value", "'" & custID_txt.Text & "', '" & cust_txt.Text & "'")

        Dim msg As String = IIf(SettingVars.custInsertMode = "insert", "新增", "修改")


        If (ControlDB.NonExe(stm)) Then
            MsgBox(msg & "成功", 0 + 48)
        Else
            MsgBox(msg & "失敗", 0 + 48)
            Exit Sub
        End If

        custID_txt.Text = ""
        cust_txt.Text = ""

        If (SettingVars.custInsertMode = "modify") Then
            Me.Close()
        Else
            cust_txt.Focus()
        End If
    End Sub

    Private Sub custInsetForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        infoForm.Enabled = True
    End Sub

    Private Sub custInsetForm_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        If (SettingVars.custInsertMode = "insert") Then
            title.Text = "買受人新增"
            insert_btn.Text = "新增"
        ElseIf (SettingVars.custInsertMode = "modify") Then
            title.Text = "買受人修改"
            insert_btn.Text = "修改"
            custID_txt.Enabled = False
        End If
    End Sub
End Class