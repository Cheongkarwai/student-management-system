Imports MySql.Data.MySqlClient
Public Class StudentCourseSelection
    Private conn As New MySqlConnection("server=localhost;database=SIS;userid=root;password=root")
    Private checkBoxCol As New DataGridViewCheckBoxColumn
    Private Sub ManageStudForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        roundCornerModule.roundCorner(dgvCourse)
        cbxSem.Items.Clear()

        For i As Integer = StudentForm.semesterVal To 1 Step -1
            cbxSem.Items.Add(i)
        Next

        checkBoxCol.HeaderText = ""
        checkBoxCol.Name = "chkCourse"
        dgvCourse.ReadOnly = False
        dgvCourse.Columns.Add(checkBoxCol)




    End Sub

    Private Sub reloadTable()
        dgvCourse.DataSource = Nothing

        Try
            conn.Open()
            Dim sql As String = "SELECT courseID,courseName FROM Student 
                                JOIN Programme 
                                JOIN Course
                                ON student.programmeID = programme.programmeID AND programme.programmeID = course.programmeID
                                AND course.semester = @sem AND student.studentID = @studentID"
            Dim cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@sem", cbxSem.SelectedItem)
            cmd.Parameters.AddWithValue("@studentID", StudentForm.usernameVal)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim ds As New DataSet()
            adapter.Fill(ds, "table")

            dgvCourse.DataSource = ds.Tables("table")



        Catch ex As Exception
            MessageBox.Show(ex.Message())
        Finally
            conn.Close()

        End Try
    End Sub

    Private Sub cbxSem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxSem.SelectedIndexChanged
        reloadTable()
        If cbxSem.SelectedItem <> StudentForm.semesterVal Then
            dgvCourse.ReadOnly = True
        Else
            dgvCourse.ReadOnly = False
        End If
        checkHasEnrolled()
    End Sub

    Private Sub checkHasEnrolled()
        If cbxSem.SelectedIndex >= 0 Then
            Try
                conn.Open()
                Dim sql As String = "SELECT c.courseID FROM student_course sc
                                JOIN Student s
                                JOIN Course c
                                ON sc.studentID = s.studentID AND c.courseID = sc.courseID
                                WHERE c.semester = @sem AND s.studentID = @studentID"
                Dim cmd As MySqlCommand = New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@sem", cbxSem.SelectedItem)
                cmd.Parameters.AddWithValue("@studentID", StudentForm.usernameVal)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                While reader.Read()
                    For i = 0 To dgvCourse.Rows.Count - 1
                        If reader.GetString("courseID") = dgvCourse.Rows(i).Cells("courseID").Value.ToString Then
                            dgvCourse.Rows(i).Cells("chkCourse").Value = True
                            dgvCourse.Rows(i).ReadOnly = True
                        End If
                    Next
                End While
                reader.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message())
            Finally
                conn.Close()
            End Try
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If cbxSem.SelectedIndex >= 0 Then
            Try
                conn.Open()
                Dim sql As String = "SELECT c.courseID,s.semester FROM student_course sc
                                JOIN Student s
                                JOIN Course c
                                ON sc.studentID = s.studentID AND c.courseID = sc.courseID
                                WHERE c.semester = @sem AND s.studentID = @studentID"
                Dim cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@sem", cbxSem.SelectedItem)
                cmd.Parameters.AddWithValue("@studentID", StudentForm.usernameVal)
                Dim adapter As New MySqlDataAdapter(cmd)
                Dim ds As New DataSet()
                adapter.Fill(ds, "table")

                Dim isEligible As Boolean = False
                If cbxSem.SelectedItem = StudentForm.semesterVal Then
                    isEligible = True
                End If

                If isEligible Then
                    For i = 0 To dgvCourse.Rows.Count - 1
                        Dim count As Integer = 0
                        If ds.Tables("table").Rows.Count > 0 Then
                            For j = 0 To ds.Tables("table").Rows.Count - 1
                                If dgvCourse.Rows(i).Cells("courseID").Value.ToString() = ds.Tables("table").Rows(j).Item("courseID").ToString() Then
                                    count = count + 1
                                End If
                            Next
                        End If

                        If dgvCourse.Rows(i).Cells("chkCourse").Value = True And count = 0 Then
                            dgvCourse.Rows(i).ReadOnly = True
                            Dim sql2 = "INSERT INTO Student_Course VALUES (@courseID2,@studentID,@status,@hasPaid)"
                            Dim cmd2 As New MySqlCommand(sql2, conn)
                            cmd2.Parameters.AddWithValue("@courseID2", dgvCourse.Rows(i).Cells("courseID").Value.ToString)
                            cmd2.Parameters.AddWithValue("@studentID", StudentForm.usernameVal)
                            cmd2.Parameters.AddWithValue("@status", "Pending")
                            cmd2.Parameters.AddWithValue("@hasPaid", "N")
                            cmd2.ExecuteNonQuery()
                        End If
                    Next
                    MessageBox.Show("You have send a request to enroll in these courses.")
                Else
                    dgvCourse.ReadOnly = True
                    MessageBox.Show("Please select your current semester.")
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message())
            Finally
                conn.Close()
            End Try
        Else
            MessageBox.Show("Please select a semester")
        End If
    End Sub
End Class