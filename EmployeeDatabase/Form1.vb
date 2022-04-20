
Imports MySql.Data.MySqlClient
Public Class Form1

    Dim sqlConn As New MySqlConnection
    Dim sqlCmd As New MySqlCommand
    Dim sqlDt As New DataTable
    Dim sqlQuery As String
    Dim DtA As New MySqlDataAdapter
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sqlConn = New MySqlConnection
        sqlConn.ConnectionString =
            "server=localhost;userid=root;password=Dragons1@;database=employeedata"
        Try
            sqlConn.Open()
            MessageBox.Show("Connection Successful")
            sqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            sqlConn.Dispose()
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sqlConn = New MySqlConnection
        sqlConn.ConnectionString =
            "server=localhost;userid=root;password=Dragons1@;database=employeedata"
        Dim sqlRd As MySqlDataReader

        Try
            sqlConn.Open()
            Dim Query As String
            Query = "select * from employeedata.employeedata where user_name='" & TextBox_UN.Text & "' and passwords='" & TextBox_Pass.Text & "' "
            sqlCmd = New MySqlCommand(Query, sqlConn)
            sqlRd = sqlCmd.ExecuteReader
            Dim count As Integer
            count = 0
            While sqlRd.Read
                count = count + 1
            End While

            If count = 1 Then
                Form2.Show()
                Me.Hide()

            ElseIf count > 1 Then
                MessageBox.Show("Username or password are Duplicate")
            Else
                MessageBox.Show("Username or password are not correct")
            End If

            sqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            sqlConn.Dispose()
        End Try
    End Sub
End Class
