Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frmQuanLyHoaDon

    Dim database As New DataTable ' Tạo đối tượng database để lưu trữ dữ liệu từ Database Online'
    'Tạo chuỗi kết nối để kết nối tới Database Online'
    Dim chuoiconnect As String = "workstation id=ps02720.mssql.somee.com;packet size=4096;user id=ngoctpnps02720_SQLLogin_7;pwd=4hifjkxf1s;data source=ps02720.mssql.somee.com;persist security info=False;initial catalog=ps02720"
    Dim connect As SqlConnection = New SqlConnection(chuoiconnect)

    Private Sub frmQuanLyHoaDon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connect As SqlConnection = New SqlConnection(chuoiconnect) ' Tạo đối tượng kết nối tới DB  Online'
        ' Câu truy vấn để get dữ liệu'
        Dim Query1 As SqlDataAdapter = New SqlDataAdapter("select * from HoaDon", connect)
        'Kết nối mở ra
        connect.Open()
        'Đổ dữ liệu vào đối tượng database'
        Query1.Fill(database)
        'Hiển thị dữ liệu ra Datagridview'
        dgvDanhSachHD.DataSource = database.DefaultView
    End Sub 'frmQuanLyHoaDon_Load

    Private Sub Loaddata()
        database.Clear()
        dgvDanhSachHD.DataSource = database
        dgvDanhSachHD.DataSource = Nothing
        Dim connect As SqlConnection = New SqlConnection(chuoiconnect)
        Dim Query1 As SqlDataAdapter = New SqlDataAdapter("select * from HoaDon", connect)

        connect.Open()
        Query1.Fill(database)
        dgvDanhSachHD.DataSource = database.DefaultView
    End Sub 'Loaddata()

    Private Sub dgvDanhSachHD_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDanhSachHD.CellContentClick
        Dim index As Integer = dgvDanhSachHD.CurrentCell.RowIndex
        txtMaHD.Text = dgvDanhSachHD.Item(0, index).Value
        txtTongTien.Text = dgvDanhSachHD.Item(1, index).Value
        txtNgayLap.Text = dgvDanhSachHD.Item(2, index).Value
        txtMaKHHD.Text = dgvDanhSachHD.Item(3, index).Value
        txtMaNVHD.Text = dgvDanhSachHD.Item(4, index).Value
    End Sub 'dgvDanhSachHD_CellContentClick

    Private Sub btnThemHD_Click(sender As Object, e As EventArgs) Handles btnThemHD.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiconnect)
        'Tạo query câu truy vấn Insert into'
        Dim Add As String = "insert into HoaDon values (@MaHD,@TongTien,@NgayLap,@KhachHang_MaKH,@MaNV)"
        'Tạo đối tượng để thực thi câu truy vấn với DB online'
        Dim them As New SqlCommand(Add, connect)
        'Kết nối mở ra
        connect.Open()

        Try
            'Truyền giá trị trong các ô textbox cho các biến tương ứng'
            them.Parameters.AddWithValue("@MaHD", txtMaHD.Text)
            them.Parameters.AddWithValue("@TongTien", txtTongTien.Text)
            them.Parameters.AddWithValue("@NgayLap", txtNgayLap.Text)
            them.Parameters.AddWithValue("@KhachHang_MaKH", txtMaKHHD.Text)
            them.Parameters.AddWithValue("@MaNV", txtMaNVHD.Text)

            MessageBox.Show("Thêm thành công!")
            'Exucute là ghi dữ liệu vào Database'
            them.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Không thành công!")

        End Try
        'Cập nhật dữ liệu'
        Loaddata()
    End Sub 'btnThemHD_Click

    Private Sub btnSuaHD_Click(sender As Object, e As EventArgs) Handles btnSuaHD.Click
        Dim Ketnoisua As New SqlConnection(chuoiconnect)
        Ketnoisua.Open()
        Dim Straddsua As String = "Update HoaDon set TongTien = @TongTien, NgayLap = @NgayLap, KhachHang_MaKH = @KhachHang_MaKH, MaNV = @MaNV where MaHD = @MaHD"
        Dim Comsua As New SqlCommand(Straddsua, Ketnoisua)
        Try
            Comsua.Parameters.AddWithValue("@MaHD", txtMaHD.Text)
            Comsua.Parameters.AddWithValue("@TongTien", txtTongTien.Text)
            Comsua.Parameters.AddWithValue("@NgayLap", txtNgayLap.Text)
            Comsua.Parameters.AddWithValue("@KhachHang_MaKH", txtMaKHHD.Text)
            Comsua.Parameters.AddWithValue("@MaNV", txtMaNVHD.Text)
            Comsua.ExecuteNonQuery()
            Ketnoisua.Close()
            MessageBox.Show("Sửa thành công")
        Catch ex As Exception
            MessageBox.Show("Sửa không thành công")
        End Try
        Loaddata()
    End Sub 'btnSuaHD_Click

    Private Sub btnXoaHD_Click(sender As Object, e As EventArgs) Handles btnXoaHD.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiconnect)
        connect.Open()
        Dim delete As String = "Delete from HoaDon where MaHD = @MaHD"
        Dim xoa As New SqlCommand(delete, connect)
        Try
            xoa.Parameters.AddWithValue("@MaHD", txtMaHD.Text)
            xoa.ExecuteNonQuery()
            MessageBox.Show("Xóa Thành Công")
        Catch ex As Exception
            MessageBox.Show("Xóa Không Thành Công")
        End Try
        Loaddata()
    End Sub 'btnXoaHD_Click

    Private Sub btnThoatHD_Click(sender As Object, e As EventArgs) Handles btnThoatHD.Click
        Me.Close()
    End Sub 'btnThoatHD_Click

End Class 'frmQuanLyHoaDon