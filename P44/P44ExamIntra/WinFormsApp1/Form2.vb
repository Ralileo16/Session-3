Imports System.Runtime.CompilerServices
Imports Microsoft.Data.SqlClient

Public Class FormModifier

    Public cn As SqlConnection
    Private cmdUpdate As SqlCommand
    Public TagTitreNom As String
    Public frmDisco As FormDisco
    Private titre As String
    Private nom As String

    Private Sub FormModifier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OuvrirConnexion()
        InitialiserCommandes()
        titre = Tag.split(":")(0)
        nom = Tag.split(":")(1)
        tbAlbum.Text = titre
    End Sub

    Private Sub OuvrirConnexion()
        Try
            cn = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Discographe;Integrated Security=True;Trust Server Certificate=True; Connection Timeout=3")
            cn.Open()
        Catch sqlEx As SqlException
            MessageBox.Show("Un problème est survenu lors de l'ouveture de la connexion au serveur de base de données:: " & sqlEx.Number & ":: " & sqlEx.Message)
            Environment.Exit(0)
        Catch ex As Exception
            MessageBox.Show("Un problème est survenu lors de l'ouveture de la connexion au serveur de base de données:: " & ex.Message)
            Environment.Exit(0)
        End Try
    End Sub

    Private Sub InitialiserCommandes()
        cmdUpdate = New SqlCommand("UPDATE Album " &
                           "SET Titre = @TitreNew " &
                           "WHERE ID IN ( " &
                           "SELECT a.ID " &
                           "FROM Album a " &
                           "INNER JOIN FK_Album_Artiste faa ON a.ID = faa.FK_Album_ID " &
                           "INNER JOIN Artiste ar ON faa.FK_Artiste_ID = ar.ID " &
                           "WHERE ar.Nom = @Nom AND  a.Titre = @Titre)", cn)
        cmdUpdate.Parameters.AddRange(New SqlParameter() {
            New SqlParameter("@Titre", SqlDbType.VarChar),
            New SqlParameter("@Nom", SqlDbType.VarChar),
            New SqlParameter("@TitreNew", SqlDbType.VarChar)
        })
    End Sub

    Private Sub ButtonOK_Click(sender As Object, e As EventArgs) Handles ButtonOK.Click
        cmdUpdate.Parameters.Item("@Titre").Value = titre
        cmdUpdate.Parameters.Item("@Nom").Value = nom
        cmdUpdate.Parameters.Item("@TitreNew").Value = tbAlbum.Text
        MessageBox.Show(cmdUpdate.ExecuteNonQuery() & " enregistrement affectés avec succès")
        frmDisco.RemplirListView()
        Me.Close()
    End Sub

    Private Sub ButtonAnnuler_Click(sender As Object, e As EventArgs) Handles ButtonAnnuler.Click
        Me.Close()
    End Sub
End Class