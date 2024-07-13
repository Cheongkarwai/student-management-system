<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class verifyForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(verifyForm))
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.lblVerify = New System.Windows.Forms.Label()
        Me.txtVerify = New System.Windows.Forms.TextBox()
        Me.btnVerify = New System.Windows.Forms.Button()
        Me.errorVerify = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.errorVerify, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(156, 253)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 30)
        Me.btnRefresh.TabIndex = 31
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'lblVerify
        '
        Me.lblVerify.BackColor = System.Drawing.Color.White
        Me.lblVerify.Font = New System.Drawing.Font("Segoe Script", 28.2!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Strikeout), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVerify.ForeColor = System.Drawing.Color.Black
        Me.lblVerify.Location = New System.Drawing.Point(63, 23)
        Me.lblVerify.Name = "lblVerify"
        Me.lblVerify.Size = New System.Drawing.Size(420, 146)
        Me.lblVerify.TabIndex = 30
        Me.lblVerify.Text = "Label9"
        Me.lblVerify.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtVerify
        '
        Me.txtVerify.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVerify.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVerify.Location = New System.Drawing.Point(109, 204)
        Me.txtVerify.Name = "txtVerify"
        Me.txtVerify.Size = New System.Drawing.Size(331, 27)
        Me.txtVerify.TabIndex = 29
        '
        'btnVerify
        '
        Me.btnVerify.Location = New System.Drawing.Point(294, 253)
        Me.btnVerify.Name = "btnVerify"
        Me.btnVerify.Size = New System.Drawing.Size(75, 30)
        Me.btnVerify.TabIndex = 32
        Me.btnVerify.Text = "Verify"
        Me.btnVerify.UseVisualStyleBackColor = True
        '
        'errorVerify
        '
        Me.errorVerify.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.errorVerify.ContainerControl = Me
        Me.errorVerify.Icon = CType(resources.GetObject("errorVerify.Icon"), System.Drawing.Icon)
        '
        'verifyForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(552, 308)
        Me.Controls.Add(Me.btnVerify)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.lblVerify)
        Me.Controls.Add(Me.txtVerify)
        Me.Name = "verifyForm"
        CType(Me.errorVerify, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRefresh As Button
    Friend WithEvents lblVerify As Label
    Friend WithEvents txtVerify As TextBox
    Friend WithEvents btnVerify As Button
    Friend WithEvents errorVerify As ErrorProvider
End Class
