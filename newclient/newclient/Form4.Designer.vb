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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(infoContratForm))
        majButton = New Button()
        sortirButton = New Button()
        infoListBox = New ListBox()
        supprimerButton = New Button()
        infoLabel = New Label()
        imageTopLeft = New PictureBox()
        imageBottomRight = New PictureBox()
        abonnetLogo = New PictureBox()
        CType(imageTopLeft, ComponentModel.ISupportInitialize).BeginInit()
        CType(imageBottomRight, ComponentModel.ISupportInitialize).BeginInit()
        CType(abonnetLogo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' majButton
        ' 
        majButton.Font = New Font("Microsoft Sans Serif", 8.25F)
        majButton.Location = New Point(395, 124)
        majButton.Name = "majButton"
        majButton.Size = New Size(130, 23)
        majButton.TabIndex = 0
        majButton.Text = "Mettre à jour le contrat"
        majButton.UseVisualStyleBackColor = True
        ' 
        ' sortirButton
        ' 
        sortirButton.Font = New Font("Microsoft Sans Serif", 8.25F)
        sortirButton.Location = New Point(395, 182)
        sortirButton.Name = "sortirButton"
        sortirButton.Size = New Size(130, 23)
        sortirButton.TabIndex = 1
        sortirButton.Text = "Retour au menu"
        sortirButton.UseVisualStyleBackColor = True
        ' 
        ' infoListBox
        ' 
        infoListBox.Font = New Font("Microsoft Sans Serif", 8.25F)
        infoListBox.FormattingEnabled = True
        infoListBox.ItemHeight = 13
        infoListBox.Items.AddRange(New Object() {"Numéro de contrat : ", "Nom : ", "Type de client : ", "Date de début : ", "Date de fin : ", "Équipement loué : ", "Nombre d'équipement loué : ", "", "Fréquence des paiements : ", "Frais de locations total : ", "Frais de locations payés : ", "Pourcentage de taxes : ", "", "Dernier paiement : ", "Type de paiement : "})
        infoListBox.Location = New Point(66, 91)
        infoListBox.Name = "infoListBox"
        infoListBox.Size = New Size(285, 212)
        infoListBox.TabIndex = 2
        ' 
        ' supprimerButton
        ' 
        supprimerButton.Font = New Font("Microsoft Sans Serif", 8.25F)
        supprimerButton.Location = New Point(395, 153)
        supprimerButton.Name = "supprimerButton"
        supprimerButton.Size = New Size(130, 23)
        supprimerButton.TabIndex = 3
        supprimerButton.Text = "Supprimer"
        supprimerButton.UseVisualStyleBackColor = True
        ' 
        ' infoLabel
        ' 
        infoLabel.Font = New Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        infoLabel.Location = New Point(200, 7)
        infoLabel.Margin = New Padding(2, 0, 2, 0)
        infoLabel.Name = "infoLabel"
        infoLabel.Size = New Size(181, 71)
        infoLabel.TabIndex = 4
        infoLabel.Text = "Informations sur le contrat"
        infoLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' imageTopLeft
        ' 
        imageTopLeft.Image = CType(resources.GetObject("imageTopLeft.Image"), Image)
        imageTopLeft.Location = New Point(-1, -1)
        imageTopLeft.Name = "imageTopLeft"
        imageTopLeft.Size = New Size(156, 45)
        imageTopLeft.SizeMode = PictureBoxSizeMode.StretchImage
        imageTopLeft.TabIndex = 14
        imageTopLeft.TabStop = False
        ' 
        ' imageBottomRight
        ' 
        imageBottomRight.Image = CType(resources.GetObject("imageBottomRight.Image"), Image)
        imageBottomRight.Location = New Point(442, 266)
        imageBottomRight.Name = "imageBottomRight"
        imageBottomRight.Size = New Size(143, 56)
        imageBottomRight.SizeMode = PictureBoxSizeMode.StretchImage
        imageBottomRight.TabIndex = 13
        imageBottomRight.TabStop = False
        ' 
        ' abonnetLogo
        ' 
        abonnetLogo.Image = CType(resources.GetObject("abonnetLogo.Image"), Image)
        abonnetLogo.Location = New Point(456, 12)
        abonnetLogo.Name = "abonnetLogo"
        abonnetLogo.Size = New Size(116, 25)
        abonnetLogo.SizeMode = PictureBoxSizeMode.StretchImage
        abonnetLogo.TabIndex = 12
        abonnetLogo.TabStop = False
        ' 
        ' infoContratForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(584, 321)
        Controls.Add(imageTopLeft)
        Controls.Add(imageBottomRight)
        Controls.Add(abonnetLogo)
        Controls.Add(infoLabel)
        Controls.Add(supprimerButton)
        Controls.Add(infoListBox)
        Controls.Add(sortirButton)
        Controls.Add(majButton)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "infoContratForm"
        Text = "Abonnet - Informations sur le contrat"
        CType(imageTopLeft, ComponentModel.ISupportInitialize).EndInit()
        CType(imageBottomRight, ComponentModel.ISupportInitialize).EndInit()
        CType(abonnetLogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents majButton As Button
    Friend WithEvents sortirButton As Button
    Friend WithEvents infoListBox As ListBox
    Friend WithEvents supprimerButton As Button
    Friend WithEvents infoLabel As Label
    Friend WithEvents imageTopLeft As PictureBox
    Friend WithEvents imageBottomRight As PictureBox
    Friend WithEvents abonnetLogo As PictureBox
End Class
