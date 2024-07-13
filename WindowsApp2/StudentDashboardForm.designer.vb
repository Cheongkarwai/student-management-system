<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StudentDashboardForm
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
        Me.panelDashb = New System.Windows.Forms.Panel()
        Me.pProfile = New System.Windows.Forms.Panel()
        Me.txtUser = New System.Windows.Forms.Label()
        Me.picUser = New System.Windows.Forms.PictureBox()
        Me.pCocurriculum = New System.Windows.Forms.Panel()
        Me.txtCocurriculum = New System.Windows.Forms.Label()
        Me.picCocurriculum = New System.Windows.Forms.PictureBox()
        Me.pGrade = New System.Windows.Forms.Panel()
        Me.txtGrade = New System.Windows.Forms.Label()
        Me.picGrade = New System.Windows.Forms.PictureBox()
        Me.pCourse = New System.Windows.Forms.Panel()
        Me.txtCourse = New System.Windows.Forms.Label()
        Me.picCourse = New System.Windows.Forms.PictureBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.panelDashb.SuspendLayout()
        Me.pProfile.SuspendLayout()
        CType(Me.picUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pCocurriculum.SuspendLayout()
        CType(Me.picCocurriculum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pGrade.SuspendLayout()
        CType(Me.picGrade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pCourse.SuspendLayout()
        CType(Me.picCourse, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelDashb
        '
        Me.panelDashb.AutoScroll = True
        Me.panelDashb.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.panelDashb.Controls.Add(Me.pProfile)
        Me.panelDashb.Controls.Add(Me.pCocurriculum)
        Me.panelDashb.Controls.Add(Me.pGrade)
        Me.panelDashb.Controls.Add(Me.pCourse)
        Me.panelDashb.Controls.Add(Me.Label25)
        Me.panelDashb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelDashb.Location = New System.Drawing.Point(0, 0)
        Me.panelDashb.Margin = New System.Windows.Forms.Padding(2)
        Me.panelDashb.Name = "panelDashb"
        Me.panelDashb.Size = New System.Drawing.Size(1106, 645)
        Me.panelDashb.TabIndex = 0
        '
        'pProfile
        '
        Me.pProfile.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.pProfile.Controls.Add(Me.txtUser)
        Me.pProfile.Controls.Add(Me.picUser)
        Me.pProfile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pProfile.Location = New System.Drawing.Point(154, 448)
        Me.pProfile.Margin = New System.Windows.Forms.Padding(2)
        Me.pProfile.Name = "pProfile"
        Me.pProfile.Size = New System.Drawing.Size(263, 240)
        Me.pProfile.TabIndex = 21
        '
        'txtUser
        '
        Me.txtUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtUser.Font = New System.Drawing.Font("Monoid", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.ForeColor = System.Drawing.Color.White
        Me.txtUser.Location = New System.Drawing.Point(82, 188)
        Me.txtUser.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(125, 25)
        Me.txtUser.TabIndex = 4
        Me.txtUser.Text = "User Profile"
        '
        'picUser
        '
        Me.picUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picUser.Image = Global.WindowsApp2.My.Resources.Resources.user
        Me.picUser.Location = New System.Drawing.Point(86, 50)
        Me.picUser.Margin = New System.Windows.Forms.Padding(2)
        Me.picUser.Name = "picUser"
        Me.picUser.Size = New System.Drawing.Size(98, 98)
        Me.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picUser.TabIndex = 3
        Me.picUser.TabStop = False
        '
        'pCocurriculum
        '
        Me.pCocurriculum.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.pCocurriculum.Controls.Add(Me.txtCocurriculum)
        Me.pCocurriculum.Controls.Add(Me.picCocurriculum)
        Me.pCocurriculum.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pCocurriculum.Location = New System.Drawing.Point(637, 142)
        Me.pCocurriculum.Margin = New System.Windows.Forms.Padding(2)
        Me.pCocurriculum.Name = "pCocurriculum"
        Me.pCocurriculum.Size = New System.Drawing.Size(263, 240)
        Me.pCocurriculum.TabIndex = 19
        '
        'txtCocurriculum
        '
        Me.txtCocurriculum.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtCocurriculum.Font = New System.Drawing.Font("Monoid", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCocurriculum.ForeColor = System.Drawing.Color.White
        Me.txtCocurriculum.Location = New System.Drawing.Point(78, 173)
        Me.txtCocurriculum.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtCocurriculum.Name = "txtCocurriculum"
        Me.txtCocurriculum.Size = New System.Drawing.Size(125, 25)
        Me.txtCocurriculum.TabIndex = 2
        Me.txtCocurriculum.Text = "Cocurriculum"
        '
        'picCocurriculum
        '
        Me.picCocurriculum.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picCocurriculum.Image = Global.WindowsApp2.My.Resources.Resources._event
        Me.picCocurriculum.Location = New System.Drawing.Point(82, 46)
        Me.picCocurriculum.Margin = New System.Windows.Forms.Padding(2)
        Me.picCocurriculum.Name = "picCocurriculum"
        Me.picCocurriculum.Size = New System.Drawing.Size(104, 90)
        Me.picCocurriculum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCocurriculum.TabIndex = 2
        Me.picCocurriculum.TabStop = False
        '
        'pGrade
        '
        Me.pGrade.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.pGrade.Controls.Add(Me.txtGrade)
        Me.pGrade.Controls.Add(Me.picGrade)
        Me.pGrade.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pGrade.Location = New System.Drawing.Point(637, 448)
        Me.pGrade.Margin = New System.Windows.Forms.Padding(2)
        Me.pGrade.Name = "pGrade"
        Me.pGrade.Size = New System.Drawing.Size(263, 240)
        Me.pGrade.TabIndex = 20
        '
        'txtGrade
        '
        Me.txtGrade.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtGrade.Font = New System.Drawing.Font("Monoid", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrade.ForeColor = System.Drawing.Color.White
        Me.txtGrade.Location = New System.Drawing.Point(78, 173)
        Me.txtGrade.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtGrade.Name = "txtGrade"
        Me.txtGrade.Size = New System.Drawing.Size(125, 25)
        Me.txtGrade.TabIndex = 3
        Me.txtGrade.Text = "Grade Report"
        '
        'picGrade
        '
        Me.picGrade.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picGrade.Image = Global.WindowsApp2.My.Resources.Resources.grades
        Me.picGrade.Location = New System.Drawing.Point(82, 46)
        Me.picGrade.Margin = New System.Windows.Forms.Padding(2)
        Me.picGrade.Name = "picGrade"
        Me.picGrade.Size = New System.Drawing.Size(114, 100)
        Me.picGrade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picGrade.TabIndex = 1
        Me.picGrade.TabStop = False
        '
        'pCourse
        '
        Me.pCourse.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.pCourse.Controls.Add(Me.txtCourse)
        Me.pCourse.Controls.Add(Me.picCourse)
        Me.pCourse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pCourse.Location = New System.Drawing.Point(154, 142)
        Me.pCourse.Margin = New System.Windows.Forms.Padding(2)
        Me.pCourse.Name = "pCourse"
        Me.pCourse.Size = New System.Drawing.Size(263, 240)
        Me.pCourse.TabIndex = 18
        '
        'txtCourse
        '
        Me.txtCourse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtCourse.Font = New System.Drawing.Font("Monoid", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCourse.ForeColor = System.Drawing.Color.White
        Me.txtCourse.Location = New System.Drawing.Point(54, 173)
        Me.txtCourse.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.Size = New System.Drawing.Size(166, 25)
        Me.txtCourse.TabIndex = 1
        Me.txtCourse.Text = "Course Selection"
        '
        'picCourse
        '
        Me.picCourse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picCourse.Image = Global.WindowsApp2.My.Resources.Resources.online_course
        Me.picCourse.Location = New System.Drawing.Point(87, 46)
        Me.picCourse.Margin = New System.Windows.Forms.Padding(2)
        Me.picCourse.Name = "picCourse"
        Me.picCourse.Size = New System.Drawing.Size(94, 90)
        Me.picCourse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCourse.TabIndex = 0
        Me.picCourse.TabStop = False
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Fira Code", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(38, 76)
        Me.Label25.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(143, 38)
        Me.Label25.TabIndex = 16
        Me.Label25.Text = "Dashboard"
        '
        'StudentDashboardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1106, 645)
        Me.Controls.Add(Me.panelDashb)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "StudentDashboardForm"
        Me.Text = "Form1"
        Me.panelDashb.ResumeLayout(False)
        Me.panelDashb.PerformLayout()
        Me.pProfile.ResumeLayout(False)
        CType(Me.picUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pCocurriculum.ResumeLayout(False)
        CType(Me.picCocurriculum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pGrade.ResumeLayout(False)
        CType(Me.picGrade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pCourse.ResumeLayout(False)
        CType(Me.picCourse, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelDashb As Panel
    Friend WithEvents Label25 As Label
    Friend WithEvents pCourse As Panel
    Friend WithEvents pProfile As Panel
    Friend WithEvents pCocurriculum As Panel
    Friend WithEvents pGrade As Panel
    Friend WithEvents picCourse As PictureBox
    Friend WithEvents picGrade As PictureBox
    Friend WithEvents picCocurriculum As PictureBox
    Friend WithEvents picUser As PictureBox
    Friend WithEvents txtUser As Label
    Friend WithEvents txtCocurriculum As Label
    Friend WithEvents txtGrade As Label
    Friend WithEvents txtCourse As Label
End Class
