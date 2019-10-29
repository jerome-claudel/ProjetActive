Imports System.Data.SqlClient
Public Class Frm_Administrateur
    Private Sub Frm_Administrateur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Chargement et création de la Datagrid view sur l'onglet liste
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''


        connexion.OUVRIR_CONNEXION_DGV("Sp_stored_procedures")
        ' définition d'une table recueillant le résulatat de la Procédure Sockée
        adapt = New SqlDataAdapter(myCmd)      'on créée un nouvel objet sqlDataAdapter
        adapt.Fill(dt)                         'ajoute des lignes dans la dataTable
        'ma table dt est la source de la DATAGRID
        DGV_Procedures.DataSource = dt
        'On instancie 
        Dim objBuilder As New SqlCommandBuilder(adapt)
        connexion.FERMER_CONNEXION()


    End Sub

    Private Sub DGV_Procedures_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Procedures.CellDoubleClick
        Dim RI As Integer
        Dim CI As Integer
        Dim str_Valeur As String = ""

        ''''''''''''''''''''''''''''''

        'Renvoie la valeur de la première cellule de la ligne cliquée soit le matricule du collaborateur
        'If Me.DGV_Procedures.CurrentCell.Value <> Nothing Then
        '    ' str_Matricule = DGV_Collabo(0, DGV_Collabo.CurrentCell.RowIndex).Value 'Récupére le numéro de matricule de la ligne cliquée
        '    'bascule sur la page collaborateur
        '    'et mise à jour des champs du collaborateur
        '    connexion.OUVRIR_CONNEXION("PS_JC_Recherche_COLLABORATEUR_par_Matricule", "@matricule_id", str_Matricule)
        '    connexion.FERMER_CONNEXION()
        'End If

        If Me.DGV_Procedures.CurrentCell.Value <> Nothing Then
            RI = Me.DGV_Procedures.CurrentCell.RowIndex()
            CI = Me.DGV_Procedures.CurrentCell.ColumnIndex()
            str_Valeur = Me.DGV_Procedures.CurrentCell.Value
        End If
        'Dim message As String = str_Valeur.Split(";", 1)
        'MsgBox(message)





    End Sub
End Class