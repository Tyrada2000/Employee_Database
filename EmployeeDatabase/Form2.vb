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
            Query = "insert into employeedata.employeedata (EmId,Firstname,Lastname,JobTitle,DateOfHire) 
values ('" & TextBox_Id.Text & "','" & TextBox_First.Text & "','" & TextBox_Last.Text & "','" & TextBox_Job.Text & "','" & TextBox_DoH.Text & "')"
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        sqlConn = New MySqlConnection
        sqlConn.ConnectionString =
            "server=localhost;userid=root;password=Dragons1@;database=employeedata"
        Dim sqlRd As MySqlDataReader

        Try
            sqlConn.Open()
            Dim Query As String
            Query = "update employeedata.employeedata 
set EmId='" & TextBox_Id.Text & "',Firstname='" & TextBox_First.Text & "',Lastname='" & TextBox_Last.Text & "',JobTitle='" & TextBox_Job.Text & "',DateOfHire='" & TextBox_DoH.Text & "'
where EmId='" & TextBox_Id.Text & "'"
            sqlCmd = New MySqlCommand(Query, sqlConn)
            sqlRd = sqlCmd.ExecuteReader

            MessageBox.Show("Update Successful")
            sqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            sqlConn.Dispose()
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        sqlConn = New MySqlConnection
        sqlConn.ConnectionString =
            "server=localhost;userid=root;password=Dragons1@;database=employeedata"
        Dim sqlRd As MySqlDataReader

        Try
            sqlConn.Open()
            Dim Query As String
            Query = "Delete from employeedata.employeedata 
where EmId='" & TextBox_Id.Text & "'"
            sqlCmd = New MySqlCommand(Query, sqlConn)
            sqlRd = sqlCmd.ExecuteReader

            MessageBox.Show("Deletion Successful")
            sqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            sqlConn.Dispose()
        End Try
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sqlConn = New MySqlConnection
        sqlConn.ConnectionString =
            "server=localhost;userid=root;password=Dragons1@;database=employeedata"
        Dim sqlRd As MySqlDataReader

        Try
            sqlConn.Open()
            Dim Query As String
            Query = "select * from employeedata.employeedata"
            sqlCmd = New MySqlCommand(Query, sqlConn)
            sqlRd = sqlCmd.ExecuteReader
            While sqlRd.Read
                Dim sName = sqlRd.GetString("Firstname")
                ListBox1.Items.Add(sName)

            End While
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        sqlConn = New MySqlConnection
        sqlConn.ConnectionString =
            "server=localhost;userid=root;password=Dragons1@;database=employeedata"
        Dim sqlRd As MySqlDataReader

        Try
            sqlConn.Open()
            Dim Query As String
            Query = "select * from employeedata.employeedata where Firstname='" & ListBox1.Text & "'"
            sqlCmd = New MySqlCommand(Query, sqlConn)
            sqlRd = sqlCmd.ExecuteReader

            While sqlRd.Read
                TextBox_Id.Text = sqlRd.GetString("EmId")
                TextBox_First.Text = sqlRd.GetString("Firstname")
                TextBox_Last.Text = sqlRd.GetString("Lastname")
                TextBox_Job.Text = sqlRd.GetString("JobTitle")
                TextBox_DoH.Text = sqlRd.GetString("DateOfHire")
            End While
            sqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            sqlConn.Dispose()
        End Try
    End Sub
End Class