Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frmQuanLyNhanVien
    Dim database As New DataTable ' Tạo đối tượng database để lưu trữ dữ liệu từ Database Online'
    'Tạo chuỗi kết nối để kết nối tới Database Online'
    Dim chuoiconnect As String = "workstation id=ps02720.mssql.somee.com;packet size=4096;user id=ngoctpnps02720_SQLLogin_7;pwd=4hifjkxf1s;data source=ps02720.mssql.somee.com;persist security info=False;initial catalog=ps02720"
    Dim connect As SqlConnection = New SqlConnection(chuoiconnect)

    Private Sub frmQuanLyNhanVien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connect As SqlConnection = New SqlConnection(chuoiconnect) ' Tạo đối tượng kết nối tới DB  Online'
        ' Câu truy vấn để get dữ liệu'
        Dim Query1 As SqlDataAdapter = New SqlDataAdapter("select * from NhanVien", connect)
        'Kết nối mở ra
        connect.Open()
        'Đổ dữ liệu vào đối tượng database'
        Query1.Fill(database)
        'Hiển thị dữ liệu ra Datagridview'
        dgvDanhSachNV.DataSource = database.DefaultView
    End Sub 'frmQuanLyNhanVien_Load

    Private Sub Loaddata()
        database.Clear()
        dgvDanhSachNV.DataSource = database
        dgvDanhSachNV.DataSource = Nothing
        Dim connect As SqlConnection = New SqlConnection(chuoiconnect)
        Dim Query1 As SqlDataAdapter = New SqlDataAdapter("select * from Nhanvien", connect)

        connect.Open()
        Query1.Fill(database)
        dgvDanhSachNV.DataSource = database.DefaultView
    End Sub 'Loaddata()

    Private Sub dgvDanhSachNV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDanhSachNV.CellContentClick
        Dim index As Integer = dgvDanhSachNV.CurrentCell.RowIndex
        txtMaNV.Text = dgvDanhSachNV.Item(0, index).Value
        txtMatKhauNV.Text = dgvDanhSachNV.Item(1, index).Value
        txtTenNV.Text = dgvDanhSachNV.Item(2, index).Value
        txtMaHDNV.Text = dgvDanhSachNV.Item(3, index).Value
        txtTenDangNhap.Text = dgvDanhSachNV.Item(4, index).Value
    End Sub 'dgvDanhSachNV_CellContentClick

    Private Sub btnThemNV_Click(sender As Object, e As EventArgs) Handles btnThemNV.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiconnect)
        'Tạo query câu truy vấn Insert into'
        Dim Add As String = "insert into NhanVien values (@MaNV,@MatKhau,@TenNV,@HoaDon_MaHD,@TenDangNhap)"
        'Tạo đối tượng để thực thi câu truy vấn với DB online'
        Dim them As New SqlCommand(Add, connect)
        'Kết nối mở ra
        connect.Open()

        Try
            'Truyền giá trị trong các ô textbox cho các biến tương ứng'
            them.Parameters.AddWithValue("@MaNV", txtMaNV.Text)
            them.Parameters.AddWithValue("@MatKhau", txtMatKhauNV.Text)
            them.Parameters.AddWithValue("@TenNV", txtTenNV.Text)
            them.Parameters.AddWithValue("@HoaDon_MaHD", txtMaHDNV.Text)
            them.Parameters.AddWithValue("@TenDangNhap", txtTenDangNhap.Text)


            MessageBox.Show("Thêm nhân viên thành công!")
            'Exucute là ghi dữ liệu vào Database'
            them.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Không thành công!")

        End Try
        'Cập nhật dữ liệu'
        Loaddata()
    End Sub 'btnThemNV_Click

    Private Sub btnSuaNV_Click(sender As Object, e As EventArgs) Handles btnSuaNV.Click
        Dim Ketnoisua As New SqlConnection(chuoiconnect)
        Ketnoisua.Open()
        Dim Straddsua As String = "Update NhanVien set MatKhau = @MatKhau, TenNV = @TenNV, HoaDon_MaHD = @HoaDon_MaHD, TenDangNhap = @TenDangNhap where MaNV = @MaNV"
        Dim Comsua As New SqlCommand(Straddsua, Ketnoisua)
        Try
            Comsua.Parameters.AddWithValue("@MaNV", txtMaNV.Text)
            Comsua.Parameters.AddWithValue("@MatKhau", txtMatKhauNV.Text)
            Comsua.Parameters.AddWithValue("@TenNV", txtTenNV.Text)
            Comsua.Parameters.AddWithValue("@HoaDon_MaHD", txtMaHDNV.Text)
            Comsua.Parameters.AddWithValue("@TenDangNhap", txtTenDangNhap.Text)
            Comsua.ExecuteNonQuery()
            Ketnoisua.Close()
            MessageBox.Show("Sửa thành công")
        Catch ex As Exception
            MessageBox.Show("Sửa không thành công")
        End Try
        Loaddata()
    End Sub 'btnSuaNV_Click

    Private Sub btnXoaNV_Click(sender As Object, e As EventArgs) Handles btnXoaNV.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiconnect)
        connect.Open()
        Dim delete As String = "Delete from NhanVien where MaNV = @MaNV"
        Dim xoa As New SqlCommand(delete, connect)
        Try
            xoa.Parameters.AddWithValue("@MaNV", txtMaNV.Text)
            xoa.ExecuteNonQuery()
            MessageBox.Show("Xóa Thành Công")
        Catch ex As Exception
            MessageBox.Show("Xóa Không Thành Công")
        End Try
        Loaddata()
    End Sub 'btnXoaNV_Click

    Private Sub btnThoatNV_Click(sender As Object, e As EventArgs) Handles btnThoatNV.Click
        Me.Close()
    End Sub 'btnThoatNV_Click

End Class 'frmQuanLyNhanVien