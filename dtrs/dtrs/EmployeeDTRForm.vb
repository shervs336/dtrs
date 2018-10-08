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

        Access.AddParam("Employee_ID", 2018001)
        Access.AddParam(Transaction, DateNow.ToString("M/d/yyyy hh:mm:ss tt"))
        Access.AddParam("Shift_Date", DateNow.ToString("M/d/yyyy"))

        If Access.RecordCount = 0 Then
            Access.ExecQuery("Insert Into tbl_employee_login([Employee_ID], [" & Transaction & "], [Shift_Date]) Values(@Employee_ID, @" & Transaction & ", @Shift_Date)")
        Else
            'Access.ExecQuery("Update tbl_employee_login Set [" & Transaction & "] = ? WHERE [Employee_ID] = ? AND [Shift_Date] = ?")
            Dim NewDate = DateNow.ToString("M/d/yyyy hh:mm:ss tt")
            Access.ExecQuery("Update tbl_employee_login Set [" & Transaction & "] = '" & NewDate & "'")
        End If

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
End Class