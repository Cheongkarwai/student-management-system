<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LecProfileForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LecProfileForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cancelChangePass = New System.Windows.Forms.PictureBox()
        Me.cancelEditProf = New System.Windows.Forms.PictureBox()
        Me.linkLogout = New System.Windows.Forms.Label()
        Me.linkEditProfile = New System.Windows.Forms.Label()
        Me.linkChangePass = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtDepartment = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.lblPos = New System.Windows.Forms.Label()
        Me.txtPos = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.errorName = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errorContact = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errorEmail = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errorUsername = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errorPass = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.cancelChangePass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cancelEditProf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorContact, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorUsername, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorPass, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1164, 753)
        Me.Panel1.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label4.Font = New System.Drawing.Font("Monoid", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(571, 852)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 17)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "12 December 2022"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Font = New System.Drawing.Font("Monoid", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(431, 852)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Last edited : "
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.WindowsApp2.My.Resources.Resources.pencil
        Me.PictureBox2.Location = New System.Drawing.Point(325, 434)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(33, 34)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.cancelChangePass)
        Me.Panel3.Controls.Add(Me.cancelEditProf)
        Me.Panel3.Controls.Add(Me.linkLogout)
        Me.Panel3.Controls.Add(Me.linkEditProfile)
        Me.Panel3.Controls.Add(Me.linkChangePass)
        Me.Panel3.Location = New System.Drawing.Point(92, 515)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(272, 413)
        Me.Panel3.TabIndex = 13
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
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtDepartment)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.txtEmail)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.lblName)
        Me.Panel2.Controls.Add(Me.lblUser)
        Me.Panel2.Controls.Add(Me.txtName)
        Me.Panel2.Controls.Add(Me.txtPass)
        Me.Panel2.Controls.Add(Me.lblPass)
        Me.Panel2.Controls.Add(Me.txtUsername)
        Me.Panel2.Controls.Add(Me.lblPhone)
        Me.Panel2.Controls.Add(Me.txtContact)
        Me.Panel2.Controls.Add(Me.lblPos)
        Me.Panel2.Controls.Add(Me.txtPos)
        Me.Panel2.Location = New System.Drawing.Point(417, 216)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(890, 605)
        Me.Panel2.TabIndex = 12
        '
        'txtDepartment
        '
        Me.txtDepartment.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.txtDepartment.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDepartment.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtDepartment.Enabled = False
        Me.txtDepartment.Font = New System.Drawing.Font("Fira Code", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDepartment.ForeColor = System.Drawing.Color.White
        Me.txtDepartment.Location = New System.Drawing.Point(57, 540)
        Me.txtDepartment.Name = "txtDepartment"
        Me.txtDepartment.Size = New System.Drawing.Size(572, 24)
        Me.txtDepartment.TabIndex = 16
        Me.txtDepartment.Text = "Information Technology"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Fira Code", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(50, 470)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(157, 37)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Department"
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Fira Code", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(49, 325)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(199, 37)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Email Address"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Fira Code", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.White
        Me.lblName.Location = New System.Drawing.Point(49, 57)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(73, 37)
        Me.lblName.TabIndex = 12
        Me.lblName.Text = "Name"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Fira Code", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.Color.White
        Me.lblUser.Location = New System.Drawing.Point(521, 57)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(129, 37)
        Me.lblUser.TabIndex = 4
        Me.lblUser.Text = "Username"
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
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Font = New System.Drawing.Font("Fira Code", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPass.ForeColor = System.Drawing.Color.White
        Me.lblPass.Location = New System.Drawing.Point(521, 188)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(129, 37)
        Me.lblPass.TabIndex = 6
        Me.lblPass.Text = "Password"
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
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Font = New System.Drawing.Font("Fira Code", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhone.ForeColor = System.Drawing.Color.White
        Me.lblPhone.Location = New System.Drawing.Point(49, 188)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(185, 37)
        Me.lblPhone.TabIndex = 8
        Me.lblPhone.Text = "Phone Number"
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
        Me.txtContact.Text = "01128188291"
        '
        'lblPos
        '
        Me.lblPos.AutoSize = True
        Me.lblPos.Font = New System.Drawing.Font("Fira Code", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPos.ForeColor = System.Drawing.Color.White
        Me.lblPos.Location = New System.Drawing.Point(521, 325)
        Me.lblPos.Name = "lblPos"
        Me.lblPos.Size = New System.Drawing.Size(129, 37)
        Me.lblPos.TabIndex = 10
        Me.lblPos.Text = "Position"
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
        Me.txtPos.Text = "Lecturer"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Fira Code", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(128, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 63)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Profile"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(92, 236)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(266, 232)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
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
        'errorUsername
        '
        Me.errorUsername.ContainerControl = Me
        '
        'errorPass
        '
        Me.errorPass.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.errorPass.ContainerControl = Me
        Me.errorPass.Icon = CType(resources.GetObject("errorPass.Icon"), System.Drawing.Icon)
        '
        'LecProfileForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1164, 753)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "LecProfileForm"
        Me.Text = "LecProfile"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.cancelChangePass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cancelEditProf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorContact, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorUsername, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorPass, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents cancelChangePass As PictureBox
    Friend WithEvents cancelEditProf As PictureBox
    Friend WithEvents linkLogout As Label
    Friend WithEvents linkEditProfile As Label
    Friend WithEvents linkChangePass As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents lblPass As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblPhone As Label
    Friend WithEvents txtContact As TextBox
    Friend WithEvents lblPos As Label
    Friend WithEvents txtPos As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtDepartment As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents errorName As ErrorProvider
    Friend WithEvents errorContact As ErrorProvider
    Friend WithEvents errorEmail As ErrorProvider
    Friend WithEvents errorUsername As ErrorProvider
    Friend WithEvents errorPass As ErrorProvider
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class
