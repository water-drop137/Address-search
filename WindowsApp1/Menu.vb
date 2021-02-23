Public Class Menu
    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call TimeDisp()


    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '住所から郵便番号を検索するフォームを表示
        Form1.ShowDialog()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '郵便番号から検索するフォームを表示
        Form2.ShowDialog()
    End Sub



    Public Sub TimeDisp()
        '年月日の取得
        Dim dNow As DateTime = System.DateTime.Now
        Label3.Text = dNow.ToLongDateString

        '曜日の取得
        Dim week As DayOfWeek = dNow.DayOfWeek
        'int32型にキャスト
        Dim weekNumber As Integer = CInt(dNow.DayOfWeek)
        '省略された曜日名で取得
        Dim strDate1 As String = dNow.ToString("ddd")
        Label7.Text = "(" & strDate1 & ")"

        Dim Time1 As String = dNow.Hour
        Dim Minu1 As String = dNow.Minute


        If Minu1 <= 9 Then
            Label4.Text = Time1 & ":" & "0" & Minu1
        Else
            Label4.Text = Time1 & "時" & Minu1 & "分"
        End If
    End Sub
End Class