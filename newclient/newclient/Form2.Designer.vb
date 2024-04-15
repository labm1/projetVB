<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sessionForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sessionForm))
        ouvrirButton = New Button()
        annulerButton = New Button()
        userTextBox = New TextBox()
        mdpTextBox = New TextBox()
        erreurLabel = New Label()
        abonnetLogo = New PictureBox()
        imageBottomRight = New PictureBox()
        imageTopLeft = New PictureBox()
        CType(abonnetLogo, ComponentModel.ISupportInitialize).BeginInit()
        CType(imageBottomRight, ComponentModel.ISupportInitialize).BeginInit()
        CType(imageTopLeft, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ouvrirButton
        ' 
        ouvrirButton.Location = New Point(203, 266)
        ouvrirButton.Name = "ouvrirButton"
        ouvrirButton.Size = New Size(75, 23)
        ouvrirButton.TabIndex = 0
        ouvrirButton.Text = "Connexion"
        ouvrirButton.UseVisualStyleBackColor = True
        ' 
        ' annulerButton
        ' 
        annulerButton.Location = New Point(294, 266)
        annulerButton.Name = "annulerButton"
        annulerButton.Size = New Size(75, 23)
        annulerButton.TabIndex = 1
        annulerButton.Text = "Quitter"
        annulerButton.UseVisualStyleBackColor = True
        ' 
        ' userTextBox
        ' 
        userTextBox.Location = New Point(222, 147)
        userTextBox.Name = "userTextBox"
        userTextBox.PlaceholderText = "Nom d'utilisateur"
        userTextBox.Size = New Size(134, 23)
        userTextBox.TabIndex = 2
        ' 
        ' mdpTextBox
        ' 
        mdpTextBox.Location = New Point(222, 190)
        mdpTextBox.Name = "mdpTextBox"
        mdpTextBox.PlaceholderText = "Mot de passe"
        mdpTextBox.Size = New Size(134, 23)
        mdpTextBox.TabIndex = 3
        mdpTextBox.UseSystemPasswordChar = True
        ' 
        ' erreurLabel
        ' 
        erreurLabel.AutoSize = True
        erreurLabel.ForeColor = Color.Red
        erreurLabel.Location = New Point(203, 237)
        erreurLabel.Margin = New Padding(2, 0, 2, 0)
        erreurLabel.Name = "erreurLabel"
        erreurLabel.Size = New Size(166, 15)
        erreurLabel.TabIndex = 5
        erreurLabel.Text = "Erreur! Ce compte n'existe pas"
        erreurLabel.Visible = False
        ' 
        ' abonnetLogo
        ' 
        abonnetLogo.Image = CType(resources.GetObject("abonnetLogo.Image"), Image)
        abonnetLogo.Location = New Point(161, 67)
        abonnetLogo.Name = "abonnetLogo"
        abonnetLogo.Size = New Size(244, 56)
        abonnetLogo.SizeMode = PictureBoxSizeMode.StretchImage
        abonnetLogo.TabIndex = 6
        abonnetLogo.TabStop = False
        ' 
        ' imageBottomRight
        ' 
        imageBottomRight.Image = CType(resources.GetObject("imageBottomRight.Image"), Image)
        imageBottomRight.Location = New Point(442, 266)
        imageBottomRight.Name = "imageBottomRight"
        imageBottomRight.Size = New Size(143, 56)
        imageBottomRight.SizeMode = PictureBoxSizeMode.StretchImage
        imageBottomRight.TabIndex = 7
        imageBottomRight.TabStop = False
        ' 
        ' imageTopLeft
        ' 
        imageTopLeft.Image = CType(resources.GetObject("imageTopLeft.Image"), Image)
        imageTopLeft.Location = New Point(-1, -1)
        imageTopLeft.Name = "imageTopLeft"
        imageTopLeft.Size = New Size(156, 45)
        imageTopLeft.SizeMode = PictureBoxSizeMode.StretchImage
        imageTopLeft.TabIndex = 8
        imageTopLeft.TabStop = False
        ' 
        ' sessionForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(584, 321)
        Controls.Add(imageTopLeft)
        Controls.Add(imageBottomRight)
        Controls.Add(abonnetLogo)
        Controls.Add(erreurLabel)
        Controls.Add(mdpTextBox)
        Controls.Add(userTextBox)
        Controls.Add(annulerButton)
        Controls.Add(ouvrirButton)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "sessionForm"
        Text = "Abonnet - Écran de connexion"
        CType(abonnetLogo, ComponentModel.ISupportInitialize).EndInit()
        CType(imageBottomRight, ComponentModel.ISupportInitialize).EndInit()
        CType(imageTopLeft, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ouvrirButton As Button
    Friend WithEvents annulerButton As Button
    Friend WithEvents userTextBox As TextBox
    Friend WithEvents mdpTextBox As TextBox
    Friend WithEvents erreurLabel As Label
    Friend WithEvents abonnetLogo As PictureBox
    Friend WithEvents imageBottomRight As PictureBox
    Friend WithEvents imageTopLeft As PictureBox
End Class
