Imports FontAwesome.Sharp
Public Class LecForm
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel
    Private currentForm As Form
    Private Property moveForm As Boolean
    Private Property moveForm_MousePosition As Point
    Private toggle As Boolean = False
    Private sender As Object
    Private username As String
    Private pass As String
    Private depID As String
    Private depName As String
    Public Property depNameVal() As String
        Set(depName As String)
            Me.depName = depName
        End Set
        Get
            Return depName
        End Get
    End Property

    Public Property depIDVal() As String
        Set(depID As String)
            Me.depID = depID
        End Set
        Get
            Return depID
        End Get
    End Property
    Public Property usernameVal() As String
        Set(username As String)
            Me.username = username
        End Set
        Get
            Return username
        End Get
    End Property

    Public Property passVal() As String
        Set(pass As String)
            Me.pass = pass
        End Set
        Get
            Return pass
        End Get
    End Property
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'Me.Size = New Size(1700, 1000)
        'LecOverviewClassForm.Size = New Size(1182, 800)
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 63)
        panelMenu.Controls.Add(leftBorderBtn)
    End Sub
    Private Sub LecForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        activateBtn(btnDashboard, Color.LightSkyBlue)
        openNewForm(New LecDashboardForm())
        Me.FormBorderStyle = FormBorderStyle.None
        roundCornerModule.roundCorner(Me)
        dropDownPanel1.Size = dropDownPanel1.MinimumSize

    End Sub


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
    Public Sub openNewForm(form As Form)

        If currentForm IsNot Nothing Then
            currentForm.Close()
        End If

        currentForm = form
        form.TopLevel = False
        form.FormBorderStyle = FormBorderStyle.None
        form.Dock = DockStyle.Fill

        panelDesktop.Controls.Add(form)
        panelDesktop.Tag = form

        form.BringToFront()
        form.Show()

    End Sub

    'Form custom click, maximize/normal, minimize
    Private Sub close_Click(sender As Object, e As EventArgs) Handles close.Click
        Application.Exit()
    End Sub
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

    Private Sub btnManageStud_Click(sender As Object, e As EventArgs) Handles btnManageStud.Click
        Me.sender = sender
        timerLecManageStud.Start()
    End Sub

    Private Sub timerLecManageStud_Tick(sender As Object, e As EventArgs) Handles timerLecManageStud.Tick

        If Not toggle Then
            toggle = expandDropDown(dropDownPanel1, timerLecManageStud, toggle)
        ElseIf toggle Then
            toggle = collapseDropDown(dropDownPanel1, timerLecManageStud, toggle)
        End If
        activateBtn(Me.sender, Color.Violet)
    End Sub

    Private Sub BtnManageClass_Click(sender As Object, e As EventArgs) Handles BtnManageClass.Click
        activateBtn(BtnManageClass, Color.Red)
        openNewForm(New LecOverviewClassForm())

    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        activateBtn(btnDashboard, Color.LightSkyBlue)
        openNewForm(New LecDashboardForm())

    End Sub

    Private Sub btnManageTimetable_Click(sender As Object, e As EventArgs) Handles btnOverviewTimetable.Click
        activateBtn(btnOverviewTimetable, Color.White)
        openNewForm(New LecOverviewTimetableForm())
    End Sub

    Private Sub BtnProfile_Click(sender As Object, e As EventArgs) Handles BtnProfile.Click
        activateBtn(BtnProfile, Color.Orange)
        openNewForm(New LecProfileForm())
    End Sub

    Private Sub btnStudAttendance_Click(sender As Object, e As EventArgs) Handles btnStudAttendance.Click
        openNewForm(New LecStudAttForm())
        changeSubBtnColor(btnStudAttendance)
        changeToOriColor(btnStudGrade)
    End Sub

    Private Sub btnStudGrade_Click(sender As Object, e As EventArgs) Handles btnStudGrade.Click
        openNewForm(New LecStudGradeForm())
        changeSubBtnColor(btnStudGrade)
        changeToOriColor(btnStudAttendance)
    End Sub

    Private Sub btnStudAttendance_Leave(sender As Object, e As EventArgs) Handles btnStudAttendance.Leave
        sender.ForeColor = Color.White
        sender.BackColor = Color.FromArgb(46, 51, 73)
    End Sub

    Private Sub btnStudGrade_Leave(sender As Object, e As EventArgs) Handles btnStudGrade.Leave
        sender.ForeColor = Color.White
        sender.BackColor = Color.FromArgb(46, 51, 73)
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
            If time.Enabled Then
                time.Stop()
            End If
            If timerCollapse.Enabled Then
                timerCollapse.Stop()
            End If
            control = False
        End If
        Return control
    End Function
    Private Sub changeSubBtnColor(btn As Button)
        btn.BackColor = Color.FromArgb(46, 51, 100)
    End Sub
    Private Sub changeToOriColor(btn As Button)
        btn.BackColor = Color.FromArgb(46, 51, 73)
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        timerCollapse.Start()
        disableBtn()
        Me.Dispose()

        Dim loginPage As New login()
        loginPage.Show()
        loginPage.clear()
    End Sub

    Private Sub timerCollapse_Tick(sender As Object, e As EventArgs) Handles timerCollapse.Tick
        If toggle Then
            toggle = collapseDropDown(dropDownPanel1, timerLecManageStud, toggle)
        End If
    End Sub


End Class