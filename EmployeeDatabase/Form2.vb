Imports MySql.Data.MySqlClient

Public Class Form2
    Dim sqlConn As New MySqlConnection
    Dim sqlCmd As New MySqlCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sqlConn = New MySqlConnection
        sqlConn.ConnectionString =
            "server=localhost;userid=root;password=Dragons1@;database=employeedata"
        Dim sqlRd As MySqlDataReader

        Try
            sqlConn.Open()
            Dim Query As String
            Query = "insert into employeedata.employeedata (Firstname,Lastname,JobTitle,DateOfHire) 
values('" & TextBox_First.Text & "','" & TextBox_Last.Text & "','" & TextBox_Job.Text & "''" & TextBox_DoH.Text & "')"
            sqlCmd = New MySqlCommand(Query, sqlConn)
            sqlRd = sqlCmd.ExecuteReader

            MessageBox.Show("Data Saved")
            sqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            sqlConn.Dispose()
        End Try
    End Sub
End Class