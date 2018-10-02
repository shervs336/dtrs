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
End Class