<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWelcome
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
        Me.tmrWelcome = New System.Windows.Forms.Timer(Me.components)
        Me.pgbWelcome = New System.Windows.Forms.ProgressBar()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tmrWelcome
        '
        Me.tmrWelcome.Enabled = True
        Me.tmrWelcome.Interval = 30
        '
        'pgbWelcome
        '
        Me.pgbWelcome.Location = New System.Drawing.Point(-3, 350)
        Me.pgbWelcome.Name = "pgbWelcome"
        Me.pgbWelcome.Size = New System.Drawing.Size(650, 10)
        Me.pgbWelcome.TabIndex = 5
        '
        'lblWelcome
        '
        Me.lblWelcome.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblWelcome.BackColor = System.Drawing.Color.Transparent
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblWelcome.Location = New System.Drawing.Point(71, 73)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(500, 192)
        Me.lblWelcome.TabIndex = 4
        Me.lblWelcome.Text = "Chương Trình Quản Lý"
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmWelcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ngoctpnps02720_inf205_asmfinal.My.Resources.Resources.hinh_nen
        Me.ClientSize = New System.Drawing.Size(644, 360)
        Me.ControlBox = False
        Me.Controls.Add(Me.pgbWelcome)
        Me.Controls.Add(Me.lblWelcome)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmWelcome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tmrWelcome As System.Windows.Forms.Timer
    Friend WithEvents pgbWelcome As System.Windows.Forms.ProgressBar
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
End Class
