Public Class MainAdminFormEmployees
    Private Sub Tbl_employeesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tbl_employeesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tbl_employeesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database3SADDataSet)

    End Sub

    Private Sub MainAdminFormEmployees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database3SADDataSet.tbl_employees' table. You can move, or remove it, as needed.
        Me.Tbl_employeesTableAdapter.Fill(Me.Database3SADDataSet.tbl_employees)

    End Sub
    Private Sub EmployeesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeesToolStripMenuItem.Click
        Me.Hide()
        Me.Show()
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