Imports System.ComponentModel

Public Class EmployeeDTRForm
    Private Access As New DBControl
    Private Employee As New Object

    Private Sub EmployeeDTRForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Hide()
        MainForm.Show()
    End Sub

    Private Sub btnTimeIn_Click(sender As Object, e As EventArgs) Handles btnTimeIn.Click
        Dim DateNow As New Date
        DateNow = Date.Now

        Try
            CheckEmployeeExists()
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

        Try
            HasDTRRecord(DateNow, "Time_In")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub CheckEmployeeExists()
        If EmployeeID.Text.ToString = String.Empty Then Throw New Exception("Employeed ID field is required")

        Access.AddParam("id", Convert.ToInt32(EmployeeID.Text))

        Access.ExecQuery("Select * From tbl_employees WHERE id=@id")

        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        If Access.RecordCount = 0 Then Throw New Exception("Employee is either not found or inactive!")

        Employee = Access.DBDT.Rows.Item(0)

        LabelEmployeeName.Text = Employee("Full_Name")
    End Sub

    Private Sub HasDTRRecord(DateNow As Date, Transaction As String)
        Access.AddParam("employee_id", Convert.ToInt32(EmployeeID.Text))
        Access.AddParam("shift_date", DateNow.ToString("M/d/yyyy"))

        Access.ExecQuery("Select * From tbl_employee_login WHERE employee_id=@id AND shift_date=@shift_date")

        Access.AddParam(Transaction, DateNow.ToString("M/d/yyyy hh:mm:ss tt"))
        Access.AddParam("Shift_Date", DateNow.ToString("M/d/yyyy"))
        Access.AddParam("Employee_ID", Convert.ToInt32(EmployeeID.Text))

        If Access.RecordCount = 0 Then
            Access.ExecQuery("Insert Into tbl_employee_login([" & Transaction & "], [Shift_Date], [Employee_ID]) Values( @" & Transaction & ",@Shift_Date, @Employee_ID)")
        Else
            Dim NewDate = DateNow.ToString("M/d/yyyy hh:mm:ss tt")
            Access.ExecQuery("Update tbl_employee_login Set [" & Transaction & "] = @" & Transaction & " Where Shift_Date=@Shift_Date And Employee_ID=@Employee_ID")
        End If

        ComputeHours(DateNow)

        Access.AddParam("employee_id", Convert.ToInt32(EmployeeID.Text))
        Access.ExecQuery("Select Top 10 * From tbl_employee_login WHERE Employee_ID=@id ORDER BY Shift_Date DESC")

        If Access.RecordCount > 0 Then
            DGEmployeeDTR.DataSource = Access.DBDT
        End If



    End Sub

    Private Sub btnTimeOut_Click(sender As Object, e As EventArgs) Handles btnTimeOut.Click
        Dim DateNow As New Date
        DateNow = Date.Now

        Try
            CheckEmployeeExists()
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

        Try
            HasDTRRecord(DateNow, "Time_Out")
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub ComputeHours(DateNow As Date)
        Access.AddParam("employee_id", Convert.ToInt32(EmployeeID.Text))
        Access.AddParam("shift_date", DateNow.ToString("M/d/yyyy"))

        Access.ExecQuery("Select * From tbl_employee_login WHERE employee_id=@id AND shift_date=@shift_date AND time_in IS NOT NULL and time_out IS NOT NULL")

        If Access.RecordCount > 0 Then

            Dim record = Access.DBDT.Rows(0)

            Dim diff = record("Time_Out") - record("Time_In")

            Dim nums As String() = diff.ToString().Split(New Char() {":"c})
            Dim actualHours As Integer
            'Update Hours in Login
            Select Case Convert.ToInt32(nums(0))
                Case 5
                    actualHours = 4
                Case 6
                    actualHours = 4
                Case 7
                    actualHours = 5
                Case 8
                    actualHours = 6
                Case 9
                    actualHours = 7
                Case 10
                    actualHours = 7
                Case 11
                    actualHours = 8
                Case 12
                    actualHours = 9
                Case 13
                    actualHours = 10
            End Select



            Access.AddParam("total_hours", Convert.ToInt32(nums(0)))
            Access.AddParam("employee_id", Convert.ToInt32(EmployeeID.Text))
            Access.AddParam("shift_date", DateNow.ToString("M/d/yyyy"))

            Access.ExecQuery("Update tbl_employee_login Set total_hours=@total_hours WHERE employee_id=@id AND shift_date=@shift_date")

            'Check Current Payroll Period
            Access.AddParam("date", DateNow.ToString("M/d/yyyy"))
            Access.ExecQuery("SELECT * From tbl_payroll_period Where @date BETWEEN Start_Period AND End_Period")

            Dim currPayroll = Access.DBDT.Rows(0)

            'Check If Salary Already is already recorded
            Access.AddParam("employee_id", Convert.ToInt32(EmployeeID.Text))
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
                Access.AddParam("employee_id", Convert.ToInt32(EmployeeID.Text))
                Access.AddParam("payroll_period", currPayroll("Start_Period") & " - " & currPayroll("End_Period"))
                Access.ExecQuery("Update tbl_salary Set rate=@rate, total_hours=@hours Where employee_id=@employee_id AND payroll_period=@payroll_period")
            Else
                'Insert new record
                Access.AddParam("employee_id", Convert.ToInt32(EmployeeID.Text))
                Access.AddParam("hours", record("total_hours"))
                Access.AddParam("rate", Employee("rate"))
                Access.AddParam("payroll_period", currPayroll("Start_Period") & " - " & currPayroll("End_Period"))
                Access.ExecQuery("Insert Into tbl_salary Values(@employee_id, @hours, @rate, @payroll_period)")
            End If

        End If

    End Sub
End Class