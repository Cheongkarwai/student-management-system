<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminCourseForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ComboBox12 = New System.Windows.Forms.ComboBox()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblViewOutstanding = New System.Windows.Forms.Label()
        Me.panelViewPending = New System.Windows.Forms.Panel()
        Me.panelViewEnrolled = New System.Windows.Forms.Panel()
        Me.dgvEnrolledCourse = New System.Windows.Forms.DataGridView()
        Me.cbxIDEnrolled = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtFeesEnrolled = New System.Windows.Forms.Label()
        Me.txtNameEnrolled = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbxProgrammeEnrolled = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSemesterPending = New System.Windows.Forms.Label()
        Me.Label97 = New System.Windows.Forms.Label()
        Me.txtNamePending = New System.Windows.Forms.Label()
        Me.txtCourseIDPending = New System.Windows.Forms.Label()
        Me.txtFeesPending = New System.Windows.Forms.Label()
        Me.lblFees = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbxIDPending = New System.Windows.Forms.ComboBox()
        Me.lblCourse = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbxCoursePending = New System.Windows.Forms.ComboBox()
        Me.cbxProgrammePending = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnReject = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.panelSpace = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbxSort = New System.Windows.Forms.ComboBox()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.dgvCourse = New System.Windows.Forms.DataGridView()
        Me.cbxView = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GenSearchPanel = New System.Windows.Forms.Panel()
        Me.cbxGenID = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbxGenProgramme = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.panelViewPending.SuspendLayout()
        Me.panelViewEnrolled.SuspendLayout()
        CType(Me.dgvEnrolledCourse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCourse, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GenSearchPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComboBox12
        '
        Me.ComboBox12.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox12.Font = New System.Drawing.Font("Fira Code", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox12.FormattingEnabled = True
        Me.ComboBox12.Items.AddRange(New Object() {"ID", "Name ", "Programme ", "Course Name", "Course ID"})
        Me.ComboBox12.Location = New System.Drawing.Point(736, -506)
        Me.ComboBox12.Name = "ComboBox12"
        Me.ComboBox12.Size = New System.Drawing.Size(213, 40)
        Me.ComboBox12.TabIndex = 43
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Font = New System.Drawing.Font("Monoid", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label68.ForeColor = System.Drawing.Color.White
        Me.Label68.Location = New System.Drawing.Point(514, -499)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(197, 22)
        Me.Label68.TabIndex = 42
        Me.Label68.Text = "Sort By Order A-Z"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Fira Code", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(-194, -513)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(308, 47)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Course Selection"
        '
        'lblViewOutstanding
        '
        Me.lblViewOutstanding.AutoSize = True
        Me.lblViewOutstanding.Font = New System.Drawing.Font("Fira Code", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblViewOutstanding.ForeColor = System.Drawing.Color.White
        Me.lblViewOutstanding.Location = New System.Drawing.Point(120, 865)
        Me.lblViewOutstanding.Name = "lblViewOutstanding"
        Me.lblViewOutstanding.Size = New System.Drawing.Size(506, 47)
        Me.lblViewOutstanding.TabIndex = 40
        Me.lblViewOutstanding.Text = "Course Selection/Fees Panel"
        '
        'panelViewPending
        '
        Me.panelViewPending.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.panelViewPending.Controls.Add(Me.panelViewEnrolled)
        Me.panelViewPending.Controls.Add(Me.txtSemesterPending)
        Me.panelViewPending.Controls.Add(Me.Label97)
        Me.panelViewPending.Controls.Add(Me.txtNamePending)
        Me.panelViewPending.Controls.Add(Me.txtCourseIDPending)
        Me.panelViewPending.Controls.Add(Me.txtFeesPending)
        Me.panelViewPending.Controls.Add(Me.lblFees)
        Me.panelViewPending.Controls.Add(Me.Label12)
        Me.panelViewPending.Controls.Add(Me.cbxIDPending)
        Me.panelViewPending.Controls.Add(Me.lblCourse)
        Me.panelViewPending.Controls.Add(Me.Label10)
        Me.panelViewPending.Controls.Add(Me.Label9)
        Me.panelViewPending.Controls.Add(Me.cbxCoursePending)
        Me.panelViewPending.Controls.Add(Me.cbxProgrammePending)
        Me.panelViewPending.Controls.Add(Me.Label8)
        Me.panelViewPending.Location = New System.Drawing.Point(91, 936)
        Me.panelViewPending.Name = "panelViewPending"
        Me.panelViewPending.Size = New System.Drawing.Size(1080, 723)
        Me.panelViewPending.TabIndex = 41
        '
        'panelViewEnrolled
        '
        Me.panelViewEnrolled.Controls.Add(Me.dgvEnrolledCourse)
        Me.panelViewEnrolled.Controls.Add(Me.cbxIDEnrolled)
        Me.panelViewEnrolled.Controls.Add(Me.Label16)
        Me.panelViewEnrolled.Controls.Add(Me.txtFeesEnrolled)
        Me.panelViewEnrolled.Controls.Add(Me.txtNameEnrolled)
        Me.panelViewEnrolled.Controls.Add(Me.Label13)
        Me.panelViewEnrolled.Controls.Add(Me.Label6)
        Me.panelViewEnrolled.Controls.Add(Me.cbxProgrammeEnrolled)
        Me.panelViewEnrolled.Controls.Add(Me.Label4)
        Me.panelViewEnrolled.Location = New System.Drawing.Point(0, 0)
        Me.panelViewEnrolled.Name = "panelViewEnrolled"
        Me.panelViewEnrolled.Size = New System.Drawing.Size(1080, 723)
        Me.panelViewEnrolled.TabIndex = 22
        '
        'dgvEnrolledCourse
        '
        Me.dgvEnrolledCourse.AllowUserToAddRows = False
        Me.dgvEnrolledCourse.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvEnrolledCourse.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvEnrolledCourse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgvEnrolledCourse.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvEnrolledCourse.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.dgvEnrolledCourse.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvEnrolledCourse.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvEnrolledCourse.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(73, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Fira Code", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(40, 30, 40, 10)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(73, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEnrolledCourse.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvEnrolledCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEnrolledCourse.EnableHeadersVisualStyles = False
        Me.dgvEnrolledCourse.GridColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.dgvEnrolledCourse.Location = New System.Drawing.Point(565, 123)
        Me.dgvEnrolledCourse.MultiSelect = False
        Me.dgvEnrolledCourse.Name = "dgvEnrolledCourse"
        Me.dgvEnrolledCourse.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEnrolledCourse.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvEnrolledCourse.RowHeadersVisible = False
        Me.dgvEnrolledCourse.RowHeadersWidth = 51
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(73, Byte), Integer))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        Me.dgvEnrolledCourse.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvEnrolledCourse.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.dgvEnrolledCourse.RowTemplate.Height = 24
        Me.dgvEnrolledCourse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEnrolledCourse.Size = New System.Drawing.Size(460, 322)
        Me.dgvEnrolledCourse.TabIndex = 50
        '
        'cbxIDEnrolled
        '
        Me.cbxIDEnrolled.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxIDEnrolled.Font = New System.Drawing.Font("Fira Code", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxIDEnrolled.FormattingEnabled = True
        Me.cbxIDEnrolled.Location = New System.Drawing.Point(132, 276)
        Me.cbxIDEnrolled.Name = "cbxIDEnrolled"
        Me.cbxIDEnrolled.Size = New System.Drawing.Size(322, 40)
        Me.cbxIDEnrolled.TabIndex = 26
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Fira Code", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(126, 241)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(134, 32)
        Me.Label16.TabIndex = 25
        Me.Label16.Text = "Student ID"
        '
        'txtFeesEnrolled
        '
        Me.txtFeesEnrolled.Font = New System.Drawing.Font("Monoid", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFeesEnrolled.ForeColor = System.Drawing.Color.White
        Me.txtFeesEnrolled.Location = New System.Drawing.Point(302, 620)
        Me.txtFeesEnrolled.Name = "txtFeesEnrolled"
        Me.txtFeesEnrolled.Size = New System.Drawing.Size(478, 54)
        Me.txtFeesEnrolled.TabIndex = 24
        Me.txtFeesEnrolled.Text = "0.00"
        Me.txtFeesEnrolled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNameEnrolled
        '
        Me.txtNameEnrolled.Font = New System.Drawing.Font("Monoid", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNameEnrolled.ForeColor = System.Drawing.Color.White
        Me.txtNameEnrolled.Location = New System.Drawing.Point(125, 431)
        Me.txtNameEnrolled.Name = "txtNameEnrolled"
        Me.txtNameEnrolled.Size = New System.Drawing.Size(337, 37)
        Me.txtNameEnrolled.TabIndex = 24
        Me.txtNameEnrolled.Text = "-"
        Me.txtNameEnrolled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Fira Code", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(292, 544)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(506, 47)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Total Outstanding Fees (RM)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Fira Code", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(125, 366)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(185, 37)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Student Name"
        '
        'cbxProgrammeEnrolled
        '
        Me.cbxProgrammeEnrolled.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxProgrammeEnrolled.Font = New System.Drawing.Font("Fira Code", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxProgrammeEnrolled.FormattingEnabled = True
        Me.cbxProgrammeEnrolled.Location = New System.Drawing.Point(132, 141)
        Me.cbxProgrammeEnrolled.Name = "cbxProgrammeEnrolled"
        Me.cbxProgrammeEnrolled.Size = New System.Drawing.Size(322, 40)
        Me.cbxProgrammeEnrolled.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Fira Code", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(126, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 32)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Programmes"
        '
        'txtSemesterPending
        '
        Me.txtSemesterPending.AutoSize = True
        Me.txtSemesterPending.Font = New System.Drawing.Font("Monoid", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSemesterPending.ForeColor = System.Drawing.Color.White
        Me.txtSemesterPending.Location = New System.Drawing.Point(921, 308)
        Me.txtSemesterPending.Name = "txtSemesterPending"
        Me.txtSemesterPending.Size = New System.Drawing.Size(36, 37)
        Me.txtSemesterPending.TabIndex = 21
        Me.txtSemesterPending.Text = "-"
        '
        'Label97
        '
        Me.Label97.AutoSize = True
        Me.Label97.Font = New System.Drawing.Font("Fira Code", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label97.ForeColor = System.Drawing.Color.White
        Me.Label97.Location = New System.Drawing.Point(871, 251)
        Me.Label97.Name = "Label97"
        Me.Label97.Size = New System.Drawing.Size(129, 37)
        Me.Label97.TabIndex = 20
        Me.Label97.Text = "Semester"
        '
        'txtNamePending
        '
        Me.txtNamePending.Font = New System.Drawing.Font("Monoid", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamePending.ForeColor = System.Drawing.Color.White
        Me.txtNamePending.Location = New System.Drawing.Point(471, 308)
        Me.txtNamePending.Name = "txtNamePending"
        Me.txtNamePending.Size = New System.Drawing.Size(337, 37)
        Me.txtNamePending.TabIndex = 18
        Me.txtNamePending.Text = "-"
        Me.txtNamePending.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCourseIDPending
        '
        Me.txtCourseIDPending.Font = New System.Drawing.Font("Monoid", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCourseIDPending.ForeColor = System.Drawing.Color.White
        Me.txtCourseIDPending.Location = New System.Drawing.Point(513, 439)
        Me.txtCourseIDPending.Name = "txtCourseIDPending"
        Me.txtCourseIDPending.Size = New System.Drawing.Size(260, 37)
        Me.txtCourseIDPending.TabIndex = 17
        Me.txtCourseIDPending.Text = "-"
        Me.txtCourseIDPending.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtFeesPending
        '
        Me.txtFeesPending.Font = New System.Drawing.Font("Monoid", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFeesPending.ForeColor = System.Drawing.Color.White
        Me.txtFeesPending.Location = New System.Drawing.Point(808, 439)
        Me.txtFeesPending.Name = "txtFeesPending"
        Me.txtFeesPending.Size = New System.Drawing.Size(247, 37)
        Me.txtFeesPending.TabIndex = 16
        Me.txtFeesPending.Text = "0"
        Me.txtFeesPending.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFees
        '
        Me.lblFees.AutoSize = True
        Me.lblFees.Font = New System.Drawing.Font("Fira Code", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFees.ForeColor = System.Drawing.Color.White
        Me.lblFees.Location = New System.Drawing.Point(857, 388)
        Me.lblFees.Name = "lblFees"
        Me.lblFees.Size = New System.Drawing.Size(143, 37)
        Me.lblFees.TabIndex = 12
        Me.lblFees.Text = "Fees (RM)"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Fira Code", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(101, 328)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(98, 32)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Courses"
        '
        'cbxIDPending
        '
        Me.cbxIDPending.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxIDPending.Font = New System.Drawing.Font("Fira Code", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxIDPending.FormattingEnabled = True
        Me.cbxIDPending.Location = New System.Drawing.Point(107, 481)
        Me.cbxIDPending.Name = "cbxIDPending"
        Me.cbxIDPending.Size = New System.Drawing.Size(322, 40)
        Me.cbxIDPending.TabIndex = 10
        '
        'lblCourse
        '
        Me.lblCourse.AutoSize = True
        Me.lblCourse.Font = New System.Drawing.Font("Fira Code", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourse.ForeColor = System.Drawing.Color.White
        Me.lblCourse.Location = New System.Drawing.Point(560, 388)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Size = New System.Drawing.Size(143, 37)
        Me.lblCourse.TabIndex = 8
        Me.lblCourse.Text = "Course ID"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Fira Code", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(560, 251)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(185, 37)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Student Name"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Fira Code", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(101, 446)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(134, 32)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Student ID"
        '
        'cbxCoursePending
        '
        Me.cbxCoursePending.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCoursePending.Font = New System.Drawing.Font("Fira Code", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxCoursePending.FormattingEnabled = True
        Me.cbxCoursePending.Location = New System.Drawing.Point(107, 363)
        Me.cbxCoursePending.Name = "cbxCoursePending"
        Me.cbxCoursePending.Size = New System.Drawing.Size(322, 40)
        Me.cbxCoursePending.TabIndex = 5
        '
        'cbxProgrammePending
        '
        Me.cbxProgrammePending.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxProgrammePending.Font = New System.Drawing.Font("Fira Code", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxProgrammePending.FormattingEnabled = True
        Me.cbxProgrammePending.Location = New System.Drawing.Point(107, 253)
        Me.cbxProgrammePending.Name = "cbxProgrammePending"
        Me.cbxProgrammePending.Size = New System.Drawing.Size(322, 40)
        Me.cbxProgrammePending.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Fira Code", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(101, 218)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(134, 32)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Programmes"
        '
        'btnReject
        '
        Me.btnReject.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnReject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReject.Font = New System.Drawing.Font("Fira Code", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReject.ForeColor = System.Drawing.Color.White
        Me.btnReject.Location = New System.Drawing.Point(913, 1717)
        Me.btnReject.Name = "btnReject"
        Me.btnReject.Size = New System.Drawing.Size(234, 47)
        Me.btnReject.TabIndex = 19
        Me.btnReject.Text = "Reject"
        Me.btnReject.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Fira Code", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.White
        Me.btnReset.Location = New System.Drawing.Point(510, 1717)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(234, 47)
        Me.btnReset.TabIndex = 10
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Fira Code", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(91, 1717)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(234, 47)
        Me.btnAdd.TabIndex = 9
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'panelSpace
        '
        Me.panelSpace.Location = New System.Drawing.Point(24, 1805)
        Me.panelSpace.Name = "panelSpace"
        Me.panelSpace.Size = New System.Drawing.Size(1141, 26)
        Me.panelSpace.TabIndex = 44
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Fira Code", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(119, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(308, 47)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Course Selection"
        '
        'cbxSort
        '
        Me.cbxSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxSort.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxSort.FormattingEnabled = True
        Me.cbxSort.Items.AddRange(New Object() {"Student ID", "Student Name", "Programme Name", "Course Name", "Course Code"})
        Me.cbxSort.Location = New System.Drawing.Point(954, 154)
        Me.cbxSort.Name = "cbxSort"
        Me.cbxSort.Size = New System.Drawing.Size(181, 34)
        Me.cbxSort.TabIndex = 46
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.Font = New System.Drawing.Font("Monoid", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label69.ForeColor = System.Drawing.Color.White
        Me.Label69.Location = New System.Drawing.Point(787, 163)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(161, 17)
        Me.Label69.TabIndex = 45
        Me.Label69.Text = "Sort By Order A-Z"
        '
        'dgvCourse
        '
        Me.dgvCourse.AllowUserToAddRows = False
        Me.dgvCourse.AllowUserToDeleteRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        Me.dgvCourse.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvCourse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgvCourse.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvCourse.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.dgvCourse.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvCourse.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvCourse.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Fira Code", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Padding = New System.Windows.Forms.Padding(40, 30, 40, 10)
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCourse.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCourse.EnableHeadersVisualStyles = False
        Me.dgvCourse.GridColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.dgvCourse.Location = New System.Drawing.Point(91, 212)
        Me.dgvCourse.MultiSelect = False
        Me.dgvCourse.Name = "dgvCourse"
        Me.dgvCourse.ReadOnly = True
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCourse.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvCourse.RowHeadersVisible = False
        Me.dgvCourse.RowHeadersWidth = 51
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        Me.dgvCourse.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvCourse.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.dgvCourse.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvCourse.RowTemplate.Height = 24
        Me.dgvCourse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCourse.Size = New System.Drawing.Size(1080, 588)
        Me.dgvCourse.TabIndex = 47
        '
        'cbxView
        '
        Me.cbxView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxView.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxView.FormattingEnabled = True
        Me.cbxView.Items.AddRange(New Object() {"General", "Pending", "Enrolled"})
        Me.cbxView.Location = New System.Drawing.Point(584, 154)
        Me.cbxView.Name = "cbxView"
        Me.cbxView.Size = New System.Drawing.Size(181, 34)
        Me.cbxView.TabIndex = 48
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monoid", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(534, 163)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 17)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "View"
        '
        'GenSearchPanel
        '
        Me.GenSearchPanel.Controls.Add(Me.cbxGenID)
        Me.GenSearchPanel.Controls.Add(Me.Label7)
        Me.GenSearchPanel.Controls.Add(Me.cbxGenProgramme)
        Me.GenSearchPanel.Controls.Add(Me.Label5)
        Me.GenSearchPanel.Location = New System.Drawing.Point(91, 806)
        Me.GenSearchPanel.Name = "GenSearchPanel"
        Me.GenSearchPanel.Size = New System.Drawing.Size(1080, 144)
        Me.GenSearchPanel.TabIndex = 50
        '
        'cbxGenID
        '
        Me.cbxGenID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxGenID.Font = New System.Drawing.Font("Fira Code", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxGenID.FormattingEnabled = True
        Me.cbxGenID.Location = New System.Drawing.Point(733, 59)
        Me.cbxGenID.Name = "cbxGenID"
        Me.cbxGenID.Size = New System.Drawing.Size(322, 40)
        Me.cbxGenID.TabIndex = 52
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Fira Code", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(594, 62)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(134, 32)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "Student ID"
        '
        'cbxGenProgramme
        '
        Me.cbxGenProgramme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxGenProgramme.Font = New System.Drawing.Font("Fira Code", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxGenProgramme.FormattingEnabled = True
        Me.cbxGenProgramme.Location = New System.Drawing.Point(181, 59)
        Me.cbxGenProgramme.Name = "cbxGenProgramme"
        Me.cbxGenProgramme.Size = New System.Drawing.Size(322, 40)
        Me.cbxGenProgramme.TabIndex = 52
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Fira Code", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(41, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 32)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Programmes"
        '
        'AdminCourseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1164, 753)
        Me.Controls.Add(Me.GenSearchPanel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbxView)
        Me.Controls.Add(Me.dgvCourse)
        Me.Controls.Add(Me.cbxSort)
        Me.Controls.Add(Me.Label69)
        Me.Controls.Add(Me.panelSpace)
        Me.Controls.Add(Me.ComboBox12)
        Me.Controls.Add(Me.btnReject)
        Me.Controls.Add(Me.Label68)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblViewOutstanding)
        Me.Controls.Add(Me.panelViewPending)
        Me.Name = "AdminCourseForm"
        Me.Text = "AdminCourseFormvb"
        Me.panelViewPending.ResumeLayout(False)
        Me.panelViewPending.PerformLayout()
        Me.panelViewEnrolled.ResumeLayout(False)
        Me.panelViewEnrolled.PerformLayout()
        CType(Me.dgvEnrolledCourse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCourse, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GenSearchPanel.ResumeLayout(False)
        Me.GenSearchPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox12 As ComboBox
    Friend WithEvents Label68 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblViewOutstanding As Label
    Friend WithEvents panelViewPending As Panel
    Friend WithEvents txtSemesterPending As Label
    Friend WithEvents Label97 As Label
    Friend WithEvents btnReject As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtNamePending As Label
    Friend WithEvents txtCourseIDPending As Label
    Friend WithEvents txtFeesPending As Label
    Friend WithEvents lblFees As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents cbxIDPending As ComboBox
    Friend WithEvents lblCourse As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cbxCoursePending As ComboBox
    Friend WithEvents cbxProgrammePending As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents panelSpace As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents cbxSort As ComboBox
    Friend WithEvents Label69 As Label
    Friend WithEvents dgvCourse As DataGridView
    Friend WithEvents cbxView As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents panelViewEnrolled As Panel
    Friend WithEvents dgvEnrolledCourse As DataGridView
    Friend WithEvents cbxIDEnrolled As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtFeesEnrolled As Label
    Friend WithEvents txtNameEnrolled As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cbxProgrammeEnrolled As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GenSearchPanel As Panel
    Friend WithEvents cbxGenID As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cbxGenProgramme As ComboBox
    Friend WithEvents Label5 As Label
End Class
