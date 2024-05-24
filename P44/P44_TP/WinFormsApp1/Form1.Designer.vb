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
        MenuStrip1 = New MenuStrip()
        GestionToolStripMenuItem = New ToolStripMenuItem()
        ProgrammeToolStripMenuItem = New ToolStripMenuItem()
        ÉtudiantsToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator1 = New ToolStripSeparator()
        QuitterToolStripMenuItem = New ToolStripMenuItem()
        RapportsToolStripMenuItem = New ToolStripMenuItem()
        ListeDesProgrammesToolStripMenuItem = New ToolStripMenuItem()
        ListeDesÉtudiantsToolStripMenuItem = New ToolStripMenuItem()
        ListeDesÉtudiantsParProgrammeToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {GestionToolStripMenuItem, RapportsToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(889, 24)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' GestionToolStripMenuItem
        ' 
        GestionToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ProgrammeToolStripMenuItem, ÉtudiantsToolStripMenuItem, ToolStripSeparator1, QuitterToolStripMenuItem})
        GestionToolStripMenuItem.Name = "GestionToolStripMenuItem"
        GestionToolStripMenuItem.Size = New Size(59, 20)
        GestionToolStripMenuItem.Text = "Gestion"
        ' 
        ' ProgrammeToolStripMenuItem
        ' 
        ProgrammeToolStripMenuItem.Name = "ProgrammeToolStripMenuItem"
        ProgrammeToolStripMenuItem.Size = New Size(137, 22)
        ProgrammeToolStripMenuItem.Text = "Programme"
        ' 
        ' ÉtudiantsToolStripMenuItem
        ' 
        ÉtudiantsToolStripMenuItem.Name = "ÉtudiantsToolStripMenuItem"
        ÉtudiantsToolStripMenuItem.Size = New Size(137, 22)
        ÉtudiantsToolStripMenuItem.Text = "Étudiants"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(134, 6)
        ' 
        ' QuitterToolStripMenuItem
        ' 
        QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        QuitterToolStripMenuItem.Size = New Size(137, 22)
        QuitterToolStripMenuItem.Text = "Quitter"
        ' 
        ' RapportsToolStripMenuItem
        ' 
        RapportsToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ListeDesProgrammesToolStripMenuItem, ListeDesÉtudiantsToolStripMenuItem, ListeDesÉtudiantsParProgrammeToolStripMenuItem})
        RapportsToolStripMenuItem.Name = "RapportsToolStripMenuItem"
        RapportsToolStripMenuItem.Size = New Size(66, 20)
        RapportsToolStripMenuItem.Text = "Rapports"
        ' 
        ' ListeDesProgrammesToolStripMenuItem
        ' 
        ListeDesProgrammesToolStripMenuItem.Name = "ListeDesProgrammesToolStripMenuItem"
        ListeDesProgrammesToolStripMenuItem.Size = New Size(257, 22)
        ListeDesProgrammesToolStripMenuItem.Text = "Liste des Programmes"
        ' 
        ' ListeDesÉtudiantsToolStripMenuItem
        ' 
        ListeDesÉtudiantsToolStripMenuItem.Name = "ListeDesÉtudiantsToolStripMenuItem"
        ListeDesÉtudiantsToolStripMenuItem.Size = New Size(257, 22)
        ListeDesÉtudiantsToolStripMenuItem.Text = "Liste des Étudiants"
        ' 
        ' ListeDesÉtudiantsParProgrammeToolStripMenuItem
        ' 
        ListeDesÉtudiantsParProgrammeToolStripMenuItem.Name = "ListeDesÉtudiantsParProgrammeToolStripMenuItem"
        ListeDesÉtudiantsParProgrammeToolStripMenuItem.Size = New Size(257, 22)
        ListeDesÉtudiantsParProgrammeToolStripMenuItem.Text = "Liste des étudiants par programme"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(889, 521)
        Controls.Add(MenuStrip1)
        ForeColor = SystemColors.ControlText
        IsMdiContainer = True
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Gestion"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GestionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RapportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProgrammeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ÉtudiantsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents QuitterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListeDesProgrammesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListeDesÉtudiantsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListeDesÉtudiantsParProgrammeToolStripMenuItem As ToolStripMenuItem

End Class
