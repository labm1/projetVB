<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menuForm
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
        validationButton = New Button()
        contratButton = New Button()
        equipementButton = New Button()
        progButton = New Button()
        appelButton = New Button()
        formationButton = New Button()
        rapportButton = New Button()
        menuLabel = New Label()
        logoutButton = New Button()
        SuspendLayout()
        ' 
        ' validationButton
        ' 
        validationButton.Location = New Point(101, 95)
        validationButton.Name = "validationButton"
        validationButton.Size = New Size(253, 34)
        validationButton.TabIndex = 0
        validationButton.Text = "Validation Code Client"
        validationButton.UseVisualStyleBackColor = True
        ' 
        ' contratButton
        ' 
        contratButton.Location = New Point(101, 135)
        contratButton.Name = "contratButton"
        contratButton.Size = New Size(253, 34)
        contratButton.TabIndex = 1
        contratButton.Text = "Gestion des Contrats"
        contratButton.UseVisualStyleBackColor = True
        ' 
        ' equipementButton
        ' 
        equipementButton.Location = New Point(101, 215)
        equipementButton.Name = "equipementButton"
        equipementButton.Size = New Size(253, 34)
        equipementButton.TabIndex = 2
        equipementButton.Text = "État des Équipements"
        equipementButton.UseVisualStyleBackColor = True
        ' 
        ' progButton
        ' 
        progButton.Location = New Point(101, 255)
        progButton.Name = "progButton"
        progButton.Size = New Size(253, 34)
        progButton.TabIndex = 3
        progButton.Text = "Programmation de Site"
        progButton.UseVisualStyleBackColor = True
        ' 
        ' appelButton
        ' 
        appelButton.Location = New Point(101, 175)
        appelButton.Name = "appelButton"
        appelButton.Size = New Size(253, 34)
        appelButton.TabIndex = 4
        appelButton.Text = "Gestion des Appels Téléphoniques"
        appelButton.UseVisualStyleBackColor = True
        ' 
        ' formationButton
        ' 
        formationButton.Location = New Point(101, 375)
        formationButton.Name = "formationButton"
        formationButton.Size = New Size(253, 34)
        formationButton.TabIndex = 5
        formationButton.Text = "Formations..."
        formationButton.UseVisualStyleBackColor = True
        ' 
        ' rapportButton
        ' 
        rapportButton.Location = New Point(101, 335)
        rapportButton.Name = "rapportButton"
        rapportButton.Size = New Size(253, 34)
        rapportButton.TabIndex = 6
        rapportButton.Text = "Rapports et Statistiques"
        rapportButton.UseVisualStyleBackColor = True
        ' 
        ' menuLabel
        ' 
        menuLabel.AutoSize = True
        menuLabel.Font = New Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        menuLabel.Location = New Point(167, 9)
        menuLabel.Name = "menuLabel"
        menuLabel.Size = New Size(122, 48)
        menuLabel.TabIndex = 7
        menuLabel.Text = "Menu"
        ' 
        ' logoutButton
        ' 
        logoutButton.Location = New Point(474, 375)
        logoutButton.Name = "logoutButton"
        logoutButton.Size = New Size(214, 34)
        logoutButton.TabIndex = 8
        logoutButton.Text = "Quitter la session"
        logoutButton.UseVisualStyleBackColor = True
        ' 
        ' menuForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(logoutButton)
        Controls.Add(menuLabel)
        Controls.Add(rapportButton)
        Controls.Add(formationButton)
        Controls.Add(appelButton)
        Controls.Add(progButton)
        Controls.Add(equipementButton)
        Controls.Add(contratButton)
        Controls.Add(validationButton)
        Name = "menuForm"
        Text = "Menu"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents validationButton As Button
    Friend WithEvents contratButton As Button
    Friend WithEvents equipementButton As Button
    Friend WithEvents progButton As Button
    Friend WithEvents appelButton As Button
    Friend WithEvents formationButton As Button
    Friend WithEvents rapportButton As Button
    Friend WithEvents menuLabel As Label
    Friend WithEvents logoutButton As Button
End Class
