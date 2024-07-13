Imports MySql.Data.MySqlClient
Public Class StudentCocurriculum

    Private conn As New MySqlConnection("server=localhost;database=SIS;userid=root;password=root")
    Private Sub ManageLecForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        roundCornerModule.roundCorner(dgvCocurriculum)

        Try
            conn.Open()
            Dim sql As String = "SELECT eventName,point FROM Cocurriculum c
                                JOIN Student_Cocurriculum sc
                                JOIN Student s
                                ON c.eventNo = sc.eventNo AND s.studentID = sc.studentID
                                WHERE s.studentID = @studentID"
            Dim cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@studentID", StudentForm.usernameVal)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim ds As New DataSet()
            adapter.Fill(ds, "table")

            dgvCocurriculum.DataSource = ds.Tables("table")

        Catch ex As Exception
            MessageBox.Show(ex.Message())
        Finally
            conn.Close()
        End Try
    End Sub
End Class