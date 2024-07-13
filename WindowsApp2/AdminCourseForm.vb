Imports MySql.Data.MySqlClient
Public Class AdminCourseForm
    Private connString As String = "server=localhost;database=SIS;userid=root;password=root"
    Private adapter As MySqlDataAdapter
    Private reader As MySqlDataReader
    Private command As MySqlCommand
    Private ds As DataSet
    Private sql As String
    Private count As Integer = 0
    Private Sub AdminCourseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        roundCornerModule.roundCorner(dgvCourse)
        roundCornerModule.roundCorner(panelViewPending)
        roundCornerModule.roundCorner(panelViewEnrolled)
        roundCornerModule.roundCorner(dgvEnrolledCourse)
        cbxView.SelectedItem = "General"
        loadGeneralData()
        loadProgrammeData(cbxGenProgramme)
        showGenPanel()
    End Sub
    Private Sub loadGeneralData()
        Dim conn As MySqlConnection = New MySqlConnection(connString)
        Try
            conn.Open()
            sql = "SELECT student.studentID As StudentID,student.studentName AS StudentName,programme.programmeName AS ProgrammeName ,course.courseID As CourseCode,course.courseName As CourseName,course.creditHour As CreditHour,student.semester As Semester,student_course.status As Status,course.fees As Fees FROM student_course INNER JOIN Course INNER JOIN Student INNER JOIN Programme WHERE student_course.courseID = course.courseID AND student_course.studentID = student.studentID And student.programmeID = programme.programmeID And (status = @status1 OR status =@status2 OR status = @status3)"
            command = New MySqlCommand(sql, conn)
            command.Parameters.AddWithValue("@status1", "Pending")
            command.Parameters.AddWithValue("@status2", "Enrolled")
            command.Parameters.AddWithValue("@status3", "Done")
            adapter = New MySqlDataAdapter(command)
            ds = New DataSet()
            adapter.Fill(ds, "generalRecords")

            dgvCourse.DataSource = ds.Tables("generalRecords")

        Catch ex As Exception
            MessageBox.Show(ex.Message())
        Finally
            conn.Close()
            conn.Dispose()
        End Try
    End Sub
    Private Sub loadProgrammeData(cbxBox As ComboBox)
        cbxBox.Items.Clear()
        Dim conn As MySqlConnection = New MySqlConnection(connString)
        Try
            conn.Open()
            sql = "SELECT programmeName FROM Programme"
            command = New MySqlCommand(sql, conn)
            reader = command.ExecuteReader()

            While reader.Read
                cbxBox.Items.Add(reader.GetString("programmeName"))
            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
            conn.Dispose()
        End Try
    End Sub
    Private Sub loadCourseData(status As String)
        Dim conn As MySqlConnection = New MySqlConnection(connString)
        Try
            conn.Open()
            sql = "SELECT student.studentID As StudentID,student.studentName AS StudentName,programme.programmeName AS ProgrammeName ,course.courseID As CourseCode,course.courseName As CourseName,course.creditHour As CreditHour,student.semester As Semester,student_course.status As Status,course.fees As Fees FROM student_course INNER JOIN Course INNER JOIN Student INNER JOIN Programme WHERE student_course.courseID = course.courseID AND student_course.studentID = student.studentID And student.programmeID = programme.programmeID And status = @status"
            command = New MySqlCommand(sql, conn)
            command.Parameters.AddWithValue("@status", status)
            adapter = New MySqlDataAdapter(command)
            ds = New DataSet()
            adapter.Fill(ds, "enrolledRecords")

            dgvCourse.DataSource = ds.Tables("enrolledRecords")

        Catch ex As Exception
            MessageBox.Show(ex.Message())
        Finally
            conn.Close()
            conn.Dispose()
        End Try
    End Sub

    Private Sub dgvCourse_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCourse.CellContentClick
        If cbxView.SelectedItem = "Pending" Then
            If dgvCourse.Rows.Count > 0 Then
                txtNamePending.Text = dgvCourse.CurrentRow.Cells("StudentName").Value.ToString()
                txtCourseIDPending.Text = dgvCourse.CurrentRow.Cells("CourseCode").Value.ToString()
                txtSemesterPending.Text = dgvCourse.CurrentRow.Cells("Semester").Value.ToString()
                txtFeesPending.Text = dgvCourse.CurrentRow.Cells("Fees").Value.ToString()
                cbxProgrammePending.SelectedItem = dgvCourse.CurrentRow.Cells("ProgrammeName").Value.ToString()
                cbxCoursePending.SelectedItem = dgvCourse.CurrentRow.Cells("CourseName").Value.ToString()
                cbxIDPending.SelectedItem = dgvCourse.CurrentRow.Cells("StudentID").Value.ToString()
            Else
                MessageBox.Show("No record found")
            End If

        ElseIf cbxView.SelectedItem = "Enrolled" Then
            If dgvCourse.Rows.Count > 0 Then
                cbxProgrammeEnrolled.SelectedItem = dgvCourse.CurrentRow.Cells("ProgrammeName").Value.ToString()
                cbxIDEnrolled.SelectedItem = dgvCourse.CurrentRow.Cells("studentID").Value.ToString()
                dgvCourse.CurrentRow.Cells("ProgrammeName").Value.ToString()
                txtNameEnrolled.Text = dgvCourse.CurrentRow.Cells("studentName").Value.ToString()
            Else
                MessageBox.Show("No record found")
            End If
        End If
    End Sub

    Private Sub cbxProgramme_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxProgrammePending.SelectedIndexChanged
        cbxCoursePending.Items.Clear()
        loadCourseData()
    End Sub

    Private Sub loadCourseData()
        Dim conn As MySqlConnection = New MySqlConnection(connString)
        Try
            conn.Open()
            sql = "SELECT courseName FROM Course INNER JOIN Programme WHERE course.programmeID = programme.programmeID AND programmeName = @programmeName"
            command = New MySqlCommand(sql, conn)
            command.Parameters.AddWithValue("@programmeName", cbxProgrammePending.SelectedItem)
            reader = command.ExecuteReader()

            While reader.Read
                cbxCoursePending.Items.Add(reader.GetString("courseName"))
            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
            conn.Dispose()
        End Try
    End Sub

    Private Sub cbxCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCoursePending.SelectedIndexChanged
        cbxIDPending.Items.Clear()
        getStudID("Pending")
    End Sub

    Private Sub getStudID(status As String)
        Dim conn As MySqlConnection = New MySqlConnection(connString)
        Try
            conn.Open()
            sql = "SELECT student.studentID FROM Student_course INNER JOIN Student INNER JOIN Course WHERE student_course.studentID = student.studentID AND course.courseID = student_course.courseID AND status = @status AND courseName = @courseName"
            command = New MySqlCommand(sql, conn)
            command.Parameters.AddWithValue("@status", status)
            command.Parameters.AddWithValue("@courseName", cbxCoursePending.SelectedItem())
            reader = command.ExecuteReader()

            While reader.Read
                count = count + 1
                cbxIDPending.Items.Add(reader.GetString("studentID"))
            End While
            If count <= 0 Then
                MessageBox.Show("No pending request in " & cbxProgrammePending.SelectedItem & " (" & cbxCoursePending.SelectedItem & ")")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
            conn.Dispose()
        End Try
    End Sub

    Private Sub cbxName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxIDPending.SelectedIndexChanged
        If cbxView.SelectedItem = "Pending" Then
            If cbxIDPending.SelectedIndex >= 0 And cbxCoursePending.SelectedIndex >= 0 And cbxProgrammePending.SelectedIndex >= 0 Then
                Dim conn As MySqlConnection = New MySqlConnection(connString)
                Try
                    conn.Open()
                    sql = "SELECT student.studentName,student.studentID,course.courseID,course.fees,course.semester FROM Student INNER JOIN Course INNER JOIN student_course WHERE student.studentID = student_course.studentID AND Course.courseID = student_course.courseID AND course.courseName = @courseName AND student.studentID =  @studentID"
                    command = New MySqlCommand(sql, conn)
                    command.Parameters.AddWithValue("@courseName", cbxCoursePending.SelectedItem)
                    command.Parameters.AddWithValue("@studentID", cbxIDPending.SelectedItem)
                    reader = command.ExecuteReader()

                    While reader.Read
                        txtNamePending.Text = reader.GetString("studentName")
                        txtSemesterPending.Text = reader.GetString("semester")
                        txtFeesPending.Text = reader.GetString("fees")
                        txtCourseIDPending.Text = reader.GetString("courseID")
                    End While

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    conn.Close()
                    conn.Dispose()
                End Try
            End If
        End If

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim conn As MySqlConnection = New MySqlConnection(connString)

        If cbxView.SelectedItem = "Pending" Then
            If cbxCoursePending.SelectedIndex >= 0 And cbxProgrammePending.SelectedIndex >= 0 And cbxIDPending.SelectedIndex >= 0 Then

                'Dim dt As New DataTable()
                'Dim courseID As String = ""
                'Try
                '    conn.Open()
                '    sql = "SELECT courseID FROM Course WHERE courseName = @courseName"
                '    command = New MySqlCommand(sql, conn)
                '    command.Parameters.AddWithValue("courseID", cbxCoursePending.SelectedItem())
                '    reader = command.ExecuteReader()
                '    While reader.Read()
                '        courseID = reader.GetString("courseID")
                '    End While
                'Catch ex As Exception
                '    MessageBox.Show(ex.Message() & "Hey")
                'Finally
                '    conn.Close()
                'End Try
                Try
                    conn.Open()
                    sql = "UPDATE Student_Course 
                            SET status = @status WHERE studentID = @studentID AND courseID = @courseID"
                    command = New MySqlCommand(sql, conn)
                    command.Parameters.AddWithValue("@status", "Enrolled")
                    command.Parameters.AddWithValue("@studentID", cbxIDPending.SelectedItem)
                    command.Parameters.AddWithValue("@courseID", txtCourseIDPending.Text)
                    command.ExecuteNonQuery()

                    MessageBox.Show(txtNamePending.Text & " " & cbxIDPending.SelectedItem & " " & "has successfully enrolled into " & cbxCoursePending.SelectedItem)
                    loadCourseData("Pending")
                    clearForm()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    conn.Close()

                End Try
            Else
                MessageBox.Show("Please select a record ")
            End If
        End If
    End Sub

    'Private Function retrieveCourseID() As String
    '    Dim conn As MySqlConnection = New MySqlConnection(connString)
    '    Dim courseID As String
    '    Try
    '        conn.Open()
    '        sql = "SELECT courseID FROM Course WHERE courseName = @courseName"
    '        command = New MySqlCommand(sql, conn)
    '        command.Parameters.AddWithValue("courseID", cbxCoursePending.SelectedItem())
    '        reader = command.ExecuteReader()
    '        While reader.Read()
    '            courseID = reader.GetString("courseID")
    '        End While
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message() & "Hey")
    '    Finally
    '        conn.Close()
    '    End Try

    '    Return courseID
    'End Function
    Private Sub cbxProgrammeEnrolled_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxProgrammeEnrolled.SelectedIndexChanged
        cbxIDEnrolled.Items.Clear()
        Dim conn As MySqlConnection = New MySqlConnection(connString)

        If cbxProgrammeEnrolled.SelectedIndex >= 0 Then
            Try
                conn.Open()
                sql = "SELECT DISTINCT student.studentID FROM Student_course 
                        INNER JOIN Student 
                        INNER JOIN Programme 
                        WHERE student.programmeID = programme.programmeID AND student_course.studentID = student.studentID AND status = @status AND programmeName = @programmeName"
                command = New MySqlCommand(sql, conn)
                command.Parameters.AddWithValue("@status", "Enrolled")
                command.Parameters.AddWithValue("@programmeName", cbxProgrammeEnrolled.SelectedItem())
                reader = command.ExecuteReader()

                While reader.Read
                    count = count + 1
                    cbxIDEnrolled.Items.Add(reader.GetString("studentID"))
                End While

                If count <= 0 Then
                    MessageBox.Show("No student enroll in " & cbxProgrammeEnrolled.SelectedItem)
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                conn.Close()
                conn.Dispose()
            End Try
        Else
            MessageBox.Show("Please select a programme")
        End If
    End Sub

    Private Sub showGenPanel()
        GenSearchPanel.Visible = True
        panelViewEnrolled.Visible = False
        panelViewPending.Visible = False
        btnReject.Visible = False
        btnAdd.Visible = False
        btnReset.Visible = False
        panelSpace.Visible = False
    End Sub

    Private Sub showBtn()
        GenSearchPanel.Visible = False
        btnReject.Visible = True
        btnAdd.Visible = True
        btnReset.Visible = True
        panelSpace.Visible = True
    End Sub
    Private Sub hideBtn()
        GenSearchPanel.Visible = False
        btnReject.Visible = False
        btnAdd.Visible = False
        btnReset.Visible = False
        panelSpace.Visible = True
    End Sub
    Private Sub cbxView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxView.SelectedIndexChanged
        If cbxView.SelectedItem = "Pending" Then
            loadProgrammeData(cbxProgrammePending)
            loadCourseData("Pending")
            panelViewEnrolled.Visible = False
            panelViewPending.Visible = True
            showBtn()
            clearForm()
            If dgvCourse.Rows.Count <= 0 Then
                MessageBox.Show("No pending request")
            End If
        ElseIf cbxView.SelectedItem = "Enrolled" Then
            loadProgrammeData(cbxProgrammeEnrolled)
            loadCourseData("Enrolled")
            panelViewPending.Visible = True
            panelViewEnrolled.Visible = True
            hideBtn()
            clearForm()
            If dgvCourse.Rows.Count <= 0 Then
                MessageBox.Show("No enrollment")
            End If
        ElseIf cbxView.SelectedItem = "General" Then
            loadGeneralData()
            loadProgrammeData(cbxGenProgramme)
            showGenPanel()
            clearForm()
            If dgvCourse.Rows.Count <= 0 Then
                MessageBox.Show("No enrollment or pending request")
            End If
        End If
    End Sub

    Private Sub cbxIDEnrolled_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxIDEnrolled.SelectedIndexChanged

        Dim conn As MySqlConnection = New MySqlConnection(connString)

        If cbxIDEnrolled.SelectedIndex >= 0 Then
            Try
                conn.Open()
                sql = "SELECT course.courseID,course.courseName,course.fees,student_course.hasPaid FROM Student INNER JOIN Course INNER JOIN student_course WHERE student.studentID = student_course.studentID AND student_course.courseID = course.courseID AND status = @status AND student.studentID = @studentID"
                command = New MySqlCommand(sql, conn)
                command.Parameters.AddWithValue("@status", "Enrolled")
                command.Parameters.AddWithValue("@studentID", cbxIDEnrolled.SelectedItem)
                adapter = New MySqlDataAdapter(command)
                ds = New DataSet()
                adapter.Fill(ds, "enrolledTable")
                dgvEnrolledCourse.DataSource = ds.Tables("enrolledTable")

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                conn.Close()
            End Try
            Try
                conn.Open()
                sql = "SELECT studentName FROM Student WHERE studentID = @studentID"
                command = New MySqlCommand(sql, conn)
                command.Parameters.AddWithValue("@studentID", cbxIDEnrolled.SelectedItem)
                reader = command.ExecuteReader()

                While reader.Read
                    txtNameEnrolled.Text = reader.GetString("studentName")
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                conn.Close()
            End Try
            Try
                conn.Open()
                sql = "SELECT COALESCE(SUM(fees),0) AS outstandingFees FROM Student INNER JOIN Course INNER JOIN student_course WHERE student.studentID = student_course.studentID AND student_course.courseID = course.courseID AND status = @status  AND student.studentID = @studentID AND student_course.hasPaid = @hasPaid;"
                command = New MySqlCommand(sql, conn)
                command.Parameters.AddWithValue("@status", "Enrolled")
                command.Parameters.AddWithValue("@studentID", cbxIDEnrolled.SelectedItem)
                command.Parameters.AddWithValue("@hasPaid", "N")
                adapter = New MySqlDataAdapter(command)
                ds = New DataSet()
                adapter.Fill(ds, "result")
                If ds.Tables("result").Rows.Count > 0 Then
                    For i = 0 To ds.Tables("result").Rows.Count - 1
                        txtFeesEnrolled.Text = ds.Tables("result").Rows(i).Item("outstandingFees").ToString()
                    Next
                ElseIf ds.Tables("result").Rows.Count = 0 Then
                    txtFeesEnrolled.Text = "-"
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                conn.Close()
            End Try
        End If
    End Sub

    Private Sub cbxGenProgramme_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxGenProgramme.SelectedIndexChanged
        cbxGenID.Items.Clear()
        Dim conn As MySqlConnection = New MySqlConnection(connString)
        Try
            conn.Open()
            sql = "SELECT DISTINCT student.studentID FROM Student INNER JOIN Programme INNER JOIN student_course WHERE student.programmeID = programme.programmeID AND student_course.studentID = student.studentID AND programmeName = @programmeName"
            command = New MySqlCommand(sql, conn)
            command.Parameters.AddWithValue("@programmeName", cbxGenProgramme.SelectedItem())
            reader = command.ExecuteReader()

            While reader.Read
                count = count + 1
                cbxGenID.Items.Add(reader.GetString("studentID"))
            End While

            If count <= 0 Then
                MessageBox.Show("No pending request or enrollment in " & cbxProgrammeEnrolled.SelectedItem)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
            conn.Dispose()
        End Try
    End Sub

    Private Sub cbxGenID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxGenID.SelectedIndexChanged
        If cbxGenProgramme.SelectedIndex >= 0 Then
            Dim conn As MySqlConnection = New MySqlConnection(connString)
            Try
                conn.Open()
                sql = "SELECT student.studentID As StudentID,student.studentName AS StudentName,programme.programmeName AS ProgrammeName ,course.courseID As CourseCode,course.courseName As CourseName,course.creditHour As CreditHour,student.semester As Semester,student_course.status As Status,course.fees As Fees FROM student_course INNER JOIN Course INNER JOIN Student INNER JOIN Programme WHERE student_course.courseID = course.courseID AND student_course.studentID = student.studentID And student.programmeID = programme.programmeID And (status = @status1 OR status =@status2 OR status = @status3) And student.studentID = @studentID"
                command = New MySqlCommand(sql, conn)
                command.Parameters.AddWithValue("@status1", "Pending")
                command.Parameters.AddWithValue("@status2", "Enrolled")
                command.Parameters.AddWithValue("@status3", "Done")
                command.Parameters.AddWithValue("@studentID", cbxGenID.SelectedItem)
                adapter = New MySqlDataAdapter(command)
                ds = New DataSet()

                adapter.Fill(ds, "generalTable")
                dgvCourse.DataSource = ds.Tables("generalTable")

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                conn.Close()
                conn.Dispose()
            End Try
        End If
    End Sub
    Private Sub sortGen(sql As String)
        Dim conn As MySqlConnection = New MySqlConnection(connString)
        Try
            conn.Open()
            command = New MySqlCommand(sql, conn)
            command.Parameters.AddWithValue("@status1", "Pending")
            command.Parameters.AddWithValue("@status2", "Enrolled")
            command.Parameters.AddWithValue("@status3", "Done")
            adapter = New MySqlDataAdapter(command)
            ds = New DataSet()

            adapter.Fill(ds, "sortedRecords")
            dgvCourse.DataSource = ds.Tables("sortedRecords")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
            conn.Dispose()
        End Try
    End Sub
    Private Sub sortNonGen(status As String, sql As String)
        Dim conn As MySqlConnection = New MySqlConnection(connString)
        Try
            conn.Open()
            command = New MySqlCommand(sql, conn)
            command.Parameters.AddWithValue("@status", status)
            adapter = New MySqlDataAdapter(command)
            ds = New DataSet()
            adapter.Fill(ds, "sortedRecords")

            dgvCourse.DataSource = ds.Tables("sortedRecords")

        Catch ex As Exception
            MessageBox.Show(ex.Message())
        Finally
            conn.Close()
            conn.Dispose()
        End Try
    End Sub
    Private Sub cbxSort_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxSort.SelectedIndexChanged
        cbxGenProgramme.SelectedIndex = -1
        cbxGenID.SelectedIndex = -1
        If dgvCourse.Rows.Count > 0 Then
            If cbxView.SelectedItem = "General" Then
                If cbxSort.SelectedItem = "Student ID" Then
                    sortGen("SELECT student.studentID As StudentID,student.studentName AS StudentName,programme.programmeName AS ProgrammeName ,course.courseID As CourseCode,course.courseName As CourseName,course.creditHour As CreditHour,student.semester As Semester,student_course.status As Status,course.fees As Fees FROM student_course INNER JOIN Course INNER JOIN Student INNER JOIN Programme WHERE student_course.courseID = course.courseID AND student_course.studentID = student.studentID And student.programmeID = programme.programmeID And (status = @status1 OR status =@status2 OR status = @status3) ORDER BY student.studentID")
                ElseIf cbxSort.SelectedItem = "Student Name" Then
                    sortGen("SELECT student.studentID As StudentID,student.studentName AS StudentName,programme.programmeName AS ProgrammeName ,course.courseID As CourseCode,course.courseName As CourseName,course.creditHour As CreditHour,student.semester As Semester,student_course.status As Status,course.fees As Fees FROM student_course INNER JOIN Course INNER JOIN Student INNER JOIN Programme WHERE student_course.courseID = course.courseID AND student_course.studentID = student.studentID And student.programmeID = programme.programmeID And (status = @status1 OR status =@status2 OR status = @status3) ORDER BY student.studentName")
                ElseIf cbxSort.SelectedItem = "Programme Name" Then
                    sortGen("SELECT student.studentID As StudentID,student.studentName AS StudentName,programme.programmeName AS ProgrammeName ,course.courseID As CourseCode,course.courseName As CourseName,course.creditHour As CreditHour,student.semester As Semester,student_course.status As Status,course.fees As Fees FROM student_course INNER JOIN Course INNER JOIN Student INNER JOIN Programme WHERE student_course.courseID = course.courseID AND student_course.studentID = student.studentID And student.programmeID = programme.programmeID And (status = @status1 OR status =@status2 OR status = @status3) ORDER BY programme.programmeName")
                ElseIf cbxSort.SelectedItem = "Course Name" Then
                    sortGen("SELECT student.studentID As StudentID,student.studentName AS StudentName,programme.programmeName AS ProgrammeName ,course.courseID As CourseCode,course.courseName As CourseName,course.creditHour As CreditHour,student.semester As Semester,student_course.status As Status,course.fees As Fees FROM student_course INNER JOIN Course INNER JOIN Student INNER JOIN Programme WHERE student_course.courseID = course.courseID AND student_course.studentID = student.studentID And student.programmeID = programme.programmeID And (status = @status1 OR status =@status2 OR status = @status3) ORDER BY course.courseName")
                ElseIf cbxSort.SelectedItem = "Course Code" Then
                    sortGen("SELECT student.studentID As StudentID,student.studentName AS StudentName,programme.programmeName AS ProgrammeName ,course.courseID As CourseCode,course.courseName As CourseName,course.creditHour As CreditHour,student.semester As Semester,student_course.status As Status,course.fees As Fees FROM student_course INNER JOIN Course INNER JOIN Student INNER JOIN Programme WHERE student_course.courseID = course.courseID AND student_course.studentID = student.studentID And student.programmeID = programme.programmeID And (status = @status1 OR status =@status2 OR status = @status3) ORDER BY course.courseID")
                End If
            End If
            If cbxView.SelectedItem = "Pending" Then
                If cbxSort.SelectedItem = "Student ID" Then
                    sortNonGen("Pending", "SELECT student.studentID As StudentID,student.studentName AS StudentName,programme.programmeName AS ProgrammeName ,course.courseID As CourseCode,course.courseName As CourseName,course.creditHour As CreditHour,student.semester As Semester,student_course.status As Status,course.fees As Fees FROM student_course INNER JOIN Course INNER JOIN Student INNER JOIN Programme WHERE student_course.courseID = course.courseID AND student_course.studentID = student.studentID And student.programmeID = programme.programmeID And status = @status ORDER BY student.studentID")
                ElseIf cbxSort.SelectedItem = "Student Name" Then
                    sortNonGen("Pending", "SELECT student.studentID As StudentID,student.studentName AS StudentName,programme.programmeName AS ProgrammeName ,course.courseID As CourseCode,course.courseName As CourseName,course.creditHour As CreditHour,student.semester As Semester,student_course.status As Status,course.fees As Fees FROM student_course INNER JOIN Course INNER JOIN Student INNER JOIN Programme WHERE student_course.courseID = course.courseID AND student_course.studentID = student.studentID And student.programmeID = programme.programmeID And status = @status ORDER BY student.studentName")
                ElseIf cbxSort.SelectedItem = "Programme Name" Then
                    sortNonGen("Pending", "SELECT student.studentID As StudentID,student.studentName AS StudentName,programme.programmeName AS ProgrammeName ,course.courseID As CourseCode,course.courseName As CourseName,course.creditHour As CreditHour,student.semester As Semester,student_course.status As Status,course.fees As Fees FROM student_course INNER JOIN Course INNER JOIN Student INNER JOIN Programme WHERE student_course.courseID = course.courseID AND student_course.studentID = student.studentID And student.programmeID = programme.programmeID And status = @status ORDER BY programme.programmeName")
                ElseIf cbxSort.SelectedItem = "Course Name" Then
                    sortNonGen("Pending", "SELECT student.studentID As StudentID,student.studentName AS StudentName,programme.programmeName AS ProgrammeName ,course.courseID As CourseCode,course.courseName As CourseName,course.creditHour As CreditHour,student.semester As Semester,student_course.status As Status,course.fees As Fees FROM student_course INNER JOIN Course INNER JOIN Student INNER JOIN Programme WHERE student_course.courseID = course.courseID AND student_course.studentID = student.studentID And student.programmeID = programme.programmeID And status = @status ORDER BY course.courseName")
                ElseIf cbxSort.SelectedItem = "Course Code" Then
                    sortNonGen("Pending", "SELECT student.studentID As StudentID,student.studentName AS StudentName,programme.programmeName AS ProgrammeName ,course.courseID As CourseCode,course.courseName As CourseName,course.creditHour As CreditHour,student.semester As Semester,student_course.status As Status,course.fees As Fees FROM student_course INNER JOIN Course INNER JOIN Student INNER JOIN Programme WHERE student_course.courseID = course.courseID AND student_course.studentID = student.studentID And student.programmeID = programme.programmeID And status = @status ORDER BY course.courseID")
                End If
            End If
            If cbxView.SelectedItem = "Enrolled" Then
                If cbxSort.SelectedItem = "Student ID" Then
                    sortNonGen("Enrolled", "SELECT student.studentID As StudentID,student.studentName AS StudentName,programme.programmeName AS ProgrammeName ,course.courseID As CourseCode,course.courseName As CourseName,course.creditHour As CreditHour,student.semester As Semester,student_course.status As Status,course.fees As Fees FROM student_course INNER JOIN Course INNER JOIN Student INNER JOIN Programme WHERE student_course.courseID = course.courseID AND student_course.studentID = student.studentID And student.programmeID = programme.programmeID And status = @status ORDER BY student.studentID")
                ElseIf cbxSort.SelectedItem = "Student Name" Then
                    sortNonGen("Enrolled", "SELECT student.studentID As StudentID,student.studentName AS StudentName,programme.programmeName AS ProgrammeName ,course.courseID As CourseCode,course.courseName As CourseName,course.creditHour As CreditHour,student.semester As Semester,student_course.status As Status,course.fees As Fees FROM student_course INNER JOIN Course INNER JOIN Student INNER JOIN Programme WHERE student_course.courseID = course.courseID AND student_course.studentID = student.studentID And student.programmeID = programme.programmeID And status = @status ORDER BY student.studentName")
                ElseIf cbxSort.SelectedItem = "Programme Name" Then
                    sortNonGen("Enrolled", "SELECT student.studentID As StudentID,student.studentName AS StudentName,programme.programmeName AS ProgrammeName ,course.courseID As CourseCode,course.courseName As CourseName,course.creditHour As CreditHour,student.semester As Semester,student_course.status As Status,course.fees As Fees FROM student_course INNER JOIN Course INNER JOIN Student INNER JOIN Programme WHERE student_course.courseID = course.courseID AND student_course.studentID = student.studentID And student.programmeID = programme.programmeID And status = @status ORDER BY programme.programmeName")
                ElseIf cbxSort.SelectedItem = "Course Name" Then
                    sortNonGen("Enrolled", "SELECT student.studentID As StudentID,student.studentName AS StudentName,programme.programmeName AS ProgrammeName ,course.courseID As CourseCode,course.courseName As CourseName,course.creditHour As CreditHour,student.semester As Semester,student_course.status As Status,course.fees As Fees FROM student_course INNER JOIN Course INNER JOIN Student INNER JOIN Programme WHERE student_course.courseID = course.courseID AND student_course.studentID = student.studentID And student.programmeID = programme.programmeID And status = @status ORDER BY course.courseName")
                ElseIf cbxSort.SelectedItem = "Course Code" Then
                    sortNonGen("Enrolled", "SELECT student.studentID As StudentID,student.studentName AS StudentName,programme.programmeName AS ProgrammeName ,course.courseID As CourseCode,course.courseName As CourseName,course.creditHour As CreditHour,student.semester As Semester,student_course.status As Status,course.fees As Fees FROM student_course INNER JOIN Course INNER JOIN Student INNER JOIN Programme WHERE student_course.courseID = course.courseID AND student_course.studentID = student.studentID And student.programmeID = programme.programmeID And status = @status ORDER BY course.courseID")
                End If
            End If
        Else
            MessageBox.Show("No record found")
        End If
    End Sub

    Private Sub clearForm()
        cbxProgrammePending.SelectedIndex = -1
        cbxSort.SelectedIndex = -1
        cbxGenID.Items.Clear()
        cbxIDEnrolled.Items.Clear()
        txtNameEnrolled.Text = "-"
        txtFeesEnrolled.Text = "0.00"
        dgvEnrolledCourse.DataSource = Nothing
        cbxCoursePending.Items.Clear()
        cbxIDPending.Items.Clear()
        txtCourseIDPending.Text = "-"
        txtFeesPending.Text = "0"
        txtNamePending.Text = "-"
        txtSemesterPending.Text = "-"
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        clearForm()
    End Sub

    Private Sub btnReject_Click(sender As Object, e As EventArgs) Handles btnReject.Click

        Dim conn As MySqlConnection = New MySqlConnection(connString)
        Dim conn2 As MySqlConnection = New MySqlConnection(connString)
        If cbxProgrammePending.SelectedIndex < 0 Or cbxCoursePending.SelectedIndex < 0 Or cbxIDPending.SelectedIndex < 0 Or txtCourseIDPending.Text.Length <= 0 Or txtFeesPending.Text.Length <= 0 Or txtNamePending.Text.Length <= 0 Or txtSemesterPending.Text.Length <= 0 Then
            MessageBox.Show("No selected record")
        Else
            sql = "DELETE FROM student_course WHERE studentID = @studentID AND courseID = @courseID"
            Dim sql2 As String = "SELECT courseID FROM Course WHERE courseName = @courseName"
            Dim result As Integer
            result = MessageBox.Show("Are you sure you want to reject this request?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
            If result = DialogResult.Yes Then
                Try
                    conn.Open()
                    command = New MySqlCommand(sql, conn)
                    command.Parameters.AddWithValue("@studentID", cbxIDPending.SelectedItem)

                    Try
                        conn2.Open()
                        Dim cmd2 As MySqlCommand = New MySqlCommand(sql2, conn2)
                        cmd2.Parameters.AddWithValue("@courseName", cbxCoursePending.SelectedItem)
                        reader = cmd2.ExecuteReader()

                        While reader.Read
                            command.Parameters.AddWithValue("@courseID", reader.GetString("courseID"))
                        End While
                        reader.Close()

                    Catch ex As Exception
                        MessageBox.Show(ex.Message())
                    Finally
                        conn2.Close()
                        conn2.Dispose()
                    End Try
                    command.ExecuteNonQuery()
                    loadCourseData("Pending")
                    clearForm()
                Catch ex As Exception
                    MessageBox.Show(ex.Message())
                Finally
                    conn.Close()
                    conn.Dispose()
                End Try
            End If
        End If

    End Sub
End Class