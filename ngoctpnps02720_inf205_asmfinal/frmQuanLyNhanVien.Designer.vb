<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanLyNhanVien
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
        Me.btnSuaNV = New System.Windows.Forms.Button()
        Me.txtTenDangNhap = New System.Windows.Forms.TextBox()
        Me.lblTenDangNhap = New System.Windows.Forms.Label()
        Me.btnThoatNV = New System.Windows.Forms.Button()
        Me.btnXoaNV = New System.Windows.Forms.Button()
        Me.btnThemNV = New System.Windows.Forms.Button()
        Me.txtMaHDNV = New System.Windows.Forms.TextBox()
        Me.txtTenNV = New System.Windows.Forms.TextBox()
        Me.lblMaHDNV = New System.Windows.Forms.Label()
        Me.lblTenNV = New System.Windows.Forms.Label()
        Me.txtMatKhauNV = New System.Windows.Forms.TextBox()
        Me.txtMaNV = New System.Windows.Forms.TextBox()
        Me.lblMatKhauNV = New System.Windows.Forms.Label()
        Me.lblMaNV = New System.Windows.Forms.Label()
        Me.dgvDanhSachNV = New System.Windows.Forms.DataGridView()
        Me.lblQLNV = New System.Windows.Forms.Label()
        CType(Me.dgvDanhSachNV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSuaNV
        '
        Me.btnSuaNV.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnSuaNV.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnSuaNV.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnSuaNV.ForeColor = System.Drawing.SystemColors.Control
        Me.btnSuaNV.Image = Global.ngoctpnps02720_inf205_asmfinal.My.Resources.Resources.sửa
        Me.btnSuaNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSuaNV.Location = New System.Drawing.Point(565, 293)
        Me.btnSuaNV.Name = "btnSuaNV"
        Me.btnSuaNV.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnSuaNV.Size = New System.Drawing.Size(75, 30)
        Me.btnSuaNV.TabIndex = 12
        Me.btnSuaNV.Text = "Sửa   "
        Me.btnSuaNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSuaNV.UseVisualStyleBackColor = False
        '
        'txtTenDangNhap
        '
        Me.txtTenDangNhap.BackColor = System.Drawing.Color.DodgerBlue
        Me.txtTenDangNhap.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtTenDangNhap.ForeColor = System.Drawing.SystemColors.Control
        Me.txtTenDangNhap.Location = New System.Drawing.Point(252, 193)
        Me.txtTenDangNhap.Multiline = True
        Me.txtTenDangNhap.Name = "txtTenDangNhap"
        Me.txtTenDangNhap.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTenDangNhap.Size = New System.Drawing.Size(130, 23)
        Me.txtTenDangNhap.TabIndex = 9
        '
        'lblTenDangNhap
        '
        Me.lblTenDangNhap.BackColor = System.Drawing.Color.Transparent
        Me.lblTenDangNhap.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblTenDangNhap.ForeColor = System.Drawing.SystemColors.Control
        Me.lblTenDangNhap.Location = New System.Drawing.Point(252, 164)
        Me.lblTenDangNhap.Name = "lblTenDangNhap"
        Me.lblTenDangNhap.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTenDangNhap.Size = New System.Drawing.Size(115, 23)
        Me.lblTenDangNhap.TabIndex = 4
        Me.lblTenDangNhap.Text = "Tên Đăng Nhập"
        Me.lblTenDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnThoatNV
        '
        Me.btnThoatNV.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnThoatNV.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnThoatNV.ForeColor = System.Drawing.SystemColors.Control
        Me.btnThoatNV.Image = Global.ngoctpnps02720_inf205_asmfinal.My.Resources.Resources.dialog_cancel
        Me.btnThoatNV.Location = New System.Drawing.Point(610, 0)
        Me.btnThoatNV.Name = "btnThoatNV"
        Me.btnThoatNV.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnThoatNV.Size = New System.Drawing.Size(30, 30)
        Me.btnThoatNV.TabIndex = 15
        Me.btnThoatNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnThoatNV.UseVisualStyleBackColor = False
        '
        'btnXoaNV
        '
        Me.btnXoaNV.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnXoaNV.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnXoaNV.ForeColor = System.Drawing.SystemColors.Control
        Me.btnXoaNV.Image = Global.ngoctpnps02720_inf205_asmfinal.My.Resources.Resources.eraser
        Me.btnXoaNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnXoaNV.Location = New System.Drawing.Point(565, 329)
        Me.btnXoaNV.Name = "btnXoaNV"
        Me.btnXoaNV.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnXoaNV.Size = New System.Drawing.Size(75, 30)
        Me.btnXoaNV.TabIndex = 13
        Me.btnXoaNV.Text = "Xóa   "
        Me.btnXoaNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnXoaNV.UseVisualStyleBackColor = False
        '
        'btnThemNV
        '
        Me.btnThemNV.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnThemNV.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnThemNV.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnThemNV.ForeColor = System.Drawing.SystemColors.Control
        Me.btnThemNV.Image = Global.ngoctpnps02720_inf205_asmfinal.My.Resources.Resources.thêm
        Me.btnThemNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThemNV.Location = New System.Drawing.Point(565, 257)
        Me.btnThemNV.Name = "btnThemNV"
        Me.btnThemNV.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnThemNV.Size = New System.Drawing.Size(75, 30)
        Me.btnThemNV.TabIndex = 11
        Me.btnThemNV.Text = "Thêm"
        Me.btnThemNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnThemNV.UseVisualStyleBackColor = False
        '
        'txtMaHDNV
        '
        Me.txtMaHDNV.BackColor = System.Drawing.Color.DodgerBlue
        Me.txtMaHDNV.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtMaHDNV.ForeColor = System.Drawing.SystemColors.Control
        Me.txtMaHDNV.Location = New System.Drawing.Point(450, 193)
        Me.txtMaHDNV.Multiline = True
        Me.txtMaHDNV.Name = "txtMaHDNV"
        Me.txtMaHDNV.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMaHDNV.Size = New System.Drawing.Size(130, 23)
        Me.txtMaHDNV.TabIndex = 10
        '
        'txtTenNV
        '
        Me.txtTenNV.BackColor = System.Drawing.Color.DodgerBlue
        Me.txtTenNV.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtTenNV.ForeColor = System.Drawing.SystemColors.Control
        Me.txtTenNV.Location = New System.Drawing.Point(382, 127)
        Me.txtTenNV.Multiline = True
        Me.txtTenNV.Name = "txtTenNV"
        Me.txtTenNV.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTenNV.Size = New System.Drawing.Size(130, 23)
        Me.txtTenNV.TabIndex = 7
        '
        'lblMaHDNV
        '
        Me.lblMaHDNV.BackColor = System.Drawing.Color.Transparent
        Me.lblMaHDNV.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblMaHDNV.ForeColor = System.Drawing.SystemColors.Control
        Me.lblMaHDNV.Location = New System.Drawing.Point(450, 164)
        Me.lblMaHDNV.Name = "lblMaHDNV"
        Me.lblMaHDNV.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMaHDNV.Size = New System.Drawing.Size(115, 23)
        Me.lblMaHDNV.TabIndex = 5
        Me.lblMaHDNV.Text = "Mã Hóa Đơn"
        Me.lblMaHDNV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTenNV
        '
        Me.lblTenNV.BackColor = System.Drawing.Color.Transparent
        Me.lblTenNV.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblTenNV.ForeColor = System.Drawing.SystemColors.Control
        Me.lblTenNV.Location = New System.Drawing.Point(382, 98)
        Me.lblTenNV.Name = "lblTenNV"
        Me.lblTenNV.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTenNV.Size = New System.Drawing.Size(115, 23)
        Me.lblTenNV.TabIndex = 2
        Me.lblTenNV.Text = "Tên Nhân Viên"
        Me.lblTenNV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtMatKhauNV
        '
        Me.txtMatKhauNV.BackColor = System.Drawing.Color.DodgerBlue
        Me.txtMatKhauNV.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtMatKhauNV.ForeColor = System.Drawing.SystemColors.Control
        Me.txtMatKhauNV.Location = New System.Drawing.Point(55, 193)
        Me.txtMatKhauNV.Multiline = True
        Me.txtMatKhauNV.Name = "txtMatKhauNV"
        Me.txtMatKhauNV.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMatKhauNV.Size = New System.Drawing.Size(130, 23)
        Me.txtMatKhauNV.TabIndex = 8
        '
        'txtMaNV
        '
        Me.txtMaNV.BackColor = System.Drawing.Color.DodgerBlue
        Me.txtMaNV.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtMaNV.ForeColor = System.Drawing.SystemColors.Control
        Me.txtMaNV.Location = New System.Drawing.Point(123, 127)
        Me.txtMaNV.Multiline = True
        Me.txtMaNV.Name = "txtMaNV"
        Me.txtMaNV.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMaNV.Size = New System.Drawing.Size(130, 23)
        Me.txtMaNV.TabIndex = 6
        '
        'lblMatKhauNV
        '
        Me.lblMatKhauNV.BackColor = System.Drawing.Color.Transparent
        Me.lblMatKhauNV.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblMatKhauNV.ForeColor = System.Drawing.SystemColors.Control
        Me.lblMatKhauNV.Location = New System.Drawing.Point(55, 164)
        Me.lblMatKhauNV.Name = "lblMatKhauNV"
        Me.lblMatKhauNV.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMatKhauNV.Size = New System.Drawing.Size(115, 23)
        Me.lblMatKhauNV.TabIndex = 3
        Me.lblMatKhauNV.Text = "Mật Khẩu"
        Me.lblMatKhauNV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMaNV
        '
        Me.lblMaNV.BackColor = System.Drawing.Color.Transparent
        Me.lblMaNV.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblMaNV.ForeColor = System.Drawing.SystemColors.Control
        Me.lblMaNV.Location = New System.Drawing.Point(123, 98)
        Me.lblMaNV.Name = "lblMaNV"
        Me.lblMaNV.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMaNV.Size = New System.Drawing.Size(115, 23)
        Me.lblMaNV.TabIndex = 1
        Me.lblMaNV.Text = "Mã Nhân Viên"
        Me.lblMaNV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvDanhSachNV
        '
        Me.dgvDanhSachNV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDanhSachNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDanhSachNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhSachNV.Location = New System.Drawing.Point(5, 257)
        Me.dgvDanhSachNV.Name = "dgvDanhSachNV"
        Me.dgvDanhSachNV.Size = New System.Drawing.Size(554, 102)
        Me.dgvDanhSachNV.TabIndex = 14
        '
        'lblQLNV
        '
        Me.lblQLNV.BackColor = System.Drawing.Color.Transparent
        Me.lblQLNV.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblQLNV.ForeColor = System.Drawing.SystemColors.Control
        Me.lblQLNV.Location = New System.Drawing.Point(172, 0)
        Me.lblQLNV.Name = "lblQLNV"
        Me.lblQLNV.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblQLNV.Size = New System.Drawing.Size(290, 50)
        Me.lblQLNV.TabIndex = 0
        Me.lblQLNV.Text = "Quản Lý Nhân Viên"
        Me.lblQLNV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmQuanLyNhanVien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ngoctpnps02720_inf205_asmfinal.My.Resources.Resources.hinh_nen
        Me.ClientSize = New System.Drawing.Size(644, 360)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSuaNV)
        Me.Controls.Add(Me.txtTenDangNhap)
        Me.Controls.Add(Me.lblTenDangNhap)
        Me.Controls.Add(Me.btnThoatNV)
        Me.Controls.Add(Me.btnXoaNV)
        Me.Controls.Add(Me.btnThemNV)
        Me.Controls.Add(Me.txtMaHDNV)
        Me.Controls.Add(Me.txtTenNV)
        Me.Controls.Add(Me.lblMaHDNV)
        Me.Controls.Add(Me.lblTenNV)
        Me.Controls.Add(Me.txtMatKhauNV)
        Me.Controls.Add(Me.txtMaNV)
        Me.Controls.Add(Me.lblMatKhauNV)
        Me.Controls.Add(Me.lblMaNV)
        Me.Controls.Add(Me.dgvDanhSachNV)
        Me.Controls.Add(Me.lblQLNV)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmQuanLyNhanVien"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgvDanhSachNV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSuaNV As System.Windows.Forms.Button
    Friend WithEvents txtTenDangNhap As System.Windows.Forms.TextBox
    Friend WithEvents lblTenDangNhap As System.Windows.Forms.Label
    Friend WithEvents btnThoatNV As System.Windows.Forms.Button
    Friend WithEvents btnXoaNV As System.Windows.Forms.Button
    Friend WithEvents btnThemNV As System.Windows.Forms.Button
    Friend WithEvents txtMaHDNV As System.Windows.Forms.TextBox
    Friend WithEvents txtTenNV As System.Windows.Forms.TextBox
    Friend WithEvents lblMaHDNV As System.Windows.Forms.Label
    Friend WithEvents lblTenNV As System.Windows.Forms.Label
    Friend WithEvents txtMatKhauNV As System.Windows.Forms.TextBox
    Friend WithEvents txtMaNV As System.Windows.Forms.TextBox
    Friend WithEvents lblMatKhauNV As System.Windows.Forms.Label
    Friend WithEvents lblMaNV As System.Windows.Forms.Label
    Friend WithEvents dgvDanhSachNV As System.Windows.Forms.DataGridView
    Friend WithEvents lblQLNV As System.Windows.Forms.Label
End Class
