Public Class Form1
    Private Sub Phsphene_Button1_Click(sender As Object, e As EventArgs) Handles btnCikis.Click
        Application.Exit()

    End Sub

    Private Sub btnYonetgiris_Click(sender As Object, e As EventArgs) Handles btnYonetgiris.Click
        If txtYonetgiris.Text = "2" And txtYonetparola.Text = "2" Then
            MsgBox("Hoşgeldiniz!")
            Form3.Show()
            Me.Hide()
        Else
            MsgBox("Kullanıcı Adı veya Parola Geçersiz!",
MsgBoxStyle.Critical, "Hata")
        End If
    End Sub
    Private Sub btnUyegiris_Click_1(sender As Object, e As EventArgs) Handles btnUyegiris.Click
        If txtUyegiris.Text = "1" And txtUyeparola.Text = "1" Then
            MsgBox("Hoşgeldiniz!")
            Form4.Show()
            Me.Hide()
        Else
            MsgBox("Kullanıcı Adı veya Parola Geçersiz!",
MsgBoxStyle.Critical, "Hata")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
