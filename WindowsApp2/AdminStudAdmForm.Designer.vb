<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminStudAdmForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminStudAdmForm))
        Me.cbxAdm = New System.Windows.Forms.ComboBox()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panelEditAdm = New System.Windows.Forms.Panel()
        Me.btnZoom = New System.Windows.Forms.Button()
        Me.pic = New System.Windows.Forms.PictureBox()
        Me.txtCountry = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDOB = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPassport = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtStudentID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtProgramme = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtIC = New System.Windows.Forms.TextBox()
        Me.txtStudentEmail = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtPostcode = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.btnAdmReject = New System.Windows.Forms.Button()
        Me.btnAdmAdd = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvAdm = New System.Windows.Forms.DataGridView()
        Me.applicantNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.applicantName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ic = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.passport = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.country = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.contact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dateOfBirth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.emailAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.homeAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.state = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.city = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.postcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.programme = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.result = New System.Windows.Forms.DataGridViewImageColumn()
        Me.errorID = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.panelEditAdm.SuspendLayout()
        CType(Me.pic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvAdm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbxAdm
        '
        Me.cbxAdm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxAdm.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxAdm.FormattingEnabled = True
        Me.cbxAdm.Items.AddRange(New Object() {"ID", "Name ", "Programme "})
        Me.cbxAdm.Location = New System.Drawing.Point(949, 154)
        Me.cbxAdm.Name = "cbxAdm"
        Me.cbxAdm.Size = New System.Drawing.Size(181, 34)
        Me.cbxAdm.TabIndex = 43
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.Font = New System.Drawing.Font("Monoid", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label69.ForeColor = System.Drawing.Color.White
        Me.Label69.Location = New System.Drawing.Point(766, 163)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(161, 17)
        Me.Label69.TabIndex = 42
        Me.Label69.Text = "Sort By Order A-Z"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Fira Code", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(119, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(254, 47)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "New Admission"
        '
        'panelEditAdm
        '
        Me.panelEditAdm.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.panelEditAdm.Controls.Add(Me.btnZoom)
        Me.panelEditAdm.Controls.Add(Me.pic)
        Me.panelEditAdm.Controls.Add(Me.txtCountry)
        Me.panelEditAdm.Controls.Add(Me.Label8)
        Me.panelEditAdm.Controls.Add(Me.txtGender)
        Me.panelEditAdm.Controls.Add(Me.Label7)
        Me.panelEditAdm.Controls.Add(Me.txtDOB)
        Me.panelEditAdm.Controls.Add(Me.Label6)
        Me.panelEditAdm.Controls.Add(Me.txtPassport)
        Me.panelEditAdm.Controls.Add(Me.Label5)
        Me.panelEditAdm.Controls.Add(Me.txtStudentID)
        Me.panelEditAdm.Controls.Add(Me.Label4)
        Me.panelEditAdm.Controls.Add(Me.txtState)
        Me.panelEditAdm.Controls.Add(Me.txtCity)
        Me.panelEditAdm.Controls.Add(Me.txtProgramme)
        Me.panelEditAdm.Controls.Add(Me.Label3)
        Me.panelEditAdm.Controls.Add(Me.txtIC)
        Me.panelEditAdm.Controls.Add(Me.txtStudentEmail)
        Me.panelEditAdm.Controls.Add(Me.Label28)
        Me.panelEditAdm.Controls.Add(Me.txtEmail)
        Me.panelEditAdm.Controls.Add(Me.Label27)
        Me.panelEditAdm.Controls.Add(Me.txtContact)
        Me.panelEditAdm.Controls.Add(Me.Label26)
        Me.panelEditAdm.Controls.Add(Me.Label25)
        Me.panelEditAdm.Controls.Add(Me.txtPostcode)
        Me.panelEditAdm.Controls.Add(Me.Label24)
        Me.panelEditAdm.Controls.Add(Me.Label23)
        Me.panelEditAdm.Controls.Add(Me.Label22)
        Me.panelEditAdm.Controls.Add(Me.txtAddress)
        Me.panelEditAdm.Controls.Add(Me.Label21)
        Me.panelEditAdm.Controls.Add(Me.Label20)
        Me.panelEditAdm.Controls.Add(Me.txtName)
        Me.panelEditAdm.Controls.Add(Me.Label19)
        Me.panelEditAdm.Location = New System.Drawing.Point(91, 936)
        Me.panelEditAdm.Name = "panelEditAdm"
        Me.panelEditAdm.Size = New System.Drawing.Size(1080, 1194)
        Me.panelEditAdm.TabIndex = 13
        '
        'btnZoom
        '
        Me.btnZoom.BackColor = System.Drawing.Color.SeaShell
        Me.btnZoom.Location = New System.Drawing.Point(653, 1035)
        Me.btnZoom.Name = "btnZoom"
        Me.btnZoom.Size = New System.Drawing.Size(174, 34)
        Me.btnZoom.TabIndex = 44
        Me.btnZoom.Text = "Click to view"
        Me.btnZoom.UseVisualStyleBackColor = False
        '
        'pic
        '
        Me.pic.Location = New System.Drawing.Point(653, 751)
        Me.pic.Name = "pic"
        Me.pic.Size = New System.Drawing.Size(353, 268)
        Me.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic.TabIndex = 43
        Me.pic.TabStop = False
        '
        'txtCountry
        '
        Me.txtCountry.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtCountry.Font = New System.Drawing.Font("Fira Code", 13.8!)
        Me.txtCountry.Location = New System.Drawing.Point(171, 864)
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.ReadOnly = True
        Me.txtCountry.Size = New System.Drawing.Size(308, 38)
        Me.txtCountry.TabIndex = 42
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Fira Code", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(166, 833)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 28)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Country"
        '
        'txtGender
        '
        Me.txtGender.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtGender.Font = New System.Drawing.Font("Fira Code", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGender.Location = New System.Drawing.Point(171, 642)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.ReadOnly = True
        Me.txtGender.Size = New System.Drawing.Size(54, 38)
        Me.txtGender.TabIndex = 40
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Fira Code", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(166, 611)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 28)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Gender"
        '
        'txtDOB
        '
        Me.txtDOB.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtDOB.Font = New System.Drawing.Font("Fira Code", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDOB.Location = New System.Drawing.Point(171, 751)
        Me.txtDOB.Name = "txtDOB"
        Me.txtDOB.Size = New System.Drawing.Size(308, 38)
        Me.txtDOB.TabIndex = 38
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Fira Code", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(166, 720)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(155, 28)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Date Of Birth"
        '
        'txtPassport
        '
        Me.txtPassport.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtPassport.Font = New System.Drawing.Font("Fira Code", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassport.Location = New System.Drawing.Point(171, 533)
        Me.txtPassport.Name = "txtPassport"
        Me.txtPassport.ReadOnly = True
        Me.txtPassport.Size = New System.Drawing.Size(308, 38)
        Me.txtPassport.TabIndex = 36
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Fira Code", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(166, 502)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(177, 28)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Passport Number"
        '
        'txtStudentID
        '
        Me.txtStudentID.BackColor = System.Drawing.Color.Silver
        Me.txtStudentID.Font = New System.Drawing.Font("Fira Code", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentID.Location = New System.Drawing.Point(171, 207)
        Me.txtStudentID.MaxLength = 10
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.ReadOnly = True
        Me.txtStudentID.Size = New System.Drawing.Size(308, 38)
        Me.txtStudentID.TabIndex = 34
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Fira Code", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(166, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 28)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Student ID"
        '
        'txtState
        '
        Me.txtState.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtState.Font = New System.Drawing.Font("Fira Code", 13.8!)
        Me.txtState.Location = New System.Drawing.Point(653, 428)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(308, 38)
        Me.txtState.TabIndex = 32
        '
        'txtCity
        '
        Me.txtCity.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtCity.Font = New System.Drawing.Font("Fira Code", 13.8!)
        Me.txtCity.Location = New System.Drawing.Point(653, 533)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.ReadOnly = True
        Me.txtCity.Size = New System.Drawing.Size(308, 38)
        Me.txtCity.TabIndex = 31
        '
        'txtProgramme
        '
        Me.txtProgramme.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtProgramme.Font = New System.Drawing.Font("Fira Code", 13.8!)
        Me.txtProgramme.Location = New System.Drawing.Point(653, 207)
        Me.txtProgramme.Name = "txtProgramme"
        Me.txtProgramme.ReadOnly = True
        Me.txtProgramme.Size = New System.Drawing.Size(308, 38)
        Me.txtProgramme.TabIndex = 30
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Fira Code", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(648, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 28)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Programme"
        '
        'txtIC
        '
        Me.txtIC.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtIC.Font = New System.Drawing.Font("Fira Code", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIC.Location = New System.Drawing.Point(171, 428)
        Me.txtIC.Name = "txtIC"
        Me.txtIC.ReadOnly = True
        Me.txtIC.Size = New System.Drawing.Size(308, 38)
        Me.txtIC.TabIndex = 28
        '
        'txtStudentEmail
        '
        Me.txtStudentEmail.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtStudentEmail.Font = New System.Drawing.Font("Fira Code", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentEmail.Location = New System.Drawing.Point(171, 320)
        Me.txtStudentEmail.Name = "txtStudentEmail"
        Me.txtStudentEmail.ReadOnly = True
        Me.txtStudentEmail.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtStudentEmail.Size = New System.Drawing.Size(308, 38)
        Me.txtStudentEmail.TabIndex = 27
        Me.txtStudentEmail.Text = "@ucsicollege.edu.my"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Fira Code", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.White
        Me.Label28.Location = New System.Drawing.Point(648, 720)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(144, 28)
        Me.Label28.TabIndex = 26
        Me.Label28.Text = "Files/Images"
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtEmail.Font = New System.Drawing.Font("Fira Code", 13.8!)
        Me.txtEmail.Location = New System.Drawing.Point(653, 100)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(308, 38)
        Me.txtEmail.TabIndex = 24
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Fira Code", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.White
        Me.Label27.Location = New System.Drawing.Point(648, 70)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(155, 28)
        Me.Label27.TabIndex = 23
        Me.Label27.Text = "Email Address"
        '
        'txtContact
        '
        Me.txtContact.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtContact.Font = New System.Drawing.Font("Fira Code", 13.8!)
        Me.txtContact.Location = New System.Drawing.Point(171, 978)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.ReadOnly = True
        Me.txtContact.Size = New System.Drawing.Size(308, 38)
        Me.txtContact.TabIndex = 22
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Fira Code", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.White
        Me.Label26.Location = New System.Drawing.Point(166, 947)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(144, 28)
        Me.Label26.TabIndex = 21
        Me.Label26.Text = "Phone Number"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Fira Code", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(648, 502)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(56, 28)
        Me.Label25.TabIndex = 18
        Me.Label25.Text = "City"
        '
        'txtPostcode
        '
        Me.txtPostcode.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtPostcode.Font = New System.Drawing.Font("Fira Code", 13.8!)
        Me.txtPostcode.Location = New System.Drawing.Point(653, 642)
        Me.txtPostcode.Name = "txtPostcode"
        Me.txtPostcode.ReadOnly = True
        Me.txtPostcode.Size = New System.Drawing.Size(126, 38)
        Me.txtPostcode.TabIndex = 17
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Fira Code", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.White
        Me.Label24.Location = New System.Drawing.Point(648, 611)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(100, 28)
        Me.Label24.TabIndex = 16
        Me.Label24.Text = "Postcode"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Fira Code", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(648, 397)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(67, 28)
        Me.Label23.TabIndex = 14
        Me.Label23.Text = "State"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Fira Code", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(648, 289)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(144, 28)
        Me.Label22.TabIndex = 13
        Me.Label22.Text = "Home Address"
        '
        'txtAddress
        '
        Me.txtAddress.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtAddress.Font = New System.Drawing.Font("Fira Code", 13.8!)
        Me.txtAddress.Location = New System.Drawing.Point(653, 320)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ReadOnly = True
        Me.txtAddress.Size = New System.Drawing.Size(308, 38)
        Me.txtAddress.TabIndex = 12
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Fira Code", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(166, 397)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(111, 28)
        Me.Label21.TabIndex = 11
        Me.Label21.Text = "IC Number"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Fira Code", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(169, 288)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(155, 28)
        Me.Label20.TabIndex = 8
        Me.Label20.Text = "Student Email"
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtName.Font = New System.Drawing.Font("Fira Code", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(171, 100)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(308, 38)
        Me.txtName.TabIndex = 7
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Fira Code", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(169, 69)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(56, 28)
        Me.Label19.TabIndex = 6
        Me.Label19.Text = "Name"
        '
        'btnAdmReject
        '
        Me.btnAdmReject.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnAdmReject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdmReject.Font = New System.Drawing.Font("Fira Code", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdmReject.ForeColor = System.Drawing.Color.White
        Me.btnAdmReject.Location = New System.Drawing.Point(731, 2155)
        Me.btnAdmReject.Name = "btnAdmReject"
        Me.btnAdmReject.Size = New System.Drawing.Size(259, 47)
        Me.btnAdmReject.TabIndex = 5
        Me.btnAdmReject.Text = "Reject"
        Me.btnAdmReject.UseVisualStyleBackColor = False
        '
        'btnAdmAdd
        '
        Me.btnAdmAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnAdmAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdmAdd.Font = New System.Drawing.Font("Fira Code", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdmAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdmAdd.Location = New System.Drawing.Point(333, 2155)
        Me.btnAdmAdd.Name = "btnAdmAdd"
        Me.btnAdmAdd.Size = New System.Drawing.Size(259, 47)
        Me.btnAdmAdd.TabIndex = 0
        Me.btnAdmAdd.Text = "Add"
        Me.btnAdmAdd.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(51, 2208)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1096, 23)
        Me.Panel1.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Fira Code", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(120, 865)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(380, 47)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Account Registration"
        '
        'dgvAdm
        '
        Me.dgvAdm.AllowUserToAddRows = False
        Me.dgvAdm.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvAdm.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvAdm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgvAdm.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvAdm.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.dgvAdm.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvAdm.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvAdm.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Fira Code", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(40, 30, 40, 10)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAdm.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvAdm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAdm.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.applicantNo, Me.applicantName, Me.ic, Me.passport, Me.country, Me.contact, Me.gender, Me.dateOfBirth, Me.emailAddress, Me.homeAddress, Me.state, Me.city, Me.postcode, Me.programme, Me.result})
        Me.dgvAdm.EnableHeadersVisualStyles = False
        Me.dgvAdm.GridColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.dgvAdm.Location = New System.Drawing.Point(91, 211)
        Me.dgvAdm.MultiSelect = False
        Me.dgvAdm.Name = "dgvAdm"
        Me.dgvAdm.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAdm.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvAdm.RowHeadersVisible = False
        Me.dgvAdm.RowHeadersWidth = 51
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        Me.dgvAdm.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvAdm.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.dgvAdm.RowTemplate.Height = 24
        Me.dgvAdm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAdm.Size = New System.Drawing.Size(1080, 588)
        Me.dgvAdm.TabIndex = 13
        '
        'applicantNo
        '
        Me.applicantNo.HeaderText = "Application No"
        Me.applicantNo.MinimumWidth = 6
        Me.applicantNo.Name = "applicantNo"
        Me.applicantNo.ReadOnly = True
        Me.applicantNo.Width = 243
        '
        'applicantName
        '
        Me.applicantName.HeaderText = "Applicant Name"
        Me.applicantName.MinimumWidth = 6
        Me.applicantName.Name = "applicantName"
        Me.applicantName.ReadOnly = True
        Me.applicantName.Width = 243
        '
        'ic
        '
        Me.ic.HeaderText = "IC Number"
        Me.ic.MinimumWidth = 6
        Me.ic.Name = "ic"
        Me.ic.ReadOnly = True
        Me.ic.Width = 198
        '
        'passport
        '
        Me.passport.HeaderText = "Passport Number"
        Me.passport.MinimumWidth = 6
        Me.passport.Name = "passport"
        Me.passport.ReadOnly = True
        Me.passport.Width = 252
        '
        'country
        '
        Me.country.HeaderText = "Country"
        Me.country.MinimumWidth = 6
        Me.country.Name = "country"
        Me.country.ReadOnly = True
        Me.country.Width = 189
        '
        'contact
        '
        Me.contact.HeaderText = "Contact No"
        Me.contact.MinimumWidth = 6
        Me.contact.Name = "contact"
        Me.contact.ReadOnly = True
        Me.contact.Width = 189
        '
        'gender
        '
        Me.gender.HeaderText = "Gender"
        Me.gender.MinimumWidth = 6
        Me.gender.Name = "gender"
        Me.gender.ReadOnly = True
        Me.gender.Width = 179
        '
        'dateOfBirth
        '
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.dateOfBirth.DefaultCellStyle = DataGridViewCellStyle3
        Me.dateOfBirth.HeaderText = "Date Of Birth"
        Me.dateOfBirth.MinimumWidth = 6
        Me.dateOfBirth.Name = "dateOfBirth"
        Me.dateOfBirth.ReadOnly = True
        Me.dateOfBirth.Width = 189
        '
        'emailAddress
        '
        Me.emailAddress.HeaderText = "Email Address"
        Me.emailAddress.MinimumWidth = 6
        Me.emailAddress.Name = "emailAddress"
        Me.emailAddress.ReadOnly = True
        Me.emailAddress.Width = 234
        '
        'homeAddress
        '
        Me.homeAddress.HeaderText = "Home Address"
        Me.homeAddress.MinimumWidth = 6
        Me.homeAddress.Name = "homeAddress"
        Me.homeAddress.ReadOnly = True
        Me.homeAddress.Width = 225
        '
        'state
        '
        Me.state.HeaderText = "State"
        Me.state.MinimumWidth = 6
        Me.state.Name = "state"
        Me.state.ReadOnly = True
        Me.state.Width = 169
        '
        'city
        '
        Me.city.HeaderText = "City"
        Me.city.MinimumWidth = 6
        Me.city.Name = "city"
        Me.city.ReadOnly = True
        Me.city.Width = 159
        '
        'postcode
        '
        Me.postcode.HeaderText = "Postcode"
        Me.postcode.MinimumWidth = 6
        Me.postcode.Name = "postcode"
        Me.postcode.ReadOnly = True
        Me.postcode.Width = 199
        '
        'programme
        '
        Me.programme.HeaderText = "Programme Name"
        Me.programme.MinimumWidth = 6
        Me.programme.Name = "programme"
        Me.programme.ReadOnly = True
        Me.programme.Width = 243
        '
        'result
        '
        Me.result.HeaderText = "Result"
        Me.result.MinimumWidth = 6
        Me.result.Name = "result"
        Me.result.ReadOnly = True
        Me.result.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.result.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.result.Width = 179
        '
        'errorID
        '
        Me.errorID.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.errorID.ContainerControl = Me
        Me.errorID.Icon = CType(resources.GetObject("errorID.Icon"), System.Drawing.Icon)
        '
        'AdminStudAdmForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1185, 774)
        Me.Controls.Add(Me.dgvAdm)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panelEditAdm)
        Me.Controls.Add(Me.cbxAdm)
        Me.Controls.Add(Me.Label69)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAdmAdd)
        Me.Controls.Add(Me.btnAdmReject)
        Me.Name = "AdminStudAdmForm"
        Me.Text = "AdminStudAdmForm"
        Me.panelEditAdm.ResumeLayout(False)
        Me.panelEditAdm.PerformLayout()
        CType(Me.pic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvAdm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbxAdm As ComboBox
    Friend WithEvents Label69 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents panelEditAdm As Panel
    Friend WithEvents Label28 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents txtContact As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents txtPostcode As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents btnAdmReject As Button
    Friend WithEvents btnAdmAdd As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents txtIC As TextBox
    Friend WithEvents txtStudentEmail As TextBox
    Friend WithEvents dgvAdm As DataGridView
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtState As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtProgramme As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPassport As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtGender As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDOB As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents errorID As ErrorProvider
    Friend WithEvents txtCountry As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents pic As PictureBox
    Friend WithEvents btnZoom As Button
    Friend WithEvents applicantNo As DataGridViewTextBoxColumn
    Friend WithEvents applicantName As DataGridViewTextBoxColumn
    Friend WithEvents ic As DataGridViewTextBoxColumn
    Friend WithEvents passport As DataGridViewTextBoxColumn
    Friend WithEvents country As DataGridViewTextBoxColumn
    Friend WithEvents contact As DataGridViewTextBoxColumn
    Friend WithEvents gender As DataGridViewTextBoxColumn
    Friend WithEvents dateOfBirth As DataGridViewTextBoxColumn
    Friend WithEvents emailAddress As DataGridViewTextBoxColumn
    Friend WithEvents homeAddress As DataGridViewTextBoxColumn
    Friend WithEvents state As DataGridViewTextBoxColumn
    Friend WithEvents city As DataGridViewTextBoxColumn
    Friend WithEvents postcode As DataGridViewTextBoxColumn
    Friend WithEvents programme As DataGridViewTextBoxColumn
    Friend WithEvents result As DataGridViewImageColumn
End Class
