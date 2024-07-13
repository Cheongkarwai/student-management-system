<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminTimetableForm
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
        Me.Label40 = New System.Windows.Forms.Label()
        Me.panelGrading = New System.Windows.Forms.Panel()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbxTime = New System.Windows.Forms.ComboBox()
        Me.cbxDay = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCourseID = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblLecturer = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cbxCourse = New System.Windows.Forms.ComboBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.cbxLecturer = New System.Windows.Forms.ComboBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSet = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.panelGrading.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Fira Code", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.White
        Me.Label40.Location = New System.Drawing.Point(119, 140)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(254, 47)
        Me.Label40.TabIndex = 18
        Me.Label40.Text = "Set Timetable"
        '
        'panelGrading
        '
        Me.panelGrading.AutoScroll = True
        Me.panelGrading.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.panelGrading.Controls.Add(Me.lblDay)
        Me.panelGrading.Controls.Add(Me.Label6)
        Me.panelGrading.Controls.Add(Me.lblTime)
        Me.panelGrading.Controls.Add(Me.Label4)
        Me.panelGrading.Controls.Add(Me.cbxTime)
        Me.panelGrading.Controls.Add(Me.cbxDay)
        Me.panelGrading.Controls.Add(Me.Label3)
        Me.panelGrading.Controls.Add(Me.Label1)
        Me.panelGrading.Controls.Add(Me.lblCourseID)
        Me.panelGrading.Controls.Add(Me.Label2)
        Me.panelGrading.Controls.Add(Me.lblLecturer)
        Me.panelGrading.Controls.Add(Me.Label22)
        Me.panelGrading.Controls.Add(Me.cbxCourse)
        Me.panelGrading.Controls.Add(Me.Label39)
        Me.panelGrading.Controls.Add(Me.cbxLecturer)
        Me.panelGrading.Controls.Add(Me.Label38)
        Me.panelGrading.Location = New System.Drawing.Point(91, 230)
        Me.panelGrading.Name = "panelGrading"
        Me.panelGrading.Size = New System.Drawing.Size(1080, 672)
        Me.panelGrading.TabIndex = 19
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.Font = New System.Drawing.Font("Monoid", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDay.ForeColor = System.Drawing.Color.White
        Me.lblDay.Location = New System.Drawing.Point(830, 462)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(29, 31)
        Me.lblDay.TabIndex = 60
        Me.lblDay.Text = "-"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Fira Code SemiBold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(830, 371)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 32)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "Day"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Monoid", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.Location = New System.Drawing.Point(521, 462)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(29, 31)
        Me.lblTime.TabIndex = 58
        Me.lblTime.Text = "-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Fira Code SemiBold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(521, 371)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 32)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Time"
        '
        'cbxTime
        '
        Me.cbxTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTime.Font = New System.Drawing.Font("Fira Code", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxTime.FormattingEnabled = True
        Me.cbxTime.Items.AddRange(New Object() {"09:30 to 11:00", "11:00 to 12:30", "12:30 to 14:00", "14:00 to 15:30", "15:30 to 17:00"})
        Me.cbxTime.Location = New System.Drawing.Point(89, 536)
        Me.cbxTime.Name = "cbxTime"
        Me.cbxTime.Size = New System.Drawing.Size(322, 34)
        Me.cbxTime.TabIndex = 56
        '
        'cbxDay
        '
        Me.cbxDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxDay.Font = New System.Drawing.Font("Fira Code", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxDay.FormattingEnabled = True
        Me.cbxDay.Items.AddRange(New Object() {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday"})
        Me.cbxDay.Location = New System.Drawing.Point(89, 410)
        Me.cbxDay.Name = "cbxDay"
        Me.cbxDay.Size = New System.Drawing.Size(322, 34)
        Me.cbxDay.TabIndex = 55
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Fira Code SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(84, 357)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 32)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Day"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Fira Code SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(86, 489)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 32)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Time"
        '
        'lblCourseID
        '
        Me.lblCourseID.AutoSize = True
        Me.lblCourseID.Font = New System.Drawing.Font("Monoid", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourseID.ForeColor = System.Drawing.Color.White
        Me.lblCourseID.Location = New System.Drawing.Point(830, 258)
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
        Me.Label2.Location = New System.Drawing.Point(830, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 32)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Course ID"
        '
        'lblLecturer
        '
        Me.lblLecturer.AutoSize = True
        Me.lblLecturer.Font = New System.Drawing.Font("Monoid", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLecturer.ForeColor = System.Drawing.Color.White
        Me.lblLecturer.Location = New System.Drawing.Point(521, 258)
        Me.lblLecturer.Name = "lblLecturer"
        Me.lblLecturer.Size = New System.Drawing.Size(29, 31)
        Me.lblLecturer.TabIndex = 49
        Me.lblLecturer.Text = "-"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Fira Code SemiBold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(521, 166)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(110, 32)
        Me.Label22.TabIndex = 48
        Me.Label22.Text = "Lecturer"
        '
        'cbxCourse
        '
        Me.cbxCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCourse.Font = New System.Drawing.Font("Fira Code", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxCourse.FormattingEnabled = True
        Me.cbxCourse.Location = New System.Drawing.Point(89, 288)
        Me.cbxCourse.Name = "cbxCourse"
        Me.cbxCourse.Size = New System.Drawing.Size(322, 34)
        Me.cbxCourse.TabIndex = 27
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Fira Code SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.White
        Me.Label39.Location = New System.Drawing.Point(84, 235)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(98, 32)
        Me.Label39.TabIndex = 26
        Me.Label39.Text = "Courses"
        '
        'cbxLecturer
        '
        Me.cbxLecturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxLecturer.Font = New System.Drawing.Font("Fira Code", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxLecturer.FormattingEnabled = True
        Me.cbxLecturer.Location = New System.Drawing.Point(89, 164)
        Me.cbxLecturer.Name = "cbxLecturer"
        Me.cbxLecturer.Size = New System.Drawing.Size(322, 34)
        Me.cbxLecturer.TabIndex = 25
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Fira Code SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.White
        Me.Label38.Location = New System.Drawing.Point(84, 109)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(110, 32)
        Me.Label38.TabIndex = 20
        Me.Label38.Text = "Lecturer"
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(91, 1023)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 32)
        Me.Panel1.TabIndex = 20
        '
        'btnSet
        '
        Me.btnSet.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSet.Font = New System.Drawing.Font("Fira Code", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSet.ForeColor = System.Drawing.Color.White
        Me.btnSet.Location = New System.Drawing.Point(796, 958)
        Me.btnSet.Name = "btnSet"
        Me.btnSet.Size = New System.Drawing.Size(221, 47)
        Me.btnSet.TabIndex = 36
        Me.btnSet.Text = "Set"
        Me.btnSet.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Fira Code", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(232, 958)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(221, 47)
        Me.btnClear.TabIndex = 37
        Me.btnClear.Text = "Reset"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'AdminTimetableForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1185, 774)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSet)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panelGrading)
        Me.Controls.Add(Me.Label40)
        Me.Name = "AdminTimetableForm"
        Me.Text = "AdminTimetableForm"
        Me.panelGrading.ResumeLayout(False)
        Me.panelGrading.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label40 As Label
    Friend WithEvents panelGrading As Panel
    Friend WithEvents lblCourseID As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblLecturer As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents cbxCourse As ComboBox
    Friend WithEvents Label39 As Label
    Friend WithEvents cbxLecturer As ComboBox
    Friend WithEvents Label38 As Label
    Friend WithEvents lblDay As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbxTime As ComboBox
    Friend WithEvents cbxDay As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSet As Button
    Friend WithEvents btnClear As Button
End Class
