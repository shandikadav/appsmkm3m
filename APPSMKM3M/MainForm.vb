Public Class MainForm
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SCinformation.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        StudentRegistration.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FormLogin.Show()
        Me.Hide()
    End Sub
End Class
