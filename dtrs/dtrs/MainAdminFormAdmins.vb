Public Class MainAdminFormAdmins
    Private Sub Tbl_adminsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tbl_adminsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tbl_adminsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database3SADDataSet)

    End Sub

    Private Sub MainAdminFormAdmins_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database3SADDataSet.tbl_admins' table. You can move, or remove it, as needed.
        Me.Tbl_adminsTableAdapter.Fill(Me.Database3SADDataSet.tbl_admins)

    End Sub

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
        Me.Show()
    End Sub
End Class