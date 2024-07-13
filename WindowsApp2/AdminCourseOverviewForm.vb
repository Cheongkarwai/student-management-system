Imports MySql.Data.MySqlClient
Public Class AdminCourseOverviewForm
    Private conn As New MySqlConnection("server=localhost;database=SIS;userid=root;password=root")
    Private adapter As MySqlDataAdapter
    Private reader As MySqlDataReader
    Private ds As DataSet
    Private command As MySqlCommand
    Private sql As String
    Private Sub AdminCourseOverviewForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        roundCornerModule.roundCorner(dgvCourseOverview)
        reloadTable()
        cbxSort.SelectedIndex = 0
    End Sub

    Private Sub reloadTable()
        dgvCourseOverview.DataSource = Nothing
        Try
            conn.Open()
            sql = "SELECT c.courseID AS Course_ID,c.courseName AS Course_Name,p.programmeName AS Programme_Name,c.creditHour AS Credit_Hour,c.semester AS Semester,COUNT(sc.studentID) AS Number_Of_Students,l.lecID AS LecID,l.lecName AS LecName
                    FROM Course c 
                    JOIN Lecturer l ON c.lecID = l.lecID
                    LEFT JOIN Student_Course sc 
                    ON c.courseID = sc.courseID
                    LEFT JOIN Student s 
                    ON sc.studentID = s.studentID
                    RIGHT JOIN Programme p 
                    ON p.programmeID = c.programmeID
                    GROUP BY c.courseID
                    ORDER BY p.programmeName ASC"
            adapter = New MySqlDataAdapter(sql, conn)
            ds = New DataSet()
            adapter.Fill(ds, "table")
            dgvCourseOverview.DataSource = ds.Tables("table")

        Catch ex As Exception
            MessageBox.Show(ex.Message())
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub sortTable(sql As String)
        dgvCourseOverview.DataSource = Nothing
        Try
            conn.Open()
            Me.sql = sql
            adapter = New MySqlDataAdapter(sql, conn)
            ds = New DataSet()
            adapter.Fill(ds, "table")
            dgvCourseOverview.DataSource = ds.Tables("table")

        Catch ex As Exception
            MessageBox.Show(ex.Message())
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub cbxSort_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxSort.SelectedIndexChanged

        If cbxSort.SelectedIndex = 0 Then
            sortTable("SELECT c.courseID AS Course_ID,c.courseName AS Course_Name,p.programmeName AS Programme_Name,c.creditHour AS Credit_Hour,c.semester AS Semester,COUNT(sc.studentID) AS Number_Of_Students,l.lecID AS LecID,l.lecName AS LecName
                        FROM Course c 
                        JOIN Lecturer l ON c.lecID = l.lecID
                        LEFT JOIN Student_Course sc 
                        ON c.courseID = sc.courseID
                        LEFT JOIN Student s 
                        ON sc.studentID = s.studentID
                        RIGHT JOIN Programme p 
                        ON p.programmeID = c.programmeID
                        GROUP BY c.courseID
                        ORDER BY p.programmeName ASC")

        ElseIf cbxSort.SelectedIndex = 1 Then
            sortTable("SELECT c.courseID AS Course_ID,c.courseName AS Course_Name,p.programmeName AS Programme_Name,c.creditHour AS Credit_Hour,c.semester AS Semester,COUNT(sc.studentID) AS Number_Of_Students,l.lecID AS LecID,l.lecName AS LecName
                        FROM Course c 
                        JOIN Lecturer l ON c.lecID = l.lecID
                        LEFT JOIN Student_Course sc 
                        ON c.courseID = sc.courseID
                        LEFT JOIN Student s 
                        ON sc.studentID = s.studentID
                        RIGHT JOIN Programme p 
                        ON p.programmeID = c.programmeID
                        GROUP BY c.courseID
                        ORDER BY Number_Of_Students ASC")
        ElseIf cbxSort.SelectedIndex = 2 Then
            sortTable("SELECT c.courseID AS Course_ID,c.courseName AS Course_Name,p.programmeName AS Programme_Name,c.creditHour AS Credit_Hour,c.semester AS Semester,COUNT(sc.studentID) AS Number_Of_Students,l.lecID AS LecID,l.lecName AS LecName
                        FROM Course c 
                        JOIN Lecturer l ON c.lecID = l.lecID
                        LEFT JOIN Student_Course sc 
                        ON c.courseID = sc.courseID
                        LEFT JOIN Student s 
                        ON sc.studentID = s.studentID
                        RIGHT JOIN Programme p 
                        ON p.programmeID = c.programmeID
                        GROUP BY c.courseID
                        ORDER BY Credit_Hour ASC")
        End If
    End Sub


End Class