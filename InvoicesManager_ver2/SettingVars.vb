Module SettingVars
    'infoForm
    Public infoCaller As String = ""    '哪個Form呼叫infoForm
    Public infoMode As String = ""      'infoForm顯示模式 ( 客戶 / 商品 )

    'invInsertForm
    Public invInsertMode As String = ""

    'custInsertForm
    Public custInsertMode As String = ""

    'prodInsertForm
    Public prodInsertMode As String = ""

    'filterForm setting
    Public bs_chk As Boolean = False
    Public bs_crt As String = ""
    Public reptID_chk As Boolean = False
    Public reptID_crt As String = ""
    Public custID_chk As Boolean = False
    Public custID_crt As String = ""
    Public cust_chk As Boolean = False
    Public cust_crt As String = ""
    Public date_chk As Boolean = False
    Public date_from As Date = Now.Date()
    Public date_end As Date = Now.Date()
    Public uses_chk As Boolean = False
    Public uses_crt As String = ""
    Public note_chk As Boolean = False
    Public note_crt As String = ""

    '儲存invoiceInfo From更新table的條件
    Public curInvStm As String = "select r.receiptID as '發票編號', r.type as '買/賣', r.uses as 類別, r.customID as 統一編號, c.custom as 買受人, r.date as 日期, r.n_total as '銷售額合計', r.taxes as 營業稅, r.total as '總計', r.note as '備註' " & _
                                 "from receipt r left join custom c on r.customID = c.customID Where logOut = 0"
End Module
