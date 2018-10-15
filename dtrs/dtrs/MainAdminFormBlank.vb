Public Class MainAdminFormBlank
    Private Sub EmployeesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeesToolStripMenuItem.Click
        Me.Hide()
        MainAdminFormEmployees.Show()
    End Sub
    Private Sub PositionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PositionsToolStripMenuItem.Click
        Me.Hide()
        MainAdminFormPositions.Show()
    End Sub
    Private Sub AdminsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminsToolStripMenuItem.Click
        Me.Hide()
        MainAdminFormAdmins.Show()
    End Sub

    Private Sub MainAdminFormBlank_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AdminNameLabel.Text = "Hi! - " & LoggedUser.LoggedUser("Full_Name")
    End Sub

    Private Sub SalaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalaryToolStripMenuItem.Click
        Me.Hide()
        MainAdminFormSalary.Show()
    End Sub
End Class