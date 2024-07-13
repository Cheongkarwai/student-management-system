<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StudentProfileForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentProfileForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cancelChangePass = New System.Windows.Forms.PictureBox()
        Me.cancelEditProf = New System.Windows.Forms.PictureBox()
        Me.linkLogout = New System.Windows.Forms.Label()
        Me.linkEditProfile = New System.Windows.Forms.Label()
        Me.linkChangePass = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtProgramme = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtPos = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.errorPass = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errorUsername = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errorName = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errorContact = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errorEmail = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSem = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.cancelChangePass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cancelEditProf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorPass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorUsername, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorContact, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Fira Code", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(128, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 63)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Profile"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1164, 753)
        Me.Panel1.TabIndex = 15
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.cancelChangePass)
        Me.Panel2.Controls.Add(Me.cancelEditProf)
        Me.Panel2.Controls.Add(Me.linkLogout)
        Me.Panel2.Controls.Add(Me.linkEditProfile)
        Me.Panel2.Controls.Add(Me.linkChangePass)
        Me.Panel2.Location = New System.Drawing.Point(76, 443)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(272, 413)
        Me.Panel2.TabIndex = 17
        '
        'cancelChangePass
        '
        Me.cancelChangePass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cancelChangePass.Image = CType(resources.GetObject("cancelChangePass.Image"), System.Drawing.Image)
        Me.cancelChangePass.Location = New System.Drawing.Point(234, 132)
        Me.cancelChangePass.Name = "cancelChangePass"
        Me.cancelChangePass.Size = New System.Drawing.Size(24, 28)
        Me.cancelChangePass.TabIndex = 9
        Me.cancelChangePass.TabStop = False
        Me.cancelChangePass.Visible = False
        '
        'cancelEditProf
        '
        Me.cancelEditProf.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cancelEditProf.Image = CType(resources.GetObject("cancelEditProf.Image"), System.Drawing.Image)
        Me.cancelEditProf.Location = New System.Drawing.Point(236, 27)
        Me.cancelEditProf.Name = "cancelEditProf"
        Me.cancelEditProf.Size = New System.Drawing.Size(24, 28)
        Me.cancelEditProf.TabIndex = 7
        Me.cancelEditProf.TabStop = False
        Me.cancelEditProf.Visible = False
        '
        'linkLogout
        '
        Me.linkLogout.AutoSize = True
        Me.linkLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.linkLogout.Font = New System.Drawing.Font("Monoid", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linkLogout.ForeColor = System.Drawing.Color.White
        Me.linkLogout.Location = New System.Drawing.Point(105, 232)
        Me.linkLogout.Name = "linkLogout"
        Me.linkLogout.Size = New System.Drawing.Size(69, 20)
        Me.linkLogout.TabIndex = 6
        Me.linkLogout.Text = "Logout"
        '
        'linkEditProfile
        '
        Me.linkEditProfile.AutoSize = True
        Me.linkEditProfile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.linkEditProfile.Font = New System.Drawing.Font("Monoid", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linkEditProfile.ForeColor = System.Drawing.Color.White
        Me.linkEditProfile.Location = New System.Drawing.Point(74, 35)
        Me.linkEditProfile.Name = "linkEditProfile"
        Me.linkEditProfile.Size = New System.Drawing.Size(129, 20)
        Me.linkEditProfile.TabIndex = 4
        Me.linkEditProfile.Text = "Edit Profile"
        '
        'linkChangePass
        '
        Me.linkChangePass.AutoSize = True
        Me.linkChangePass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.linkChangePass.Font = New System.Drawing.Font("Monoid", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linkChangePass.ForeColor = System.Drawing.Color.White
        Me.linkChangePass.Location = New System.Drawing.Point(56, 140)
        Me.linkChangePass.Name = "linkChangePass"
        Me.linkChangePass.Size = New System.Drawing.Size(159, 20)
        Me.linkChangePass.TabIndex = 3
        Me.linkChangePass.Text = "Change Password"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.txtSem)
        Me.Panel4.Controls.Add(Me.txtProgramme)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.txtEmail)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.txtName)
        Me.Panel4.Controls.Add(Me.txtPass)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.txtUsername)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.txtContact)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.txtPos)
        Me.Panel4.Location = New System.Drawing.Point(386, 166)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(890, 605)
        Me.Panel4.TabIndex = 16
        '
        'txtProgramme
        '
        Me.txtProgramme.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.txtProgramme.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtProgramme.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtProgramme.Enabled = False
        Me.txtProgramme.Font = New System.Drawing.Font("Fira Code", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProgramme.ForeColor = System.Drawing.Color.White
        Me.txtProgramme.Location = New System.Drawing.Point(57, 540)
        Me.txtProgramme.Name = "txtProgramme"
        Me.txtProgramme.Size = New System.Drawing.Size(572, 24)
        Me.txtProgramme.TabIndex = 16
        Me.txtProgramme.Text = "Information Technology"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Fira Code", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(50, 470)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 37)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Programme"
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmail.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtEmail.Enabled = False
        Me.txtEmail.Font = New System.Drawing.Font("Fira Code", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.Color.White
        Me.txtEmail.Location = New System.Drawing.Point(57, 397)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(358, 24)
        Me.txtEmail.TabIndex = 14
        Me.txtEmail.Text = "cheong@icloud.com"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Fira Code", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(49, 325)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(199, 37)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Email Address"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Fira Code", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(49, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 37)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Name"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Fira Code", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(521, 57)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(129, 37)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Username"
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtName.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtName.Enabled = False
        Me.txtName.Font = New System.Drawing.Font("Fira Code", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.ForeColor = System.Drawing.Color.White
        Me.txtName.Location = New System.Drawing.Point(57, 121)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(367, 24)
        Me.txtName.TabIndex = 2
        Me.txtName.Text = "Cheong"
        '
        'txtPass
        '
        Me.txtPass.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPass.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtPass.Enabled = False
        Me.txtPass.Font = New System.Drawing.Font("Fira Code", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.ForeColor = System.Drawing.Color.White
        Me.txtPass.Location = New System.Drawing.Point(529, 255)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(321, 24)
        Me.txtPass.TabIndex = 7
        Me.txtPass.Text = "aaas"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Fira Code", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(521, 188)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(129, 37)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Password"
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtUsername.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtUsername.Enabled = False
        Me.txtUsername.Font = New System.Drawing.Font("Fira Code", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.Color.White
        Me.txtUsername.Location = New System.Drawing.Point(529, 121)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(316, 24)
        Me.txtUsername.TabIndex = 5
        Me.txtUsername.Text = "@cheong"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Fira Code", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(49, 188)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(185, 37)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Phone Number"
        '
        'txtContact
        '
        Me.txtContact.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.txtContact.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtContact.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtContact.Enabled = False
        Me.txtContact.Font = New System.Drawing.Font("Fira Code", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.ForeColor = System.Drawing.Color.White
        Me.txtContact.Location = New System.Drawing.Point(57, 255)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(358, 24)
        Me.txtContact.TabIndex = 9
        Me.txtContact.Text = "6011-28188291"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Fira Code", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(521, 325)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(129, 37)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Position"
        '
        'txtPos
        '
        Me.txtPos.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.txtPos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPos.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtPos.Enabled = False
        Me.txtPos.Font = New System.Drawing.Font("Fira Code", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPos.ForeColor = System.Drawing.Color.White
        Me.txtPos.Location = New System.Drawing.Point(528, 397)
        Me.txtPos.Name = "txtPos"
        Me.txtPos.Size = New System.Drawing.Size(358, 24)
        Me.txtPos.TabIndex = 11
        Me.txtPos.Text = "Student"
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.WindowsApp2.My.Resources.Resources.pencil
        Me.PictureBox2.Location = New System.Drawing.Point(325, 384)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(33, 34)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(92, 186)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(266, 232)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'errorPass
        '
        Me.errorPass.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.errorPass.ContainerControl = Me
        Me.errorPass.Icon = CType(resources.GetObject("errorPass.Icon"), System.Drawing.Icon)
        '
        'errorUsername
        '
        Me.errorUsername.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.errorUsername.ContainerControl = Me
        Me.errorUsername.Icon = CType(resources.GetObject("errorUsername.Icon"), System.Drawing.Icon)
        '
        'errorName
        '
        Me.errorName.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.errorName.ContainerControl = Me
        Me.errorName.Icon = CType(resources.GetObject("errorName.Icon"), System.Drawing.Icon)
        '
        'errorContact
        '
        Me.errorContact.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.errorContact.ContainerControl = Me
        Me.errorContact.Icon = CType(resources.GetObject("errorContact.Icon"), System.Drawing.Icon)
        '
        'errorEmail
        '
        Me.errorEmail.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.errorEmail.ContainerControl = Me
        Me.errorEmail.Icon = CType(resources.GetObject("errorEmail.Icon"), System.Drawing.Icon)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Fira Code", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(521, 468)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 37)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Semester"
        '
        'txtSem
        '
        Me.txtSem.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.txtSem.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSem.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtSem.Enabled = False
        Me.txtSem.Font = New System.Drawing.Font("Fira Code", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSem.ForeColor = System.Drawing.Color.White
        Me.txtSem.Location = New System.Drawing.Point(528, 540)
        Me.txtSem.Name = "txtSem"
        Me.txtSem.Size = New System.Drawing.Size(358, 24)
        Me.txtSem.TabIndex = 18
        Me.txtSem.Text = "Student"
        '
        'StudentProfileForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1164, 753)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Name = "StudentProfileForm"
        Me.Text = "Profile"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.cancelChangePass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cancelEditProf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorPass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorUsername, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorContact, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorEmail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtProgramme As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtContact As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtPos As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cancelChangePass As PictureBox
    Friend WithEvents cancelEditProf As PictureBox
    Friend WithEvents linkLogout As Label
    Friend WithEvents linkEditProfile As Label
    Friend WithEvents linkChangePass As Label
    Friend WithEvents errorPass As ErrorProvider
    Friend WithEvents errorUsername As ErrorProvider
    Friend WithEvents errorName As ErrorProvider
    Friend WithEvents errorContact As ErrorProvider
    Friend WithEvents errorEmail As ErrorProvider
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSem As TextBox
End Class
