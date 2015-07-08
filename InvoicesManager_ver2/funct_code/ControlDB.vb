Imports MySql.Data.MySqlClient
Imports System.Data
Public Class ControlDB
    Private connStr As String
    Private reader As MySqlDataReader

    Sub New()
        connStr = "Server=localhost;User=root;Password=test123;Database=invoices;port=3306;Character Set=utf8;"
    End Sub

    Function NonExe(ByVal stm As String) As Boolean
        Dim conn As MySqlConnection
        Dim cmd As MySqlCommand
        Try
            conn = New MySqlConnection(connStr)
            conn.Open()
            cmd = New MySqlCommand(stm, conn)
            NonExe = cmd.ExecuteNonQuery()

        Catch e As Exception
            MsgBox("error: NonExe" & vbCrLf & e.Message)
            NonExe = False

        Finally
            cmd = Nothing
            conn.Close()
            conn.Dispose()
            conn = Nothing
        End Try

    End Function

    Function Exe_talbe(ByVal stm As String) As Object
        Dim conn As MySqlConnection
        Dim da As MySqlDataAdapter
        Dim dt As DataTable
        Try
            dt = New DataTable
            conn = New MySqlConnection(connStr)
            da = New MySqlDataAdapter(stm, conn)
            da.Fill(dt)

            '使用DataAdapter拿到空資料時不會產生exception，reader才會
            '所以要另外判斷拿到的Row數是否為0
            '才能判斷table是否有資料
            If (dt.Rows.Count = 0) Then
                Exe_talbe = DBNull.Value
            Else
                Exe_talbe = dt
            End If
        Catch ex As Exception
            '取得null集合時會發生exception
            '此時的error number = 5
            '手動設定null value
            'If (Err.Number = 5) Then
            'Exe_talbe = DBNull.Value
            'MsgBox(ex.Message)
            'End If

            MsgBox("ControlDb.Exe_table error" & vbCrLf & ex.Message)
            Exe_talbe = ex.Message

        Finally
            conn.Close()
            conn.Dispose()
            conn = Nothing
            da.Dispose()
            da = Nothing
            dt.Dispose()
            dt = Nothing
        End Try
    End Function

    Function Lookup(ByVal field As String, ByVal table As String, ByVal criteria As String) As Object
        Dim stm = "Select " & field & " From " & table & IIf(criteria <> "", (" Where " & criteria), "")
        Dim conn As MySqlConnection
        Dim cmd As MySqlCommand
        Try
            conn = New MySqlConnection(connStr)
            cmd = New MySqlCommand(stm, conn)
            conn.Open()
            reader = cmd.ExecuteReader()
            reader.Read()

            Lookup = reader(0)
        Catch e As Exception
            '取得null集合時會發生exception
            '此時的error number = 5
            '手動設定null value
            If (Err.Number = 5) Then
                Lookup = DBNull.Value
            Else
                Lookup = e.Message
                MsgBox("error: ControlDb.Lookup" & vbCrLf & e.Message)
            End If

        Finally
            If (Not reader Is Nothing) Then
                reader.Close()
                reader.Dispose()
                reader = Nothing
            End If

            If (Not cmd Is Nothing) Then
                cmd.Dispose()
                cmd = Nothing
            End If

            If (Not conn Is Nothing) Then
                conn.Close()
                conn.Dispose()
            End If
        End Try
    End Function
End Class
