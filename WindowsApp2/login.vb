Imports MySql.Data.MySqlClient
Public Class login
    Dim conn As MySqlConnection = New MySqlConnection("server=localhost;database=SIS;userid=root;password=root")




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim count As Integer = 0
        Dim role As String = cbxRole.SelectedItem
        If cbxRole.SelectedIndex < 0 Then
            MessageBox.Show("Please select a role before proceed")
        Else
            If txtID.Text.Length > 0 And txtPass.Text.Length > 0 Then
                If cbxRole.SelectedIndex = 0 Then
                    count = checkAcc("SELECT a.studentID,password,p.programmeID,semester FROM Account a
                                    JOIN Programme p
                                    JOIN Student s
                                    ON a.studentID = s.studentID AND s.programmeID = p.programmeID
                                    WHERE a.studentID = @id AND password = @pass")
                ElseIf cbxRole.SelectedIndex = 1 Then
                    count = checkAcc("SELECT a.lecID,password,d.depID AS depID,depName FROM Account a
                                JOIN Lecturer l
                                JOIN Department d
                                ON a.lecID = l.lecID AND l.depID = d.depID
                                WHERE a.lecID = @id AND password = @pass")
                ElseIf cbxRole.SelectedIndex = 2 Then
                    count = checkAcc("SELECT a.adminID,password,d.depID,d.depName FROM Account a
                                 JOIN Department d
                                 JOIN Admin ad
                                 ON a.adminID = ad.adminID And ad.depID = d.depID
                                 WHERE a.adminID = @id AND password = @pass")
                End If
            Else
                MessageBox.Show("Please fill in username and password")
            End If
        End If

        If txtID.Text.Length > 0 And txtPass.Text.Length > 0 And cbxRole.SelectedIndex >= 0 Then
            If count > 0 Then
                If role = "Lecturer" Then
                    LecForm.Show()
                    Me.Hide()
                    LecForm.usernameVal = txtID.Text.Trim
                    LecForm.passVal = txtPass.Text.Trim
                    LecForm.activateBtn(LecForm.btnDashboard, Color.LightSkyBlue)
                    LecForm.openNewForm(New LecDashboardForm())
                ElseIf role = "Admin" Then
                    AdminForm.Show()
                    Me.Hide()
                    AdminForm.usernameVal = txtID.Text.Trim
                    AdminForm.passVal = txtPass.Text.Trim
                    AdminForm.openNewForm(New AdminDashboardForm())
                    AdminForm.activateBtn(AdminForm.btnDashboard, Color.LightSkyBlue)

                ElseIf role = "Student" Then
                    StudentForm.Show()
                    Me.Hide()
                    StudentForm.usernameVal = txtID.Text.Trim
                    StudentForm.passVal = txtPass.Text.Trim
                    StudentForm.activateBtn(StudentForm.btnDashboard, Color.LightSkyBlue)
                    StudentForm.openNewForm(New StudentDashboardForm())

                End If
            Else
                MessageBox.Show("Invalid username or password")
                txtPass.Text = ""
            End If
        End If
    End Sub


    Private Function checkAcc(sql As String) As Integer
        Dim count As Integer = 0
        Try
            conn.Open()
            Dim command As MySqlCommand
            Dim reader As MySqlDataReader
            command = New MySqlCommand(sql, conn)
            command.Parameters.AddWithValue("@id", txtID.Text.Trim)
            command.Parameters.AddWithValue("@pass", txtPass.Text.Trim)
            reader = command.ExecuteReader()
            While reader.Read()
                count = count + 1
                If cbxRole.SelectedItem = "Lecturer" Then
                    LecForm.depIDVal = reader.GetString("depID")
                    LecForm.depNameVal = reader.GetString("depName")
                ElseIf cbxRole.SelectedItem = "Admin" Then
                    AdminForm.depIDVal = reader.GetString("depID")
                    AdminForm.depNameVal = reader.GetString("depName")
                ElseIf cbxRole.SelectedItem = "Student" Then
                    StudentForm.programmeIDVal = reader.GetString("programmeID")
                    StudentForm.semesterVal = reader.GetString("semester")
                End If
            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message())
        Finally
            conn.Close()
        End Try

        Return count
    End Function

    Private Sub linkToRegister_Click(sender As Object, e As EventArgs) Handles linkToRegister.Click
        clear()
        RegistrationForm.Show()
        Me.Hide()
    End Sub

    Public Sub clear()
        cbxRole.SelectedIndex = -1
        txtID.Text = ""
        txtPass.Text = ""
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class