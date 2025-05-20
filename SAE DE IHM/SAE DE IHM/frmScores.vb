Imports SAE_DE_IHM.frmAccueil

Public Class frmScores

    Private Shared scores As New List(Of String)

    Public Sub AjouterScore(nom As String, paires As Integer, temps As Integer)
        Dim nouveauScore As String = nom & " - Paires trouvées : " & paires & " - Temps : " & temps & "s"
        scores.Add(nouveauScore)
        lstScores.Items.Add(nouveauScore)
    End Sub

    Private Sub frmScores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstScores.Items.Clear()
        For Each s In scores
            lstScores.Items.Add(s)
        Next
    End Sub

    Private Sub btnFermer_Click(sender As Object, e As EventArgs) Handles btnFermer.Click
        Me.Close()
    End Sub

End Class
