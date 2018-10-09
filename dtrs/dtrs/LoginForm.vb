Imports System.ComponentModel

Public Class LoginForm
    Private Access As New DBControl
    Dim ErrorBag As Boolean = False

    Private Sub ValidateInputs()
        For Each ctrl In Me.Controls.OfType(Of TextBox)
            If ctrl.Text = String.Empty Then
                ctrl.BackColor = Color.Red
                ErrorBag = True
            End If
            Access.AddParam(ctrl.AccessibleName, ctrl.Text)
        Next
    End Sub


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ValidateInputs()

        If ErrorBag Then
            MsgBox("There is an error with your inputs")
            Exit Sub
        End If

        Access.ExecQuery("Select * From tbl_admins WHERE username=@username AND password=@password")

        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        ' CHECK IF QUERY HAS COUNT
        If Access.RecordCount > 0 Then
            LoggedUser.LoggedUser = Access.DBDT.Rows("0")
            Me.Hide()
            MainAdminFormBlank.Show()
            Exit Sub
        End If

        MsgBox("Incorrect username and password")


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
