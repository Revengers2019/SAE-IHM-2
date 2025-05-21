Public Class frmJeu
    Private tempsRestant As Integer = 60
    Private WithEvents pauseTimer As Timer = New Timer()
    Private estActif As Boolean = True

    Private aleatoire As New Random()
    Private cartesDevoilees As New Dictionary(Of PictureBox, String)()
    Private cartesRetournees As New List(Of PictureBox)()
    Private valeurChaineActuelle As String = ""
    Private compteChaine As Integer = 0
    Private nbPairesTrouvees As Integer = 0

    Private indicesUtilises As Integer = 0
    Private dureeIndice As Integer = 1000
    Private boutonsIndice As New List(Of PictureBox)()
    Public ThemeSelectionne As String
    Private liensImages As New List(Of String)

    Private Sub frmJeu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ThemeSelectionne = "Cinema" Then
            liensImages = New List(Of String) From {
                "Images\buster.jpg", "Images\star.jpg", "Images\Marvel.jpg", "Images\DC.jpg", "Images\WB.jpg"
            }
        ElseIf ThemeSelectionne = "FastFood" Then
            liensImages = New List(Of String) From {
                "Images2\bk.jpg", "Images2\domi.jpg", "Images2\hut.jpg", "Images2\pepe.jpg", "Images2\kfc.jpg"
            }
        Else
            MessageBox.Show("Erreur : Aucun thème n'a été défini.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            frmThemes.Show()
            Exit Sub
        End If

        Timer1.Interval = 1000
        Timer1.Start()
        lblTemps.Text = tempsRestant.ToString()
        lblNom.Text = frmAccueil.tbNom.Text

        Dim valeurs As New List(Of String)
        For Each lien In liensImages
            For j = 1 To 4
                valeurs.Add(lien)
            Next
        Next

        Dim pictureBoxes As New List(Of PictureBox) From {
            PictureBox1, PictureBox2, PictureBox3, PictureBox4, PictureBox5,
            PictureBox6, PictureBox7, PictureBox8, PictureBox9, PictureBox10,
            PictureBox11, PictureBox12, PictureBox13, PictureBox14, PictureBox15,
            PictureBox16, PictureBox17, PictureBox18, PictureBox19, PictureBox20
        }

        For Each pictureBox In pictureBoxes
            Dim index As Integer = aleatoire.Next(valeurs.Count)
            cartesDevoilees.Add(pictureBox, valeurs(index))
            valeurs.RemoveAt(index)
            pictureBox.BackgroundImage = Image.FromFile("Images\Cer.jpg")
            pictureBox.BackgroundImageLayout = ImageLayout.Stretch
            pictureBox.Image = Nothing
            AddHandler pictureBox.Click, AddressOf Clic_Carte
        Next
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If tempsRestant > 0 Then
            tempsRestant -= 1
            lblTemps.Text = tempsRestant.ToString()
        Else
            Timer1.Stop()
            lblTemps.Text = "0"

            Dim tempsUtilise As Integer = If(nbPairesTrouvees = 5, 60 - 0, 60)

            MessageBox.Show("Temps écoulé ! Paires trouvées : " & nbPairesTrouvees, "Fin", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Dim scoreForm As New frmScores()
            scoreForm.AjouterScore(frmAccueil.tbNom.Text, nbPairesTrouvees, tempsUtilise)
            scoreForm.ShowDialog()

            Me.Close()
            frmAccueil.Show()
        End If
    End Sub

    Private Sub PauseTimer_Tick(sender As Object, e As EventArgs) Handles pauseTimer.Tick
        pauseTimer.Stop()
        If boutonsIndice.Count > 0 Then
            For Each pictureBox In boutonsIndice
                pictureBox.Image = Nothing
            Next
            boutonsIndice.Clear()
        Else
            For Each pictureBox In cartesRetournees
                pictureBox.Image = Nothing
            Next
            cartesRetournees.Clear()
            compteChaine = 0
            valeurChaineActuelle = ""
        End If
        For Each pictureBox In cartesDevoilees.Keys
            If pictureBox.Image Is Nothing Then
                pictureBox.Enabled = True
            End If
        Next
        If estActif Then
            Timer1.Start()
        End If
    End Sub

    Private Sub Clic_Carte(sender As Object, e As EventArgs)
        Dim pictureBox As PictureBox = CType(sender, PictureBox)
        If Not pictureBox.Enabled OrElse cartesRetournees.Contains(pictureBox) Then Exit Sub

        pictureBox.Image = Image.FromStream(New System.Net.WebClient().OpenRead(cartesDevoilees(pictureBox)))
        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage
        cartesRetournees.Add(pictureBox)

        If compteChaine = 0 Then
            valeurChaineActuelle = cartesDevoilees(pictureBox)
            compteChaine = 1
        ElseIf cartesDevoilees(pictureBox) = valeurChaineActuelle Then
            compteChaine += 1
            If compteChaine = 4 Then
                For Each p In cartesRetournees
                    p.Enabled = False
                Next
                cartesRetournees.Clear()
                compteChaine = 0
                valeurChaineActuelle = ""
                nbPairesTrouvees += 1
                VerifierFinPartie()
            End If
        Else
            For Each p In cartesDevoilees.Keys
                p.Enabled = False
            Next
            pauseTimer.Interval = 50
            pauseTimer.Start()
        End If
    End Sub

    Private Sub btnPause_Click(sender As Object, e As EventArgs) Handles btnPause.Click
        If estActif Then
            btnPause.Text = "Reprendre"
            estActif = False
            Timer1.Stop()
            For Each pictureBox In cartesDevoilees.Keys
                pictureBox.Enabled = False
            Next
        Else
            btnPause.Text = "Pause"
            estActif = True
            Timer1.Start()
            For Each pictureBox In cartesDevoilees.Keys
                If pictureBox.Image Is Nothing Then
                    pictureBox.Enabled = True
                End If
            Next
        End If
    End Sub

    Private Sub btnAbandonner_Click(sender As Object, e As EventArgs) Handles btnAbandonner.Click
        If MsgBox("Veux-tu abandonner ?", vbYesNo) = vbYes Then
            Me.Close()
            frmAccueil.Show()
            Timer1.Stop()
        End If
    End Sub

    Private Sub btnIndice_Click_1(sender As Object, e As EventArgs) Handles btnIndice.Click
        If cartesRetournees.Count > 0 Then
            MsgBox("Termine ton coup avant l'indice.", MsgBoxStyle.Exclamation, "Indice")
            Exit Sub
        End If

        If indicesUtilises >= 3 Then
            MsgBox("Tous les indices sont utilisés.", MsgBoxStyle.Exclamation, "Indice")
            Exit Sub
        End If

        Dim pictureBoxesActifs = cartesDevoilees.Keys.Where(Function(p) p.Enabled).ToList()
        If pictureBoxesActifs.Count < 4 Then
            MsgBox("Pas assez de cartes libres.", MsgBoxStyle.Exclamation, "Indice")
            Exit Sub
        End If

        Dim pictureBoxesAleatoires = pictureBoxesActifs.OrderBy(Function(p) aleatoire.Next()).Take(4).ToList()
        indicesUtilises += 1

        For Each p In cartesDevoilees.Keys
            p.Enabled = False
        Next

        For Each p In pictureBoxesAleatoires
            p.Image = Image.FromStream(New System.Net.WebClient().OpenRead(cartesDevoilees(p)))
            p.SizeMode = PictureBoxSizeMode.StretchImage
            boutonsIndice.Add(p)
        Next

        Timer1.Stop()
        pauseTimer.Interval = dureeIndice
        pauseTimer.Start()
    End Sub

    Private Sub VerifierFinPartie()
        If tempsRestant <= 0 OrElse nbPairesTrouvees = 5 Then
            Timer1.Stop()
            Dim tempsUtilise As Integer = 60 - tempsRestant
            Dim scoreForm As New frmScores()
            scoreForm.AjouterScore(frmAccueil.tbNom.Text, nbPairesTrouvees, tempsUtilise)
            scoreForm.ShowDialog()
            Me.Close()
            frmAccueil.Show()
        End If
    End Sub

    Private Sub lblTemps_Click(sender As Object, e As EventArgs) Handles lblTemps.Click

    End Sub
End Class
