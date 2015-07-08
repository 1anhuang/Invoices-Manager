Public Class prodInsertForm
    Dim ControlDB As ControlDB = New ControlDB
    Dim modiNumOfProd As Object
    Private Sub prodInsertForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        infoForm.Enabled = True
    End Sub

    Private Sub insert_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles insert_btn.Click

        If (prod_txt.Text.Trim = "") Then
            MsgBox("請確認欄位已填齊", 0 + 48)
            Exit Sub
        ElseIf (SettingVars.prodInsertMode = "modify") Then
            If (ControlDB.NonExe("Delete From product Where productID = " & modiNumOfProd)) Then
                'MsgBox("刪除成功", 0 + 48)
            Else
                MsgBox("修改失敗", 0 + 48)
                Exit Sub
            End If
        ElseIf (Not ControlDB.Lookup("product", "product", "product = '" & prod_txt.Text.Trim & "'") Is DBNull.Value) Then
            MsgBox("商品名稱已存在，請再確認一次", 0 + 48)
            Exit Sub
        End If

        Dim stm As String = "Insert into @table ( @field ) value ( @value )"
        Dim numOfprod As Integer = IIf(SettingVars.prodInsertMode = "modify", modiNumOfProd, ControlDB.Lookup("count(*)", "product", "") + 1)
        Dim msg As String = IIf(SettingVars.prodInsertMode = "modify", "修改", "新增")
        stm = Replace(stm, "@table", "product")
        stm = Replace(stm, "@field", "productID, product")
        stm = Replace(stm, "@value", "'" & numOfprod & "', '" & prod_txt.Text & "'")

        If (ControlDB.NonExe(stm)) Then
            MsgBox(msg & "成功", 0 + 48)
        Else
            MsgBox(msg & "失敗", 0 + 48)
            Exit Sub
        End If

        prod_txt.Text = ""
        If (SettingVars.prodInsertMode = "modify") Then
            Me.Close()
        Else
            prod_txt.Focus()
        End If
    End Sub

    Private Sub prodInsertForm_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        If (SettingVars.prodInsertMode = "insert") Then
            title.Text = "產品新增"
            insert_btn.Text = "新增"
        ElseIf (SettingVars.prodInsertMode = "modify") Then
            title.Text = "產品修改"
            insert_btn.Text = "修改"
            modiNumOfProd = ControlDB.Lookup("productID", "product", "product = '" & prod_txt.Text.Trim & "'")
            If (modiNumOfProd Is DBNull.Value) Then
                MsgBox("發生錯誤", 0 + 48)
                Me.Close()
            Else
                'MsgBox(modiNumOfProd)
            End If
        End If
    End Sub
End Class