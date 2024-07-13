<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LecForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LecForm))
        Me.panelMenu = New System.Windows.Forms.Panel()
        Me.BtnProfile = New FontAwesome.Sharp.IconButton()
        Me.btnOverviewTimetable = New FontAwesome.Sharp.IconButton()
        Me.BtnManageClass = New FontAwesome.Sharp.IconButton()
        Me.dropDownPanel1 = New System.Windows.Forms.Panel()
        Me.btnStudGrade = New FontAwesome.Sharp.IconButton()
        Me.btnStudAttendance = New FontAwesome.Sharp.IconButton()
        Me.btnManageStud = New FontAwesome.Sharp.IconButton()
        Me.btnDashboard = New FontAwesome.Sharp.IconButton()
        Me.btnLogout = New FontAwesome.Sharp.IconButton()
        Me.panelLogo = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.formTop = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.minimize = New System.Windows.Forms.PictureBox()
        Me.close = New System.Windows.Forms.PictureBox()
        Me.panelDesktop = New System.Windows.Forms.Panel()
        Me.timerLecManageStud = New System.Windows.Forms.Timer(Me.components)
        Me.timerCollapse = New System.Windows.Forms.Timer(Me.components)
        Me.timerProf = New System.Windows.Forms.Timer(Me.components)
        Me.timerTimetable = New System.Windows.Forms.Timer(Me.components)
        Me.timerClass = New System.Windows.Forms.Timer(Me.components)
        Me.timerDash = New System.Windows.Forms.Timer(Me.components)
        Me.panelMenu.SuspendLayout()
        Me.dropDownPanel1.SuspendLayout()
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
        Me.panelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.panelMenu.Controls.Add(Me.BtnProfile)
        Me.panelMenu.Controls.Add(Me.btnOverviewTimetable)
        Me.panelMenu.Controls.Add(Me.BtnManageClass)
        Me.panelMenu.Controls.Add(Me.dropDownPanel1)
        Me.panelMenu.Controls.Add(Me.btnManageStud)
        Me.panelMenu.Controls.Add(Me.btnDashboard)
        Me.panelMenu.Controls.Add(Me.btnLogout)
        Me.panelMenu.Controls.Add(Me.panelLogo)
        Me.panelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelMenu.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.panelMenu.Location = New System.Drawing.Point(0, 0)
        Me.panelMenu.Name = "panelMenu"
        Me.panelMenu.Size = New System.Drawing.Size(380, 949)
        Me.panelMenu.TabIndex = 3
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
        Me.BtnProfile.Location = New System.Drawing.Point(0, 618)
        Me.BtnProfile.Name = "BtnProfile"
        Me.BtnProfile.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.BtnProfile.Size = New System.Drawing.Size(380, 80)
        Me.BtnProfile.TabIndex = 6
        Me.BtnProfile.Text = "Profile"
        Me.BtnProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnProfile.UseVisualStyleBackColor = False
        '
        'btnOverviewTimetable
        '
        Me.btnOverviewTimetable.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnOverviewTimetable.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOverviewTimetable.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnOverviewTimetable.FlatAppearance.BorderSize = 0
        Me.btnOverviewTimetable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOverviewTimetable.Font = New System.Drawing.Font("Fira Code", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOverviewTimetable.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnOverviewTimetable.IconChar = FontAwesome.Sharp.IconChar.UserEdit
        Me.btnOverviewTimetable.IconColor = System.Drawing.Color.White
        Me.btnOverviewTimetable.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnOverviewTimetable.IconSize = 32
        Me.btnOverviewTimetable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOverviewTimetable.Location = New System.Drawing.Point(0, 538)
        Me.btnOverviewTimetable.Name = "btnOverviewTimetable"
        Me.btnOverviewTimetable.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnOverviewTimetable.Size = New System.Drawing.Size(380, 80)
        Me.btnOverviewTimetable.TabIndex = 7
        Me.btnOverviewTimetable.Text = "Overview Timetable"
        Me.btnOverviewTimetable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOverviewTimetable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOverviewTimetable.UseVisualStyleBackColor = False
        '
        'BtnManageClass
        '
        Me.BtnManageClass.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.BtnManageClass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnManageClass.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnManageClass.FlatAppearance.BorderSize = 0
        Me.BtnManageClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnManageClass.Font = New System.Drawing.Font("Fira Code", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnManageClass.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BtnManageClass.IconChar = FontAwesome.Sharp.IconChar.UserEdit
        Me.BtnManageClass.IconColor = System.Drawing.Color.White
        Me.BtnManageClass.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnManageClass.IconSize = 32
        Me.BtnManageClass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnManageClass.Location = New System.Drawing.Point(0, 458)
        Me.BtnManageClass.Name = "BtnManageClass"
        Me.BtnManageClass.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.BtnManageClass.Size = New System.Drawing.Size(380, 80)
        Me.BtnManageClass.TabIndex = 5
        Me.BtnManageClass.Text = "Manage Classes"
        Me.BtnManageClass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnManageClass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnManageClass.UseVisualStyleBackColor = False
        '
        'dropDownPanel1
        '
        Me.dropDownPanel1.Controls.Add(Me.btnStudGrade)
        Me.dropDownPanel1.Controls.Add(Me.btnStudAttendance)
        Me.dropDownPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.dropDownPanel1.Location = New System.Drawing.Point(0, 360)
        Me.dropDownPanel1.MaximumSize = New System.Drawing.Size(380, 98)
        Me.dropDownPanel1.Name = "dropDownPanel1"
        Me.dropDownPanel1.Size = New System.Drawing.Size(380, 98)
        Me.dropDownPanel1.TabIndex = 0
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
        Me.btnStudGrade.Location = New System.Drawing.Point(0, 50)
        Me.btnStudGrade.Name = "btnStudGrade"
        Me.btnStudGrade.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnStudGrade.Size = New System.Drawing.Size(380, 50)
        Me.btnStudGrade.TabIndex = 3
        Me.btnStudGrade.Text = "Student Grade"
        Me.btnStudGrade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStudGrade.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnStudGrade.UseVisualStyleBackColor = False
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
        Me.btnStudAttendance.Location = New System.Drawing.Point(0, 0)
        Me.btnStudAttendance.Name = "btnStudAttendance"
        Me.btnStudAttendance.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnStudAttendance.Size = New System.Drawing.Size(380, 50)
        Me.btnStudAttendance.TabIndex = 2
        Me.btnStudAttendance.Text = "Student Attendance"
        Me.btnStudAttendance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnStudAttendance.UseVisualStyleBackColor = False
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
        Me.btnManageStud.Size = New System.Drawing.Size(380, 80)
        Me.btnManageStud.TabIndex = 1
        Me.btnManageStud.Text = "Manage Students"
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
        Me.btnDashboard.Size = New System.Drawing.Size(380, 80)
        Me.btnDashboard.TabIndex = 0
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDashboard.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Fira Code", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnLogout.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft
        Me.btnLogout.IconColor = System.Drawing.Color.White
        Me.btnLogout.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnLogout.IconSize = 30
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.Location = New System.Drawing.Point(-1, 768)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnLogout.Size = New System.Drawing.Size(400, 85)
        Me.btnLogout.TabIndex = 4
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'panelLogo
        '
        Me.panelLogo.Controls.Add(Me.PictureBox1)
        Me.panelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelLogo.Location = New System.Drawing.Point(0, 0)
        Me.panelLogo.Name = "panelLogo"
        Me.panelLogo.Size = New System.Drawing.Size(380, 200)
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
        'formTop
        '
        Me.formTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.formTop.Controls.Add(Me.Panel1)
        Me.formTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.formTop.Location = New System.Drawing.Point(380, 0)
        Me.formTop.Name = "formTop"
        Me.formTop.Size = New System.Drawing.Size(1298, 60)
        Me.formTop.TabIndex = 7
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
        'panelDesktop
        '
        Me.panelDesktop.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelDesktop.Location = New System.Drawing.Point(380, 0)
        Me.panelDesktop.Name = "panelDesktop"
        Me.panelDesktop.Size = New System.Drawing.Size(1298, 949)
        Me.panelDesktop.TabIndex = 6
        '
        'timerLecManageStud
        '
        Me.timerLecManageStud.Interval = 10
        '
        'timerCollapse
        '
        Me.timerCollapse.Interval = 10
        '
        'timerProf
        '
        Me.timerProf.Interval = 10
        '
        'timerTimetable
        '
        Me.timerTimetable.Interval = 10
        '
        'timerClass
        '
        Me.timerClass.Interval = 10
        '
        'timerDash
        '
        Me.timerDash.Interval = 10
        '
        'LecForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1678, 949)
        Me.Controls.Add(Me.formTop)
        Me.Controls.Add(Me.panelDesktop)
        Me.Controls.Add(Me.panelMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximumSize = New System.Drawing.Size(1700, 1000)
        Me.MinimumSize = New System.Drawing.Size(1700, 1000)
        Me.Name = "LecForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LecForm"
        Me.panelMenu.ResumeLayout(False)
        Me.dropDownPanel1.ResumeLayout(False)
        Me.panelLogo.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.formTop.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.minimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.close, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelMenu As Panel
    Friend WithEvents BtnProfile As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnManageClass As FontAwesome.Sharp.IconButton
    Friend WithEvents btnLogout As FontAwesome.Sharp.IconButton
    Friend WithEvents btnManageStud As FontAwesome.Sharp.IconButton
    Friend WithEvents btnDashboard As FontAwesome.Sharp.IconButton
    Friend WithEvents panelLogo As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents formTop As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents minimize As PictureBox
    Friend WithEvents close As PictureBox
    Friend WithEvents panelDesktop As Panel
    Friend WithEvents dropDownPanel1 As Panel
    Friend WithEvents btnStudGrade As FontAwesome.Sharp.IconButton
    Friend WithEvents btnStudAttendance As FontAwesome.Sharp.IconButton
    Friend WithEvents timerLecManageStud As Timer
    Friend WithEvents btnOverviewTimetable As FontAwesome.Sharp.IconButton
    Friend WithEvents timerCollapse As Timer
    Friend WithEvents timerProf As Timer
    Friend WithEvents timerTimetable As Timer
    Friend WithEvents timerClass As Timer
    Friend WithEvents timerDash As Timer
End Class
