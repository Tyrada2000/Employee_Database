Imports MySql.Data.MySqlClient

Public Class Form2
    Dim sqlConn As New MySqlConnection
    Dim sqlCmd As New MySqlCommand
    Dim dbDataSet As New DataTable
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

            MessageBox.Show("Employee Saved")
            sqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            sqlConn.Dispose()
        End Try

        load_table()
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

        load_table()
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

        load_table()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_table()
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
            While sqlRd.Read()

            End While

            sqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlConn.Dispose()
        End Try
    End Sub
    Private Sub load_table()
        sqlConn = New MySqlConnection
        sqlConn.ConnectionString =
            "server=localhost;userid=root;password=Dragons1@;database=employeedata"
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource

        Try
            sqlConn.Open()
            Dim Query As String
            Query = "select EmId, Firstname, Lastname, JobTitle, DateOfHire from employeedata.employeedata"
            sqlCmd = New MySqlCommand(Query, sqlConn)
            SDA.SelectCommand = sqlCmd
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            DataGridView1.DataSource = bSource
            SDA.Update(dbDataSet)

            sqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlConn.Dispose()
        End Try

    End Sub
    Private Sub Button_LoadTable_Click(sender As Object, e As EventArgs) Handles Button_LoadTable.Click
        sqlConn = New MySqlConnection
        sqlConn.ConnectionString =
            "server=localhost;userid=root;password=Dragons1@;database=employeedata"
        Dim SDA As New MySqlDataAdapter
        Dim bSource As New BindingSource

        Try
            sqlConn.Open()
            Dim Query As String
            Query = "select EmId, Firstname, Lastname, JobTitle, DateOfHire from employeedata.employeedata"
            sqlCmd = New MySqlCommand(Query, sqlConn)
            SDA.SelectCommand = sqlCmd
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            DataGridView1.DataSource = bSource
            SDA.Update(dbDataSet)

            sqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlConn.Dispose()
            load_table()
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.DataGridView1.Rows(e.RowIndex)

            TextBox_Id.Text = row.Cells("EmId").Value.ToString
            TextBox_First.Text = row.Cells("Firstname").Value.ToString
            TextBox_Last.Text = row.Cells("Lastname").Value.ToString
            TextBox_Job.Text = row.Cells("JobTitle").Value.ToString
            TextBox_DoH.Text = row.Cells("DateOfHire").Value.ToString
        End If
    End Sub

    Private Sub Search_txt_TextChanged(sender As Object, e As EventArgs) Handles Search_txt.TextChanged
        Dim DV As New DataView(dbDataSet)
        DV.RowFilter = String.Format("Firstname Like '%{0}%'", Search_txt.Text)
        DataGridView1.DataSource = DV
    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Do you want to exit", "Exit", MessageBoxButtons.YesNo)
        If dialog = DialogResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()
        End If

    End Sub
End Class