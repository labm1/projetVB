Public Class gestionContratForm
    Private Sub choisirButton_Click(sender As Object, e As EventArgs) Handles choisirButton.Click
        infoContratForm.Show()
    End Sub

    Private Sub creerButton_Click(sender As Object, e As EventArgs) Handles creerButton.Click
        clientForm.Show()
    End Sub

    Private Sub menuButton_Click(sender As Object, e As EventArgs) Handles menuButton.Click
        menuForm.menuLabel.Text = nomMenuLabel.Text
        menuForm.Show()
        Me.Close()
    End Sub
End Class