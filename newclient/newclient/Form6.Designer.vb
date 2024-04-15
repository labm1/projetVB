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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(menuForm))
        validationButton = New Button()
        contratButton = New Button()
        equipementButton = New Button()
        progButton = New Button()
        appelButton = New Button()
        formationButton = New Button()
        rapportButton = New Button()
        menuLabel = New Label()
        logoutButton = New Button()
        imageTopLeft = New PictureBox()
        imageBottomRight = New PictureBox()
        abonnetLogo = New PictureBox()
        CType(imageTopLeft, ComponentModel.ISupportInitialize).BeginInit()
        CType(imageBottomRight, ComponentModel.ISupportInitialize).BeginInit()
        CType(abonnetLogo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' validationButton
        ' 
        validationButton.Location = New Point(194, 60)
        validationButton.Margin = New Padding(2)
        validationButton.Name = "validationButton"
        validationButton.Size = New Size(177, 23)
        validationButton.TabIndex = 0
        validationButton.Text = "Validation code client"
        validationButton.UseVisualStyleBackColor = True
        ' 
        ' contratButton
        ' 
        contratButton.Location = New Point(194, 84)
        contratButton.Margin = New Padding(2)
        contratButton.Name = "contratButton"
        contratButton.Size = New Size(177, 23)
        contratButton.TabIndex = 1
        contratButton.Text = "Gestion des contrats"
        contratButton.UseVisualStyleBackColor = True
        ' 
        ' equipementButton
        ' 
        equipementButton.Location = New Point(194, 132)
        equipementButton.Margin = New Padding(2)
        equipementButton.Name = "equipementButton"
        equipementButton.Size = New Size(177, 23)
        equipementButton.TabIndex = 2
        equipementButton.Text = "État des équipements"
        equipementButton.UseVisualStyleBackColor = True
        ' 
        ' progButton
        ' 
        progButton.Location = New Point(194, 156)
        progButton.Margin = New Padding(2)
        progButton.Name = "progButton"
        progButton.Size = New Size(177, 23)
        progButton.TabIndex = 3
        progButton.Text = "Gestion du site web"
        progButton.UseVisualStyleBackColor = True
        ' 
        ' appelButton
        ' 
        appelButton.Location = New Point(194, 108)
        appelButton.Margin = New Padding(2)
        appelButton.Name = "appelButton"
        appelButton.Size = New Size(177, 23)
        appelButton.TabIndex = 4
        appelButton.Text = "Gestion des appels"
        appelButton.UseVisualStyleBackColor = True
        ' 
        ' formationButton
        ' 
        formationButton.Location = New Point(194, 228)
        formationButton.Margin = New Padding(2)
        formationButton.Name = "formationButton"
        formationButton.Size = New Size(177, 23)
        formationButton.TabIndex = 5
        formationButton.Text = "Formations"
        formationButton.UseVisualStyleBackColor = True
        ' 
        ' rapportButton
        ' 
        rapportButton.Location = New Point(194, 204)
        rapportButton.Margin = New Padding(2)
        rapportButton.Name = "rapportButton"
        rapportButton.Size = New Size(177, 23)
        rapportButton.TabIndex = 6
        rapportButton.Text = "Rapports et statistiques"
        rapportButton.UseVisualStyleBackColor = True
        ' 
        ' menuLabel
        ' 
        menuLabel.Font = New Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        menuLabel.Location = New Point(160, 12)
        menuLabel.Margin = New Padding(2, 0, 2, 0)
        menuLabel.Name = "menuLabel"
        menuLabel.Size = New Size(252, 29)
        menuLabel.TabIndex = 7
        menuLabel.Text = "Menu"
        menuLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' logoutButton
        ' 
        logoutButton.Location = New Point(211, 276)
        logoutButton.Margin = New Padding(2)
        logoutButton.Name = "logoutButton"
        logoutButton.Size = New Size(150, 23)
        logoutButton.TabIndex = 8
        logoutButton.Text = "Quitter la session"
        logoutButton.UseVisualStyleBackColor = True
        ' 
        ' imageTopLeft
        ' 
        imageTopLeft.Image = CType(resources.GetObject("imageTopLeft.Image"), Image)
        imageTopLeft.Location = New Point(-1, -1)
        imageTopLeft.Name = "imageTopLeft"
        imageTopLeft.Size = New Size(156, 45)
        imageTopLeft.SizeMode = PictureBoxSizeMode.StretchImage
        imageTopLeft.TabIndex = 11
        imageTopLeft.TabStop = False
        ' 
        ' imageBottomRight
        ' 
        imageBottomRight.Image = CType(resources.GetObject("imageBottomRight.Image"), Image)
        imageBottomRight.Location = New Point(442, 266)
        imageBottomRight.Name = "imageBottomRight"
        imageBottomRight.Size = New Size(143, 56)
        imageBottomRight.SizeMode = PictureBoxSizeMode.StretchImage
        imageBottomRight.TabIndex = 10
        imageBottomRight.TabStop = False
        ' 
        ' abonnetLogo
        ' 
        abonnetLogo.Image = CType(resources.GetObject("abonnetLogo.Image"), Image)
        abonnetLogo.Location = New Point(456, 12)
        abonnetLogo.Name = "abonnetLogo"
        abonnetLogo.Size = New Size(116, 25)
        abonnetLogo.SizeMode = PictureBoxSizeMode.StretchImage
        abonnetLogo.TabIndex = 9
        abonnetLogo.TabStop = False
        ' 
        ' menuForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(584, 321)
        Controls.Add(imageTopLeft)
        Controls.Add(imageBottomRight)
        Controls.Add(abonnetLogo)
        Controls.Add(logoutButton)
        Controls.Add(menuLabel)
        Controls.Add(rapportButton)
        Controls.Add(formationButton)
        Controls.Add(appelButton)
        Controls.Add(progButton)
        Controls.Add(equipementButton)
        Controls.Add(contratButton)
        Controls.Add(validationButton)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(2)
        Name = "menuForm"
        Text = "Abonnet - Menu"
        CType(imageTopLeft, ComponentModel.ISupportInitialize).EndInit()
        CType(imageBottomRight, ComponentModel.ISupportInitialize).EndInit()
        CType(abonnetLogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
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
    Friend WithEvents imageTopLeft As PictureBox
    Friend WithEvents imageBottomRight As PictureBox
    Friend WithEvents abonnetLogo As PictureBox
End Class
