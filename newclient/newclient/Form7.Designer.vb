<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class validationForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(validationForm))
        TextBox1 = New TextBox()
        verifierButton = New Button()
        menuButton = New Button()
        imageTopLeft = New PictureBox()
        imageBottomRight = New PictureBox()
        abonnetLogo = New PictureBox()
        infoLabel = New Label()
        CType(imageTopLeft, ComponentModel.ISupportInitialize).BeginInit()
        CType(imageBottomRight, ComponentModel.ISupportInitialize).BeginInit()
        CType(abonnetLogo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(189, 109)
        TextBox1.Margin = New Padding(2)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "XXXX-XXXX-XXXX-XXXX"
        TextBox1.Size = New Size(202, 23)
        TextBox1.TabIndex = 0
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' verifierButton
        ' 
        verifierButton.Location = New Point(227, 165)
        verifierButton.Margin = New Padding(2)
        verifierButton.Name = "verifierButton"
        verifierButton.Size = New Size(130, 23)
        verifierButton.TabIndex = 1
        verifierButton.Text = "Vérifier le code client"
        verifierButton.UseVisualStyleBackColor = True
        ' 
        ' menuButton
        ' 
        menuButton.Location = New Point(227, 201)
        menuButton.Margin = New Padding(2)
        menuButton.Name = "menuButton"
        menuButton.Size = New Size(130, 23)
        menuButton.TabIndex = 2
        menuButton.Text = "Retour au menu"
        menuButton.UseVisualStyleBackColor = True
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
        ' infoLabel
        ' 
        infoLabel.Font = New Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        infoLabel.Location = New Point(189, 21)
        infoLabel.Margin = New Padding(2, 0, 2, 0)
        infoLabel.Name = "infoLabel"
        infoLabel.Size = New Size(202, 71)
        infoLabel.TabIndex = 15
        infoLabel.Text = "Validation du code client"
        infoLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' validationForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(584, 321)
        Controls.Add(infoLabel)
        Controls.Add(imageTopLeft)
        Controls.Add(imageBottomRight)
        Controls.Add(abonnetLogo)
        Controls.Add(menuButton)
        Controls.Add(verifierButton)
        Controls.Add(TextBox1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(2)
        Name = "validationForm"
        Text = "Abonnet - Validation de code"
        CType(imageTopLeft, ComponentModel.ISupportInitialize).EndInit()
        CType(imageBottomRight, ComponentModel.ISupportInitialize).EndInit()
        CType(abonnetLogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents verifierButton As Button
    Friend WithEvents menuButton As Button
    Friend WithEvents imageTopLeft As PictureBox
    Friend WithEvents imageBottomRight As PictureBox
    Friend WithEvents abonnetLogo As PictureBox
    Friend WithEvents infoLabel As Label
End Class
