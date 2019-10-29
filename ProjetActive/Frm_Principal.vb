Imports ProjetActive.Connexion_DB

Public Class Frm_Principal
    'Fenêtre de connexion à l'application
    Private Sub Btn_Connexion_Click(sender As Object, e As EventArgs) Handles Btn_Connexion.Click
        'Procédure de connexion à la base de données avec login et mot de passe
        connexion.OUVRIR_CONNEXION("PS_JC_Acces_DB")
        Do While myReader.Read()     'On balaye tous les résultats de la requête
            'Si le login et le mot de passe sont bons, on se connecte à l'application
            If (myReader.GetString(2) = Txt_Login.Text And myReader.GetString(3) = Txt_Password.Text) Then
                str_Nom = "Bienvenue " + Txt_Login.Text
                Me.Hide()
                Frm_Accueil.Show()
            End If
        Loop
        connexion.FERMER_CONNEXION()
    End Sub
End Class
