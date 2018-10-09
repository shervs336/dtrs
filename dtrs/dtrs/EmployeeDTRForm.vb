Imports System.ComponentModel

Public Class EmployeeDTRForm
    Private Access As New DBControl

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

        Dim Data = Access.DBDT.Rows.Item(0)

        LabelEmployeeName.Text = Data("Full_Name")
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

        Access.AddParam("employee_id", Convert.ToInt32(EmployeeID.Text))
        Access.ExecQuery("Select Top 10 * From tbl_employee_login WHERE Employee_ID=@id ORDER BY Shift_Date DESC")

        If Access.RecordCount > 0 Then
            DGEmployeeDTR.DataSource = Access.DBDT
        End If

        ComputeHours(DateNow)

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

            'Access.Ex

        End If

    End Sub
End Class