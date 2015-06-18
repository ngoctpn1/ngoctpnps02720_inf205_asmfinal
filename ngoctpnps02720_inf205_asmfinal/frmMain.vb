Public Class frmMain

    Private Sub mniDangNhap_Click(sender As Object, e As EventArgs) Handles mniDangNhap.Click
        frmDangNhap.ShowDialog()
    End Sub 'mniDangNhap_Click

    Private Sub mniThoat_Click(sender As Object, e As EventArgs) Handles mniThoat.Click
        Me.Close()
    End Sub 'mniThoat_Click

    Private Sub mniQLNV_Click(sender As Object, e As EventArgs) Handles mniQLNV.Click
        frmQuanLyNhanVien.ShowDialog()
    End Sub 'mniQLNV_Click

    Private Sub mniQLKH_Click(sender As Object, e As EventArgs) Handles mniQLKH.Click
        frmQuanLyKhachHang.ShowDialog()
    End Sub 'mniQLKH_Click

    Private Sub mniQLSP_Click(sender As Object, e As EventArgs) Handles mniQLSP.Click
        frmQuanLySanPham.ShowDialog()
    End Sub 'mniQLSP_Click

    Private Sub mniQLLSP_Click(sender As Object, e As EventArgs) Handles mniQLLSP.Click
        frmQuanLyLoaiSanPham.ShowDialog()
    End Sub 'mniQLLSP_Click

    Private Sub mniQLHD_Click(sender As Object, e As EventArgs) Handles mniQLHD.Click
        frmQuanLyHoaDon.ShowDialog()
    End Sub 'mniQLHD_Click

    Private Sub mniCTHD_Click(sender As Object, e As EventArgs) Handles mniCTHD.Click
        frmChiTietHoaDon.ShowDialog()
    End Sub 'mniCTHD_Click

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmWelcome.ShowDialog()
        frmDangNhap.ShowDialog()
    End Sub 'frmMain_Load

    Private Sub btnThoatMain_Click(sender As Object, e As EventArgs) Handles btnThoatMain.Click
        Me.Close()
    End Sub 'btnThoatMain_Click

    
End Class 'frmMain