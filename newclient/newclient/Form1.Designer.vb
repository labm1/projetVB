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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(clientForm))
        typeClientComboBox = New ComboBox()
        nomTextBox = New TextBox()
        tempsTextBox = New TextBox()
        creerButton = New Button()
        annulerButton = New Button()
        frequenceComboBox = New ComboBox()
        equipementComboBox = New ComboBox()
        nbComboBox = New ComboBox()
        infoLabel = New Label()
        imageTopLeft = New PictureBox()
        imageBottomRight = New PictureBox()
        abonnetLogo = New PictureBox()
        nbLabel = New Label()
        equipementLabel = New Label()
        frequenceLabel = New Label()
        tempsLabel = New Label()
        typeClientLabel = New Label()
        nomLabel = New Label()
        CType(imageTopLeft, ComponentModel.ISupportInitialize).BeginInit()
        CType(imageBottomRight, ComponentModel.ISupportInitialize).BeginInit()
        CType(abonnetLogo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' typeClientComboBox
        ' 
        typeClientComboBox.Font = New Font("Microsoft Sans Serif", 8.25F)
        typeClientComboBox.FormattingEnabled = True
        typeClientComboBox.Items.AddRange(New Object() {"Civil", "Commercial"})
        typeClientComboBox.Location = New Point(202, 96)
        typeClientComboBox.Name = "typeClientComboBox"
        typeClientComboBox.Size = New Size(185, 21)
        typeClientComboBox.TabIndex = 2
        ' 
        ' nomTextBox
        ' 
        nomTextBox.Font = New Font("Microsoft Sans Serif", 8.25F)
        nomTextBox.Location = New Point(202, 66)
        nomTextBox.Name = "nomTextBox"
        nomTextBox.Size = New Size(185, 20)
        nomTextBox.TabIndex = 3
        ' 
        ' tempsTextBox
        ' 
        tempsTextBox.Font = New Font("Microsoft Sans Serif", 8.25F)
        tempsTextBox.Location = New Point(202, 126)
        tempsTextBox.Name = "tempsTextBox"
        tempsTextBox.Size = New Size(185, 20)
        tempsTextBox.TabIndex = 5
        ' 
        ' creerButton
        ' 
        creerButton.Font = New Font("Microsoft Sans Serif", 8.25F)
        creerButton.Location = New Point(207, 255)
        creerButton.Name = "creerButton"
        creerButton.Size = New Size(75, 23)
        creerButton.TabIndex = 6
        creerButton.Text = "Créer"
        creerButton.UseVisualStyleBackColor = True
        ' 
        ' annulerButton
        ' 
        annulerButton.Font = New Font("Microsoft Sans Serif", 8.25F)
        annulerButton.Location = New Point(306, 255)
        annulerButton.Name = "annulerButton"
        annulerButton.Size = New Size(75, 23)
        annulerButton.TabIndex = 7
        annulerButton.Text = "Annuler"
        annulerButton.UseVisualStyleBackColor = True
        ' 
        ' frequenceComboBox
        ' 
        frequenceComboBox.Font = New Font("Microsoft Sans Serif", 8.25F)
        frequenceComboBox.FormattingEnabled = True
        frequenceComboBox.Items.AddRange(New Object() {"Annuel", "Mensuel"})
        frequenceComboBox.Location = New Point(202, 156)
        frequenceComboBox.Name = "frequenceComboBox"
        frequenceComboBox.Size = New Size(185, 21)
        frequenceComboBox.TabIndex = 9
        ' 
        ' equipementComboBox
        ' 
        equipementComboBox.Font = New Font("Microsoft Sans Serif", 8.25F)
        equipementComboBox.FormattingEnabled = True
        equipementComboBox.Items.AddRange(New Object() {"Modem", "Ligne Internet", "Micro-Ordinateur"})
        equipementComboBox.Location = New Point(202, 186)
        equipementComboBox.Name = "equipementComboBox"
        equipementComboBox.Size = New Size(185, 21)
        equipementComboBox.TabIndex = 11
        ' 
        ' nbComboBox
        ' 
        nbComboBox.Font = New Font("Microsoft Sans Serif", 8.25F)
        nbComboBox.FormattingEnabled = True
        nbComboBox.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        nbComboBox.Location = New Point(202, 216)
        nbComboBox.Name = "nbComboBox"
        nbComboBox.Size = New Size(185, 21)
        nbComboBox.TabIndex = 13
        ' 
        ' infoLabel
        ' 
        infoLabel.Font = New Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        infoLabel.Location = New Point(160, 9)
        infoLabel.Margin = New Padding(2, 0, 2, 0)
        infoLabel.Name = "infoLabel"
        infoLabel.Size = New Size(273, 51)
        infoLabel.TabIndex = 41
        infoLabel.Text = "Nouveau client"
        infoLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' imageTopLeft
        ' 
        imageTopLeft.Image = CType(resources.GetObject("imageTopLeft.Image"), Image)
        imageTopLeft.Location = New Point(-1, -1)
        imageTopLeft.Name = "imageTopLeft"
        imageTopLeft.Size = New Size(156, 45)
        imageTopLeft.SizeMode = PictureBoxSizeMode.StretchImage
        imageTopLeft.TabIndex = 40
        imageTopLeft.TabStop = False
        ' 
        ' imageBottomRight
        ' 
        imageBottomRight.Image = CType(resources.GetObject("imageBottomRight.Image"), Image)
        imageBottomRight.Location = New Point(442, 266)
        imageBottomRight.Name = "imageBottomRight"
        imageBottomRight.Size = New Size(143, 56)
        imageBottomRight.SizeMode = PictureBoxSizeMode.StretchImage
        imageBottomRight.TabIndex = 39
        imageBottomRight.TabStop = False
        ' 
        ' abonnetLogo
        ' 
        abonnetLogo.Image = CType(resources.GetObject("abonnetLogo.Image"), Image)
        abonnetLogo.Location = New Point(456, 12)
        abonnetLogo.Name = "abonnetLogo"
        abonnetLogo.Size = New Size(116, 25)
        abonnetLogo.SizeMode = PictureBoxSizeMode.StretchImage
        abonnetLogo.TabIndex = 38
        abonnetLogo.TabStop = False
        ' 
        ' nbLabel
        ' 
        nbLabel.Font = New Font("Microsoft Sans Serif", 8.25F)
        nbLabel.Location = New Point(71, 216)
        nbLabel.Name = "nbLabel"
        nbLabel.Size = New Size(130, 21)
        nbLabel.TabIndex = 37
        nbLabel.Text = "Nombre d'équipement"
        nbLabel.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' equipementLabel
        ' 
        equipementLabel.Font = New Font("Microsoft Sans Serif", 8.25F)
        equipementLabel.Location = New Point(71, 186)
        equipementLabel.Name = "equipementLabel"
        equipementLabel.Size = New Size(130, 21)
        equipementLabel.TabIndex = 36
        equipementLabel.Text = "Équipement"
        equipementLabel.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' frequenceLabel
        ' 
        frequenceLabel.Font = New Font("Microsoft Sans Serif", 8.25F)
        frequenceLabel.Location = New Point(71, 156)
        frequenceLabel.Name = "frequenceLabel"
        frequenceLabel.Size = New Size(130, 21)
        frequenceLabel.TabIndex = 35
        frequenceLabel.Text = "Fréquence de paiement"
        frequenceLabel.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' tempsLabel
        ' 
        tempsLabel.Font = New Font("Microsoft Sans Serif", 8.25F)
        tempsLabel.Location = New Point(71, 126)
        tempsLabel.Name = "tempsLabel"
        tempsLabel.Size = New Size(130, 20)
        tempsLabel.TabIndex = 34
        tempsLabel.Text = "Temps désiré"
        tempsLabel.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' typeClientLabel
        ' 
        typeClientLabel.Font = New Font("Microsoft Sans Serif", 8.25F)
        typeClientLabel.Location = New Point(71, 96)
        typeClientLabel.Name = "typeClientLabel"
        typeClientLabel.Size = New Size(130, 21)
        typeClientLabel.TabIndex = 33
        typeClientLabel.Text = "Type de client"
        typeClientLabel.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' nomLabel
        ' 
        nomLabel.Font = New Font("Microsoft Sans Serif", 8.25F)
        nomLabel.Location = New Point(71, 66)
        nomLabel.Name = "nomLabel"
        nomLabel.Size = New Size(130, 20)
        nomLabel.TabIndex = 32
        nomLabel.Text = "Nom du client"
        nomLabel.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' clientForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(584, 321)
        Controls.Add(infoLabel)
        Controls.Add(imageTopLeft)
        Controls.Add(imageBottomRight)
        Controls.Add(abonnetLogo)
        Controls.Add(nbLabel)
        Controls.Add(equipementLabel)
        Controls.Add(frequenceLabel)
        Controls.Add(tempsLabel)
        Controls.Add(typeClientLabel)
        Controls.Add(nomLabel)
        Controls.Add(nbComboBox)
        Controls.Add(equipementComboBox)
        Controls.Add(frequenceComboBox)
        Controls.Add(annulerButton)
        Controls.Add(creerButton)
        Controls.Add(tempsTextBox)
        Controls.Add(nomTextBox)
        Controls.Add(typeClientComboBox)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "clientForm"
        Text = "Abonnet - Nouveau client"
        CType(imageTopLeft, ComponentModel.ISupportInitialize).EndInit()
        CType(imageBottomRight, ComponentModel.ISupportInitialize).EndInit()
        CType(abonnetLogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents typeClientComboBox As ComboBox
    Friend WithEvents nomTextBox As TextBox
    Friend WithEvents tempsTextBox As TextBox
    Friend WithEvents creerButton As Button
    Friend WithEvents annulerButton As Button
    Friend WithEvents frequenceComboBox As ComboBox
    Friend WithEvents equipementComboBox As ComboBox
    Friend WithEvents nbComboBox As ComboBox
    Friend WithEvents infoLabel As Label
    Friend WithEvents imageTopLeft As PictureBox
    Friend WithEvents imageBottomRight As PictureBox
    Friend WithEvents abonnetLogo As PictureBox
    Friend WithEvents nbLabel As Label
    Friend WithEvents equipementLabel As Label
    Friend WithEvents frequenceLabel As Label
    Friend WithEvents tempsLabel As Label
    Friend WithEvents typeClientLabel As Label
    Friend WithEvents nomLabel As Label

End Class
