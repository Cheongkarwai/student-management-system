Imports MySql.Data.MySqlClient
Public Class AdminGradingForm
    Private conn As New MySqlConnection("server=localhost;database=SIS;userid=root;password=root")
    Private adapter As MySqlDataAdapter
    Private command As MySqlCommand
    Private ds As DataSet
    Private reader As MySqlDataReader
    Private sql As String
    Private deleteSql As String
    Private grade As String
    Private gpa As Double

    Private Sub AdminGradingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        roundCornerModule.roundCorner(panelGrading)
        roundCornerModule.roundCorner(dgvGrade)
        Try
            conn.Open()
            sql = "SELECT programmeName FROM programme"
            command = New MySqlCommand(sql, conn)
            reader = command.ExecuteReader()

            While reader.Read()
                cbxProgramme.Items.Add(reader.GetString(0))
            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub reloadTable(sql As String, condition As String, condition2 As String, value As String)

        dgvGrade.DataSource = Nothing

        Try
            conn.Open()
            command = New MySqlCommand(sql, conn)
            command.Parameters.AddWithValue(condition, value)
            command.Parameters.AddWithValue(condition2, "Pending")
            adapter = New MySqlDataAdapter(command)
            ds = New DataSet()
            adapter.Fill(ds, "table")
            dgvGrade.DataSource = ds.Tables("table")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub cbxProgramme_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxProgramme.SelectedIndexChanged

        cbxCourse.Items.Clear()
        Try
            conn.Open()
            sql = "SELECT course.courseName FROM course INNER JOIN programme ON course.programmeID = programme.programmeID WHERE programme.programmeName = @programme"
            command = New MySqlCommand(sql, conn)
            command.Parameters.AddWithValue("@programme", cbxProgramme.SelectedItem())
            reader = command.ExecuteReader()

            While reader.Read()
                cbxCourse.Items.Add(reader.GetString("courseName"))
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub



    Private Sub cbxCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCourse.SelectedIndexChanged

        reloadTable("SELECT student.studentID AS ID,student.studentName AS Name,programme.programmeName AS Programme,course.courseName AS Course,course.courseID AS CourseID,student.semester AS Semester,gradeReport.GPA AS GPA,gradeReport.grade AS Grade,gradeReport.status AS Status FROM student 
                INNER JOIN course 
                INNER JOIN programme 
                INNER JOIN gradeReport
                ON programme.programmeID = student.programmeID AND gradeReport.studentID = student.studentID AND gradeReport.courseID = course.courseID
                WHERE course.courseName = @courseName AND gradeReport.status = @status", "@courseName", "@status", cbxCourse.SelectedItem())
    End Sub

    Private Sub dgvGrade_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGrade.CellContentClick
        lblID.Text = dgvGrade.CurrentRow.Cells("ID").Value.ToString()
        lblCourseID.Text = dgvGrade.CurrentRow.Cells("CourseID").Value.ToString()
        lblSemester.Text = dgvGrade.CurrentRow.Cells("Semester").Value.ToString()
        lblGPA.Text = dgvGrade.CurrentRow.Cells("GPA").Value.ToString()
        lblGrade.Text = dgvGrade.CurrentRow.Cells("Grade").Value.ToString()

    End Sub


    Private Sub btnApprove_Click(sender As Object, e As EventArgs) Handles btnApprove.Click

        If cbxProgramme.SelectedIndex >= 0 Then
            If cbxCourse.SelectedIndex >= 0 Then
                If Not (lblID.Text = "-" And lblCourseID.Text = "-" And lblSemester.Text = "-" And lblGPA.Text = "-" And lblGrade.Text = "-") Then
                    Try
                        conn.Open()
                        sql = "UPDATE GradeReport
                                SET status = @status 
                                WHERE courseID =@courseID AND studentID = @studentID"
                        command = New MySqlCommand(sql, conn)
                        command.Parameters.AddWithValue("@status", "Success")
                        command.Parameters.AddWithValue("@courseID", lblCourseID.Text)
                        command.Parameters.AddWithValue("@studentID", lblID.Text)
                        command.ExecuteNonQuery()

                        MessageBox.Show("Student ID" & " " & lblID.Text & "'s grade has been approved")
                    Catch ex As Exception
                        MessageBox.Show(ex.Message())
                    Finally
                        conn.Close()
                        clearForm()
                    End Try
                Else
                    MessageBox.Show("Please select a record from the table")
                End If
            Else
                MessageBox.Show("Please select a course")
            End If
        Else
            MessageBox.Show("Please select a programme")
        End If

    End Sub

    Private Sub clearForm()
        dgvGrade.DataSource = ""
        cbxProgramme.SelectedIndex = -1
        cbxCourse.SelectedIndex = -1
        lblID.Text = "-"
        lblCourseID.Text = "-"
        lblGPA.Text = "-"
        lblGrade.Text = "-"
        lblSemester.Text = "-"
    End Sub

    Private Sub btnReject_Click(sender As Object, e As EventArgs) Handles btnReject.Click

        Dim result As Integer = MessageBox.Show("Are you sure to delete this record?", "Delete Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)

        If result = DialogResult.Yes Then
            If cbxProgramme.SelectedIndex >= 0 Then
                If cbxCourse.SelectedIndex >= 0 Then
                    If Not (lblID.Text = "-" And lblCourseID.Text = "-" And lblSemester.Text = "-" And lblGPA.Text = "-" And lblGrade.Text = "-") Then
                        Try
                            conn.Open()
                            sql = "DELETE FROM GradeReport
                                WHERE courseID = @courseID AND studentID = @studentID"
                            command = New MySqlCommand(sql, conn)
                            command.Parameters.AddWithValue("@courseID", lblCourseID.Text)
                            command.Parameters.AddWithValue("@studentID", lblID.Text)
                            command.ExecuteNonQuery()

                            MessageBox.Show("Student ID" & " " & lblID.Text & "'s grade has been rejected")
                        Catch ex As Exception
                            MessageBox.Show(ex.Message())
                        Finally
                            conn.Close()
                            clearForm()
                        End Try
                    Else
                        MessageBox.Show("Please select a record from the table")
                    End If
                Else
                    MessageBox.Show("Please select a course")
                End If
            Else
                MessageBox.Show("Please select a programme")
            End If

        End If
    End Sub
End Class