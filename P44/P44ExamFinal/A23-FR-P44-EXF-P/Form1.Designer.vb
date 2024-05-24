<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        GroupBox1 = New GroupBox()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        tbPoints = New TextBox()
        nudPasses = New NumericUpDown()
        nudButs = New NumericUpDown()
        mtbTel = New MaskedTextBox()
        ddEquipe = New ComboBox()
        ddPosition = New ComboBox()
        tbNom = New TextBox()
        tbPrenom = New TextBox()
        tbNo = New TextBox()
        GroupBox2 = New GroupBox()
        lblNav = New Label()
        btnSuivant = New Button()
        btnDernier = New Button()
        btnPrecedent = New Button()
        btnPremier = New Button()
        btnEnlever = New Button()
        btnAjouter = New Button()
        btnEnregistrer = New Button()
        btnAnnuler = New Button()
        btnListe = New Button()
        GroupBox1.SuspendLayout()
        CType(nudPasses, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudButs, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(tbPoints)
        GroupBox1.Controls.Add(nudPasses)
        GroupBox1.Controls.Add(nudButs)
        GroupBox1.Controls.Add(mtbTel)
        GroupBox1.Controls.Add(ddEquipe)
        GroupBox1.Controls.Add(ddPosition)
        GroupBox1.Controls.Add(tbNom)
        GroupBox1.Controls.Add(tbPrenom)
        GroupBox1.Controls.Add(tbNo)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(419, 333)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Info Joueur"
        ' 
        ' Label9
        ' 
        Label9.Location = New Point(268, 223)
        Label9.Name = "Label9"
        Label9.Size = New Size(145, 23)
        Label9.TabIndex = 17
        Label9.Text = "Points:"
        Label9.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label8
        ' 
        Label8.Location = New Point(136, 223)
        Label8.Name = "Label8"
        Label8.Size = New Size(118, 23)
        Label8.TabIndex = 16
        Label8.Text = "Passes:"
        Label8.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label7
        ' 
        Label7.Location = New Point(6, 223)
        Label7.Name = "Label7"
        Label7.Size = New Size(118, 23)
        Label7.TabIndex = 15
        Label7.Text = "Buts:"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label6
        ' 
        Label6.Location = New Point(6, 167)
        Label6.Name = "Label6"
        Label6.Size = New Size(118, 23)
        Label6.TabIndex = 14
        Label6.Text = "Téléphone: "
        Label6.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label5
        ' 
        Label5.Location = New Point(6, 138)
        Label5.Name = "Label5"
        Label5.Size = New Size(118, 23)
        Label5.TabIndex = 13
        Label5.Text = "Équipe: "
        Label5.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label4
        ' 
        Label4.Location = New Point(6, 108)
        Label4.Name = "Label4"
        Label4.Size = New Size(118, 23)
        Label4.TabIndex = 12
        Label4.Text = "Position: "
        Label4.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label3
        ' 
        Label3.Location = New Point(6, 80)
        Label3.Name = "Label3"
        Label3.Size = New Size(118, 23)
        Label3.TabIndex = 11
        Label3.Text = "Nom: "
        Label3.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label2
        ' 
        Label2.Location = New Point(6, 51)
        Label2.Name = "Label2"
        Label2.Size = New Size(118, 23)
        Label2.TabIndex = 10
        Label2.Text = "Prénom: "
        Label2.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label1
        ' 
        Label1.Location = New Point(6, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(118, 23)
        Label1.TabIndex = 9
        Label1.Text = "No: "
        Label1.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' tbPoints
        ' 
        tbPoints.Location = New Point(268, 249)
        tbPoints.Name = "tbPoints"
        tbPoints.Size = New Size(145, 23)
        tbPoints.TabIndex = 8
        tbPoints.Text = "0"
        tbPoints.TextAlign = HorizontalAlignment.Center
        ' 
        ' nudPasses
        ' 
        nudPasses.Location = New Point(136, 249)
        nudPasses.Name = "nudPasses"
        nudPasses.Size = New Size(118, 23)
        nudPasses.TabIndex = 7
        nudPasses.TextAlign = HorizontalAlignment.Right
        ' 
        ' nudButs
        ' 
        nudButs.Location = New Point(6, 249)
        nudButs.Name = "nudButs"
        nudButs.Size = New Size(118, 23)
        nudButs.TabIndex = 6
        nudButs.TextAlign = HorizontalAlignment.Right
        ' 
        ' mtbTel
        ' 
        mtbTel.Location = New Point(136, 167)
        mtbTel.Mask = "(###) ###-####"
        mtbTel.Name = "mtbTel"
        mtbTel.Size = New Size(277, 23)
        mtbTel.TabIndex = 5
        ' 
        ' ddEquipe
        ' 
        ddEquipe.FormattingEnabled = True
        ddEquipe.Location = New Point(136, 138)
        ddEquipe.Name = "ddEquipe"
        ddEquipe.Size = New Size(277, 23)
        ddEquipe.TabIndex = 4
        ' 
        ' ddPosition
        ' 
        ddPosition.FormattingEnabled = True
        ddPosition.Location = New Point(136, 109)
        ddPosition.Name = "ddPosition"
        ddPosition.Size = New Size(277, 23)
        ddPosition.TabIndex = 3
        ' 
        ' tbNom
        ' 
        tbNom.Location = New Point(136, 80)
        tbNom.Name = "tbNom"
        tbNom.Size = New Size(277, 23)
        tbNom.TabIndex = 2
        ' 
        ' tbPrenom
        ' 
        tbPrenom.Location = New Point(136, 51)
        tbPrenom.Name = "tbPrenom"
        tbPrenom.Size = New Size(277, 23)
        tbPrenom.TabIndex = 1
        ' 
        ' tbNo
        ' 
        tbNo.Location = New Point(136, 22)
        tbNo.Name = "tbNo"
        tbNo.ReadOnly = True
        tbNo.Size = New Size(93, 23)
        tbNo.TabIndex = 0
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(lblNav)
        GroupBox2.Controls.Add(btnSuivant)
        GroupBox2.Controls.Add(btnDernier)
        GroupBox2.Controls.Add(btnPrecedent)
        GroupBox2.Controls.Add(btnPremier)
        GroupBox2.Location = New Point(12, 351)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(413, 87)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        ' 
        ' lblNav
        ' 
        lblNav.BorderStyle = BorderStyle.FixedSingle
        lblNav.Location = New Point(132, 22)
        lblNav.Name = "lblNav"
        lblNav.Size = New Size(149, 59)
        lblNav.TabIndex = 4
        lblNav.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnSuivant
        ' 
        btnSuivant.Location = New Point(287, 22)
        btnSuivant.Name = "btnSuivant"
        btnSuivant.Size = New Size(57, 59)
        btnSuivant.TabIndex = 3
        btnSuivant.Text = ">"
        btnSuivant.UseVisualStyleBackColor = True
        ' 
        ' btnDernier
        ' 
        btnDernier.Location = New Point(350, 22)
        btnDernier.Name = "btnDernier"
        btnDernier.Size = New Size(57, 59)
        btnDernier.TabIndex = 2
        btnDernier.Text = ">|"
        btnDernier.UseVisualStyleBackColor = True
        ' 
        ' btnPrecedent
        ' 
        btnPrecedent.Location = New Point(69, 22)
        btnPrecedent.Name = "btnPrecedent"
        btnPrecedent.Size = New Size(57, 59)
        btnPrecedent.TabIndex = 1
        btnPrecedent.Text = "<"
        btnPrecedent.UseVisualStyleBackColor = True
        ' 
        ' btnPremier
        ' 
        btnPremier.Location = New Point(6, 22)
        btnPremier.Name = "btnPremier"
        btnPremier.Size = New Size(57, 59)
        btnPremier.TabIndex = 0
        btnPremier.Text = "|<"
        btnPremier.UseVisualStyleBackColor = True
        ' 
        ' btnEnlever
        ' 
        btnEnlever.Location = New Point(437, 23)
        btnEnlever.Name = "btnEnlever"
        btnEnlever.Size = New Size(140, 51)
        btnEnlever.TabIndex = 2
        btnEnlever.Text = "Enlever"
        btnEnlever.UseVisualStyleBackColor = True
        ' 
        ' btnAjouter
        ' 
        btnAjouter.Location = New Point(437, 77)
        btnAjouter.Name = "btnAjouter"
        btnAjouter.Size = New Size(140, 51)
        btnAjouter.TabIndex = 3
        btnAjouter.Text = "Ajouter"
        btnAjouter.UseVisualStyleBackColor = True
        ' 
        ' btnEnregistrer
        ' 
        btnEnregistrer.Location = New Point(437, 134)
        btnEnregistrer.Name = "btnEnregistrer"
        btnEnregistrer.Size = New Size(140, 51)
        btnEnregistrer.TabIndex = 4
        btnEnregistrer.Text = "Enregistrer"
        btnEnregistrer.UseVisualStyleBackColor = True
        ' 
        ' btnAnnuler
        ' 
        btnAnnuler.Enabled = False
        btnAnnuler.Location = New Point(437, 191)
        btnAnnuler.Name = "btnAnnuler"
        btnAnnuler.Size = New Size(140, 51)
        btnAnnuler.TabIndex = 5
        btnAnnuler.Text = "Annuler"
        btnAnnuler.UseVisualStyleBackColor = True
        ' 
        ' btnListe
        ' 
        btnListe.Location = New Point(437, 330)
        btnListe.Name = "btnListe"
        btnListe.Size = New Size(140, 108)
        btnListe.TabIndex = 6
        btnListe.Text = "Liste DataGrid"
        btnListe.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(588, 450)
        Controls.Add(btnListe)
        Controls.Add(btnAnnuler)
        Controls.Add(btnEnregistrer)
        Controls.Add(btnAjouter)
        Controls.Add(btnEnlever)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(nudPasses, ComponentModel.ISupportInitialize).EndInit()
        CType(nudButs, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents nudButs As NumericUpDown
    Friend WithEvents mtbTel As MaskedTextBox
    Friend WithEvents ddEquipe As ComboBox
    Friend WithEvents ddPosition As ComboBox
    Friend WithEvents tbNom As TextBox
    Friend WithEvents tbPrenom As TextBox
    Friend WithEvents tbNo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tbPoints As TextBox
    Friend WithEvents nudPasses As NumericUpDown
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblNav As Label
    Friend WithEvents btnSuivant As Button
    Friend WithEvents btnDernier As Button
    Friend WithEvents btnPrecedent As Button
    Friend WithEvents btnPremier As Button
    Friend WithEvents btnEnlever As Button
    Friend WithEvents btnAjouter As Button
    Friend WithEvents btnEnregistrer As Button
    Friend WithEvents btnAnnuler As Button
    Friend WithEvents btnListe As Button
End Class
