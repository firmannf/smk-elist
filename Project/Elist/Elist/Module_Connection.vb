Imports System.Data
Imports System.Data.SqlClient
Module Module_Connection
    Public conn As SqlConnection = Nothing
    Public cmd As SqlCommand = Nothing

    Public Sub dbConnection()
        Dim connString As String = "Data Source=FIRMAN; Initial Catalog=elist;Integrated Security=true"
        Try
            conn = New SqlClient.SqlConnection(connString)
            conn.Open()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("DB Connection Error : " & ex.Message)
        End Try
    End Sub
End Module
