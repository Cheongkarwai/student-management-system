Imports MySql.Data.MySqlClient
Public Class AdminTimetableForm
    Private conn As New MySqlConnection("server=localhost;database=SIS;userid=root;password=root")
    Private reader As MySqlDataReader
    Private cmd As MySqlCommand
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clear()

    End Sub

    Private Sub clear()
        cbxLecturer.SelectedIndex = -1
        cbxCourse.SelectedIndex = -1
        cbxDay.SelectedIndex = -1
        cbxTime.SelectedIndex = -1
        lblLecturer.Text = "-"
        lblTime.Text = "-"
        lblDay.Text = "-"
        lblCourseID.Text = "-"
    End Sub

    Private Sub btnSet_Click(sender As Object, e As EventArgs) Handles btnSet.Click

        If cbxLecturer.SelectedIndex >= 0 And cbxCourse.SelectedIndex >= 0 And cbxDay.SelectedIndex >= 0 And cbxTime.SelectedIndex >= 0 Then
            Try
                conn.Open()
                Dim sql As String = "INSERT INTO Timetable VALUES (@lecID,@timeFrom,@timeTo,@courseID,@day)"
                cmd = New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@lecID", cbxLecturer.SelectedItem())
                cmd.Parameters.AddWithValue("@timeFrom", cbxTime.SelectedItem.ToString().Substring(0, 5))
                cmd.Parameters.AddWithValue("@timeTo", cbxTime.SelectedItem.ToString().Substring(9, 5))
                cmd.Parameters.AddWithValue("@courseID", cbxCourse.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@day", cbxDay.SelectedItem)

                cmd.ExecuteNonQuery()
                MessageBox.Show("Successfully added timetable for lecturer ID : " & cbxLecturer.SelectedItem())

            Catch ex As Exception
                MessageBox.Show(ex.Message() & "(Unable to locate this lecturer in this time slot)")
            Finally
                conn.Close()
            End Try
        Else
            MessageBox.Show("Please fill in all the required form ")
        End If
    End Sub

    Private Sub AdminTimetableForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadLec()

    End Sub

    Private Sub loadLec()

        cbxLecturer.Items.Clear()
        Try
            conn.Open()
            Dim sql As String = "SELECT * FROM Lecturer"
            cmd = New MySqlCommand(sql, conn)
            reader = cmd.ExecuteReader()

            While reader.Read()
                cbxLecturer.Items.Add(reader.GetString("lecID"))
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message())
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub cbxLecturer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxLecturer.SelectedIndexChanged
        cbxCourse.Items.Clear()

        Try
            conn.Open()
            Dim sql As String = "SELECT courseID FROM Course c
                                JOIN Lecturer l
                                ON c.lecID = l.lecID
                                WHERE c.lecID = @lecID"
            cmd = New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@lecID", cbxLecturer.SelectedItem)

            reader = cmd.ExecuteReader()

            While reader.Read()
                cbxCourse.Items.Add(reader.GetString("courseID"))
            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message())
        Finally
            conn.Close()
        End Try

        If cbxLecturer.SelectedIndex >= 0 Then
            lblLecturer.Text = cbxLecturer.SelectedItem
        Else
            lblLecturer.Text = "-"
        End If
    End Sub

    Private Sub cbxCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCourse.SelectedIndexChanged
        If cbxCourse.SelectedIndex >= 0 Then
            lblCourseID.Text = cbxCourse.SelectedItem
        Else
            lblCourseID.Text = "-"
        End If
    End Sub

    Private Sub cbxDay_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxDay.SelectedIndexChanged
        If cbxDay.SelectedIndex >= 0 Then
            lblDay.Text = cbxDay.SelectedItem
        Else
            lblDay.Text = "-"
        End If
    End Sub

    Private Sub cbxTime_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxTime.SelectedIndexChanged
        If cbxTime.SelectedIndex >= 0 Then
            lblTime.Text = cbxTime.SelectedItem
        Else
            lblTime.Text = "-"
        End If
    End Sub
End Class