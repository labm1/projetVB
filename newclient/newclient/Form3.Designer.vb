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
        creerButton = New Button()
        creerLabel = New Label()
        contratComboBox = New ComboBox()
        contratLabel = New Label()
        choisirButton = New Button()
        menuButton = New Button()
        nomMenuLabel = New Label()
        SuspendLayout()
        ' 
        ' creerButton
        ' 
        creerButton.Font = New Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        creerButton.Location = New Point(93, 408)
        creerButton.Margin = New Padding(4, 5, 4, 5)
        creerButton.Name = "creerButton"
        creerButton.Size = New Size(108, 38)
        creerButton.TabIndex = 0
        creerButton.Text = "Créer"
        creerButton.UseVisualStyleBackColor = True
        ' 
        ' creerLabel
        ' 
        creerLabel.AutoSize = True
        creerLabel.Font = New Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        creerLabel.Location = New Point(93, 347)
        creerLabel.Margin = New Padding(4, 0, 4, 0)
        creerLabel.Name = "creerLabel"
        creerLabel.Size = New Size(189, 20)
        creerLabel.TabIndex = 1
        creerLabel.Text = "Créer un nouveau contrat"
        ' 
        ' contratComboBox
        ' 
        contratComboBox.Font = New Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        contratComboBox.FormattingEnabled = True
        contratComboBox.Location = New Point(94, 135)
        contratComboBox.Margin = New Padding(4, 5, 4, 5)
        contratComboBox.Name = "contratComboBox"
        contratComboBox.Size = New Size(171, 28)
        contratComboBox.TabIndex = 2
        contratComboBox.Text = "nom des contrats"
        ' 
        ' contratLabel
        ' 
        contratLabel.AutoSize = True
        contratLabel.Font = New Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        contratLabel.Location = New Point(93, 73)
        contratLabel.Margin = New Padding(4, 0, 4, 0)
        contratLabel.Name = "contratLabel"
        contratLabel.Size = New Size(137, 20)
        contratLabel.TabIndex = 3
        contratLabel.Text = "Contrats existants"
        ' 
        ' choisirButton
        ' 
        choisirButton.Font = New Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        choisirButton.Location = New Point(94, 202)
        choisirButton.Margin = New Padding(4, 5, 4, 5)
        choisirButton.Name = "choisirButton"
        choisirButton.Size = New Size(107, 38)
        choisirButton.TabIndex = 4
        choisirButton.Text = "Choisir"
        choisirButton.UseVisualStyleBackColor = True
        ' 
        ' menuButton
        ' 
        menuButton.Font = New Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        menuButton.Location = New Point(93, 537)
        menuButton.Margin = New Padding(4, 5, 4, 5)
        menuButton.Name = "menuButton"
        menuButton.Size = New Size(108, 38)
        menuButton.TabIndex = 5
        menuButton.Text = "Menu"
        menuButton.UseVisualStyleBackColor = True
        ' 
        ' nomMenuLabel
        ' 
        nomMenuLabel.AutoSize = True
        nomMenuLabel.Location = New Point(528, 564)
        nomMenuLabel.Name = "nomMenuLabel"
        nomMenuLabel.Size = New Size(0, 25)
        nomMenuLabel.TabIndex = 6
        nomMenuLabel.Visible = False
        ' 
        ' gestionContratForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(620, 607)
        Controls.Add(nomMenuLabel)
        Controls.Add(menuButton)
        Controls.Add(choisirButton)
        Controls.Add(contratLabel)
        Controls.Add(contratComboBox)
        Controls.Add(creerLabel)
        Controls.Add(creerButton)
        Margin = New Padding(4, 5, 4, 5)
        Name = "gestionContratForm"
        Text = "Gestion de Contrats"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents creerButton As Button
    Friend WithEvents creerLabel As Label
    Friend WithEvents contratComboBox As ComboBox
    Friend WithEvents contratLabel As Label
    Friend WithEvents choisirButton As Button
    Friend WithEvents menuButton As Button
    Friend WithEvents nomMenuLabel As Label
End Class
