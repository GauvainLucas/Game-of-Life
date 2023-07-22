<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormJeuxDeLaVie
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ButtonAfficheCarre = New System.Windows.Forms.Button()
        Me.ButtonEvolution = New System.Windows.Forms.Button()
        Me.ButtonRenitialiser = New System.Windows.Forms.Button()
        Me.MenuConfiguration = New System.Windows.Forms.MenuStrip()
        Me.ToolStripFichier = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnregistrerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OuvrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfigurationDeRéférenceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanneauToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfigurationsStablesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CarréToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VaisseauToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PulsarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ButtonQuitter = New System.Windows.Forms.Button()
        Me.PictureBoxJeux = New System.Windows.Forms.PictureBox()
        Me.MenuConfiguration.SuspendLayout()
        CType(Me.PictureBoxJeux, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonAfficheCarre
        '
        Me.ButtonAfficheCarre.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonAfficheCarre.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonAfficheCarre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAfficheCarre.Location = New System.Drawing.Point(12, 398)
        Me.ButtonAfficheCarre.Name = "ButtonAfficheCarre"
        Me.ButtonAfficheCarre.Size = New System.Drawing.Size(213, 64)
        Me.ButtonAfficheCarre.TabIndex = 1
        Me.ButtonAfficheCarre.Text = "Afficher les cellules"
        Me.ButtonAfficheCarre.UseVisualStyleBackColor = False
        '
        'ButtonEvolution
        '
        Me.ButtonEvolution.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonEvolution.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonEvolution.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEvolution.Location = New System.Drawing.Point(12, 635)
        Me.ButtonEvolution.Name = "ButtonEvolution"
        Me.ButtonEvolution.Size = New System.Drawing.Size(213, 64)
        Me.ButtonEvolution.TabIndex = 2
        Me.ButtonEvolution.Text = "Evolution"
        Me.ButtonEvolution.UseVisualStyleBackColor = False
        '
        'ButtonRenitialiser
        '
        Me.ButtonRenitialiser.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonRenitialiser.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonRenitialiser.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRenitialiser.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonRenitialiser.Location = New System.Drawing.Point(12, 155)
        Me.ButtonRenitialiser.Name = "ButtonRenitialiser"
        Me.ButtonRenitialiser.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ButtonRenitialiser.Size = New System.Drawing.Size(213, 63)
        Me.ButtonRenitialiser.TabIndex = 4
        Me.ButtonRenitialiser.Text = "Rénitialiser la grille"
        Me.ButtonRenitialiser.UseVisualStyleBackColor = False
        '
        'MenuConfiguration
        '
        Me.MenuConfiguration.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MenuConfiguration.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuConfiguration.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuConfiguration.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripFichier, Me.ConfigurationDeRéférenceToolStripMenuItem, Me.ConfigurationsStablesToolStripMenuItem})
        Me.MenuConfiguration.Location = New System.Drawing.Point(0, 0)
        Me.MenuConfiguration.Name = "MenuConfiguration"
        Me.MenuConfiguration.Padding = New System.Windows.Forms.Padding(10)
        Me.MenuConfiguration.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuConfiguration.Size = New System.Drawing.Size(1542, 49)
        Me.MenuConfiguration.TabIndex = 5
        Me.MenuConfiguration.Text = "MenuStrip1"
        Me.MenuConfiguration.UseWaitCursor = True
        '
        'ToolStripFichier
        '
        Me.ToolStripFichier.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ToolStripFichier.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnregistrerToolStripMenuItem, Me.OuvrirToolStripMenuItem})
        Me.ToolStripFichier.ForeColor = System.Drawing.Color.White
        Me.ToolStripFichier.Name = "ToolStripFichier"
        Me.ToolStripFichier.Size = New System.Drawing.Size(78, 29)
        Me.ToolStripFichier.Text = "Fichier"
        '
        'EnregistrerToolStripMenuItem
        '
        Me.EnregistrerToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.EnregistrerToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.EnregistrerToolStripMenuItem.Name = "EnregistrerToolStripMenuItem"
        Me.EnregistrerToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.EnregistrerToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.EnregistrerToolStripMenuItem.Text = "Enregistrer"
        '
        'OuvrirToolStripMenuItem
        '
        Me.OuvrirToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.OuvrirToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.OuvrirToolStripMenuItem.Name = "OuvrirToolStripMenuItem"
        Me.OuvrirToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OuvrirToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.OuvrirToolStripMenuItem.Text = "Ouvrir"
        '
        'ConfigurationDeRéférenceToolStripMenuItem
        '
        Me.ConfigurationDeRéférenceToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ConfigurationDeRéférenceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PanneauToolStripMenuItem1})
        Me.ConfigurationDeRéférenceToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ConfigurationDeRéférenceToolStripMenuItem.Name = "ConfigurationDeRéférenceToolStripMenuItem"
        Me.ConfigurationDeRéférenceToolStripMenuItem.Size = New System.Drawing.Size(239, 29)
        Me.ConfigurationDeRéférenceToolStripMenuItem.Text = "Configuration de référence"
        '
        'PanneauToolStripMenuItem1
        '
        Me.PanneauToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanneauToolStripMenuItem1.ForeColor = System.Drawing.Color.Black
        Me.PanneauToolStripMenuItem1.Image = Global.Jeux_de_la_vie.My.Resources.Resources.panneau
        Me.PanneauToolStripMenuItem1.Name = "PanneauToolStripMenuItem1"
        Me.PanneauToolStripMenuItem1.Size = New System.Drawing.Size(270, 34)
        Me.PanneauToolStripMenuItem1.Text = "Panneau"
        '
        'ConfigurationsStablesToolStripMenuItem
        '
        Me.ConfigurationsStablesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ConfigurationsStablesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CarréToolStripMenuItem1, Me.VaisseauToolStripMenuItem1, Me.PulsarToolStripMenuItem1})
        Me.ConfigurationsStablesToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ConfigurationsStablesToolStripMenuItem.Name = "ConfigurationsStablesToolStripMenuItem"
        Me.ConfigurationsStablesToolStripMenuItem.Size = New System.Drawing.Size(205, 29)
        Me.ConfigurationsStablesToolStripMenuItem.Text = "Configurations stables"
        '
        'CarréToolStripMenuItem1
        '
        Me.CarréToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CarréToolStripMenuItem1.ForeColor = System.Drawing.Color.Black
        Me.CarréToolStripMenuItem1.Image = Global.Jeux_de_la_vie.My.Resources.Resources.carre
        Me.CarréToolStripMenuItem1.Name = "CarréToolStripMenuItem1"
        Me.CarréToolStripMenuItem1.Size = New System.Drawing.Size(270, 34)
        Me.CarréToolStripMenuItem1.Text = "Carré"
        '
        'VaisseauToolStripMenuItem1
        '
        Me.VaisseauToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.VaisseauToolStripMenuItem1.ForeColor = System.Drawing.Color.Black
        Me.VaisseauToolStripMenuItem1.Image = Global.Jeux_de_la_vie.My.Resources.Resources.vaisseau
        Me.VaisseauToolStripMenuItem1.Name = "VaisseauToolStripMenuItem1"
        Me.VaisseauToolStripMenuItem1.Size = New System.Drawing.Size(270, 34)
        Me.VaisseauToolStripMenuItem1.Text = "Vaisseau "
        '
        'PulsarToolStripMenuItem1
        '
        Me.PulsarToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PulsarToolStripMenuItem1.ForeColor = System.Drawing.Color.Black
        Me.PulsarToolStripMenuItem1.Image = Global.Jeux_de_la_vie.My.Resources.Resources.pulsar
        Me.PulsarToolStripMenuItem1.Name = "PulsarToolStripMenuItem1"
        Me.PulsarToolStripMenuItem1.Size = New System.Drawing.Size(270, 34)
        Me.PulsarToolStripMenuItem1.Text = "Pulsar"
        '
        'ButtonQuitter
        '
        Me.ButtonQuitter.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ButtonQuitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonQuitter.Location = New System.Drawing.Point(1028, 860)
        Me.ButtonQuitter.Name = "ButtonQuitter"
        Me.ButtonQuitter.Size = New System.Drawing.Size(127, 46)
        Me.ButtonQuitter.TabIndex = 6
        Me.ButtonQuitter.Text = "Quitter"
        Me.ButtonQuitter.UseVisualStyleBackColor = False
        '
        'PictureBoxJeux
        '
        Me.PictureBoxJeux.BackColor = System.Drawing.Color.White
        Me.PictureBoxJeux.Location = New System.Drawing.Point(248, 91)
        Me.PictureBoxJeux.Name = "PictureBoxJeux"
        Me.PictureBoxJeux.Size = New System.Drawing.Size(1001, 1001)
        Me.PictureBoxJeux.TabIndex = 3
        Me.PictureBoxJeux.TabStop = False
        '
        'FormJeuxDeLaVie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1542, 1050)
        Me.Controls.Add(Me.ButtonQuitter)
        Me.Controls.Add(Me.ButtonRenitialiser)
        Me.Controls.Add(Me.PictureBoxJeux)
        Me.Controls.Add(Me.ButtonEvolution)
        Me.Controls.Add(Me.ButtonAfficheCarre)
        Me.Controls.Add(Me.MenuConfiguration)
        Me.Location = New System.Drawing.Point(200, 200)
        Me.MainMenuStrip = Me.MenuConfiguration
        Me.Name = "FormJeuxDeLaVie"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Jeux de la vie"
        Me.MenuConfiguration.ResumeLayout(False)
        Me.MenuConfiguration.PerformLayout()
        CType(Me.PictureBoxJeux, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonAfficheCarre As Button
    Friend WithEvents ButtonEvolution As Button
    Friend WithEvents PictureBoxJeux As PictureBox
    Friend WithEvents ButtonRenitialiser As Button
    Friend WithEvents MenuConfiguration As MenuStrip
    Friend WithEvents ToolStripFichier As ToolStripMenuItem
    Friend WithEvents EnregistrerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OuvrirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConfigurationDeRéférenceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConfigurationsStablesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CarréToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents VaisseauToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PulsarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ButtonQuitter As Button
    Public WithEvents PanneauToolStripMenuItem1 As ToolStripMenuItem
End Class
