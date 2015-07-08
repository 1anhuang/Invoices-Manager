Public Class infoForm

    Dim ControlDB As ControlDB = New ControlDB
    Dim info_T As Object                  '買受人/商品資訊 Table
    Dim custStm As String = "select customID As 統一編號, custom As 買受人 from custom order by customID"
    Dim prodStm As String = "select productID As 商品編號, product As 商品名稱 from product order by productID"

    Sub RefreshDgv()
        If (Not TypeOf info_T Is String And Not info_T Is DBNull.Value And Not info_T Is Nothing) Then
            info_T.Clear()
            info_T.Dispose()
            'MsgBox("info_T 資源已清除")
        End If

        If (title.Text = "買受人資訊") Then
            info_T = ControlDB.Exe_talbe(custStm)
        Else
            info_T = ControlDB.Exe_talbe(prodStm)
        End If

        info_dgv.DataSource = info_T

        If (TypeOf info_T Is String) Then
            MsgBox("Error!" & vbCrLf & info_T, 0 + 16)
            Exit Sub
        ElseIf (info_T Is DBNull.Value) Then
            MsgBox("查無" & title.Text, 0 + 48)
            Exit Sub
        End If

        numOfRow_lb.Text = "總共有 " & info_dgv.Rows.Count - 1 & "筆資料"
        info_dgv.Rows(0).Selected = True
    End Sub

    Private Sub infoForm_EnabledChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.EnabledChanged
        If (Me.Enabled = True) Then
            RefreshDgv()
        End If
    End Sub
    Private Sub custInfo_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        title.Text = SettingVars.infoMode
        Me.info_dgv.DefaultCellStyle.Font = New Font("微軟正黑體", 12)
        If (SettingVars.infoCaller <> "menuForm") Then
            Select_btn.Visible = True
            Select_btn.Enabled = True
            insertInfo_btn.Visible = False
            insertInfo_btn.Enabled = False
            updInfo_btn.Visible = False
            updInfo_btn.Enabled = False
        End If

        RefreshDgv()

        info_dgv.Columns(0).Width = 100
        info_dgv.Columns(1).Width = 260
    End Sub
    Private Sub custInfo_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If (Select_btn.Visible = True) Then
            Select_btn.Visible = False
            Select_btn.Enabled = False
        End If

        title.Text = ""

        '根據FormCaller來恢復視窗
        If (SettingVars.infoCaller = "menuForm") Then
            menuForm.Enabled = True
        ElseIf (SettingVars.infoCaller = "invInsertForm") Then
            invInsertForm.Enabled = True
        ElseIf (SettingVars.infoCaller = "dtlForm") Then
            dtlForm.Enabled = True
        ElseIf (SettingVars.infoCaller = "filterForm") Then
            filterForm.Enabled = True
        End If
        SettingVars.infoMode = ""
        SettingVars.infoCaller = ""
    End Sub

    Private Sub invUp_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles invUp_btn.Click
        'If (info_dgv.SelectedRows.Count <= 0) Then
        '    Exit Sub
        'ElseIf (info_dgv.SelectedRows(0).Index - 1 < 0) Then
        '    Exit Sub
        'End If

        'Dim i As Integer = info_dgv.SelectedRows(0).Index
        'info_dgv.Rows(i).Selected = False
        'info_dgv.Rows(i - 1).Selected = True
        'info_dgv.FirstDisplayedScrollingRowIndex = i - 1   '設定滾輪
        info_dgv.Focus()
        SendKeys.Send("{UP}")
    End Sub

    Private Sub invDwn_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles invDwn_btn.Click
        'If (info_dgv.SelectedRows.Count <= 0) Then
        '    Exit Sub
        'ElseIf (info_dgv.SelectedRows(0).Index + 1 > info_dgv.Rows.Count - 1) Then
        '    Exit Sub
        'End If

        'Dim i As Integer = info_dgv.SelectedRows(0).Index
        'info_dgv.Rows(i).Selected = False
        'info_dgv.Rows(i + 1).Selected = True
        'info_dgv.FirstDisplayedScrollingRowIndex = i + 1   '設定滾輪
        'invDwn_btn.Enabled = False
        'SendKeys.Send("{DOWN}")
        'SendKeys.Send("{ENTER}")
        info_dgv.Focus()
        SendKeys.Send("{DOWN}")

    End Sub

    Private Sub Select_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Select_btn.Click
        If (info_dgv.SelectedRows.Count <= 0) Then
            Exit Sub
        ElseIf (info_dgv.SelectedRows(0).Index > info_dgv.Rows.Count - 2) Then
            MsgBox("請選取有效列！", 0 + 48)
            Exit Sub
        End If

        Dim i As Integer = info_dgv.SelectedRows(0).Index
        If (SettingVars.infoMode = "買受人資訊") Then
            If (SettingVars.infoCaller = "invInsertForm") Then
                invInsertForm.custID_txt.Text = info_dgv.Rows(i).Cells(0).Value
                invInsertForm.cust_txt.Text = info_dgv.Rows(i).Cells(1).Value
                Me.Close()
            ElseIf (SettingVars.infoCaller = "filterForm") Then
                filterForm.custID_crt.Text = info_dgv.Rows(i).Cells(0).Value
                filterForm.cust_crt.Text = info_dgv.Rows(i).Cells(1).Value
                Me.Close()
            End If
        ElseIf (SettingVars.infoMode = "商品資訊") Then
            If (SettingVars.infoCaller = "dtlForm") Then
                dtlForm.prod_txt.Text = info_dgv.Rows(i).Cells(1).Value
                Me.Close()
            End If
        End If
    End Sub

    Private Sub insertInfo_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles insertInfo_btn.Click
        Me.Enabled = False
        If (SettingVars.infoMode = "買受人資訊") Then
            SettingVars.custInsertMode = "insert"
            custInsetForm.Show()
        ElseIf (SettingVars.infoMode = "商品資訊") Then
            SettingVars.prodInsertMode = "insert"
            prodInsertForm.Show()
        End If
    End Sub

    Private Sub updInfo_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles updInfo_btn.Click
        If (info_dgv.SelectedRows.Count <= 0) Then
            MsgBox("請選取有效列", 0 + 48)
            Exit Sub
        ElseIf (info_dgv.SelectedRows(0).Index >= info_dgv.Rows.Count - 1) Then
            MsgBox("請選取有效列", 0 + 48)
            Exit Sub
        End If

        Dim i As Integer = info_dgv.SelectedRows(0).Index
        Me.Enabled = False
        If (SettingVars.infoMode = "買受人資訊") Then
            SettingVars.custInsertMode = "modify"
            custInsetForm.custID_txt.Text = info_dgv.Rows(i).Cells(0).Value
            custInsetForm.cust_txt.Text = info_dgv.Rows(i).Cells(1).Value
            custInsetForm.Show()
        ElseIf (SettingVars.infoMode = "商品資訊") Then
            SettingVars.prodInsertMode = "modify"
            prodInsertForm.prod_txt.Text = info_dgv.Rows(i).Cells(1).Value
            prodInsertForm.Show()
        End If
    End Sub

    Private Sub info_dgv_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles info_dgv.SelectionChanged
        '選取cell自動選取整行
        If (info_dgv.SelectedRows.Count = 0) Then
            If (info_dgv.SelectedCells.Count > 0) Then
                info_dgv.Rows(info_dgv.SelectedCells(0).RowIndex).Selected = True
            End If
        End If
    End Sub
End Class