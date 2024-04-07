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
        ouvrirButton = New Button()
        annulerButton = New Button()
        userTextBox = New TextBox()
        mdpTextBox = New TextBox()
        abonnetLabel = New Label()
        erreurLabel = New Label()
        SuspendLayout()
        ' 
        ' ouvrirButton
        ' 
        ouvrirButton.Location = New Point(228, 447)
        ouvrirButton.Margin = New Padding(4, 5, 4, 5)
        ouvrirButton.Name = "ouvrirButton"
        ouvrirButton.Size = New Size(107, 38)
        ouvrirButton.TabIndex = 0
        ouvrirButton.Text = "Ouvrir"
        ouvrirButton.UseVisualStyleBackColor = True
        ' 
        ' annulerButton
        ' 
        annulerButton.Location = New Point(388, 447)
        annulerButton.Margin = New Padding(4, 5, 4, 5)
        annulerButton.Name = "annulerButton"
        annulerButton.Size = New Size(107, 38)
        annulerButton.TabIndex = 1
        annulerButton.Text = "Annuler"
        annulerButton.UseVisualStyleBackColor = True
        ' 
        ' userTextBox
        ' 
        userTextBox.Location = New Point(269, 205)
        userTextBox.Margin = New Padding(4, 5, 4, 5)
        userTextBox.Name = "userTextBox"
        userTextBox.PlaceholderText = "Nom d'utilisateur"
        userTextBox.Size = New Size(190, 31)
        userTextBox.TabIndex = 2
        ' 
        ' mdpTextBox
        ' 
        mdpTextBox.Location = New Point(269, 310)
        mdpTextBox.Margin = New Padding(4, 5, 4, 5)
        mdpTextBox.Name = "mdpTextBox"
        mdpTextBox.PlaceholderText = "Mot de passe"
        mdpTextBox.Size = New Size(190, 31)
        mdpTextBox.TabIndex = 3
        mdpTextBox.UseSystemPasswordChar = True
        ' 
        ' abonnetLabel
        ' 
        abonnetLabel.AutoSize = True
        abonnetLabel.Font = New Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        abonnetLabel.Location = New Point(254, 61)
        abonnetLabel.Name = "abonnetLabel"
        abonnetLabel.Size = New Size(223, 54)
        abonnetLabel.TabIndex = 4
        abonnetLabel.Text = "ABONNET"
        ' 
        ' erreurLabel
        ' 
        erreurLabel.AutoSize = True
        erreurLabel.ForeColor = Color.Red
        erreurLabel.Location = New Point(228, 387)
        erreurLabel.Name = "erreurLabel"
        erreurLabel.Size = New Size(250, 25)
        erreurLabel.TabIndex = 5
        erreurLabel.Text = "Erreur! Ce compte n'existe pas"
        erreurLabel.Visible = False
        ' 
        ' sessionForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(777, 587)
        Controls.Add(erreurLabel)
        Controls.Add(abonnetLabel)
        Controls.Add(mdpTextBox)
        Controls.Add(userTextBox)
        Controls.Add(annulerButton)
        Controls.Add(ouvrirButton)
        Margin = New Padding(4, 5, 4, 5)
        Name = "sessionForm"
        Text = "Nouvelle Session"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ouvrirButton As Button
    Friend WithEvents annulerButton As Button
    Friend WithEvents userTextBox As TextBox
    Friend WithEvents mdpTextBox As TextBox
    Friend WithEvents abonnetLabel As Label
    Friend WithEvents erreurLabel As Label
End Class
