<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEtudiant
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        GroupBox1 = New GroupBox()
        tbTel = New MaskedTextBox()
        Label9 = New Label()
        tbPostal = New TextBox()
        tbState = New TextBox()
        tbCity = New TextBox()
        tbAddr = New TextBox()
        tbLastName = New TextBox()
        gbSexe = New GroupBox()
        rbMale = New RadioButton()
        rbFem = New RadioButton()
        tbFirstName = New TextBox()
        tbNoProg = New ComboBox()
        tbDA = New TextBox()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        btnNew = New Button()
        btnConf = New Button()
        btnCancel = New Button()
        btnEdit = New Button()
        btnDelete = New Button()
        dgvStudent = New DataGridView()
        GroupBox1.SuspendLayout()
        gbSexe.SuspendLayout()
        CType(dgvStudent, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(tbTel)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(tbPostal)
        GroupBox1.Controls.Add(tbState)
        GroupBox1.Controls.Add(tbCity)
        GroupBox1.Controls.Add(tbAddr)
        GroupBox1.Controls.Add(tbLastName)
        GroupBox1.Controls.Add(gbSexe)
        GroupBox1.Controls.Add(tbFirstName)
        GroupBox1.Controls.Add(tbNoProg)
        GroupBox1.Controls.Add(tbDA)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(775, 214)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Étudiant"
        ' 
        ' tbTel
        ' 
        tbTel.Enabled = False
        tbTel.Location = New Point(461, 132)
        tbTel.Mask = "(000) 000-0000"
        tbTel.Name = "tbTel"
        tbTel.Size = New Size(288, 23)
        tbTel.TabIndex = 19
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BorderStyle = BorderStyle.FixedSingle
        Label9.Location = New Point(379, 135)
        Label9.Name = "Label9"
        Label9.Padding = New Padding(0, 0, 12, 0)
        Label9.Size = New Size(75, 17)
        Label9.TabIndex = 17
        Label9.Text = "Téléphone"
        ' 
        ' tbPostal
        ' 
        tbPostal.Enabled = False
        tbPostal.Location = New Point(461, 103)
        tbPostal.Name = "tbPostal"
        tbPostal.PlaceholderText = "___-___"
        tbPostal.Size = New Size(288, 23)
        tbPostal.TabIndex = 16
        ' 
        ' tbState
        ' 
        tbState.Enabled = False
        tbState.Location = New Point(461, 74)
        tbState.Name = "tbState"
        tbState.Size = New Size(288, 23)
        tbState.TabIndex = 15
        ' 
        ' tbCity
        ' 
        tbCity.Enabled = False
        tbCity.Location = New Point(461, 45)
        tbCity.Name = "tbCity"
        tbCity.Size = New Size(288, 23)
        tbCity.TabIndex = 14
        ' 
        ' tbAddr
        ' 
        tbAddr.Enabled = False
        tbAddr.Location = New Point(461, 16)
        tbAddr.Name = "tbAddr"
        tbAddr.Size = New Size(288, 23)
        tbAddr.TabIndex = 13
        ' 
        ' tbLastName
        ' 
        tbLastName.Enabled = False
        tbLastName.Location = New Point(80, 103)
        tbLastName.Name = "tbLastName"
        tbLastName.Size = New Size(271, 23)
        tbLastName.TabIndex = 12
        ' 
        ' gbSexe
        ' 
        gbSexe.Controls.Add(rbMale)
        gbSexe.Controls.Add(rbFem)
        gbSexe.Enabled = False
        gbSexe.Location = New Point(80, 132)
        gbSexe.Name = "gbSexe"
        gbSexe.Size = New Size(94, 76)
        gbSexe.TabIndex = 11
        gbSexe.TabStop = False
        gbSexe.Text = "Sexe"
        ' 
        ' rbMale
        ' 
        rbMale.AutoSize = True
        rbMale.Enabled = False
        rbMale.Location = New Point(6, 47)
        rbMale.Name = "rbMale"
        rbMale.Size = New Size(73, 19)
        rbMale.TabIndex = 1
        rbMale.TabStop = True
        rbMale.Text = "Masculin"
        rbMale.UseVisualStyleBackColor = True
        ' 
        ' rbFem
        ' 
        rbFem.AutoSize = True
        rbFem.Enabled = False
        rbFem.Location = New Point(6, 22)
        rbFem.Name = "rbFem"
        rbFem.Size = New Size(68, 19)
        rbFem.TabIndex = 0
        rbFem.TabStop = True
        rbFem.Text = "Féminin"
        rbFem.UseVisualStyleBackColor = True
        ' 
        ' tbFirstName
        ' 
        tbFirstName.Enabled = False
        tbFirstName.Location = New Point(80, 74)
        tbFirstName.Name = "tbFirstName"
        tbFirstName.Size = New Size(271, 23)
        tbFirstName.TabIndex = 10
        ' 
        ' tbNoProg
        ' 
        tbNoProg.Enabled = False
        tbNoProg.FormattingEnabled = True
        tbNoProg.Location = New Point(80, 45)
        tbNoProg.Name = "tbNoProg"
        tbNoProg.Size = New Size(121, 23)
        tbNoProg.TabIndex = 9
        ' 
        ' tbDA
        ' 
        tbDA.Enabled = False
        tbDA.Location = New Point(80, 16)
        tbDA.Name = "tbDA"
        tbDA.PlaceholderText = "_______"
        tbDA.Size = New Size(121, 23)
        tbDA.TabIndex = 8
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BorderStyle = BorderStyle.FixedSingle
        Label8.Location = New Point(379, 106)
        Label8.Name = "Label8"
        Label8.Size = New Size(75, 17)
        Label8.TabIndex = 7
        Label8.Text = "Code Postal:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BorderStyle = BorderStyle.FixedSingle
        Label7.Location = New Point(379, 77)
        Label7.Name = "Label7"
        Label7.Padding = New Padding(0, 0, 17, 0)
        Label7.Size = New Size(75, 17)
        Label7.TabIndex = 6
        Label7.Text = "Province:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BorderStyle = BorderStyle.FixedSingle
        Label6.Location = New Point(379, 48)
        Label6.Name = "Label6"
        Label6.Padding = New Padding(0, 0, 41, 0)
        Label6.Size = New Size(75, 17)
        Label6.TabIndex = 5
        Label6.Text = "Ville:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BorderStyle = BorderStyle.FixedSingle
        Label5.Location = New Point(379, 19)
        Label5.Name = "Label5"
        Label5.Padding = New Padding(0, 0, 22, 0)
        Label5.Size = New Size(75, 17)
        Label5.TabIndex = 4
        Label5.Text = "Adresse:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BorderStyle = BorderStyle.FixedSingle
        Label4.Location = New Point(6, 106)
        Label4.Name = "Label4"
        Label4.Padding = New Padding(0, 0, 30, 0)
        Label4.Size = New Size(69, 17)
        Label4.TabIndex = 3
        Label4.Text = "Nom:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BorderStyle = BorderStyle.FixedSingle
        Label3.Location = New Point(6, 77)
        Label3.Name = "Label3"
        Label3.Padding = New Padding(0, 0, 15, 0)
        Label3.Size = New Size(69, 17)
        Label3.TabIndex = 2
        Label3.Text = "Prénom:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BorderStyle = BorderStyle.FixedSingle
        Label2.Location = New Point(6, 48)
        Label2.Name = "Label2"
        Label2.Padding = New Padding(0, 0, 10, 0)
        Label2.Size = New Size(69, 17)
        Label2.TabIndex = 1
        Label2.Text = "No Prog.:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BorderStyle = BorderStyle.FixedSingle
        Label1.Location = New Point(6, 19)
        Label1.Name = "Label1"
        Label1.Padding = New Padding(0, 0, 41, 0)
        Label1.Size = New Size(69, 17)
        Label1.TabIndex = 0
        Label1.Text = "DA:"
        ' 
        ' btnNew
        ' 
        btnNew.Location = New Point(793, 12)
        btnNew.Name = "btnNew"
        btnNew.Size = New Size(75, 23)
        btnNew.TabIndex = 2
        btnNew.Text = "Nouveau"
        btnNew.UseVisualStyleBackColor = True
        ' 
        ' btnConf
        ' 
        btnConf.Enabled = False
        btnConf.Location = New Point(793, 41)
        btnConf.Name = "btnConf"
        btnConf.Size = New Size(75, 23)
        btnConf.TabIndex = 3
        btnConf.Text = "OK"
        btnConf.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Enabled = False
        btnCancel.Location = New Point(793, 70)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(75, 23)
        btnCancel.TabIndex = 4
        btnCancel.Text = "Annuler"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.Enabled = False
        btnEdit.Location = New Point(793, 99)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(75, 23)
        btnEdit.TabIndex = 5
        btnEdit.Text = "Modifier"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Enabled = False
        btnDelete.Location = New Point(793, 128)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(75, 23)
        btnDelete.TabIndex = 6
        btnDelete.Text = "Enlever"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' dgvStudent
        ' 
        dgvStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvStudent.Location = New Point(12, 232)
        dgvStudent.Name = "dgvStudent"
        dgvStudent.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvStudent.Size = New Size(856, 256)
        dgvStudent.TabIndex = 17
        ' 
        ' frmEtudiant
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        ClientSize = New Size(880, 500)
        Controls.Add(dgvStudent)
        Controls.Add(btnDelete)
        Controls.Add(btnEdit)
        Controls.Add(btnCancel)
        Controls.Add(btnConf)
        Controls.Add(btnNew)
        Controls.Add(GroupBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmEtudiant"
        Text = "frmEtudiant"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        gbSexe.ResumeLayout(False)
        gbSexe.PerformLayout()
        CType(dgvStudent, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnNew As Button
    Friend WithEvents btnConf As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents tbDA As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tbState As TextBox
    Friend WithEvents tbCity As TextBox
    Friend WithEvents tbAddr As TextBox
    Friend WithEvents tbLastName As TextBox
    Friend WithEvents gbSexe As GroupBox
    Friend WithEvents rbMale As RadioButton
    Friend WithEvents rbFem As RadioButton
    Friend WithEvents tbFirstName As TextBox
    Friend WithEvents tbNoProg As ComboBox
    Friend WithEvents tbPostal As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents dgvStudent As DataGridView
    Friend WithEvents tbTel As MaskedTextBox
End Class
