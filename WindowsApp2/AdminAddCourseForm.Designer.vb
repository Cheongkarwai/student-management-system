<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminAddCourseForm
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminAddCourseForm))
        Me.label = New System.Windows.Forms.Label()
        Me.panelAddCourse = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblLec = New System.Windows.Forms.Label()
        Me.cbxLec = New System.Windows.Forms.ComboBox()
        Me.Label87 = New System.Windows.Forms.Label()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.lblCourseName = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtCourseName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblFees = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtFees = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblSemester = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtSemester = New System.Windows.Forms.TextBox()
        Me.cbxProgramme = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblCourseID = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblProgramme = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblCreditHours = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCreditHours = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.txtCourseID = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvAddCourse = New System.Windows.Forms.DataGridView()
        Me.errorCourseName = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errorCreditHours = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errorSemester = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errorFees = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errorProgramme = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.cbxMode = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.errorCourseID = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.panelAddCourse.SuspendLayout()
        CType(Me.dgvAddCourse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorCourseName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorCreditHours, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorSemester, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorFees, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorProgramme, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorCourseID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Font = New System.Drawing.Font("Fira Code", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label.ForeColor = System.Drawing.Color.White
        Me.label.Location = New System.Drawing.Point(95, 112)
        Me.label.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(255, 38)
        Me.label.TabIndex = 40
        Me.label.Text = "Course Management"
        '
        'panelAddCourse
        '
        Me.panelAddCourse.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.panelAddCourse.Controls.Add(Me.Label11)
        Me.panelAddCourse.Controls.Add(Me.lblLec)
        Me.panelAddCourse.Controls.Add(Me.cbxLec)
        Me.panelAddCourse.Controls.Add(Me.Label87)
        Me.panelAddCourse.Controls.Add(Me.btnRemove)
        Me.panelAddCourse.Controls.Add(Me.lblCourseName)
        Me.panelAddCourse.Controls.Add(Me.Label12)
        Me.panelAddCourse.Controls.Add(Me.Label13)
        Me.panelAddCourse.Controls.Add(Me.txtCourseName)
        Me.panelAddCourse.Controls.Add(Me.Label3)
        Me.panelAddCourse.Controls.Add(Me.lblFees)
        Me.panelAddCourse.Controls.Add(Me.Label8)
        Me.panelAddCourse.Controls.Add(Me.txtFees)
        Me.panelAddCourse.Controls.Add(Me.Label1)
        Me.panelAddCourse.Controls.Add(Me.lblSemester)
        Me.panelAddCourse.Controls.Add(Me.Label10)
        Me.panelAddCourse.Controls.Add(Me.txtSemester)
        Me.panelAddCourse.Controls.Add(Me.cbxProgramme)
        Me.panelAddCourse.Controls.Add(Me.Label9)
        Me.panelAddCourse.Controls.Add(Me.lblCourseID)
        Me.panelAddCourse.Controls.Add(Me.Label7)
        Me.panelAddCourse.Controls.Add(Me.lblProgramme)
        Me.panelAddCourse.Controls.Add(Me.Label5)
        Me.panelAddCourse.Controls.Add(Me.lblCreditHours)
        Me.panelAddCourse.Controls.Add(Me.btnSave)
        Me.panelAddCourse.Controls.Add(Me.btnAdd)
        Me.panelAddCourse.Controls.Add(Me.Label4)
        Me.panelAddCourse.Controls.Add(Me.txtCreditHours)
        Me.panelAddCourse.Controls.Add(Me.Label2)
        Me.panelAddCourse.Controls.Add(Me.Label48)
        Me.panelAddCourse.Controls.Add(Me.txtCourseID)
        Me.panelAddCourse.Location = New System.Drawing.Point(102, 585)
        Me.panelAddCourse.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.panelAddCourse.Name = "panelAddCourse"
        Me.panelAddCourse.Size = New System.Drawing.Size(825, 835)
        Me.panelAddCourse.TabIndex = 53
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Fira Code", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(423, 562)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 24)
        Me.Label11.TabIndex = 64
        Me.Label11.Text = "Lecturer"
        '
        'lblLec
        '
        Me.lblLec.AutoSize = True
        Me.lblLec.Font = New System.Drawing.Font("Monoid", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLec.ForeColor = System.Drawing.Color.White
        Me.lblLec.Location = New System.Drawing.Point(424, 590)
        Me.lblLec.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLec.Name = "lblLec"
        Me.lblLec.Size = New System.Drawing.Size(17, 18)
        Me.lblLec.TabIndex = 63
        Me.lblLec.Text = "-"
        '
        'cbxLec
        '
        Me.cbxLec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxLec.Font = New System.Drawing.Font("Fira Code", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxLec.FormattingEnabled = True
        Me.cbxLec.Location = New System.Drawing.Point(95, 585)
        Me.cbxLec.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbxLec.Name = "cbxLec"
        Me.cbxLec.Size = New System.Drawing.Size(244, 33)
        Me.cbxLec.TabIndex = 62
        '
        'Label87
        '
        Me.Label87.AutoSize = True
        Me.Label87.Font = New System.Drawing.Font("Fira Code", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label87.ForeColor = System.Drawing.Color.White
        Me.Label87.Location = New System.Drawing.Point(94, 562)
        Me.Label87.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label87.Name = "Label87"
        Me.Label87.Size = New System.Drawing.Size(82, 24)
        Me.Label87.TabIndex = 61
        Me.Label87.Text = "Lecturer"
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove.Font = New System.Drawing.Font("Fira Code", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.ForeColor = System.Drawing.Color.White
        Me.btnRemove.Location = New System.Drawing.Point(613, 730)
        Me.btnRemove.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(158, 38)
        Me.btnRemove.TabIndex = 59
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'lblCourseName
        '
        Me.lblCourseName.AutoSize = True
        Me.lblCourseName.Font = New System.Drawing.Font("Monoid", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourseName.ForeColor = System.Drawing.Color.White
        Me.lblCourseName.Location = New System.Drawing.Point(424, 252)
        Me.lblCourseName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCourseName.Name = "lblCourseName"
        Me.lblCourseName.Size = New System.Drawing.Size(17, 18)
        Me.lblCourseName.TabIndex = 58
        Me.lblCourseName.Text = "-"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Fira Code", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(423, 222)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(109, 24)
        Me.Label12.TabIndex = 57
        Me.Label12.Text = "Course Name"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Fira Code", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(94, 222)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(109, 24)
        Me.Label13.TabIndex = 56
        Me.Label13.Text = "Course Name"
        '
        'txtCourseName
        '
        Me.txtCourseName.Font = New System.Drawing.Font("Fira Code", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCourseName.Location = New System.Drawing.Point(95, 246)
        Me.txtCourseName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCourseName.Name = "txtCourseName"
        Me.txtCourseName.Size = New System.Drawing.Size(244, 28)
        Me.txtCourseName.TabIndex = 55
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Fira Code", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(423, 477)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 24)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Fees"
        '
        'lblFees
        '
        Me.lblFees.AutoSize = True
        Me.lblFees.Font = New System.Drawing.Font("Monoid", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFees.ForeColor = System.Drawing.Color.White
        Me.lblFees.Location = New System.Drawing.Point(424, 507)
        Me.lblFees.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFees.Name = "lblFees"
        Me.lblFees.Size = New System.Drawing.Size(17, 18)
        Me.lblFees.TabIndex = 53
        Me.lblFees.Text = "-"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Fira Code", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(94, 477)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 24)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "Fees"
        '
        'txtFees
        '
        Me.txtFees.Font = New System.Drawing.Font("Fira Code", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFees.Location = New System.Drawing.Point(95, 502)
        Me.txtFees.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtFees.Name = "txtFees"
        Me.txtFees.Size = New System.Drawing.Size(244, 28)
        Me.txtFees.TabIndex = 51
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Fira Code", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(423, 393)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 24)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Semester"
        '
        'lblSemester
        '
        Me.lblSemester.AutoSize = True
        Me.lblSemester.Font = New System.Drawing.Font("Monoid", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSemester.ForeColor = System.Drawing.Color.White
        Me.lblSemester.Location = New System.Drawing.Point(424, 423)
        Me.lblSemester.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSemester.Name = "lblSemester"
        Me.lblSemester.Size = New System.Drawing.Size(17, 18)
        Me.lblSemester.TabIndex = 49
        Me.lblSemester.Text = "-"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Fira Code", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(94, 393)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 24)
        Me.Label10.TabIndex = 48
        Me.Label10.Text = "Semester"
        '
        'txtSemester
        '
        Me.txtSemester.Font = New System.Drawing.Font("Fira Code", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSemester.Location = New System.Drawing.Point(95, 418)
        Me.txtSemester.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtSemester.MaxLength = 2
        Me.txtSemester.Name = "txtSemester"
        Me.txtSemester.Size = New System.Drawing.Size(244, 28)
        Me.txtSemester.TabIndex = 47
        '
        'cbxProgramme
        '
        Me.cbxProgramme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxProgramme.Font = New System.Drawing.Font("Fira Code", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxProgramme.FormattingEnabled = True
        Me.cbxProgramme.Location = New System.Drawing.Point(95, 77)
        Me.cbxProgramme.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbxProgramme.Name = "cbxProgramme"
        Me.cbxProgramme.Size = New System.Drawing.Size(244, 33)
        Me.cbxProgramme.TabIndex = 45
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Fira Code", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(423, 307)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(118, 24)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "Credit Hours"
        '
        'lblCourseID
        '
        Me.lblCourseID.AutoSize = True
        Me.lblCourseID.Font = New System.Drawing.Font("Monoid", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourseID.ForeColor = System.Drawing.Color.White
        Me.lblCourseID.Location = New System.Drawing.Point(424, 167)
        Me.lblCourseID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCourseID.Name = "lblCourseID"
        Me.lblCourseID.Size = New System.Drawing.Size(17, 18)
        Me.lblCourseID.TabIndex = 42
        Me.lblCourseID.Text = "-"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Fira Code", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(423, 137)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 24)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Course ID"
        '
        'lblProgramme
        '
        Me.lblProgramme.AutoSize = True
        Me.lblProgramme.Font = New System.Drawing.Font("Monoid", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProgramme.ForeColor = System.Drawing.Color.White
        Me.lblProgramme.Location = New System.Drawing.Point(424, 82)
        Me.lblProgramme.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblProgramme.Name = "lblProgramme"
        Me.lblProgramme.Size = New System.Drawing.Size(17, 18)
        Me.lblProgramme.TabIndex = 40
        Me.lblProgramme.Text = "-"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Fira Code", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(423, 49)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 24)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Programme"
        '
        'lblCreditHours
        '
        Me.lblCreditHours.AutoSize = True
        Me.lblCreditHours.Font = New System.Drawing.Font("Monoid", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreditHours.ForeColor = System.Drawing.Color.White
        Me.lblCreditHours.Location = New System.Drawing.Point(424, 338)
        Me.lblCreditHours.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCreditHours.Name = "lblCreditHours"
        Me.lblCreditHours.Size = New System.Drawing.Size(17, 18)
        Me.lblCreditHours.TabIndex = 38
        Me.lblCreditHours.Text = "-"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Fira Code", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(354, 730)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(158, 38)
        Me.btnSave.TabIndex = 36
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Fira Code", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(98, 730)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(158, 38)
        Me.btnAdd.TabIndex = 35
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Fira Code", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(94, 307)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 24)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Credit Hours"
        '
        'txtCreditHours
        '
        Me.txtCreditHours.Font = New System.Drawing.Font("Fira Code", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCreditHours.Location = New System.Drawing.Point(95, 332)
        Me.txtCreditHours.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCreditHours.MaxLength = 2
        Me.txtCreditHours.Name = "txtCreditHours"
        Me.txtCreditHours.Size = New System.Drawing.Size(244, 28)
        Me.txtCreditHours.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Fira Code", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(91, 49)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 24)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Programme"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Font = New System.Drawing.Font("Fira Code", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.Color.White
        Me.Label48.Location = New System.Drawing.Point(94, 137)
        Me.Label48.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(91, 24)
        Me.Label48.TabIndex = 21
        Me.Label48.Text = "Course ID"
        '
        'txtCourseID
        '
        Me.txtCourseID.Font = New System.Drawing.Font("Fira Code", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCourseID.Location = New System.Drawing.Point(95, 162)
        Me.txtCourseID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCourseID.MaxLength = 7
        Me.txtCourseID.Name = "txtCourseID"
        Me.txtCourseID.Size = New System.Drawing.Size(244, 28)
        Me.txtCourseID.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(10, 1478)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(917, 34)
        Me.Panel1.TabIndex = 54
        '
        'dgvAddCourse
        '
        Me.dgvAddCourse.AllowUserToAddRows = False
        Me.dgvAddCourse.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvAddCourse.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvAddCourse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgvAddCourse.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvAddCourse.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.dgvAddCourse.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvAddCourse.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvAddCourse.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Fira Code", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(40, 30, 40, 10)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAddCourse.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvAddCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAddCourse.EnableHeadersVisualStyles = False
        Me.dgvAddCourse.GridColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.dgvAddCourse.Location = New System.Drawing.Point(102, 167)
        Me.dgvAddCourse.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgvAddCourse.MultiSelect = False
        Me.dgvAddCourse.Name = "dgvAddCourse"
        Me.dgvAddCourse.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAddCourse.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvAddCourse.RowHeadersVisible = False
        Me.dgvAddCourse.RowHeadersWidth = 51
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        Me.dgvAddCourse.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvAddCourse.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.dgvAddCourse.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvAddCourse.RowTemplate.Height = 24
        Me.dgvAddCourse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAddCourse.Size = New System.Drawing.Size(825, 327)
        Me.dgvAddCourse.TabIndex = 58
        '
        'errorCourseName
        '
        Me.errorCourseName.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.errorCourseName.ContainerControl = Me
        Me.errorCourseName.Icon = CType(resources.GetObject("errorCourseName.Icon"), System.Drawing.Icon)
        '
        'errorCreditHours
        '
        Me.errorCreditHours.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.errorCreditHours.ContainerControl = Me
        Me.errorCreditHours.Icon = CType(resources.GetObject("errorCreditHours.Icon"), System.Drawing.Icon)
        '
        'errorSemester
        '
        Me.errorSemester.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.errorSemester.ContainerControl = Me
        Me.errorSemester.Icon = CType(resources.GetObject("errorSemester.Icon"), System.Drawing.Icon)
        '
        'errorFees
        '
        Me.errorFees.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.errorFees.ContainerControl = Me
        Me.errorFees.Icon = CType(resources.GetObject("errorFees.Icon"), System.Drawing.Icon)
        '
        'errorProgramme
        '
        Me.errorProgramme.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.errorProgramme.ContainerControl = Me
        Me.errorProgramme.Icon = CType(resources.GetObject("errorProgramme.Icon"), System.Drawing.Icon)
        '
        'cbxMode
        '
        Me.cbxMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxMode.Font = New System.Drawing.Font("Fira Mono", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxMode.FormattingEnabled = True
        Me.cbxMode.Items.AddRange(New Object() {"Edit Mode", "Add New", "Delete"})
        Me.cbxMode.Location = New System.Drawing.Point(759, 549)
        Me.cbxMode.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbxMode.Name = "cbxMode"
        Me.cbxMode.Size = New System.Drawing.Size(168, 25)
        Me.cbxMode.TabIndex = 59
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Fira Mono", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(708, 550)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 19)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "Mode"
        '
        'errorCourseID
        '
        Me.errorCourseID.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.errorCourseID.ContainerControl = Me
        Me.errorCourseID.Icon = CType(resources.GetObject("errorCourseID.Icon"), System.Drawing.Icon)
        '
        'AdminAddCourseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(965, 619)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbxMode)
        Me.Controls.Add(Me.dgvAddCourse)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panelAddCourse)
        Me.Controls.Add(Me.label)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "AdminAddCourseForm"
        Me.Text = "AdminAddCourseForm"
        Me.panelAddCourse.ResumeLayout(False)
        Me.panelAddCourse.PerformLayout()
        CType(Me.dgvAddCourse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorCourseName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorCreditHours, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorSemester, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorFees, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorProgramme, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorCourseID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents label As Label
    Friend WithEvents panelAddCourse As Panel
    Friend WithEvents cbxProgramme As ComboBox
    Friend WithEvents lblCourseID As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblProgramme As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label48 As Label
    Friend WithEvents txtCourseID As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblSemester As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtSemester As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents lblCreditHours As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCreditHours As TextBox
    Friend WithEvents dgvAddCourse As DataGridView
    Friend WithEvents lblCourseName As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtCourseName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblFees As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtFees As TextBox
    Friend WithEvents errorCourseName As ErrorProvider
    Friend WithEvents errorCreditHours As ErrorProvider
    Friend WithEvents errorSemester As ErrorProvider
    Friend WithEvents errorFees As ErrorProvider
    Friend WithEvents errorProgramme As ErrorProvider
    Friend WithEvents Label6 As Label
    Friend WithEvents cbxMode As ComboBox
    Friend WithEvents btnRemove As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents lblLec As Label
    Friend WithEvents cbxLec As ComboBox
    Friend WithEvents Label87 As Label
    Friend WithEvents errorCourseID As ErrorProvider
End Class
