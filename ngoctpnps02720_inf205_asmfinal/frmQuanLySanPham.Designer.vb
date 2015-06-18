<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanLySanPham
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
        Me.btnSuaSP = New System.Windows.Forms.Button()
        Me.txtDonGia = New System.Windows.Forms.TextBox()
        Me.lblDonGia = New System.Windows.Forms.Label()
        Me.btnThoatSP = New System.Windows.Forms.Button()
        Me.btnXoaSP = New System.Windows.Forms.Button()
        Me.btnThemSP = New System.Windows.Forms.Button()
        Me.txtSoLuong = New System.Windows.Forms.TextBox()
        Me.txtChiTiet = New System.Windows.Forms.TextBox()
        Me.lblSoLuong = New System.Windows.Forms.Label()
        Me.lblChiTiet = New System.Windows.Forms.Label()
        Me.txtTenSP = New System.Windows.Forms.TextBox()
        Me.txtMaSP = New System.Windows.Forms.TextBox()
        Me.lblTenSP = New System.Windows.Forms.Label()
        Me.lblMaSP = New System.Windows.Forms.Label()
        Me.dgvDanhSachSP = New System.Windows.Forms.DataGridView()
        Me.lblQLSP = New System.Windows.Forms.Label()
        Me.txtMaLoaiSP = New System.Windows.Forms.TextBox()
        Me.lblMaLoaiSP = New System.Windows.Forms.Label()
        CType(Me.dgvDanhSachSP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSuaSP
        '
        Me.btnSuaSP.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnSuaSP.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnSuaSP.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnSuaSP.ForeColor = System.Drawing.SystemColors.Control
        Me.btnSuaSP.Image = Global.ngoctpnps02720_inf205_asmfinal.My.Resources.Resources.sửa
        Me.btnSuaSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSuaSP.Location = New System.Drawing.Point(562, 289)
        Me.btnSuaSP.Name = "btnSuaSP"
        Me.btnSuaSP.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnSuaSP.Size = New System.Drawing.Size(75, 30)
        Me.btnSuaSP.TabIndex = 14
        Me.btnSuaSP.Text = "Sửa   "
        Me.btnSuaSP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSuaSP.UseVisualStyleBackColor = False
        '
        'txtDonGia
        '
        Me.txtDonGia.BackColor = System.Drawing.Color.DodgerBlue
        Me.txtDonGia.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtDonGia.ForeColor = System.Drawing.SystemColors.Control
        Me.txtDonGia.Location = New System.Drawing.Point(507, 131)
        Me.txtDonGia.Multiline = True
        Me.txtDonGia.Name = "txtDonGia"
        Me.txtDonGia.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDonGia.Size = New System.Drawing.Size(130, 23)
        Me.txtDonGia.TabIndex = 9
        '
        'lblDonGia
        '
        Me.lblDonGia.BackColor = System.Drawing.Color.Transparent
        Me.lblDonGia.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblDonGia.ForeColor = System.Drawing.SystemColors.Control
        Me.lblDonGia.Location = New System.Drawing.Point(507, 102)
        Me.lblDonGia.Name = "lblDonGia"
        Me.lblDonGia.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDonGia.Size = New System.Drawing.Size(115, 23)
        Me.lblDonGia.TabIndex = 3
        Me.lblDonGia.Text = "Đơn Giá"
        Me.lblDonGia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnThoatSP
        '
        Me.btnThoatSP.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnThoatSP.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnThoatSP.ForeColor = System.Drawing.SystemColors.Control
        Me.btnThoatSP.Image = Global.ngoctpnps02720_inf205_asmfinal.My.Resources.Resources.dialog_cancel
        Me.btnThoatSP.Location = New System.Drawing.Point(607, 21)
        Me.btnThoatSP.Name = "btnThoatSP"
        Me.btnThoatSP.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnThoatSP.Size = New System.Drawing.Size(30, 30)
        Me.btnThoatSP.TabIndex = 17
        Me.btnThoatSP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnThoatSP.UseVisualStyleBackColor = False
        '
        'btnXoaSP
        '
        Me.btnXoaSP.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnXoaSP.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnXoaSP.ForeColor = System.Drawing.SystemColors.Control
        Me.btnXoaSP.Image = Global.ngoctpnps02720_inf205_asmfinal.My.Resources.Resources.eraser
        Me.btnXoaSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnXoaSP.Location = New System.Drawing.Point(562, 325)
        Me.btnXoaSP.Name = "btnXoaSP"
        Me.btnXoaSP.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnXoaSP.Size = New System.Drawing.Size(75, 30)
        Me.btnXoaSP.TabIndex = 15
        Me.btnXoaSP.Text = "Xóa   "
        Me.btnXoaSP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnXoaSP.UseVisualStyleBackColor = False
        '
        'btnThemSP
        '
        Me.btnThemSP.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnThemSP.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnThemSP.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnThemSP.ForeColor = System.Drawing.SystemColors.Control
        Me.btnThemSP.Image = Global.ngoctpnps02720_inf205_asmfinal.My.Resources.Resources.thêm
        Me.btnThemSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThemSP.Location = New System.Drawing.Point(562, 253)
        Me.btnThemSP.Name = "btnThemSP"
        Me.btnThemSP.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnThemSP.Size = New System.Drawing.Size(75, 30)
        Me.btnThemSP.TabIndex = 13
        Me.btnThemSP.Text = "Thêm"
        Me.btnThemSP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnThemSP.UseVisualStyleBackColor = False
        '
        'txtSoLuong
        '
        Me.txtSoLuong.BackColor = System.Drawing.Color.DodgerBlue
        Me.txtSoLuong.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtSoLuong.ForeColor = System.Drawing.SystemColors.Control
        Me.txtSoLuong.Location = New System.Drawing.Point(7, 209)
        Me.txtSoLuong.Multiline = True
        Me.txtSoLuong.Name = "txtSoLuong"
        Me.txtSoLuong.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSoLuong.Size = New System.Drawing.Size(130, 23)
        Me.txtSoLuong.TabIndex = 10
        '
        'txtChiTiet
        '
        Me.txtChiTiet.BackColor = System.Drawing.Color.DodgerBlue
        Me.txtChiTiet.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtChiTiet.ForeColor = System.Drawing.SystemColors.Control
        Me.txtChiTiet.Location = New System.Drawing.Point(254, 209)
        Me.txtChiTiet.Multiline = True
        Me.txtChiTiet.Name = "txtChiTiet"
        Me.txtChiTiet.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtChiTiet.Size = New System.Drawing.Size(130, 23)
        Me.txtChiTiet.TabIndex = 11
        '
        'lblSoLuong
        '
        Me.lblSoLuong.BackColor = System.Drawing.Color.Transparent
        Me.lblSoLuong.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblSoLuong.ForeColor = System.Drawing.SystemColors.Control
        Me.lblSoLuong.Location = New System.Drawing.Point(7, 180)
        Me.lblSoLuong.Name = "lblSoLuong"
        Me.lblSoLuong.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSoLuong.Size = New System.Drawing.Size(130, 23)
        Me.lblSoLuong.TabIndex = 4
        Me.lblSoLuong.Text = "Số Lượng"
        Me.lblSoLuong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblChiTiet
        '
        Me.lblChiTiet.BackColor = System.Drawing.Color.Transparent
        Me.lblChiTiet.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblChiTiet.ForeColor = System.Drawing.SystemColors.Control
        Me.lblChiTiet.Location = New System.Drawing.Point(254, 180)
        Me.lblChiTiet.Name = "lblChiTiet"
        Me.lblChiTiet.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblChiTiet.Size = New System.Drawing.Size(115, 23)
        Me.lblChiTiet.TabIndex = 5
        Me.lblChiTiet.Text = "Chi Tiết"
        Me.lblChiTiet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTenSP
        '
        Me.txtTenSP.BackColor = System.Drawing.Color.DodgerBlue
        Me.txtTenSP.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtTenSP.ForeColor = System.Drawing.SystemColors.Control
        Me.txtTenSP.Location = New System.Drawing.Point(254, 131)
        Me.txtTenSP.Multiline = True
        Me.txtTenSP.Name = "txtTenSP"
        Me.txtTenSP.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTenSP.Size = New System.Drawing.Size(130, 23)
        Me.txtTenSP.TabIndex = 8
        '
        'txtMaSP
        '
        Me.txtMaSP.BackColor = System.Drawing.Color.DodgerBlue
        Me.txtMaSP.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtMaSP.ForeColor = System.Drawing.SystemColors.Control
        Me.txtMaSP.Location = New System.Drawing.Point(7, 131)
        Me.txtMaSP.Multiline = True
        Me.txtMaSP.Name = "txtMaSP"
        Me.txtMaSP.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMaSP.Size = New System.Drawing.Size(130, 23)
        Me.txtMaSP.TabIndex = 7
        '
        'lblTenSP
        '
        Me.lblTenSP.BackColor = System.Drawing.Color.Transparent
        Me.lblTenSP.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblTenSP.ForeColor = System.Drawing.SystemColors.Control
        Me.lblTenSP.Location = New System.Drawing.Point(254, 102)
        Me.lblTenSP.Name = "lblTenSP"
        Me.lblTenSP.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTenSP.Size = New System.Drawing.Size(115, 23)
        Me.lblTenSP.TabIndex = 2
        Me.lblTenSP.Text = "Tên Sản Phẩm"
        Me.lblTenSP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMaSP
        '
        Me.lblMaSP.BackColor = System.Drawing.Color.Transparent
        Me.lblMaSP.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblMaSP.ForeColor = System.Drawing.SystemColors.Control
        Me.lblMaSP.Location = New System.Drawing.Point(7, 102)
        Me.lblMaSP.Name = "lblMaSP"
        Me.lblMaSP.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMaSP.Size = New System.Drawing.Size(115, 23)
        Me.lblMaSP.TabIndex = 1
        Me.lblMaSP.Text = "Mã Sản Phẩm"
        Me.lblMaSP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvDanhSachSP
        '
        Me.dgvDanhSachSP.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDanhSachSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDanhSachSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhSachSP.Location = New System.Drawing.Point(7, 253)
        Me.dgvDanhSachSP.Name = "dgvDanhSachSP"
        Me.dgvDanhSachSP.Size = New System.Drawing.Size(549, 103)
        Me.dgvDanhSachSP.TabIndex = 16
        '
        'lblQLSP
        '
        Me.lblQLSP.BackColor = System.Drawing.Color.Transparent
        Me.lblQLSP.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblQLSP.ForeColor = System.Drawing.SystemColors.Control
        Me.lblQLSP.Location = New System.Drawing.Point(174, 5)
        Me.lblQLSP.Name = "lblQLSP"
        Me.lblQLSP.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblQLSP.Size = New System.Drawing.Size(290, 50)
        Me.lblQLSP.TabIndex = 0
        Me.lblQLSP.Text = "Quản Lý Sản Phẩm"
        Me.lblQLSP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtMaLoaiSP
        '
        Me.txtMaLoaiSP.BackColor = System.Drawing.Color.DodgerBlue
        Me.txtMaLoaiSP.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtMaLoaiSP.ForeColor = System.Drawing.SystemColors.Control
        Me.txtMaLoaiSP.Location = New System.Drawing.Point(507, 209)
        Me.txtMaLoaiSP.Multiline = True
        Me.txtMaLoaiSP.Name = "txtMaLoaiSP"
        Me.txtMaLoaiSP.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMaLoaiSP.Size = New System.Drawing.Size(130, 23)
        Me.txtMaLoaiSP.TabIndex = 12
        '
        'lblMaLoaiSP
        '
        Me.lblMaLoaiSP.BackColor = System.Drawing.Color.Transparent
        Me.lblMaLoaiSP.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblMaLoaiSP.ForeColor = System.Drawing.SystemColors.Control
        Me.lblMaLoaiSP.Location = New System.Drawing.Point(507, 180)
        Me.lblMaLoaiSP.Name = "lblMaLoaiSP"
        Me.lblMaLoaiSP.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMaLoaiSP.Size = New System.Drawing.Size(115, 23)
        Me.lblMaLoaiSP.TabIndex = 6
        Me.lblMaLoaiSP.Text = "Mã Loại"
        Me.lblMaLoaiSP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmQuanLySanPham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ngoctpnps02720_inf205_asmfinal.My.Resources.Resources.hinh_nen
        Me.ClientSize = New System.Drawing.Size(644, 360)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtMaLoaiSP)
        Me.Controls.Add(Me.lblMaLoaiSP)
        Me.Controls.Add(Me.btnSuaSP)
        Me.Controls.Add(Me.txtDonGia)
        Me.Controls.Add(Me.lblDonGia)
        Me.Controls.Add(Me.btnThoatSP)
        Me.Controls.Add(Me.btnXoaSP)
        Me.Controls.Add(Me.btnThemSP)
        Me.Controls.Add(Me.txtSoLuong)
        Me.Controls.Add(Me.txtChiTiet)
        Me.Controls.Add(Me.lblSoLuong)
        Me.Controls.Add(Me.lblChiTiet)
        Me.Controls.Add(Me.txtTenSP)
        Me.Controls.Add(Me.txtMaSP)
        Me.Controls.Add(Me.lblTenSP)
        Me.Controls.Add(Me.lblMaSP)
        Me.Controls.Add(Me.dgvDanhSachSP)
        Me.Controls.Add(Me.lblQLSP)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmQuanLySanPham"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgvDanhSachSP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSuaSP As System.Windows.Forms.Button
    Friend WithEvents txtDonGia As System.Windows.Forms.TextBox
    Friend WithEvents lblDonGia As System.Windows.Forms.Label
    Friend WithEvents btnThoatSP As System.Windows.Forms.Button
    Friend WithEvents btnXoaSP As System.Windows.Forms.Button
    Friend WithEvents btnThemSP As System.Windows.Forms.Button
    Friend WithEvents txtSoLuong As System.Windows.Forms.TextBox
    Friend WithEvents txtChiTiet As System.Windows.Forms.TextBox
    Friend WithEvents lblSoLuong As System.Windows.Forms.Label
    Friend WithEvents lblChiTiet As System.Windows.Forms.Label
    Friend WithEvents txtTenSP As System.Windows.Forms.TextBox
    Friend WithEvents txtMaSP As System.Windows.Forms.TextBox
    Friend WithEvents lblTenSP As System.Windows.Forms.Label
    Friend WithEvents lblMaSP As System.Windows.Forms.Label
    Friend WithEvents dgvDanhSachSP As System.Windows.Forms.DataGridView
    Friend WithEvents lblQLSP As System.Windows.Forms.Label
    Friend WithEvents txtMaLoaiSP As System.Windows.Forms.TextBox
    Friend WithEvents lblMaLoaiSP As System.Windows.Forms.Label
End Class
