Imports MySql.Data.MySqlClient
Public Class LecStudGradeForm
    Private conn As New MySqlConnection("server=localhost;database=SIS;userid=root;password=root")
    Private sql As String
    Private adapter As MySqlDataAdapter
    Private ds As DataSet
    Private command As MySqlCommand
    Private reader As MySqlDataReader
    Private Sub LecStudGradeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        roundCornerModule.roundCorner(dgvGrade)
    End Sub

    Private Sub loadCourse()

        cbxCourse.Items.Clear()
        Try
            conn.Open()
            sql = "SELECT courseName,c.courseID FROM Course c
                    JOIN Lecturer l
                    JOIN Account a
                    ON c.lecID = l.lecID AND a.lecID = l.lecID
                    WHERE a.lecID = @lecID"
            command = New MySqlCommand(sql, conn)
            command.Parameters.AddWithValue("@lecID", LecForm.usernameVal)
            reader = command.ExecuteReader()
            Dim i As Integer = 0
            While reader.Read
                cbxCourse.Items.Add(reader.GetString("courseName"))
                i = i + 1
            End While
            reader.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message())
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub searchRecord()
        Try
            conn.Open()
            sql = "SELECT studentName FROM Student"
            adapter = New MySqlDataAdapter(sql, conn)
            ds = New DataSet()
            adapter.Fill(ds, "tables")

            While reader.Read

            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message())
        Finally

        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If cbxView.SelectedIndex >= 0 Then
            If cbxCourse.SelectedIndex >= 0 Then
                If cbxView.SelectedItem = "Edit" Then
                    dgvGrade.DataSource = Nothing
                    loadTable()
                ElseIf cbxView.SelectedItem = "Submission" Then
                    dgvGrade.DataSource = Nothing
                    loadSubmission()
                End If
            Else
                MessageBox.Show("Please select a course before searching")
            End If
        Else
            MessageBox.Show("Please select a view")
        End If
    End Sub

    Private Sub loadSubmission()

        Try
            conn.Open()
            sql = "SELECT s.studentName AS studentName,s.studentID AS studentID,c.courseID AS courseID,c.courseName AS courseName,gpa as GPA,grade,gr.semester AS semester FROM Student s
                    JOIN gradeReport gr
                    JOIN Course c
                    ON s.studentID = gr.studentID AND c.courseID = gr.courseID WHERE
                    status = @status AND courseName = @courseName"

            command = New MySqlCommand(sql, conn)
            command.Parameters.AddWithValue("@status", "Pending")
            command.Parameters.AddWithValue("@courseName", cbxCourse.SelectedItem())
            adapter = New MySqlDataAdapter(command)
            Dim ds As New DataSet()

            adapter.Fill(ds, "submissionTable")

            dgvGrade.DataSource = ds.Tables("submissionTable")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub loadTable()

        Try
            conn.Open()
            sql = "SELECT s.studentName AS StudentName,s.studentID AS StudentID,c.courseID AS CourseID,c.courseName AS CourseName,c.semester AS Semester FROM Student s
                    JOIN Course c
                    JOIN student_course sc
                    JOIN Lecturer l
                    ON s.studentID = sc.studentID AND c.courseID = sc.courseID AND l.lecID = c.lecID
                    WHERE NOT EXISTS (SELECT courseID,studentID FROM gradeReport WHERE s.studentID = gradeReport.studentID AND c.courseID = gradeReport.courseID) AND courseName = @courseName AND l.lecID = @lecID AND sc.status = 'Enrolled'"
            command = New MySqlCommand(sql, conn)

            command.Parameters.AddWithValue("@lecID", LecForm.usernameVal)
            command.Parameters.AddWithValue("@courseName", cbxCourse.SelectedItem)
            adapter = New MySqlDataAdapter(command)
            ds = New DataSet()
            adapter.Fill(ds, "table")

            dgvGrade.DataSource = ds.Tables("table")

        Catch ex As Exception
            MessageBox.Show(ex.Message())
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub cbxView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxView.SelectedIndexChanged
        If cbxView.SelectedIndex >= 0 Then
            loadCourse()
            If cbxView.SelectedItem = "Edit" Then
                dgvGrade.DataSource = Nothing
                dgvGrade.ReadOnly = False
            ElseIf cbxView.SelectedItem = "Submission" Then
                dgvGrade.DataSource = Nothing
                dgvGrade.ReadOnly = True
            End If
        End If
    End Sub

    Private Sub dgvGrade_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGrade.CellContentClick

        If cbxView.SelectedItem = "Edit" Then
            lblName.Text = dgvGrade.CurrentRow.Cells("StudentName").Value.ToString()
            lblID.Text = dgvGrade.CurrentRow.Cells("StudentID").Value.ToString()
            lblCourseID.Text = dgvGrade.CurrentRow.Cells("CourseID").Value.ToString()
            lblCourseName.Text = dgvGrade.CurrentRow.Cells("CourseName").Value.ToString()
            lblSemester.Text = dgvGrade.CurrentRow.Cells("Semester").Value.ToString()
        End If
    End Sub

    Public Function displayGrade(marks As Double) As String(,)

        Dim grade(0, 1) As String

        If marks >= 86 And marks <= 100 Then
            grade(0, 0) = "A+"
            grade(0, 1) = "4.00"
        ElseIf marks >= 80 And marks <= 85 Then
            grade(0, 0) = "A"
            grade(0, 1) = "3.75"
        ElseIf marks >= 76 And marks <= 79 Then
            grade(0, 0) = "B+"
            grade(0, 1) = "3.50"
        ElseIf marks >= 66 And marks <= 75 Then
            grade(0, 0) = "B"
            grade(0, 1) = "3.00"
        ElseIf marks >= 60 And marks <= 65 Then
            grade(0, 0) = "C+"
            grade(0, 1) = "2.50"
        ElseIf marks >= 50 And marks <= 59 Then
            grade(0, 0) = "C"
            grade(0, 1) = "2.00"
        ElseIf marks >= 40 And marks <= 49 Then
            grade(0, 0) = "D"
            grade(0, 1) = "1.00"
        ElseIf marks >= 0 And marks <= 39 Then
            grade(0, 0) = "F"
            grade(0, 1) = "0.00"
        Else
            grade(0, 0) = "-"
            grade(0, 1) = "-"
        End If

        Return grade

    End Function

    Private Sub txtMarks_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMarks.KeyPress
        If cbxView.SelectedItem = "Edit" Then
            If (e.KeyChar >= Chr(47) And e.KeyChar <= Chr(58)) Or e.KeyChar = Chr(8) Or e.KeyChar = Chr(46) Then
                If lblCourseID.Text = "-" And lblCourseName.Text = "-" And lblName.Text = "-" And lblID.Text = "-" And lblSemester.Text = "-" Then
                    e.Handled = True
                    MessageBox.Show("Please select a record first")
                End If
            Else
                e.Handled = True
                MessageBox.Show("Please enter digits only")
            End If
        Else
            e.Handled = True
            MessageBox.Show("Please select edit view to proceed")
        End If
    End Sub

    Private Sub txtMarks_TextChanged(sender As Object, e As EventArgs) Handles txtMarks.TextChanged

        If txtMarks.Text.Length > 0 Then
            Dim arr(,) As String = displayGrade(Double.Parse(txtMarks.Text))
            lblGrade.Text = arr(0, 0)
            lblGPA.Text = arr(0, 1)
        Else
            lblGrade.Text = "-"
            lblGPA.Text = "-"
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If cbxView.SelectedItem = "Edit" Then
            If Not (lblCourseID.Text = "-" And lblCourseName.Text = "-" And lblName.Text = "-" And lblID.Text = "-" And lblSemester.Text = "-") Then
                If txtMarks.Text.Length > 0 Then
                    If Double.Parse(txtMarks.Text) >= 0.00 And Double.Parse(txtMarks.Text) <= 100.0 Then
                        Try
                            conn.Open()
                            sql = "INSERT INTO gradeReport VALUES (@studentID,@gpa,@grade,@courseID,@semester,@status)"
                            command = New MySqlCommand(sql, conn)
                            command.Parameters.AddWithValue("@studentID", lblID.Text)
                            command.Parameters.AddWithValue("@gpa", lblGPA.Text)
                            command.Parameters.AddWithValue("@grade", lblGrade.Text)
                            command.Parameters.AddWithValue("@courseID", lblCourseID.Text)
                            command.Parameters.AddWithValue("@semester", lblSemester.Text)
                            command.Parameters.AddWithValue("@status", "Pending")
                            command.ExecuteNonQuery()
                            MessageBox.Show("Student ID:" & lblID.Text & " " & "has been graded" & " " & "GPA " & lblGPA.Text & " " & "Grade " & lblGrade.Text)

                            resetForm()
                        Catch ex As Exception
                            MessageBox.Show(ex.Message())
                        Finally
                            conn.Close()
                            loadTable()
                        End Try
                    Else
                        MessageBox.Show("Please enter 0 - 100 for marks")
                    End If
                Else
                        MessageBox.Show("Please enter marks")
                End If
            Else
                MessageBox.Show("Please select a record first")
            End If
        Else
            MessageBox.Show("Please select edit view to do submission")
        End If
    End Sub

    Public Sub resetForm()
        lblName.Text = "-"
        lblCourseID.Text = "-"
        lblCourseName.Text = "-"
        lblSemester.Text = "-"
        lblGPA.Text = "-"
        lblGrade.Text = "-"
        lblID.Text = "-"
        txtMarks.Text = ""
    End Sub

End Class