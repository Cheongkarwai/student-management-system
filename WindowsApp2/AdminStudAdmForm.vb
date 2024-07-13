Imports MySql.Data.MySqlClient
Imports System.IO
Public Class AdminStudAdmForm
    Private connString As String = "server=localhost;database=SIS;userid=root;password=root"
    Private conn As New MySqlConnection("server=localhost;database=SIS;userid=root;password=root")
    Private table As DataSet
    Private adapter As MySqlDataAdapter
    Private sql As String
    Private command As MySqlCommand
    Private reader As MySqlDataReader
    Private conn2 As New MySqlConnection("server=localhost;database=SIS;userid=root;password=root")
    Private conn3 As New MySqlConnection("server=localhost;database=SIS;userid=root;password=root")
    Private cmd2 As MySqlCommand
    Private sql2 As String
    Private Sub AdminStudAdmForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        roundCornerModule.roundCorner(panelEditAdm)
        roundCornerModule.roundCorner(dgvAdm)
        reloadAdmissionTable()
    End Sub
    Private Sub reloadAdmissionTable()

        dgvAdm.Rows.Clear()

        sql = "SELECT applicationNo,applicantName,ICNo,passportNo,country,contactNo,gender,DATE_FORMAT(dateOfBirth,'%Y-%m-%d') AS dateOfBirth,emailAddress,homeAddress,state,city,postcode,programme.programmeName,result FROM application INNER JOIN Programme WHERE application.programme = programme.programmeID"
        Try
            conn3.Open()
            command = New MySqlCommand(sql, conn3)
            reader = command.ExecuteReader()
            result.ImageLayout = DataGridViewImageCellLayout.Zoom

            While reader.Read()
                Dim rowId As Integer = dgvAdm.Rows.Add()
                Dim row As DataGridViewRow = dgvAdm.Rows(rowId)
                row.Cells("applicantNo").Value = reader.GetString("applicationNo")
                row.Cells("applicantName").Value = reader.GetString("applicantName")
                row.Cells("ic").Value = reader.GetString("ICNo")
                row.Cells("passport").Value = reader.GetString("passportNo")
                row.Cells("country").Value = reader.GetString("country")
                row.Cells("contact").Value = reader.GetString("contactNo")
                row.Cells("gender").Value = reader.GetString("gender")
                row.Cells("dateOfBirth").Value = reader.GetString("dateOfBirth")
                row.Cells("emailAddress").Value = reader.GetString("emailAddress")
                row.Cells("homeAddress").Value = reader.GetString("homeAddress")
                row.Cells("state").Value = reader.GetString("state")
                row.Cells("city").Value = reader.GetString("city")
                row.Cells("postcode").Value = reader.GetString("postcode")
                row.Cells("programme").Value = reader.GetString("programmeName")
                Dim img As Image = Image.FromStream(getImage(reader.GetString("applicationNo")))
                row.Cells("result").Value = img
                row.Cells("dateOfBirth").Style.Format = "YYYY-MM-DD"
            End While
            reader.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message())
        Finally
            conn3.Close()
        End Try

    End Sub

    Private Sub SortRecords(sql As String)
        dgvAdm.Rows.Clear()
        Try
            conn.Open()
            command = New MySqlCommand(sql, conn)
            reader = command.ExecuteReader()
            result.ImageLayout = DataGridViewImageCellLayout.Zoom

            While reader.Read()
                Dim rowId As Integer = dgvAdm.Rows.Add()
                Dim row As DataGridViewRow = dgvAdm.Rows(rowId)
                row.Cells("applicantNo").Value = reader.GetString("applicationNo")
                row.Cells("applicantName").Value = reader.GetString("applicantName")
                row.Cells("ic").Value = reader.GetString("ICNo")
                row.Cells("passport").Value = reader.GetString("passportNo")
                row.Cells("country").Value = reader.GetString("country")
                row.Cells("contact").Value = reader.GetString("contactNo")
                row.Cells("gender").Value = reader.GetString("gender")
                row.Cells("dateOfBirth").Value = reader.GetString("dateOfBirth")
                row.Cells("emailAddress").Value = reader.GetString("emailAddress")
                row.Cells("homeAddress").Value = reader.GetString("homeAddress")
                row.Cells("state").Value = reader.GetString("state")
                row.Cells("city").Value = reader.GetString("city")
                row.Cells("postcode").Value = reader.GetString("postcode")
                row.Cells("programme").Value = reader.GetString("programmeName")
                Dim img As Image = Image.FromStream(getImage(reader.GetString("applicationNo")))
                row.Cells("result").Value = img
            End While
            reader.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message())
        Finally
            conn.Close()
        End Try
    End Sub

    Private Function getImage(no As String) As MemoryStream
        Dim ms As MemoryStream
        Dim reader2 As MySqlDataReader
        Try
            conn2.Open()
            sql = "SELECT result FROM Application WHERE applicationNo = @no"
            command = New MySqlCommand(sql, conn2)
            command.Parameters.AddWithValue("@no", no)
            reader2 = command.ExecuteReader()
            While reader2.Read
                Dim bytes() As Byte = reader2.Item("result")
                ms = New MemoryStream(bytes)
            End While
            reader2.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message())
        Finally
            conn2.Close()
        End Try
        Return ms
    End Function
    Private Sub txtStudentID_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtStudentID.Validating

        If txtStudentID.Text.Length > 0 Then
            If txtStudentID.Text.Trim Like "##########" Then
                generateStudID()

            Else
                setErrorMsg(errorID, txtStudentID, "Please enter numbers and 10 character length")
            End If
        Else
            setErrorMsg(errorID, txtStudentID, "Please fill in student id")
        End If
    End Sub
    Private Sub generateStudID()

        setWarningIconPadding(errorID, txtStudentID, 4)

        Dim d1 As Date
        d1 = Date.Now()

        Try
            conn.Close()
            conn.Open()
            sql = "SELECT studentID FROM Student WHERE studentID LIKE '" & d1.Year & "%' ORDER BY studentID ASC"
            command = New MySqlCommand(sql, conn)
            command.Parameters.AddWithValue("@idprefix", d1.Year)
            adapter = New MySqlDataAdapter(command)
            table = New DataSet()
            adapter.Fill(table, "table")

            If table.Tables("table").Rows.Count > 0 Then
                Dim lastRow As Integer = table.Tables("table").Rows.Count - 1
                Dim currentID As Integer = Integer.Parse(table.Tables("table").Rows(lastRow).Item("studentID")) + 1
                txtStudentID.Text = currentID
            Else
                txtStudentID.Text = d1.Year & "000" & "000"
            End If
            setSuccessMsg(errorID, txtStudentID, "Success")



        Catch ex As Exception
            MessageBox.Show(ex.Message())
        Finally
            conn.Close()
        End Try
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

    Private Sub dgvAdm_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAdm.CellContentClick

        txtName.Text = dgvAdm.CurrentRow.Cells(1).Value.ToString()
        txtIC.Text = dgvAdm.CurrentRow.Cells(2).Value.ToString()
        txtPassport.Text = dgvAdm.CurrentRow.Cells(3).Value.ToString()
        txtCountry.Text = dgvAdm.CurrentRow.Cells(4).Value.ToString()
        txtContact.Text = dgvAdm.CurrentRow.Cells(5).Value.ToString()
        txtGender.Text = dgvAdm.CurrentRow.Cells(6).Value.ToString()
        txtDOB.Text = dgvAdm.CurrentRow.Cells(7).Value.ToString()
        txtEmail.Text = dgvAdm.CurrentRow.Cells(8).Value.ToString()
        txtAddress.Text = dgvAdm.CurrentRow.Cells(9).Value.ToString()
        txtState.Text = dgvAdm.CurrentRow.Cells(10).Value.ToString()
        txtCity.Text = dgvAdm.CurrentRow.Cells(11).Value.ToString()
        txtPostcode.Text = dgvAdm.CurrentRow.Cells(12).Value.ToString()
        txtProgramme.Text = dgvAdm.CurrentRow.Cells(13).Value.ToString()
        pic.Image = Image.FromStream(getImage(dgvAdm.CurrentRow.Cells(0).Value.ToString()))
        generateStudID()

    End Sub

    Private Sub txtStudentID_TextChanged(sender As Object, e As EventArgs) Handles txtStudentID.TextChanged
        txtStudentEmail.Text = ""
        Dim email As String = "@ucsicollege.edu.my"
        txtStudentEmail.Text = txtStudentID.Text & email
    End Sub

    Private Function checkNullField(txtBox As TextBox) As Boolean
        If txtBox.Text.Trim.Length > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub cbxAdm_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxAdm.SelectedIndexChanged
        If cbxAdm.SelectedIndex = 0 Then
            SortRecords("SELECT applicationNo,applicantName,ICNo,passportNo,country,contactNo,gender,dateOfBirth,emailAddress,homeAddress,state,city,postcode,programme.programmeName,result FROM application INNER JOIN Programme WHERE application.programme = programme.programmeID ORDER BY applicationNo")
        ElseIf cbxAdm.SelectedIndex = 1 Then
            SortRecords("SELECT applicationNo, applicantName, ICNo, passportNo, country, contactNo, gender, dateOfBirth, emailAddress, homeAddress, state, city, postcode, programme.programmeName, result FROM application INNER JOIN Programme WHERE application.programme = programme.programmeID ORDER BY applicantName")
        ElseIf cbxAdm.SelectedIndex = 2 Then
            SortRecords("SELECT applicationNo,applicantName,ICNo,passportNo,country,contactNo,gender,dateOfBirth,emailAddress,homeAddress,state,city,postcode,programme.programmeName,result FROM application INNER JOIN Programme WHERE application.programme = programme.programmeID ORDER BY programmeName")
        End If

    End Sub

    Private Sub btnAdmAdd_Click(sender As Object, e As EventArgs) Handles btnAdmAdd.Click
        Dim writer As StreamWriter
        writer = My.Computer.FileSystem.OpenTextFileWriter(txtName.Text & " " & txtStudentID.Text & ".txt", False)

        If checkNullField(txtName) And checkNullField(txtStudentEmail) And checkNullField(txtStudentID) And (checkNullField(txtIC) Or checkNullField(txtPassport)) And checkNullField(txtGender) And checkNullField(txtDOB) And checkNullField(txtCountry) And checkNullField(txtEmail) And checkNullField(txtProgramme) And checkNullField(txtAddress) And checkNullField(txtState) And checkNullField(txtCity) And checkNullField(txtPostcode) And checkNullField(txtContact) And (Not pic.Image Is Nothing) Then
            If errorID.GetError(txtStudentID) = "Success" Then
                Try
                    sql = "INSERT INTO Student(studentID,studentName,ICNo,passportNo,country,contactNo,gender,dateOfBirth,emailAddress,homeAddress,state,city,postcode,programmeID,studentEmail) VALUES (@studentID,@studentName,@ICNo,@passportNo,@country,@contactNo,@gender,@dateOfBirth,@emailAddress,@homeAddress,@state,@city,@postcode,@programmeID,@studentEmail)"
                    conn.Open()
                    command = New MySqlCommand(sql, conn)
                    command.Parameters.AddWithValue("@studentName", txtName.Text)
                    command.Parameters.AddWithValue("@studentID", txtStudentID.Text)
                    command.Parameters.AddWithValue("@ICNo", txtIC.Text)
                    command.Parameters.AddWithValue("@passportNo", txtPassport.Text)
                    command.Parameters.AddWithValue("@country", txtCountry.Text)
                    command.Parameters.AddWithValue("@contactNo", txtContact.Text)
                    command.Parameters.AddWithValue("@gender", txtGender.Text)
                    command.Parameters.AddWithValue("@dateOfBirth", txtDOB.Text)
                    command.Parameters.AddWithValue("@emailAddress", txtEmail.Text)
                    command.Parameters.AddWithValue("@homeAddress", txtAddress.Text)
                    command.Parameters.AddWithValue("@state", txtState.Text)
                    command.Parameters.AddWithValue("@city", txtCity.Text)
                    command.Parameters.AddWithValue("@postcode", txtPostcode.Text)
                    command.Parameters.AddWithValue("@studentEmail", txtStudentEmail.Text)
                    writer.WriteLine("Student Name : " & txtName.Text)
                    writer.WriteLine("Student ID : " & txtStudentID.Text)
                    writer.WriteLine("IC No : " & txtIC.Text)
                    writer.WriteLine("Passport No : " & txtPassport.Text)
                    writer.WriteLine("Country : " & txtCountry.Text)
                    writer.WriteLine("Contact No : " & txtContact.Text)
                    writer.WriteLine("Gender : " & txtGender.Text)
                    writer.WriteLine("Date Of Birth : " & txtDOB.Text)
                    writer.WriteLine("Email Address : " & txtEmail.Text)
                    writer.WriteLine("Home Address : " & txtAddress.Text)
                    writer.WriteLine("State : " & txtState.Text)
                    writer.WriteLine("City : " & txtCity.Text)
                    writer.WriteLine("Postcode : " & txtPostcode.Text)
                    writer.WriteLine("Student Email : " & txtStudentEmail.Text)
                    writer.Close()
                    Try
                        sql2 = "SELECT programmeID FROM Programme WHERE programmeName = @programmeName"
                        cmd2 = New MySqlCommand(sql2, conn)
                        cmd2.Parameters.AddWithValue("@programmeName", txtProgramme.Text)
                        reader = cmd2.ExecuteReader()

                        While reader.Read()
                            command.Parameters.AddWithValue("@programmeID", reader.GetString("programmeID"))
                        End While

                        reader.Close()

                    Catch ex As Exception
                        MessageBox.Show(ex.Message())
                    Finally
                    End Try

                    command.ExecuteNonQuery()
                    MessageBox.Show(txtName.Text & " " & txtStudentID.Text & " has officially become our UCSI College Student!")
                    Try
                        sql2 = "INSERT INTO Account(studentID,password) VALUES (@studentID,@password)"
                        cmd2 = New MySqlCommand(sql2, conn)
                        cmd2.Parameters.AddWithValue("@studentID", txtStudentID.Text.Trim)
                        cmd2.Parameters.AddWithValue("@password", txtStudentID.Text & "abc")

                        cmd2.ExecuteNonQuery()

                    Catch ex As Exception
                        MessageBox.Show(ex.Message())
                    End Try
                    deleteRecord()
                    clearForm()
                    reloadAdmissionTable()
                Catch ex As Exception
                    MessageBox.Show(txtStudentID.Text & " has been used by another student. Please enter another student ID " & ex.Message())
                Finally
                    conn.Close()
                End Try
            Else
                MessageBox.Show("Invalid student ID")
            End If
        Else
            MessageBox.Show("Please select a record")
        End If

        errorID.Dispose()
    End Sub

    Private Sub deleteRecord()

        Try

            sql2 = "DELETE FROM Application WHERE applicationNo = @no"
            cmd2 = New MySqlCommand(sql2, conn)
            cmd2.Parameters.AddWithValue("@no", dgvAdm.CurrentRow.Cells(0).Value.ToString())
            cmd2.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show(ex.Message())
        Finally

        End Try
    End Sub
    Private Sub btnZoom_Click(sender As Object, e As EventArgs) Handles btnZoom.Click
        If Not pic.Image Is Nothing Then
            viewImg.PictureBox1.Image = pic.Image
            viewImg.Show()
        Else
            MessageBox.Show("No pic")
        End If
    End Sub

    Private Sub txtStudentID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStudentID.KeyPress
        If checkNullField(txtName) And checkNullField(txtStudentEmail) And checkNullField(txtStudentID) And (checkNullField(txtIC) Or checkNullField(txtPassport)) And checkNullField(txtGender) And checkNullField(txtDOB) And checkNullField(txtCountry) And checkNullField(txtEmail) And checkNullField(txtProgramme) And checkNullField(txtAddress) And checkNullField(txtState) And checkNullField(txtCity) And checkNullField(txtPostcode) And checkNullField(txtContact) And (Not pic.Image Is Nothing) Then
            Dim email As String = "@ucsicollege.edu.my"
            txtStudentEmail.Text = txtStudentID.Text & email
        Else
            e.Handled = True
            MessageBox.Show("Please select a record")
            txtStudentID.Text = ""
        End If
    End Sub

    Private Sub clearForm()
        txtName.Text = ""
        txtStudentID.Text = ""
        txtIC.Text = ""
        txtPassport.Text = ""
        txtGender.Text = ""
        txtDOB.Text = ""
        txtCountry.Text = ""
        txtContact.Text = ""
        txtEmail.Text = ""
        txtAddress.Text = ""
        txtProgramme.Text = ""
        txtAddress.Text = ""
        txtState.Text = ""
        txtCity.Text = ""
        txtPostcode.Text = ""
        pic.Image = Nothing
        errorID.Dispose()
    End Sub

    Private Sub btnAdmReject_Click(sender As Object, e As EventArgs) Handles btnAdmReject.Click
        If checkNullField(txtName) And checkNullField(txtStudentEmail) And checkNullField(txtStudentID) And (checkNullField(txtIC) Or checkNullField(txtPassport)) And checkNullField(txtGender) And checkNullField(txtDOB) And checkNullField(txtCountry) And checkNullField(txtEmail) And checkNullField(txtProgramme) And checkNullField(txtAddress) And checkNullField(txtState) And checkNullField(txtCity) And checkNullField(txtPostcode) And checkNullField(txtContact) And (Not pic.Image Is Nothing) Then
            Try
                conn.Open()
                Dim result As Integer = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
                If result = DialogResult.Yes Then
                    deleteRecord()
                    clearForm()
                    reloadAdmissionTable()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message())
            Finally
                conn.Close()
            End Try
        Else
            MessageBox.Show("Please select a record")
        End If
    End Sub

End Class

