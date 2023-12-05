Public Class Form1
    Private Sub AffichepatientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AffichepatientToolStripMenuItem.Click
        frm_afficherpatient.Show()
    End Sub

    Private Sub AjoutpatientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjoutpatientToolStripMenuItem.Click
        frm_ajoutpatient.MdiParent = Me
        frm_ajoutpatient.Show()

    End Sub

    Private Sub CodepatientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CodepatientToolStripMenuItem.Click
        frm_ajouterrdv.MdiParent = Me
        frm_ajouterrdv.Show()

    End Sub

    Private Sub DateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DateToolStripMenuItem.Click
        frm_afficherrdv.Show()
    End Sub
End Class
