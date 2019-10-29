Public Class Frm_Accueil
    Private Sub Accueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = str_Nom
    End Sub

    Private Sub Btn_Employes_Click(sender As Object, e As EventArgs) Handles Btn_Employes.Click
        Me.Hide()
        Frm_Collaborateurs.Show()

    End Sub
    Private Sub ProcéduresStockéesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Frm_Administrateur.Show()
    End Sub
End Class