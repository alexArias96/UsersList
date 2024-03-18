Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Module Connection

    Public conn As New SqlConnection("Server=LAPTOP-SG8V7THJ\SQLARIAS; Database=BD_crud; User Id=sa; Password=SQLPassword")

    Sub OpenConnection()
        If conn.State = 0 Then
            conn.Open()
        End If
    End Sub

    Sub CloseConnection()
        If conn.State = 1 Then
            conn.Close()
        End If
    End Sub
End Module
