Public Class infoContratForm
    Private Sub majButton_Click(sender As Object, e As EventArgs) Handles majButton.Click
        majForm.Show()
        Me.Close()
    End Sub

    Private Sub sortirButton_Click(sender As Object, e As EventArgs) Handles sortirButton.Click
        gestionContratForm.Show()
        Me.Close()
    End Sub
End Class