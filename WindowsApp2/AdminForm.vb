Imports FontAwesome.Sharp
Public Class AdminForm
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel
    Private currentForm As Form
    Private Property moveForm As Boolean
    Private Property moveForm_MousePosition As Point
    'variable to hold whether drop down button is on or off.
    Private toggle() As Boolean = {False, False, False}
    Private sender As Object
    Private username As String
    Private pass As String
    Private depID As String
    Private depName As String
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 63)
        panelMenu.Controls.Add(leftBorderBtn)
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'open the form as default when form loads.
        openNewForm(New AdminDashboardForm())
        activateBtn(btnDashboard, Color.LightSkyBlue)

        'disable form border style when form loads.
        Me.FormBorderStyle = FormBorderStyle.None

        'function to make form border vertices round.
        roundCornerModule.roundCorner(Me)
        'close all drop down panel when form loads.
        dropDownPanelStud.Size = dropDownPanelStud.MinimumSize
        dropDownPanelLec.Size = dropDownPanelStud.MinimumSize
        dropDownPanelClass.Size = dropDownPanelStud.MinimumSize



    End Sub

    Public Property usernameVal As String
        Set(username As String)
            Me.username = username
        End Set
        Get
            Return username
        End Get
    End Property

    Public Property depNameVal As String
        Set(depName As String)
            Me.depName = depName
        End Set
        Get
            Return depName
        End Get
    End Property

    Public Property depIDVal As String
        Set(depID As String)
            Me.depID = depID
        End Set
        Get
            Return depID
        End Get
    End Property

    Public Property passVal As String
        Set(pass As String)
            Me.pass = pass
        End Set
        Get
            Return pass
        End Get
    End Property


    Public Sub activateBtn(sender As Object, customColor As Color)
        If sender IsNot Nothing Then
            disableBtn()
            currentBtn = sender

            currentBtn.IconColor = customColor
            currentBtn.ForeColor = customColor

            leftBorderBtn.BackColor = customColor
            leftBorderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()


        End If
    End Sub
    Private Sub disableBtn()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(24, 30, 54)
            currentBtn.IconColor = Color.White
            currentBtn.ForeColor = Color.White
        End If
    End Sub

    'open new form
    Public Sub openNewForm(form As Form)

        'if currentform has something
        If currentForm IsNot Nothing Then
            'close current form
            currentForm.Close()
        End If

        'assign new form from parameter to currentform
        currentForm = form
        form.TopLevel = False
        form.FormBorderStyle = FormBorderStyle.None
        form.Dock = DockStyle.Fill

        panelDesktop.Controls.Add(form)
        panelDesktop.Tag = form

        'show new form
        form.BringToFront()
        form.Show()

    End Sub



    'custom close btn setting
    Private Sub close_Click(sender As Object, e As EventArgs) Handles close.Click
        'close form
        Application.Exit()
    End Sub
    'custom minimize btn setting
    Private Sub minimize_Click(sender As Object, e As EventArgs) Handles minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    'Dragable Form
    Private Sub formTop_MouseDown(sender As Object, e As MouseEventArgs) Handles formTop.MouseDown
        If e.Button = MouseButtons.Left Then
            moveForm = True
            Me.Cursor = Cursors.Default
            moveForm_MousePosition = e.Location
        End If
    End Sub
    Private Sub formTop_MouseMove(sender As Object, e As MouseEventArgs) Handles formTop.MouseMove
        If moveForm Then
            Me.Location = Me.Location + (e.Location - moveForm_MousePosition)
        End If
    End Sub
    Private Sub formTop_MouseUp(sender As Object, e As MouseEventArgs) Handles formTop.MouseUp
        If e.Button = MouseButtons.Left Then
            moveForm = False
            Me.Cursor = Cursors.Default
        End If
    End Sub
    Public Function expandDropDown(panel As Panel, time As Timer, control As Boolean) As Boolean
        panel.Height += 100
        If panel.Height >= panel.MaximumSize.Height Then
            time.Stop()
            control = True
        End If
        Return control
    End Function
    'function to close drop down panel
    Public Function collapseDropDown(panel As Panel, time As Timer, control As Boolean) As Boolean
        panel.Height -= 100
        If panel.Height <= panel.MinimumSize.Height Then
            time.Stop()
            If timerCollapse.Enabled Then
                timerCollapse.Stop()
            End If
            If timerProfile.Enabled Then
                timerProfile.Stop()
            End If
            If timerDash.Enabled Then
                timerDash.Stop()
            End If
            control = False
        End If
        Return control
    End Function
    'event handler for btn dashboard
    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        'open dashboard form
        Me.sender = sender
        timerDash.Start()
        'collapseAllSubButton()
        openNewForm(New AdminDashboardForm())


    End Sub

    'function to expand drop down panel

    'event handler for btn manage student 
    Private Sub btnManageStud_Click(sender As Object, e As EventArgs) Handles btnManageStud.Click
        'when clicked, open the drop down panel of stud
        Me.sender = sender
        timerAdminStud.Start()

        'check if other drop down panel is open, if open close all drop down panel except stud.
        If toggle(1) Then
            timerAdminLec.Start()
        End If
        If toggle(2) Then
            timerAdminClass.Start()
        End If


    End Sub
    'event handler for btn manage lecturer
    Private Sub BtnManageLect_Click(sender As Object, e As EventArgs) Handles BtnManageLect.Click
        'when clicked, open the drop down panel of lec
        Me.sender = sender
        timerAdminLec.Start()

        'check if other drop down panel is open, if open close all drop down panel except lec.
        If toggle(0) Then
            timerAdminStud.Start()
        End If
        If toggle(2) Then
            timerAdminClass.Start()
        End If

    End Sub

    Private Sub BtnManageClass_Click(sender As Object, e As EventArgs) Handles BtnManageCourse.Click
        'when clicked, open the drop down panel of class
        Me.sender = sender
        timerAdminClass.Start()
        'check if other drop down panel is open, if open close all drop down panel except class.
        If toggle(0) Then
            timerAdminStud.Start()
        End If
        If toggle(1) Then
            timerAdminLec.Start()
        End If
    End Sub
    Private Sub BtnProfile_Click(sender As Object, e As EventArgs) Handles BtnProfile.Click
        Me.sender = sender
        timerProfile.Start()
        openNewForm(New AdminProfileForm())
    End Sub



    Private Sub adminStudTimer_Tick(sender As Object, e As EventArgs) Handles timerAdminStud.Tick

        'if other panel is open
        If toggle(1) Then
            'close panel,return false
            toggle(1) = collapseDropDown(dropDownPanelLec, timerAdminLec, toggle(1))
        ElseIf toggle(2) Then
            'close panel,return false
            toggle(2) = collapseDropDown(dropDownPanelClass, timerAdminClass, toggle(2))
        End If

        'check if toggle is on
        If Not toggle(0) Then
            'if false expand it, return true '
            toggle(0) = expandDropDown(dropDownPanelStud, timerAdminStud, toggle(0))
        Else
            'if false close it, return false
            toggle(0) = collapseDropDown(dropDownPanelStud, timerAdminStud, toggle(0))
        End If

        activateBtn(Me.sender, Color.Yellow)

    End Sub

    Private Sub timerAdminLec_Tick(sender As Object, e As EventArgs) Handles timerAdminLec.Tick

        'if other panel is open
        If toggle(0) Then
            'close panel, return false
            toggle(0) = collapseDropDown(dropDownPanelStud, timerAdminStud, toggle(0))
        ElseIf toggle(2) Then
            'close panel, return false
            toggle(2) = collapseDropDown(dropDownPanelClass, timerAdminClass, toggle(2))
        End If

        'check if toggle is on
        If Not toggle(1) Then
            'if false expand it, return true
            toggle(1) = expandDropDown(dropDownPanelLec, timerAdminLec, toggle(1))
        Else
            'if true close it, return false
            toggle(1) = collapseDropDown(dropDownPanelLec, timerAdminLec, toggle(1))
        End If

        activateBtn(Me.sender, Color.LightGray)

    End Sub

    Private Sub timerAdminClass_Tick(sender As Object, e As EventArgs) Handles timerAdminClass.Tick

        'if other panel is open
        If toggle(0) Then
            'close panel, return false
            toggle(0) = collapseDropDown(dropDownPanelStud, timerAdminStud, toggle(0))
        ElseIf toggle(1) Then
            'close panel, return false
            toggle(1) = collapseDropDown(dropDownPanelLec, timerAdminLec, toggle(1))
        End If

        'check if toggle is on
        If Not toggle(2) Then
            'if false expand it, return true
            toggle(2) = expandDropDown(dropDownPanelClass, timerAdminClass, toggle(2))
        Else
            'if true close it, return false
            toggle(2) = collapseDropDown(dropDownPanelClass, timerAdminClass, toggle(2))
        End If

        activateBtn(Me.sender, Color.Cyan)

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        disableBtn()
        timerCollapse.Start()

        Dim loginPage As New login()
        loginPage.Show()
        loginPage.clear()
        Me.Hide()
        Me.sender = Nothing

    End Sub


    Private Sub timerCollapse_Tick(sender As Object, e As EventArgs) Handles timerCollapse.Tick
        If toggle(0) Then
            'close panel, return false
            toggle(0) = collapseDropDown(dropDownPanelStud, timerAdminStud, toggle(0))
        ElseIf toggle(1) Then
            'close panel, return false
            toggle(1) = collapseDropDown(dropDownPanelLec, timerAdminLec, toggle(1))
        ElseIf toggle(2) Then
            'close panel, return false
            toggle(2) = collapseDropDown(dropDownPanelClass, timerAdminClass, toggle(2))
        End If
    End Sub

    Private Sub timerProfile_Tick(sender As Object, e As EventArgs) Handles timerProfile.Tick
        If toggle(0) Then
            'close panel, return false
            toggle(0) = collapseDropDown(dropDownPanelStud, timerAdminStud, toggle(0))
        ElseIf toggle(1) Then
            'close panel, return false
            toggle(1) = collapseDropDown(dropDownPanelLec, timerAdminLec, toggle(1))
        ElseIf toggle(2) Then
            'close panel, return false
            toggle(2) = collapseDropDown(dropDownPanelClass, timerAdminClass, toggle(2))
        End If

        activateBtn(Me.sender, Color.LightGreen)
    End Sub

    Private Sub timerDash_Tick(sender As Object, e As EventArgs) Handles timerDash.Tick

        If toggle(0) Then
            'close panel, return false
            toggle(0) = collapseDropDown(dropDownPanelStud, timerAdminStud, toggle(0))
        ElseIf toggle(1) Then
            'close panel, return false
            toggle(1) = collapseDropDown(dropDownPanelLec, timerAdminLec, toggle(1))
        ElseIf toggle(2) Then
            'close panel, return false
            toggle(2) = collapseDropDown(dropDownPanelClass, timerAdminClass, toggle(2))
        End If

        activateBtn(Me.sender, Color.LightSkyBlue)
    End Sub

    'round object'
    Private Sub changeSubBtnColor(btn As Button)
        btn.BackColor = Color.FromArgb(46, 51, 100)
    End Sub
    Private Sub changeToOriColor(btn As Button)
        btn.BackColor = Color.FromArgb(46, 51, 73)
    End Sub
    Private Sub btnStudAdmission_Click(sender As Object, e As EventArgs) Handles btnStudAdmission.Click
        openNewForm(New AdminStudAdmForm())
        changeToOriColor()
        changeSubBtnColor(btnStudAdmission)
    End Sub

    Private Sub btnStudCourse_Click(sender As Object, e As EventArgs) Handles btnStudCourse.Click
        openNewForm(New AdminCourseForm())
        changeToOriColor()
        changeSubBtnColor(btnStudCourse)
    End Sub

    Private Sub btnStudGrade_Click(sender As Object, e As EventArgs) Handles btnStudGrade.Click
        openNewForm(New AdminGradingForm())
        changeToOriColor()
        changeSubBtnColor(btnStudGrade)
    End Sub

    Private Sub btnStudCurriculum_Click(sender As Object, e As EventArgs) Handles btnStudCurriculum.Click
        openNewForm(New AdminECAForm())
        changeToOriColor()
        changeSubBtnColor(btnStudCurriculum)
    End Sub

    Private Sub btnStudAttendance_Click(sender As Object, e As EventArgs) Handles btnStudAttendance.Click
        openNewForm(New AdminAttendanceForm())
        changeToOriColor()
        changeSubBtnColor(btnStudAttendance)
    End Sub

    Private Sub btnClassOverview_Click(sender As Object, e As EventArgs) Handles btnCourseOverview.Click
        openNewForm(New AdminCourseOverviewForm())
        changeToOriColor()
        changeSubBtnColor(btnCourseOverview)
    End Sub
    Private Sub changeToOriColor()
        changeToOriColor(btnStudAttendance)
        changeToOriColor(btnTimetable)
        changeToOriColor(btnStudCourse)
        changeToOriColor(btnStudGrade)
        changeToOriColor(btnStudAdmission)
        changeToOriColor(btnStudCurriculum)
        changeToOriColor(btnCourseOverview)
        changeToOriColor(btnCourseManagement)
    End Sub

    Private Sub btnCourseManagement_Click(sender As Object, e As EventArgs) Handles btnCourseManagement.Click
        openNewForm(New AdminAddCourseForm())
        changeToOriColor()
        changeSubBtnColor(btnCourseManagement)
    End Sub

    Private Sub btnTimetable_Click(sender As Object, e As EventArgs) Handles btnTimetable.Click
        openNewForm(New AdminTimetableForm())
        changeToOriColor()
        changeSubBtnColor(btnTimetable)
    End Sub
End Class


Module Reset
    Public Sub reset(sender As Object)
        If TypeOf sender Is TextBox Then
            sender.Text = ""
        ElseIf TypeOf sender Is CheckBox Then
            sender.Checked = False
        ElseIf TypeOf sender Is RadioButton Then
            sender.Checked = False
        ElseIf TypeOf sender Is ComboBox Then
            sender.SelectedIndex = 0
        End If



    End Sub
End Module
