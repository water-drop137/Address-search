Imports System.Data.SqlClient

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        県名表示ラベル.Text = ""
        市区町村名表示ラベル.Text = ""
        地区名表示ラベル.Text = ""
        TextBox1.MaxLength = 7
        Call TimeDisp()

        Label8.Text = "履歴"
        ListBox1.Items.Clear()
        Call DispListBox()


    End Sub

    '年月日、時刻の取得、表示
    Public Sub TimeDisp()
        '年月日の取得
        Dim dNow As DateTime = System.DateTime.Now
        Label2.Text = dNow.ToLongDateString

        '曜日の取得
        Dim week As DayOfWeek = dNow.DayOfWeek
        'int32型にキャスト
        Dim weekNumber As Integer = CInt(dNow.DayOfWeek)
        '省略された曜日名で取得
        Dim strDate1 As String = dNow.ToString("ddd")
        Label4.Text = "(" & strDate1 & ")"

        Dim Time1 As String = dNow.Hour
        Dim Minu1 As String = dNow.Minute

        If Minu1 <= 9 Then
            Label7.Text = Time1 & ":" & "0" & Minu1
        Else
            Label7.Text = Time1 & "時" & Minu1 & "分"
        End If
    End Sub

    'TextBox1のKeyPressイベントハンドラ
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        'キーが [0]～[9] または [BackSpace] 以外の場合イベントをキャンセル
        If Not (("0"c <= e.KeyChar And e.KeyChar <= "9"c) Or e.KeyChar = ControlChars.Back) Then
            'コントロールの既定の処理を省略する場合は true
            e.Handled = True
        End If
    End Sub

    '検索ボタン押下時
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Call SelectData()

        Call InsertData()

        Call DispListBox()

    End Sub

    'テキストボックスクリック時にテキストをクリア
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.Click
        TextBox1.Text = ""
    End Sub

    '終了ボタン押下時
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox1.Text = "ここに郵便番号を入力"
        Me.ActiveControl = TextBox1
        Me.Close()

    End Sub

    '郵便番号から住所データを取得し、ラベルに表示
    Private Sub SelectData()

        Dim strZipCode As String = ""
        strZipCode = TextBox1.Text

        If strZipCode = "" Then
            MessageBox.Show("郵便番号が未入力です。")
            Exit Sub
        ElseIf IsNumeric(strZipCode) = False Then
            MessageBox.Show("郵便番号は半角数字7桁で入力してください。")
            Exit Sub
        ElseIf strZipCode.Length < 7 And strZipCode.Length >= 1 Then
            MessageBox.Show("郵便番号は半角数字7桁で入力してください。")
            Exit Sub
        End If

        Try
            'SQLServerの接続開始
            Dim sqlconn As New SqlConnection(My.Settings.sqlServer)
            sqlconn.Open()

            Try

                'SQL作成
                Dim sql As New System.Text.StringBuilder
                sql.AppendLine("SELECT ")
                sql.AppendLine("  郵便番号, ")
                sql.AppendLine("  都道府県名, ")
                sql.AppendLine("  市町村名, ")
                sql.AppendLine("  地区名")
                sql.AppendLine("FROM 住所データ1")
                sql.AppendLine("WHERE 郵便番号 ='" & strZipCode & "'")

                'SQL実行
                Dim command As New SqlCommand(sql.ToString, sqlconn)
                Dim adapter As New SqlDataAdapter(command)
                Dim dtSaitama As New DataTable
                adapter.Fill(dtSaitama)

                '実行結果
                For rowindex As Integer = 0 To dtSaitama.Rows.Count - 1
                    For colindex As Integer = 0 To dtSaitama.Columns.Count - 1
                        If colindex = 1 Then
                            県名表示ラベル.Text = dtSaitama.Rows(rowindex).Item(colindex).ToString

                        ElseIf colindex = 2 Then
                            市区町村名表示ラベル.Text = dtSaitama.Rows(rowindex).Item(colindex).ToString

                        ElseIf colindex = 3 Then
                            地区名表示ラベル.Text = dtSaitama.Rows(rowindex).Item(colindex).ToString
                            If 地区名表示ラベル.Text = "" Then
                                地区名表示ラベル.Text = "該当なし"
                            End If
                        End If
                    Next
                Next
                If 県名表示ラベル.Text = "" Or 市区町村名表示ラベル.Text = "" Then
                    MessageBox.Show("該当する住所が見つかりませんでした。郵便番号を確認してください。")
                    Exit Sub
                End If

            Catch ex As Exception
                Throw
            Finally
                sqlconn.Close()
            End Try
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    '履歴データの追加
    Private Sub InsertData()
        Dim intMaxID As Integer
        Dim strPref1 As String = ""
        Dim strCity1 As String = ""
        Dim strArea1 As String = ""
        Dim strZipCode As String = ""

        strZipCode = TextBox1.Text
        strPref1 = 県名表示ラベル.Text
        strCity1 = 市区町村名表示ラベル.Text
        strArea1 = 地区名表示ラベル.Text

        Try
            'SQLServerの接続開始
            Dim sqlconn As New SqlConnection(My.Settings.sqlServer)
            sqlconn.Open()
            Try
                'SQL作成
                Dim sql As New System.Text.StringBuilder
                sql.AppendLine(" SELECT COUNT(*)")
                sql.AppendLine(" FROM Rireki")

                'SQL実行
                Dim command As New SqlCommand(sql.ToString, sqlconn)
                Dim adapter As New SqlDataAdapter(command)
                Dim dtRireki As New DataTable
                adapter.Fill(dtRireki)

                '履歴テーブルの全行数を取得
                intMaxID = dtRireki.Rows(0).Item(0).ToString
                intMaxID += 1
            Catch ex As Exception
                Throw
            Finally
                sqlconn.Close()
            End Try

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        ''SQL作成
        'Dim sql1 As New System.Text.StringBuilder
        'sql1.AppendLine("INSERT INTO Rireki( ")
        'sql1.AppendLine("  Id ")
        'sql1.AppendLine("  ,郵便番号 ")
        'sql1.AppendLine("  ,都道府県名 ")
        'sql1.AppendLine("  ,市区町村名 ")
        'sql1.AppendLine("  ,地区名")
        'sql1.AppendLine("  ) VALUES( ")
        'sql1.AppendLine("  'intMaxID' ")
        'sql1.AppendLine("  ,'strZipCode' ")
        'sql1.AppendLine("  ,strPref1 = 県名表示ラベル.Text ")
        'sql1.AppendLine("  ,'strCity1' ")
        'sql1.AppendLine("  ,'aaaaaa'")
        'sql1.AppendLine("  )")


        Try
            'SQLServerの接続開始
            Dim sqlconn As New SqlConnection(My.Settings.sqlServer)
            sqlconn.Open()

            Try
                Dim Sql_Insert1 As String = ""

                Sql_Insert1 &= ""
                Sql_Insert1 &= "INSERT INTO Rireki("
                Sql_Insert1 &= "Id "
                Sql_Insert1 &= " ,郵便番号 "
                Sql_Insert1 &= " ,都道府県名 "
                Sql_Insert1 &= " ,市区町村名 "
                Sql_Insert1 &= " ,地区名 "
                Sql_Insert1 &= " )"
                Sql_Insert1 &= " VALUES( "
                Sql_Insert1 &= "'" & intMaxID & "'"
                Sql_Insert1 &= " ,'" & strZipCode & "'"
                Sql_Insert1 &= " ,'" & strPref1 & "'"
                Sql_Insert1 &= " ,'" & strCity1 & "'"
                Sql_Insert1 &= " ,'" & strArea1 & "'"
                Sql_Insert1 &= " )"

                'SQLコマンド設定
                Dim command As New SqlCommand(Sql_Insert1, sqlconn)
                command.Connection = sqlconn
                command.ExecuteNonQuery()

            Catch ex As Exception
                Throw
            Finally
                sqlconn.Close()
            End Try

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    'リストボックスに履歴データを格納
    Private Sub DispListBox()

        Dim yuubin1 As String = ""
        Dim Prefe1 As String = ""
        Dim City1 As String = ""
        Dim Area1 As String = ""
        Dim TotalList As String = ""

        Try
            'SQLServerの接続開始
            Dim sqlconn As New SqlConnection(My.Settings.sqlServer)
            sqlconn.Open()
            Try
                'SQL作成
                Dim sql As New System.Text.StringBuilder
                sql.AppendLine(" SELECT *")
                sql.AppendLine(" FROM Rireki")

                'SQL実行
                Dim command As New SqlCommand(sql.ToString, sqlconn)
                Dim adapter As New SqlDataAdapter(command)
                Dim dtRireki As New DataTable
                adapter.Fill(dtRireki)

                '実行結果
                For rowindex As Integer = 0 To dtRireki.Rows.Count - 1
                    For colindex As Integer = 0 To dtRireki.Columns.Count - 1
                        If colindex = 1 Then
                            yuubin1 = dtRireki.Rows(rowindex).Item(colindex).ToString

                        ElseIf colindex = 2 Then
                            Prefe1 = dtRireki.Rows(rowindex).Item(colindex).ToString

                        ElseIf colindex = 3 Then
                            City1 = dtRireki.Rows(rowindex).Item(colindex).ToString

                        ElseIf colindex = 4 Then
                            Area1 = dtRireki.Rows(rowindex).Item(colindex).ToString
                        End If
                    Next

                    'ListBoxに値を格納
                    TotalList = " " & yuubin1 & " " & Prefe1 & " " & City1 & " " & Area1
                    ListBox1.Items.Add(TotalList)
                Next

            Catch ex As Exception
                Throw
            Finally
                sqlconn.Close()
            End Try
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            'SQLServerの接続開始
            Dim sqlconn As New SqlConnection(My.Settings.sqlServer)
            sqlconn.Open()

            Try
                'SQL作成
                Dim sql1 As New System.Text.StringBuilder
                sql1.AppendLine("TRUNCATE table Rireki")

                'SQLコマンド設定
                Dim command As New SqlCommand(sql1.ToString, sqlconn)
                command.Connection = sqlconn
                command.ExecuteNonQuery()
                'Dim adapter As New SqlDataAdapter(command)
                'Dim dtLog As New DataTable
                'adapter.Fill(dtLog)

            Catch ex As Exception
                Throw
            Finally
                sqlconn.Close()
            End Try
            ListBox1.Items.Clear()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
End Class

