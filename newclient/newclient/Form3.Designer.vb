<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gestionContratForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(gestionContratForm))
        creerButton = New Button()
        creerLabel = New Label()
        contratComboBox = New ComboBox()
        contratLabel = New Label()
        choisirButton = New Button()
        menuButton = New Button()
        infoLabel = New Label()
        imageTopLeft = New PictureBox()
        imageBottomRight = New PictureBox()
        abonnetLogo = New PictureBox()
        CType(imageTopLeft, ComponentModel.ISupportInitialize).BeginInit()
        CType(imageBottomRight, ComponentModel.ISupportInitialize).BeginInit()
        CType(abonnetLogo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' creerButton
        ' 
        creerButton.Font = New Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        creerButton.Location = New Point(255, 210)
        creerButton.Name = "creerButton"
        creerButton.Size = New Size(75, 23)
        creerButton.TabIndex = 0
        creerButton.Text = "Créer"
        creerButton.UseVisualStyleBackColor = True
        ' 
        ' creerLabel
        ' 
        creerLabel.AutoSize = True
        creerLabel.Font = New Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        creerLabel.Location = New Point(227, 187)
        creerLabel.Name = "creerLabel"
        creerLabel.Size = New Size(128, 13)
        creerLabel.TabIndex = 1
        creerLabel.Text = "Créer un nouveau contrat"
        creerLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' contratComboBox
        ' 
        contratComboBox.Font = New Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        contratComboBox.FormattingEnabled = True
        contratComboBox.Location = New Point(230, 101)
        contratComboBox.Name = "contratComboBox"
        contratComboBox.Size = New Size(121, 21)
        contratComboBox.TabIndex = 2
        contratComboBox.Text = "Nom des contrats"
        ' 
        ' contratLabel
        ' 
        contratLabel.AutoSize = True
        contratLabel.Font = New Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        contratLabel.Location = New Point(246, 75)
        contratLabel.Name = "contratLabel"
        contratLabel.Size = New Size(90, 13)
        contratLabel.TabIndex = 3
        contratLabel.Text = "Contrats existants"
        contratLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' choisirButton
        ' 
        choisirButton.Font = New Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        choisirButton.Location = New Point(255, 132)
        choisirButton.Name = "choisirButton"
        choisirButton.Size = New Size(75, 23)
        choisirButton.TabIndex = 4
        choisirButton.Text = "Choisir"
        choisirButton.UseVisualStyleBackColor = True
        ' 
        ' menuButton
        ' 
        menuButton.Font = New Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        menuButton.Location = New Point(229, 272)
        menuButton.Name = "menuButton"
        menuButton.Size = New Size(130, 23)
        menuButton.TabIndex = 5
        menuButton.Text = "Retour au menu"
        menuButton.UseVisualStyleBackColor = True
        ' 
        ' infoLabel
        ' 
        infoLabel.Font = New Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        infoLabel.Location = New Point(160, 9)
        infoLabel.Margin = New Padding(2, 0, 2, 0)
        infoLabel.Name = "infoLabel"
        infoLabel.Size = New Size(273, 51)
        infoLabel.TabIndex = 45
        infoLabel.Text = "Gestion des contrats"
        infoLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' imageTopLeft
        ' 
        imageTopLeft.Image = CType(resources.GetObject("imageTopLeft.Image"), Image)
        imageTopLeft.Location = New Point(-1, -1)
        imageTopLeft.Name = "imageTopLeft"
        imageTopLeft.Size = New Size(156, 45)
        imageTopLeft.SizeMode = PictureBoxSizeMode.StretchImage
        imageTopLeft.TabIndex = 44
        imageTopLeft.TabStop = False
        ' 
        ' imageBottomRight
        ' 
        imageBottomRight.Image = CType(resources.GetObject("imageBottomRight.Image"), Image)
        imageBottomRight.Location = New Point(442, 266)
        imageBottomRight.Name = "imageBottomRight"
        imageBottomRight.Size = New Size(143, 56)
        imageBottomRight.SizeMode = PictureBoxSizeMode.StretchImage
        imageBottomRight.TabIndex = 43
        imageBottomRight.TabStop = False
        ' 
        ' abonnetLogo
        ' 
        abonnetLogo.Image = CType(resources.GetObject("abonnetLogo.Image"), Image)
        abonnetLogo.Location = New Point(456, 12)
        abonnetLogo.Name = "abonnetLogo"
        abonnetLogo.Size = New Size(116, 25)
        abonnetLogo.SizeMode = PictureBoxSizeMode.StretchImage
        abonnetLogo.TabIndex = 42
        abonnetLogo.TabStop = False
        ' 
        ' gestionContratForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(584, 321)
        Controls.Add(infoLabel)
        Controls.Add(imageTopLeft)
        Controls.Add(imageBottomRight)
        Controls.Add(abonnetLogo)
        Controls.Add(menuButton)
        Controls.Add(choisirButton)
        Controls.Add(contratLabel)
        Controls.Add(contratComboBox)
        Controls.Add(creerLabel)
        Controls.Add(creerButton)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "gestionContratForm"
        Text = "Abonnet - Gestion des contrats"
        CType(imageTopLeft, ComponentModel.ISupportInitialize).EndInit()
        CType(imageBottomRight, ComponentModel.ISupportInitialize).EndInit()
        CType(abonnetLogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents creerButton As Button
    Friend WithEvents creerLabel As Label
    Friend WithEvents contratComboBox As ComboBox
    Friend WithEvents contratLabel As Label
    Friend WithEvents choisirButton As Button
    Friend WithEvents menuButton As Button
    Friend WithEvents infoLabel As Label
    Friend WithEvents imageTopLeft As PictureBox
    Friend WithEvents imageBottomRight As PictureBox
    Friend WithEvents abonnetLogo As PictureBox
End Class
