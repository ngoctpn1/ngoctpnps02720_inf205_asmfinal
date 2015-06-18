<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanLyKhachHang
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
        Me.btnSuaKH = New System.Windows.Forms.Button()
        Me.btnThoatKH = New System.Windows.Forms.Button()
        Me.lblQLKH = New System.Windows.Forms.Label()
        Me.btnXoaKH = New System.Windows.Forms.Button()
        Me.btnThemKH = New System.Windows.Forms.Button()
        Me.txtDiaChiKH = New System.Windows.Forms.TextBox()
        Me.txtSDTKH = New System.Windows.Forms.TextBox()
        Me.lblDiaChiKH = New System.Windows.Forms.Label()
        Me.lblSDTKH = New System.Windows.Forms.Label()
        Me.txtTenKH = New System.Windows.Forms.TextBox()
        Me.txtMaKH = New System.Windows.Forms.TextBox()
        Me.lblTenKH = New System.Windows.Forms.Label()
        Me.lblMaKH = New System.Windows.Forms.Label()
        Me.dgvDanhSachKH = New System.Windows.Forms.DataGridView()
        CType(Me.dgvDanhSachKH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSuaKH
        '
        Me.btnSuaKH.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnSuaKH.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnSuaKH.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnSuaKH.ForeColor = System.Drawing.SystemColors.Control
        Me.btnSuaKH.Image = Global.ngoctpnps02720_inf205_asmfinal.My.Resources.Resources.sửa
        Me.btnSuaKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSuaKH.Location = New System.Drawing.Point(561, 289)
        Me.btnSuaKH.Name = "btnSuaKH"
        Me.btnSuaKH.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnSuaKH.Size = New System.Drawing.Size(75, 30)
        Me.btnSuaKH.TabIndex = 10
        Me.btnSuaKH.Text = "Sửa   "
        Me.btnSuaKH.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSuaKH.UseVisualStyleBackColor = False
        '
        'btnThoatKH
        '
        Me.btnThoatKH.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnThoatKH.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnThoatKH.ForeColor = System.Drawing.SystemColors.Control
        Me.btnThoatKH.Image = Global.ngoctpnps02720_inf205_asmfinal.My.Resources.Resources.dialog_cancel
        Me.btnThoatKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThoatKH.Location = New System.Drawing.Point(606, 5)
        Me.btnThoatKH.Name = "btnThoatKH"
        Me.btnThoatKH.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnThoatKH.Size = New System.Drawing.Size(30, 30)
        Me.btnThoatKH.TabIndex = 13
        Me.btnThoatKH.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnThoatKH.UseVisualStyleBackColor = False
        '
        'lblQLKH
        '
        Me.lblQLKH.BackColor = System.Drawing.Color.Transparent
        Me.lblQLKH.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblQLKH.ForeColor = System.Drawing.SystemColors.Control
        Me.lblQLKH.Location = New System.Drawing.Point(170, 5)
        Me.lblQLKH.Name = "lblQLKH"
        Me.lblQLKH.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblQLKH.Size = New System.Drawing.Size(304, 39)
        Me.lblQLKH.TabIndex = 0
        Me.lblQLKH.Text = "Quản Lý Khách Hàng"
        Me.lblQLKH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnXoaKH
        '
        Me.btnXoaKH.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnXoaKH.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnXoaKH.ForeColor = System.Drawing.SystemColors.Control
        Me.btnXoaKH.Image = Global.ngoctpnps02720_inf205_asmfinal.My.Resources.Resources.eraser
        Me.btnXoaKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnXoaKH.Location = New System.Drawing.Point(561, 325)
        Me.btnXoaKH.Name = "btnXoaKH"
        Me.btnXoaKH.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnXoaKH.Size = New System.Drawing.Size(75, 30)
        Me.btnXoaKH.TabIndex = 11
        Me.btnXoaKH.Text = "Xóa   "
        Me.btnXoaKH.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnXoaKH.UseVisualStyleBackColor = False
        '
        'btnThemKH
        '
        Me.btnThemKH.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnThemKH.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnThemKH.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnThemKH.ForeColor = System.Drawing.SystemColors.Control
        Me.btnThemKH.Image = Global.ngoctpnps02720_inf205_asmfinal.My.Resources.Resources.thêm
        Me.btnThemKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThemKH.Location = New System.Drawing.Point(561, 253)
        Me.btnThemKH.Name = "btnThemKH"
        Me.btnThemKH.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnThemKH.Size = New System.Drawing.Size(75, 30)
        Me.btnThemKH.TabIndex = 9
        Me.btnThemKH.Text = "Thêm"
        Me.btnThemKH.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnThemKH.UseVisualStyleBackColor = False
        '
        'txtDiaChiKH
        '
        Me.txtDiaChiKH.BackColor = System.Drawing.Color.DodgerBlue
        Me.txtDiaChiKH.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtDiaChiKH.ForeColor = System.Drawing.SystemColors.Control
        Me.txtDiaChiKH.Location = New System.Drawing.Point(325, 192)
        Me.txtDiaChiKH.Multiline = True
        Me.txtDiaChiKH.Name = "txtDiaChiKH"
        Me.txtDiaChiKH.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDiaChiKH.Size = New System.Drawing.Size(230, 23)
        Me.txtDiaChiKH.TabIndex = 8
        '
        'txtSDTKH
        '
        Me.txtSDTKH.BackColor = System.Drawing.Color.DodgerBlue
        Me.txtSDTKH.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtSDTKH.ForeColor = System.Drawing.SystemColors.Control
        Me.txtSDTKH.Location = New System.Drawing.Point(325, 134)
        Me.txtSDTKH.Multiline = True
        Me.txtSDTKH.Name = "txtSDTKH"
        Me.txtSDTKH.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSDTKH.Size = New System.Drawing.Size(230, 23)
        Me.txtSDTKH.TabIndex = 7
        '
        'lblDiaChiKH
        '
        Me.lblDiaChiKH.BackColor = System.Drawing.Color.Transparent
        Me.lblDiaChiKH.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblDiaChiKH.ForeColor = System.Drawing.SystemColors.Control
        Me.lblDiaChiKH.Location = New System.Drawing.Point(325, 163)
        Me.lblDiaChiKH.Name = "lblDiaChiKH"
        Me.lblDiaChiKH.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDiaChiKH.Size = New System.Drawing.Size(115, 23)
        Me.lblDiaChiKH.TabIndex = 4
        Me.lblDiaChiKH.Text = "Địa Chỉ"
        Me.lblDiaChiKH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSDTKH
        '
        Me.lblSDTKH.BackColor = System.Drawing.Color.Transparent
        Me.lblSDTKH.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblSDTKH.ForeColor = System.Drawing.SystemColors.Control
        Me.lblSDTKH.Location = New System.Drawing.Point(325, 105)
        Me.lblSDTKH.Name = "lblSDTKH"
        Me.lblSDTKH.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSDTKH.Size = New System.Drawing.Size(115, 23)
        Me.lblSDTKH.TabIndex = 3
        Me.lblSDTKH.Text = "Số Điện Thoại"
        Me.lblSDTKH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTenKH
        '
        Me.txtTenKH.BackColor = System.Drawing.Color.DodgerBlue
        Me.txtTenKH.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtTenKH.ForeColor = System.Drawing.SystemColors.Control
        Me.txtTenKH.Location = New System.Drawing.Point(9, 192)
        Me.txtTenKH.Multiline = True
        Me.txtTenKH.Name = "txtTenKH"
        Me.txtTenKH.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTenKH.Size = New System.Drawing.Size(230, 23)
        Me.txtTenKH.TabIndex = 6
        '
        'txtMaKH
        '
        Me.txtMaKH.BackColor = System.Drawing.Color.DodgerBlue
        Me.txtMaKH.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtMaKH.ForeColor = System.Drawing.SystemColors.Control
        Me.txtMaKH.Location = New System.Drawing.Point(9, 134)
        Me.txtMaKH.Multiline = True
        Me.txtMaKH.Name = "txtMaKH"
        Me.txtMaKH.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMaKH.Size = New System.Drawing.Size(230, 23)
        Me.txtMaKH.TabIndex = 5
        '
        'lblTenKH
        '
        Me.lblTenKH.BackColor = System.Drawing.Color.Transparent
        Me.lblTenKH.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblTenKH.ForeColor = System.Drawing.SystemColors.Control
        Me.lblTenKH.Location = New System.Drawing.Point(9, 163)
        Me.lblTenKH.Name = "lblTenKH"
        Me.lblTenKH.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTenKH.Size = New System.Drawing.Size(115, 23)
        Me.lblTenKH.TabIndex = 2
        Me.lblTenKH.Text = "Tên Khách Hàng"
        Me.lblTenKH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMaKH
        '
        Me.lblMaKH.BackColor = System.Drawing.Color.Transparent
        Me.lblMaKH.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblMaKH.ForeColor = System.Drawing.SystemColors.Control
        Me.lblMaKH.Location = New System.Drawing.Point(9, 105)
        Me.lblMaKH.Name = "lblMaKH"
        Me.lblMaKH.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMaKH.Size = New System.Drawing.Size(115, 23)
        Me.lblMaKH.TabIndex = 1
        Me.lblMaKH.Text = "Mã Khách Hàng"
        Me.lblMaKH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvDanhSachKH
        '
        Me.dgvDanhSachKH.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDanhSachKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhSachKH.Location = New System.Drawing.Point(9, 253)
        Me.dgvDanhSachKH.Name = "dgvDanhSachKH"
        Me.dgvDanhSachKH.Size = New System.Drawing.Size(546, 102)
        Me.dgvDanhSachKH.TabIndex = 12
        '
        'frmQuanLyKhachHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ngoctpnps02720_inf205_asmfinal.My.Resources.Resources.hinh_nen
        Me.ClientSize = New System.Drawing.Size(644, 360)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSuaKH)
        Me.Controls.Add(Me.btnThoatKH)
        Me.Controls.Add(Me.lblQLKH)
        Me.Controls.Add(Me.btnXoaKH)
        Me.Controls.Add(Me.btnThemKH)
        Me.Controls.Add(Me.txtDiaChiKH)
        Me.Controls.Add(Me.txtSDTKH)
        Me.Controls.Add(Me.lblDiaChiKH)
        Me.Controls.Add(Me.lblSDTKH)
        Me.Controls.Add(Me.txtTenKH)
        Me.Controls.Add(Me.txtMaKH)
        Me.Controls.Add(Me.lblTenKH)
        Me.Controls.Add(Me.lblMaKH)
        Me.Controls.Add(Me.dgvDanhSachKH)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmQuanLyKhachHang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgvDanhSachKH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSuaKH As System.Windows.Forms.Button
    Friend WithEvents btnThoatKH As System.Windows.Forms.Button
    Friend WithEvents lblQLKH As System.Windows.Forms.Label
    Friend WithEvents btnXoaKH As System.Windows.Forms.Button
    Friend WithEvents btnThemKH As System.Windows.Forms.Button
    Friend WithEvents txtDiaChiKH As System.Windows.Forms.TextBox
    Friend WithEvents txtSDTKH As System.Windows.Forms.TextBox
    Friend WithEvents lblDiaChiKH As System.Windows.Forms.Label
    Friend WithEvents lblSDTKH As System.Windows.Forms.Label
    Friend WithEvents txtTenKH As System.Windows.Forms.TextBox
    Friend WithEvents txtMaKH As System.Windows.Forms.TextBox
    Friend WithEvents lblTenKH As System.Windows.Forms.Label
    Friend WithEvents lblMaKH As System.Windows.Forms.Label
    Friend WithEvents dgvDanhSachKH As System.Windows.Forms.DataGridView
End Class
