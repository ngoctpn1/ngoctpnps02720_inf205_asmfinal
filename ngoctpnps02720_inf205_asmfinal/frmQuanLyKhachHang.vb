Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frmQuanLyKhachHang

    Dim database As New DataTable ' Tạo đối tượng database để lưu trữ dữ liệu từ Database Online'
    'Tạo chuỗi kết nối để kết nối tới Database Online'
    Dim chuoiconnect As String = "workstation id=ps02720.mssql.somee.com;packet size=4096;user id=ngoctpnps02720_SQLLogin_7;pwd=4hifjkxf1s;data source=ps02720.mssql.somee.com;persist security info=False;initial catalog=ps02720"
    Dim connect As SqlConnection = New SqlConnection(chuoiconnect)
    Private Sub frmQuanLyKhachHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connect As SqlConnection = New SqlConnection(chuoiconnect) ' Tạo đối tượng kết nối tới DB  Online'
        ' Câu truy vấn để get dữ liệu'
        Dim Query1 As SqlDataAdapter = New SqlDataAdapter("select * from KhachHang", connect)
        'Kết nối mở ra
        connect.Open()
        'Đổ dữ liệu vào đối tượng database'
        Query1.Fill(database)
        'Hiển thị dữ liệu ra Datagridview'
        dgvDanhSachKH.DataSource = database.DefaultView
    End Sub 'frmQuanLyKhachHang_Load

    Private Sub dgvDanhSachKH_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDanhSachKH.CellContentClick
        Dim index As Integer = dgvDanhSachKH.CurrentCell.RowIndex
        txtMaKH.Text = dgvDanhSachKH.Item(0, index).Value
        txtTenKH.Text = dgvDanhSachKH.Item(1, index).Value
        txtSDTKH.Text = dgvDanhSachKH.Item(2, index).Value
        txtDiaChiKH.Text = dgvDanhSachKH.Item(3, index).Value
    End Sub 'dgvDanhSachKH_CellContentClick

    Private Sub Loaddata()
        database.Clear()
        dgvDanhSachKH.DataSource = database
        dgvDanhSachKH.DataSource = Nothing
        Dim connect As SqlConnection = New SqlConnection(chuoiconnect)
        Dim Query1 As SqlDataAdapter = New SqlDataAdapter("select * from KhachHang", connect)

        connect.Open()
        Query1.Fill(database)
        dgvDanhSachKH.DataSource = database.DefaultView
    End Sub 'Loaddata()

    Private Sub btnThemKH_Click(sender As Object, e As EventArgs) Handles btnThemKH.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiconnect)
        'Tạo query câu truy vấn Insert into'
        Dim Add As String = "insert into KhachHang values (@MaKH,@TenKH,@SDT,@DiaChi)"
        'Tạo đối tượng để thực thi câu truy vấn với DB online'
        Dim them As New SqlCommand(Add, connect)
        'Kết nối mở ra
        connect.Open()

        Try
            'Truyền giá trị trong các ô textbox cho các biến tương ứng'
            them.Parameters.AddWithValue("@MaKH", txtMaKH.Text)
            them.Parameters.AddWithValue("@TenKH", txtTenKH.Text)
            them.Parameters.AddWithValue("@SDT", txtSDTKH.Text)
            them.Parameters.AddWithValue("@DiaChi", txtDiaChiKH.Text)

            MessageBox.Show("Thêm khách hàng thành công!")
            'Exucute là ghi dữ liệu vào Database'
            them.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Không thành công!")

        End Try
        'Cập nhật dữ liệu'
        Loaddata()
    End Sub 'btnThemKH_Click

    Private Sub btnSuaKH_Click(sender As Object, e As EventArgs) Handles btnSuaKH.Click
        Dim Ketnoisua As New SqlConnection(chuoiconnect)
        Ketnoisua.Open()
        Dim Straddsua As String = "Update KhachHang set TenKH = @TenKH, SDT = @SDT, DiaChi = @DiaChi where MaKH = @MaKH"
        Dim Comsua As New SqlCommand(Straddsua, Ketnoisua)
        Try
            Comsua.Parameters.AddWithValue("@MaKH", txtMaKH.Text)
            Comsua.Parameters.AddWithValue("@TenKH", txtTenKH.Text)
            Comsua.Parameters.AddWithValue("@SDT", txtSDTKH.Text)
            Comsua.Parameters.AddWithValue("@DiaChi", txtDiaChiKH.Text)
            Comsua.ExecuteNonQuery()
            Ketnoisua.Close()
            MessageBox.Show("Sửa thành công")
        Catch ex As Exception
            MessageBox.Show("Sửa không thành công")
        End Try
        Loaddata()
    End Sub 'btnSuaKH_Click

    Private Sub btnXoaKH_Click(sender As Object, e As EventArgs) Handles btnXoaKH.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiconnect)
        connect.Open()
        Dim delete As String = "Delete from KhachHang where MaKH = @MaKH"
        Dim xoa As New SqlCommand(delete, connect)
        Try
            xoa.Parameters.AddWithValue("@MaKH", txtMaKH.Text)
            xoa.ExecuteNonQuery()
            connect.Close()
            MessageBox.Show("Xóa Thành Công")
        Catch ex As Exception
            MessageBox.Show("Xóa Không Thành Công")
        End Try
        Loaddata()
    End Sub 'btnXoaKH_Click

    Private Sub btnThoatKH_Click(sender As Object, e As EventArgs) Handles btnThoatKH.Click
        Me.Close()
    End Sub 'btnThoatKH_Click

End Class 'frmQuanLyKhachHang