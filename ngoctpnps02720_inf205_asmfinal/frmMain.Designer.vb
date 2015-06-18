<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.btnThoatMain = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblTenDangNhap = New System.Windows.Forms.Label()
        Me.mnsMain = New System.Windows.Forms.MenuStrip()
        Me.mniHeThong = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniDangNhap = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniThoat = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniNhanVien = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniQuanTri = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniQLNV = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniQLKH = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniQLSP = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniQLLSP = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniQLHD = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniCTHD = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniHoTro = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnsMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnThoatMain
        '
        Me.btnThoatMain.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnThoatMain.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnThoatMain.ForeColor = System.Drawing.SystemColors.Control
        Me.btnThoatMain.Image = Global.ngoctpnps02720_inf205_asmfinal.My.Resources.Resources.dialog_cancel
        Me.btnThoatMain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThoatMain.Location = New System.Drawing.Point(614, 0)
        Me.btnThoatMain.Name = "btnThoatMain"
        Me.btnThoatMain.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnThoatMain.Size = New System.Drawing.Size(30, 30)
        Me.btnThoatMain.TabIndex = 21
        Me.btnThoatMain.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnThoatMain.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(373, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(144, 50)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Bán Hàng"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(137, 166)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(128, 50)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Quản Lý"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = Global.ngoctpnps02720_inf205_asmfinal.My.Resources.Resources.cart
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(235, 132)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(162, 118)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'lblTenDangNhap
        '
        Me.lblTenDangNhap.BackColor = System.Drawing.Color.Transparent
        Me.lblTenDangNhap.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblTenDangNhap.ForeColor = System.Drawing.SystemColors.Control
        Me.lblTenDangNhap.Location = New System.Drawing.Point(462, 337)
        Me.lblTenDangNhap.Name = "lblTenDangNhap"
        Me.lblTenDangNhap.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTenDangNhap.Size = New System.Drawing.Size(182, 23)
        Me.lblTenDangNhap.TabIndex = 17
        Me.lblTenDangNhap.Text = "pt10102_ngoctpnps02720_inf205"
        Me.lblTenDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'mnsMain
        '
        Me.mnsMain.AutoSize = False
        Me.mnsMain.BackColor = System.Drawing.Color.DodgerBlue
        Me.mnsMain.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.mnsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniHeThong, Me.mniNhanVien, Me.mniQuanTri, Me.mniHoTro})
        Me.mnsMain.Location = New System.Drawing.Point(0, 0)
        Me.mnsMain.Name = "mnsMain"
        Me.mnsMain.Size = New System.Drawing.Size(644, 30)
        Me.mnsMain.TabIndex = 16
        '
        'mniHeThong
        '
        Me.mniHeThong.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniDangNhap, Me.mniThoat})
        Me.mniHeThong.ForeColor = System.Drawing.SystemColors.Control
        Me.mniHeThong.Image = Global.ngoctpnps02720_inf205_asmfinal.My.Resources.Resources.system
        Me.mniHeThong.Name = "mniHeThong"
        Me.mniHeThong.Size = New System.Drawing.Size(97, 26)
        Me.mniHeThong.Text = "Hệ Thống"
        '
        'mniDangNhap
        '
        Me.mniDangNhap.Name = "mniDangNhap"
        Me.mniDangNhap.Size = New System.Drawing.Size(146, 22)
        Me.mniDangNhap.Text = "Đăng Nhập"
        '
        'mniThoat
        '
        Me.mniThoat.Name = "mniThoat"
        Me.mniThoat.Size = New System.Drawing.Size(146, 22)
        Me.mniThoat.Text = "Thoát"
        '
        'mniNhanVien
        '
        Me.mniNhanVien.ForeColor = System.Drawing.SystemColors.Control
        Me.mniNhanVien.Image = Global.ngoctpnps02720_inf205_asmfinal.My.Resources.Resources.Nhan_vien
        Me.mniNhanVien.Name = "mniNhanVien"
        Me.mniNhanVien.Size = New System.Drawing.Size(101, 26)
        Me.mniNhanVien.Text = "Nhân Viên"
        '
        'mniQuanTri
        '
        Me.mniQuanTri.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniQLNV, Me.mniQLKH, Me.mniQLSP, Me.mniQLLSP, Me.mniQLHD})
        Me.mniQuanTri.ForeColor = System.Drawing.SystemColors.Control
        Me.mniQuanTri.Image = Global.ngoctpnps02720_inf205_asmfinal.My.Resources.Resources.quan_tri
        Me.mniQuanTri.Name = "mniQuanTri"
        Me.mniQuanTri.Size = New System.Drawing.Size(90, 26)
        Me.mniQuanTri.Text = "Quản Trị"
        '
        'mniQLNV
        '
        Me.mniQLNV.Name = "mniQLNV"
        Me.mniQLNV.Size = New System.Drawing.Size(222, 22)
        Me.mniQLNV.Text = "Quản Lý Nhân viên"
        '
        'mniQLKH
        '
        Me.mniQLKH.Name = "mniQLKH"
        Me.mniQLKH.Size = New System.Drawing.Size(222, 22)
        Me.mniQLKH.Text = "Quản Lý Khách Hàng"
        '
        'mniQLSP
        '
        Me.mniQLSP.Name = "mniQLSP"
        Me.mniQLSP.Size = New System.Drawing.Size(222, 22)
        Me.mniQLSP.Text = "Quản Lý Sản Phẩm"
        '
        'mniQLLSP
        '
        Me.mniQLLSP.Name = "mniQLLSP"
        Me.mniQLLSP.Size = New System.Drawing.Size(222, 22)
        Me.mniQLLSP.Text = "Quản Lý Loại Sản Phẩm"
        '
        'mniQLHD
        '
        Me.mniQLHD.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniCTHD})
        Me.mniQLHD.Name = "mniQLHD"
        Me.mniQLHD.Size = New System.Drawing.Size(222, 22)
        Me.mniQLHD.Text = "Quản Lý Hoá Đơn"
        '
        'mniCTHD
        '
        Me.mniCTHD.Name = "mniCTHD"
        Me.mniCTHD.Size = New System.Drawing.Size(183, 22)
        Me.mniCTHD.Text = "Chi Tiết Hoá Đơn"
        '
        'mniHoTro
        '
        Me.mniHoTro.ForeColor = System.Drawing.SystemColors.Control
        Me.mniHoTro.Image = Global.ngoctpnps02720_inf205_asmfinal.My.Resources.Resources.hotro
        Me.mniHoTro.Name = "mniHoTro"
        Me.mniHoTro.Size = New System.Drawing.Size(79, 26)
        Me.mniHoTro.Text = "Hỗ Trợ"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ngoctpnps02720_inf205_asmfinal.My.Resources.Resources.hinh_nen
        Me.ClientSize = New System.Drawing.Size(644, 360)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnThoatMain)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblTenDangNhap)
        Me.Controls.Add(Me.mnsMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnsMain.ResumeLayout(False)
        Me.mnsMain.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnThoatMain As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblTenDangNhap As System.Windows.Forms.Label
    Friend WithEvents mnsMain As System.Windows.Forms.MenuStrip
    Friend WithEvents mniHeThong As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniDangNhap As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniThoat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniNhanVien As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniQuanTri As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniQLNV As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniQLKH As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniQLSP As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniQLLSP As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniHoTro As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniQLHD As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniCTHD As System.Windows.Forms.ToolStripMenuItem
End Class
