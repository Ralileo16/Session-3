<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDisco
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
        lvAlbums = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        btnMod = New Button()
        Label1 = New Label()
        Label2 = New Label()
        tbArtiste = New TextBox()
        tbTitre = New TextBox()
        SuspendLayout()
        ' 
        ' lvAlbums
        ' 
        lvAlbums.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2})
        lvAlbums.FullRowSelect = True
        lvAlbums.GridLines = True
        lvAlbums.Location = New Point(12, 12)
        lvAlbums.MultiSelect = False
        lvAlbums.Name = "lvAlbums"
        lvAlbums.Size = New Size(353, 426)
        lvAlbums.TabIndex = 0
        lvAlbums.UseCompatibleStateImageBehavior = False
        lvAlbums.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "Artiste"
        ColumnHeader1.Width = 174
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Album"
        ColumnHeader2.Width = 174
        ' 
        ' btnMod
        ' 
        btnMod.Location = New Point(431, 202)
        btnMod.Name = "btnMod"
        btnMod.Size = New Size(100, 23)
        btnMod.TabIndex = 1
        btnMod.Text = "Modifier"
        btnMod.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(371, 79)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 15)
        Label1.TabIndex = 2
        Label1.Text = "Artiste"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(371, 134)
        Label2.Name = "Label2"
        Label2.Size = New Size(30, 15)
        Label2.TabIndex = 3
        Label2.Text = "Titre"
        ' 
        ' tbArtiste
        ' 
        tbArtiste.BorderStyle = BorderStyle.None
        tbArtiste.Enabled = False
        tbArtiste.Location = New Point(431, 79)
        tbArtiste.Name = "tbArtiste"
        tbArtiste.Size = New Size(270, 16)
        tbArtiste.TabIndex = 4
        ' 
        ' tbTitre
        ' 
        tbTitre.BorderStyle = BorderStyle.None
        tbTitre.Enabled = False
        tbTitre.Location = New Point(431, 134)
        tbTitre.Name = "tbTitre"
        tbTitre.Size = New Size(270, 16)
        tbTitre.TabIndex = 5
        ' 
        ' FormDisco
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(tbTitre)
        Controls.Add(tbArtiste)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnMod)
        Controls.Add(lvAlbums)
        Name = "FormDisco"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lvAlbums As ListView
    Friend WithEvents btnMod As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbArtiste As TextBox
    Friend WithEvents tbTitre As TextBox
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader

End Class
