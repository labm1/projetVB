Public Class clientForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles creerButton.Click
        infoContratForm.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles annulerButton.Click
        gestionContratForm.Show()
        Me.Close()
    End Sub
End Class
