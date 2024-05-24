Imports Microsoft.Data.SqlClient

Public Class Form2

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

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitialiserConnexion()
        InitialiserCommandes()
        InitialiserDataAdapters()
        InitialiserDataSet()
        InitialiserBindingSources()
        InitialiserDataGridViews()
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
        cmdSelectEquipe = New SqlCommand("SELECT * FROM T_Equipes", cn)
    End Sub

    Private Sub InitialiserDataAdapters()
        JoueurSqlAdapter = New SqlDataAdapter(cmdSelectJoueur)
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

    Private Sub InitialiserDataGridViews()
        dgvEquipes.Columns.AddRange({
            New DataGridViewTextBoxColumn() With {
                .Name = "dvgEquipeNo",
                .HeaderText = "Equipe No.",
                .DataPropertyName = "Equ_no",
                .Visible = True
            },
            New DataGridViewTextBoxColumn() With {
                .Name = "dvgEquipeNom",
                .HeaderText = "Nom",
                .DataPropertyName = "Equ_Nom",
                .Visible = True
            },
            New DataGridViewTextBoxColumn() With {
                .Name = "dvgEquipeVille",
                .HeaderText = "Ville",
                .DataPropertyName = "Equ_Ville",
                .Visible = True
            }
        })

        dgvJoueurs.AutoGenerateColumns = False
        dgvJoueurs.Columns.AddRange({
            New DataGridViewTextBoxColumn() With {
                .Name = "dvgJoueurNo",
                .HeaderText = "Joueur No.",
                .DataPropertyName = "Jou_no",
                .Visible = True
            },
            New DataGridViewTextBoxColumn() With {
                .Name = "dvgJoueurEquNo",
                .HeaderText = "Equipe No.",
                .DataPropertyName = "Equ_no",
                .Visible = True
            },
            New DataGridViewTextBoxColumn() With {
                .Name = "dvgJoueurPrenom",
                .HeaderText = "Prenom",
                .DataPropertyName = "Jou_Prenom",
                .Visible = True
            },
            New DataGridViewTextBoxColumn() With {
                .Name = "dvgJoueurNom",
                .HeaderText = "Nom",
                .DataPropertyName = "Jou_nom",
                .Visible = True
            },
            New DataGridViewTextBoxColumn() With {
                .Name = "dvgJoueurPos",
                .HeaderText = "Position",
                .DataPropertyName = "Jou_Position",
                .Visible = True
            },
            New DataGridViewTextBoxColumn() With {
                .Name = "dvgJoueurButs",
                .HeaderText = "Buts",
                .DataPropertyName = "Jou_Buts",
                .Visible = True
            },
            New DataGridViewTextBoxColumn() With {
                .Name = "dvgJoueurPasses",
                .HeaderText = "Passes",
                .DataPropertyName = "Jou_Passes",
                .Visible = True
            },
            New DataGridViewTextBoxColumn() With {
                .Name = "dvgJoueurTelephone",
                .HeaderText = "Telephone",
                .DataPropertyName = "Jou_Telephone",
                .Visible = True
            }
        })

        dgvEquipes.DataSource = EquipeBindingSource
        dgvJoueurs.DataSource = JoueurBindingSource
    End Sub

    Private Sub dgvEquipes_SelectionChanged(sender As Object, e As EventArgs) Handles dgvEquipes.SelectionChanged
        If IsNotNullOrNewRow() Then
            Dim idEquipe As String = dgvEquipes.SelectedRows(0).Cells(0).Value
            ChargerJoueurs(idEquipe)
        End If
    End Sub

    Private Sub ChargerJoueurs(idEquipe As String)
        JoueurBindingSource.Filter = "[Equ_no] = '" & idEquipe & "'"
    End Sub

    Private Function IsNotNullOrNewRow() As Boolean
        If dgvEquipes.SelectedRows.Count < 1 Then
            Return False
        End If
        Return Not IsDBNull(dgvEquipes.SelectedRows(0).Cells(1).Value) And Not dgvEquipes.SelectedRows(0).IsNewRow
    End Function
End Class