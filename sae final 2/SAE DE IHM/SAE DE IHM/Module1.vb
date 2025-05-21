Module modScore

    Public scores As New List(Of String)

    Public Sub AjouterScore(nom As String, paires As Integer, temps As Integer)
        Dim nouveauScore As String = nom & " - Paires trouvées : " & paires & " - Temps : " & temps & "s"
        scores.Add(nouveauScore)
    End Sub

End Module
