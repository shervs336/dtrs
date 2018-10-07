Imports System.Data.OleDb

Public Class DBControl

    ' CREATE YOUR DB CONNECTION
    Private DBCon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database3SAD.accdb")

    ' PREPARE DB COMMAND
    Private DBCmd As OleDbCommand

    ' DB DATA
    Public DBDA As OleDbDataAdapter
    Public DBDT As DataTable

    ' QUERY PARAMETERS
    Public Params As New List(Of OleDbParameter)

    ' STATISTICS
    Public RecordCount As Integer
    Public Exception As String

    Public Sub ExecQuery(Query As String)
        ResetStatistics()

        Try
            ' OPEN A CONNECTION
            DBCon.Open()

            ' CREATE DB COMMAND
            DBCmd = New OleDbCommand(Query, DBCon)

            ' LOAD PARAMS IN DB COMMAND
            Params.ForEach(Sub(p) DBCmd.Parameters.Add(p))

            ' CLEAR PARAMS LIST
            Params.Clear()

            ' EXECUTE COMMAND AND FILL OUR DATATABLE
            DBDT = New DataTable
            DBDA = New OleDbDataAdapter(DBCmd)
            RecordCount = DBDA.Fill(DBDT)
        Catch ex As Exception
            Exception = ex.Message
        End Try

        ' CLOSE YOUR CONNECTION
        If DBCon.State = ConnectionState.Open Then DBCon.Close()

    End Sub

    ' INCLUDE QUERY AND COMMAND PARAMETERS
    Public Sub AddParam(Name As String, Value As Object)
        Dim NewParam As New OleDbParameter(Name, Value)
        Params.Add(NewParam)
    End Sub

    Private Sub ResetStatistics()
        RecordCount = 0
        Exception = ""
    End Sub





End Class
