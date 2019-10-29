Imports System.Data.SqlClient

Public Class Frm_Collaborateurs
    'Variables pour le click de la DataGridView
    Dim str_Matricule As Integer
    Private Sub Generation_Liste_Noms()
        'procédure qui génére la liste des noms des collaborateurs depuis la base de données
        connexion.OUVRIR_CONNEXION("PS_JC_Nom_Collaborateur")
        Do While myReader.Read()
            Cbx_Nom.Items.Add(myReader.GetString(0))
        Loop
        connexion.FERMER_CONNEXION()
    End Sub
    Private Sub Maj_Consultation()
        'Mise en forme des controls pour le formulaire collaborateurs en mode consultation
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Btn_Valider.Visible = False
        Btn_Annuler.Visible = False
        'On met les valeurs de control de saisie à vide 
        For Each control In GBx_1.Controls
            If TypeOf control Is Label Then
            Else
                control.Enabled = False
                If TypeOf control Is ComboBox Or TypeOf control Is TextBox Then
                    control.text = ""
                End If
            End If
        Next
        For Each control In GBx_Contrat.Controls
            If TypeOf control Is Label Then
            Else
                control.Enabled = False
                If TypeOf control Is ComboBox Or TypeOf control Is TextBox Then
                    control.text = ""
                End If
            End If
        Next
        For Each control In GBx_Genre.Controls
            If TypeOf control Is Label Then
            Else
                control.Enabled = False
            End If
        Next

        Btn_Rechercher_Nom.Enabled = True
        LstB_Prenoms.Enabled = True
        Cbx_Nom.Enabled = True
        GBx_Genre.Enabled = True
        Txt_Matricule.Enabled = False
        'Cbx_Nom.Items.Clear()
        Call Generation_Liste_Noms()

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        'appel de la fonction Maj_Consultation
        Maj_Consultation()
    End Sub
    Private Sub Cbx_Nom_SelectedIndexChanged(sender As Object, e As EventArgs)
        Btn_Rechercher_Nom.Visible = True
    End Sub
    Private Sub Btn_Rechercher_Nom_Click(sender As Object, e As EventArgs)
        Dim i_Nb_Nom As Integer = 0
        'Recherche le nom du collaborateur dans la base de données et rempli tous les champs correspondants
        connexion.OUVRIR_CONNEXION("PS_JC_Compte_Nombre_Nom", "@NomCollabo", Cbx_Nom.Text)
        Do While myReader.Read()
            i_Nb_Nom = myReader.GetValue(1)
        Loop
        connexion.FERMER_CONNEXION()
        Dim aTableauNomParam() As String = {"@NomCollabo"}
        Dim aTableauValParam() As String = {Cbx_Nom.Text}
        Dim aTableauParam(aTableauNomParam.Length, 2) As String
        aTableauParam(0, 0) = aTableauNomParam(0)
        aTableauParam(0, 1) = aTableauValParam(0)

        connexion.OUVRIR_CONNEXION("PS_JC_Recherche_Collaborateur", aTableauParam)
        'Si il n'y a qu'une seule fois le nom on lance la màj des champs
        If i_Nb_Nom = 1 Then
            Remplir_Champs_Collabo()
            connexion.FERMER_CONNEXION()
        Else
            LstB_Prenoms.Items.Clear()
            ' Sinon on séléctionne la bonne personne
            Do While myReader.Read()
                LstB_Prenoms.Items.Add(myReader.GetString(6))
                LstB_Prenoms.Visible = True
                Cbx_Nom.Enabled = False
            Loop
            connexion.FERMER_CONNEXION()
        End If

        'On regénére la liste des noms du combobox nom
        Call Generation_Liste_Noms()
        Btn_Modification.Visible = True
    End Sub
    Private Sub Remplir_Champs_Collabo()
        'Procédure qui remplit les champs du formulaire collaborateur en fonction 
        'du retour de la requête
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Do While myReader.Read()
            Cbx_Nom.Text = myReader.GetString(5)
            Txt_Prenom.Text = myReader.GetString(6)
            Txt_Telephone.Text = myReader.GetString(9)
            Txt_Email.Text = myReader.GetString(10)
            Dtp_DateEmbauche.Value = myReader.GetDateTime(7)
            Txt_Matricule.Text = myReader.GetValue(0)

            If myReader.GetValue(14) = 2 Then
                RdB_M.Checked = True
                'RdB_F.Checked = False
            ElseIf myReader.GetValue(14) = 1 Then
                RdB_F.Checked = True
                'RdB_M.Checked = False
            ElseIf myReader.GetValue(15) = 3 Then
                RdB_F.Checked = False
                RdB_M.Checked = False
            End If
            Txt_Salaire.Text = Math.Round(myReader.GetDecimal(13), 2) & " €"
            If IsDBNull(myReader.GetValue(8)) Then
                Dtp_DateFinContrat.Visible = False
            Else
                Dtp_DateFinContrat.Visible = True
                Lbl_DateFinContrat.Visible = True
                Dtp_DateFinContrat.Value = myReader.GetDateTime(8)
            End If
            Txt_Numero.Text = myReader.GetString(21)
            Txt_NomVoie.Text = myReader.GetString(20)
            Cbx_Ville.Text = myReader.GetString(24)
            Cbx_Fonction.Text = myReader.GetString(27)
            Cbx_Statut.Text = myReader.GetString(29)
            If myReader.GetValue(25) < 10000 Then
                Cbx_CodePostal.Text = "0" & myReader.GetValue(25)
            Else
                Cbx_CodePostal.Text = myReader.GetValue(25)
            End If
        Loop
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
        'Met à jour les champs en fonction du prénom cliqué dans la listBox
        Dim aTableauParam(2, 2) As String
        aTableauParam(0, 0) = "@NomCollabo"
        aTableauParam(0, 1) = Cbx_Nom.Text
        aTableauParam(1, 0) = "@PrenomCollabo"
        aTableauParam(1, 1) = LstB_Prenoms.SelectedItem
        connexion.OUVRIR_CONNEXION("PS_JC_Recherche_Collabo_Nom_Prenom", aTableauParam)
        Remplir_Champs_Collabo()
        connexion.FERMER_CONNEXION()
        LstB_Prenoms.Visible = False
        Cbx_Nom.Enabled = True
    End Sub
    Private Sub Btn_Creation_Click(sender As Object, e As EventArgs)
        'selection et mise en forme du formulaire collaborateurs pour la création
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'Mise en forme des boutons 
        Btn_Fiche_Collabo.Enabled = False
        Btn_Liste.Enabled = True

        Liberer_controles()
        For Each Control In Me.GBx_1.Controls
            Control.Enabled = True
            If TypeOf Control Is ComboBox Or TypeOf Control Is TextBox Then
                Control.text = ""
            End If
        Next Control
        For Each Control In Me.GBx_Contrat.Controls
            Control.Enabled = True
            If TypeOf Control Is ComboBox Or TypeOf Control Is TextBox Then
                Control.text = ""
            End If
        Next Control
        For Each Control In Me.GBx_Genre.Controls
            Control.Enabled = True
            Control.Checked = False
        Next Control
        Dtp_DateFinContrat.Visible = True
        Cbx_CodePostal.Enabled = False
        Txt_Matricule.Enabled = False
        Txt_Email.Enabled = False
        Btn_Valider.Visible = True
        Btn_Valider.Text = "Valider"
        Btn_Annuler.Visible = True

        'Selection du formulaire collaborateur
        TabCtrl_Collabo.SelectedTab = TabP_Collaborateur

    End Sub
    Private Sub Liberer_controles()
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ''''Met à jour les controles de saisie des champs du formulaire collaborateur
        ''''pour permettre la saisie et/ou la modification
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        'Mise à jour du combobox avec la liste de villes
        Cbx_Nom.Items.Clear()
        connexion.OUVRIR_CONNEXION("PS_JC_Liste_Nom_Ville")
        Do While myReader.Read()
            Cbx_Ville.Items.Add(myReader.GetString(0))
        Loop
        connexion.FERMER_CONNEXION()
        'Mise à jour du combobox avec la liste de codes postaux
        connexion.OUVRIR_CONNEXION("PS_JC_Recherche_CP")
        Do While myReader.Read()
            Cbx_CodePostal.Items.Add(myReader.GetValue(0))
        Loop
        connexion.FERMER_CONNEXION()
        'Mise à jour du combobox avec la liste des statuts
        connexion.OUVRIR_CONNEXION("PS_JC_Liste_Statut")
        Do While myReader.Read()
            Cbx_Statut.Items.Add(myReader.GetString(0))
        Loop
        connexion.FERMER_CONNEXION()
        'Mise à jour du combobox avec la liste des fonctions
        connexion.OUVRIR_CONNEXION("PS_JC_Liste_Fonctions")
        Do While myReader.Read()
            Cbx_Fonction.Items.Add(myReader.GetString(0))
        Loop
        connexion.FERMER_CONNEXION()



    End Sub
    Private Sub Btn_Valider_Click(sender As Object, e As EventArgs)
        'Valide la création ou la modification d'un collaborateur

        Dim char_Sexe As String = "M"
        Dim Test_insertion As Boolean = True
        Dim str_message As String = ""
        Dim str_login As String
        If RdB_M.Checked = True Then
            char_Sexe = "H"
        ElseIf RdB_F.Checked = True Then
            char_Sexe = "F"
        Else
            char_Sexe = "I"
        End If
        'Création de l'adresse mail avec le nom et le prénom
        Dim str_nom_email As String
        Dim char_lettre_prenom As String = Txt_Prenom.Text.Substring(0, 1)
        Dim i_nb_Email As Integer = 0
        'on compte le nombre d'adresse mail avec le meme nom et la meme premier lettre du prenom
        connexion.OUVRIR_CONNEXION("PS_JC_NOMBRE_EMAIL", "@nom_str", Cbx_Nom.Text, "@lettre_prenom_str", char_lettre_prenom)
        Do While myReader.Read()
            i_nb_Email = myReader.GetValue(1)
        Loop
        connexion.FERMER_CONNEXION()
        'on créé l'adresse mail en fonction du nombre d'adresses déjà existante
        If i_nb_Email = 0 Then
            str_login = LCase(Txt_Prenom.Text.Substring(0, 1).Trim & "." & Cbx_Nom.Text.Trim)
            str_nom_email = str_login & "@active.bzh"
        Else
            str_login = LCase(Txt_Prenom.Text.Substring(0, 1).Trim & "." & Cbx_Nom.Text.Trim & i_nb_Email + 1)
            str_nom_email = str_login & "@active.bzh"
        End If
        Txt_Email.Text = str_nom_email

        'Si on est en mode création on lance l'INSERT avec le bouton "valider" si on est en mode modification on lance l'UPDATE avec le bouton "modifier"
        If Btn_Valider.Text = "Valider" Then
            If Txt_Salaire.Text = "" Then Txt_Salaire.Text = 0.00
            'Définition d'un tableau avec le nom des paramètres
            Dim aTableauNomParam() As String = {"@sexe_str", "@adresse_str", "@statut_str", "@fonction_str", "@nom_str", "@prenom_str", "@numero_int", "@ville_str", "@telephone", "@email", "@salaire", "@dateemabauche"}
            'Définition d'un tableau avec la valeur des paramètres
            Dim aTableauValParam() As String = {char_Sexe, Txt_NomVoie.Text, Cbx_Statut.Text, Cbx_Fonction.Text, Cbx_Nom.Text, Txt_Prenom.Text, Txt_Numero.Text, Cbx_Ville.Text, Txt_Telephone.Text, str_nom_email, Txt_Salaire.Text, Dtp_DateEmbauche.Value}
            'Définition du tableau à 2 dimensions avec les noms des paramètres et leur valeur
            Dim aTableauparam(aTableauNomParam.Length, 2) As String
            'TEST la position du radioButton est renvoie le caractère correspondant au sexe

            'Test si les champs obligatoires sont renseignés ou non et renvoie la valeur false dans la variable test_insertion 
            'si ce n'est pas le cas
            If Cbx_Nom.Text = "" Then
                Test_insertion = False
                str_message += "        " & "Nom" & vbCrLf
            End If
            If Txt_Prenom.Text = "" Then
                Test_insertion = False
                str_message += "        " & "Prénom" & vbCrLf
            End If
            If Cbx_Ville.Text = "" Then
                Test_insertion = False
                str_message += "        " & "Ville" & vbCrLf
            End If
            If Cbx_Statut.Text = "" Then
                Test_insertion = False
                str_message += "        " & "Statut" & vbCrLf
            End If
            If Cbx_Fonction.Text = "" Then
                Test_insertion = False
                str_message += "        " & "Fonction" & vbCrLf
            End If
            If Txt_Salaire.Text = "" Then Txt_Salaire.Text = 0.00

            If Test_insertion = True Then
                'Si tous les champs obligatoires ont été renseignés, on insert les deonnées dans la base
                'Définition d'un tableau avec le nom des paramètres
                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

                For index = 0 To 11
                    aTableauparam(index, 0) = aTableauNomParam(index)
                    aTableauparam(index, 1) = aTableauValParam(index)
                Next
                connexion.OUVRIR_CONNEXION("PS_JC_INSERT_COLLABORATEUR", aTableauparam)
                connexion.FERMER_CONNEXION()

                MsgBox("Création", MsgBoxStyle.Information, "Collaborateur créé")
                Btn_Valider.Visible = False
                Btn_Annuler.Visible = False
            Else
                'sinon on affiche un message d'erreur
                MsgBox("Veuillez renseigner les champs obligatoire suivants :" & vbCrLf & str_message, MsgBoxStyle.Exclamation, "Champs manquants")
            End If
            'Création des droits d'accès à la base de donnée pour le collaborateur créé
            Dim i_droits As Integer = 2
            connexion.OUVRIR_CONNEXION("PS_JC_CREATION_DROITS_ACCES", "@droit_int", i_droits, "@login_str", str_login)
            connexion.FERMER_CONNEXION()

        ElseIf Btn_Valider.Text = "Modifier" Then

            Dim aTableauNomParam2() As String = {"@numero", "@ville_str", "@adresse_str", "fonction_str", "@statut_str", "sexe_str", "@collaborateur_id", "@nom_str", "@prenom_str", "@numero_int", "@telephone", "@email", "@salaire", "@dateemabauche"}
            'Définition d'un tableau avec la valeur des paramètres
            Dim aTableauValParam2() As String = {Txt_Numero.Text, Cbx_Ville.Text, Txt_NomVoie.Text, Cbx_Fonction.Text, Cbx_Statut.Text, char_Sexe, Txt_Matricule.Text, Cbx_Nom.Text, Txt_Prenom.Text, Txt_Numero.Text, Txt_Telephone.Text, Txt_Email.Text, CDbl(Txt_Salaire.Text), Dtp_DateEmbauche.Value}
            'Définition du tableau à 2 dimensions avec les noms des paramètres et leur valeur
            Dim aTableauparam2(aTableauNomParam2.Length, 2) As String
            For index = 0 To aTableauNomParam2.Length - 1
                aTableauparam2(index, 0) = aTableauNomParam2(index)
                aTableauparam2(index, 1) = aTableauValParam2(index)
            Next

            connexion.OUVRIR_CONNEXION("PS_JC_UPDATE_Collaborateur", aTableauparam2)
            connexion.FERMER_CONNEXION()

        End If
    End Sub
    Private Sub Cbx_Ville_Validated(sender As Object, e As EventArgs)
        'mise à jour de la liste des villes dans le combobox ville
        connexion.OUVRIR_CONNEXION("PS_JC_RECUPERE_CP_VILLE", "@NomVille", Cbx_Ville.Text)
        Do While myReader.Read()
            Cbx_CodePostal.Text = myReader.GetValue(0)
        Loop
        connexion.FERMER_CONNEXION()
    End Sub
    Private Sub DGV_copie(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        'Clique sur datagridview
        ''''''''''''''''''''''''''''''
        Maj_Consultation()
        'Renvoie la valeur de la première cellule de la ligne cliquée soit le matricule du collaborateur
        If Me.DGV_Collabo.CurrentCell.Value <> Nothing Then
            str_Matricule = DGV_Collabo(0, DGV_Collabo.CurrentCell.RowIndex).Value 'Récupére le numéro de matricule de la ligne cliquée
            'bascule sur la page collaborateur
            TabCtrl_Collabo.SelectedTab = TabP_Collaborateur
            Btn_Fiche_Collabo.Enabled = False
            Btn_Liste.Enabled = True
            Btn_Fiche_Collabo.BackColor = Color.White
            Btn_Liste.BackColor = Color.FromArgb(255, 0, 192, 192)
            Btn_Liste.FlatAppearance.BorderColor = Color.FromArgb(255, 0, 192, 192)
            Btn_Fiche_Collabo.BackColor = Color.White
            Btn_Fiche_Collabo.FlatAppearance.BorderColor = Color.White

            'et mise à jour des champs du collaborateur
            connexion.OUVRIR_CONNEXION("PS_JC_Recherche_COLLABORATEUR_par_Matricule", "@matricule_id", str_Matricule)
            Remplir_Champs_Collabo()
            connexion.FERMER_CONNEXION()
        End If
        Btn_Modification.Visible = True


    End Sub
    Private Sub Btn_Fiche_Collabo_Click(sender As Object, e As EventArgs)
        'bascule vers le formulaire fiche collaborateur et mise en forme des boutons 
        TabCtrl_Collabo.SelectedTab = TabP_Collaborateur
        Btn_Fiche_Collabo.Enabled = False
        Btn_Fiche_Collabo.BackColor = Color.White
        Btn_Liste.FlatAppearance.BorderColor = Color.FromArgb(255, 0, 192, 192)
        Btn_Fiche_Collabo.FlatAppearance.BorderColor = Color.White
        Btn_Liste.Enabled = True
        Btn_Liste.BackColor = Color.FromArgb(255, 0, 192, 192)
        Btn_Liste.ForeColor = Color.White

    End Sub
    Private Sub Btn_Liste_Click(sender As Object, e As EventArgs)
        'Click sur le bouton Liste
        '''''''''''''''''''''''''''''''''''''
        'bascule vers le formulaire liste et mise en forme des boutons 
        Btn_Fiche_Collabo.Enabled = True
        Btn_Fiche_Collabo.BackColor = Color.FromArgb(255, 0, 192, 192)
        Btn_Fiche_Collabo.ForeColor = Color.White
        Btn_Liste.Enabled = False
        Btn_Liste.BackColor = Color.White
        Btn_Liste.FlatAppearance.BorderColor = Color.White
        Btn_Fiche_Collabo.FlatAppearance.BorderColor = Color.FromArgb(255, 0, 192, 192)
        TabCtrl_Collabo.SelectedTab = TabP_ListeCollabo

    End Sub
    Private Sub Frm_Collaborateurs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Chargement de la fenetre collaborateurs et création de la Datagrid view sur l'onglet liste
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'Mise en forme des boutons au lancement de la fenetre Collaborateurs
        Btn_Fiche_Collabo.Enabled = False

        connexion.OUVRIR_CONNEXION_DGV("PS_JC_INFOS_COLLABORATEURS")
        ' définition d'une table recueillant le résulatat de la Procédure Sockée
        adapt = New SqlDataAdapter(myCmd)      'on créée un nouvel objet sqlDataAdapter
        adapt.Fill(dt)                         'ajoute des lignes dans la dataTable
        'ma table dt est la source de la DATAGRID
        DGV_Collabo.DataSource = dt
        'On instancie 
        Dim objBuilder As New SqlCommandBuilder(adapt)
        connexion.FERMER_CONNEXION()
        'On redimensionne les colonnes de la datagridview
        DGV_Collabo.Columns.Item(0).Width = 50
        DGV_Collabo.Columns.Item(1).Width = 190
        DGV_Collabo.Columns.Item(2).Width = 190
        DGV_Collabo.Columns.Item(3).Width = 280
        DGV_Collabo.Columns.Item(4).Width = 51

    End Sub
    Private Sub DGV_Collabo_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
    Private Sub Btn_Filtrer_Click(sender As Object, e As EventArgs)
        'Lance le filtrage du datagridview en fonction du paramètre rentré
        DGV_Collabo.DataSource = ""

        dt2.Clear()
        dt.Clear()
        connexion.OUVRIR_CONNEXION_DGV("PS_JC_RECHERCHE_COLLABORATEUR_PAR_NOM", "@Nom", Txt_Filtre.Text)
        'définition d'une table recueillant le résulatat de la Procédure Sockée
        'on créée un nouvel objet sqlDataAdapter
        adapt = New SqlDataAdapter(myCmd)

        adapt.Fill(dt2) 'ajoute des lignes dans la dataTable
        'ma table dt est la source de la DATAGRID
        DGV_Collabo.DataSource = dt2
        'On instancie 
        Dim objBuilder As New SqlCommandBuilder(adapt2)
        connexion.FERMER_CONNEXION()
        DGV_Collabo.Columns.Item(0).Width = 50
        DGV_Collabo.Columns.Item(1).Width = 190
        DGV_Collabo.Columns.Item(2).Width = 190
        DGV_Collabo.Columns.Item(3).Width = 280
        DGV_Collabo.Columns.Item(4).Width = 51


    End Sub

    Private Sub Btn_Modification_Click(sender As Object, e As EventArgs)
        'Mets en forme les controles quand click sur le bouton modifier
        Liberer_controles()
        Btn_Valider.Text = "Modifier"
        For Each Control In Me.GBx_1.Controls
            Control.Enabled = True
        Next Control
        For Each Control In Me.GBx_Contrat.Controls
            Control.Enabled = True
        Next Control
        For Each Control In Me.GBx_Genre.Controls
            Control.Enabled = True

        Next Control
        Dtp_DateFinContrat.Visible = True
        Cbx_CodePostal.Enabled = False
        Txt_Matricule.Enabled = False
        Txt_Email.Enabled = False
        Btn_Valider.Visible = True
        Btn_Annuler.Visible = True

        'Selection du formulaire collaborateur
        TabCtrl_Collabo.SelectedTab = TabP_Collaborateur

    End Sub
    Private Sub ProcéduresStockéesToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        Frm_Administrateur.Show()
    End Sub
End Class