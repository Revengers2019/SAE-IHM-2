Public Class frmThemes

    Private themeSelectionne As String = ""

    Private Sub btnCinema_Click(sender As Object, e As EventArgs) Handles btnCinema.Click
        themeSelectionne = "Cinema"
        PictureBox1.Image = Image.FromFile("Images\Cine.jpg")
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub btnFastFood_Click(sender As Object, e As EventArgs) Handles btnOptions.Click
        themeSelectionne = "FastFood"
        PictureBox1.Image = Image.FromFile("Images2\Fast.jpg")
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub btnQuitter_Click(sender As Object, e As EventArgs) Handles btnQuitter.Click
        Me.Close()
    End Sub

    Private Sub btnJouer_Click(sender As Object, e As EventArgs) Handles btnJouer.Click
        If themeSelectionne = "" Then
            MessageBox.Show("Veuillez sélectionner un thème avant de jouer.", "Thème manquant", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        frmJeu.ThemeSelectionne = themeSelectionne
        frmJeu.Show()
        Me.Hide()
    End Sub

    Private Sub frmThemes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
