Imports MySql.Data.MySqlClient
Public Class LecOverviewClassForm
    Private conn As New MySqlConnection("server=localhost;database=SIS;userid=root;password=root;")
    Private adapter As MySqlDataAdapter
    Private sql As String
    Private cmd As MySqlCommand
    Private reader As MySqlDataReader
    Private Sub LecManageClass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        roundCornerModule.roundCorner(dgvStud)
        loadCourse()
    End Sub

    Private Sub loadCourse()
        Try
            conn.Open()
            sql = "SELECT courseName FROM Course c
                    WHERE lecID = @lecID"

            cmd = New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@lecID", LecForm.usernameVal)
            reader = cmd.ExecuteReader()

            While reader.Read
                cbxCourse.Items.Add(reader.GetString("courseName"))
            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message())
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub cbxCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCourse.SelectedIndexChanged
        Try
            conn.Open()
            sql = "SELECT s.studentID,s.studentName,c.courseName,c.courseID FROM Student s
                    JOIN student_course sc
                    JOIN Course c
                    ON s.studentID = sc.studentID And c.courseID = sc.courseID
                    WHERE status = @status AND c.courseName = @courseName"

            cmd = New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@status", "Enrolled")
            cmd.Parameters.AddWithValue("@courseName", cbxCourse.SelectedItem)
            adapter = New MySqlDataAdapter(cmd)
            Dim ds As New DataSet()
            adapter.Fill(ds, "table")

            dgvStud.DataSource = ds.Tables("table")

        Catch ex As Exception

        Finally
            conn.Close()
        End Try
    End Sub
End Class