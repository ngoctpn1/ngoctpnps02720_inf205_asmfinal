<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanLyHoaDon
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
        Me.btnSuaHD = New System.Windows.Forms.Button()
        Me.txtMaKHHD = New System.Windows.Forms.TextBox()
        Me.lblMaKHHD = New System.Windows.Forms.Label()
        Me.btnThoatHD = New System.Windows.Forms.Button()
        Me.btnXoaHD = New System.Windows.Forms.Button()
        Me.btnThemHD = New System.Windows.Forms.Button()
        Me.txtMaNVHD = New System.Windows.Forms.TextBox()
        Me.txtTongTien = New System.Windows.Forms.TextBox()
        Me.lblMaNVHD = New System.Windows.Forms.Label()
        Me.lblTongTien = New System.Windows.Forms.Label()
        Me.txtNgayLap = New System.Windows.Forms.TextBox()
        Me.txtMaHD = New System.Windows.Forms.TextBox()
        Me.lblNgayLap = New System.Windows.Forms.Label()
        Me.lblMaHD = New System.Windows.Forms.Label()
        Me.dgvDanhSachHD = New System.Windows.Forms.DataGridView()
        Me.lblQLHD = New System.Windows.Forms.Label()
        CType(Me.dgvDanhSachHD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSuaHD
        '
        Me.btnSuaHD.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnSuaHD.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnSuaHD.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnSuaHD.ForeColor = System.Drawing.SystemColors.Control
        Me.btnSuaHD.Image = Global.ngoctpnps02720_inf205_asmfinal.My.Resources.Resources.sửa
        Me.btnSuaHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSuaHD.Location = New System.Drawing.Point(565, 294)
        Me.btnSuaHD.Name = "btnSuaHD"
        Me.btnSuaHD.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnSuaHD.Size = New System.Drawing.Size(75, 30)
        Me.btnSuaHD.TabIndex = 12
        Me.btnSuaHD.Text = "Sửa   "
        Me.btnSuaHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSuaHD.UseVisualStyleBackColor = False
        '
        'txtMaKHHD
        '
        Me.txtMaKHHD.BackColor = System.Drawing.Color.DodgerBlue
        Me.txtMaKHHD.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtMaKHHD.ForeColor = System.Drawing.SystemColors.Control
        Me.txtMaKHHD.Location = New System.Drawing.Point(252, 194)
        Me.txtMaKHHD.Multiline = True
        Me.txtMaKHHD.Name = "txtMaKHHD"
        Me.txtMaKHHD.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMaKHHD.Size = New System.Drawing.Size(130, 23)
        Me.txtMaKHHD.TabIndex = 9
        '
        'lblMaKHHD
        '
        Me.lblMaKHHD.BackColor = System.Drawing.Color.Transparent
        Me.lblMaKHHD.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblMaKHHD.ForeColor = System.Drawing.SystemColors.Control
        Me.lblMaKHHD.Location = New System.Drawing.Point(252, 165)
        Me.lblMaKHHD.Name = "lblMaKHHD"
        Me.lblMaKHHD.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMaKHHD.Size = New System.Drawing.Size(115, 23)
        Me.lblMaKHHD.TabIndex = 4
        Me.lblMaKHHD.Text = "Mã Khách Hàng"
        Me.lblMaKHHD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnThoatHD
        '
        Me.btnThoatHD.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnThoatHD.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnThoatHD.ForeColor = System.Drawing.SystemColors.Control
        Me.btnThoatHD.Image = Global.ngoctpnps02720_inf205_asmfinal.My.Resources.Resources.dialog_cancel
        Me.btnThoatHD.Location = New System.Drawing.Point(610, 1)
        Me.btnThoatHD.Name = "btnThoatHD"
        Me.btnThoatHD.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnThoatHD.Size = New System.Drawing.Size(30, 30)
        Me.btnThoatHD.TabIndex = 15
        Me.btnThoatHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnThoatHD.UseVisualStyleBackColor = False
        '
        'btnXoaHD
        '
        Me.btnXoaHD.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnXoaHD.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnXoaHD.ForeColor = System.Drawing.SystemColors.Control
        Me.btnXoaHD.Image = Global.ngoctpnps02720_inf205_asmfinal.My.Resources.Resources.eraser
        Me.btnXoaHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnXoaHD.Location = New System.Drawing.Point(565, 330)
        Me.btnXoaHD.Name = "btnXoaHD"
        Me.btnXoaHD.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnXoaHD.Size = New System.Drawing.Size(75, 30)
        Me.btnXoaHD.TabIndex = 13
        Me.btnXoaHD.Text = "Xóa   "
        Me.btnXoaHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnXoaHD.UseVisualStyleBackColor = False
        '
        'btnThemHD
        '
        Me.btnThemHD.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnThemHD.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnThemHD.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnThemHD.ForeColor = System.Drawing.SystemColors.Control
        Me.btnThemHD.Image = Global.ngoctpnps02720_inf205_asmfinal.My.Resources.Resources.thêm
        Me.btnThemHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThemHD.Location = New System.Drawing.Point(565, 258)
        Me.btnThemHD.Name = "btnThemHD"
        Me.btnThemHD.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnThemHD.Size = New System.Drawing.Size(75, 30)
        Me.btnThemHD.TabIndex = 11
        Me.btnThemHD.Text = "Thêm"
        Me.btnThemHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnThemHD.UseVisualStyleBackColor = False
        '
        'txtMaNVHD
        '
        Me.txtMaNVHD.BackColor = System.Drawing.Color.DodgerBlue
        Me.txtMaNVHD.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtMaNVHD.ForeColor = System.Drawing.SystemColors.Control
        Me.txtMaNVHD.Location = New System.Drawing.Point(450, 194)
        Me.txtMaNVHD.Multiline = True
        Me.txtMaNVHD.Name = "txtMaNVHD"
        Me.txtMaNVHD.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMaNVHD.Size = New System.Drawing.Size(130, 23)
        Me.txtMaNVHD.TabIndex = 10
        '
        'txtTongTien
        '
        Me.txtTongTien.BackColor = System.Drawing.Color.DodgerBlue
        Me.txtTongTien.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtTongTien.ForeColor = System.Drawing.SystemColors.Control
        Me.txtTongTien.Location = New System.Drawing.Point(382, 128)
        Me.txtTongTien.Multiline = True
        Me.txtTongTien.Name = "txtTongTien"
        Me.txtTongTien.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTongTien.Size = New System.Drawing.Size(130, 23)
        Me.txtTongTien.TabIndex = 7
        '
        'lblMaNVHD
        '
        Me.lblMaNVHD.BackColor = System.Drawing.Color.Transparent
        Me.lblMaNVHD.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblMaNVHD.ForeColor = System.Drawing.SystemColors.Control
        Me.lblMaNVHD.Location = New System.Drawing.Point(450, 165)
        Me.lblMaNVHD.Name = "lblMaNVHD"
        Me.lblMaNVHD.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMaNVHD.Size = New System.Drawing.Size(115, 23)
        Me.lblMaNVHD.TabIndex = 5
        Me.lblMaNVHD.Text = "Mã Nhân Viên"
        Me.lblMaNVHD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTongTien
        '
        Me.lblTongTien.BackColor = System.Drawing.Color.Transparent
        Me.lblTongTien.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblTongTien.ForeColor = System.Drawing.SystemColors.Control
        Me.lblTongTien.Location = New System.Drawing.Point(382, 99)
        Me.lblTongTien.Name = "lblTongTien"
        Me.lblTongTien.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTongTien.Size = New System.Drawing.Size(115, 23)
        Me.lblTongTien.TabIndex = 2
        Me.lblTongTien.Text = "Tổng Tiền"
        Me.lblTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNgayLap
        '
        Me.txtNgayLap.BackColor = System.Drawing.Color.DodgerBlue
        Me.txtNgayLap.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtNgayLap.ForeColor = System.Drawing.SystemColors.Control
        Me.txtNgayLap.Location = New System.Drawing.Point(55, 194)
        Me.txtNgayLap.Multiline = True
        Me.txtNgayLap.Name = "txtNgayLap"
        Me.txtNgayLap.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNgayLap.Size = New System.Drawing.Size(130, 23)
        Me.txtNgayLap.TabIndex = 8
        '
        'txtMaHD
        '
        Me.txtMaHD.BackColor = System.Drawing.Color.DodgerBlue
        Me.txtMaHD.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtMaHD.ForeColor = System.Drawing.SystemColors.Control
        Me.txtMaHD.Location = New System.Drawing.Point(123, 128)
        Me.txtMaHD.Multiline = True
        Me.txtMaHD.Name = "txtMaHD"
        Me.txtMaHD.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMaHD.Size = New System.Drawing.Size(130, 23)
        Me.txtMaHD.TabIndex = 6
        '
        'lblNgayLap
        '
        Me.lblNgayLap.BackColor = System.Drawing.Color.Transparent
        Me.lblNgayLap.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblNgayLap.ForeColor = System.Drawing.SystemColors.Control
        Me.lblNgayLap.Location = New System.Drawing.Point(55, 165)
        Me.lblNgayLap.Name = "lblNgayLap"
        Me.lblNgayLap.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNgayLap.Size = New System.Drawing.Size(115, 23)
        Me.lblNgayLap.TabIndex = 3
        Me.lblNgayLap.Text = "Ngày Lập"
        Me.lblNgayLap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMaHD
        '
        Me.lblMaHD.BackColor = System.Drawing.Color.Transparent
        Me.lblMaHD.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblMaHD.ForeColor = System.Drawing.SystemColors.Control
        Me.lblMaHD.Location = New System.Drawing.Point(123, 99)
        Me.lblMaHD.Name = "lblMaHD"
        Me.lblMaHD.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMaHD.Size = New System.Drawing.Size(115, 23)
        Me.lblMaHD.TabIndex = 1
        Me.lblMaHD.Text = "Mã Hoá Đơn"
        Me.lblMaHD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvDanhSachHD
        '
        Me.dgvDanhSachHD.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDanhSachHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDanhSachHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhSachHD.Location = New System.Drawing.Point(5, 258)
        Me.dgvDanhSachHD.Name = "dgvDanhSachHD"
        Me.dgvDanhSachHD.Size = New System.Drawing.Size(554, 102)
        Me.dgvDanhSachHD.TabIndex = 14
        '
        'lblQLHD
        '
        Me.lblQLHD.BackColor = System.Drawing.Color.Transparent
        Me.lblQLHD.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblQLHD.ForeColor = System.Drawing.SystemColors.Control
        Me.lblQLHD.Location = New System.Drawing.Point(172, 1)
        Me.lblQLHD.Name = "lblQLHD"
        Me.lblQLHD.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblQLHD.Size = New System.Drawing.Size(290, 50)
        Me.lblQLHD.TabIndex = 0
        Me.lblQLHD.Text = "Quản Lý Hoá Đơn"
        Me.lblQLHD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmQuanLyHoaDon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ngoctpnps02720_inf205_asmfinal.My.Resources.Resources.hinh_nen
        Me.ClientSize = New System.Drawing.Size(644, 360)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSuaHD)
        Me.Controls.Add(Me.txtMaKHHD)
        Me.Controls.Add(Me.lblMaKHHD)
        Me.Controls.Add(Me.btnThoatHD)
        Me.Controls.Add(Me.btnXoaHD)
        Me.Controls.Add(Me.btnThemHD)
        Me.Controls.Add(Me.txtMaNVHD)
        Me.Controls.Add(Me.txtTongTien)
        Me.Controls.Add(Me.lblMaNVHD)
        Me.Controls.Add(Me.lblTongTien)
        Me.Controls.Add(Me.txtNgayLap)
        Me.Controls.Add(Me.txtMaHD)
        Me.Controls.Add(Me.lblNgayLap)
        Me.Controls.Add(Me.lblMaHD)
        Me.Controls.Add(Me.dgvDanhSachHD)
        Me.Controls.Add(Me.lblQLHD)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmQuanLyHoaDon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgvDanhSachHD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSuaHD As System.Windows.Forms.Button
    Friend WithEvents txtMaKHHD As System.Windows.Forms.TextBox
    Friend WithEvents lblMaKHHD As System.Windows.Forms.Label
    Friend WithEvents btnThoatHD As System.Windows.Forms.Button
    Friend WithEvents btnXoaHD As System.Windows.Forms.Button
    Friend WithEvents btnThemHD As System.Windows.Forms.Button
    Friend WithEvents txtMaNVHD As System.Windows.Forms.TextBox
    Friend WithEvents txtTongTien As System.Windows.Forms.TextBox
    Friend WithEvents lblMaNVHD As System.Windows.Forms.Label
    Friend WithEvents lblTongTien As System.Windows.Forms.Label
    Friend WithEvents txtNgayLap As System.Windows.Forms.TextBox
    Friend WithEvents txtMaHD As System.Windows.Forms.TextBox
    Friend WithEvents lblNgayLap As System.Windows.Forms.Label
    Friend WithEvents lblMaHD As System.Windows.Forms.Label
    Friend WithEvents dgvDanhSachHD As System.Windows.Forms.DataGridView
    Friend WithEvents lblQLHD As System.Windows.Forms.Label
End Class
