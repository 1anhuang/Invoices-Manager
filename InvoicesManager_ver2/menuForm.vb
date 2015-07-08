Public Class menuForm

    Private Sub invoiceMtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles invoiceMtn.Click
        Me.Enabled = False
        invInfoForm.Show()
    End Sub

    Private Sub customMtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles customMtn.Click
        SettingVars.infoCaller = "menuForm"
        SettingVars.infoMode = "買受人資訊"
        Me.Enabled = False
        infoForm.Show()
        'infoForm.title.Text = "買受人資訊"
    End Sub

    Private Sub productMtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles productMtn.Click
        SettingVars.infoCaller = "menuForm"
        SettingVars.infoMode = "商品資訊"
        Me.Enabled = False
        infoForm.Show()
        'infoForm.title.Text = "商品資訊"
    End Sub
End Class
