Imports MySql.Data.MySqlClient

Public Class AdminECAForm
    Private conn As New MySqlConnection("server = localhost;database=SIS;userid=root;password=root;")
    Private adapter As MySqlDataAdapter
    Private ds As DataSet
    Private command As MySqlCommand
    Private reader As MySqlDataReader
    Private sql As String
    Private eventNo As Integer

    Private Sub AdminECAForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        roundCornerModule.roundCorner(dgvECA)
        roundCornerModule.roundCorner(panelSetECA)

        reloadTable()
        loadEventName()
        loadProgramme()
    End Sub

    Private Sub loadProgramme()
        cbxProgramme.Items.Clear()
        Try
            conn.Open()
            sql = "SELECT programmeName FROM Programme"
            command = New MySqlCommand(sql, conn)
            reader = command.ExecuteReader()
            While reader.Read()
                cbxProgramme.Items.Add(reader.GetString("programmeName"))
            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message())
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub loadEventName()
        cbxEvent.Items.Clear()
        Try
            conn.Open()
            sql = "SELECT eventName FROM cocurriculum"
            command = New MySqlCommand(sql, conn)
            reader = command.ExecuteReader()
            While reader.Read()
                cbxEvent.Items.Add(reader.GetString("eventName"))
            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message())
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub reloadTable()
        Try
            conn.Open()
            sql = "SELECT eventNo,eventName,point FROM Cocurriculum"
            command = New MySqlCommand(sql, conn)
            adapter = New MySqlDataAdapter(command)
            ds = New DataSet()
            adapter.Fill(ds, "table")

            dgvECA.DataSource = ds.Tables("table")

        Catch ex As Exception
            MessageBox.Show(ex.Message())
        Finally
            conn.Close()
        End Try
    End Sub





    Private Sub cbxProgramme_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxProgramme.SelectedIndexChanged
        cbxStudentID.Items.Clear()
        Try
            conn.Open()
            sql = "SELECT studentID FROM Student s
                    JOIN Programme p 
                    ON s.programmeID = p.programmeID
                    WHERE programmeName = @programmeName"
            command = New MySqlCommand(sql, conn)
            command.Parameters.AddWithValue("@programmeName", cbxProgramme.SelectedItem())
            reader = command.ExecuteReader()
            While reader.Read
                cbxStudentID.Items.Add(reader.GetString("studentID"))
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message())
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnAddECA_Click(sender As Object, e As EventArgs) Handles btnAddECA.Click

        If cbxEvent.SelectedIndex >= 0 And cbxProgramme.SelectedIndex >= 0 And cbxStudentID.SelectedIndex >= 0 Then
            Try
                conn.Open()

                sql = "INSERT INTO student_cocurriculum VALUES (@eventNo,@studentID)"
                command = New MySqlCommand(sql, conn)
                command.Parameters.AddWithValue("@eventNo", eventNo)
                command.Parameters.AddWithValue("@studentID", cbxStudentID.SelectedItem)
                command.ExecuteNonQuery()

                MessageBox.Show("Student ID " & cbxStudentID.SelectedItem & " has been awarded points for attending " & cbxEvent.SelectedItem)


            Catch ex As MySqlException
                MessageBox.Show(ex.Message() & "(This student was awarded points for attending this event)")
            Catch ex As Exception
                MessageBox.Show(ex.Message())
            Finally
                conn.Close()
                clear()
            End Try
        Else
            MessageBox.Show("Please fill in all the required form")
        End If

    End Sub




    Private Sub clear()
        cbxEvent.SelectedIndex = -1
        cbxProgramme.SelectedIndex = -1
        cbxStudentID.SelectedIndex = -1
        lblPoint.Text = "0"

    End Sub


    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        clear()
    End Sub

    Private Sub cbxEvent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxEvent.SelectedIndexChanged
        Try
            conn.Open()
            sql = "SELECT point,eventNo FROM Cocurriculum c
                    WHERE eventName = @eventName"
            command = New MySqlCommand(sql, conn)
            command.Parameters.AddWithValue("@eventName", cbxEvent.SelectedItem())
            reader = command.ExecuteReader()

            While reader.Read()
                lblPoint.Text = reader.GetString("point")
                eventNo = reader.GetString("eventNo")
            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message())
        Finally
            conn.Close()
        End Try
    End Sub
End Class