Public Class frm_ajouterrdv
    Private Sub frm_ajouterrdv_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_ajouter_Click(sender As Object, e As EventArgs) Handles btn_ajouter.Click
        Dim r As rendezvous
        r.codepatien = txt_code2.Text
        r.dadtrdv = txt_datrdv.Text
        r.heurerdv = txt_heure.Text
        If ajouter_rdv(r) Then
            MessageBox.Show("RDV ajouter")
        Else
            MessageBox.Show("le rdv existe deja")
        End If
        txt_code2.Clear()
        txt_datrdv.Clear()
        txt_heure.Clear()
    End Sub



    Private Sub btn_reset_Click(sender As Object, e As EventArgs) Handles btn_reset.Click
        txt_code2.Clear()
        txt_datrdv.Clear()
        txt_heure.Clear()

    End Sub

    Private Sub btn_Annuler_Click(sender As Object, e As EventArgs) Handles btn_Annuler.Click
        If effacer_rdv(txt_code2.Text) Then
            MessageBox.Show("rdv supprimer")
        Else
            MessageBox.Show("rdv nexiste pas")

        End If
        txt_code2.Clear()
        txt_datrdv.Clear()
        txt_heure.Clear()
    End Sub
End Class