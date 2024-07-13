Imports MySql.Data.MySqlClient
Public Class AdminAddCourseForm
    Private connString As String = "server=localhost;database=SIS;userid=root;password=root"
    Private conn As New MySqlConnection("server=localhost;database=SIS;userid=root;password=root")
    Private adapter As MySqlDataAdapter
    Private reader As MySqlDataReader
    Private ds As DataSet
    Private command As MySqlCommand
    Private sql As String
    Private courseID As String
    Private Sub AdminAddCourseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        roundCornerModule.roundCorner(dgvAddCourse)
        roundCornerModule.roundCorner(panelAddCourse)
        'reload table
        reloadTable()
        disableControls()
        loadProgrammeData()
        loadLecData()
    End Sub

    Private Sub loadLecData()
        cbxLec.Items.Clear()
        Try
            conn.Open()
            sql = "SELECT * FROM Lecturer"
            command = New MySqlCommand(sql, conn)
            reader = command.ExecuteReader()

            While reader.Read()
                cbxLec.Items.Add(reader.GetString("lecID") & " " & reader.GetString("lecName"))
            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message())
        Finally
            conn.Close()
        End Try

    End Sub
    Private Sub loadProgrammeData()
        cbxProgramme.Items.Clear()
        'load the programme into combobox
        Dim conn As MySqlConnection = New MySqlConnection(connString)
        Try
            conn.Open()
            sql = "SELECT programmeName FROM Programme"
            command = New MySqlCommand(sql, conn)
            reader = command.ExecuteReader()
            While reader.Read
                cbxProgramme.Items.Add(reader.GetString("programmeName"))
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message())
        Finally
            conn.Close()
            conn.Dispose()
        End Try
    End Sub

    Private Sub reloadTable()
        dgvAddCourse.DataSource = Nothing
        Dim conn As MySqlConnection = New MySqlConnection(connString)
        Try
            conn.Open()
            sql = "SELECT c.courseID AS Course_ID,c.courseName AS Course_Name,p.programmeName AS Programme_Name,c.creditHour AS Credit_Hour,c.semester AS Semester,c.fees AS Course_Fees,COUNT(sc.studentID) AS Number_Of_Students,l.lecID AS LecID,l.lecName AS LecName
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
            dgvAddCourse.DataSource = ds.Tables("table")

        Catch ex As Exception
            MessageBox.Show(ex.Message())
        Finally
            conn.Close()
            conn.Dispose()
        End Try
    End Sub

    Private Sub dgvAddCourse_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAddCourse.CellContentClick
        cbxProgramme.Enabled = True
        If cbxProgramme.Enabled = True And txtCourseID.Enabled = True And txtSemester.Enabled = True And txtCreditHours.Enabled = True And txtCourseName.Enabled = True And txtFees.Enabled = True Then
            If cbxMode.SelectedItem = "Edit Mode" Then
                txtCourseID.Text = dgvAddCourse.CurrentRow.Cells("Course_ID").Value.ToString()
                txtSemester.Text = dgvAddCourse.CurrentRow.Cells("Semester").Value.ToString()
                txtCreditHours.Text = dgvAddCourse.CurrentRow.Cells("Credit_Hour").Value.ToString()
                txtCourseName.Text = dgvAddCourse.CurrentRow.Cells("Course_Name").Value.ToString()
                txtFees.Text = dgvAddCourse.CurrentRow.Cells("Course_Fees").Value.ToString()
                Me.courseID = dgvAddCourse.CurrentRow.Cells("Course_ID").Value.ToString()
                cbxLec.SelectedItem = dgvAddCourse.CurrentRow.Cells("LecID").Value.ToString() & " " & dgvAddCourse.CurrentRow.Cells("LecName").Value.ToString()
                cbxProgramme.SelectedItem = dgvAddCourse.CurrentRow.Cells("Programme_Name").Value.ToString()
                setToWriteRead()
                cbxProgramme.Enabled = False
            ElseIf cbxMode.SelectedItem = "Add New" Then
                MessageBox.Show("Please select Edit Mode Or Delete Mode")
            ElseIf cbxMode.SelectedItem = "Delete" Then
                txtCourseID.Text = dgvAddCourse.CurrentRow.Cells("Course_ID").Value.ToString()
                txtSemester.Text = dgvAddCourse.CurrentRow.Cells("Semester").Value.ToString()
                txtCreditHours.Text = dgvAddCourse.CurrentRow.Cells("Credit_Hour").Value.ToString()
                txtCourseName.Text = dgvAddCourse.CurrentRow.Cells("Course_Name").Value.ToString()
                txtFees.Text = dgvAddCourse.CurrentRow.Cells("Course_Fees").Value.ToString()
                cbxLec.SelectedItem = dgvAddCourse.CurrentRow.Cells("LecID").Value.ToString() & " " & dgvAddCourse.CurrentRow.Cells("LecName").Value.ToString()
                cbxProgramme.SelectedItem = dgvAddCourse.CurrentRow.Cells("Programme_Name").Value.ToString()
                txtCourseID.ReadOnly = True
                cbxProgramme.Enabled = False
                cbxLec.Enabled = False
            End If
        Else
            MessageBox.Show("Please select a mode")
        End If
    End Sub

    Private Sub cbxProgramme_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxProgramme.SelectedIndexChanged

        If cbxProgramme.SelectedIndex >= 0 Then
            lblProgramme.Text = ""
            lblProgramme.Text = cbxProgramme.SelectedItem()
        Else
            lblProgramme.Text = "-"
        End If
        If cbxMode.SelectedItem = "Edit Mode" Then
            If Not (checkNullField(txtCourseID) And checkNullField(txtCourseName) And checkNullField(txtFees) And checkNullField(txtSemester) And checkNullField(txtFees)) Then
                cbxProgramme.SelectedIndex = -1
            End If
        ElseIf cbxMode.SelectedItem = "Add New" Then
            setPrefix("DIT", "Diploma in Information Technology")
        ElseIf cbxMode.SelectedItem = "Delete" Then
            If Not (checkNullField(txtCourseID) And checkNullField(txtCourseName) And checkNullField(txtFees) And checkNullField(txtSemester) And checkNullField(txtFees)) Then
                cbxProgramme.SelectedIndex = -1
            End If
        End If
    End Sub
    Private Sub setPrefix(prefix As String, programme As String)
        If cbxProgramme.SelectedItem = programme Then
            txtCourseID.Text = ""
            txtCourseID.Text = prefix
        End If
    End Sub

    Private Function checkNullField(txt As TextBox) As Boolean
        If txt.Text.Length > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    'BTN SAVE
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim conn As MySqlConnection = New MySqlConnection(connString)
        Dim id As String = cbxLec.SelectedItem.ToString()

        If cbxMode.SelectedIndex >= 0 Then
            If cbxMode.SelectedItem = "Edit Mode" Then
                If cbxProgramme.SelectedIndex >= 0 Then
                    validateTxtCourseName()
                    validateTxtCreditHours()
                    validateTxtFees()
                    validateTxtSemester()
                    If errorCourseName.GetError(txtCourseName) = "Success" And errorCreditHours.GetError(txtCreditHours) = "Success" And errorFees.GetError(txtFees) = "Success" And errorSemester.GetError(txtSemester) = "Success" Then
                        Try
                            sql = "UPDATE Course 
                                    SET courseName = @courseName,creditHour = @creditHour,semester = @semester,fees = @fees,lecID = @lecID
                                    WHERE courseID = @courseID2"
                            conn.Open()
                            command = New MySqlCommand(sql, conn)
                            command.Parameters.AddWithValue("@courseName", txtCourseName.Text.Trim)
                            command.Parameters.AddWithValue("@creditHour", txtCreditHours.Text.Trim)
                            command.Parameters.AddWithValue("@semester", txtSemester.Text.Trim)
                            command.Parameters.AddWithValue("@fees", txtFees.Text.Trim)
                            command.Parameters.AddWithValue("@courseID2", Me.courseID)

                            command.Parameters.AddWithValue("@lecID", id.Substring(0, 10))

                            command.ExecuteNonQuery()
                            MessageBox.Show("Updated Programme Name: " & cbxProgramme.SelectedItem & vbCrLf & "Course Code: " & txtCourseID.Text)
                            clearForm()
                            reloadTable()
                            cbxProgramme.SelectedIndex = -1
                            cbxLec.SelectedIndex = -1
                        Catch ex As Exception
                            MessageBox.Show(ex.Message())
                        Finally
                            conn.Close()
                        End Try
                    Else
                        MessageBox.Show("Please resolve the red warning before proceed")
                    End If
                Else
                    MessageBox.Show("Please select a programme")
                End If
            Else
                MessageBox.Show("Please select edit mode")
            End If
        Else
            MessageBox.Show("Please select a mode")
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



    Private Sub validateTxtCourseID()

        Dim conn As MySqlConnection = New MySqlConnection(connString)

        setWarningIconPadding(errorCourseID, txtCourseID, 5)

        If txtCourseID.Text.Length = 7 Then
            Dim noSpace As Boolean = False
            For Each c As Char In txtCourseID.Text
                If c = " " Then
                    noSpace = False
                    Exit For
                Else
                    noSpace = True
                End If
            Next
            If noSpace Then
                Dim subStr As String = txtCourseID.Text.Substring(3, 4)
                Dim isNum As Boolean = False
                For Each c As Char In subStr
                    If Char.IsNumber(c) Then
                        isNum = True
                    Else
                        isNum = False
                        Exit For
                    End If
                Next
                If isNum Then
                    Dim tempCourseID As String = ""
                    Try
                        conn.Open()
                        sql = "SELECT courseID FROM Course WHERE courseID =@courseID"
                        command = New MySqlCommand(sql, conn)
                        command.Parameters.AddWithValue("@courseID", txtCourseID.Text)
                        reader = command.ExecuteReader()

                        While reader.Read
                            tempCourseID = reader.GetString("courseID")
                        End While

                        reader.Close()

                    Catch ex As Exception
                        MessageBox.Show(ex.Message())
                    Finally
                        conn.Close()
                    End Try
                    If Not tempCourseID.ToUpper.Equals(txtCourseID.Text.Trim.ToUpper) Then
                        setSuccessMsg(errorCourseID, txtCourseID, "Success")
                    Else
                        setErrorMsg(errorCourseID, txtCourseID, "Please enter another course ID")
                    End If
                Else
                    setErrorMsg(errorCourseID, txtCourseID, "Must follow the current format DIT1232")
                End If
            Else
                setErrorMsg(errorCourseID, txtCourseID, "No space is allowed")
            End If
        Else
            setErrorMsg(errorCourseID, txtCourseID, "Must be length of 7")
        End If
    End Sub
    Private Sub txtCourseName_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtCourseName.Validating
        If cbxProgramme.SelectedIndex >= 0 Then
            If cbxMode.SelectedItem = "Add New" Then
                validateTxtCourseName()
            ElseIf cbxMode.SelectedItem = "Edit Mode" Then
                validateTxtCourseName()
            End If
        End If
    End Sub


    Private Sub validateTxtCourseName()

        setWarningIconPadding(errorCourseName, txtCourseName, 5)

        Dim conn As MySqlConnection = New MySqlConnection(connString)

        If txtCourseName.Text.Length > 0 Then
            Dim isAlpha As Boolean = False
            For Each c As Char In txtCourseName.Text
                If Char.IsLetter(c) Or c = " " Then
                    isAlpha = True
                Else
                    isAlpha = False
                    Exit For
                End If
            Next
            If isAlpha Then
                setSuccessMsg(errorCourseName, txtCourseName, "Success")
            Else
                setErrorMsg(errorCourseName, txtCourseName, "No number is allowed")
            End If
        Else
            setErrorMsg(errorCourseName, txtCourseName, "Please enter course name")
        End If
    End Sub

    Private Sub txtCreditHours_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtCreditHours.Validating
        If cbxProgramme.SelectedIndex >= 0 Then
            If cbxMode.SelectedItem = "Add New" Then
                validateTxtCreditHours()
            ElseIf cbxMode.SelectedItem = "Edit Mode" Then
                validateTxtCreditHours()
            End If
        End If
    End Sub

    Private Sub validateTxtCreditHours()
        setWarningIconPadding(errorCreditHours, txtCreditHours, 5)

        If txtCreditHours.Text.Length > 0 Then
            Dim isNum As Boolean = False
            For Each c As Char In txtCreditHours.Text
                If Char.IsNumber(c) Then
                    isNum = True
                Else
                    isNum = False
                    Exit For
                End If
            Next
            If isNum Then
                setSuccessMsg(errorCreditHours, txtCreditHours, "Success")
            Else
                setErrorMsg(errorCreditHours, txtCreditHours, "No alphabet is allowed")
            End If
        Else
            setErrorMsg(errorCreditHours, txtCreditHours, "Please enter credit hour")
        End If
    End Sub

    Private Sub txtSemester_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtSemester.Validating
        If cbxProgramme.SelectedIndex >= 0 Then
            If cbxMode.SelectedItem = "Add New" Then
                validateTxtSemester()
            ElseIf cbxMode.SelectedItem = "Edit Mode" Then
                validateTxtSemester()
            End If
        End If
    End Sub

    Private Sub validateTxtSemester()

        setWarningIconPadding(errorSemester, txtSemester, 5)

        If txtSemester.Text.Length > 0 Then
            Dim isNum As Boolean = False
            For Each c As Char In txtSemester.Text
                If Char.IsNumber(c) Then
                    isNum = True
                Else
                    isNum = False
                    Exit For
                End If
            Next
            If isNum Then
                If Integer.Parse(txtSemester.Text) > 0 Then
                    setSuccessMsg(errorSemester, txtSemester, "Success")
                Else
                    setErrorMsg(errorSemester, txtSemester, "Invalid semester")
                End If
            Else
                setErrorMsg(errorSemester, txtSemester, "No alphabet is allowed")
            End If
        Else
            setErrorMsg(errorSemester, txtSemester, "Please enter semester")
        End If
    End Sub
    Private Sub validateTxtFees()

        setWarningIconPadding(errorFees, txtFees, 5)

        If txtFees.Text.Length > 0 Then
            Dim isNum As Boolean = False
            For Each c As Char In txtFees.Text
                If Char.IsNumber(c) Or c = "." Then
                    isNum = True
                Else
                    isNum = False
                    Exit For
                End If
            Next
            If isNum Then
                If Double.Parse(txtFees.Text) >= 0 Then
                    setSuccessMsg(errorFees, txtFees, "Success")
                Else
                    setErrorMsg(errorFees, txtFees, "Invalid fees")
                End If
            Else
                setErrorMsg(errorFees, txtFees, "No alphabet is allowed")
            End If
        Else
            setErrorMsg(errorFees, txtFees, "Please enter fees")
        End If

    End Sub

    Private Sub cbxMode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxMode.SelectedIndexChanged
        If cbxMode.SelectedIndex >= 0 Then
            enableControls()
            clearForm()
            loadLecData()
            loadProgrammeData()

        End If

        If cbxMode.SelectedItem = "Edit Mode" Then
            btnSave.Enabled = True
            btnAdd.Enabled = False
            btnRemove.Enabled = False
            setToReadOnly()
            MessageBox.Show("Please select a record from the table before proceed", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf cbxMode.SelectedItem = "Add New" Then
            btnAdd.Enabled = True
            btnSave.Enabled = False
            btnRemove.Enabled = False
            setToWriteRead()
            txtCourseID.ReadOnly = False
        ElseIf cbxMode.SelectedItem = "Delete" Then
            btnRemove.Enabled = True
            btnSave.Enabled = False
            btnAdd.Enabled = False
            setToReadOnly()
            MessageBox.Show("Please select a record from the table before proceed", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub setToReadOnly()
        txtCourseID.ReadOnly = True
        txtCourseName.ReadOnly = True
        txtCreditHours.ReadOnly = True
        txtSemester.ReadOnly = True
        txtFees.ReadOnly = True
    End Sub

    Private Sub setToWriteRead()
        txtCourseName.ReadOnly = False
        txtCreditHours.ReadOnly = False
        txtSemester.ReadOnly = False
        txtFees.ReadOnly = False
    End Sub
    Private Sub enableControls()
        cbxProgramme.Enabled = True
        txtCourseID.Enabled = True
        txtSemester.Enabled = True
        txtCreditHours.Enabled = True
        txtFees.Enabled = True
        txtCourseName.Enabled = True
        txtCourseID.BackColor = Color.White
        txtSemester.BackColor = Color.White
        txtCreditHours.BackColor = Color.White
        txtFees.BackColor = Color.White
        txtCourseName.BackColor = Color.White
        cbxLec.Enabled = True
    End Sub
    Private Sub disableControls()
        cbxProgramme.Enabled = False
        txtCourseID.Enabled = False
        txtSemester.Enabled = False
        txtCreditHours.Enabled = False
        txtFees.Enabled = False
        txtCourseName.Enabled = False
        txtCourseID.BackColor = Color.Gray
        txtSemester.BackColor = Color.Gray
        txtCreditHours.BackColor = Color.Gray
        txtFees.BackColor = Color.Gray
        txtCourseName.BackColor = Color.Gray
        cbxLec.Enabled = False
    End Sub

    Private Sub clearForm()
        txtCourseID.Text = ""
        txtCourseName.Text = ""
        txtCreditHours.Text = ""
        txtFees.Text = ""
        txtSemester.Text = ""
        lblCourseID.Text = "-"
        lblCourseName.Text = "-"
        lblCreditHours.Text = "-"
        lblFees.Text = "-"
        lblSemester.Text = "-"
        lblLec.Text = "-"

        cbxProgramme.SelectedIndex = -1
        lblProgramme.Text = "-"
        cbxLec.SelectedIndex = -1
        lblLec.Text = "-"

        errorCourseID.Dispose()
        errorCourseName.Dispose()
        errorCreditHours.Dispose()
        errorFees.Dispose()
        errorProgramme.Dispose()
        errorSemester.Dispose()
    End Sub
    'BUTTON ADD 
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim conn As MySqlConnection = New MySqlConnection(connString)
        Dim cmd2 As MySqlCommand
        Dim sql2 As String = ""

        If cbxMode.SelectedIndex >= 0 Then
            If cbxMode.SelectedItem = "Add New" Then
                If cbxProgramme.SelectedIndex >= 0 Then
                    validateTxtCourseID()
                    validateTxtCourseName()
                    validateTxtCreditHours()
                    validateTxtFees()
                    validateTxtSemester()
                    If cbxLec.SelectedIndex >= 0 Then
                        If errorCourseID.GetError(txtCourseID) = "Success" And errorCourseName.GetError(txtCourseName) = "Success" And errorCreditHours.GetError(txtCreditHours) = "Success" And errorSemester.GetError(txtSemester) = "Success" And errorFees.GetError(txtFees) = "Success" Then
                            Try
                                conn.Open()
                                sql = "INSERT INTO Course(courseID,courseName,creditHour,programmeID,semester,fees,lecID) VALUES (@courseID,@courseName,@creditHour,@programmeID,@semester,@fees,@lecID)"
                                command = New MySqlCommand(sql, conn)
                                command.Parameters.AddWithValue("@courseID", txtCourseID.Text.Trim())
                                command.Parameters.AddWithValue("@courseName", txtCourseName.Text.Trim())
                                command.Parameters.AddWithValue("@creditHour", txtCreditHours.Text.Trim())
                                command.Parameters.AddWithValue("@lecID", cbxLec.SelectedItem.ToString().Substring(0, 10))
                                Try
                                    sql2 = "SELECT programmeID FROM Programme 
                                        WHERE programmeName = @programmeName"
                                    cmd2 = New MySqlCommand(sql2, conn)
                                    cmd2.Parameters.AddWithValue("@programmeName", cbxProgramme.SelectedItem)
                                    reader = cmd2.ExecuteReader()

                                    While reader.Read
                                        command.Parameters.AddWithValue("@programmeID", reader.GetString("programmeID"))
                                    End While

                                    reader.Close()
                                Catch ex As Exception
                                    MessageBox.Show(ex.Message())
                                End Try

                                command.Parameters.AddWithValue("@semester", txtSemester.Text.Trim())
                                command.Parameters.AddWithValue("@fees", txtFees.Text.Trim)
                                command.ExecuteNonQuery()

                                MessageBox.Show(txtCourseName.Text & " " & txtCourseID.Text & " has been successfully added to " & cbxProgramme.SelectedItem)

                                clearForm()
                                reloadTable()
                                cbxProgramme.SelectedIndex = -1
                                cbxLec.SelectedIndex = -1
                            Catch ex As Exception
                                MessageBox.Show(ex.Message())
                            Finally
                                conn.Close()
                                conn.Dispose()
                            End Try

                        Else
                            MessageBox.Show("Please resolve the red warning before proceed")
                        End If
                    Else
                        MessageBox.Show("Please select a lecturer")
                    End If
                Else
                        MessageBox.Show("Please select a programme")
                End If
            Else
                MessageBox.Show("Please select Add New to add new course")
            End If
        Else
            MessageBox.Show("Please select a mode")
        End If
    End Sub

    Private Sub txtFees_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtFees.Validating
        If cbxProgramme.SelectedIndex >= 0 Then
            If cbxMode.SelectedItem = "Add New" Then
                validateTxtFees()
            ElseIf cbxMode.SelectedItem = "Edit Mode" Then
                validateTxtFees()
            End If
        End If
    End Sub

    'TEXT CHANGE EVENT
    Private Sub txtCourse_TextChanged(sender As Object, e As EventArgs) Handles txtCourseID.TextChanged
        lblCourseID.Text = ""
        lblCourseID.Text = txtCourseID.Text
    End Sub

    Private Sub txtCreditHours_TextChanged(sender As Object, e As EventArgs) Handles txtCreditHours.TextChanged
        lblCreditHours.Text = ""
        lblCreditHours.Text = txtCreditHours.Text
    End Sub

    Private Sub txtSemester_TextChanged(sender As Object, e As EventArgs) Handles txtSemester.TextChanged
        lblSemester.Text = ""
        lblSemester.Text = txtSemester.Text
    End Sub

    Private Sub txtCourseName_TextChanged(sender As Object, e As EventArgs) Handles txtCourseName.TextChanged
        lblCourseName.Text = ""
        lblCourseName.Text = txtCourseName.Text
    End Sub

    Private Sub txtFees_TextChanged(sender As Object, e As EventArgs) Handles txtFees.TextChanged
        lblFees.Text = ""
        lblFees.Text = txtFees.Text
    End Sub

    'KEY PRESSED EVENT
    Private Sub txtSemester_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSemester.KeyPress
        If cbxMode.SelectedItem = "Add New" Then
            If cbxProgramme.SelectedIndex < 0 Then
                e.Handled = True
                MessageBox.Show("Please select a programme")
            End If
        End If
    End Sub

    Private Sub txtCourseID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCourseID.KeyPress
        If cbxMode.SelectedItem = "Add New" Then
            If cbxProgramme.SelectedIndex < 0 Then
                e.Handled = True
                MessageBox.Show("Please select a programme")
            End If
            If txtCourseID.Text.Length = 3 Then
                If e.KeyChar = Chr(8) Then
                    e.Handled = True
                Else
                    e.Handled = False
                End If
            End If
        ElseIf cbxMode.SelectedItem = "Edit Mode" Then
            If txtCourseID.Text.Length = 3 Then
                If e.KeyChar = Chr(8) Then
                    e.Handled = True
                Else
                    e.Handled = False
                End If
            End If
        End If
    End Sub

    Private Sub txtCourseName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCourseName.KeyPress
        If cbxMode.SelectedItem = "Add New" Then
            If cbxProgramme.SelectedIndex < 0 Then
                e.Handled = True
                MessageBox.Show("Please select a programme")
            End If
        End If
    End Sub

    Private Sub txtFees_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFees.KeyPress
        If cbxMode.SelectedItem = "Add New" Then
            If cbxProgramme.SelectedIndex < 0 Then
                e.Handled = True
                MessageBox.Show("Please select a programme")
            End If
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim conn As MySqlConnection = New MySqlConnection(connString)

        If cbxMode.SelectedIndex >= 0 Then
            If cbxMode.SelectedItem = "Delete" Then
                If cbxProgramme.SelectedIndex >= 0 And checkNullField(txtCourseID) And checkNullField(txtCourseName) And checkNullField(txtCreditHours) And checkNullField(txtSemester) And checkNullField(txtCreditHours) Then
                    Dim result As Integer = 0
                    result = MessageBox.Show("Are you sure to delete this course", "Confirmation Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
                    If result = DialogResult.Yes Then
                        Try
                            conn.Open()
                            sql = "DELETE FROM Course 
                                    WHERE courseID = @courseID"
                            command = New MySqlCommand(sql, conn)
                            command.Parameters.AddWithValue("@courseID", txtCourseID.Text)
                            command.ExecuteNonQuery()

                            MessageBox.Show("You have successfully remove " & txtCourseName.Text)
                            clearForm()
                            reloadTable()
                            cbxProgramme.SelectedIndex = -1
                        Catch ex As Exception
                            MessageBox.Show(ex.Message())
                        End Try
                    End If
                Else
                        MessageBox.Show("Please select a record from the table above")
                End If
            Else
                MessageBox.Show("Please select remove mode")
            End If
        Else
            MessageBox.Show("Please select a mode")
        End If
    End Sub

    Private Sub cbxLec_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxLec.SelectedIndexChanged
        If cbxMode.SelectedItem = "Delete" Or cbxMode.SelectedItem = "Edit Mode" Then
            If Not (checkNullField(txtCourseID) And checkNullField(txtCourseName) And checkNullField(txtFees) And checkNullField(txtSemester) And checkNullField(txtFees)) Then
                cbxLec.SelectedIndex = -1
            End If
        End If

        If cbxLec.SelectedIndex >= 0 Then
            lblLec.Text = cbxLec.SelectedItem()
        Else
            lblLec.Text = "-"
        End If
    End Sub

    Private Sub txtCourseID_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtCourseID.Validating
        If cbxProgramme.SelectedIndex >= 0 Then
            If cbxMode.SelectedItem = "Add New" Then
                validateTxtCourseID()

            End If
        End If
    End Sub
End Class