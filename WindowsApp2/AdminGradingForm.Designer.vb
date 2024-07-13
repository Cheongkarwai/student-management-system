<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminGradingForm
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
        Me.Label40 = New System.Windows.Forms.Label()
        Me.panelGrading = New System.Windows.Forms.Panel()
        Me.lblGPA = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblGrade = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblCourseID = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvGrade = New System.Windows.Forms.DataGridView()
        Me.lblSemester = New System.Windows.Forms.Label()
        Me.Label100 = New System.Windows.Forms.Label()
        Me.cbxCourse = New System.Windows.Forms.ComboBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.cbxProgramme = New System.Windows.Forms.ComboBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.btnReject = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnApprove = New System.Windows.Forms.Button()
        Me.panelGrading.SuspendLayout()
        CType(Me.dgvGrade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Fira Code", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.White
        Me.Label40.Location = New System.Drawing.Point(119, 140)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(272, 47)
        Me.Label40.TabIndex = 17
        Me.Label40.Text = "Grading System"
        '
        'panelGrading
        '
        Me.panelGrading.AutoScroll = True
        Me.panelGrading.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.panelGrading.Controls.Add(Me.lblGPA)
        Me.panelGrading.Controls.Add(Me.Label5)
        Me.panelGrading.Controls.Add(Me.lblGrade)
        Me.panelGrading.Controls.Add(Me.Label3)
        Me.panelGrading.Controls.Add(Me.lblCourseID)
        Me.panelGrading.Controls.Add(Me.Label2)
        Me.panelGrading.Controls.Add(Me.lblID)
        Me.panelGrading.Controls.Add(Me.Label1)
        Me.panelGrading.Controls.Add(Me.dgvGrade)
        Me.panelGrading.Controls.Add(Me.lblSemester)
        Me.panelGrading.Controls.Add(Me.Label100)
        Me.panelGrading.Controls.Add(Me.cbxCourse)
        Me.panelGrading.Controls.Add(Me.Label39)
        Me.panelGrading.Controls.Add(Me.cbxProgramme)
        Me.panelGrading.Controls.Add(Me.Label38)
        Me.panelGrading.Location = New System.Drawing.Point(91, 214)
        Me.panelGrading.Name = "panelGrading"
        Me.panelGrading.Size = New System.Drawing.Size(1080, 758)
        Me.panelGrading.TabIndex = 16
        '
        'lblGPA
        '
        Me.lblGPA.Font = New System.Drawing.Font("Monoid", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGPA.ForeColor = System.Drawing.Color.White
        Me.lblGPA.Location = New System.Drawing.Point(813, 535)
        Me.lblGPA.Name = "lblGPA"
        Me.lblGPA.Size = New System.Drawing.Size(29, 31)
        Me.lblGPA.TabIndex = 55
        Me.lblGPA.Text = "-"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Fira Mono", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(794, 488)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 31)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "GPA"
        '
        'lblGrade
        '
        Me.lblGrade.AutoSize = True
        Me.lblGrade.Font = New System.Drawing.Font("Monoid", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrade.ForeColor = System.Drawing.Color.White
        Me.lblGrade.Location = New System.Drawing.Point(454, 623)
        Me.lblGrade.Name = "lblGrade"
        Me.lblGrade.Size = New System.Drawing.Size(29, 31)
        Me.lblGrade.TabIndex = 53
        Me.lblGrade.Text = "-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Fira Code SemiBold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(454, 565)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 32)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Grade"
        '
        'lblCourseID
        '
        Me.lblCourseID.AutoSize = True
        Me.lblCourseID.Font = New System.Drawing.Font("Monoid", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourseID.ForeColor = System.Drawing.Color.White
        Me.lblCourseID.Location = New System.Drawing.Point(454, 488)
        Me.lblCourseID.Name = "lblCourseID"
        Me.lblCourseID.Size = New System.Drawing.Size(29, 31)
        Me.lblCourseID.TabIndex = 51
        Me.lblCourseID.Text = "-"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Fira Code SemiBold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(454, 440)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 32)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Course ID"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Monoid", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.ForeColor = System.Drawing.Color.White
        Me.lblID.Location = New System.Drawing.Point(84, 488)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(29, 31)
        Me.lblID.TabIndex = 49
        Me.lblID.Text = "-"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Fira Code SemiBold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(84, 440)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 32)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Name"
        '
        'dgvGrade
        '
        Me.dgvGrade.AllowUserToAddRows = False
        Me.dgvGrade.AllowUserToDeleteRows = False
        Me.dgvGrade.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgvGrade.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.dgvGrade.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.dgvGrade.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvGrade.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvGrade.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(73, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(70, 20, 70, 4)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(73, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvGrade.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGrade.EnableHeadersVisualStyles = False
        Me.dgvGrade.Location = New System.Drawing.Point(494, 86)
        Me.dgvGrade.Name = "dgvGrade"
        Me.dgvGrade.ReadOnly = True
        Me.dgvGrade.RowHeadersVisible = False
        Me.dgvGrade.RowHeadersWidth = 51
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(73, Byte), Integer))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        Me.dgvGrade.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvGrade.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvGrade.RowTemplate.Height = 24
        Me.dgvGrade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvGrade.Size = New System.Drawing.Size(525, 305)
        Me.dgvGrade.TabIndex = 47
        '
        'lblSemester
        '
        Me.lblSemester.AutoSize = True
        Me.lblSemester.Font = New System.Drawing.Font("Monoid", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSemester.ForeColor = System.Drawing.Color.White
        Me.lblSemester.Location = New System.Drawing.Point(83, 623)
        Me.lblSemester.Name = "lblSemester"
        Me.lblSemester.Size = New System.Drawing.Size(29, 31)
        Me.lblSemester.TabIndex = 38
        Me.lblSemester.Text = "-"
        '
        'Label100
        '
        Me.Label100.AutoSize = True
        Me.Label100.Font = New System.Drawing.Font("Fira Code SemiBold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label100.ForeColor = System.Drawing.Color.White
        Me.Label100.Location = New System.Drawing.Point(83, 565)
        Me.Label100.Name = "Label100"
        Me.Label100.Size = New System.Drawing.Size(110, 32)
        Me.Label100.TabIndex = 37
        Me.Label100.Text = "Semester"
        '
        'cbxCourse
        '
        Me.cbxCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCourse.Font = New System.Drawing.Font("Fira Code", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxCourse.FormattingEnabled = True
        Me.cbxCourse.Location = New System.Drawing.Point(89, 333)
        Me.cbxCourse.Name = "cbxCourse"
        Me.cbxCourse.Size = New System.Drawing.Size(322, 34)
        Me.cbxCourse.TabIndex = 27
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Fira Code SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.White
        Me.Label39.Location = New System.Drawing.Point(83, 286)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(98, 32)
        Me.Label39.TabIndex = 26
        Me.Label39.Text = "Courses"
        '
        'cbxProgramme
        '
        Me.cbxProgramme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxProgramme.Font = New System.Drawing.Font("Fira Code", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxProgramme.FormattingEnabled = True
        Me.cbxProgramme.Location = New System.Drawing.Point(89, 164)
        Me.cbxProgramme.Name = "cbxProgramme"
        Me.cbxProgramme.Size = New System.Drawing.Size(322, 34)
        Me.cbxProgramme.TabIndex = 25
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Fira Code SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.White
        Me.Label38.Location = New System.Drawing.Point(84, 109)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(134, 32)
        Me.Label38.TabIndex = 20
        Me.Label38.Text = "Programmes"
        '
        'btnReject
        '
        Me.btnReject.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnReject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReject.Font = New System.Drawing.Font("Fira Code", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReject.ForeColor = System.Drawing.Color.White
        Me.btnReject.Location = New System.Drawing.Point(815, 21)
        Me.btnReject.Name = "btnReject"
        Me.btnReject.Size = New System.Drawing.Size(221, 47)
        Me.btnReject.TabIndex = 24
        Me.btnReject.Text = "Reject"
        Me.btnReject.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnApprove)
        Me.Panel1.Controls.Add(Me.btnReject)
        Me.Panel1.Location = New System.Drawing.Point(30, 1016)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1141, 159)
        Me.Panel1.TabIndex = 46
        '
        'btnApprove
        '
        Me.btnApprove.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnApprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApprove.Font = New System.Drawing.Font("Fira Code", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApprove.ForeColor = System.Drawing.Color.White
        Me.btnApprove.Location = New System.Drawing.Point(233, 21)
        Me.btnApprove.Name = "btnApprove"
        Me.btnApprove.Size = New System.Drawing.Size(221, 47)
        Me.btnApprove.TabIndex = 35
        Me.btnApprove.Text = "Approve"
        Me.btnApprove.UseVisualStyleBackColor = False
        '
        'AdminGradingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1185, 774)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label40)
        Me.Controls.Add(Me.panelGrading)
        Me.Name = "AdminGradingForm"
        Me.Text = "AdminGradingForm"
        Me.panelGrading.ResumeLayout(False)
        Me.panelGrading.PerformLayout()
        CType(Me.dgvGrade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label40 As Label
    Friend WithEvents panelGrading As Panel
    Friend WithEvents lblSemester As Label
    Friend WithEvents Label100 As Label
    Friend WithEvents cbxCourse As ComboBox
    Friend WithEvents Label39 As Label
    Friend WithEvents cbxProgramme As ComboBox
    Friend WithEvents btnReject As Button
    Friend WithEvents Label38 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgvGrade As DataGridView
    Friend WithEvents lblGPA As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblGrade As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblCourseID As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblID As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnApprove As Button
End Class
