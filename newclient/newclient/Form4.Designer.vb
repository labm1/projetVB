<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class infoContratForm
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
        majButton = New Button()
        sortirButton = New Button()
        infoListBox = New ListBox()
        supprimerButton = New Button()
        infoLabel = New Label()
        SuspendLayout()
        ' 
        ' majButton
        ' 
        majButton.Font = New Font("Microsoft Sans Serif", 8.25F)
        majButton.Location = New Point(167, 647)
        majButton.Margin = New Padding(4, 5, 4, 5)
        majButton.Name = "majButton"
        majButton.Size = New Size(159, 38)
        majButton.TabIndex = 0
        majButton.Text = "Mettre à jour"
        majButton.UseVisualStyleBackColor = True
        ' 
        ' sortirButton
        ' 
        sortirButton.Font = New Font("Microsoft Sans Serif", 8.25F)
        sortirButton.Location = New Point(660, 647)
        sortirButton.Margin = New Padding(4, 5, 4, 5)
        sortirButton.Name = "sortirButton"
        sortirButton.Size = New Size(107, 38)
        sortirButton.TabIndex = 1
        sortirButton.Text = "Sortir"
        sortirButton.UseVisualStyleBackColor = True
        ' 
        ' infoListBox
        ' 
        infoListBox.Font = New Font("Microsoft Sans Serif", 8.25F)
        infoListBox.FormattingEnabled = True
        infoListBox.ItemHeight = 20
        infoListBox.Items.AddRange(New Object() {"Numéro de contrat: ", "Nom: ", "type de client: ", "Date de début: ", "Date de fin: ", "Équipement loué: ", "Nombre d'équipement loué: ", "", "Fréquence des paiements: ", "Frais de locations total: ", "Frais de locations payés: ", "Pourcentage taxes: ", "", "Dernier paiement: ", "type de paiement: "})
        infoListBox.Location = New Point(167, 155)
        infoListBox.Margin = New Padding(4, 5, 4, 5)
        infoListBox.Name = "infoListBox"
        infoListBox.Size = New Size(598, 424)
        infoListBox.TabIndex = 2
        ' 
        ' supprimerButton
        ' 
        supprimerButton.Font = New Font("Microsoft Sans Serif", 8.25F)
        supprimerButton.Location = New Point(420, 647)
        supprimerButton.Margin = New Padding(4, 5, 4, 5)
        supprimerButton.Name = "supprimerButton"
        supprimerButton.Size = New Size(107, 38)
        supprimerButton.TabIndex = 3
        supprimerButton.Text = "Supprimer"
        supprimerButton.UseVisualStyleBackColor = True
        ' 
        ' infoLabel
        ' 
        infoLabel.AutoSize = True
        infoLabel.Font = New Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        infoLabel.Location = New Point(216, 77)
        infoLabel.Name = "infoLabel"
        infoLabel.Size = New Size(501, 48)
        infoLabel.TabIndex = 4
        infoLabel.Text = "Informations sur le contrat"
        ' 
        ' infoContratForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(837, 750)
        Controls.Add(infoLabel)
        Controls.Add(supprimerButton)
        Controls.Add(infoListBox)
        Controls.Add(sortirButton)
        Controls.Add(majButton)
        Margin = New Padding(4, 5, 4, 5)
        Name = "infoContratForm"
        Text = "Info Contrat"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents majButton As Button
    Friend WithEvents sortirButton As Button
    Friend WithEvents infoListBox As ListBox
    Friend WithEvents supprimerButton As Button
    Friend WithEvents infoLabel As Label
End Class
