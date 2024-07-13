Imports FontAwesome.Sharp
Public Class StudentForm
    Public currentBtn As IconButton
    Public leftBorderBtn As Panel
    Public currentForm As Form
    Private isMaximize As Boolean
    Private Property moveForm As Boolean
    Private Property moveForm_MousePosition As Point
    Private username As String
    Private pass As String
    Private programmeID As String
    Private semester As String
    Public Property semesterVal() As String
        Set(semester As String)
            Me.semester = semester
        End Set
        Get
            Return semester
        End Get
    End Property
    Public Property programmeIDVal() As String
        Set(programmeID As String)
            Me.programmeID = programmeID
        End Set
        Get
            Return programmeID
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
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 63)
        panelMenu.Controls.Add(leftBorderBtn)
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click

        openNewForm(New StudentDashboardForm())
        activateBtn(sender, Color.LightSkyBlue)

    End Sub

    Private Sub btnManageStud_Click(sender As Object, e As EventArgs) Handles btnCourseSelection.Click

        openNewForm(New StudentCourseSelection())

        activateBtn(sender, Color.Yellow)

    End Sub

    Private Sub BtnManageLect_Click(sender As Object, e As EventArgs) Handles BtnEvent.Click
        openNewForm(New StudentCocurriculum())
        activateBtn(sender, Color.LightGray)

    End Sub

    Private Sub BtnManageClass_Click(sender As Object, e As EventArgs) Handles BtnGrade.Click
        openNewForm(New StudentGradeReport())
        activateBtn(sender, Color.Violet)
    End Sub
    Private Sub BtnProfile_Click(sender As Object, e As EventArgs) Handles BtnProfile.Click
        openNewForm(New StudentProfileForm())
        activateBtn(sender, Color.LightGreen)

    End Sub

    Private Sub StudentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        activateBtn(btnDashboard, Color.LightSkyBlue)
        openNewForm(New StudentDashboardForm())
        Me.FormBorderStyle = FormBorderStyle.None
        roundCornerModule.roundCorner(Me)

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
    Public Sub disableBtn()
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

    Public Sub resetForm(formToReset As Form)
        For Each c As Control In formToReset.Controls
            Reset.reset(c)
        Next
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

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Dispose()
        Dim loginPage As New login()
        loginPage.Show()
        loginPage.clear()
    End Sub


    'round object'

End Class

