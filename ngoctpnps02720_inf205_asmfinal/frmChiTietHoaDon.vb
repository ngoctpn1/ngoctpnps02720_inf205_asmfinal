Imports System.Data.SqlClient
Imports System.Data.DataTable
'Đã chỉnh sửa
Public Class frmChiTietHoaDon

    Dim database As New DataTable ' Tạo đối tượng database để lưu trữ dữ liệu từ Database Online'
    'Tạo chuỗi kết nối để kết nối tới Database Online'
    Dim chuoiconnect As String = "workstation id=ps02720.mssql.somee.com;packet size=4096;user id=ngoctpnps02720_SQLLogin_7;pwd=4hifjkxf1s;data source=ps02720.mssql.somee.com;persist security info=False;initial catalog=ps02720"
    Dim connect As SqlConnection = New SqlConnection(chuoiconnect)

    Private Sub frmChiTietHoaDon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connect As SqlConnection = New SqlConnection(chuoiconnect) ' Tạo đối tượng kết nối tới DB  Online'
        ' Câu truy vấn để get dữ liệu'
        Dim Query1 As SqlDataAdapter = New SqlDataAdapter("select * from ChiTietHoaDon", connect)
        'Kết nối mở ra
        connect.Open()
        'Đổ dữ liệu vào đối tượng database'
        Query1.Fill(database)
        'Hiển thị dữ liệu ra Datagridview'
        dgvDanhSachCTHD.DataSource = database.DefaultView
    End Sub 'frmChiTietHoaDon_Load

    Private Sub Loaddata()
        database.Clear()
        dgvDanhSachCTHD.DataSource = database
        dgvDanhSachCTHD.DataSource = Nothing
        Dim connect As SqlConnection = New SqlConnection(chuoiconnect)
        Dim Query1 As SqlDataAdapter = New SqlDataAdapter("select * from ChiTietHoaDon", connect)

        connect.Open()
        Query1.Fill(database)
        dgvDanhSachCTHD.DataSource = database.DefaultView
    End Sub 'Loaddata()

    Private Sub dgvDanhSachCTHD_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDanhSachCTHD.CellContentClick
        Dim index As Integer = dgvDanhSachCTHD.CurrentCell.RowIndex
        txtMaCTHD.Text = dgvDanhSachCTHD.Item(0, index).Value
        txtSoLuongCTHD.Text = dgvDanhSachCTHD.Item(1, index).Value
        txtMaHDCTHD.Text = dgvDanhSachCTHD.Item(2, index).Value
        txtMaSPCTHD.Text = dgvDanhSachCTHD.Item(3, index).Value
    End Sub 'dgvDanhSachCTHD_CellContentClick

    Private Sub btnThemCTHD_Click(sender As Object, e As EventArgs) Handles btnThemCTHD.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiconnect)
        'Tạo query câu truy vấn Insert into'
        Dim Add As String = "insert into ChiTietHoaDon values (@MaCTHD,@SoLuong,@HoaDon_MaHD,@SanPham_MaSP)"
        'Tạo đối tượng để thực thi câu truy vấn với DB online'
        Dim them As New SqlCommand(Add, connect)
        'Kết nối mở ra
        connect.Open()

        Try
            'Truyền giá trị trong các ô textbox cho các biến tương ứng'
            them.Parameters.AddWithValue("@MaCTHD", txtMaCTHD.Text)
            them.Parameters.AddWithValue("@SoLuong", txtSoLuongCTHD.Text)
            them.Parameters.AddWithValue("@HoaDon_MaHD", txtMaHDCTHD.Text)
            them.Parameters.AddWithValue("@SanPham_MaSP", txtMaSPCTHD.Text)

            MessageBox.Show("Thêm thành công!")
            'Exucute là ghi dữ liệu vào Database'
            them.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Không thành công!")

        End Try
        'Cập nhật dữ liệu'
        Loaddata()
    End Sub 'btnThemCTHD_Click

    Private Sub btnSuaCTHD_Click(sender As Object, e As EventArgs) Handles btnSuaCTHD.Click
        Dim Ketnoisua As New SqlConnection(chuoiconnect)
        Ketnoisua.Open()
        Dim Straddsua As String = "Update ChiTietHoaDon set SoLuong = @SoLuong, HoaDon_MaHD = @HoaDon_MaHD, SanPham_MaSP = @SanPham_MaSP where MaCTHD = @MaCTHD"
        Dim Comsua As New SqlCommand(Straddsua, Ketnoisua)
        Try
            Comsua.Parameters.AddWithValue("@MaCTHD", txtMaCTHD.Text)
            Comsua.Parameters.AddWithValue("@SoLuong", txtSoLuongCTHD.Text)
            Comsua.Parameters.AddWithValue("@HoaDon_MaHD", txtMaHDCTHD.Text)
            Comsua.Parameters.AddWithValue("@SanPham_MaSP", txtMaSPCTHD.Text)
            Comsua.ExecuteNonQuery()
            Ketnoisua.Close()
            MessageBox.Show("Sửa thành công")
        Catch ex As Exception
            MessageBox.Show("Sửa không thành công")
        End Try
        Loaddata()
    End Sub 'btnSuaCTHD_Click

    Private Sub btnXoaCTHD_Click(sender As Object, e As EventArgs) Handles btnXoaCTHD.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiconnect)
        connect.Open()
        Dim delete As String = "Delete from ChiTietHoaDon where MaCTHD = @MaCTHD"
        Dim xoa As New SqlCommand(delete, connect)
        Try
            xoa.Parameters.AddWithValue("@MaCTHD", txtMaCTHD.Text)
            xoa.ExecuteNonQuery()
            MessageBox.Show("Xóa Thành Công")
        Catch ex As Exception
            MessageBox.Show("Xóa Không Thành Công")
        End Try
        Loaddata()
    End Sub 'btnXoaCTHD_Click

    Private Sub btnThoatCTHD_Click(sender As Object, e As EventArgs) Handles btnThoatCTHD.Click
        Me.Close()
    End Sub 'btnThoatCTHD_Click

End Class 'frmChiTietHoaDon