Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmQuanLySanPham

    Dim database As New DataTable ' Tạo đối tượng database để lưu trữ dữ liệu từ Database Online'
    'Tạo chuỗi kết nối để kết nối tới Database Online'
    Dim chuoiconnect As String = "workstation id=ps02720.mssql.somee.com;packet size=4096;user id=ngoctpnps02720_SQLLogin_7;pwd=4hifjkxf1s;data source=ps02720.mssql.somee.com;persist security info=False;initial catalog=ps02720"
    Dim connect As SqlConnection = New SqlConnection(chuoiconnect)

    Private Sub frmQuanLySanPham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connect As SqlConnection = New SqlConnection(chuoiconnect) ' Tạo đối tượng kết nối tới DB  Online'
        ' Câu truy vấn để get dữ liệu'
        Dim Query1 As SqlDataAdapter = New SqlDataAdapter("select * from SanPham", connect)
        'Kết nối mở ra
        connect.Open()
        'Đổ dữ liệu vào đối tượng database'
        Query1.Fill(database)
        'Hiển thị dữ liệu ra Datagridview'
        dgvDanhSachSP.DataSource = database.DefaultView
    End Sub 'frmQuanLySanPham_Load

    Private Sub Loaddata()
        database.Clear()
        dgvDanhSachSP.DataSource = database
        dgvDanhSachSP.DataSource = Nothing
        Dim connect As SqlConnection = New SqlConnection(chuoiconnect)
        Dim Query1 As SqlDataAdapter = New SqlDataAdapter("select * from SanPham", connect)

        connect.Open()
        Query1.Fill(database)
        dgvDanhSachSP.DataSource = database.DefaultView
    End Sub 'Loaddata()

    Private Sub dgvDanhSachSP_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDanhSachSP.CellContentClick
        Dim index As Integer = dgvDanhSachSP.CurrentCell.RowIndex
        txtMaSP.Text = dgvDanhSachSP.Item(0, index).Value
        txtTenSP.Text = dgvDanhSachSP.Item(1, index).Value
        txtDonGia.Text = dgvDanhSachSP.Item(2, index).Value
        txtSoLuong.Text = dgvDanhSachSP.Item(3, index).Value
        txtChiTiet.Text = dgvDanhSachSP.Item(4, index).Value
        txtMaLoaiSP.Text = dgvDanhSachSP.Item(5, index).Value
    End Sub 'dgvDanhSachSP_CellContentClick

    Private Sub btnThemSP_Click(sender As Object, e As EventArgs) Handles btnThemSP.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiconnect)
        'Tạo query câu truy vấn Insert into'
        Dim Add As String = "insert into SanPham values (@MaSP,@TenSP,@DonGia,@SoLuong,@ChiTietSP,@LoaiSanPham_Maloai)"
        'Tạo đối tượng để thực thi câu truy vấn với DB online'
        Dim them As New SqlCommand(Add, connect)
        'Kết nối mở ra
        connect.Open()

        Try
            'Truyền giá trị trong các ô textbox cho các biến tương ứng'
            them.Parameters.AddWithValue("@MaSP", txtMaSP.Text)
            them.Parameters.AddWithValue("@TenSP", txtTenSP.Text)
            them.Parameters.AddWithValue("@DonGia", txtDonGia.Text)
            them.Parameters.AddWithValue("@SoLuong", txtSoLuong.Text)
            them.Parameters.AddWithValue("@ChiTietSP", txtChiTiet.Text)
            them.Parameters.AddWithValue("@LoaiSanPham_MaLoai", txtMaLoaiSP.Text)

            MessageBox.Show("Thêm sản phẩm thành công!")
            'Exucute là ghi dữ liệu vào Database'
            them.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Không thành công!")

        End Try
        'Cập nhật dữ liệu'
        Loaddata()
    End Sub 'btnThemSP_Click

    Private Sub btnSuaSP_Click(sender As Object, e As EventArgs) Handles btnSuaSP.Click
        Dim Ketnoisua As New SqlConnection(chuoiconnect)
        Ketnoisua.Open()
        Dim Straddsua As String = "Update SanPham set TenSP = @TenSP, DonGia = @DonGia, SoLuong = @SoLuong, ChiTietSP = @ChiTietSP, LoaiSanPham_MaLoai = @LoaiSanPham_MaLoai where MaSP = @MaSP"
        Dim Comsua As New SqlCommand(Straddsua, Ketnoisua)
        Try
            Comsua.Parameters.AddWithValue("@MaSP", txtMaSP.Text)
            Comsua.Parameters.AddWithValue("@TenSP", txtTenSP.Text)
            Comsua.Parameters.AddWithValue("@DonGia", txtDonGia.Text)
            Comsua.Parameters.AddWithValue("@SoLuong", txtSoLuong.Text)
            Comsua.Parameters.AddWithValue("@ChiTietSP", txtChiTiet.Text)
            Comsua.Parameters.AddWithValue("@LoaiSanPham_MaLoai", txtMaLoaiSP.Text)
            Comsua.ExecuteNonQuery()
            Ketnoisua.Close()
            MessageBox.Show("Sửa thành công")
        Catch ex As Exception
            MessageBox.Show("Sửa không thành công")
        End Try
        Loaddata()
    End Sub 'btnSuaSP_Click

    Private Sub btnXoaSP_Click(sender As Object, e As EventArgs) Handles btnXoaSP.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiconnect)
        connect.Open()
        Dim delete As String = "Delete from SanPham where MaSP = @MaSP"
        Dim xoa As New SqlCommand(delete, connect)
        Try
            xoa.Parameters.AddWithValue("@MaSP", txtMaSP.Text)
            xoa.ExecuteNonQuery()
            MessageBox.Show("Xóa Thành Công")
        Catch ex As Exception
            MessageBox.Show("Xóa Không Thành Công")
        End Try
        Loaddata()
    End Sub 'btnXoaSP_Click

    Private Sub btnThoatSP_Click(sender As Object, e As EventArgs) Handles btnThoatSP.Click
        Me.Close()
    End Sub 'btnThoatSP_Click

End Class 'frmQuanLySanPham