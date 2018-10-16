Public Class MainAdminFormPayroll
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

    Private Sub SalaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalaryToolStripMenuItem.Click
        Me.Hide()
        MainAdminFormSalary.Show()
    End Sub

    Private Sub PayrollPeriodToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PayrollPeriodToolStripMenuItem.Click
        Me.Hide()
        Me.Show()

    End Sub

    Private Sub Tbl_payroll_periodBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tbl_payroll_periodBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tbl_payroll_periodBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database3SADDataSet)

    End Sub

    Private Sub MainAdminFormPayroll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database3SADDataSet.tbl_payroll_period' table. You can move, or remove it, as needed.
        Me.Tbl_payroll_periodTableAdapter.Fill(Me.Database3SADDataSet.tbl_payroll_period)

    End Sub
End Class