Imports MySql.Data.MySqlClient
Public Class AdminAttendanceForm

    Private conn As New MySqlConnection("server=localhost;database=SIS;userid=root;password=root")
    Private sql As String

    Private Sub AdminAttendanceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        roundCornerModule.roundCorner(dgvAttendance)
        roundCornerModule.roundCorner(dgvRecent)

        loadTable()
        loadApproval()
        dgvAttendance.Columns("date").DefaultCellStyle.Format = "dd-MM-yyyy"
    End Sub

    Private Sub loadApproval()
        Try
            conn.Open()
            sql = "SELECT p.programmeName,s.studentID,c.courseName,c.courseID,a.date,a.status FROM Attendance a
                    JOIN Student s
                    JOIN Course c
                    JOIN Programme p 
                    ON a.studentID = s.studentID AND a.courseID = c.courseID AND p.programmeID = s.programmeID
                    WHERE a.reviewStat = @status"
            Dim cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@status", "Success")

            Dim ds As New DataSet()
            Dim adapter As New MySqlDataAdapter(cmd)
            adapter.Fill(ds, "table")
            dgvRecent.DataSource = ds.Tables("table")

        Catch ex As Exception
            MessageBox.Show(ex.Message())
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub loadTable()
        Try
            conn.Open()
            sql = "SELECT p.programmeName,s.studentID,c.courseName,c.courseID,a.date FROM Attendance a
                    JOIN Student s
                    JOIN Course c
                    JOIN Programme p 
                    ON a.studentID = s.studentID AND a.courseID = c.courseID AND p.programmeID = s.programmeID
                    WHERE a.reviewStat = @status"
            Dim cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@status", "Pending")

            Dim ds As New DataSet()
            Dim adapter As New MySqlDataAdapter(cmd)
            adapter.Fill(ds, "table")
            dgvAttendance.DataSource = ds.Tables("table")
        Catch ex As Exception
            MessageBox.Show(ex.Message())
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub dgvAttendance_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAttendance.CellContentClick
        lblProgramme.Text = dgvAttendance.CurrentRow.Cells("programmeName").Value.ToString()
        lblCourseID.Text = dgvAttendance.CurrentRow.Cells("courseID").Value.ToString()
        lblCourseName.Text = dgvAttendance.CurrentRow.Cells("courseName").Value.ToString()
        lblID.Text = dgvAttendance.CurrentRow.Cells("studentID").Value.ToString()
        lblDate.Text = Format(CDate(dgvAttendance.CurrentRow.Cells("date").Value.ToString()), "dd-MM-yyyy")
    End Sub

    Private Sub btnApprove_Click(sender As Object, e As EventArgs) Handles btnApprove.Click
        If Not (lblProgramme.Text = "-" And lblCourseID.Text = "-" And lblCourseName.Text = "-" And lblID.Text = "-" And lblDate.Text = "-") Then
            Try
                conn.Open()
                sql = "UPDATE Attendance
                        SET reviewStat = @stat 
                        WHERE studentID = @studentID AND courseID = @courseID AND date = @date"
                Dim cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@stat", "Success")
                cmd.Parameters.AddWithValue("@studentID", lblID.Text)
                cmd.Parameters.AddWithValue("@courseID", lblCourseID.Text)
                cmd.Parameters.AddWithValue("@date", lblDate.Text.Substring(6, 4) & "-" & lblDate.Text.Substring(3, 2) & "-" & lblDate.Text.Substring(0, 2))
                cmd.ExecuteNonQuery()

                MessageBox.Show("Student ID" & " " & lblID.Text & " attendance " & " for date" & lblDate.Text & " has been approved")
            Catch ex As Exception
                MessageBox.Show(ex.Message())
            Finally
                conn.Close()
                clear()
                loadTable()
            End Try
        Else
            MessageBox.Show("Please select a record from the table above before proceed")
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If Not (lblProgramme.Text = "-" And lblCourseID.Text = "-" And lblCourseName.Text = "-" And lblID.Text = "-" And lblDate.Text = "-") Then
            Dim result As Integer = MessageBox.Show("Are you sure to delete this record?", "Delete Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)

            If result = DialogResult.Yes Then
                Try
                    conn.Open()
                    sql = "DELETE FROM Attendance
                        WHERE reviewStat = @stat AND studentID = @studentID AND courseID = @courseID AND date = @date"
                    Dim cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@stat", "Pending")
                    cmd.Parameters.AddWithValue("@studentID", lblID.Text)
                    cmd.Parameters.AddWithValue("@courseID", lblCourseID.Text)
                    cmd.Parameters.AddWithValue("@date", lblDate.Text.Substring(6, 4) & "-" & lblDate.Text.Substring(3, 2) & "-" & lblDate.Text.Substring(0, 2))

                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Student ID" & " " & lblID.Text & " attendance " & " for date" & lblDate.Text & " has been rejected")
                Catch ex As Exception
                    MessageBox.Show(ex.Message())
                Finally
                    conn.Close()
                    clear()
                    loadTable()
                End Try
            End If
        Else
            MessageBox.Show("Please select a record from the table above before proceed")
        End If
    End Sub

    Private Sub clear()
        lblCourseID.Text = "-"
        lblCourseName.Text = "-"
        lblProgramme.Text = "-"
        lblID.Text = "-"
        lblDate.Text = "-"
        loadTable()
        loadApproval()
    End Sub


End Class