Public Class frm_ajoutpatient
    Private Sub frm_ajoutpatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_Ajouter_Click(sender As Object, e As EventArgs) Handles btn_Ajouter.Click
        Dim l As patient
        l.code = txt_code.text
        l.nom = txt_nom.text
        l.prenom = txt_prenom.Text
        If ajouterpatient(l) Then
            MsgBox("Ajout avec sucess")
        Else
            MsgBox("erreur")

        End If
    End Sub

    Private Sub btn_Annuler_Click(sender As Object, e As EventArgs) Handles btn_Annuler.Click
        Me.Close()

    End Sub

    Private Sub btn_vider_Click(sender As Object, e As EventArgs) Handles btn_vider.Click
        txt_code.Clear()
        txt_nom.Clear()
        txt_prenom.Clear()


    End Sub
End Class