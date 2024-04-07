Public Class majForm
    Private Sub annulerButton_Click(sender As Object, e As EventArgs) Handles annulerButton.Click
        infoContratForm.Show()
        Me.Close()
    End Sub

    Private Sub confirmerButton_Click(sender As Object, e As EventArgs) Handles confirmerButton.Click
        infoContratForm.Show()
        Me.Close()
    End Sub
End Class