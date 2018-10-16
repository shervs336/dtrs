Public Class MainAdminFormPositions
    Private Sub Tbl_positionsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tbl_positionsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tbl_positionsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database3SADDataSet)

    End Sub

    Private Sub MainAdminFormPositions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database3SADDataSet.tbl_positions' table. You can move, or remove it, as needed.
        Me.Tbl_positionsTableAdapter.Fill(Me.Database3SADDataSet.tbl_positions)
        'TODO: This line of code loads data into the 'Database3SADDataSet.tbl_positions' table. You can move, or remove it, as needed.
        Me.Tbl_positionsTableAdapter.Fill(Me.Database3SADDataSet.tbl_positions)

    End Sub
    Private Sub EmployeesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeesToolStripMenuItem.Click
        Me.Hide()
        MainAdminFormEmployees.Show()
    End Sub
    Private Sub PositionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PositionsToolStripMenuItem.Click
        Me.Hide()
        Me.Show()
    End Sub
    Private Sub AdminsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminsToolStripMenuItem.Click
        Me.Hide()
        MainAdminFormAdmins.Show()
    End Sub

    Private Sub SalaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalaryToolStripMenuItem.Click
        Me.Hide()
        MainAdminFormSalary.Show()
    End Sub

    Private Sub PayrollPeriodToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PayrollPeriodToolStripMenuItem.Click
        Me.Hide()
        MainAdminFormPayroll.Show()
    End Sub

    Private Sub Tbl_positionsBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Tbl_positionsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database3SADDataSet)

    End Sub
End Class