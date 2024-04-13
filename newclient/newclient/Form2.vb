Imports System.Diagnostics.Eventing.Reader

Public Class sessionForm

    Private Sub ouvrirButton_Click(sender As Object, e As EventArgs) Handles ouvrirButton.Click
        If userTextBox.Text = "gerant" Or userTextBox.Text = "conseiller" Or userTextBox.Text = "ti" Or userTextBox.Text = "technicien" Then
            menuForm.menuLabel.Text = "Menu " & userTextBox.Text
            menuForm.Show()
            Me.Close()
        Else
            erreurLabel.Visible = True
        End If
    End Sub

    Private Sub annulerButton_Click(sender As Object, e As EventArgs) Handles annulerButton.Click
        End
    End Sub
End Class