<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDangNhap
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
        Me.btnXoaDN = New System.Windows.Forms.Button()
        Me.btnThoatDN = New System.Windows.Forms.Button()
        Me.btnNhapDN = New System.Windows.Forms.Button()
        Me.txtMatKhau = New System.Windows.Forms.TextBox()
        Me.txtTenDangNhap = New System.Windows.Forms.TextBox()
        Me.lblMatKhau = New System.Windows.Forms.Label()
        Me.lblTenDangNhap = New System.Windows.Forms.Label()
        Me.lblDangNhap = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnXoaDN
        '
        Me.btnXoaDN.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnXoaDN.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnXoaDN.ForeColor = System.Drawing.SystemColors.Control
        Me.btnXoaDN.Image = Global.ngoctpnps02720_inf205_asmfinal.My.Resources.Resources.eraser
        Me.btnXoaDN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnXoaDN.Location = New System.Drawing.Point(281, 286)
        Me.btnXoaDN.Name = "btnXoaDN"
        Me.btnXoaDN.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnXoaDN.Size = New System.Drawing.Size(75, 30)
        Me.btnXoaDN.TabIndex = 6
        Me.btnXoaDN.Text = "Xóa   "
        Me.btnXoaDN.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnXoaDN.UseVisualStyleBackColor = False
        '
        'btnThoatDN
        '
        Me.btnThoatDN.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnThoatDN.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnThoatDN.ForeColor = System.Drawing.SystemColors.Control
        Me.btnThoatDN.Image = Global.ngoctpnps02720_inf205_asmfinal.My.Resources.Resources.dialog_cancel
        Me.btnThoatDN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThoatDN.Location = New System.Drawing.Point(373, 286)
        Me.btnThoatDN.Name = "btnThoatDN"
        Me.btnThoatDN.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnThoatDN.Size = New System.Drawing.Size(75, 30)
        Me.btnThoatDN.TabIndex = 7
        Me.btnThoatDN.Text = "Thoát "
        Me.btnThoatDN.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnThoatDN.UseVisualStyleBackColor = False
        '
        'btnNhapDN
        '
        Me.btnNhapDN.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnNhapDN.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnNhapDN.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnNhapDN.ForeColor = System.Drawing.SystemColors.Control
        Me.btnNhapDN.Image = Global.ngoctpnps02720_inf205_asmfinal.My.Resources.Resources.login
        Me.btnNhapDN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNhapDN.Location = New System.Drawing.Point(188, 286)
        Me.btnNhapDN.Name = "btnNhapDN"
        Me.btnNhapDN.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnNhapDN.Size = New System.Drawing.Size(75, 30)
        Me.btnNhapDN.TabIndex = 5
        Me.btnNhapDN.Text = "Nhập"
        Me.btnNhapDN.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNhapDN.UseVisualStyleBackColor = False
        '
        'txtMatKhau
        '
        Me.txtMatKhau.BackColor = System.Drawing.Color.DodgerBlue
        Me.txtMatKhau.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtMatKhau.ForeColor = System.Drawing.SystemColors.Control
        Me.txtMatKhau.Location = New System.Drawing.Point(185, 230)
        Me.txtMatKhau.Multiline = True
        Me.txtMatKhau.Name = "txtMatKhau"
        Me.txtMatKhau.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtMatKhau.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMatKhau.Size = New System.Drawing.Size(263, 23)
        Me.txtMatKhau.TabIndex = 4
        Me.txtMatKhau.Text = "ABC123"
        '
        'txtTenDangNhap
        '
        Me.txtTenDangNhap.BackColor = System.Drawing.Color.DodgerBlue
        Me.txtTenDangNhap.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtTenDangNhap.ForeColor = System.Drawing.SystemColors.Control
        Me.txtTenDangNhap.Location = New System.Drawing.Point(185, 156)
        Me.txtTenDangNhap.Multiline = True
        Me.txtTenDangNhap.Name = "txtTenDangNhap"
        Me.txtTenDangNhap.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTenDangNhap.Size = New System.Drawing.Size(263, 23)
        Me.txtTenDangNhap.TabIndex = 3
        Me.txtTenDangNhap.Text = "ngoctpn"
        '
        'lblMatKhau
        '
        Me.lblMatKhau.BackColor = System.Drawing.Color.Transparent
        Me.lblMatKhau.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblMatKhau.ForeColor = System.Drawing.SystemColors.Control
        Me.lblMatKhau.Location = New System.Drawing.Point(185, 201)
        Me.lblMatKhau.Name = "lblMatKhau"
        Me.lblMatKhau.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMatKhau.Size = New System.Drawing.Size(223, 23)
        Me.lblMatKhau.TabIndex = 2
        Me.lblMatKhau.Text = "Mật Khẩu"
        Me.lblMatKhau.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTenDangNhap
        '
        Me.lblTenDangNhap.BackColor = System.Drawing.Color.Transparent
        Me.lblTenDangNhap.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblTenDangNhap.ForeColor = System.Drawing.SystemColors.Control
        Me.lblTenDangNhap.Location = New System.Drawing.Point(185, 127)
        Me.lblTenDangNhap.Name = "lblTenDangNhap"
        Me.lblTenDangNhap.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTenDangNhap.Size = New System.Drawing.Size(223, 23)
        Me.lblTenDangNhap.TabIndex = 1
        Me.lblTenDangNhap.Text = "Tên Đăng Nhập"
        Me.lblTenDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDangNhap
        '
        Me.lblDangNhap.BackColor = System.Drawing.Color.Transparent
        Me.lblDangNhap.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblDangNhap.ForeColor = System.Drawing.SystemColors.Control
        Me.lblDangNhap.Location = New System.Drawing.Point(116, 44)
        Me.lblDangNhap.Name = "lblDangNhap"
        Me.lblDangNhap.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDangNhap.Size = New System.Drawing.Size(412, 39)
        Me.lblDangNhap.TabIndex = 0
        Me.lblDangNhap.Text = "Đăng Nhập Hệ Thống"
        Me.lblDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmDangNhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ngoctpnps02720_inf205_asmfinal.My.Resources.Resources.hinh_nen
        Me.ClientSize = New System.Drawing.Size(644, 360)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnXoaDN)
        Me.Controls.Add(Me.btnThoatDN)
        Me.Controls.Add(Me.btnNhapDN)
        Me.Controls.Add(Me.txtMatKhau)
        Me.Controls.Add(Me.txtTenDangNhap)
        Me.Controls.Add(Me.lblMatKhau)
        Me.Controls.Add(Me.lblTenDangNhap)
        Me.Controls.Add(Me.lblDangNhap)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmDangNhap"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnXoaDN As System.Windows.Forms.Button
    Friend WithEvents btnThoatDN As System.Windows.Forms.Button
    Friend WithEvents btnNhapDN As System.Windows.Forms.Button
    Friend WithEvents txtMatKhau As System.Windows.Forms.TextBox
    Friend WithEvents txtTenDangNhap As System.Windows.Forms.TextBox
    Friend WithEvents lblMatKhau As System.Windows.Forms.Label
    Friend WithEvents lblTenDangNhap As System.Windows.Forms.Label
    Friend WithEvents lblDangNhap As System.Windows.Forms.Label
End Class
