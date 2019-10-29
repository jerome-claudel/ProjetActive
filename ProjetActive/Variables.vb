Imports System.Data.SqlClient
Module Variables
    Public str_Nom As String = ""
    Public myConn As SqlConnection      'Connexion à la base de données
    Public myCmd As SqlCommand          'Commande SQL
    Public myReader As SqlDataReader    'Lire le résultat d'un requête SQL
    Public machainedeconnexion = "Initial Catalog=ProjetActive;Data Source=PC-CDA04\SQLEXPRESS;Integrated Security=SSPI;"
    Public adapt As New SqlDataAdapter ' variable pour utiliser le DataGridView
    Public adapt2 As New SqlDataAdapter
    Public dt As New DataTable          'Variable datatable pour l'import des données vers le data Grid view
    Public dt2 As New DataTable
    Public connexion As New Connexion_DB
    Public atableau(,) As String
    Public b_test_Boucle_maj_ville As Boolean


End Module



