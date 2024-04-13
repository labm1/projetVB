Public Class gestionContratForm
    Private Sub choisirButton_Click(sender As Object, e As EventArgs) Handles choisirButton.Click
        infoContratForm.Show()
        Me.Close()
    End Sub

    Private Sub creerButton_Click(sender As Object, e As EventArgs) Handles creerButton.Click
        clientForm.Show()
        Me.Close()
    End Sub

    Private Sub menuButton_Click(sender As Object, e As EventArgs) Handles menuButton.Click
        menuForm.Show()
        Me.Close()
    End Sub
End Class