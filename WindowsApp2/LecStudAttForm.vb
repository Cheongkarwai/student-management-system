Imports MySql.Data.MySqlClient
Public Class LecStudAttForm
    Private conn As New MySqlConnection("server=localhost;database=SIS;userid=root;password=root")
    Private adapter As MySqlDataAdapter
    Private reader As MySqlDataReader
    Private ds As DataSet
    Private command As MySqlCommand
    Private sql As String
    Private d1 As Date
    Private checkBoxCol As New DataGridViewCheckBoxColumn
    Private Sub LecManageStudForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        roundCornerModule.roundCorner(dgvAttendance)
        reloadTable()
        d1 = Date.Now()
        lblDate.Text = d1.Year & "-" & d1.Month & "-" & d1.Day
        checkBoxCol.HeaderText = "Attendance"
        checkBoxCol.Name = "cbxAttendance"
        dgvAttendance.ReadOnly = False
        dgvAttendance.Columns.Add(checkBoxCol)

        Try
            conn.Open()
            sql = "SELECT courseName FROM Course WHERE lecID = @lecID"
            command = New MySqlCommand(sql, conn)
            command.Parameters.AddWithValue("@lecID", LecForm.usernameVal)
            reader = command.ExecuteReader()

            While reader.Read
                cbxCourse.Items.Add(reader.GetString("courseName"))
            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message())
        Finally
            conn.Close()
        End Try
        cbxView.SelectedIndex = 0
    End Sub
    Private Sub reloadTable()
        dgvAttendance.DataSource = Nothing
        Try
            conn.Open()
            sql = "SELECT s.studentID,s.studentName,c.courseName,c.courseID FROM Student s
                    JOIN student_course sc
                    JOIN Course c
                    ON s.studentID = sc.studentID AND c.courseID = sc.courseID
                    WHERE courseName = @courseName AND sc.status = @status"
            command = New MySqlCommand(sql, conn)
            command.Parameters.AddWithValue("@courseName", cbxCourse.SelectedItem)
            command.Parameters.AddWithValue("@status", "Enrolled")
            adapter = New MySqlDataAdapter(command)
            ds = New DataSet()
            adapter.Fill(ds, "table")
            dgvAttendance.DataSource = ds.Tables("table")
        Catch ex As Exception
            MessageBox.Show(ex.Message())
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub submissionRecord()

        Dim recordCount As Integer = 0
        Try
            conn.Open()
            sql = "SELECT s.studentID,s.studentName,c.courseName,c.courseID,a.status FROM Student s
                    JOIN course c
                    JOIN Attendance a
                    ON s.studentID = a.studentID AND c.courseID = a.courseID
                    WHERE courseName = @courseName AND date = @date"
            command = New MySqlCommand(sql, conn)
            command.Parameters.AddWithValue("@courseName", cbxCourse.SelectedItem)
            command.Parameters.AddWithValue("@date", d1.Year & "-" & d1.Month & "-" & d1.Day)
            reader = command.ExecuteReader()
            While reader.Read
                For i = 0 To dgvAttendance.Rows.Count - 1
                    If reader.GetString("status") = "Y" And reader.GetString("studentID") = dgvAttendance.Rows(i).Cells("studentID").Value Then
                        dgvAttendance.Rows(i).Cells("cbxAttendance").Value = True
                    End If
                    dgvAttendance.Rows(i).Cells("cbxAttendance").ReadOnly = True
                Next
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message())
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub checkStat()

        Dim recordCount As Integer = 0

        Try
            conn.Open()
            sql = "SELECT s.studentID,s.studentName,c.courseName,c.courseID,a.status FROM Student s
                    JOIN course c
                    JOIN Attendance a
                    ON s.studentID = a.studentID AND c.courseID = a.courseID
                    WHERE courseName = @courseName AND date = @date"
            command = New MySqlCommand(sql, conn)
            command.Parameters.AddWithValue("@courseName", cbxCourse.SelectedItem)
            command.Parameters.AddWithValue("@date", d1.Year & "-" & d1.Month & "-" & d1.Day)
            reader = command.ExecuteReader()
            While reader.Read
                recordCount = recordCount + 1
            End While
            If cbxCourse.SelectedIndex >= 0 Then
                If recordCount > 0 Then
                    lblStatus1.Text = "Submitted"
                Else
                    lblStatus1.Text = "Pending"
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message())
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs)
        If cbxCourse.SelectedIndex >= 0 Then

        Else
            MessageBox.Show("Please select a course")
        End If
    End Sub

    Private Sub cbxCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCourse.SelectedIndexChanged
        If cbxView.SelectedIndex = 0 Then
            reloadTable()
            checkStat()
            If lblStatus1.Text = "Pending" Then
                btnSubmit.Enabled = True
                btnUpdate.Enabled = False
            ElseIf lblStatus1.Text = "Submitted" Then
                btnUpdate.Enabled = True
                btnSubmit.Enabled = False
            End If
        Else
            reloadTable()
            submissionRecord()
            lblStatus1.Text = ""
        End If

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If cbxCourse.SelectedIndex >= 0 Then
            Try
                conn.Open()
                sql = "INSERT INTO Attendance(studentID,courseID,date,status,reviewStat) VALUES (@studentID,@courseID,@date,@status,@reviewStat)"
                command = New MySqlCommand(sql, conn)
                For i = 0 To dgvAttendance.Rows.Count - 1
                    command.Parameters.Clear()
                    command.Parameters.AddWithValue("@studentID", dgvAttendance.Rows(i).Cells("studentID").Value)
                    command.Parameters.AddWithValue("@courseID", dgvAttendance.Rows(i).Cells("courseID").Value)
                    command.Parameters.AddWithValue("@date", d1.Year & "-" & d1.Month & "-" & d1.Day)
                    Dim isChecked As Boolean = dgvAttendance.Rows(i).Cells("cbxAttendance").Value
                    If isChecked Then
                        command.Parameters.AddWithValue("@status", "Y")
                    Else
                        command.Parameters.AddWithValue("@status", "N")
                    End If
                    command.Parameters.AddWithValue("@reviewStat", "Pending")
                    command.Parameters.AddWithValue("@submittedTime", Date.Now())
                    command.ExecuteNonQuery()
                Next
                MessageBox.Show("Attendance of " & d1.Year & "-" & d1.Month & "-" & d1.Day & " has been submitted for course " & cbxCourse.SelectedItem().ToString())
            Catch ex As Exception
                MessageBox.Show(ex.Message())
            Finally
                conn.Close()
                reloadTable()
                checkStat()
                If lblStatus1.Text = "Pending" Then
                    btnSubmit.Enabled = True
                    btnUpdate.Enabled = False
                ElseIf lblStatus1.Text = "Submitted" Then
                    btnUpdate.Enabled = True
                    btnSubmit.Enabled = False
                End If
            End Try
        Else
            MessageBox.Show("Please select a course")
        End If

    End Sub

    Private Sub cbxView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxView.SelectedIndexChanged
        If cbxView.SelectedIndex = 0 Then
            dgvAttendance.ReadOnly = False
            reloadTable()
            checkStat()
            lblStatus.Visible = True
            If cbxCourse.SelectedIndex >= 0 Then
                If lblStatus1.Text = "Pending" Then
                    btnSubmit.Enabled = True
                    btnUpdate.Enabled = False
                ElseIf lblStatus1.Text = "Submitted" Then
                    btnUpdate.Enabled = True
                    btnSubmit.Enabled = False
                End If
            Else
                btnUpdate.Enabled = False
                btnSubmit.Enabled = False
            End If
        ElseIf cbxView.SelectedIndex = 1 Then
                dgvAttendance.ReadOnly = True
            reloadTable()
            submissionRecord()
            lblStatus1.Text = ""
            lblStatus.Visible = False
            btnSubmit.Enabled = False
            btnUpdate.Enabled = False
        End If


    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If cbxCourse.SelectedIndex >= 0 Then
            Try
                Dim sql As String = "UPDATE Attendance SET status = @status WHERE studentID = @studentID And reviewStat = @reviewStat"

                conn.Open()
                command = New MySqlCommand(sql, conn)

                For i = 0 To dgvAttendance.Rows.Count - 1
                    command.Parameters.Clear()
                    Dim isChecked As Boolean = dgvAttendance.Rows(i).Cells("cbxAttendance").Value
                    If isChecked Then
                        command.Parameters.AddWithValue("@status", "Y")
                    Else
                        command.Parameters.AddWithValue("@status", "N")
                    End If
                    command.Parameters.AddWithValue("@studentID", dgvAttendance.Rows(i).Cells("studentID").Value)
                    command.Parameters.AddWithValue("@reviewStat", "Pending")
                    command.ExecuteNonQuery()
                Next
                MessageBox.Show("Attendance for " & Date.Now() & " has been updated")
            Catch ex As Exception
                MessageBox.Show(ex.Message())

            Finally
                conn.Close()
            End Try
        Else
            MessageBox.Show("Please select a course")
        End If
    End Sub


End Class

Class MyException : Inherits Exception
    Public Sub New(msg As String)
        MyBase.New(msg)
    End Sub
End Class