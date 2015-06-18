<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChiTietHoaDon
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
        Me.btnSuaCTHD = New System.Windows.Forms.Button()
        Me.btnThoatCTHD = New System.Windows.Forms.Button()
        Me.lblQLCTHD = New System.Windows.Forms.Label()
        Me.btnXoaCTHD = New System.Windows.Forms.Button()
        Me.btnThemCTHD = New System.Windows.Forms.Button()
        Me.txtMaSPCTHD = New System.Windows.Forms.TextBox()
        Me.txtSoLuongCTHD = New System.Windows.Forms.TextBox()
        Me.lblMaSPCTHD = New System.Windows.Forms.Label()
        Me.lblSoLuongCTHD = New System.Windows.Forms.Label()
        Me.txtMaHDCTHD = New System.Windows.Forms.TextBox()
        Me.txtMaCTHD = New System.Windows.Forms.TextBox()
        Me.lblMaHDCTHD = New System.Windows.Forms.Label()
        Me.lblMaCTHD = New System.Windows.Forms.Label()
        Me.dgvDanhSachCTHD = New System.Windows.Forms.DataGridView()
        CType(Me.dgvDanhSachCTHD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSuaCTHD
        '
        Me.btnSuaCTHD.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnSuaCTHD.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnSuaCTHD.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnSuaCTHD.ForeColor = System.Drawing.SystemColors.Control
        Me.btnSuaCTHD.Image = Global.ngoctpnps02720_inf205_asmfinal.My.Resources.Resources.sửa
        Me.btnSuaCTHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSuaCTHD.Location = New System.Drawing.Point(561, 289)
        Me.btnSuaCTHD.Name = "btnSuaCTHD"
        Me.btnSuaCTHD.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnSuaCTHD.Size = New System.Drawing.Size(75, 30)
        Me.btnSuaCTHD.TabIndex = 10
        Me.btnSuaCTHD.Text = "Sửa   "
        Me.btnSuaCTHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSuaCTHD.UseVisualStyleBackColor = False
        '
        'btnThoatCTHD
        '
        Me.btnThoatCTHD.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnThoatCTHD.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnThoatCTHD.ForeColor = System.Drawing.SystemColors.Control
        Me.btnThoatCTHD.Image = Global.ngoctpnps02720_inf205_asmfinal.My.Resources.Resources.dialog_cancel
        Me.btnThoatCTHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThoatCTHD.Location = New System.Drawing.Point(606, 5)
        Me.btnThoatCTHD.Name = "btnThoatCTHD"
        Me.btnThoatCTHD.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnThoatCTHD.Size = New System.Drawing.Size(30, 30)
        Me.btnThoatCTHD.TabIndex = 13
        Me.btnThoatCTHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnThoatCTHD.UseVisualStyleBackColor = False
        '
        'lblQLCTHD
        '
        Me.lblQLCTHD.BackColor = System.Drawing.Color.Transparent
        Me.lblQLCTHD.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblQLCTHD.ForeColor = System.Drawing.SystemColors.Control
        Me.lblQLCTHD.Location = New System.Drawing.Point(170, 5)
        Me.lblQLCTHD.Name = "lblQLCTHD"
        Me.lblQLCTHD.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblQLCTHD.Size = New System.Drawing.Size(304, 39)
        Me.lblQLCTHD.TabIndex = 0
        Me.lblQLCTHD.Text = "Chi Tiết Hoá Đơn"
        Me.lblQLCTHD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnXoaCTHD
        '
        Me.btnXoaCTHD.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnXoaCTHD.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnXoaCTHD.ForeColor = System.Drawing.SystemColors.Control
        Me.btnXoaCTHD.Image = Global.ngoctpnps02720_inf205_asmfinal.My.Resources.Resources.eraser
        Me.btnXoaCTHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnXoaCTHD.Location = New System.Drawing.Point(561, 325)
        Me.btnXoaCTHD.Name = "btnXoaCTHD"
        Me.btnXoaCTHD.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnXoaCTHD.Size = New System.Drawing.Size(75, 30)
        Me.btnXoaCTHD.TabIndex = 11
        Me.btnXoaCTHD.Text = "Xóa   "
        Me.btnXoaCTHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnXoaCTHD.UseVisualStyleBackColor = False
        '
        'btnThemCTHD
        '
        Me.btnThemCTHD.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnThemCTHD.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnThemCTHD.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnThemCTHD.ForeColor = System.Drawing.SystemColors.Control
        Me.btnThemCTHD.Image = Global.ngoctpnps02720_inf205_asmfinal.My.Resources.Resources.thêm
        Me.btnThemCTHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThemCTHD.Location = New System.Drawing.Point(561, 253)
        Me.btnThemCTHD.Name = "btnThemCTHD"
        Me.btnThemCTHD.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnThemCTHD.Size = New System.Drawing.Size(75, 30)
        Me.btnThemCTHD.TabIndex = 9
        Me.btnThemCTHD.Text = "Thêm"
        Me.btnThemCTHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnThemCTHD.UseVisualStyleBackColor = False
        '
        'txtMaSPCTHD
        '
        Me.txtMaSPCTHD.BackColor = System.Drawing.Color.DodgerBlue
        Me.txtMaSPCTHD.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtMaSPCTHD.ForeColor = System.Drawing.SystemColors.Control
        Me.txtMaSPCTHD.Location = New System.Drawing.Point(325, 192)
        Me.txtMaSPCTHD.Multiline = True
        Me.txtMaSPCTHD.Name = "txtMaSPCTHD"
        Me.txtMaSPCTHD.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMaSPCTHD.Size = New System.Drawing.Size(230, 23)
        Me.txtMaSPCTHD.TabIndex = 8
        '
        'txtSoLuongCTHD
        '
        Me.txtSoLuongCTHD.BackColor = System.Drawing.Color.DodgerBlue
        Me.txtSoLuongCTHD.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtSoLuongCTHD.ForeColor = System.Drawing.SystemColors.Control
        Me.txtSoLuongCTHD.Location = New System.Drawing.Point(325, 134)
        Me.txtSoLuongCTHD.Multiline = True
        Me.txtSoLuongCTHD.Name = "txtSoLuongCTHD"
        Me.txtSoLuongCTHD.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSoLuongCTHD.Size = New System.Drawing.Size(230, 23)
        Me.txtSoLuongCTHD.TabIndex = 6
        '
        'lblMaSPCTHD
        '
        Me.lblMaSPCTHD.BackColor = System.Drawing.Color.Transparent
        Me.lblMaSPCTHD.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblMaSPCTHD.ForeColor = System.Drawing.SystemColors.Control
        Me.lblMaSPCTHD.Location = New System.Drawing.Point(325, 163)
        Me.lblMaSPCTHD.Name = "lblMaSPCTHD"
        Me.lblMaSPCTHD.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMaSPCTHD.Size = New System.Drawing.Size(115, 23)
        Me.lblMaSPCTHD.TabIndex = 4
        Me.lblMaSPCTHD.Text = "Mã Sản Phẩm"
        Me.lblMaSPCTHD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSoLuongCTHD
        '
        Me.lblSoLuongCTHD.BackColor = System.Drawing.Color.Transparent
        Me.lblSoLuongCTHD.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblSoLuongCTHD.ForeColor = System.Drawing.SystemColors.Control
        Me.lblSoLuongCTHD.Location = New System.Drawing.Point(325, 105)
        Me.lblSoLuongCTHD.Name = "lblSoLuongCTHD"
        Me.lblSoLuongCTHD.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSoLuongCTHD.Size = New System.Drawing.Size(115, 23)
        Me.lblSoLuongCTHD.TabIndex = 2
        Me.lblSoLuongCTHD.Text = "Số Lượng"
        Me.lblSoLuongCTHD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtMaHDCTHD
        '
        Me.txtMaHDCTHD.BackColor = System.Drawing.Color.DodgerBlue
        Me.txtMaHDCTHD.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtMaHDCTHD.ForeColor = System.Drawing.SystemColors.Control
        Me.txtMaHDCTHD.Location = New System.Drawing.Point(9, 192)
        Me.txtMaHDCTHD.Multiline = True
        Me.txtMaHDCTHD.Name = "txtMaHDCTHD"
        Me.txtMaHDCTHD.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMaHDCTHD.Size = New System.Drawing.Size(230, 23)
        Me.txtMaHDCTHD.TabIndex = 7
        '
        'txtMaCTHD
        '
        Me.txtMaCTHD.BackColor = System.Drawing.Color.DodgerBlue
        Me.txtMaCTHD.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtMaCTHD.ForeColor = System.Drawing.SystemColors.Control
        Me.txtMaCTHD.Location = New System.Drawing.Point(9, 134)
        Me.txtMaCTHD.Multiline = True
        Me.txtMaCTHD.Name = "txtMaCTHD"
        Me.txtMaCTHD.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMaCTHD.Size = New System.Drawing.Size(230, 23)
        Me.txtMaCTHD.TabIndex = 5
        '
        'lblMaHDCTHD
        '
        Me.lblMaHDCTHD.BackColor = System.Drawing.Color.Transparent
        Me.lblMaHDCTHD.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblMaHDCTHD.ForeColor = System.Drawing.SystemColors.Control
        Me.lblMaHDCTHD.Location = New System.Drawing.Point(9, 163)
        Me.lblMaHDCTHD.Name = "lblMaHDCTHD"
        Me.lblMaHDCTHD.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMaHDCTHD.Size = New System.Drawing.Size(115, 23)
        Me.lblMaHDCTHD.TabIndex = 3
        Me.lblMaHDCTHD.Text = "Mã Hoá Đơn"
        Me.lblMaHDCTHD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMaCTHD
        '
        Me.lblMaCTHD.BackColor = System.Drawing.Color.Transparent
        Me.lblMaCTHD.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblMaCTHD.ForeColor = System.Drawing.SystemColors.Control
        Me.lblMaCTHD.Location = New System.Drawing.Point(9, 105)
        Me.lblMaCTHD.Name = "lblMaCTHD"
        Me.lblMaCTHD.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMaCTHD.Size = New System.Drawing.Size(230, 23)
        Me.lblMaCTHD.TabIndex = 1
        Me.lblMaCTHD.Text = "Mã Chi Tiết Hoá Đơn"
        Me.lblMaCTHD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvDanhSachCTHD
        '
        Me.dgvDanhSachCTHD.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDanhSachCTHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDanhSachCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhSachCTHD.Location = New System.Drawing.Point(9, 253)
        Me.dgvDanhSachCTHD.Name = "dgvDanhSachCTHD"
        Me.dgvDanhSachCTHD.Size = New System.Drawing.Size(546, 102)
        Me.dgvDanhSachCTHD.TabIndex = 12
        '
        'frmChiTietHoaDon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ngoctpnps02720_inf205_asmfinal.My.Resources.Resources.hinh_nen
        Me.ClientSize = New System.Drawing.Size(644, 360)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSuaCTHD)
        Me.Controls.Add(Me.btnThoatCTHD)
        Me.Controls.Add(Me.lblQLCTHD)
        Me.Controls.Add(Me.btnXoaCTHD)
        Me.Controls.Add(Me.btnThemCTHD)
        Me.Controls.Add(Me.txtMaSPCTHD)
        Me.Controls.Add(Me.txtSoLuongCTHD)
        Me.Controls.Add(Me.lblMaSPCTHD)
        Me.Controls.Add(Me.lblSoLuongCTHD)
        Me.Controls.Add(Me.txtMaHDCTHD)
        Me.Controls.Add(Me.txtMaCTHD)
        Me.Controls.Add(Me.lblMaHDCTHD)
        Me.Controls.Add(Me.lblMaCTHD)
        Me.Controls.Add(Me.dgvDanhSachCTHD)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmChiTietHoaDon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgvDanhSachCTHD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSuaCTHD As System.Windows.Forms.Button
    Friend WithEvents btnThoatCTHD As System.Windows.Forms.Button
    Friend WithEvents lblQLCTHD As System.Windows.Forms.Label
    Friend WithEvents btnXoaCTHD As System.Windows.Forms.Button
    Friend WithEvents btnThemCTHD As System.Windows.Forms.Button
    Friend WithEvents txtMaSPCTHD As System.Windows.Forms.TextBox
    Friend WithEvents txtSoLuongCTHD As System.Windows.Forms.TextBox
    Friend WithEvents lblMaSPCTHD As System.Windows.Forms.Label
    Friend WithEvents lblSoLuongCTHD As System.Windows.Forms.Label
    Friend WithEvents txtMaHDCTHD As System.Windows.Forms.TextBox
    Friend WithEvents txtMaCTHD As System.Windows.Forms.TextBox
    Friend WithEvents lblMaHDCTHD As System.Windows.Forms.Label
    Friend WithEvents lblMaCTHD As System.Windows.Forms.Label
    Friend WithEvents dgvDanhSachCTHD As System.Windows.Forms.DataGridView
End Class
