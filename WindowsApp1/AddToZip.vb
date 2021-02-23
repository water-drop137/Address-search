Imports System.Data.SqlClient

Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = ""
        Label2.Text = ""
        Label4.Text = ""
        ComboBox1.Text = ""
        ComboBox1.Items.Clear()
        ComboBox3.Items.Clear()
        ComboBox2.Items.Clear()

        ComboBox1.Items.Add("埼玉県")
        ComboBox1.Items.Add("東京都")

        Call TimeDisp()
    End Sub

    Public Sub TimeDisp()
        '年月日の取得
        Dim dNow As DateTime = System.DateTime.Now
        Label12.Text = dNow.ToLongDateString

        '曜日の取得
        Dim week As DayOfWeek = dNow.DayOfWeek
        'int32型にキャスト
        Dim weekNumber As Integer = CInt(dNow.DayOfWeek)
        '省略された曜日名で取得
        Dim strDate1 As String = dNow.ToString("ddd")
        Label9.Text = "(" & strDate1 & ")"

        Dim Time1 As String = dNow.Hour
        Dim Minu1 As String = dNow.Minute


        If Minu1 <= 9 Then
            Label10.Text = Time1 & ":" & "0" & Minu1
        Else
            Label10.Text = Time1 & "時" & Minu1 & "分"
        End If



        If Time1 < 11 And weekNumber <= 6 Then
            Label14.Text = "11:07"
        ElseIf Time1 <= 15 And weekNumber <= 6 Then
            Label14.Text = "15:07"
        ElseIf Time1 <= 16 And weekNumber <= 6 Then
            Label14.Text = "16:53"
        ElseIf Time1 >= 17 Then
            Label13.Text = "本日の取集は終了しました。"
            Label14.Text = ""
            Label15.Text = ""
        End If

        If Time1 <= 11 And weekNumber = 7 Then
            Label14.Text = "11:57"
        ElseIf Time1 <= 15 And weekNumber = 7 Then
            Label14.Text = "15:27"
        ElseIf Time1 >= 16 Then
            Label13.Text = "本日の取集は終了しました。"
            Label14.Text = ""
            Label16.Text = ""
        End If
    End Sub

    '市区町村名を取得し、CBに格納

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.Leave

        Dim strPrefectureName As String = ""
        Dim strCityName As String = ""
        Dim strKaburi As String = ""

        '都道府県名、市町村名、地区名を保持
        strPrefectureName = ComboBox1.Text

        Try

            'SQLServerの接続開始
            Dim sqlconn As New SqlConnection(My.Settings.sqlServer)
            sqlconn.Open()

            Try

                'SQL作成
                Dim sql As New System.Text.StringBuilder
                sql.AppendLine("SELECT ")
                sql.AppendLine(" 市町村名 ")
                sql.AppendLine("FROM 住所データ1 ")
                sql.AppendLine("WHERE 都道府県名 = '" & strPrefectureName & "'")

                'SQL実行
                Dim command As New SqlCommand(sql.ToString, sqlconn)
                Dim adapter As New SqlDataAdapter(command)
                Dim dtCityNameS As New DataTable
                adapter.Fill(dtCityNameS)

                ComboBox3.Text = ""
                ComboBox3.Items.Clear()

                '実行結果をコンボボックスに格納
                For i As Integer = 0 To dtCityNameS.Rows.Count - 1
                    strCityName = dtCityNameS.Rows(i).Item(0).ToString

                    If strKaburi = strCityName Then

                    Else
                        ComboBox3.Items.Add(strCityName)
                        strKaburi = strCityName
                    End If
                Next

                If dtCityNameS.Rows.Count = 0 Then
                    MessageBox.Show("都道府県名を選択してください。")

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

    '地区名をCBに格納
    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.Leave

        Dim strPrefectureName As String = ""
        Dim strCityName As String = ""
        Dim strDestrictName As String = ""
        '都道府県名、市町村名、地区名を保持
        strPrefectureName = ComboBox1.Text
        strCityName = ComboBox3.Text

        Try

            'SQLServerの接続開始
            Dim sqlconn As New SqlConnection(My.Settings.sqlServer)
            sqlconn.Open()

            Try

                'SQL作成
                Dim sql As New System.Text.StringBuilder
                sql.AppendLine("SELECT ")
                sql.AppendLine("  地区名 ")
                sql.AppendLine("FROM 住所データ1 ")
                sql.AppendLine("WHERE 都道府県名 = '" & strPrefectureName & "'")
                sql.AppendLine(" AND 市町村名 = '" & strCityName & "'")

                'SQL実行
                Dim command As New SqlCommand(sql.ToString, sqlconn)
                Dim adapter As New SqlDataAdapter(command)
                Dim dtDestrictNames As New DataTable
                adapter.Fill(dtDestrictNames)

                ComboBox2.Text = ""
                ComboBox2.Items.Clear()

                '実行結果をコンボボックスに格納
                For i As Integer = 0 To dtDestrictNames.Rows.Count - 1
                    strDestrictName = dtDestrictNames.Rows(i).Item(0).ToString
                    If strDestrictName = "以下に掲載がない場合" Then
                        strDestrictName = ""
                    Else
                        ComboBox2.Items.Add(strDestrictName)
                    End If
                Next

                '地区名が0の場合
                If ComboBox3.Text = "" And ComboBox2.Text = "" Then
                    MessageBox.Show("都道府県名と市町村名を選択してください。")
                    Exit Sub
                ElseIf dtDestrictNames.Rows.Count = 0 And strPrefectureName <> "" Then
                    MessageBox.Show("都道府県名と市町村名を確認してください。")
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

    '検索ボタン押下時

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim strPrefectureName As String = ""
        Dim strCityName As String = ""
        Dim strDestrictName As String = ""

        '都道府県名、市町村名、地区名を保持
        strPrefectureName = ComboBox1.Text
        strCityName = ComboBox3.Text
        strDestrictName = ComboBox2.Text

        Try

            'SQLServerの接続開始
            Dim sqlconn As New SqlConnection(My.Settings.sqlServer)
            sqlconn.Open()

            Try

                'SQL作成
                Dim sql As New System.Text.StringBuilder
                sql.AppendLine("SELECT ")
                sql.AppendLine("  郵便番号 ")
                sql.AppendLine("FROM 住所データ1 ")
                sql.AppendLine("WHERE 都道府県名 = '" & strPrefectureName & "'")
                sql.AppendLine(" AND 市町村名 = '" & strCityName & "'")
                sql.AppendLine(" AND 地区名 = '" & strDestrictName & "'")

                'SQL実行
                Dim command As New SqlCommand(sql.ToString, sqlconn)
                Dim adapter As New SqlDataAdapter(command)
                Dim dtZipCodeS As New DataTable
                adapter.Fill(dtZipCodeS)

                If dtZipCodeS.Rows.Count = 0 Then
                    MessageBox.Show("一致する郵便番号が見つかりませんでした。入力事項を確認してください。")
                    Label2.Text = ""
                    Label1.Text = ""
                    Label4.Text = ""

                    '市区町村名が未選択の場合、地区名をオールクリア
                    If ComboBox3.Text = "" Then
                        ComboBox2.Text = ""
                        ComboBox2.Items.Clear()
                    End If

                    Exit Sub

                End If

                '実行結果
                Label2.Text = dtZipCodeS.Rows(0).Item(0).ToString
                Label1.Text = "お調べの郵便番号は"
                Label4.Text = "です。"

            Catch ex As Exception
                Throw
            Finally
                sqlconn.Close()
            End Try

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    '市区町村名CB
    Private Sub ComboBox3_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox3.Click

        ComboBox3.DroppedDown = True

    End Sub

    '地区名CB
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.Click

        ComboBox2.DroppedDown = True
        If ComboBox1.Text = "" Then
            MessageBox.Show("都道府県名と市町村名を選択してください。")
        ElseIf ComboBox3.Text = "" Then
            MessageBox.Show("市町村名を選択してください。")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()


        ComboBox3.Items.Clear()
        ComboBox2.Items.Clear()

    End Sub
End Class