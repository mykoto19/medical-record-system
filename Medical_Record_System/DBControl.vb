Imports System.Data.OleDb

Public Class DBControl
    ' CREATE YOUR DATABASE CONNECTIONS
    Private DBCon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" & _
                                         "Data Source = C:\Users\macmac\Documents\Access Database\Medical_Record.accdb")


    ' Provider=Microsoft.ACE.OLEDB.12.0;Data Source="C:\Users\macmac\Documents\Access Database\Medical_Record.accdb"
    ' Prepare DB COMMAND
    Private DBcmd As OleDbCommand

    ' DB Data
    Public DBDA As OleDbDataAdapter
    Public DBDT As DataTable

    ' QUERY PARAMETERS
    Public Params As New List(Of OleDbParameter)

    ' QUERY STATISTICS
    Public RecordCount As Integer
    Public Exception As String

    Public Sub ExecQuery(ByVal Query As String)
        ' RESET QUERY STATISTICS
        RecordCount = 0
        Exception = ""

        Try
            ' OPEN A CONNECTION
            DBCon.Open()

            ' CREATE DB COMMAND
            DBcmd = New OleDbCommand(Query, DBCon)

            ' LOAD PARAMS INTO DB COMMAND
            Params.ForEach(Sub(p) DBcmd.Parameters.Add(p))

            ' OR THIS ONE ALSO IN LOOP BUT LONGER THAN THE ABOVE ONE, start below:
            'For Each p As OleDbParameter In Params
            'DBcmd.Parameters.Add(p)
            'Next


            ' CLEAR PARAMS LIST
            Params.Clear()

            ' EXECUTE COMMANDS AND FILL DATABLE
            DBDT = New DataTable
            DBDA = New OleDbDataAdapter(DBcmd)
            RecordCount = DBDA.Fill(DBDT)

        Catch ex As Exception
            Exception = ex.Message
        End Try

        ' CLOSE YOUR CONNECTION
        If DBCon.State = ConnectionState.Open Then DBCon.Close()

    End Sub

    ' ADDING & INCLUDE QUERY AND COMMAND PARAMETERS
    Public Sub AddParam(ByVal Name As String, ByVal Value As Object)
        Dim NewParam As New OleDbParameter(Name, Value)
        Params.Add(NewParam)
    End Sub
End Class
