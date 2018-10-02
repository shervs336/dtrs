Imports System.ComponentModel
Imports System.Data.OleDb

Public Class LoginForm
    Dim con As New OleDbConnection

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database3SAD.accdb"

        Dim pass As String

        Dim cmd As New OleDbCommand("Select * From tbl_admins Where Username='" & txtUsername.Text & "' and Password='" & txtPassword.Text & "'", con)
        con.Open()

        Try
            pass = cmd.ExecuteScalar().ToString
        Catch
            MsgBox("Incorrect Username and Password!", MsgBoxStyle.Exclamation)
        End Try

        con.Close()

        If (pass) Then
            MsgBox("You are now logged in ")
            MainAdminFormBlank.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub btnReturnToMainMenu_Click(sender As Object, e As EventArgs) Handles btnReturnToMainMenu.Click
        ClosingToMenu()
    End Sub

    Private Sub LoginForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        ClosingToMenu()
    End Sub

    Private Sub ClosingToMenu()
        Me.Hide()
        MainForm.Show()
    End Sub
End Class
