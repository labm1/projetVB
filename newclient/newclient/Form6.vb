Public Class menuForm
    Private Sub menuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case menuLabel.Text
            Case "Menu conseiller"
                equipementButton.Visible = False
                progButton.Visible = False
            Case "Menu ti"
                validationButton.Visible = False
                contratButton.Visible = False
                equipementButton.Visible = False
                appelButton.Visible = False
            Case "Menu technicien"
                validationButton.Visible = False
                contratButton.Visible = False
                progButton.Visible = False
                appelButton.Visible = False
        End Select
    End Sub

    Private Sub contratButton_Click(sender As Object, e As EventArgs) Handles contratButton.Click
        gestionContratForm.nomMenuLabel.Text = menuLabel.Text
        gestionContratForm.Show()
        Me.Close()
    End Sub

    Private Sub logoutButton_Click(sender As Object, e As EventArgs) Handles logoutButton.Click
        sessionForm.Show()
        Me.Close()
    End Sub
End Class