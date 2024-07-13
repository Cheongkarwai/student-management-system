Imports MySql.Data.MySqlClient
Public Class LecDashboardForm
    Private conn As New MySqlConnection("server=localhost;database=SIS;userid=root;password=root")

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        loadClass()
        loadStudentClass()
    End Sub
    Private Sub LecDashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        roundCornerModule.roundCorner(panelStud)
        roundCornerModule.roundCorner(panelClass)
        roundCornerModule.roundCorner(dgvClass)

    End Sub

    Public Sub loadClass()
        Try
            conn.Open()
            Dim sql As String = "SELECT courseID,courseName,semester FROM Course c 
                                WHERE lecID = @lecID"
            Dim cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@lecID", LecForm.usernameVal)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim ds As New DataSet()
            adapter.Fill(ds, "table")
            dgvClass.DataSource = ds.Tables("table")

        Catch ex As Exception
            MessageBox.Show(ex.Message())
        Finally
            conn.Close()
        End Try
    End Sub

    Public Sub loadStudentClass()

        Dim cmd As MySqlCommand
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim sql As String = "SELECT COUNT(DISTINCT s.studentID) AS NumberOfStudent FROM Student s
                                JOIN student_course sc 
                                JOIN Course c
                                ON s.studentID = sc.studentID AND sc.courseID = c.courseID
                                WHERE lecID = @lecID"
            cmd = New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@lecID", LecForm.usernameVal)
            reader = cmd.ExecuteReader()

            While reader.Read
                txtStud.Text = reader.GetString(0)
            End While

            cmd.Cancel()
            reader.Close()


            sql = "SELECT COUNT(courseID) FROM Course
                    WHERE lecID = @lecID"
            cmd = New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@lecID", LecForm.usernameVal)
            reader = cmd.ExecuteReader()

            While reader.Read
                txtClass.Text = reader.GetString(0)
            End While

            cmd.Cancel()
            reader.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message())
        Finally
            conn.Close()
        End Try

    End Sub
End Class