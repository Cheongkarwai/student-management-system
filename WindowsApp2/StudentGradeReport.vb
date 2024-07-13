Imports MySql.Data.MySqlClient
Public Class StudentGradeReport
    Private conn As New MySqlConnection("server=localhost;database=SIS;userid=root;password=root")

    Private Sub ManageClassForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        roundCornerModule.roundCorner(dgvGrade)
        roundCornerModule.roundCorner(panelGrade)
        For i As Integer = StudentForm.semesterVal To 1 Step -1
            cbxSem.Items.Add(i)
        Next

        cbxSem.SelectedIndex = 0
    End Sub

    Private Sub cbxSem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxSem.SelectedIndexChanged
        reloadTable()
        calcCGPA()
    End Sub

    Private Sub reloadTable()

        Try
            conn.Open()
            Dim sql As String = "SELECT c.courseID,creditHour,GPA,grade FROM GradeReport g
                                JOIN Course c
                                ON g.courseID = c.courseID
                                WHERE studentID = @studentID AND g.semester = @sem AND g.status = @stat"
            Dim cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@studentID", StudentForm.usernameVal)
            cmd.Parameters.AddWithValue("@sem", cbxSem.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@stat", "Success")
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim ds As New DataSet()
            adapter.Fill(ds, "table")
            dgvGrade.DataSource = ds.Tables("table")

        Catch ex As Exception
            MessageBox.Show(ex.Message())
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub calcCGPA()


        Dim totalGPA As Double = 0
        Dim totalCreditHour As Double = 0
        Dim cgpa As Double = 0
        Try
            conn.Open()
            Dim sql As String = "SELECT creditHour,GPA FROM GradeReport g
                  JOIN Course c
                  ON g.courseID = c.courseID
                  WHERE studentID = @studentID AND g.semester = @sem AND g.status = @stat"

            Dim cmd As MySqlCommand = New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@studentID", StudentForm.usernameVal)
            cmd.Parameters.AddWithValue("@sem", cbxSem.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@stat", "Success")
            Dim adapter As MySqlDataAdapter = New MySqlDataAdapter(cmd)
            Dim ds As DataSet = New DataSet()
            adapter.Fill(ds, "table2")
            Dim temp(ds.Tables("table2").Rows.Count - 1) As Double

            For i = 0 To ds.Tables("table2").Rows.Count - 1
                totalCreditHour = totalCreditHour + Double.Parse(ds.Tables("table2").Rows(i).Item("creditHour"))
                totalGPA = totalGPA + Double.Parse(ds.Tables("table2").Rows(i).Item("GPA"))
                temp(i) = Double.Parse(ds.Tables("table2").Rows(i).Item("creditHour")) * Double.Parse(ds.Tables("table2").Rows(i).Item("GPA"))
            Next
            If ds.Tables("table2").Rows.Count > 0 Then
                txtCreditHour.Text = totalCreditHour.ToString()
                txtGPA.Text = totalGPA.ToString()
                For i As Integer = 0 To temp.GetUpperBound(0)
                    cgpa = cgpa + temp(i)
                Next
                txtCGPA.Text = (cgpa / totalCreditHour).ToString()
            Else
                txtCreditHour.Text = "0"
                txtGPA.Text = "0"
                txtCGPA.Text = "0"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message())
        Finally
            conn.Close()
        End Try

    End Sub

End Class