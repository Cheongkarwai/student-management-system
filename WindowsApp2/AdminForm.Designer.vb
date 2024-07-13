<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminForm))
        Me.panelMenu = New System.Windows.Forms.Panel()
        Me.btnLogout = New FontAwesome.Sharp.IconButton()
        Me.BtnProfile = New FontAwesome.Sharp.IconButton()
        Me.dropDownPanelClass = New System.Windows.Forms.Panel()
        Me.btnCourseManagement = New FontAwesome.Sharp.IconButton()
        Me.btnCourseOverview = New FontAwesome.Sharp.IconButton()
        Me.BtnManageCourse = New FontAwesome.Sharp.IconButton()
        Me.dropDownPanelLec = New System.Windows.Forms.Panel()
        Me.btnTimetable = New FontAwesome.Sharp.IconButton()
        Me.BtnManageLect = New FontAwesome.Sharp.IconButton()
        Me.dropDownPanelStud = New System.Windows.Forms.Panel()
        Me.btnStudAttendance = New FontAwesome.Sharp.IconButton()
        Me.btnStudCurriculum = New FontAwesome.Sharp.IconButton()
        Me.btnStudGrade = New FontAwesome.Sharp.IconButton()
        Me.btnStudCourse = New FontAwesome.Sharp.IconButton()
        Me.btnStudAdmission = New FontAwesome.Sharp.IconButton()
        Me.btnManageStud = New FontAwesome.Sharp.IconButton()
        Me.btnDashboard = New FontAwesome.Sharp.IconButton()
        Me.panelLogo = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panelDesktop = New System.Windows.Forms.Panel()
        Me.formTop = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.minimize = New System.Windows.Forms.PictureBox()
        Me.close = New System.Windows.Forms.PictureBox()
        Me.timerAdminStud = New System.Windows.Forms.Timer(Me.components)
        Me.timerAdminLec = New System.Windows.Forms.Timer(Me.components)
        Me.timerAdminClass = New System.Windows.Forms.Timer(Me.components)
        Me.timerCollapse = New System.Windows.Forms.Timer(Me.components)
        Me.timerProfile = New System.Windows.Forms.Timer(Me.components)
        Me.timerDash = New System.Windows.Forms.Timer(Me.components)
        Me.panelMenu.SuspendLayout()
        Me.dropDownPanelClass.SuspendLayout()
        Me.dropDownPanelLec.SuspendLayout()
        Me.dropDownPanelStud.SuspendLayout()
        Me.panelLogo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.formTop.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.minimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.close, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelMenu
        '
        Me.panelMenu.AutoScroll = True
        Me.panelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.panelMenu.Controls.Add(Me.btnLogout)
        Me.panelMenu.Controls.Add(Me.BtnProfile)
        Me.panelMenu.Controls.Add(Me.dropDownPanelClass)
        Me.panelMenu.Controls.Add(Me.BtnManageCourse)
        Me.panelMenu.Controls.Add(Me.dropDownPanelLec)
        Me.panelMenu.Controls.Add(Me.BtnManageLect)
        Me.panelMenu.Controls.Add(Me.dropDownPanelStud)
        Me.panelMenu.Controls.Add(Me.btnManageStud)
        Me.panelMenu.Controls.Add(Me.btnDashboard)
        Me.panelMenu.Controls.Add(Me.panelLogo)
        Me.panelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelMenu.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.panelMenu.Location = New System.Drawing.Point(0, 0)
        Me.panelMenu.Name = "panelMenu"
        Me.panelMenu.Size = New System.Drawing.Size(380, 953)
        Me.panelMenu.TabIndex = 2
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Fira Code", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnLogout.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft
        Me.btnLogout.IconColor = System.Drawing.Color.White
        Me.btnLogout.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnLogout.IconSize = 30
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.Location = New System.Drawing.Point(0, 1002)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnLogout.Size = New System.Drawing.Size(359, 85)
        Me.btnLogout.TabIndex = 4
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'BtnProfile
        '
        Me.BtnProfile.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.BtnProfile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnProfile.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnProfile.FlatAppearance.BorderSize = 0
        Me.BtnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnProfile.Font = New System.Drawing.Font("Fira Code", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProfile.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BtnProfile.IconChar = FontAwesome.Sharp.IconChar.Desktop
        Me.BtnProfile.IconColor = System.Drawing.Color.White
        Me.BtnProfile.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnProfile.IconSize = 32
        Me.BtnProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnProfile.Location = New System.Drawing.Point(0, 922)
        Me.BtnProfile.Name = "BtnProfile"
        Me.BtnProfile.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.BtnProfile.Size = New System.Drawing.Size(359, 80)
        Me.BtnProfile.TabIndex = 6
        Me.BtnProfile.Text = "Profile"
        Me.BtnProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnProfile.UseVisualStyleBackColor = False
        '
        'dropDownPanelClass
        '
        Me.dropDownPanelClass.Controls.Add(Me.btnCourseManagement)
        Me.dropDownPanelClass.Controls.Add(Me.btnCourseOverview)
        Me.dropDownPanelClass.Dock = System.Windows.Forms.DockStyle.Top
        Me.dropDownPanelClass.Location = New System.Drawing.Point(0, 821)
        Me.dropDownPanelClass.MaximumSize = New System.Drawing.Size(380, 101)
        Me.dropDownPanelClass.Name = "dropDownPanelClass"
        Me.dropDownPanelClass.Size = New System.Drawing.Size(359, 101)
        Me.dropDownPanelClass.TabIndex = 5
        '
        'btnCourseManagement
        '
        Me.btnCourseManagement.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnCourseManagement.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCourseManagement.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCourseManagement.FlatAppearance.BorderSize = 0
        Me.btnCourseManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCourseManagement.Font = New System.Drawing.Font("Fira Code", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCourseManagement.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnCourseManagement.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnCourseManagement.IconColor = System.Drawing.Color.White
        Me.btnCourseManagement.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnCourseManagement.IconSize = 32
        Me.btnCourseManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCourseManagement.Location = New System.Drawing.Point(0, 50)
        Me.btnCourseManagement.Name = "btnCourseManagement"
        Me.btnCourseManagement.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnCourseManagement.Size = New System.Drawing.Size(359, 50)
        Me.btnCourseManagement.TabIndex = 4
        Me.btnCourseManagement.Text = "Add New Course"
        Me.btnCourseManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCourseManagement.UseVisualStyleBackColor = False
        '
        'btnCourseOverview
        '
        Me.btnCourseOverview.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnCourseOverview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCourseOverview.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCourseOverview.FlatAppearance.BorderSize = 0
        Me.btnCourseOverview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCourseOverview.Font = New System.Drawing.Font("Fira Code", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCourseOverview.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnCourseOverview.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnCourseOverview.IconColor = System.Drawing.Color.White
        Me.btnCourseOverview.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnCourseOverview.IconSize = 32
        Me.btnCourseOverview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCourseOverview.Location = New System.Drawing.Point(0, 0)
        Me.btnCourseOverview.Name = "btnCourseOverview"
        Me.btnCourseOverview.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnCourseOverview.Size = New System.Drawing.Size(359, 50)
        Me.btnCourseOverview.TabIndex = 3
        Me.btnCourseOverview.Text = "Overview"
        Me.btnCourseOverview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCourseOverview.UseVisualStyleBackColor = False
        '
        'BtnManageCourse
        '
        Me.BtnManageCourse.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.BtnManageCourse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnManageCourse.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnManageCourse.FlatAppearance.BorderSize = 0
        Me.BtnManageCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnManageCourse.Font = New System.Drawing.Font("Fira Code", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnManageCourse.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BtnManageCourse.IconChar = FontAwesome.Sharp.IconChar.UserEdit
        Me.BtnManageCourse.IconColor = System.Drawing.Color.White
        Me.BtnManageCourse.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnManageCourse.IconSize = 32
        Me.BtnManageCourse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnManageCourse.Location = New System.Drawing.Point(0, 741)
        Me.BtnManageCourse.Name = "BtnManageCourse"
        Me.BtnManageCourse.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.BtnManageCourse.Size = New System.Drawing.Size(359, 80)
        Me.BtnManageCourse.TabIndex = 5
        Me.BtnManageCourse.Text = "Manage Course"
        Me.BtnManageCourse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnManageCourse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnManageCourse.UseVisualStyleBackColor = False
        '
        'dropDownPanelLec
        '
        Me.dropDownPanelLec.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.dropDownPanelLec.Controls.Add(Me.btnTimetable)
        Me.dropDownPanelLec.Dock = System.Windows.Forms.DockStyle.Top
        Me.dropDownPanelLec.Location = New System.Drawing.Point(0, 691)
        Me.dropDownPanelLec.MaximumSize = New System.Drawing.Size(380, 50)
        Me.dropDownPanelLec.Name = "dropDownPanelLec"
        Me.dropDownPanelLec.Size = New System.Drawing.Size(359, 50)
        Me.dropDownPanelLec.TabIndex = 0
        '
        'btnTimetable
        '
        Me.btnTimetable.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnTimetable.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTimetable.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnTimetable.FlatAppearance.BorderSize = 0
        Me.btnTimetable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTimetable.Font = New System.Drawing.Font("Fira Code", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimetable.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnTimetable.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnTimetable.IconColor = System.Drawing.Color.White
        Me.btnTimetable.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnTimetable.IconSize = 32
        Me.btnTimetable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTimetable.Location = New System.Drawing.Point(0, 0)
        Me.btnTimetable.Name = "btnTimetable"
        Me.btnTimetable.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnTimetable.Size = New System.Drawing.Size(359, 50)
        Me.btnTimetable.TabIndex = 4
        Me.btnTimetable.Text = "Timetable Management"
        Me.btnTimetable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTimetable.UseVisualStyleBackColor = False
        '
        'BtnManageLect
        '
        Me.BtnManageLect.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.BtnManageLect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnManageLect.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnManageLect.FlatAppearance.BorderSize = 0
        Me.BtnManageLect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnManageLect.Font = New System.Drawing.Font("Fira Code", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnManageLect.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BtnManageLect.IconChar = FontAwesome.Sharp.IconChar.Desktop
        Me.BtnManageLect.IconColor = System.Drawing.Color.White
        Me.BtnManageLect.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnManageLect.IconSize = 32
        Me.BtnManageLect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnManageLect.Location = New System.Drawing.Point(0, 611)
        Me.BtnManageLect.Name = "BtnManageLect"
        Me.BtnManageLect.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.BtnManageLect.Size = New System.Drawing.Size(359, 80)
        Me.BtnManageLect.TabIndex = 2
        Me.BtnManageLect.Text = "Manage Lecturer"
        Me.BtnManageLect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnManageLect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnManageLect.UseVisualStyleBackColor = False
        '
        'dropDownPanelStud
        '
        Me.dropDownPanelStud.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.dropDownPanelStud.Controls.Add(Me.btnStudAttendance)
        Me.dropDownPanelStud.Controls.Add(Me.btnStudCurriculum)
        Me.dropDownPanelStud.Controls.Add(Me.btnStudGrade)
        Me.dropDownPanelStud.Controls.Add(Me.btnStudCourse)
        Me.dropDownPanelStud.Controls.Add(Me.btnStudAdmission)
        Me.dropDownPanelStud.Dock = System.Windows.Forms.DockStyle.Top
        Me.dropDownPanelStud.Location = New System.Drawing.Point(0, 360)
        Me.dropDownPanelStud.MaximumSize = New System.Drawing.Size(380, 251)
        Me.dropDownPanelStud.Name = "dropDownPanelStud"
        Me.dropDownPanelStud.Size = New System.Drawing.Size(359, 251)
        Me.dropDownPanelStud.TabIndex = 0
        '
        'btnStudAttendance
        '
        Me.btnStudAttendance.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnStudAttendance.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStudAttendance.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnStudAttendance.FlatAppearance.BorderSize = 0
        Me.btnStudAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStudAttendance.Font = New System.Drawing.Font("Fira Code", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudAttendance.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnStudAttendance.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnStudAttendance.IconColor = System.Drawing.Color.White
        Me.btnStudAttendance.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnStudAttendance.IconSize = 32
        Me.btnStudAttendance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStudAttendance.Location = New System.Drawing.Point(0, 200)
        Me.btnStudAttendance.Name = "btnStudAttendance"
        Me.btnStudAttendance.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnStudAttendance.Size = New System.Drawing.Size(359, 50)
        Me.btnStudAttendance.TabIndex = 7
        Me.btnStudAttendance.Text = "Attendance"
        Me.btnStudAttendance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnStudAttendance.UseVisualStyleBackColor = False
        '
        'btnStudCurriculum
        '
        Me.btnStudCurriculum.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnStudCurriculum.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStudCurriculum.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnStudCurriculum.FlatAppearance.BorderSize = 0
        Me.btnStudCurriculum.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStudCurriculum.Font = New System.Drawing.Font("Fira Code", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudCurriculum.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnStudCurriculum.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnStudCurriculum.IconColor = System.Drawing.Color.White
        Me.btnStudCurriculum.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnStudCurriculum.IconSize = 32
        Me.btnStudCurriculum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStudCurriculum.Location = New System.Drawing.Point(0, 150)
        Me.btnStudCurriculum.Name = "btnStudCurriculum"
        Me.btnStudCurriculum.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnStudCurriculum.Size = New System.Drawing.Size(359, 50)
        Me.btnStudCurriculum.TabIndex = 6
        Me.btnStudCurriculum.Text = "Co-Curriculum"
        Me.btnStudCurriculum.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnStudCurriculum.UseVisualStyleBackColor = False
        '
        'btnStudGrade
        '
        Me.btnStudGrade.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnStudGrade.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStudGrade.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnStudGrade.FlatAppearance.BorderSize = 0
        Me.btnStudGrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStudGrade.Font = New System.Drawing.Font("Fira Code", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudGrade.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnStudGrade.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnStudGrade.IconColor = System.Drawing.Color.White
        Me.btnStudGrade.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnStudGrade.IconSize = 32
        Me.btnStudGrade.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStudGrade.Location = New System.Drawing.Point(0, 100)
        Me.btnStudGrade.Name = "btnStudGrade"
        Me.btnStudGrade.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnStudGrade.Size = New System.Drawing.Size(359, 50)
        Me.btnStudGrade.TabIndex = 5
        Me.btnStudGrade.Text = "Grading"
        Me.btnStudGrade.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnStudGrade.UseVisualStyleBackColor = False
        '
        'btnStudCourse
        '
        Me.btnStudCourse.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnStudCourse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStudCourse.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnStudCourse.FlatAppearance.BorderSize = 0
        Me.btnStudCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStudCourse.Font = New System.Drawing.Font("Fira Code", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudCourse.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnStudCourse.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnStudCourse.IconColor = System.Drawing.Color.White
        Me.btnStudCourse.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnStudCourse.IconSize = 32
        Me.btnStudCourse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStudCourse.Location = New System.Drawing.Point(0, 50)
        Me.btnStudCourse.Name = "btnStudCourse"
        Me.btnStudCourse.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnStudCourse.Size = New System.Drawing.Size(359, 50)
        Me.btnStudCourse.TabIndex = 4
        Me.btnStudCourse.Text = "Course Selection"
        Me.btnStudCourse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnStudCourse.UseVisualStyleBackColor = False
        '
        'btnStudAdmission
        '
        Me.btnStudAdmission.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnStudAdmission.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStudAdmission.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnStudAdmission.FlatAppearance.BorderSize = 0
        Me.btnStudAdmission.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStudAdmission.Font = New System.Drawing.Font("Fira Code", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudAdmission.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnStudAdmission.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnStudAdmission.IconColor = System.Drawing.Color.White
        Me.btnStudAdmission.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnStudAdmission.IconSize = 32
        Me.btnStudAdmission.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStudAdmission.Location = New System.Drawing.Point(0, 0)
        Me.btnStudAdmission.Name = "btnStudAdmission"
        Me.btnStudAdmission.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnStudAdmission.Size = New System.Drawing.Size(359, 50)
        Me.btnStudAdmission.TabIndex = 3
        Me.btnStudAdmission.Text = "Student Admission"
        Me.btnStudAdmission.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnStudAdmission.UseVisualStyleBackColor = False
        '
        'btnManageStud
        '
        Me.btnManageStud.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnManageStud.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnManageStud.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnManageStud.FlatAppearance.BorderSize = 0
        Me.btnManageStud.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnManageStud.Font = New System.Drawing.Font("Fira Code", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManageStud.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnManageStud.IconChar = FontAwesome.Sharp.IconChar.GraduationCap
        Me.btnManageStud.IconColor = System.Drawing.Color.White
        Me.btnManageStud.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnManageStud.IconSize = 32
        Me.btnManageStud.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnManageStud.Location = New System.Drawing.Point(0, 280)
        Me.btnManageStud.Name = "btnManageStud"
        Me.btnManageStud.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnManageStud.Size = New System.Drawing.Size(359, 80)
        Me.btnManageStud.TabIndex = 1
        Me.btnManageStud.Text = "Manage Student"
        Me.btnManageStud.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnManageStud.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnManageStud.UseVisualStyleBackColor = False
        '
        'btnDashboard
        '
        Me.btnDashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Fira Code", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.GripHorizontal
        Me.btnDashboard.IconColor = System.Drawing.Color.White
        Me.btnDashboard.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnDashboard.IconSize = 32
        Me.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.Location = New System.Drawing.Point(0, 200)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnDashboard.Size = New System.Drawing.Size(359, 80)
        Me.btnDashboard.TabIndex = 0
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDashboard.UseVisualStyleBackColor = False
        '
        'panelLogo
        '
        Me.panelLogo.Controls.Add(Me.PictureBox1)
        Me.panelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelLogo.Location = New System.Drawing.Point(0, 0)
        Me.panelLogo.Name = "panelLogo"
        Me.panelLogo.Size = New System.Drawing.Size(359, 200)
        Me.panelLogo.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApp2.My.Resources.Resources.ucsi_university_logo
        Me.PictureBox1.Location = New System.Drawing.Point(88, 66)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(197, 107)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'panelDesktop
        '
        Me.panelDesktop.AutoSize = True
        Me.panelDesktop.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelDesktop.Location = New System.Drawing.Point(380, 0)
        Me.panelDesktop.Name = "panelDesktop"
        Me.panelDesktop.Size = New System.Drawing.Size(1302, 953)
        Me.panelDesktop.TabIndex = 4
        '
        'formTop
        '
        Me.formTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.formTop.Controls.Add(Me.Panel1)
        Me.formTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.formTop.Location = New System.Drawing.Point(380, 0)
        Me.formTop.Name = "formTop"
        Me.formTop.Size = New System.Drawing.Size(1302, 60)
        Me.formTop.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.minimize)
        Me.Panel1.Controls.Add(Me.close)
        Me.Panel1.Location = New System.Drawing.Point(1162, 19)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(160, 38)
        Me.Panel1.TabIndex = 3
        '
        'minimize
        '
        Me.minimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.minimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.minimize.Image = CType(resources.GetObject("minimize.Image"), System.Drawing.Image)
        Me.minimize.Location = New System.Drawing.Point(34, 3)
        Me.minimize.Name = "minimize"
        Me.minimize.Size = New System.Drawing.Size(26, 26)
        Me.minimize.TabIndex = 2
        Me.minimize.TabStop = False
        '
        'close
        '
        Me.close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.close.Image = CType(resources.GetObject("close.Image"), System.Drawing.Image)
        Me.close.Location = New System.Drawing.Point(88, 3)
        Me.close.Name = "close"
        Me.close.Size = New System.Drawing.Size(26, 26)
        Me.close.TabIndex = 0
        Me.close.TabStop = False
        '
        'timerAdminStud
        '
        Me.timerAdminStud.Interval = 1
        '
        'timerAdminLec
        '
        Me.timerAdminLec.Interval = 10
        '
        'timerAdminClass
        '
        Me.timerAdminClass.Interval = 10
        '
        'timerCollapse
        '
        Me.timerCollapse.Interval = 10
        '
        'timerProfile
        '
        Me.timerProfile.Interval = 10
        '
        'timerDash
        '
        Me.timerDash.Interval = 10
        '
        'AdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1682, 953)
        Me.Controls.Add(Me.formTop)
        Me.Controls.Add(Me.panelDesktop)
        Me.Controls.Add(Me.panelMenu)
        Me.MinimumSize = New System.Drawing.Size(1700, 900)
        Me.Name = "AdminForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.panelMenu.ResumeLayout(False)
        Me.dropDownPanelClass.ResumeLayout(False)
        Me.dropDownPanelLec.ResumeLayout(False)
        Me.dropDownPanelStud.ResumeLayout(False)
        Me.panelLogo.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.formTop.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.minimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.close, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents panelMenu As Panel
    Friend WithEvents panelLogo As Panel
    Friend WithEvents btnLogout As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnManageLect As FontAwesome.Sharp.IconButton
    Friend WithEvents btnManageStud As FontAwesome.Sharp.IconButton
    Friend WithEvents btnDashboard As FontAwesome.Sharp.IconButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnManageCourse As FontAwesome.Sharp.IconButton
    Friend WithEvents panelDesktop As Panel
    Friend WithEvents BtnProfile As FontAwesome.Sharp.IconButton
    Friend WithEvents formTop As Panel
    Friend WithEvents minimize As PictureBox
    Friend WithEvents close As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnStudAttendance As FontAwesome.Sharp.IconButton
    Friend WithEvents btnStudCurriculum As FontAwesome.Sharp.IconButton
    Friend WithEvents btnStudGrade As FontAwesome.Sharp.IconButton
    Friend WithEvents btnStudCourse As FontAwesome.Sharp.IconButton
    Friend WithEvents btnStudAdmission As FontAwesome.Sharp.IconButton
    Friend WithEvents dropDownPanelLec As Panel
    Friend WithEvents btnTimetable As FontAwesome.Sharp.IconButton
    Friend WithEvents timerAdminStud As Timer
    Friend WithEvents dropDownPanelStud As Panel
    Friend WithEvents timerAdminLec As Timer
    Friend WithEvents dropDownPanelClass As Panel
    Friend WithEvents btnCourseManagement As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCourseOverview As FontAwesome.Sharp.IconButton
    Friend WithEvents timerAdminClass As Timer
    Friend WithEvents timerCollapse As Timer
    Friend WithEvents timerProfile As Timer
    Friend WithEvents timerDash As Timer
End Class
