Imports Microsoft.Data.SqlClient

Public Class frmProgramme

    Public cn As SqlConnection

    Private cmdSelectProgrammes As SqlCommand
    Private cmdInsertProgramme As SqlCommand
    Private cmdUpdateProgramme As SqlCommand
    Private cmdDeleteProgramme As SqlCommand
    Private cmdSelectStudents As SqlCommand

    Private ProgrammeSqlAdapter As SqlDataAdapter
    Private StudentSqlAdapter As SqlDataAdapter

    Private ds As DataSet

    Private ProgrammeBindingSource As BindingSource
    Private StudentBindingSource As BindingSource

    Private ErrProv As New ErrorProvider()

    Private Enum DonneeAValider
        No
        Nom
        Unites
        Heures
    End Enum
    Private Sub frmProgramme_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitialiserConnexion()
        InitialiserCommandes()
        InitialiserDataAdapters()
        InitialiserDataSet()
        InitialiserBindingSources()
        InitialiserBindingsControls()
        InitialiserDataGridViews()
    End Sub

    Private Sub InitialiserConnexion()
        Try
            cn = New SqlConnection(My.Settings.cnp44)
        Catch sqlEx As SqlException
            MessageBox.Show("Un problème est survenu lors de l'ouveture de la connexion au serveur de base de données:: " & sqlEx.Number & ":: " & sqlEx.Message)
            Environment.Exit(0)
        Catch ex As Exception
            MessageBox.Show("Un problème est survenu lors de l'ouveture de la connexion au serveur de base de données:: " & ex.Message)
            Environment.Exit(0)
        End Try
    End Sub

    Private Sub InitialiserCommandes()
        cmdSelectProgrammes = New SqlCommand("SELECT * FROM T_programme", cn)

        cmdInsertProgramme = New SqlCommand("INSERT INTO T_programme (pro_no, pro_nom, pro_nbr_unites, pro_nbr_heures) " &
                                            "VALUES (@pro_no, @pro_nom, @pro_nbr_unites, @pro_nbr_heures)", cn)
        cmdInsertProgramme.Parameters.AddRange(New SqlParameter() {
            New SqlParameter("@pro_no", SqlDbType.VarChar, 0, "pro_no"),
            New SqlParameter("@pro_nom", SqlDbType.VarChar, 0, "pro_nom"),
            New SqlParameter("@pro_nbr_unites", SqlDbType.Real, 0, "pro_nbr_unites"),
            New SqlParameter("@pro_nbr_heures", SqlDbType.Int, 0, "pro_nbr_heures")
        })

        cmdUpdateProgramme = New SqlCommand("UPDATE T_programme SET pro_nom = @pro_nom, pro_nbr_unites = @pro_nbr_unites, pro_nbr_heures = @pro_nbr_heures" &
                                            " WHERE pro_no = @pro_no", cn)
        cmdUpdateProgramme.Parameters.AddRange(New SqlParameter() {
            New SqlParameter("@pro_no", SqlDbType.VarChar, 0, "pro_no"),
            New SqlParameter("@pro_nom", SqlDbType.VarChar, 0, "pro_nom"),
            New SqlParameter("@pro_nbr_unites", SqlDbType.Real, 0, "pro_nbr_unites"),
            New SqlParameter("@pro_nbr_heures", SqlDbType.Int, 0, "pro_nbr_heures")
        })

        cmdDeleteProgramme = New SqlCommand("DELETE FROM T_programme " &
                                            "WHERE pro_no = @pro_no", cn)
        cmdDeleteProgramme.Parameters.Add(New SqlParameter("@pro_no", SqlDbType.VarChar, 0, "pro_no"))

        cmdSelectStudents = New SqlCommand("SELECT * FROM T_etudiants", cn)

    End Sub

    Private Sub InitialiserDataAdapters()
        ProgrammeSqlAdapter = New SqlDataAdapter(cmdSelectProgrammes) With {
            .MissingSchemaAction = MissingSchemaAction.AddWithKey,
            .InsertCommand = cmdInsertProgramme,
            .UpdateCommand = cmdUpdateProgramme,
            .DeleteCommand = cmdDeleteProgramme
        }

        StudentSqlAdapter = New SqlDataAdapter(cmdSelectStudents)
    End Sub

    Private Sub InitialiserDataSet()
        ds = New DataSet("tp_p44")

        ProgrammeSqlAdapter.Fill(ds, "T_programme")
        StudentSqlAdapter.Fill(ds, "T_etudiants")
    End Sub

    Private Sub InitialiserBindingSources()
        ProgrammeBindingSource = New BindingSource(ds, "T_programme")
        StudentBindingSource = New BindingSource(ds, "T_etudiants")
    End Sub

    Private Sub InitialiserBindingsControls()
        Try
            tbNo.DataBindings.Add(New Binding("Text", ProgrammeBindingSource, "pro_no", True))
            tbNom.DataBindings.Add(New Binding("Text", ProgrammeBindingSource, "pro_nom", True))
            tbNbrUnit.DataBindings.Add(New Binding("Text", ProgrammeBindingSource, "pro_nbr_unites", True))
            tbNbrHour.DataBindings.Add(New Binding("Text", ProgrammeBindingSource, "pro_nbr_heures", True))
        Catch ex As Exception
            MessageBox.Show("Une erreur est survenue lors de l'initialisation des Bindings sur les Contrôles:: " & ex.Message)
        End Try
    End Sub

    Private Sub InitialiserDataGridViews()
        dgvProgramme.Columns.AddRange({
            New DataGridViewTextBoxColumn() With {
                .Name = "dvgProgrammeNo",
                .HeaderText = "No.",
                .DataPropertyName = "pro_no",
                .Visible = True
            },
            New DataGridViewTextBoxColumn() With {
                .Name = "dvgProgrammeNom",
                .HeaderText = "Nom",
                .DataPropertyName = "pro_nom",
                .Visible = True
            },
            New DataGridViewTextBoxColumn() With {
                .Name = "dvgProgrammeUnit",
                .HeaderText = "Nbr. Unités",
                .DataPropertyName = "pro_nbr_unites",
                .Visible = True
            },
            New DataGridViewTextBoxColumn() With {
                .Name = "dvgProgrammeHeure",
                .HeaderText = "Nbr. Heures",
                .DataPropertyName = "pro_nbr_heures",
                .Visible = True
            }
        })

        dgvStudent.AutoGenerateColumns = False
        dgvStudent.Columns.AddRange({
            New DataGridViewTextBoxColumn() With {
                .Name = "dvgStudentDA",
                .HeaderText = "DA",
                .DataPropertyName = "etu_da",
                .Visible = True
            },
            New DataGridViewTextBoxColumn() With {
                .Name = "dvgStudentProg",
                .HeaderText = "No. Prog",
                .DataPropertyName = "pro_no",
                .Visible = True
            },
            New DataGridViewTextBoxColumn() With {
                .Name = "dvgStudentPrenom",
                .HeaderText = "Prénom",
                .DataPropertyName = "etu_prenom",
                .Visible = True
            },
            New DataGridViewTextBoxColumn() With {
                .Name = "dvgStudentNom",
                .HeaderText = "Nom",
                .DataPropertyName = "etu_nom",
                .Visible = True
            }
        })

        dgvProgramme.DataSource = ProgrammeBindingSource
        dgvStudent.DataSource = StudentBindingSource
    End Sub

    Private Sub dgvProgramme_SelectionChanged(sender As Object, e As EventArgs) Handles dgvProgramme.SelectionChanged
        If IsNotNullOrNewRow() Then
            DebarrerControles(btnEdit, btnDelete)
            Dim idProg As String = dgvProgramme.SelectedRows(0).Cells(0).Value
            ChargerStudents(idProg)
        Else
            BarrerControles(btnEdit, btnDelete)
        End If
    End Sub

    Private Function IsNotNullOrNewRow() As Boolean
        If dgvProgramme.SelectedRows.Count < 1 Then
            Return False
        End If
        Return Not IsDBNull(dgvProgramme.SelectedRows(0).Cells(0).Value) And Not dgvProgramme.SelectedRows(0).IsNewRow
    End Function

    Private Sub ChargerStudents(idProg As String)
        StudentBindingSource.Filter = "[pro_no] = '" & idProg & "'"
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

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        BarrerControles(btnEdit, btnDelete, btnNew, dgvProgramme)
        DebarrerControles(btnConf, btnCancel, tbNbrHour, tbNbrUnit, tbNo, tbNom)
        ProgrammeBindingSource.AddNew()
        tbNo.Focus()
    End Sub

    Private Sub btnConf_Click(sender As Object, e As EventArgs) Handles btnConf.Click
        If Not ValidateChildren() Then
            MessageBox.Show("SVP Valider tous les contrôles du formulaire avant de soumettre vos modifications")
            Return
        End If
        UpdateSource(ds.Tables("T_programme"))
        DebarrerControles(btnNew, dgvProgramme)
        BarrerControles(btnConf, btnCancel, tbNbrHour, tbNbrUnit, tbNo, tbNom, btnDelete, btnEdit)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ErrProv.Clear()
        ProgrammeBindingSource.CancelEdit()
        BarrerControles(btnConf, btnCancel, tbNbrHour, tbNbrUnit, tbNo, tbNom, btnEdit, btnDelete)
        DebarrerControles(btnNew, dgvProgramme)
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        DebarrerControles(tbNbrHour, tbNbrUnit, tbNom, btnCancel, btnConf)
        BarrerControles(btnNew, btnDelete, dgvProgramme)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MessageBox.Show("Voulez-vous vraiment supprimer le programme: " & tbNo.Text, "Supprimer", MessageBoxButtons.OKCancel) = DialogResult.OK Then
            ProgrammeBindingSource.RemoveCurrent()
            UpdateSource(ds.Tables("T_programme"))
        End If
    End Sub

    Private Sub UpdateSource(dataTable As DataTable)
        Select Case dataTable.TableName
            Case "T_programme"
                ProgrammeBindingSource.EndEdit()
                Try
                    ProgrammeSqlAdapter.Update(dataTable)
                Catch ex As Exception
                    MessageBox.Show("Une erreur est survenue lors de la mise à jour de la source de données:: " & ex.Message)
                    ProgrammeBindingSource.CancelEdit()
                    dataTable.RejectChanges()
                End Try
        End Select
    End Sub

    Private Sub MettreEnErreur(valeurEnum As DonneeAValider, controle As Object)
        Dim messageErreur As String = "Erreur"
        Select Case valeurEnum
            Case DonneeAValider.No
                messageErreur = "Numero de programme doit contenir au moins 1 caractère"
            Case DonneeAValider.Nom
                messageErreur = "Nom doit contenir au moins 1 caractère"
            Case DonneeAValider.Unites
                messageErreur = "Unités doit contenir un nombre"
            Case DonneeAValider.Heures
                messageErreur = "Heures doit contenir un nombre"
        End Select

        Select Case True
            Case TypeOf controle Is Control
                ErrProv.SetError(controle, messageErreur)
            Case TypeOf controle Is DataGridViewCell
                Dim cell As DataGridViewCell = DirectCast(controle, DataGridViewCell)
                cell.ErrorText = messageErreur
        End Select
    End Sub

    Private Function IsValideString(str As String) As Boolean
        Dim valide = IIf(String.IsNullOrWhiteSpace(str), False, True)
        Return valide
    End Function

    Private Sub tbNo_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbNo.Validating
        If Not IsValideString(tbNo.Text) Then
            MettreEnErreur(DonneeAValider.No, tbNo)
            e.Cancel = True
        End If
    End Sub

    Private Sub tbNo_Validated(sender As Object, e As EventArgs) Handles tbNo.Validated
        ErrProv.SetError(tbNo, String.Empty)
    End Sub

    Private Sub tbNom_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbNom.Validating
        If Not IsValideString(tbNom.Text) Then
            MettreEnErreur(DonneeAValider.Nom, tbNom)
            e.Cancel = True
        End If
    End Sub

    Private Sub tbNom_Validated(sender As Object, e As EventArgs) Handles tbNom.Validated
        ErrProv.SetError(tbNom, String.Empty)
    End Sub

    Private Sub tbNbrUnit_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbNbrUnit.Validating
        Dim o As Double = Nothing

        If Not IsValideString(tbNbrUnit.Text) Or Not Double.TryParse(tbNbrUnit.Text, o) Then
            MettreEnErreur(DonneeAValider.Unites, tbNbrUnit)
            e.Cancel = True
        End If
    End Sub

    Private Sub tbNbrUnit_Validated(sender As Object, e As EventArgs) Handles tbNbrUnit.Validated
        ErrProv.SetError(tbNbrUnit, String.Empty)
    End Sub

    Private Sub tbNbrHour_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbNbrHour.Validating
        Dim o As Double = Nothing

        If Not IsValideString(tbNbrHour.Text) Or Not Double.TryParse(tbNbrHour.Text, o) Then
            MettreEnErreur(DonneeAValider.Heures, tbNbrHour)
            e.Cancel = True
        End If
    End Sub

    Private Sub tbNbrHour_Validated(sender As Object, e As EventArgs) Handles tbNbrHour.Validated
        ErrProv.SetError(tbNbrHour, String.Empty)
    End Sub
End Class