Public Class MainForm
    Private Sub ShowLoginForm_Click(sender As Object, e As EventArgs) Handles ShowLoginForm.Click
        Me.Hide()
        LoginForm.Show()
    End Sub

    Private Sub ShowMainDTR_Click(sender As Object, e As EventArgs) Handles ShowMainDTR.Click
        EmployeeDTRForm.Show()
        Me.Hide()
    End Sub
End Class