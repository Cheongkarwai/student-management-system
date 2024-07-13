<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LecDashboardForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LecDashboardForm))
        Me.panelDashb = New System.Windows.Forms.Panel()
        Me.dgvClass = New System.Windows.Forms.DataGridView()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.panelStud = New System.Windows.Forms.Panel()
        Me.txtStud = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.panelClass = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.txtClass = New System.Windows.Forms.Label()
        Me.lblTotalClass = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panelDashb.SuspendLayout()
        CType(Me.dgvClass, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelStud.SuspendLayout()
        Me.panelClass.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelDashb
        '
        Me.panelDashb.AutoScroll = True
        Me.panelDashb.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.panelDashb.Controls.Add(Me.dgvClass)
        Me.panelDashb.Controls.Add(Me.Label25)
        Me.panelDashb.Controls.Add(Me.Label7)
        Me.panelDashb.Controls.Add(Me.panelStud)
        Me.panelDashb.Controls.Add(Me.panelClass)
        Me.panelDashb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelDashb.Location = New System.Drawing.Point(0, 0)
        Me.panelDashb.Name = "panelDashb"
        Me.panelDashb.Size = New System.Drawing.Size(1382, 806)
        Me.panelDashb.TabIndex = 1
        '
        'dgvClass
        '
        Me.dgvClass.AllowUserToAddRows = False
        Me.dgvClass.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvClass.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvClass.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgvClass.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvClass.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.dgvClass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvClass.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvClass.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Fira Code", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(105, 30, 105, 10)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvClass.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClass.EnableHeadersVisualStyles = False
        Me.dgvClass.GridColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.dgvClass.Location = New System.Drawing.Point(147, 510)
        Me.dgvClass.MultiSelect = False
        Me.dgvClass.Name = "dgvClass"
        Me.dgvClass.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvClass.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvClass.RowHeadersVisible = False
        Me.dgvClass.RowHeadersWidth = 51
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        Me.dgvClass.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvClass.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.dgvClass.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvClass.RowTemplate.Height = 24
        Me.dgvClass.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvClass.Size = New System.Drawing.Size(976, 336)
        Me.dgvClass.TabIndex = 53
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Fira Code", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(139, 98)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(182, 47)
        Me.Label25.TabIndex = 16
        Me.Label25.Text = "Dashboard"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Fira Code", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(139, 434)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(290, 47)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "List of Classes"
        '
        'panelStud
        '
        Me.panelStud.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.panelStud.Controls.Add(Me.PictureBox1)
        Me.panelStud.Controls.Add(Me.txtStud)
        Me.panelStud.Controls.Add(Me.Label5)
        Me.panelStud.Location = New System.Drawing.Point(147, 177)
        Me.panelStud.Name = "panelStud"
        Me.panelStud.Size = New System.Drawing.Size(461, 207)
        Me.panelStud.TabIndex = 9
        '
        'txtStud
        '
        Me.txtStud.AutoSize = True
        Me.txtStud.BackColor = System.Drawing.Color.Transparent
        Me.txtStud.Font = New System.Drawing.Font("Fira Code", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStud.ForeColor = System.Drawing.Color.White
        Me.txtStud.Location = New System.Drawing.Point(292, 108)
        Me.txtStud.Name = "txtStud"
        Me.txtStud.Size = New System.Drawing.Size(60, 74)
        Me.txtStud.TabIndex = 4
        Me.txtStud.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Fira Code", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(214, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(182, 32)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Total Students"
        '
        'panelClass
        '
        Me.panelClass.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.panelClass.Controls.Add(Me.PictureBox3)
        Me.panelClass.Controls.Add(Me.txtClass)
        Me.panelClass.Controls.Add(Me.lblTotalClass)
        Me.panelClass.Location = New System.Drawing.Point(662, 177)
        Me.panelClass.Name = "panelClass"
        Me.panelClass.Size = New System.Drawing.Size(461, 210)
        Me.panelClass.TabIndex = 7
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(46, 50)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(118, 112)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 11
        Me.PictureBox3.TabStop = False
        '
        'txtClass
        '
        Me.txtClass.AutoSize = True
        Me.txtClass.BackColor = System.Drawing.Color.Transparent
        Me.txtClass.Font = New System.Drawing.Font("Fira Code", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClass.ForeColor = System.Drawing.Color.White
        Me.txtClass.Location = New System.Drawing.Point(280, 108)
        Me.txtClass.Name = "txtClass"
        Me.txtClass.Size = New System.Drawing.Size(60, 74)
        Me.txtClass.TabIndex = 4
        Me.txtClass.Text = "0"
        '
        'lblTotalClass
        '
        Me.lblTotalClass.AutoSize = True
        Me.lblTotalClass.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalClass.Font = New System.Drawing.Font("Fira Code", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalClass.ForeColor = System.Drawing.Color.White
        Me.lblTotalClass.Location = New System.Drawing.Point(227, 50)
        Me.lblTotalClass.Name = "lblTotalClass"
        Me.lblTotalClass.Size = New System.Drawing.Size(170, 32)
        Me.lblTotalClass.TabIndex = 3
        Me.lblTotalClass.Text = "Total Classes"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(51, 50)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(108, 112)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'LecDashboardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1382, 806)
        Me.Controls.Add(Me.panelDashb)
        Me.Name = "LecDashboardForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LecDashboard"
        Me.panelDashb.ResumeLayout(False)
        Me.panelDashb.PerformLayout()
        CType(Me.dgvClass, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelStud.ResumeLayout(False)
        Me.panelStud.PerformLayout()
        Me.panelClass.ResumeLayout(False)
        Me.panelClass.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelDashb As Panel
    Friend WithEvents Label25 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents panelStud As Panel
    Friend WithEvents txtStud As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents panelClass As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents txtClass As Label
    Friend WithEvents lblTotalClass As Label
    Friend WithEvents dgvClass As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
End Class
