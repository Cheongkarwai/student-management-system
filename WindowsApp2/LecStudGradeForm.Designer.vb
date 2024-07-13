<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LecStudGradeForm
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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblGrade = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvGrade = New System.Windows.Forms.DataGridView()
        Me.lblGPA = New System.Windows.Forms.Label()
        Me.lblSemester = New System.Windows.Forms.Label()
        Me.lblCourseName = New System.Windows.Forms.Label()
        Me.lblCourseID = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtMarks = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbxCourse = New System.Windows.Forms.ComboBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.cbxView = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvGrade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Fira Code", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.White
        Me.Label35.Location = New System.Drawing.Point(80, 119)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(254, 47)
        Me.Label35.TabIndex = 50
        Me.Label35.Text = "Student Grade"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblGrade)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.dgvGrade)
        Me.Panel1.Controls.Add(Me.lblGPA)
        Me.Panel1.Controls.Add(Me.lblSemester)
        Me.Panel1.Controls.Add(Me.lblCourseName)
        Me.Panel1.Controls.Add(Me.lblCourseID)
        Me.Panel1.Controls.Add(Me.lblID)
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.txtMarks)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.lblName)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.cbxCourse)
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Controls.Add(Me.btnSubmit)
        Me.Panel1.Controls.Add(Me.Label30)
        Me.Panel1.Location = New System.Drawing.Point(57, 196)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1140, 887)
        Me.Panel1.TabIndex = 51
        '
        'lblGrade
        '
        Me.lblGrade.Font = New System.Drawing.Font("Fira Code", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrade.ForeColor = System.Drawing.Color.White
        Me.lblGrade.Location = New System.Drawing.Point(270, 723)
        Me.lblGrade.Name = "lblGrade"
        Me.lblGrade.Size = New System.Drawing.Size(361, 28)
        Me.lblGrade.TabIndex = 83
        Me.lblGrade.Text = "-"
        Me.lblGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Fira Code", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(42, 789)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 28)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "GPA"
        '
        'dgvGrade
        '
        Me.dgvGrade.AllowUserToAddRows = False
        Me.dgvGrade.AllowUserToDeleteRows = False
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.White
        Me.dgvGrade.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        Me.dgvGrade.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgvGrade.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvGrade.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.dgvGrade.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvGrade.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvGrade.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Fira Code", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle14.Padding = New System.Windows.Forms.Padding(40, 30, 40, 10)
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvGrade.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.dgvGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGrade.EnableHeadersVisualStyles = False
        Me.dgvGrade.GridColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.dgvGrade.Location = New System.Drawing.Point(31, 27)
        Me.dgvGrade.MultiSelect = False
        Me.dgvGrade.Name = "dgvGrade"
        Me.dgvGrade.ReadOnly = True
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvGrade.RowHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.dgvGrade.RowHeadersVisible = False
        Me.dgvGrade.RowHeadersWidth = 51
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.White
        Me.dgvGrade.RowsDefaultCellStyle = DataGridViewCellStyle16
        Me.dgvGrade.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.dgvGrade.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvGrade.RowTemplate.Height = 24
        Me.dgvGrade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvGrade.Size = New System.Drawing.Size(669, 320)
        Me.dgvGrade.TabIndex = 81
        '
        'lblGPA
        '
        Me.lblGPA.Font = New System.Drawing.Font("Fira Code", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGPA.ForeColor = System.Drawing.Color.White
        Me.lblGPA.Location = New System.Drawing.Point(270, 788)
        Me.lblGPA.Name = "lblGPA"
        Me.lblGPA.Size = New System.Drawing.Size(361, 28)
        Me.lblGPA.TabIndex = 80
        Me.lblGPA.Text = "-"
        Me.lblGPA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSemester
        '
        Me.lblSemester.Font = New System.Drawing.Font("Fira Code", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSemester.ForeColor = System.Drawing.Color.White
        Me.lblSemester.Location = New System.Drawing.Point(270, 650)
        Me.lblSemester.Name = "lblSemester"
        Me.lblSemester.Size = New System.Drawing.Size(361, 28)
        Me.lblSemester.TabIndex = 79
        Me.lblSemester.Text = "-"
        Me.lblSemester.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCourseName
        '
        Me.lblCourseName.Font = New System.Drawing.Font("Fira Code", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourseName.ForeColor = System.Drawing.Color.White
        Me.lblCourseName.Location = New System.Drawing.Point(270, 591)
        Me.lblCourseName.Name = "lblCourseName"
        Me.lblCourseName.Size = New System.Drawing.Size(361, 28)
        Me.lblCourseName.TabIndex = 78
        Me.lblCourseName.Text = "-"
        Me.lblCourseName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCourseID
        '
        Me.lblCourseID.Font = New System.Drawing.Font("Fira Code", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourseID.ForeColor = System.Drawing.Color.White
        Me.lblCourseID.Location = New System.Drawing.Point(270, 525)
        Me.lblCourseID.Name = "lblCourseID"
        Me.lblCourseID.Size = New System.Drawing.Size(361, 28)
        Me.lblCourseID.TabIndex = 77
        Me.lblCourseID.Text = "-"
        Me.lblCourseID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblID
        '
        Me.lblID.Font = New System.Drawing.Font("Fira Code", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.ForeColor = System.Drawing.Color.White
        Me.lblID.Location = New System.Drawing.Point(270, 454)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(361, 28)
        Me.lblID.TabIndex = 76
        Me.lblID.Text = "-"
        Me.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Fira Code", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(42, 525)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(111, 28)
        Me.Label22.TabIndex = 75
        Me.Label22.Text = "Course ID"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Fira Code", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(42, 723)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(67, 28)
        Me.Label21.TabIndex = 73
        Me.Label21.Text = "Grade"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Fira Code", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(965, 513)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(26, 32)
        Me.Label18.TabIndex = 70
        Me.Label18.Text = "%"
        '
        'txtMarks
        '
        Me.txtMarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarks.Location = New System.Drawing.Point(883, 512)
        Me.txtMarks.MaxLength = 10
        Me.txtMarks.Name = "txtMarks"
        Me.txtMarks.Size = New System.Drawing.Size(76, 30)
        Me.txtMarks.TabIndex = 69
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Fira Code", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(885, 465)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(74, 32)
        Me.Label15.TabIndex = 68
        Me.Label15.Text = "Marks"
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Font = New System.Drawing.Font("Fira Code", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.ForeColor = System.Drawing.Color.White
        Me.Label.Location = New System.Drawing.Point(42, 660)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(100, 28)
        Me.Label.TabIndex = 66
        Me.Label.Text = "Semester"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Fira Code", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(42, 591)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 28)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "Course Name"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Fira Code", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(42, 454)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(122, 28)
        Me.Label9.TabIndex = 62
        Me.Label9.Text = "Student ID"
        '
        'lblName
        '
        Me.lblName.Font = New System.Drawing.Font("Fira Code", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.White
        Me.lblName.Location = New System.Drawing.Point(270, 398)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(361, 28)
        Me.lblName.TabIndex = 61
        Me.lblName.Text = "-"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Fira Code", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(42, 398)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 28)
        Me.Label7.TabIndex = 60
        Me.Label7.Text = "Name"
        '
        'cbxCourse
        '
        Me.cbxCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCourse.Font = New System.Drawing.Font("Fira Mono", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxCourse.FormattingEnabled = True
        Me.cbxCourse.Location = New System.Drawing.Point(828, 78)
        Me.cbxCourse.Name = "cbxCourse"
        Me.cbxCourse.Size = New System.Drawing.Size(285, 36)
        Me.cbxCourse.TabIndex = 59
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Fira Code", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(891, 181)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(210, 41)
        Me.btnSearch.TabIndex = 57
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.Font = New System.Drawing.Font("Fira Code", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.Location = New System.Drawing.Point(828, 759)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(183, 44)
        Me.btnSubmit.TabIndex = 56
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Fira Code", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.White
        Me.Label30.Location = New System.Drawing.Point(721, 78)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(101, 37)
        Me.Label30.TabIndex = 52
        Me.Label30.Text = "Course"
        '
        'cbxView
        '
        Me.cbxView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxView.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxView.FormattingEnabled = True
        Me.cbxView.Items.AddRange(New Object() {"Edit", "Submission"})
        Me.cbxView.Location = New System.Drawing.Point(931, 142)
        Me.cbxView.Name = "cbxView"
        Me.cbxView.Size = New System.Drawing.Size(209, 30)
        Me.cbxView.TabIndex = 52
        '
        'LecStudGradeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1185, 774)
        Me.Controls.Add(Me.cbxView)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label35)
        Me.Name = "LecStudGradeForm"
        Me.Text = "LecStudGradeForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvGrade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label35 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label18 As Label
    Friend WithEvents txtMarks As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cbxCourse As ComboBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Label30 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents lblGPA As Label
    Friend WithEvents lblSemester As Label
    Friend WithEvents lblCourseName As Label
    Friend WithEvents lblCourseID As Label
    Friend WithEvents lblID As Label
    Friend WithEvents dgvGrade As DataGridView
    Friend WithEvents cbxView As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblGrade As Label
End Class
