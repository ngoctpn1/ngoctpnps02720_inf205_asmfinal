<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanLyLoaiSanPham
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
        Me.btnSuaLoai = New System.Windows.Forms.Button()
        Me.btnThoatLoai = New System.Windows.Forms.Button()
        Me.btnXoaLoai = New System.Windows.Forms.Button()
        Me.btnThemLoai = New System.Windows.Forms.Button()
        Me.txtTenLoai = New System.Windows.Forms.TextBox()
        Me.txtMaLoai = New System.Windows.Forms.TextBox()
        Me.lblTenLoai = New System.Windows.Forms.Label()
        Me.lblMaLoai = New System.Windows.Forms.Label()
        Me.dgvDanhSachLoai = New System.Windows.Forms.DataGridView()
        Me.lblQLLSP = New System.Windows.Forms.Label()
        CType(Me.dgvDanhSachLoai, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSuaLoai
        '
        Me.btnSuaLoai.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnSuaLoai.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnSuaLoai.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnSuaLoai.ForeColor = System.Drawing.SystemColors.Control
        Me.btnSuaLoai.Image = Global.ngoctpnps02720_inf205_asmfinal.My.Resources.Resources.sửa
        Me.btnSuaLoai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSuaLoai.Location = New System.Drawing.Point(557, 291)
        Me.btnSuaLoai.Name = "btnSuaLoai"
        Me.btnSuaLoai.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnSuaLoai.Size = New System.Drawing.Size(75, 30)
        Me.btnSuaLoai.TabIndex = 6
        Me.btnSuaLoai.Text = "Sửa   "
        Me.btnSuaLoai.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSuaLoai.UseVisualStyleBackColor = False
        '
        'btnThoatLoai
        '
        Me.btnThoatLoai.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnThoatLoai.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnThoatLoai.ForeColor = System.Drawing.SystemColors.Control
        Me.btnThoatLoai.Image = Global.ngoctpnps02720_inf205_asmfinal.My.Resources.Resources.dialog_cancel
        Me.btnThoatLoai.Location = New System.Drawing.Point(602, 5)
        Me.btnThoatLoai.Name = "btnThoatLoai"
        Me.btnThoatLoai.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnThoatLoai.Size = New System.Drawing.Size(30, 30)
        Me.btnThoatLoai.TabIndex = 9
        Me.btnThoatLoai.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnThoatLoai.UseVisualStyleBackColor = False
        '
        'btnXoaLoai
        '
        Me.btnXoaLoai.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnXoaLoai.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnXoaLoai.ForeColor = System.Drawing.SystemColors.Control
        Me.btnXoaLoai.Image = Global.ngoctpnps02720_inf205_asmfinal.My.Resources.Resources.eraser
        Me.btnXoaLoai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnXoaLoai.Location = New System.Drawing.Point(557, 327)
        Me.btnXoaLoai.Name = "btnXoaLoai"
        Me.btnXoaLoai.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnXoaLoai.Size = New System.Drawing.Size(75, 30)
        Me.btnXoaLoai.TabIndex = 7
        Me.btnXoaLoai.Text = "Xóa   "
        Me.btnXoaLoai.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnXoaLoai.UseVisualStyleBackColor = False
        '
        'btnThemLoai
        '
        Me.btnThemLoai.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnThemLoai.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnThemLoai.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnThemLoai.ForeColor = System.Drawing.SystemColors.Control
        Me.btnThemLoai.Image = Global.ngoctpnps02720_inf205_asmfinal.My.Resources.Resources.thêm
        Me.btnThemLoai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThemLoai.Location = New System.Drawing.Point(557, 255)
        Me.btnThemLoai.Name = "btnThemLoai"
        Me.btnThemLoai.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnThemLoai.Size = New System.Drawing.Size(75, 30)
        Me.btnThemLoai.TabIndex = 5
        Me.btnThemLoai.Text = "Thêm"
        Me.btnThemLoai.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnThemLoai.UseVisualStyleBackColor = False
        '
        'txtTenLoai
        '
        Me.txtTenLoai.BackColor = System.Drawing.Color.DodgerBlue
        Me.txtTenLoai.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtTenLoai.ForeColor = System.Drawing.SystemColors.Control
        Me.txtTenLoai.Location = New System.Drawing.Point(12, 259)
        Me.txtTenLoai.Multiline = True
        Me.txtTenLoai.Name = "txtTenLoai"
        Me.txtTenLoai.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTenLoai.Size = New System.Drawing.Size(191, 23)
        Me.txtTenLoai.TabIndex = 4
        '
        'txtMaLoai
        '
        Me.txtMaLoai.BackColor = System.Drawing.Color.DodgerBlue
        Me.txtMaLoai.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtMaLoai.ForeColor = System.Drawing.SystemColors.Control
        Me.txtMaLoai.Location = New System.Drawing.Point(15, 187)
        Me.txtMaLoai.Multiline = True
        Me.txtMaLoai.Name = "txtMaLoai"
        Me.txtMaLoai.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMaLoai.Size = New System.Drawing.Size(191, 23)
        Me.txtMaLoai.TabIndex = 3
        '
        'lblTenLoai
        '
        Me.lblTenLoai.BackColor = System.Drawing.Color.Transparent
        Me.lblTenLoai.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblTenLoai.ForeColor = System.Drawing.SystemColors.Control
        Me.lblTenLoai.Location = New System.Drawing.Point(9, 233)
        Me.lblTenLoai.Name = "lblTenLoai"
        Me.lblTenLoai.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTenLoai.Size = New System.Drawing.Size(115, 23)
        Me.lblTenLoai.TabIndex = 2
        Me.lblTenLoai.Text = "Tên Loại"
        Me.lblTenLoai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMaLoai
        '
        Me.lblMaLoai.BackColor = System.Drawing.Color.Transparent
        Me.lblMaLoai.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblMaLoai.ForeColor = System.Drawing.SystemColors.Control
        Me.lblMaLoai.Location = New System.Drawing.Point(12, 161)
        Me.lblMaLoai.Name = "lblMaLoai"
        Me.lblMaLoai.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMaLoai.Size = New System.Drawing.Size(115, 23)
        Me.lblMaLoai.TabIndex = 1
        Me.lblMaLoai.Text = "Mã Loại"
        Me.lblMaLoai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvDanhSachLoai
        '
        Me.dgvDanhSachLoai.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDanhSachLoai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDanhSachLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhSachLoai.Location = New System.Drawing.Point(237, 160)
        Me.dgvDanhSachLoai.Name = "dgvDanhSachLoai"
        Me.dgvDanhSachLoai.Size = New System.Drawing.Size(289, 197)
        Me.dgvDanhSachLoai.TabIndex = 8
        '
        'lblQLLSP
        '
        Me.lblQLLSP.BackColor = System.Drawing.Color.Transparent
        Me.lblQLLSP.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblQLLSP.ForeColor = System.Drawing.SystemColors.Control
        Me.lblQLLSP.Location = New System.Drawing.Point(158, 35)
        Me.lblQLLSP.Name = "lblQLLSP"
        Me.lblQLLSP.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblQLLSP.Size = New System.Drawing.Size(324, 50)
        Me.lblQLLSP.TabIndex = 0
        Me.lblQLLSP.Text = "Quản Lý Loại Sản Phẩm"
        Me.lblQLLSP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmQuanLyLoaiSanPham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ngoctpnps02720_inf205_asmfinal.My.Resources.Resources.hinh_nen
        Me.ClientSize = New System.Drawing.Size(644, 360)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSuaLoai)
        Me.Controls.Add(Me.btnThoatLoai)
        Me.Controls.Add(Me.btnXoaLoai)
        Me.Controls.Add(Me.btnThemLoai)
        Me.Controls.Add(Me.txtTenLoai)
        Me.Controls.Add(Me.txtMaLoai)
        Me.Controls.Add(Me.lblTenLoai)
        Me.Controls.Add(Me.lblMaLoai)
        Me.Controls.Add(Me.dgvDanhSachLoai)
        Me.Controls.Add(Me.lblQLLSP)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmQuanLyLoaiSanPham"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgvDanhSachLoai, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSuaLoai As System.Windows.Forms.Button
    Friend WithEvents btnThoatLoai As System.Windows.Forms.Button
    Friend WithEvents btnXoaLoai As System.Windows.Forms.Button
    Friend WithEvents btnThemLoai As System.Windows.Forms.Button
    Friend WithEvents txtTenLoai As System.Windows.Forms.TextBox
    Friend WithEvents txtMaLoai As System.Windows.Forms.TextBox
    Friend WithEvents lblTenLoai As System.Windows.Forms.Label
    Friend WithEvents lblMaLoai As System.Windows.Forms.Label
    Friend WithEvents dgvDanhSachLoai As System.Windows.Forms.DataGridView
    Friend WithEvents lblQLLSP As System.Windows.Forms.Label
End Class
