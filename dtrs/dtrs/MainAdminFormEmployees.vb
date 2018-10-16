Public Class MainAdminFormEmployees
    Public CurrentRecord As Integer
    Private Access As New DBControl

    Private Sub Tbl_employeesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Tbl_employeesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database3SADDataSet)

    End Sub

    Private Sub MainAdminFormEmployees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database3SADDataSet.tbl_employees' table. You can move, or remove it, as needed.
        Me.Tbl_employeesTableAdapter.Fill(Me.Database3SADDataSet.tbl_employees)
        'TODO: This line of code loads data into the 'Database3SADDataSet.tbl_positions' table. You can move, or remove it, as needed.
        Me.Tbl_positionsTableAdapter.Fill(Me.Database3SADDataSet.tbl_positions)
        'TODO: This line of code loads data into the 'Database3SADDataSet.tbl_employees' table. You can move, or remove it, as needed.
        Me.Tbl_employeesTableAdapter.Fill(Me.Database3SADDataSet.tbl_employees)
    End Sub


    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.Tbl_positionsTableAdapter.FillBy(Me.Database3SADDataSet.tbl_positions)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ViewDTRButton_Click(sender As Object, e As EventArgs) Handles ViewDTRButton.Click
        If IDTextBox.Text.Length < 1 Then MsgBox("No employee selected.") : Exit Sub

        CurrentRecord = IDTextBox.Text

        DTRForm.Show()
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

    Private Sub SalaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalaryToolStripMenuItem.Click
        Me.Hide()
        MainAdminFormSalary.Show()
    End Sub

    Private Sub FillBy1ToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.Tbl_positionsTableAdapter.FillBy1(Me.Database3SADDataSet.tbl_positions)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub PayrollPeriodToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PayrollPeriodToolStripMenuItem.Click
        Me.Hide()
        MainAdminFormPayroll.Show()
    End Sub

    Private Sub Tbl_employeesDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_employeesDataGridView.CellContentClick

    End Sub
End Class