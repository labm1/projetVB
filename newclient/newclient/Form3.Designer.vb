<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Button1 = New Button()
        Label1 = New Label()
        ComboBox1 = New ComboBox()
        Label2 = New Label()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Ink Free", 9F)
        Button1.Location = New Point(65, 245)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 0
        Button1.Text = "creer nouveau contrat"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Ink Free", 9F)
        Label1.Location = New Point(65, 208)
        Label1.Name = "Label1"
        Label1.Size = New Size(118, 15)
        Label1.TabIndex = 1
        Label1.Text = "creer nouveau contrat"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Ink Free", 9F)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(66, 81)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 23)
        ComboBox1.TabIndex = 2
        ComboBox1.Text = "nom des contrat"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Ink Free", 9F)
        Label2.Location = New Point(65, 44)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 15)
        Label2.TabIndex = 3
        Label2.Text = "contrat existant"
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Ink Free", 9F)
        Button2.Location = New Point(66, 121)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 4
        Button2.Text = "choisis"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(434, 454)
        Controls.Add(Button2)
        Controls.Add(Label2)
        Controls.Add(ComboBox1)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Name = "Form3"
        Text = "gestion de contrat"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
End Class
