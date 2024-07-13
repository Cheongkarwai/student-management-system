<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminECAForm
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
        Me.panelSetECA = New System.Windows.Forms.Panel()
        Me.cbxStudentID = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvECA = New System.Windows.Forms.DataGridView()
        Me.cbxEvent = New System.Windows.Forms.ComboBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.lblPoint = New System.Windows.Forms.Label()
        Me.cbxProgramme = New System.Windows.Forms.ComboBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.btnAddECA = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.panelSetECA.SuspendLayout()
        CType(Me.dgvECA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelSetECA
        '
        Me.panelSetECA.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.panelSetECA.Controls.Add(Me.cbxStudentID)
        Me.panelSetECA.Controls.Add(Me.Label1)
        Me.panelSetECA.Controls.Add(Me.dgvECA)
        Me.panelSetECA.Controls.Add(Me.cbxEvent)
        Me.panelSetECA.Controls.Add(Me.Label47)
        Me.panelSetECA.Controls.Add(Me.Label50)
        Me.panelSetECA.Controls.Add(Me.lblPoint)
        Me.panelSetECA.Controls.Add(Me.cbxProgramme)
        Me.panelSetECA.Controls.Add(Me.Label48)
        Me.panelSetECA.Location = New System.Drawing.Point(91, 226)
        Me.panelSetECA.Name = "panelSetECA"
        Me.panelSetECA.Size = New System.Drawing.Size(1080, 583)
        Me.panelSetECA.TabIndex = 37
        '
        'cbxStudentID
        '
        Me.cbxStudentID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxStudentID.Font = New System.Drawing.Font("Fira Code", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxStudentID.FormattingEnabled = True
        Me.cbxStudentID.Location = New System.Drawing.Point(80, 307)
        Me.cbxStudentID.Name = "cbxStudentID"
        Me.cbxStudentID.Size = New System.Drawing.Size(322, 40)
        Me.cbxStudentID.Sorted = True
        Me.cbxStudentID.TabIndex = 50
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Fira Code", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(74, 274)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 32)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Student ID"
        '
        'dgvECA
        '
        Me.dgvECA.AllowUserToAddRows = False
        Me.dgvECA.AllowUserToDeleteRows = False
        Me.dgvECA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgvECA.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.dgvECA.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.dgvECA.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvECA.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvECA.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(73, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(80, 20, 80, 4)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(73, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvECA.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvECA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvECA.EnableHeadersVisualStyles = False
        Me.dgvECA.Location = New System.Drawing.Point(503, 42)
        Me.dgvECA.Name = "dgvECA"
        Me.dgvECA.ReadOnly = True
        Me.dgvECA.RowHeadersVisible = False
        Me.dgvECA.RowHeadersWidth = 51
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(73, Byte), Integer))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        Me.dgvECA.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvECA.RowTemplate.DefaultCellStyle.Padding = New System.Windows.Forms.Padding(80, 0, 80, 0)
        Me.dgvECA.RowTemplate.Height = 24
        Me.dgvECA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvECA.Size = New System.Drawing.Size(525, 305)
        Me.dgvECA.TabIndex = 48
        '
        'cbxEvent
        '
        Me.cbxEvent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxEvent.Font = New System.Drawing.Font("Fira Code", 12.0!)
        Me.cbxEvent.FormattingEnabled = True
        Me.cbxEvent.Location = New System.Drawing.Point(80, 86)
        Me.cbxEvent.Name = "cbxEvent"
        Me.cbxEvent.Size = New System.Drawing.Size(322, 40)
        Me.cbxEvent.TabIndex = 46
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("Fira Code", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.ForeColor = System.Drawing.Color.White
        Me.Label47.Location = New System.Drawing.Point(74, 51)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(134, 32)
        Me.Label47.TabIndex = 43
        Me.Label47.Text = "Event Name"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Font = New System.Drawing.Font("Fira Code", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.ForeColor = System.Drawing.Color.White
        Me.Label50.Location = New System.Drawing.Point(417, 395)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(267, 58)
        Me.Label50.TabIndex = 35
        Me.Label50.Text = "Event Point"
        '
        'lblPoint
        '
        Me.lblPoint.AutoSize = True
        Me.lblPoint.Font = New System.Drawing.Font("Monoid", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPoint.ForeColor = System.Drawing.Color.White
        Me.lblPoint.Location = New System.Drawing.Point(531, 470)
        Me.lblPoint.Name = "lblPoint"
        Me.lblPoint.Size = New System.Drawing.Size(50, 53)
        Me.lblPoint.TabIndex = 33
        Me.lblPoint.Text = "0"
        '
        'cbxProgramme
        '
        Me.cbxProgramme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxProgramme.Font = New System.Drawing.Font("Fira Code", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxProgramme.FormattingEnabled = True
        Me.cbxProgramme.Location = New System.Drawing.Point(80, 191)
        Me.cbxProgramme.Name = "cbxProgramme"
        Me.cbxProgramme.Size = New System.Drawing.Size(322, 40)
        Me.cbxProgramme.Sorted = True
        Me.cbxProgramme.TabIndex = 25
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Font = New System.Drawing.Font("Fira Code", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.Color.White
        Me.Label48.Location = New System.Drawing.Point(74, 158)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(122, 32)
        Me.Label48.TabIndex = 20
        Me.Label48.Text = "Programme"
        '
        'btnAddECA
        '
        Me.btnAddECA.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnAddECA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddECA.Font = New System.Drawing.Font("Fira Code", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddECA.ForeColor = System.Drawing.Color.White
        Me.btnAddECA.Location = New System.Drawing.Point(347, 861)
        Me.btnAddECA.Name = "btnAddECA"
        Me.btnAddECA.Size = New System.Drawing.Size(221, 47)
        Me.btnAddECA.TabIndex = 34
        Me.btnAddECA.Text = "Add ECA Point"
        Me.btnAddECA.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Fira Code", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.White
        Me.Button7.Location = New System.Drawing.Point(770, 861)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(221, 47)
        Me.Button7.TabIndex = 24
        Me.Button7.Text = "Reset"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Font = New System.Drawing.Font("Fira Code", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.ForeColor = System.Drawing.Color.White
        Me.Label49.Location = New System.Drawing.Point(119, 140)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(380, 47)
        Me.Label49.TabIndex = 38
        Me.Label49.Text = "Co-curriculum System"
        '
        'AdminECAForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1185, 774)
        Me.Controls.Add(Me.panelSetECA)
        Me.Controls.Add(Me.Label49)
        Me.Controls.Add(Me.btnAddECA)
        Me.Controls.Add(Me.Button7)
        Me.Name = "AdminECAForm"
        Me.Text = "AdminECAForm"
        Me.panelSetECA.ResumeLayout(False)
        Me.panelSetECA.PerformLayout()
        CType(Me.dgvECA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents panelSetECA As Panel
    Friend WithEvents Label47 As Label
    Friend WithEvents Label50 As Label
    Friend WithEvents btnAddECA As Button
    Friend WithEvents lblPoint As Label
    Friend WithEvents cbxProgramme As ComboBox
    Friend WithEvents Button7 As Button
    Friend WithEvents Label48 As Label
    Friend WithEvents Label49 As Label
    Friend WithEvents cbxEvent As ComboBox
    Friend WithEvents dgvECA As DataGridView
    Friend WithEvents cbxStudentID As ComboBox
    Friend WithEvents Label1 As Label
End Class
