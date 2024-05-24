Imports Microsoft.Data.SqlClient

Public Class FormDisco

    Public cn As SqlConnection
    Private cmdSelectAll As SqlCommand
    Private cmdSelectSingle As SqlCommand
    Private dr As SqlDataReader


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OuvrirConnexion()
        InitialiserCommandes()
        RemplirListView()
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
        cmdSelectAll = New SqlCommand("SELECT Album.Titre, Artiste.Nom " &
                                      "FROM Album " &
                                      "INNER JOIN FK_Album_Artiste ON Album.ID = FK_Album_Artiste.FK_Album_ID " &
                                      "INNER JOIN Artiste ON FK_Album_Artiste.FK_Artiste_ID = Artiste.ID;", cn)

        cmdSelectSingle = New SqlCommand("SELECT Album.Titre, Artiste.Nom " &
                                         "FROM Album " &
                                         "INNER JOIN FK_Album_Artiste ON Album.ID = FK_Album_Artiste.FK_Album_ID " &
                                         "INNER JOIN Artiste ON FK_Album_Artiste.FK_Artiste_ID = Artiste.ID " &
                                         "WHERE Album.Titre = @Titre AND Artiste.Nom = @Nom", cn)
        cmdSelectSingle.Parameters.AddRange(New SqlParameter() {
            New SqlParameter("@Titre", SqlDbType.VarChar),
            New SqlParameter("@Nom", SqlDbType.VarChar)
        })
    End Sub

    Public Sub RemplirListView()
        lvAlbums.Items.Clear()

        Dim lvi As ListViewItem

        Try
            dr = cmdSelectAll.ExecuteReader()

            Do While dr.Read()
                lvi = New ListViewItem(dr("Nom").ToString())
                lvi.SubItems.Add(dr("Titre").ToString())
                lvi.Tag = dr("Titre").ToString() & ":" & dr("Nom").ToString()

                lvAlbums.Items.Add(lvi)
            Loop
        Catch ex As Exception
            MessageBox.Show("Un problème est survenu lors du remplissage du ListView Albums/Artiste:: " & ex.Message)
        Finally
            If Not dr.IsClosed Then
                dr.Close()
            End If
        End Try
    End Sub

    Private Sub lvAlbums_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvAlbums.SelectedIndexChanged
        If lvAlbums.SelectedItems.Count > 0 Then
            Dim tag As String = lvAlbums.SelectedItems(0).Tag
            ChargerAlbumArtisteAuFormulaire(tag.Split(":")(0), tag.Split(":")(1))
        End If
    End Sub

    Private Sub ChargerAlbumArtisteAuFormulaire(titre As String, nom As String)
        cmdSelectSingle.Parameters.Item("@Titre").Value = titre
        cmdSelectSingle.Parameters.Item("@Nom").Value = nom

        Try
            dr = cmdSelectSingle.ExecuteReader()

            If dr.Read() Then
                tbTitre.Text = dr("Titre").ToString()
                tbArtiste.Text = dr("Nom").ToString()
            End If
        Catch ex As Exception
            MessageBox.Show("Un problème est survenu lors de la lecture de l'étudiant:: " & ex.Message)
        Finally
            If Not dr.IsClosed Then
                dr.Close()
            End If
        End Try
    End Sub

    Private Sub btnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        If lvAlbums.SelectedItems.Count > 0 Then
            Dim frm2 = New FormModifier With {
                .Tag = lvAlbums.SelectedItems(0).Tag,
                .frmDisco = Me
            }
            frm2.ShowDialog()

        End If
    End Sub
End Class
