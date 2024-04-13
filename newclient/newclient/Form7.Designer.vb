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
        TextBox1 = New TextBox()
        verifierButton = New Button()
        menuButton = New Button()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(256, 156)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "XXXX-XXXX-XXXX-XXXX"
        TextBox1.Size = New Size(211, 31)
        TextBox1.TabIndex = 0
        ' 
        ' verifierButton
        ' 
        verifierButton.Location = New Point(183, 229)
        verifierButton.Name = "verifierButton"
        verifierButton.Size = New Size(112, 34)
        verifierButton.TabIndex = 1
        verifierButton.Text = "Vérifier"
        verifierButton.UseVisualStyleBackColor = True
        ' 
        ' menuButton
        ' 
        menuButton.Location = New Point(439, 229)
        menuButton.Name = "menuButton"
        menuButton.Size = New Size(112, 34)
        menuButton.TabIndex = 2
        menuButton.Text = "Menu"
        menuButton.UseVisualStyleBackColor = True
        ' 
        ' validationForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(menuButton)
        Controls.Add(verifierButton)
        Controls.Add(TextBox1)
        Name = "validationForm"
        Text = "Validation de code"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents verifierButton As Button
    Friend WithEvents menuButton As Button
End Class
