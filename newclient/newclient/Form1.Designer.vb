<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class clientForm
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
        nomLabel = New Label()
        typeClientLabel = New Label()
        typeClientComboBox = New ComboBox()
        nomTextBox = New TextBox()
        tempsLabel = New Label()
        tempsTextBox = New TextBox()
        creerButton = New Button()
        annulerButton = New Button()
        frequenceLabel = New Label()
        frequenceComboBox = New ComboBox()
        equipementComboBox = New ComboBox()
        equipementLabel = New Label()
        nbComboBox = New ComboBox()
        nbLabel = New Label()
        SuspendLayout()
        ' 
        ' nomLabel
        ' 
        nomLabel.AutoSize = True
        nomLabel.Font = New Font("Microsoft Sans Serif", 8.25F)
        nomLabel.Location = New Point(66, 65)
        nomLabel.Margin = New Padding(4, 0, 4, 0)
        nomLabel.Name = "nomLabel"
        nomLabel.Size = New Size(115, 20)
        nomLabel.TabIndex = 0
        nomLabel.Text = "Nom du Client"
        ' 
        ' typeClientLabel
        ' 
        typeClientLabel.AutoSize = True
        typeClientLabel.Font = New Font("Microsoft Sans Serif", 8.25F)
        typeClientLabel.Location = New Point(65, 157)
        typeClientLabel.Margin = New Padding(4, 0, 4, 0)
        typeClientLabel.Name = "typeClientLabel"
        typeClientLabel.Size = New Size(116, 20)
        typeClientLabel.TabIndex = 1
        typeClientLabel.Text = "Type de Client"
        ' 
        ' typeClientComboBox
        ' 
        typeClientComboBox.Font = New Font("Microsoft Sans Serif", 8.25F)
        typeClientComboBox.FormattingEnabled = True
        typeClientComboBox.Items.AddRange(New Object() {"Civil", "Commercial"})
        typeClientComboBox.Location = New Point(201, 157)
        typeClientComboBox.Margin = New Padding(4, 5, 4, 5)
        typeClientComboBox.Name = "typeClientComboBox"
        typeClientComboBox.Size = New Size(263, 28)
        typeClientComboBox.TabIndex = 2
        ' 
        ' nomTextBox
        ' 
        nomTextBox.Font = New Font("Microsoft Sans Serif", 8.25F)
        nomTextBox.Location = New Point(201, 62)
        nomTextBox.Margin = New Padding(4, 5, 4, 5)
        nomTextBox.Name = "nomTextBox"
        nomTextBox.Size = New Size(263, 26)
        nomTextBox.TabIndex = 3
        ' 
        ' tempsLabel
        ' 
        tempsLabel.AutoSize = True
        tempsLabel.Font = New Font("Microsoft Sans Serif", 8.25F)
        tempsLabel.Location = New Point(65, 258)
        tempsLabel.Margin = New Padding(4, 0, 4, 0)
        tempsLabel.Name = "tempsLabel"
        tempsLabel.Size = New Size(115, 20)
        tempsLabel.TabIndex = 4
        tempsLabel.Text = "Temps Désiré"
        ' 
        ' tempsTextBox
        ' 
        tempsTextBox.Font = New Font("Microsoft Sans Serif", 8.25F)
        tempsTextBox.Location = New Point(201, 255)
        tempsTextBox.Margin = New Padding(4, 5, 4, 5)
        tempsTextBox.Name = "tempsTextBox"
        tempsTextBox.Size = New Size(263, 26)
        tempsTextBox.TabIndex = 5
        ' 
        ' creerButton
        ' 
        creerButton.Font = New Font("Microsoft Sans Serif", 8.25F)
        creerButton.Location = New Point(77, 610)
        creerButton.Margin = New Padding(4, 5, 4, 5)
        creerButton.Name = "creerButton"
        creerButton.Size = New Size(169, 38)
        creerButton.TabIndex = 6
        creerButton.Text = "Créer le Contrat"
        creerButton.UseVisualStyleBackColor = True
        ' 
        ' annulerButton
        ' 
        annulerButton.Font = New Font("Microsoft Sans Serif", 8.25F)
        annulerButton.Location = New Point(359, 610)
        annulerButton.Margin = New Padding(4, 5, 4, 5)
        annulerButton.Name = "annulerButton"
        annulerButton.Size = New Size(107, 38)
        annulerButton.TabIndex = 7
        annulerButton.Text = "Annuler"
        annulerButton.UseVisualStyleBackColor = True
        ' 
        ' frequenceLabel
        ' 
        frequenceLabel.AutoSize = True
        frequenceLabel.Font = New Font("Microsoft Sans Serif", 8.25F)
        frequenceLabel.Location = New Point(13, 351)
        frequenceLabel.Margin = New Padding(4, 0, 4, 0)
        frequenceLabel.Name = "frequenceLabel"
        frequenceLabel.Size = New Size(186, 20)
        frequenceLabel.TabIndex = 8
        frequenceLabel.Text = "Fréquence de Paiement"
        ' 
        ' frequenceComboBox
        ' 
        frequenceComboBox.Font = New Font("Microsoft Sans Serif", 8.25F)
        frequenceComboBox.FormattingEnabled = True
        frequenceComboBox.Items.AddRange(New Object() {"Annuel", "Mensuel"})
        frequenceComboBox.Location = New Point(201, 348)
        frequenceComboBox.Margin = New Padding(4, 5, 4, 5)
        frequenceComboBox.Name = "frequenceComboBox"
        frequenceComboBox.Size = New Size(263, 28)
        frequenceComboBox.TabIndex = 9
        ' 
        ' equipementComboBox
        ' 
        equipementComboBox.Font = New Font("Microsoft Sans Serif", 8.25F)
        equipementComboBox.FormattingEnabled = True
        equipementComboBox.Items.AddRange(New Object() {"Modem", "Ligne Internet", "Micro-Ordinateur"})
        equipementComboBox.Location = New Point(201, 440)
        equipementComboBox.Margin = New Padding(4, 5, 4, 5)
        equipementComboBox.Name = "equipementComboBox"
        equipementComboBox.Size = New Size(263, 28)
        equipementComboBox.TabIndex = 11
        ' 
        ' equipementLabel
        ' 
        equipementLabel.AutoSize = True
        equipementLabel.Font = New Font("Microsoft Sans Serif", 8.25F)
        equipementLabel.Location = New Point(65, 443)
        equipementLabel.Margin = New Padding(4, 0, 4, 0)
        equipementLabel.Name = "equipementLabel"
        equipementLabel.Size = New Size(97, 20)
        equipementLabel.TabIndex = 10
        equipementLabel.Text = "Équipement"
        ' 
        ' nbComboBox
        ' 
        nbComboBox.Font = New Font("Microsoft Sans Serif", 8.25F)
        nbComboBox.FormattingEnabled = True
        nbComboBox.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        nbComboBox.Location = New Point(201, 528)
        nbComboBox.Margin = New Padding(4, 5, 4, 5)
        nbComboBox.Name = "nbComboBox"
        nbComboBox.Size = New Size(263, 28)
        nbComboBox.TabIndex = 13
        ' 
        ' nbLabel
        ' 
        nbLabel.AutoSize = True
        nbLabel.Font = New Font("Microsoft Sans Serif", 8.25F)
        nbLabel.Location = New Point(13, 531)
        nbLabel.Margin = New Padding(4, 0, 4, 0)
        nbLabel.Name = "nbLabel"
        nbLabel.Size = New Size(172, 20)
        nbLabel.TabIndex = 12
        nbLabel.Text = "Nombre d'équipement"
        ' 
        ' clientForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(553, 750)
        Controls.Add(nbComboBox)
        Controls.Add(nbLabel)
        Controls.Add(equipementComboBox)
        Controls.Add(equipementLabel)
        Controls.Add(frequenceComboBox)
        Controls.Add(frequenceLabel)
        Controls.Add(annulerButton)
        Controls.Add(creerButton)
        Controls.Add(tempsTextBox)
        Controls.Add(tempsLabel)
        Controls.Add(nomTextBox)
        Controls.Add(typeClientComboBox)
        Controls.Add(typeClientLabel)
        Controls.Add(nomLabel)
        Margin = New Padding(4, 5, 4, 5)
        Name = "clientForm"
        Text = "Nouveau Client"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents nomLabel As Label
    Friend WithEvents typeClientLabel As Label
    Friend WithEvents typeClientComboBox As ComboBox
    Friend WithEvents nomTextBox As TextBox
    Friend WithEvents tempsLabel As Label
    Friend WithEvents tempsTextBox As TextBox
    Friend WithEvents creerButton As Button
    Friend WithEvents annulerButton As Button
    Friend WithEvents frequenceLabel As Label
    Friend WithEvents frequenceComboBox As ComboBox
    Friend WithEvents equipementComboBox As ComboBox
    Friend WithEvents equipementLabel As Label
    Friend WithEvents nbComboBox As ComboBox
    Friend WithEvents nbLabel As Label

End Class
