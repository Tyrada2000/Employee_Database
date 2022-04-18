
Imports MySql.Data.MySqlClient
Public Class Form1

    Dim sqlConn As New MySqlConnection
    Dim sqlCmd As New MySqlCommand
    Dim sqlRd As MySqlDataReader
    Dim sqlDt As New DataTable
    Dim sqlQuery As String
    Dim DtA As New MySqlDataAdapter

    Dim server As String = "localhost"
    Dim username As String = "root"
    Dim password As String = ""
    Dim database As String = "employeedata"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub updateTable()
        sqlConn.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" _
        + "password=" + password + ";" + "database" + database

        sqlConn.Open()

        sqlCmd.CommandText = "SELECT * From employeedata.employee"

        sqlRd = sqlCmd.ExecuteReader
        sqlDt.Load(sqlRd)
        sqlRd.Close()
        sqlConn.Close()
        DataGridView1.DataSource = sqlDt

    End Sub
    Private Sub buttonOpen_Click(sender As Object, e As EventArgs) Handles buttonOpen.Click
        updateTable()
    End Sub

    Private Sub buttonInsert_Click(sender As Object, e As EventArgs) Handles buttonInsert.Click
        sqlConn.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" _
            + "password=" + password + ";" + "database" + database

        Try
            sqlConn.Open()
            sqlQuery = "insert into employeedata.employee (Firstname, Lastname, JobTitle, DateOfHire)
values('" & txtFirstName.Text & "','" & txtLastName.Text & "','" & txtJobTitle.Text & "','" & txtDoH.Text & "')"

            sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
            sqlRd = sqlCmd.ExecuteReader
            sqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Employee System", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            sqlConn.Dispose()
        End Try
        updateTable()
    End Sub

    Private Sub buttonUpdate_Click(sender As Object, e As EventArgs) Handles buttonUpdate.Click
        sqlConn.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" _
            + "password=" + password + ";" + "database" + database
        sqlConn.Open()

        Dim SqlCmd As New MySqlCommand
        SqlCmd.Connection = sqlConn

        With SqlCmd
            .CommandText = "Update employeedata.employee Firstname=@Firstname, Lastname=@Lastname,
            JobTitle=@JobTitle, DateOfHire=@DateOfHire"

            .CommandText = CommandType.Text
            .Parameters.AddWithValue("@Firstname", txtFirstName.Text)
            .Parameters.AddWithValue("@Lastname", txtLastName.Text)
            .Parameters.AddWithValue("@JobTitle", txtJobTitle.Text)
            .Parameters.AddWithValue("@DateOfHire", txtDoH.Text)

        End With
        SqlCmd.ExecuteNonQuery()
        sqlConn.Close()
        updateTable()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            txtFirstName.Text = DataGridView1.SelectedRows(0).Cells(0).Value.ToString
            txtLastName.Text = DataGridView1.SelectedRows(0).Cells(1).Value.ToString
            txtJobTitle.Text = DataGridView1.SelectedRows(0).Cells(2).Value.ToString
            txtDoH.Text = DataGridView1.SelectedRows(0).Cells(3).Value.ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub buttonExit_Click(sender As Object, e As EventArgs) Handles buttonExit.Click
        Try
            If MessageBox.Show("Confirm if you want to exit", "Employee System", MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question) = DialogResult.Yes Then
                Application.Exit()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Employee System", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub buttonReset_Click(sender As Object, e As EventArgs) Handles buttonReset.Click
        Dim txt As Control
        Try
            For Each txt In Me.Controls
                If TypeOf txt Is TextBox Then
                    txt.Text = ""
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                Dim dv As DataView
                dv = sqlDt.DefaultView
                dv.RowFilter = String.Format("Firstname like '%{0}%'", txtSearch.Text)
                DataGridView1.DataSource = dv.ToTable()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub buttonRemove_Click(sender As Object, e As EventArgs) Handles buttonRemove.Click
        sqlConn.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" _
            + "password=" + password + ";" + "database" + database

        Try
            sqlConn.Open()
            sqlQuery = "Remove from employeedata.employee where Firstname ='" & txtFirstName.Text & "'"

            sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
            sqlRd = sqlCmd.ExecuteReader
            sqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Employee System", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            sqlConn.Dispose()
        End Try
        updateTable()
    End Sub
End Class
