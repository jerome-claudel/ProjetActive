Imports System.Data.SqlClient
Public Class Connexion_DB
    Public Overloads Sub OUVRIR_CONNEXION(NomProcedure As String)
        '''''''''''''''''''''''''''''''''''''''''''''''''''''
        'Procédure sans paramètre pour la fonction stockée
        '''''''''''''''''''''''''''''''''''''''''''''''''''''
        'Ouvre une connexion avec un nom de procédure stockée en paramètre
        myConn = New SqlConnection(machainedeconnexion)  ' Création d'un nouvelle connexion
        myCmd = myConn.CreateCommand     'Création d'un objet commande 
        myCmd.CommandType = CommandType.StoredProcedure
        myCmd.CommandText = NomProcedure
        myConn.Open()    'Ouverture de la connexion
        myReader = myCmd.ExecuteReader()   'On lit le résultat de la requête et on l'affecte dans la variable myReader
    End Sub
    Public Overloads Sub OUVRIR_CONNEXION(NomProcedure As String, Nom_Param1 As String, Val_Param1 As String)
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'Procédures avec 1 paramètre pour la fonction stockée
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'Ouvre une connexion avec un nom de procédure stockée en paramètre
        myConn = New SqlConnection(machainedeconnexion)  ' Création d'un nouvelle connexion
        myCmd = myConn.CreateCommand     'Création d'un objet commande 
        myCmd.CommandType = CommandType.StoredProcedure
        Dim Parametre1 As SqlParameter = New SqlParameter(Nom_Param1, SqlDbType.NVarChar)
        Parametre1.Value = Val_Param1
        myCmd = myConn.CreateCommand
        myCmd.CommandType = CommandType.StoredProcedure
        myCmd.CommandText = NomProcedure
        myCmd.Parameters.Add(Parametre1)
        myConn.Open()    'Ouverture de la connexion
        myReader = myCmd.ExecuteReader()   'On lit le résultat de la requête et on l'affecte dans la variable myReader
    End Sub
    Public Overloads Sub OUVRIR_CONNEXION(NomProcedure As String, Nom_Param1 As String, Val_Param1 As String, Nom_Param2 As String, Val_Param2 As String)
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'Procédures avec 1 paramètre pour la fonction stockée
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'Ouvre une connexion avec un nom de procédure stockée en paramètre
        myConn = New SqlConnection(machainedeconnexion)  ' Création d'un nouvelle connexion
        Dim Parametre1 As SqlParameter = New SqlParameter(Nom_Param1, SqlDbType.NVarChar)
        Dim Parametre2 As SqlParameter = New SqlParameter(Nom_Param2, SqlDbType.NVarChar)
        Parametre1.Value = Val_Param1
        Parametre2.Value = Val_Param2
        myCmd = myConn.CreateCommand     'Création d'un objet commande 
        myCmd.CommandType = CommandType.StoredProcedure
        myCmd.CommandText = NomProcedure
        myCmd.Parameters.Add(Parametre1)
        myCmd.Parameters.Add(Parametre2)
        myConn.Open()    'Ouverture de la connexion
        myReader = myCmd.ExecuteReader()   'On lit le résultat de la requête et on l'affecte dans la variable myReader
    End Sub

    Public Overloads Sub OUVRIR_CONNEXION(NomProcedure As String, aTableauParam(,) As String)
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'Procédures avec un tableau en paramètre pour la fonction stockée
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'Ouvre une connexion avec un nom de procédure stockée en paramètre
        myConn = New SqlConnection(machainedeconnexion)  ' Création d'un nouvelle connexion
        myCmd = myConn.CreateCommand     'Création d'un objet commande
        myCmd.CommandType = CommandType.StoredProcedure
        myCmd.CommandText = NomProcedure
        For index = 0 To UBound(aTableauParam, 1) - 1
            Dim Parametre As SqlParameter = New SqlParameter()
            Parametre.ParameterName = aTableauParam(index, 0)
            Parametre.SqlDbType = SqlDbType.NVarChar
            Parametre.Value = aTableauParam(index, 1)
            myCmd.Parameters.Add(Parametre)
        Next
        myConn.Open()    'Ouverture de la connexion
        myReader = myCmd.ExecuteReader()   'On lit le résultat de la requête et on l'affecte dans la variable myReader
    End Sub
    Sub FERMER_CONNEXION()
        myReader.Close()    'Fermeture du résultat de la requête
        myConn.Close()      'Fermeture de la connexion
    End Sub

    Public Overloads Sub OUVRIR_CONNEXION_DGV(NomProcedure As String)
        '''''''''''''''''''''''''''''''''''''''''''''''''''''
        'Procédure sans paramètre pour la fonction stockée
        '''''''''''''''''''''''''''''''''''''''''''''''''''''
        'Ouvre une connexion avec un nom de procédure stockée en paramètre
        myConn = New SqlConnection(machainedeconnexion)  ' Création d'un nouvelle connexion
        myCmd = myConn.CreateCommand     'Création d'un objet commande 
        myCmd.CommandType = CommandType.StoredProcedure
        myCmd.CommandText = NomProcedure
        myConn.Open()    'Ouverture de la connexion
        'myReader = myCmd.ExecuteReader()   'On lit le résultat de la requête et on l'affecte dans la variable myReader
    End Sub

    Public Overloads Sub OUVRIR_CONNEXION_DGV(NomProcedure As String, Nom_Param1 As String, Val_Param1 As String)
        '''''''''''''''''''''''''''''''''''''''''''''''''''''
        'Procédure avec paramètre pour la fonction stockée
        '''''''''''''''''''''''''''''''''''''''''''''''''''''
        'Définition ds paramètres
        Dim Parametre1 As SqlParameter = New SqlParameter(Nom_Param1, SqlDbType.NVarChar)
        Parametre1.Value = Val_Param1
        'Ouvre une connexion avec un nom de procédure stockée en paramètre
        myConn = New SqlConnection(machainedeconnexion)  ' Création d'un nouvelle connexion
        myCmd = myConn.CreateCommand     'Création d'un objet commande 
        myCmd.CommandType = CommandType.StoredProcedure
        myCmd.CommandText = NomProcedure
        myCmd.Parameters.Add(Parametre1)
        myConn.Open()    'Ouverture de la connexion
        'myReader = myCmd.ExecuteReader()   'On lit le résultat de la requête et on l'affecte dans la variable myReader
    End Sub

End Class
