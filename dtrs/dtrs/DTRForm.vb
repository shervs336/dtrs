Public Class DTRForm
    Private Access As New DBControl
    Private Employee As Object


    Private Sub DTRForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database3SADDataSet.tbl_employee_login' table. You can move, or remove it, as needed.
        Me.Tbl_employee_loginTableAdapter.Fill(Me.Database3SADDataSet.tbl_employee_login)
        EmployeeRecord()

        Employee_IDToolStripTextBox.Text = Employee("ID")

        Access.AddParam("employee_id", MainAdminFormEmployees.CurrentRecord)

        Access.ExecQuery("Select * From tbl_employee_login Where employee_id = ? Order By shift_date Desc")




        FullNameLabel.Text = Employee("Full_Name")
            PositionLabel.Text = Employee("Position")


    End Sub

    Private Sub EmployeeRecord()
        Access.AddParam("employee_id", MainAdminFormEmployees.CurrentRecord)

        Access.ExecQuery("Select * From tbl_employees Where id = ?")
        Employee = Access.DBDT.Rows(0)
    End Sub

    Private Sub Tbl_employee_loginBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tbl_employee_loginBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tbl_employee_loginBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database3SADDataSet)


        'Get The Changed Data
        Access.AddParam("id", Convert.ToInt32(IDTextBox.Text))
        Access.ExecQuery("Select * From tbl_employee_login Where ID=@id")

        Dim theRecord = Access.DBDT.Rows(0)

        'Check Payroll Period of Changed Record
        Access.AddParam("date", theRecord("Shift_Date"))
        Access.ExecQuery("SELECT * From tbl_payroll_period Where @date BETWEEN Start_Period AND End_Period")

        Dim currPayroll = Access.DBDT.Rows(0)

        'Check If Salary Already is already recorded
        Access.AddParam("employee_id", Employee("ID"))
        Access.AddParam("payroll_period", currPayroll("Start_Period") & " - " & currPayroll("End_Period"))
        Access.ExecQuery("SELECT * From tbl_salary WHERE employee_id=@employee_id and payroll_period=@payroll_period")

        If Access.RecordCount > 0 Then
            'Update salary  by selecting sum
            Access.AddParam("start_period", currPayroll("Start_Period"))
            Access.AddParam("end_period", currPayroll("End_Period"))
            Access.ExecQuery("Select Sum(Total_Hours) As Total_Hours From tbl_employee_login Where shift_date Between @start_period AND @end_period")

            Dim totalHours = Access.DBDT.Rows(0)

            Access.AddParam("rate", Employee("rate"))
            Access.AddParam("hours", totalHours("Total_Hours"))
            Access.AddParam("employee_id", Employee("ID"))
            Access.AddParam("payroll_period", currPayroll("Start_Period") & " - " & currPayroll("End_Period"))
            Access.ExecQuery("Update tbl_salary Set rate=@rate, total_hours=@hours Where employee_id=@employee_id AND payroll_period=@payroll_period")
        Else
            'Insert new record
            Access.AddParam("employee_id", Employee("ID"))
            Access.AddParam("hours", theRecord("total_hours"))
            Access.AddParam("rate", Employee("rate"))
            Access.AddParam("payroll_period", currPayroll("Start_Period") & " - " & currPayroll("End_Period"))
            Access.ExecQuery("Insert Into tbl_salary Values(@employee_id, @hours, @rate, @payroll_period)")
        End If

    End Sub

    Private Sub Employee_IDToolStripTextBox_TextChanged(sender As Object, e As EventArgs) Handles Employee_IDToolStripTextBox.TextChanged
        Try
            Me.Tbl_employee_loginTableAdapter.FillByEmployeeID(Me.Database3SADDataSet.tbl_employee_login, New System.Nullable(Of Integer)(CType(Employee_IDToolStripTextBox.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class