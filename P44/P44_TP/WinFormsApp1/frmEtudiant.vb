Imports System.Text.RegularExpressions
Imports Microsoft.Data.SqlClient
Imports Microsoft.IdentityModel.Tokens
Imports Windows.Win32.System

Public Class frmEtudiant

    Public cn As SqlConnection

    Private cmdSelectStudents As SqlCommand
    Private cmdInsertStudent As SqlCommand
    Private cmdUpdateStudent As SqlCommand
    Private cmdDeleteStudent As SqlCommand
    Private cmdSelectProNo As SqlCommand

    Private ProgrammeSqlAdapter As SqlDataAdapter
    Private StudentSqlAdapter As SqlDataAdapter

    Private ds As DataSet

    Private ProgrammeBindingSource As BindingSource
    Private StudentBindingSource As BindingSource

    Private ErrProv As New ErrorProvider()

    Private RegExAddresse As New Regex("^\d+ .*$")
    Private RegExCodePostal As New Regex("^[A-Z]\d[A-Z][-]\d[A-Z]\d$", RegexOptions.IgnoreCase)
    Private RegExTelephone As New Regex("^\(\d{3}\) \d{3}-\d{4}$")

    Private Enum DonneeAValider
        DA
        Prog
        Prenom
        Nom
        Adresse
        Ville
        Province
        CodePostal
        Telephone
    End Enum

    Private Sub frmEtudiant_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        cmdSelectStudents = New SqlCommand("SELECT * FROM T_etudiants", cn)

        cmdInsertStudent = New SqlCommand("INSERT INTO T_etudiants (etu_da, pro_no, etu_nom, etu_prenom, etu_sexe, " &
                                           "etu_adresse, etu_ville, etu_province, etu_telephone, etu_codepostal) " &
                                           "VALUES(@etu_da, @pro_no, @etu_nom, @etu_prenom, @etu_sexe, " &
                                           "@etu_adresse, @etu_ville, @etu_province, @etu_telephone, @etu_codepostal)", cn)
        cmdInsertStudent.Parameters.AddRange(New SqlParameter() {
            New SqlParameter("@etu_da", SqlDbType.VarChar, 0, "etu_da"),
            New SqlParameter("@pro_no", SqlDbType.VarChar, 0, "pro_no"),
            New SqlParameter("@etu_nom", SqlDbType.VarChar, 0, "etu_nom"),
            New SqlParameter("@etu_prenom", SqlDbType.VarChar, 0, "etu_prenom"),
            New SqlParameter("@etu_sexe", SqlDbType.Char, 0, "etu_sexe"),
            New SqlParameter("@etu_adresse", SqlDbType.VarChar, 0, "etu_adresse"),
            New SqlParameter("@etu_ville", SqlDbType.VarChar, 0, "etu_ville"),
            New SqlParameter("@etu_province", SqlDbType.VarChar, 0, "etu_province"),
            New SqlParameter("@etu_telephone", SqlDbType.VarChar, 0, "etu_telephone"),
            New SqlParameter("@etu_codepostal", SqlDbType.VarChar, 0, "etu_codepostal")
        })

        cmdUpdateStudent = New SqlCommand("UPDATE T_etudiants SET pro_no = @pro_no, etu_nom = @etu_nom, etu_prenom = @etu_prenom, " &
                                           "etu_sexe = @etu_sexe, etu_adresse = @etu_adresse, etu_ville = @etu_ville, " &
                                           "etu_province = @etu_province, etu_telephone = @etu_telephone, etu_codepostal = @etu_codepostal " &
                                           "WHERE etu_da = @etu_da", cn)
        cmdUpdateStudent.Parameters.AddRange(New SqlParameter() {
            New SqlParameter("@etu_da", SqlDbType.VarChar, 0, "etu_da"),
            New SqlParameter("@pro_no", SqlDbType.VarChar, 0, "pro_no"),
            New SqlParameter("@etu_nom", SqlDbType.VarChar, 0, "etu_nom"),
            New SqlParameter("@etu_prenom", SqlDbType.VarChar, 0, "etu_prenom"),
            New SqlParameter("@etu_sexe", SqlDbType.Char, 0, "etu_sexe"),
            New SqlParameter("@etu_adresse", SqlDbType.VarChar, 0, "etu_adresse"),
            New SqlParameter("@etu_ville", SqlDbType.VarChar, 0, "etu_ville"),
            New SqlParameter("@etu_province", SqlDbType.VarChar, 0, "etu_province"),
            New SqlParameter("@etu_telephone", SqlDbType.VarChar, 0, "etu_telephone"),
            New SqlParameter("@etu_codepostal", SqlDbType.VarChar, 0, "etu_codepostal")
        })

        cmdDeleteStudent = New SqlCommand("DELETE FROM T_etudiants " &
                                            "WHERE etu_da = @etu_da", cn)
        cmdDeleteStudent.Parameters.Add(New SqlParameter("@etu_da", SqlDbType.VarChar, 0, "etu_da"))

        cmdSelectProNo = New SqlCommand("SELECT DISTINCT(pro_no) FROM T_programme", cn)
    End Sub

    Private Sub InitialiserDataAdapters()
        StudentSqlAdapter = New SqlDataAdapter(cmdSelectStudents) With {
            .MissingSchemaAction = MissingSchemaAction.AddWithKey,
            .InsertCommand = cmdInsertStudent,
            .UpdateCommand = cmdUpdateStudent,
            .DeleteCommand = cmdDeleteStudent
        }

        ProgrammeSqlAdapter = New SqlDataAdapter(cmdSelectProNo)
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
            tbDA.DataBindings.Add(New Binding("Text", StudentBindingSource, "etu_da", True))
            tbFirstName.DataBindings.Add(New Binding("Text", StudentBindingSource, "etu_prenom", True))
            tbLastName.DataBindings.Add(New Binding("Text", StudentBindingSource, "etu_nom", True))
            tbAddr.DataBindings.Add(New Binding("Text", StudentBindingSource, "etu_adresse", True))
            tbCity.DataBindings.Add(New Binding("Text", StudentBindingSource, "etu_ville", True))
            tbState.DataBindings.Add(New Binding("Text", StudentBindingSource, "etu_province", True))
            tbTel.DataBindings.Add(New Binding("Text", StudentBindingSource, "etu_telephone", True))
            tbPostal.DataBindings.Add(New Binding("Text", StudentBindingSource, "etu_codepostal", True))

            tbNoProg.DisplayMember = "pro_no"
            tbNoProg.ValueMember = "pro_no"
            tbNoProg.DataSource = ProgrammeBindingSource
            tbNoProg.DataBindings.Add(New Binding("SelectedValue", StudentBindingSource, "pro_no", True))
        Catch ex As Exception
            MessageBox.Show("Une erreur est survenue lors de l'initialisation des Bindings sur les Contrôles:: " & ex.Message)
        End Try
    End Sub

    Private Sub InitialiserDataGridViews()
        dgvStudent.Columns.AddRange({
            New DataGridViewTextBoxColumn() With {
                .Name = "dvgStudentDA",
                .HeaderText = "DA",
                .DataPropertyName = "etu_da",
                .Width = 55,
                .Visible = True
            },
            New DataGridViewTextBoxColumn() With {
                .Name = "dvgStudentProg",
                .HeaderText = "No. Prog",
                .DataPropertyName = "pro_no",
                .Width = 60,
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
            },
            New DataGridViewTextBoxColumn() With {
                .Name = "dvgStudentSex",
                .HeaderText = "Sexe",
                .DataPropertyName = "etu_sexe",
                .Width = 35,
                .Visible = True
            },
            New DataGridViewTextBoxColumn() With {
                .Name = "dvgStudentAddr",
                .HeaderText = "Adresse",
                .DataPropertyName = "etu_adresse",
                .Visible = True
            },
            New DataGridViewTextBoxColumn() With {
                .Name = "dvgStudentCity",
                .HeaderText = "Ville",
                .DataPropertyName = "etu_ville",
                .Visible = True
            },
            New DataGridViewTextBoxColumn() With {
                .Name = "dvgStudentState",
                .HeaderText = "Province",
                .DataPropertyName = "etu_province",
                .Visible = True
            },
            New DataGridViewTextBoxColumn() With {
                .Name = "dvgStudentTel",
                .HeaderText = "Teléphone",
                .DataPropertyName = "etu_telephone",
                .Visible = True
            },
            New DataGridViewTextBoxColumn() With {
                .Name = "dvgStudentPostal",
                .HeaderText = "Code Postal",
                .DataPropertyName = "etu_codepostal",
                .Visible = True
            }
        })

        dgvStudent.DataSource = StudentBindingSource
    End Sub

    Private Sub dgvProgramme_SelectionChanged(sender As Object, e As EventArgs) Handles dgvStudent.SelectionChanged
        If IsNotNullOrNewRow() Then
            DebarrerControles(btnEdit, btnDelete)
            Dim currentStudent As DataRowView = CType(StudentBindingSource.Current, DataRowView)
            If currentStudent IsNot Nothing Then
                rbMale.Checked = (currentStudent("etu_sexe") = "M")
                rbFem.Checked = (currentStudent("etu_sexe") = "F")
            End If
        Else
            BarrerControles(btnEdit, btnDelete)
        End If
    End Sub

    Private Function IsNotNullOrNewRow() As Boolean
        If dgvStudent.SelectedRows.Count < 1 Then
            Return False
        End If
        Return Not IsDBNull(dgvStudent.SelectedRows(0).Cells(0).Value) And Not dgvStudent.SelectedRows(0).IsNewRow
    End Function

    Private Sub rbMale_CheckedChanged(sender As Object, e As EventArgs) Handles rbMale.CheckedChanged
        If rbMale.Checked Then
            UpdateGenderInDataSource("M")
        End If
    End Sub

    Private Sub rbFem_CheckedChanged(sender As Object, e As EventArgs) Handles rbFem.CheckedChanged
        If rbFem.Checked Then
            UpdateGenderInDataSource("F")
        End If
    End Sub

    Private Sub UpdateGenderInDataSource(gender As String)
        Dim currentStudent As DataRowView = CType(StudentBindingSource.Current, DataRowView)
        If currentStudent IsNot Nothing Then
            currentStudent("etu_sexe") = gender
        End If
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
        DebarrerControles(tbDA, tbNoProg, tbFirstName, tbLastName, tbAddr, tbCity, tbState, tbPostal, tbTel, gbSexe, rbMale, rbFem, btnConf, btnCancel, dgvStudent)
        BarrerControles(btnEdit, btnDelete, btnNew, dgvStudent)
        StudentBindingSource.AddNew()
        tbDA.Focus()
    End Sub

    Private Sub btnConf_Click(sender As Object, e As EventArgs) Handles btnConf.Click
        If Not ValidateChildren() Then
            MessageBox.Show("SVP Valider tous les contrôles du formulaire avant de soumettre vos modifications")
            Return
        End If
        UpdateSource(ds.Tables("T_etudiants"))
        DebarrerControles(btnNew, dgvStudent)
        BarrerControles(tbDA, tbNoProg, tbFirstName, tbLastName, tbAddr, tbCity, tbState, tbPostal, tbTel, gbSexe, rbMale, rbFem, btnConf, btnCancel, btnEdit, btnDelete)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ErrProv.Clear()
        StudentBindingSource.CancelEdit()
        DebarrerControles(btnNew, dgvStudent)
        BarrerControles(tbDA, tbNoProg, tbFirstName, tbLastName, tbAddr, tbCity, tbState, tbPostal, tbTel, gbSexe, rbMale, rbFem, btnConf, btnCancel, btnEdit, btnDelete)
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        DebarrerControles(tbNoProg, tbFirstName, tbLastName, tbAddr, tbCity, tbState, tbPostal, tbTel, gbSexe, rbMale, rbFem, btnConf, btnCancel)
        BarrerControles(btnNew, btnDelete, btnEdit, dgvStudent)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MessageBox.Show("Voulez-vous vraiment supprimer l'étudiant: " & tbDA.Text, "Supprimer", MessageBoxButtons.OKCancel) = DialogResult.OK Then
            StudentBindingSource.RemoveCurrent()
            UpdateSource(ds.Tables("T_etudiants"))
        End If
    End Sub

    Private Sub UpdateSource(dataTable As DataTable)
        Select Case dataTable.TableName
            Case "T_etudiants"
                StudentBindingSource.EndEdit()
                Try
                    StudentSqlAdapter.Update(dataTable)
                Catch ex As Exception
                    MessageBox.Show("Une erreur est survenue lors de la mise à jour de la source de données:: " & ex.Message)
                    StudentBindingSource.CancelEdit()
                    dataTable.RejectChanges()
                End Try
        End Select
    End Sub

    Private Sub MettreEnErreur(valeurEnum As DonneeAValider, controle As Object)
        Dim messageErreur As String = "Erreur"
        Select Case valeurEnum
            Case DonneeAValider.DA
                messageErreur = "DA doit contenir 7 chiffres"
            Case DonneeAValider.Prog
                messageErreur = "Programe ne peut être vide"
            Case DonneeAValider.Prenom
                messageErreur = "Prénom ne peut être vide"
            Case DonneeAValider.Nom
                messageErreur = "Nom ne peut être vide"
            Case DonneeAValider.Adresse
                messageErreur = "Adresse ne peut être vide ou ne respecte pas le format"
            Case DonneeAValider.Ville
                messageErreur = "Ville ne peut être vide"
            Case DonneeAValider.Province
                messageErreur = "Province ne peut être vide"
            Case DonneeAValider.CodePostal
                messageErreur = "Code postal ne peut être vide ou ne respecte pas le format"
            Case DonneeAValider.Telephone
                messageErreur = "Téléphone ne peut être vide ou ne respecte pas le format"
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

    Private Function IsValideAdresse(str As String) As Boolean
        Return IIf(RegExAddresse.IsMatch(str), True, False)
    End Function

    Private Function IsValideCodePostal(str As String) As Boolean
        Return IIf(RegExCodePostal.IsMatch(str), True, False)
    End Function

    Private Function IsValideTelephone(str) As Boolean
        Return IIf(RegExTelephone.IsMatch(str), True, False)
    End Function

    Private Sub tbDA_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbDA.Validating
        Dim o As Integer = Nothing
        If Not IsValideString(tbDA.Text) Or Not tbDA.Text.Length = 7 Or Not Integer.TryParse(tbDA.Text, o) Then
            MettreEnErreur(DonneeAValider.DA, tbDA)
            e.Cancel = True
        End If
    End Sub

    Private Sub tbDA_Validated(sender As Object, e As EventArgs) Handles tbDA.Validated
        ErrProv.SetError(tbDA, String.Empty)
    End Sub

    Private Sub tbNoProg_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbNoProg.Validating
        If Not IsValideString(tbNoProg.Text) Then
            MettreEnErreur(DonneeAValider.Prog, tbNoProg)
            e.Cancel = True
        End If
    End Sub

    Private Sub tbNoProg_Validated(sender As Object, e As EventArgs) Handles tbNoProg.Validated
        ErrProv.SetError(tbNoProg, String.Empty)
    End Sub

    Private Sub tbFirstName_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbFirstName.Validating
        If Not IsValideString(tbFirstName.Text) Then
            MettreEnErreur(DonneeAValider.Prenom, tbFirstName)
            e.Cancel = True
        End If
    End Sub

    Private Sub tbFirstName_Validated(sender As Object, e As EventArgs) Handles tbFirstName.Validated
        ErrProv.SetError(tbFirstName, String.Empty)
    End Sub

    Private Sub tbLastName_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbLastName.Validating
        If Not IsValideString(tbLastName.Text) Then
            MettreEnErreur(DonneeAValider.Nom, tbLastName)
            e.Cancel = True
        End If
    End Sub

    Private Sub tbLastName_Validated(sender As Object, e As EventArgs) Handles tbLastName.Validated
        ErrProv.SetError(tbLastName, String.Empty)
    End Sub

    Private Sub tbAddr_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbAddr.Validating
        If Not IsValideString(tbAddr.Text) Or Not IsValideAdresse(tbAddr.Text) Then
            MettreEnErreur(DonneeAValider.Adresse, tbAddr)
            e.Cancel = True
        End If
    End Sub

    Private Sub tbAddr_Validated(sender As Object, e As EventArgs) Handles tbAddr.Validated
        ErrProv.SetError(tbAddr, String.Empty)
    End Sub

    Private Sub tbCity_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbCity.Validating
        If Not IsValideString(tbCity.Text) Then
            MettreEnErreur(DonneeAValider.Ville, tbCity)
            e.Cancel = True
        End If
    End Sub

    Private Sub tbCity_Validated(sender As Object, e As EventArgs) Handles tbCity.Validated
        ErrProv.SetError(tbCity, String.Empty)
    End Sub

    Private Sub tbState_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbState.Validating
        If Not IsValideString(tbState.Text) Then
            MettreEnErreur(DonneeAValider.Province, tbState)
            e.Cancel = True
        End If
    End Sub

    Private Sub tbState_Validated(sender As Object, e As EventArgs) Handles tbState.Validated
        ErrProv.SetError(tbState, String.Empty)
    End Sub

    Private Sub tbPostal_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbPostal.Validating
        If Not IsValideString(tbPostal.Text) Or Not IsValideCodePostal(tbPostal.Text) Then
            MettreEnErreur(DonneeAValider.CodePostal, tbPostal)
            e.Cancel = True
        End If
    End Sub

    Private Sub tbPostal_Validated(sender As Object, e As EventArgs) Handles tbPostal.Validated
        ErrProv.SetError(tbPostal, String.Empty)
    End Sub

    Private Sub tbTel_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbTel.Validating
        If Not IsValideString(tbTel.Text) Or Not IsValideTelephone(tbPostal.Text) Then
            MettreEnErreur(DonneeAValider.Telephone, tbTel)
            e.Cancel = True
        End If
    End Sub

    Private Sub tbTel_Validated(sender As Object, e As EventArgs) Handles tbTel.Validated
        ErrProv.SetError(tbTel, String.Empty)
    End Sub
End Class