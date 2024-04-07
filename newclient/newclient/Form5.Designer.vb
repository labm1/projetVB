<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Button2 = New Button()
        Label1 = New Label()
        TextBox1 = New TextBox()
        TextBox3 = New TextBox()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(150, 412)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 0
        Button1.Text = "confirmer"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(288, 412)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 1
        Button2.Text = "annule"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 66)
        Label1.Name = "Label1"
        Label1.Size = New Size(81, 15)
        Label1.TabIndex = 2
        Label1.Text = "nom du client"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(150, 58)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 3
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(150, 197)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(100, 23)
        TextBox3.TabIndex = 5
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(150, 118)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 23)
        ComboBox1.TabIndex = 6
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(150, 278)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(121, 23)
        ComboBox2.TabIndex = 7
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 126)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 15)
        Label2.TabIndex = 8
        Label2.Text = "type de client"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 200)
        Label3.Name = "Label3"
        Label3.Size = New Size(40, 15)
        Label3.TabIndex = 9
        Label3.Text = "temps"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 278)
        Label4.Name = "Label4"
        Label4.Size = New Size(87, 15)
        Label4.TabIndex = 10
        Label4.Text = "type de contrat"
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(420, 478)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(TextBox3)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Form5"
        Text = "mise a jour contrat"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
