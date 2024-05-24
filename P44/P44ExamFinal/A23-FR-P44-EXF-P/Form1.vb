Imports Microsoft.Data.SqlClient

Public Class Form1

    Public cn As SqlConnection

    Private cmdSelectJoueur As SqlCommand
    Private cmdInsertJoueur As SqlCommand
    Private cmdUpdateJoueur As SqlCommand
    Private cmdDeleteJoueur As SqlCommand
    Private cmdSelectEquipe As SqlCommand

    Private JoueurSqlAdapter As SqlDataAdapter
    Private EquipeSqlAdapter As SqlDataAdapter

    Private ds As DataSet

    Private JoueurBindingSource As BindingSource
    Private EquipeBindingSource As BindingSource

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitialiserConnexion()
        InitialiserCommandes()
        InitialiserDataAdapters()
        InitialiserDataSet()
        InitialiserBindingSources()
        InitialiserBindingsControls()
        CalculerPoints()
    End Sub

    Private Sub InitialiserConnexion()
        Try
            cn = New SqlConnection(My.Settings.connection)
        Catch sqlEx As SqlException
            MessageBox.Show("Un problème est survenu lors de l'ouveture de la connexion au serveur de base de données:: " & sqlEx.Number & ":: " & sqlEx.Message)
            Environment.Exit(0)
        Catch ex As Exception
            MessageBox.Show("Un problème est survenu lors de l'ouveture de la connexion au serveur de base de données:: " & ex.Message)
            Environment.Exit(0)
        End Try
    End Sub

    Private Sub InitialiserCommandes()
        cmdSelectJoueur = New SqlCommand("SELECT * FROM T_Joueurs", cn)

        cmdInsertJoueur = New SqlCommand("INSERT INTO T_Joueurs (Equ_no, Jou_nom, Jou_Prenom, Jou_Position, " &
                                           "Jou_Buts, Jou_Passes, Jou_Telephone) " &
                                           "VALUES (@Equ_No, @Jou_Nom, @Jou_Prenom, @Jou_Position, " &
                                           "@Jou_Buts, @Jou_Passes, @Jou_Telephone)", cn)
        cmdInsertJoueur.Parameters.AddRange(New SqlParameter() {
            New SqlParameter("@Equ_No", SqlDbType.Int, 0, "Equ_no"),
            New SqlParameter("@Jou_Nom", SqlDbType.VarChar, 0, "Jou_nom"),
            New SqlParameter("@Jou_Prenom", SqlDbType.VarChar, 0, "Jou_Prenom"),
            New SqlParameter("@Jou_Position", SqlDbType.Char, 0, "Jou_Position"),
            New SqlParameter("@Jou_Buts", SqlDbType.Int, 0, "Jou_Buts"),
            New SqlParameter("@Jou_Passes", SqlDbType.Int, 0, "Jou_Passes"),
            New SqlParameter("@Jou_Telephone", SqlDbType.VarChar, 0, "Jou_Telephone")
        })

        cmdUpdateJoueur = New SqlCommand("UPDATE T_Joueurs SET Equ_no = @Equ_No, Jou_nom = @Jou_Nom, Jou_Prenom = @Jou_Prenom, " &
                                           "Jou_Position = @Jou_Position, Jou_Buts = @Jou_Buts, Jou_Passes = @Jou_Passes, " &
                                           "Jou_Telephone = @Jou_Telephone " &
                                           "WHERE Jou_no = @Jou_No", cn)
        cmdUpdateJoueur.Parameters.AddRange(New SqlParameter() {
            New SqlParameter("@Jou_No", SqlDbType.Int, 0, "Jou_no"),
            New SqlParameter("@Equ_No", SqlDbType.Int, 0, "Equ_no"),
            New SqlParameter("@Jou_Nom", SqlDbType.VarChar, 0, "Jou_nom"),
            New SqlParameter("@Jou_Prenom", SqlDbType.VarChar, 0, "Jou_Prenom"),
            New SqlParameter("@Jou_Position", SqlDbType.Char, 0, "Jou_Position"),
            New SqlParameter("@Jou_Buts", SqlDbType.Int, 0, "Jou_Buts"),
            New SqlParameter("@Jou_Passes", SqlDbType.Int, 0, "Jou_Passes"),
            New SqlParameter("@Jou_Telephone", SqlDbType.VarChar, 0, "Jou_Telephone")
        })

        cmdDeleteJoueur = New SqlCommand("DELETE FROM T_Joueurs " &
                                            "WHERE Jou_no = @Jou_No", cn)
        cmdDeleteJoueur.Parameters.Add(New SqlParameter("@Jou_No", SqlDbType.Int, 0, "Jou_no"))

        cmdSelectEquipe = New SqlCommand("SELECT * FROM T_Equipes", cn)
    End Sub

    Private Sub InitialiserDataAdapters()
        JoueurSqlAdapter = New SqlDataAdapter(cmdSelectJoueur) With {
            .MissingSchemaAction = MissingSchemaAction.AddWithKey,
            .InsertCommand = cmdInsertJoueur,
            .UpdateCommand = cmdUpdateJoueur,
            .DeleteCommand = cmdDeleteJoueur
        }

        EquipeSqlAdapter = New SqlDataAdapter(cmdSelectEquipe)
    End Sub

    Private Sub InitialiserDataSet()
        ds = New DataSet("Hockey")

        JoueurSqlAdapter.Fill(ds, "T_Joueurs")
        EquipeSqlAdapter.Fill(ds, "T_Equipes")
    End Sub

    Private Sub InitialiserBindingSources()
        JoueurBindingSource = New BindingSource(ds, "T_Joueurs")
        EquipeBindingSource = New BindingSource(ds, "T_Equipes")
    End Sub

    Private Sub InitialiserBindingsControls()
        Try
            tbNo.DataBindings.Add(New Binding("Text", JoueurBindingSource, "Jou_no", True))
            lblNav.DataBindings.Add(New Binding("Text", JoueurBindingSource, "Jou_no", True))
            tbPrenom.DataBindings.Add(New Binding("Text", JoueurBindingSource, "Jou_Prenom", True))
            tbNom.DataBindings.Add(New Binding("Text", JoueurBindingSource, "Jou_nom", True))
            mtbTel.DataBindings.Add(New Binding("Text", JoueurBindingSource, "Jou_Telephone", True))
            nudButs.DataBindings.Add(New Binding("Value", JoueurBindingSource, "Jou_Buts", True))
            nudPasses.DataBindings.Add(New Binding("Value", JoueurBindingSource, "Jou_Passes", True))

            ddEquipe.DisplayMember = "Equ_Nom"
            ddEquipe.ValueMember = "Equ_no"
            ddEquipe.DataSource = EquipeBindingSource
            ddEquipe.DataBindings.Add(New Binding("SelectedValue", JoueurBindingSource, "Equ_no", True))

            ddPosition.DisplayMember = "Jou_Position"
            ddPosition.ValueMember = "Jou_Position"

            Dim distinctPositions = (From row In ds.Tables("T_Joueurs").AsEnumerable()
                                     Select row.Field(Of String)("Jou_Position")).Distinct().ToList()

            Dim distinctPositionsTable As New DataTable()
            distinctPositionsTable.Columns.Add("Jou_Position", GetType(String))

            For Each position In distinctPositions
                distinctPositionsTable.Rows.Add(position)
            Next

            ddPosition.DataSource = distinctPositionsTable
            ddPosition.DataBindings.Add(New Binding("SelectedValue", JoueurBindingSource, "Jou_Position", True))
        Catch ex As Exception
            MessageBox.Show("Une erreur est survenue lors de l'initialisation des Bindings sur les Contrôles:: " & ex.Message)
        End Try
    End Sub

    Private Sub CalculerPoints()
        tbPoints.Text = nudButs.Value + nudPasses.Value
    End Sub

    Private Sub BarrerControles(ParamArray ctrls() As Control)
        For Each ctrl In ctrls
            ctrl.Enabled = False
        Next
    End Sub

    Private Sub DebarrerControles(ParamArray ctrls() As Control)
        For Each ctrl In ctrls
            ctrl.Enabled = True
        Next
    End Sub

    Private Sub btnPremier_Click(sender As Object, e As EventArgs) Handles btnPremier.Click
        JoueurBindingSource.Position = 0
        CalculerPoints()
    End Sub

    Private Sub btnPrecedent_Click(sender As Object, e As EventArgs) Handles btnPrecedent.Click
        JoueurBindingSource.Position -= 1
        CalculerPoints()
    End Sub

    Private Sub btnSuivant_Click(sender As Object, e As EventArgs) Handles btnSuivant.Click
        JoueurBindingSource.Position += 1
        CalculerPoints()
    End Sub

    Private Sub btnDernier_Click(sender As Object, e As EventArgs) Handles btnDernier.Click
        JoueurBindingSource.Position = JoueurBindingSource.Count
        CalculerPoints()
    End Sub

    Private Sub btnEnlever_Click(sender As Object, e As EventArgs) Handles btnEnlever.Click
        If MessageBox.Show("Voulez-vous vraiment supprimer le joueur: " & tbPrenom.Text & " " & tbNom.Text, "Supprimer", MessageBoxButtons.OKCancel) = DialogResult.OK Then
            JoueurBindingSource.RemoveCurrent()
            UpdateSource(ds.Tables("T_Joueurs"))
        End If
    End Sub

    Private Sub UpdateSource(dataTable As DataTable)
        Select Case dataTable.TableName
            Case "T_Joueurs"
                JoueurBindingSource.EndEdit()
                Try
                    JoueurSqlAdapter.Update(dataTable)
                Catch ex As Exception
                    MessageBox.Show("Une erreur est survenue lors de la mise à jour de la source de données:: " & ex.Message)
                    JoueurBindingSource.CancelEdit()
                    dataTable.RejectChanges()
                End Try
        End Select
    End Sub

    Private Sub btnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click
        JoueurBindingSource.AddNew()
        BarrerControles(btnPremier, btnPrecedent, btnSuivant, btnDernier, btnAjouter)
        DebarrerControles(btnEnregistrer, btnAnnuler)
        tbPrenom.Focus()
        nudButs.Value = 0
        nudPasses.Value = 0
        CalculerPoints()
    End Sub

    Private Sub btnEnregistrer_Click(sender As Object, e As EventArgs) Handles btnEnregistrer.Click
        UpdateSource(ds.Tables("T_Joueurs"))
        BarrerControles(btnAnnuler)
        DebarrerControles(btnPremier, btnPrecedent, btnSuivant, btnDernier, btnAjouter)
        MessageBox.Show("Joueur ajouté avec succès ")
    End Sub

    Private Sub btnAnnuler_Click(sender As Object, e As EventArgs) Handles btnAnnuler.Click
        JoueurBindingSource.CancelEdit()
        BarrerControles(btnAnnuler)
        DebarrerControles(btnPremier, btnPrecedent, btnSuivant, btnDernier, btnAjouter)
    End Sub

    Private Sub nudButs_ValueChanged(sender As Object, e As EventArgs) Handles nudButs.ValueChanged
        CalculerPoints()
    End Sub

    Private Sub nudPasses_ValueChanged(sender As Object, e As EventArgs) Handles nudPasses.ValueChanged
        CalculerPoints()
    End Sub

    Private Sub btnListe_Click(sender As Object, e As EventArgs) Handles btnListe.Click
        Dim frm = New Form2()
        frm.Show()
    End Sub
End Class
