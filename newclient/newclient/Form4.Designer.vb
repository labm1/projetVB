<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        ListBox1 = New ListBox()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Microsoft Sans Serif", 8.25F)
        Button1.Location = New Point(117, 388)
        Button1.Name = "Button1"
        Button1.Size = New Size(111, 23)
        Button1.TabIndex = 0
        Button1.Text = "mettre a jour"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Microsoft Sans Serif", 8.25F)
        Button2.Location = New Point(462, 388)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 1
        Button2.Text = "sortir"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' ListBox1
        ' 
        ListBox1.Font = New Font("Microsoft Sans Serif", 8.25F)
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 13
        ListBox1.Location = New Point(117, 93)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(420, 264)
        ListBox1.TabIndex = 2
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Microsoft Sans Serif", 8.25F)
        Button3.Location = New Point(294, 388)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 23)
        Button3.TabIndex = 3
        Button3.Text = "suprimer"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(586, 450)
        Controls.Add(Button3)
        Controls.Add(ListBox1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Form4"
        Text = "info contrat"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button3 As Button
End Class
