<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminDashboardForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminDashboardForm))
        Me.panelDashb = New System.Windows.Forms.Panel()
        Me.dgvStud = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.panelNewApp = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.lblNewApp = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.panelNewLec = New System.Windows.Forms.Panel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.lblNewLec = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.panelNewClass = New System.Windows.Forms.Panel()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.lblNewClass = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.panelStud = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.progressStud = New CircularProgressBar.CircularProgressBar()
        Me.lblUpdateStud = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblStud = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.panelLec = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblUpdateLec = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblLec = New System.Windows.Forms.Label()
        Me.lblTotalLec = New System.Windows.Forms.Label()
        Me.progressLec = New CircularProgressBar.CircularProgressBar()
        Me.panelClass = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.lblUpdateClass = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblClass = New System.Windows.Forms.Label()
        Me.lblTotalClass = New System.Windows.Forms.Label()
        Me.progressClass = New CircularProgressBar.CircularProgressBar()
        Me.timerProgStud1 = New System.Windows.Forms.Timer(Me.components)
        Me.timerProgStud2 = New System.Windows.Forms.Timer(Me.components)
        Me.timerProgLec1 = New System.Windows.Forms.Timer(Me.components)
        Me.timerProgLec2 = New System.Windows.Forms.Timer(Me.components)
        Me.timerProgClass1 = New System.Windows.Forms.Timer(Me.components)
        Me.timerProgClass2 = New System.Windows.Forms.Timer(Me.components)
        Me.timerLblStud = New System.Windows.Forms.Timer(Me.components)
        Me.timerLblLec = New System.Windows.Forms.Timer(Me.components)
        Me.timerLblClass = New System.Windows.Forms.Timer(Me.components)
        Me.panelDashb.SuspendLayout()
        CType(Me.dgvStud, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelNewApp.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelNewLec.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelNewClass.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelStud.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelLec.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelClass.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelDashb
        '
        Me.panelDashb.AutoScroll = True
        Me.panelDashb.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.panelDashb.Controls.Add(Me.dgvStud)
        Me.panelDashb.Controls.Add(Me.Panel1)
        Me.panelDashb.Controls.Add(Me.Label25)
        Me.panelDashb.Controls.Add(Me.Label21)
        Me.panelDashb.Controls.Add(Me.panelNewApp)
        Me.panelDashb.Controls.Add(Me.panelNewLec)
        Me.panelDashb.Controls.Add(Me.panelNewClass)
        Me.panelDashb.Controls.Add(Me.Label7)
        Me.panelDashb.Controls.Add(Me.panelStud)
        Me.panelDashb.Controls.Add(Me.panelLec)
        Me.panelDashb.Controls.Add(Me.panelClass)
        Me.panelDashb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelDashb.Location = New System.Drawing.Point(0, 0)
        Me.panelDashb.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.panelDashb.Name = "panelDashb"
        Me.panelDashb.Size = New System.Drawing.Size(1106, 645)
        Me.panelDashb.TabIndex = 0
        '
        'dgvStud
        '
        Me.dgvStud.AllowUserToAddRows = False
        Me.dgvStud.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvStud.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvStud.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgvStud.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvStud.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.dgvStud.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvStud.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvStud.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Fira Code", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(40, 30, 40, 10)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvStud.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvStud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStud.EnableHeadersVisualStyles = False
        Me.dgvStud.GridColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.dgvStud.Location = New System.Drawing.Point(30, 406)
        Me.dgvStud.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgvStud.MultiSelect = False
        Me.dgvStud.Name = "dgvStud"
        Me.dgvStud.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvStud.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvStud.RowHeadersVisible = False
        Me.dgvStud.RowHeadersWidth = 51
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        Me.dgvStud.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvStud.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.dgvStud.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvStud.RowTemplate.Height = 24
        Me.dgvStud.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStud.Size = New System.Drawing.Size(603, 330)
        Me.dgvStud.TabIndex = 82
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(33, 753)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(980, 17)
        Me.Panel1.TabIndex = 17
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
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Fira Code", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(682, 366)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(157, 38)
        Me.Label21.TabIndex = 14
        Me.Label21.Text = "Statistics"
        '
        'panelNewApp
        '
        Me.panelNewApp.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.panelNewApp.Controls.Add(Me.PictureBox4)
        Me.panelNewApp.Controls.Add(Me.lblNewApp)
        Me.panelNewApp.Controls.Add(Me.Label16)
        Me.panelNewApp.Controls.Add(Me.Label17)
        Me.panelNewApp.Location = New System.Drawing.Point(684, 406)
        Me.panelNewApp.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.panelNewApp.Name = "panelNewApp"
        Me.panelNewApp.Size = New System.Drawing.Size(285, 92)
        Me.panelNewApp.TabIndex = 11
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.WindowsApp2.My.Resources.Resources.application
        Me.PictureBox4.Location = New System.Drawing.Point(18, 28)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(33, 36)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 10
        Me.PictureBox4.TabStop = False
        '
        'lblNewApp
        '
        Me.lblNewApp.AutoSize = True
        Me.lblNewApp.BackColor = System.Drawing.Color.Transparent
        Me.lblNewApp.Font = New System.Drawing.Font("Monoid", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewApp.ForeColor = System.Drawing.Color.White
        Me.lblNewApp.Location = New System.Drawing.Point(235, 31)
        Me.lblNewApp.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNewApp.Name = "lblNewApp"
        Me.lblNewApp.Size = New System.Drawing.Size(30, 32)
        Me.lblNewApp.TabIndex = 12
        Me.lblNewApp.Text = "0"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Fira Code", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(63, 16)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(162, 25)
        Me.Label16.TabIndex = 8
        Me.Label16.Text = "New Application"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Monoid", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(66, 57)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(98, 15)
        Me.Label17.TabIndex = 7
        Me.Label17.Text = "Last 24 hours"
        '
        'panelNewLec
        '
        Me.panelNewLec.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.panelNewLec.Controls.Add(Me.PictureBox5)
        Me.panelNewLec.Controls.Add(Me.lblNewLec)
        Me.panelNewLec.Controls.Add(Me.Label13)
        Me.panelNewLec.Controls.Add(Me.Label14)
        Me.panelNewLec.Location = New System.Drawing.Point(684, 522)
        Me.panelNewLec.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.panelNewLec.Name = "panelNewLec"
        Me.panelNewLec.Size = New System.Drawing.Size(285, 92)
        Me.panelNewLec.TabIndex = 10
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.WindowsApp2.My.Resources.Resources.lecturer1
        Me.PictureBox5.Location = New System.Drawing.Point(18, 28)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(33, 36)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 13
        Me.PictureBox5.TabStop = False
        '
        'lblNewLec
        '
        Me.lblNewLec.AutoSize = True
        Me.lblNewLec.BackColor = System.Drawing.Color.Transparent
        Me.lblNewLec.Font = New System.Drawing.Font("Monoid", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewLec.ForeColor = System.Drawing.Color.White
        Me.lblNewLec.Location = New System.Drawing.Point(235, 31)
        Me.lblNewLec.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNewLec.Name = "lblNewLec"
        Me.lblNewLec.Size = New System.Drawing.Size(30, 32)
        Me.lblNewLec.TabIndex = 11
        Me.lblNewLec.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Fira Code", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(70, 18)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(142, 25)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "New Lecturers"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Monoid", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(72, 59)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(98, 15)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "Last 24 hours"
        '
        'panelNewClass
        '
        Me.panelNewClass.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.panelNewClass.Controls.Add(Me.PictureBox6)
        Me.panelNewClass.Controls.Add(Me.lblNewClass)
        Me.panelNewClass.Controls.Add(Me.Label11)
        Me.panelNewClass.Controls.Add(Me.Label9)
        Me.panelNewClass.Location = New System.Drawing.Point(684, 645)
        Me.panelNewClass.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.panelNewClass.Name = "panelNewClass"
        Me.panelNewClass.Size = New System.Drawing.Size(285, 92)
        Me.panelNewClass.TabIndex = 8
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.WindowsApp2.My.Resources.Resources.class1
        Me.PictureBox6.Location = New System.Drawing.Point(18, 26)
        Me.PictureBox6.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(33, 36)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 14
        Me.PictureBox6.TabStop = False
        '
        'lblNewClass
        '
        Me.lblNewClass.AutoSize = True
        Me.lblNewClass.BackColor = System.Drawing.Color.Transparent
        Me.lblNewClass.Font = New System.Drawing.Font("Monoid", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewClass.ForeColor = System.Drawing.Color.White
        Me.lblNewClass.Location = New System.Drawing.Point(235, 29)
        Me.lblNewClass.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNewClass.Name = "lblNewClass"
        Me.lblNewClass.Size = New System.Drawing.Size(30, 32)
        Me.lblNewClass.TabIndex = 10
        Me.lblNewClass.Text = "0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Fira Code", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(70, 16)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(122, 25)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "New Classes"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Monoid", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(73, 58)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 15)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Last 24 hours"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Fira Code", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(38, 366)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(437, 38)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "List of Students In University"
        '
        'panelStud
        '
        Me.panelStud.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.panelStud.Controls.Add(Me.PictureBox1)
        Me.panelStud.Controls.Add(Me.progressStud)
        Me.panelStud.Controls.Add(Me.lblUpdateStud)
        Me.panelStud.Controls.Add(Me.Label1)
        Me.panelStud.Controls.Add(Me.lblStud)
        Me.panelStud.Controls.Add(Me.Label5)
        Me.panelStud.Location = New System.Drawing.Point(30, 123)
        Me.panelStud.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.panelStud.Name = "panelStud"
        Me.panelStud.Size = New System.Drawing.Size(285, 218)
        Me.panelStud.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(39, 24)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(56, 55)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'progressStud
        '
        Me.progressStud.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.CubicEaseInOut
        Me.progressStud.AnimationSpeed = 2000
        Me.progressStud.BackColor = System.Drawing.Color.Transparent
        Me.progressStud.Font = New System.Drawing.Font("Fira Code", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.progressStud.ForeColor = System.Drawing.Color.White
        Me.progressStud.InnerColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.progressStud.InnerMargin = 2
        Me.progressStud.InnerWidth = -1
        Me.progressStud.Location = New System.Drawing.Point(159, 52)
        Me.progressStud.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.progressStud.MarqueeAnimationSpeed = 1000
        Me.progressStud.Name = "progressStud"
        Me.progressStud.OuterColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.progressStud.OuterMargin = -2
        Me.progressStud.OuterWidth = 2
        Me.progressStud.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.progressStud.ProgressWidth = 2
        Me.progressStud.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.progressStud.SecondaryFont = New System.Drawing.Font("Fira Code", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.progressStud.Size = New System.Drawing.Size(110, 106)
        Me.progressStud.StartAngle = 270
        Me.progressStud.Step = 1
        Me.progressStud.SubscriptColor = System.Drawing.Color.White
        Me.progressStud.SubscriptMargin = New System.Windows.Forms.Padding(6, -18, 0, 0)
        Me.progressStud.SubscriptText = "%"
        Me.progressStud.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.progressStud.SuperscriptMargin = New System.Windows.Forms.Padding(10, 30, 0, 0)
        Me.progressStud.SuperscriptText = ""
        Me.progressStud.TabIndex = 8
        Me.progressStud.Text = "0"
        Me.progressStud.TextMargin = New System.Windows.Forms.Padding(3, 2, 0, 0)
        Me.progressStud.Value = 68
        '
        'lblUpdateStud
        '
        Me.lblUpdateStud.AutoSize = True
        Me.lblUpdateStud.BackColor = System.Drawing.Color.Transparent
        Me.lblUpdateStud.Font = New System.Drawing.Font("Monoid", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUpdateStud.ForeColor = System.Drawing.Color.White
        Me.lblUpdateStud.Location = New System.Drawing.Point(93, 187)
        Me.lblUpdateStud.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUpdateStud.Name = "lblUpdateStud"
        Me.lblUpdateStud.Size = New System.Drawing.Size(119, 15)
        Me.lblUpdateStud.TabIndex = 6
        Me.lblUpdateStud.Text = "12 December 2022"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Monoid", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(17, 187)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Updated :"
        '
        'lblStud
        '
        Me.lblStud.AutoSize = True
        Me.lblStud.BackColor = System.Drawing.Color.Transparent
        Me.lblStud.Font = New System.Drawing.Font("Fira Code", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStud.ForeColor = System.Drawing.Color.White
        Me.lblStud.Location = New System.Drawing.Point(47, 117)
        Me.lblStud.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblStud.Name = "lblStud"
        Me.lblStud.Size = New System.Drawing.Size(48, 60)
        Me.lblStud.TabIndex = 4
        Me.lblStud.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Fira Code", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(9, 91)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 25)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Total Students"
        '
        'panelLec
        '
        Me.panelLec.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.panelLec.Controls.Add(Me.PictureBox2)
        Me.panelLec.Controls.Add(Me.lblUpdateLec)
        Me.panelLec.Controls.Add(Me.Label2)
        Me.panelLec.Controls.Add(Me.lblLec)
        Me.panelLec.Controls.Add(Me.lblTotalLec)
        Me.panelLec.Controls.Add(Me.progressLec)
        Me.panelLec.Location = New System.Drawing.Point(349, 123)
        Me.panelLec.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.panelLec.Name = "panelLec"
        Me.panelLec.Size = New System.Drawing.Size(285, 218)
        Me.panelLec.TabIndex = 8
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(50, 24)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(56, 55)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'lblUpdateLec
        '
        Me.lblUpdateLec.AutoSize = True
        Me.lblUpdateLec.BackColor = System.Drawing.Color.Transparent
        Me.lblUpdateLec.Font = New System.Drawing.Font("Monoid", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUpdateLec.ForeColor = System.Drawing.Color.White
        Me.lblUpdateLec.Location = New System.Drawing.Point(94, 185)
        Me.lblUpdateLec.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUpdateLec.Name = "lblUpdateLec"
        Me.lblUpdateLec.Size = New System.Drawing.Size(119, 15)
        Me.lblUpdateLec.TabIndex = 7
        Me.lblUpdateLec.Text = "12 December 2022"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Monoid", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(19, 185)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Updated : "
        '
        'lblLec
        '
        Me.lblLec.AutoSize = True
        Me.lblLec.BackColor = System.Drawing.Color.Transparent
        Me.lblLec.Font = New System.Drawing.Font("Fira Code", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLec.ForeColor = System.Drawing.Color.White
        Me.lblLec.Location = New System.Drawing.Point(58, 117)
        Me.lblLec.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLec.Name = "lblLec"
        Me.lblLec.Size = New System.Drawing.Size(48, 60)
        Me.lblLec.TabIndex = 4
        Me.lblLec.Text = "0"
        '
        'lblTotalLec
        '
        Me.lblTotalLec.AutoSize = True
        Me.lblTotalLec.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalLec.Font = New System.Drawing.Font("Fira Code", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalLec.ForeColor = System.Drawing.Color.White
        Me.lblTotalLec.Location = New System.Drawing.Point(2, 92)
        Me.lblTotalLec.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTotalLec.Name = "lblTotalLec"
        Me.lblTotalLec.Size = New System.Drawing.Size(162, 25)
        Me.lblTotalLec.TabIndex = 3
        Me.lblTotalLec.Text = "Total Lecturers"
        '
        'progressLec
        '
        Me.progressLec.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.CircularEaseInOut
        Me.progressLec.AnimationSpeed = 2000
        Me.progressLec.BackColor = System.Drawing.Color.Transparent
        Me.progressLec.Font = New System.Drawing.Font("Fira Code", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.progressLec.ForeColor = System.Drawing.Color.White
        Me.progressLec.InnerColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.progressLec.InnerMargin = 2
        Me.progressLec.InnerWidth = -1
        Me.progressLec.Location = New System.Drawing.Point(168, 52)
        Me.progressLec.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.progressLec.MarqueeAnimationSpeed = 1000
        Me.progressLec.Name = "progressLec"
        Me.progressLec.OuterColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.progressLec.OuterMargin = -2
        Me.progressLec.OuterWidth = 2
        Me.progressLec.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.progressLec.ProgressWidth = 2
        Me.progressLec.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.progressLec.SecondaryFont = New System.Drawing.Font("Fira Code", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.progressLec.Size = New System.Drawing.Size(110, 106)
        Me.progressLec.StartAngle = 270
        Me.progressLec.Step = 1
        Me.progressLec.SubscriptColor = System.Drawing.Color.White
        Me.progressLec.SubscriptMargin = New System.Windows.Forms.Padding(6, -18, 0, 0)
        Me.progressLec.SubscriptText = "%"
        Me.progressLec.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.progressLec.SuperscriptMargin = New System.Windows.Forms.Padding(10, 30, 0, 0)
        Me.progressLec.SuperscriptText = ""
        Me.progressLec.TabIndex = 2
        Me.progressLec.Text = "0"
        Me.progressLec.TextMargin = New System.Windows.Forms.Padding(3, 2, 0, 0)
        Me.progressLec.Value = 68
        '
        'panelClass
        '
        Me.panelClass.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.panelClass.Controls.Add(Me.PictureBox3)
        Me.panelClass.Controls.Add(Me.lblUpdateClass)
        Me.panelClass.Controls.Add(Me.Label3)
        Me.panelClass.Controls.Add(Me.lblClass)
        Me.panelClass.Controls.Add(Me.lblTotalClass)
        Me.panelClass.Controls.Add(Me.progressClass)
        Me.panelClass.Location = New System.Drawing.Point(684, 123)
        Me.panelClass.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.panelClass.Name = "panelClass"
        Me.panelClass.Size = New System.Drawing.Size(285, 218)
        Me.panelClass.TabIndex = 7
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(54, 24)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(56, 55)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 11
        Me.PictureBox3.TabStop = False
        '
        'lblUpdateClass
        '
        Me.lblUpdateClass.AutoSize = True
        Me.lblUpdateClass.BackColor = System.Drawing.Color.Transparent
        Me.lblUpdateClass.Font = New System.Drawing.Font("Monoid", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUpdateClass.ForeColor = System.Drawing.Color.White
        Me.lblUpdateClass.Location = New System.Drawing.Point(94, 185)
        Me.lblUpdateClass.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUpdateClass.Name = "lblUpdateClass"
        Me.lblUpdateClass.Size = New System.Drawing.Size(119, 15)
        Me.lblUpdateClass.TabIndex = 8
        Me.lblUpdateClass.Text = "12 December 2022"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Monoid", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(19, 185)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Updated : "
        '
        'lblClass
        '
        Me.lblClass.AutoSize = True
        Me.lblClass.BackColor = System.Drawing.Color.Transparent
        Me.lblClass.Font = New System.Drawing.Font("Fira Code", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClass.ForeColor = System.Drawing.Color.White
        Me.lblClass.Location = New System.Drawing.Point(62, 117)
        Me.lblClass.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblClass.Name = "lblClass"
        Me.lblClass.Size = New System.Drawing.Size(48, 60)
        Me.lblClass.TabIndex = 4
        Me.lblClass.Text = "0"
        '
        'lblTotalClass
        '
        Me.lblTotalClass.AutoSize = True
        Me.lblTotalClass.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalClass.Font = New System.Drawing.Font("Fira Code", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalClass.ForeColor = System.Drawing.Color.White
        Me.lblTotalClass.Location = New System.Drawing.Point(10, 91)
        Me.lblTotalClass.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTotalClass.Name = "lblTotalClass"
        Me.lblTotalClass.Size = New System.Drawing.Size(142, 25)
        Me.lblTotalClass.TabIndex = 3
        Me.lblTotalClass.Text = "Total Classes"
        '
        'progressClass
        '
        Me.progressClass.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.CircularEaseInOut
        Me.progressClass.AnimationSpeed = 2000
        Me.progressClass.BackColor = System.Drawing.Color.Transparent
        Me.progressClass.Font = New System.Drawing.Font("Fira Code", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.progressClass.ForeColor = System.Drawing.Color.White
        Me.progressClass.InnerColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.progressClass.InnerMargin = 2
        Me.progressClass.InnerWidth = -1
        Me.progressClass.Location = New System.Drawing.Point(158, 52)
        Me.progressClass.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.progressClass.MarqueeAnimationSpeed = 1000
        Me.progressClass.Name = "progressClass"
        Me.progressClass.OuterColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.progressClass.OuterMargin = -2
        Me.progressClass.OuterWidth = 2
        Me.progressClass.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.progressClass.ProgressWidth = 2
        Me.progressClass.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.progressClass.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.progressClass.Size = New System.Drawing.Size(110, 106)
        Me.progressClass.StartAngle = 270
        Me.progressClass.Step = 1
        Me.progressClass.SubscriptColor = System.Drawing.Color.White
        Me.progressClass.SubscriptMargin = New System.Windows.Forms.Padding(6, -18, 0, 0)
        Me.progressClass.SubscriptText = "%"
        Me.progressClass.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.progressClass.SuperscriptMargin = New System.Windows.Forms.Padding(10, 30, 0, 0)
        Me.progressClass.SuperscriptText = ""
        Me.progressClass.TabIndex = 2
        Me.progressClass.Text = "0"
        Me.progressClass.TextMargin = New System.Windows.Forms.Padding(3, 2, 0, 0)
        Me.progressClass.Value = 68
        '
        'timerProgStud1
        '
        '
        'timerProgStud2
        '
        '
        'timerProgLec1
        '
        '
        'timerProgLec2
        '
        '
        'timerProgClass1
        '
        '
        'timerProgClass2
        '
        '
        'timerLblStud
        '
        '
        'timerLblLec
        '
        '
        'timerLblClass
        '
        '
        'AdminDashboardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1106, 645)
        Me.Controls.Add(Me.panelDashb)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "AdminDashboardForm"
        Me.Text = "Form1"
        Me.panelDashb.ResumeLayout(False)
        Me.panelDashb.PerformLayout()
        CType(Me.dgvStud, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelNewApp.ResumeLayout(False)
        Me.panelNewApp.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelNewLec.ResumeLayout(False)
        Me.panelNewLec.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelNewClass.ResumeLayout(False)
        Me.panelNewClass.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelStud.ResumeLayout(False)
        Me.panelStud.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelLec.ResumeLayout(False)
        Me.panelLec.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelClass.ResumeLayout(False)
        Me.panelClass.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelDashb As Panel
    Friend WithEvents panelClass As Panel
    Friend WithEvents progressClass As CircularProgressBar.CircularProgressBar
    Friend WithEvents lblClass As Label
    Friend WithEvents lblTotalClass As Label
    Friend WithEvents panelStud As Panel
    Friend WithEvents lblStud As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents panelLec As Panel
    Friend WithEvents lblLec As Label
    Friend WithEvents lblTotalLec As Label
    Friend WithEvents progressLec As CircularProgressBar.CircularProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents panelNewClass As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents panelNewApp As Panel
    Friend WithEvents lblNewApp As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents panelNewLec As Panel
    Friend WithEvents lblNewLec As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lblNewClass As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblUpdateStud As Label
    Friend WithEvents lblUpdateLec As Label
    Friend WithEvents lblUpdateClass As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents progressStud As CircularProgressBar.CircularProgressBar
    Friend WithEvents timerProgStud1 As Timer
    Friend WithEvents timerProgStud2 As Timer
    Friend WithEvents timerProgLec1 As Timer
    Friend WithEvents timerProgLec2 As Timer
    Friend WithEvents timerProgClass1 As Timer
    Friend WithEvents timerProgClass2 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents dgvStud As DataGridView
    Friend WithEvents timerLblStud As Timer
    Friend WithEvents timerLblLec As Timer
    Friend WithEvents timerLblClass As Timer
End Class
