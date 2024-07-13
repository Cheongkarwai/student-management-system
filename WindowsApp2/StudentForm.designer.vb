<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StudentForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentForm))
        Me.panelMenu = New System.Windows.Forms.Panel()
        Me.BtnProfile = New FontAwesome.Sharp.IconButton()
        Me.BtnGrade = New FontAwesome.Sharp.IconButton()
        Me.btnLogout = New FontAwesome.Sharp.IconButton()
        Me.BtnEvent = New FontAwesome.Sharp.IconButton()
        Me.btnCourseSelection = New FontAwesome.Sharp.IconButton()
        Me.btnDashboard = New FontAwesome.Sharp.IconButton()
        Me.panelLogo = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.panelDesktop = New System.Windows.Forms.Panel()
        Me.formTop = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.minimize = New System.Windows.Forms.PictureBox()
        Me.close = New System.Windows.Forms.PictureBox()
        Me.panelMenu.SuspendLayout()
        Me.panelLogo.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.panelMenu.Controls.Add(Me.BtnGrade)
        Me.panelMenu.Controls.Add(Me.btnLogout)
        Me.panelMenu.Controls.Add(Me.BtnEvent)
        Me.panelMenu.Controls.Add(Me.btnCourseSelection)
        Me.panelMenu.Controls.Add(Me.btnDashboard)
        Me.panelMenu.Controls.Add(Me.panelLogo)
        Me.panelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelMenu.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.panelMenu.Location = New System.Drawing.Point(0, 0)
        Me.panelMenu.Name = "panelMenu"
        Me.panelMenu.Size = New System.Drawing.Size(380, 853)
        Me.panelMenu.TabIndex = 2
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
        Me.BtnProfile.Location = New System.Drawing.Point(0, 520)
        Me.BtnProfile.Name = "BtnProfile"
        Me.BtnProfile.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.BtnProfile.Size = New System.Drawing.Size(380, 80)
        Me.BtnProfile.TabIndex = 6
        Me.BtnProfile.Text = "Profile"
        Me.BtnProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnProfile.UseVisualStyleBackColor = False
        '
        'BtnGrade
        '
        Me.BtnGrade.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.BtnGrade.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnGrade.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnGrade.FlatAppearance.BorderSize = 0
        Me.BtnGrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGrade.Font = New System.Drawing.Font("Fira Code", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGrade.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BtnGrade.IconChar = FontAwesome.Sharp.IconChar.UserEdit
        Me.BtnGrade.IconColor = System.Drawing.Color.White
        Me.BtnGrade.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnGrade.IconSize = 32
        Me.BtnGrade.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGrade.Location = New System.Drawing.Point(0, 440)
        Me.BtnGrade.Name = "BtnGrade"
        Me.BtnGrade.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.BtnGrade.Size = New System.Drawing.Size(380, 80)
        Me.BtnGrade.TabIndex = 5
        Me.BtnGrade.Text = "Grade Report"
        Me.BtnGrade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGrade.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnGrade.UseVisualStyleBackColor = False
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
        'BtnEvent
        '
        Me.BtnEvent.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.BtnEvent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEvent.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnEvent.FlatAppearance.BorderSize = 0
        Me.BtnEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEvent.Font = New System.Drawing.Font("Fira Code", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEvent.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BtnEvent.IconChar = FontAwesome.Sharp.IconChar.Desktop
        Me.BtnEvent.IconColor = System.Drawing.Color.White
        Me.BtnEvent.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnEvent.IconSize = 32
        Me.BtnEvent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEvent.Location = New System.Drawing.Point(0, 360)
        Me.BtnEvent.Name = "BtnEvent"
        Me.BtnEvent.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.BtnEvent.Size = New System.Drawing.Size(380, 80)
        Me.BtnEvent.TabIndex = 2
        Me.BtnEvent.Text = "Cocurriculum"
        Me.BtnEvent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEvent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnEvent.UseVisualStyleBackColor = False
        '
        'btnCourseSelection
        '
        Me.btnCourseSelection.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnCourseSelection.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCourseSelection.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCourseSelection.FlatAppearance.BorderSize = 0
        Me.btnCourseSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCourseSelection.Font = New System.Drawing.Font("Fira Code", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCourseSelection.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnCourseSelection.IconChar = FontAwesome.Sharp.IconChar.GraduationCap
        Me.btnCourseSelection.IconColor = System.Drawing.Color.White
        Me.btnCourseSelection.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnCourseSelection.IconSize = 32
        Me.btnCourseSelection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCourseSelection.Location = New System.Drawing.Point(0, 280)
        Me.btnCourseSelection.Name = "btnCourseSelection"
        Me.btnCourseSelection.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnCourseSelection.Size = New System.Drawing.Size(380, 80)
        Me.btnCourseSelection.TabIndex = 1
        Me.btnCourseSelection.Text = "Course Selection"
        Me.btnCourseSelection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCourseSelection.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCourseSelection.UseVisualStyleBackColor = False
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
        'panelLogo
        '
        Me.panelLogo.Controls.Add(Me.PictureBox2)
        Me.panelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelLogo.Location = New System.Drawing.Point(0, 0)
        Me.panelLogo.Name = "panelLogo"
        Me.panelLogo.Size = New System.Drawing.Size(380, 200)
        Me.panelLogo.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.WindowsApp2.My.Resources.Resources.ucsi_university_logo
        Me.PictureBox2.Location = New System.Drawing.Point(81, 53)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(197, 107)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'panelDesktop
        '
        Me.panelDesktop.AutoSize = True
        Me.panelDesktop.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelDesktop.Location = New System.Drawing.Point(380, 0)
        Me.panelDesktop.Name = "panelDesktop"
        Me.panelDesktop.Size = New System.Drawing.Size(1302, 853)
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
        'StudentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1682, 853)
        Me.Controls.Add(Me.formTop)
        Me.Controls.Add(Me.panelDesktop)
        Me.Controls.Add(Me.panelMenu)
        Me.MinimumSize = New System.Drawing.Size(1700, 900)
        Me.Name = "StudentForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.panelMenu.ResumeLayout(False)
        Me.panelLogo.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents BtnEvent As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCourseSelection As FontAwesome.Sharp.IconButton
    Friend WithEvents btnDashboard As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnGrade As FontAwesome.Sharp.IconButton
    Friend WithEvents panelDesktop As Panel
    Friend WithEvents BtnProfile As FontAwesome.Sharp.IconButton
    Friend WithEvents formTop As Panel
    Friend WithEvents minimize As PictureBox
    Friend WithEvents close As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
End Class
