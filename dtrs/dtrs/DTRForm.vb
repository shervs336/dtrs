Public Class DTRForm
    Private Access As New DBControl
    Private Employee As Object


    Private Sub DTRForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EmployeeRecord()

        Access.AddParam("employee_id", MainAdminFormEmployees.CurrentRecord)

        Access.ExecQuery("Select * From tbl_employee_login Where employee_id = ? Order By shift_date Desc")

        If Access.RecordCount > 0 Then
            DGEmployeeLogin.DataSource = Access.DBDT

            FullNameLabel.Text = Employee("Full_Name")
            PositionLabel.Text = Employee("Position")
        End If

    End Sub

    Private Sub EmployeeRecord()
        Access.AddParam("employee_id", MainAdminFormEmployees.CurrentRecord)

        Access.ExecQuery("Select * From tbl_employees Where id = ?")
        Employee = Access.DBDT.Rows(0)
    End Sub


End Class