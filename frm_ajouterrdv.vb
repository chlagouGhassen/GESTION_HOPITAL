Public Class frm_ajouterrdv
    Private Sub frm_ajouterrdv_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_ajouter_Click(sender As Object, e As EventArgs) Handles btn_ajouter.Click
        Dim l As patient
        l.code = txt_code2.Text
        l.nom = txt_datrdv.Text
        l.prenom = txt_heure.Text
        If ajouterpatient(l) Then
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

    Private Sub btn_Annuler_Click(sender As Object, e As EventArgs) Handles btn_Annuler.Click
        Me.Hide()

    End Sub
End Class