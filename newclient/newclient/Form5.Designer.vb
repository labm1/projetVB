<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class majForm
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
        confirmerButton = New Button()
        annulerButton = New Button()
        nbComboBox = New ComboBox()
        nbLabel = New Label()
        equipementComboBox = New ComboBox()
        equipementLabel = New Label()
        frequenceComboBox = New ComboBox()
        frequenceLabel = New Label()
        tempsTextBox = New TextBox()
        tempsLabel = New Label()
        nomTextBox = New TextBox()
        typeClientComboBox = New ComboBox()
        typeClientLabel = New Label()
        nomLabel = New Label()
        SuspendLayout()
        ' 
        ' confirmerButton
        ' 
        confirmerButton.Location = New Point(214, 687)
        confirmerButton.Margin = New Padding(4, 5, 4, 5)
        confirmerButton.Name = "confirmerButton"
        confirmerButton.Size = New Size(107, 38)
        confirmerButton.TabIndex = 0
        confirmerButton.Text = "Confirmer"
        confirmerButton.UseVisualStyleBackColor = True
        ' 
        ' annulerButton
        ' 
        annulerButton.Location = New Point(411, 687)
        annulerButton.Margin = New Padding(4, 5, 4, 5)
        annulerButton.Name = "annulerButton"
        annulerButton.Size = New Size(107, 38)
        annulerButton.TabIndex = 1
        annulerButton.Text = "Annuler"
        annulerButton.UseVisualStyleBackColor = True
        ' 
        ' nbComboBox
        ' 
        nbComboBox.Font = New Font("Microsoft Sans Serif", 8.25F)
        nbComboBox.FormattingEnabled = True
        nbComboBox.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        nbComboBox.Location = New Point(226, 545)
        nbComboBox.Margin = New Padding(4, 5, 4, 5)
        nbComboBox.Name = "nbComboBox"
        nbComboBox.Size = New Size(263, 28)
        nbComboBox.TabIndex = 27
        ' 
        ' nbLabel
        ' 
        nbLabel.AutoSize = True
        nbLabel.Font = New Font("Microsoft Sans Serif", 8.25F)
        nbLabel.Location = New Point(38, 548)
        nbLabel.Margin = New Padding(4, 0, 4, 0)
        nbLabel.Name = "nbLabel"
        nbLabel.Size = New Size(172, 20)
        nbLabel.TabIndex = 26
        nbLabel.Text = "Nombre d'équipement"
        ' 
        ' equipementComboBox
        ' 
        equipementComboBox.Font = New Font("Microsoft Sans Serif", 8.25F)
        equipementComboBox.FormattingEnabled = True
        equipementComboBox.Items.AddRange(New Object() {"Modem", "Ligne Internet", "Micro-Ordinateur"})
        equipementComboBox.Location = New Point(226, 457)
        equipementComboBox.Margin = New Padding(4, 5, 4, 5)
        equipementComboBox.Name = "equipementComboBox"
        equipementComboBox.Size = New Size(263, 28)
        equipementComboBox.TabIndex = 25
        ' 
        ' equipementLabel
        ' 
        equipementLabel.AutoSize = True
        equipementLabel.Font = New Font("Microsoft Sans Serif", 8.25F)
        equipementLabel.Location = New Point(90, 460)
        equipementLabel.Margin = New Padding(4, 0, 4, 0)
        equipementLabel.Name = "equipementLabel"
        equipementLabel.Size = New Size(97, 20)
        equipementLabel.TabIndex = 24
        equipementLabel.Text = "Équipement"
        ' 
        ' frequenceComboBox
        ' 
        frequenceComboBox.Font = New Font("Microsoft Sans Serif", 8.25F)
        frequenceComboBox.FormattingEnabled = True
        frequenceComboBox.Items.AddRange(New Object() {"Annuel", "Mensuel"})
        frequenceComboBox.Location = New Point(226, 365)
        frequenceComboBox.Margin = New Padding(4, 5, 4, 5)
        frequenceComboBox.Name = "frequenceComboBox"
        frequenceComboBox.Size = New Size(263, 28)
        frequenceComboBox.TabIndex = 23
        ' 
        ' frequenceLabel
        ' 
        frequenceLabel.AutoSize = True
        frequenceLabel.Font = New Font("Microsoft Sans Serif", 8.25F)
        frequenceLabel.Location = New Point(38, 368)
        frequenceLabel.Margin = New Padding(4, 0, 4, 0)
        frequenceLabel.Name = "frequenceLabel"
        frequenceLabel.Size = New Size(186, 20)
        frequenceLabel.TabIndex = 22
        frequenceLabel.Text = "Fréquence de Paiement"
        ' 
        ' tempsTextBox
        ' 
        tempsTextBox.Font = New Font("Microsoft Sans Serif", 8.25F)
        tempsTextBox.Location = New Point(226, 272)
        tempsTextBox.Margin = New Padding(4, 5, 4, 5)
        tempsTextBox.Name = "tempsTextBox"
        tempsTextBox.Size = New Size(263, 26)
        tempsTextBox.TabIndex = 19
        ' 
        ' tempsLabel
        ' 
        tempsLabel.AutoSize = True
        tempsLabel.Font = New Font("Microsoft Sans Serif", 8.25F)
        tempsLabel.Location = New Point(90, 275)
        tempsLabel.Margin = New Padding(4, 0, 4, 0)
        tempsLabel.Name = "tempsLabel"
        tempsLabel.Size = New Size(115, 20)
        tempsLabel.TabIndex = 18
        tempsLabel.Text = "Temps Désiré"
        ' 
        ' nomTextBox
        ' 
        nomTextBox.Font = New Font("Microsoft Sans Serif", 8.25F)
        nomTextBox.Location = New Point(226, 79)
        nomTextBox.Margin = New Padding(4, 5, 4, 5)
        nomTextBox.Name = "nomTextBox"
        nomTextBox.Size = New Size(263, 26)
        nomTextBox.TabIndex = 17
        ' 
        ' typeClientComboBox
        ' 
        typeClientComboBox.Font = New Font("Microsoft Sans Serif", 8.25F)
        typeClientComboBox.FormattingEnabled = True
        typeClientComboBox.Items.AddRange(New Object() {"Civil", "Commercial"})
        typeClientComboBox.Location = New Point(226, 174)
        typeClientComboBox.Margin = New Padding(4, 5, 4, 5)
        typeClientComboBox.Name = "typeClientComboBox"
        typeClientComboBox.Size = New Size(263, 28)
        typeClientComboBox.TabIndex = 16
        ' 
        ' typeClientLabel
        ' 
        typeClientLabel.AutoSize = True
        typeClientLabel.Font = New Font("Microsoft Sans Serif", 8.25F)
        typeClientLabel.Location = New Point(90, 174)
        typeClientLabel.Margin = New Padding(4, 0, 4, 0)
        typeClientLabel.Name = "typeClientLabel"
        typeClientLabel.Size = New Size(116, 20)
        typeClientLabel.TabIndex = 15
        typeClientLabel.Text = "Type de Client"
        ' 
        ' nomLabel
        ' 
        nomLabel.AutoSize = True
        nomLabel.Font = New Font("Microsoft Sans Serif", 8.25F)
        nomLabel.Location = New Point(91, 82)
        nomLabel.Margin = New Padding(4, 0, 4, 0)
        nomLabel.Name = "nomLabel"
        nomLabel.Size = New Size(115, 20)
        nomLabel.TabIndex = 14
        nomLabel.Text = "Nom du Client"
        ' 
        ' majForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(600, 797)
        Controls.Add(nbComboBox)
        Controls.Add(nbLabel)
        Controls.Add(equipementComboBox)
        Controls.Add(equipementLabel)
        Controls.Add(frequenceComboBox)
        Controls.Add(frequenceLabel)
        Controls.Add(tempsTextBox)
        Controls.Add(tempsLabel)
        Controls.Add(nomTextBox)
        Controls.Add(typeClientComboBox)
        Controls.Add(typeClientLabel)
        Controls.Add(nomLabel)
        Controls.Add(annulerButton)
        Controls.Add(confirmerButton)
        Margin = New Padding(4, 5, 4, 5)
        Name = "majForm"
        Text = "Mise à Jour Contrat"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents confirmerButton As Button
    Friend WithEvents annulerButton As Button
    Friend WithEvents nbComboBox As ComboBox
    Friend WithEvents nbLabel As Label
    Friend WithEvents equipementComboBox As ComboBox
    Friend WithEvents equipementLabel As Label
    Friend WithEvents frequenceComboBox As ComboBox
    Friend WithEvents frequenceLabel As Label
    Friend WithEvents tempsTextBox As TextBox
    Friend WithEvents tempsLabel As Label
    Friend WithEvents nomTextBox As TextBox
    Friend WithEvents typeClientComboBox As ComboBox
    Friend WithEvents typeClientLabel As Label
    Friend WithEvents nomLabel As Label
End Class
