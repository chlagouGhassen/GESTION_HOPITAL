Public Class form2
    Private Sub btn_valider_Click(sender As Object, e As EventArgs) Handles btn_ajouter.Click
        Dim I As patient
        I.code = txt_code2.Text
        I.nom = txt_datrdv.Text
        I.prenom = txt_heure.Text
        If ajouterpatient(I) Then

            MsgBox("Ajout avec sucess")
        Else
            MsgBox("erreur")

        End If
    End Sub

    Private Sub btn_reset_Click(sender As Object, e As EventArgs) Handles btn_reset.Click
        txt_code2.Clear()
        txt_datrdv.Clear()
        txt_heure.Clear()

    End Sub
End Class