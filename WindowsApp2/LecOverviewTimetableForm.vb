Imports MySql.Data.MySqlClient
Public Class LecOverviewTimetableForm
    Private conn As New MySqlConnection("server=localhost;database=SIS;userid=root;password=root;")

    Private Sub LecOverviewTimetableForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        roundCornerModule.roundCorner(dgvTimetable)

        Dim dr(4) As DataGridViewRow
        For i As Integer = 0 To dr.GetUpperBound(0)
            dr(i) = New DataGridViewRow
            dgvTimetable.Rows.Add(dr(i))
            dgvTimetable.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(24, 30, 54)
            dgvTimetable.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
        Next



        dgvTimetable.Rows(0).HeaderCell.Value = "Monday"
        dgvTimetable.Rows(1).HeaderCell.Value = "Tuesday"
        dgvTimetable.Rows(2).HeaderCell.Value = "Wednesday"
        dgvTimetable.Rows(3).HeaderCell.Value = "Thursday"
        dgvTimetable.Rows(4).HeaderCell.Value = "Friday"

        loadTimetable()

    End Sub
    Private Sub loadTimetable()

        Try
            conn.Open()
            Dim sql As String = "SELECT timeTo,timeFrom,t.lecID,c.courseID,c.courseName,day FROM Timetable t
                                JOIN Course c
                                ON t.courseID = c.courseID
                                WHERE t.lecID = @lecID"
            Dim cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@lecID", LecForm.usernameVal)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read
                If reader.GetString("day") = "Monday" Then
                    dgvTimetable.Rows(0).Cells(checkTime(reader.GetString("timeFrom"), reader.GetString("timeTo"))).Value = reader.GetString("courseID") & " " & reader.GetString("courseName")
                ElseIf reader.GetString("day") = "Tuesday" Then
                    dgvTimetable.Rows(1).Cells(checkTime(reader.GetString("timeFrom"), reader.GetString("timeTo"))).Value = reader.GetString("courseID") & " " & reader.GetString("courseName")
                ElseIf reader.GetString("day") = "Wednesday" Then
                    dgvTimetable.Rows(2).Cells(checkTime(reader.GetString("timeFrom"), reader.GetString("timeTo"))).Value = reader.GetString("courseID") & " " & reader.GetString("courseName")
                ElseIf reader.GetString("day") = "Thursday" Then
                    dgvTimetable.Rows(3).Cells(checkTime(reader.GetString("timeFrom"), reader.GetString("timeTo"))).Value = reader.GetString("courseID") & " " & reader.GetString("courseName")
                ElseIf reader.GetString("day") = "Friday" Then
                    dgvTimetable.Rows(4).Cells(checkTime(reader.GetString("timeFrom"), reader.GetString("timeTo"))).Value = reader.GetString("courseID") & " " & reader.GetString("courseName")
                End If

            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message())
        Finally
            conn.Close()
        End Try
    End Sub

    Private Function checkTime(timeFrom As String, timeTo As String) As Integer

        Dim colCount As Integer = 0
        If timeFrom = "09:30:00" And timeTo = "11:00:00" Then
            colCount = 0
        ElseIf timeFrom = "11:00:00" And timeTo = "12:30:00" Then
            colCount = 1
        ElseIf timeFrom = "12:30:00" And timeTo = "14:00:00" Then
            colCount = 2
        ElseIf timeFrom = "14:00:00" And timeTo = "15:30:00" Then
            colCount = 3
        ElseIf timeFrom = "15:30:00" And timeTo = "17:00:00" Then
            colCount = 4
        End If

        Return colCount
    End Function

End Class