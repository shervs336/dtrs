Public Class MainAdminFormEmployees
    Private Access As New DBControl

    Private CurrentRecord As Integer = 0

    Private Sub Tbl_employeesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tbl_employeesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tbl_employeesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database3SADDataSet)

    End Sub

    Private Sub MainAdminFormEmployees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database3SADDataSet.tbl_employees' table. You can move, or remove it, as needed.
        Me.Tbl_employeesTableAdapter.Fill(Me.Database3SADDataSet.tbl_employees)

        Access.ExecQuery("Select * From tbl_positions")

        For Each R In Access.DBDT.Rows
            PositionComboBox.Items.Add(R("description"))
        Next


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

    Private Sub Tbl_employeesDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_employeesDataGridView.CellContentClick
        If e.RowIndex < 0 Or e.ColumnIndex < 0 Then Exit Sub

        CurrentRecord = Tbl_employeesDataGridView.Item(0, e.RowIndex).Value

        Access.AddParam("id", CurrentRecord)
        Access.ExecQuery("Select * From tbl_employees Where Id = @id")

        If Access.RecordCount > 0 Then
            For Each D In Access.DBDT.Rows
                PositionComboBox.SelectedValue = D("Position")
            Next

        End If
    End Sub
End Class