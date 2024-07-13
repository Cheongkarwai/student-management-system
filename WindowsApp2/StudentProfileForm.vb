Imports MySql.Data.MySqlClient
Public Class StudentProfileForm
    Private conn As New MySqlConnection("server=localhost;database=SIS;userid=root;password=root")
    Private Sub linkLogout_Click(sender As Object, e As EventArgs) Handles linkLogout.Click
        StudentForm.Hide()
        Dim loginPage As New login()
        loginPage.Show()
        loginPage.clear()
    End Sub

    Private Sub linkEditProfile_Click(sender As Object, e As EventArgs) Handles linkEditProfile.Click
        cancelEditProf.Visible = True
        txtName.Enabled = True
        txtEmail.Enabled = True
        txtContact.Enabled = True
        txtName.Cursor = Cursors.IBeam
        txtEmail.Cursor = Cursors.IBeam
        txtContact.Cursor = Cursors.IBeam
        linkChangePass.Enabled = False
        linkLogout.Enabled = False
        LecForm.btnLogout.Enabled = False
    End Sub
    Private Sub linkChangePass_Click(sender As Object, e As EventArgs) Handles linkChangePass.Click
        cancelChangePass.Visible = True
        txtPass.Enabled = True
        txtPass.Cursor = Cursors.IBeam
        linkEditProfile.Enabled = False
        linkLogout.Enabled = False
        LecForm.btnLogout.Enabled = False
    End Sub
    Private Sub cancelEditProf_Click(sender As Object, e As EventArgs) Handles cancelEditProf.Click
        validateName()
        validateEmail()
        validatePhoneNumber()

        If errorName.GetError(txtName) = "Success" And errorContact.GetError(txtContact) = "Success" And errorEmail.GetError(txtEmail) = "Success" Then
            Try
                conn.Open()
                Dim sql As String = "UPDATE Student
                                    SET studentName = @name,contactNo = @contact,emailAddress = @email
                                    WHERE studentID = @studentID"
                Dim cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@name", txtName.Text)
                cmd.Parameters.AddWithValue("@contact", txtContact.Text)
                cmd.Parameters.AddWithValue("@email", txtEmail.Text)
                cmd.Parameters.AddWithValue("@studentID", txtUsername.Text)
                cmd.ExecuteNonQuery()
                MessageBox.Show("You have successfully update your details")

                clearAllError()
                txtName.Enabled = False
                txtEmail.Enabled = False
                txtContact.Enabled = False
                txtName.Cursor = Cursors.Arrow
                txtEmail.Cursor = Cursors.Arrow
                txtContact.Cursor = Cursors.Arrow
                linkChangePass.Enabled = True
                linkLogout.Enabled = True
                cancelEditProf.Visible = False
                LecForm.btnLogout.Enabled = True
            Catch ex As Exception
                MessageBox.Show(ex.Message())
            Finally
                conn.Close()
            End Try
        Else
            MessageBox.Show("Please resolve the red warning")
        End If


    End Sub

    Public Sub clearAllError()
        errorPass.Dispose()
        errorName.Dispose()
        errorContact.Dispose()
        errorEmail.Dispose()

    End Sub

    Private Sub validateEmail()
        If txtEmail.Text.Length > 0 Then
            If (txtEmail.Text.Trim Like "*@[A-Z]*.*" Or txtEmail.Text.Trim Like "*@[a-z]*.*" Or txtEmail.Text.Trim Like "*@[0-9]*.*" Or txtEmail.Text.Trim Like "*@[a-z]*-[a-z]*.*") And Not txtEmail.Text.Trim Like "@*.*" Then
                setSuccessMsg(errorEmail, txtEmail, "Success")
            Else
                setErrorMsg(errorEmail, txtEmail, "Invalid email Address")
            End If
        Else
            setErrorMsg(errorEmail, txtEmail, "Please fill in email address")
        End If
    End Sub
    Private Sub validateName()
        If txtName.Text.Length > 0 Then
            Dim isAlpha As Boolean
            For Each c As Char In txtName.Text
                If Char.IsLetter(c) Or c = " " Then
                    isAlpha = True
                Else
                    isAlpha = False
                    Exit For
                End If
            Next
            If isAlpha Then
                setSuccessMsg(errorName, txtName, "Success")
            Else
                setErrorMsg(errorName, txtName, "Invalid name")
            End If
        Else
            setErrorMsg(errorName, txtName, "Please fill in name")
        End If
    End Sub

    Private Sub validatePhoneNumber()
        If txtContact.Text.Length > 0 Then
            If txtContact.Text Like "6011-########" Then
                setSuccessMsg(errorContact, txtContact, "Success")
            ElseIf txtContact.Text Like "601[2-9]-#######" Then
                setSuccessMsg(errorContact, txtContact, "Success")
            Else
                setErrorMsg(errorContact, txtContact, "Invalid contact number eg.601[2-9]-####### Or 6011-########")
            End If
        Else
            setErrorMsg(errorContact, txtContact, "Please fill in contact")
        End If
    End Sub

    Private Sub validatePass()
        If txtPass.Text.Length > 0 Then
            Dim isValid As Boolean
            Dim alpha As Integer = 0
            Dim num As Integer = 0
            For Each c As Char In txtPass.Text
                If Char.IsUpper(c) Then
                    alpha = alpha + 1
                ElseIf Char.IsNumber(c) Then
                    num = num + 1
                End If
            Next
            If alpha >= 3 And num >= 3 And txtPass.Text.Length >= 6 Then
                isValid = True
            Else
                isValid = False
            End If

            If isValid Then
                setSuccessMsg(errorPass, txtPass, "Success")
            Else
                setErrorMsg(errorPass, txtPass, "Must consists atleast 3 uppercase,3 digit and length of 6")
            End If
        Else
            setErrorMsg(errorPass, txtPass, "Please fill in password")
        End If
    End Sub
    Private Sub setErrorMsg(e As ErrorProvider, control As Control, msg As String)
        e.SetError(control, msg)
        e.Icon = New Icon("C:\Users\Asus\Documents\Visual Studio 2022\Project\WindowsApp2\icon\sign_cancel.ico")
    End Sub

    Private Sub setSuccessMsg(e As ErrorProvider, control As Control, msg As String)
        e.SetError(control, msg)
        e.Icon = New Icon("C:\Users\Asus\Documents\Visual Studio 2022\Project\WindowsApp2\icon\sign_tick.ico")
    End Sub
    Private Sub setWarningIconPadding(e As ErrorProvider, control As Control, padding As Integer)
        e.SetIconPadding(control, padding)
    End Sub

    Private Sub StudentProfileForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn.Open()
            Dim sql As String = "SELECT studentName,contactNo,emailAddress,p.programmeName,s.semester FROM Student s
                                JOIN Programme p 
                                ON s.programmeID = p.programmeID
                                WHERE s.studentID = @studentID"
            Dim cmd As MySqlCommand = New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@studentID", StudentForm.usernameVal)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                txtName.Text = reader.GetString("studentName")
                txtContact.Text = reader.GetString("contactNo")
                txtEmail.Text = reader.GetString("emailAddress")
                txtProgramme.Text = reader.GetString("programmeName")
                txtSem.Text = reader.GetString("semester")
            End While

            txtUsername.Text = StudentForm.usernameVal
            txtPass.Text = StudentForm.passVal

        Catch ex As Exception
            MessageBox.Show(ex.Message())
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub cancelChangePass_Click(sender As Object, e As EventArgs) Handles cancelChangePass.Click

        validatePass()
        If errorPass.GetError(txtPass) = "Success" Then
            Try
                conn.Open()
                Dim sql As String = "UPDATE Account
                                SET password = @pass
                                WHERE studentID = @studentID"
                Dim cmd As MySqlCommand = New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@pass", txtPass.Text)
                cmd.Parameters.AddWithValue("@studentID", StudentForm.usernameVal)

                cmd.ExecuteNonQuery()
                MessageBox.Show("You have successfully update your password")

            Catch ex As Exception
                MessageBox.Show(ex.Message())
            Finally
                conn.Close()
            End Try

            cancelChangePass.Visible = False
            txtPass.Enabled = False
            txtPass.Cursor = Cursors.Arrow
            linkEditProfile.Enabled = True
            linkLogout.Enabled = True
            LecForm.btnLogout.Enabled = True
            clearAllError()

        Else
            MessageBox.Show("Please resolve the red warning")
        End If
    End Sub
End Class