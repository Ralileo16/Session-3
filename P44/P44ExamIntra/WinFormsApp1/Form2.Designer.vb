<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormModifier
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
        Label1 = New Label()
        tbAlbum = New TextBox()
        ButtonOK = New Button()
        ButtonAnnuler = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(89, 15)
        Label1.TabIndex = 0
        Label1.Text = "Titre de l'album"
        ' 
        ' tbAlbum
        ' 
        tbAlbum.Location = New Point(12, 27)
        tbAlbum.Name = "tbAlbum"
        tbAlbum.Size = New Size(296, 23)
        tbAlbum.TabIndex = 1
        ' 
        ' ButtonOK
        ' 
        ButtonOK.Location = New Point(150, 84)
        ButtonOK.Name = "ButtonOK"
        ButtonOK.Size = New Size(75, 23)
        ButtonOK.TabIndex = 2
        ButtonOK.Text = "OK"
        ButtonOK.UseVisualStyleBackColor = True
        ' 
        ' ButtonAnnuler
        ' 
        ButtonAnnuler.Location = New Point(231, 84)
        ButtonAnnuler.Name = "ButtonAnnuler"
        ButtonAnnuler.Size = New Size(75, 23)
        ButtonAnnuler.TabIndex = 3
        ButtonAnnuler.Text = "Annuler"
        ButtonAnnuler.UseVisualStyleBackColor = True
        ' 
        ' FormModifier
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(318, 119)
        Controls.Add(ButtonAnnuler)
        Controls.Add(ButtonOK)
        Controls.Add(tbAlbum)
        Controls.Add(Label1)
        Name = "FormModifier"
        Text = "Modifier le titre de l'album"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tbAlbum As TextBox
    Friend WithEvents ButtonOK As Button
    Friend WithEvents ButtonAnnuler As Button
End Class
