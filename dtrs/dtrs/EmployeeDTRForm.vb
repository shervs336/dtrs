Imports System.ComponentModel

Public Class EmployeeDTRForm
    Private Sub EmployeeDTRForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Hide()
        MainForm.Show()
    End Sub
End Class