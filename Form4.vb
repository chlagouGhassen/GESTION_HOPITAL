Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_valider_Click(sender As Object, e As EventArgs) Handles btn_valider.Click
        Dim login As String
        Dim pw As String
        login = txt_utilisateur.Text
        pw = txt_mdp.Text
        If (login = "admin") And (pw = "1234") Then
            Me.Hide()
            Form1.Show()

        Else
            txt_utilisateur.Clear()
            txt_mdp.Clear()
        End If
    End Sub

    Private Sub btn_annuler_Click(sender As Object, e As EventArgs) Handles btn_annuler.Click
        Me.Hide()

    End Sub
End Class