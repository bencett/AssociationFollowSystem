Public Class Form3
    Private Sub btnEkle_Click(sender As Object, e As EventArgs) Handles btnEkle.Click
        If txtAdi.Text = "" Or txtSoyadi.Text = "" Or txtSehir.Text = "" Or txtUyeno.Text = "" Or txtTelefon.Text = "" Or txtBitis.Text = "" Then
            Or txtSehir.Text = "" Or txtUnvan.Text = "" Or txtAidat.Text = "" Or txtPosta.Text = "" Then
            MsgBox("Lütfen Tüm Alanları Doldurunuz!", MsgBoxStyle.Critical, "Hata")
            Return
        End If
        dgKayit.Rows.Add(txtAdi.Text, txtSoyadi.Text, txtSehir.Text, txtUyeno.Text, txtTelefon.Text, txtBitis.Text, txtAidat.Text, txtUnvan.Text,
        txtSehir.Text, txtPosta.Text)
        dgBilgi.Rows.Add(txtAdi.Text, txtSoyadi.Text, txtSehir.Text, txtUyeno.Text, txtTelefon.Text, txtBitis.Text, txtAidat.Text, txtUnvan.Text)
        txtAdi.Clear()
        txtSoyadi.Clear()
        txtSehir.Clear()
        txtUyeno.Clear()
        txtTelefon.Clear()
        txtBitis.Clear()
        txtUnvan.Clear()
        txtAidat.Clear()
        txtPosta.Clear()
    End Sub

    Private Sub Phsphene_Button1_Click(sender As Object, e As EventArgs) Handles btnCikis.Click
        Application.Exit()
    End Sub

    Private Sub dgKayit_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgKayit.CellContentClick

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class