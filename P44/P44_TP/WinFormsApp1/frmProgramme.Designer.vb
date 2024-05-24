<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProgramme
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
        GroupBoxPrgm = New GroupBox()
        tbNom = New TextBox()
        tbNbrHour = New TextBox()
        tbNbrUnit = New TextBox()
        tbNo = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        btnDelete = New Button()
        btnEdit = New Button()
        btnCancel = New Button()
        btnConf = New Button()
        btnNew = New Button()
        dgvProgramme = New DataGridView()
        dgvStudent = New DataGridView()
        GroupBoxPrgm.SuspendLayout()
        CType(dgvProgramme, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvStudent, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBoxPrgm
        ' 
        GroupBoxPrgm.Controls.Add(tbNom)
        GroupBoxPrgm.Controls.Add(tbNbrHour)
        GroupBoxPrgm.Controls.Add(tbNbrUnit)
        GroupBoxPrgm.Controls.Add(tbNo)
        GroupBoxPrgm.Controls.Add(Label4)
        GroupBoxPrgm.Controls.Add(Label3)
        GroupBoxPrgm.Controls.Add(Label2)
        GroupBoxPrgm.Controls.Add(Label1)
        GroupBoxPrgm.Location = New Point(12, 12)
        GroupBoxPrgm.Name = "GroupBoxPrgm"
        GroupBoxPrgm.Size = New Size(293, 168)
        GroupBoxPrgm.TabIndex = 15
        GroupBoxPrgm.TabStop = False
        GroupBoxPrgm.Text = "Programme"
        ' 
        ' tbNom
        ' 
        tbNom.Enabled = False
        tbNom.Location = New Point(87, 45)
        tbNom.Name = "tbNom"
        tbNom.Size = New Size(184, 23)
        tbNom.TabIndex = 21
        ' 
        ' tbNbrHour
        ' 
        tbNbrHour.Enabled = False
        tbNbrHour.Location = New Point(87, 103)
        tbNbrHour.Name = "tbNbrHour"
        tbNbrHour.Size = New Size(60, 23)
        tbNbrHour.TabIndex = 20
        ' 
        ' tbNbrUnit
        ' 
        tbNbrUnit.Enabled = False
        tbNbrUnit.Location = New Point(87, 74)
        tbNbrUnit.Name = "tbNbrUnit"
        tbNbrUnit.Size = New Size(60, 23)
        tbNbrUnit.TabIndex = 19
        ' 
        ' tbNo
        ' 
        tbNo.Enabled = False
        tbNo.Location = New Point(87, 16)
        tbNo.Name = "tbNo"
        tbNo.PlaceholderText = "_______"
        tbNo.Size = New Size(60, 23)
        tbNo.TabIndex = 17
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BorderStyle = BorderStyle.FixedSingle
        Label4.Location = New Point(6, 106)
        Label4.Name = "Label4"
        Label4.Size = New Size(75, 17)
        Label4.TabIndex = 16
        Label4.Text = "Nbr. Heures:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BorderStyle = BorderStyle.FixedSingle
        Label3.Location = New Point(6, 77)
        Label3.Name = "Label3"
        Label3.Padding = New Padding(0, 0, 7, 0)
        Label3.Size = New Size(75, 17)
        Label3.TabIndex = 15
        Label3.Text = "Nbr Unités:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BorderStyle = BorderStyle.FixedSingle
        Label2.Location = New Point(6, 48)
        Label2.Name = "Label2"
        Label2.Padding = New Padding(0, 0, 36, 0)
        Label2.Size = New Size(75, 17)
        Label2.TabIndex = 14
        Label2.Text = "Nom:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BorderStyle = BorderStyle.FixedSingle
        Label1.Location = New Point(6, 19)
        Label1.Name = "Label1"
        Label1.Padding = New Padding(0, 0, 44, 0)
        Label1.Size = New Size(75, 17)
        Label1.TabIndex = 13
        Label1.Text = "No.:"
        ' 
        ' btnDelete
        ' 
        btnDelete.Enabled = False
        btnDelete.Location = New Point(311, 128)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(75, 23)
        btnDelete.TabIndex = 12
        btnDelete.Text = "Enlever"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.Enabled = False
        btnEdit.Location = New Point(311, 99)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(75, 23)
        btnEdit.TabIndex = 11
        btnEdit.Text = "Modifier"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Enabled = False
        btnCancel.Location = New Point(311, 70)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(75, 23)
        btnCancel.TabIndex = 10
        btnCancel.Text = "Annuler"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' btnConf
        ' 
        btnConf.Enabled = False
        btnConf.Location = New Point(311, 41)
        btnConf.Name = "btnConf"
        btnConf.Size = New Size(75, 23)
        btnConf.TabIndex = 9
        btnConf.Text = "OK"
        btnConf.UseVisualStyleBackColor = True
        ' 
        ' btnNew
        ' 
        btnNew.Location = New Point(311, 12)
        btnNew.Name = "btnNew"
        btnNew.Size = New Size(75, 23)
        btnNew.TabIndex = 8
        btnNew.Text = "Nouveau"
        btnNew.UseVisualStyleBackColor = True
        ' 
        ' dgvProgramme
        ' 
        dgvProgramme.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvProgramme.Location = New Point(12, 186)
        dgvProgramme.Name = "dgvProgramme"
        dgvProgramme.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvProgramme.Size = New Size(374, 302)
        dgvProgramme.TabIndex = 16
        ' 
        ' dgvStudent
        ' 
        dgvStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvStudent.Location = New Point(392, 12)
        dgvStudent.Name = "dgvStudent"
        dgvStudent.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvStudent.Size = New Size(476, 476)
        dgvStudent.TabIndex = 17
        ' 
        ' frmProgramme
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        ClientSize = New Size(880, 500)
        Controls.Add(dgvStudent)
        Controls.Add(dgvProgramme)
        Controls.Add(GroupBoxPrgm)
        Controls.Add(btnDelete)
        Controls.Add(btnEdit)
        Controls.Add(btnCancel)
        Controls.Add(btnConf)
        Controls.Add(btnNew)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmProgramme"
        Text = "frmProgramme"
        GroupBoxPrgm.ResumeLayout(False)
        GroupBoxPrgm.PerformLayout()
        CType(dgvProgramme, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvStudent, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBoxPrgm As GroupBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnConf As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents tbNbrHour As TextBox
    Friend WithEvents tbNbrUnit As TextBox
    Friend WithEvents tbNo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tbNom As TextBox
    Friend WithEvents dgvProgramme As DataGridView
    Friend WithEvents dgvStudent As DataGridView
End Class
