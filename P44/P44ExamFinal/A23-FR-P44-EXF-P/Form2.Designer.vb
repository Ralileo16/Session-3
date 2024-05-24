<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        dgvEquipes = New DataGridView()
        dgvJoueurs = New DataGridView()
        CType(dgvEquipes, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvJoueurs, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvEquipes
        ' 
        dgvEquipes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvEquipes.Location = New Point(12, 12)
        dgvEquipes.Name = "dgvEquipes"
        dgvEquipes.RowTemplate.Height = 25
        dgvEquipes.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvEquipes.Size = New Size(240, 426)
        dgvEquipes.TabIndex = 0
        ' 
        ' dgvJoueurs
        ' 
        dgvJoueurs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvJoueurs.Location = New Point(258, 12)
        dgvJoueurs.Name = "dgvJoueurs"
        dgvJoueurs.RowTemplate.Height = 25
        dgvJoueurs.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvJoueurs.Size = New Size(530, 426)
        dgvJoueurs.TabIndex = 1
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(dgvJoueurs)
        Controls.Add(dgvEquipes)
        Name = "Form2"
        Text = "Form2"
        CType(dgvEquipes, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvJoueurs, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvEquipes As DataGridView
    Friend WithEvents dgvJoueurs As DataGridView
End Class
