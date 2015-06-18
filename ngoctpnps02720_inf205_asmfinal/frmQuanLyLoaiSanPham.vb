Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmQuanLyLoaiSanPham

    Dim database As New DataTable ' Tạo đối tượng database để lưu trữ dữ liệu từ Database Online'
    'Tạo chuỗi kết nối để kết nối tới Database Online'
    Dim chuoiconnect As String = "workstation id=ps02720.mssql.somee.com;packet size=4096;user id=ngoctpnps02720_SQLLogin_7;pwd=4hifjkxf1s;data source=ps02720.mssql.somee.com;persist security info=False;initial catalog=ps02720"
    Dim connect As SqlConnection = New SqlConnection(chuoiconnect)

    Private Sub frmQuanLyLoaiSanPham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connect As SqlConnection = New SqlConnection(chuoiconnect) ' Tạo đối tượng kết nối tới DB  Online'
        ' Câu truy vấn để get dữ liệu'
        Dim Query1 As SqlDataAdapter = New SqlDataAdapter("select * from LoaiSanPham", connect)
        'Kết nối mở ra
        connect.Open()
        'Đổ dữ liệu vào đối tượng database'
        Query1.Fill(database)
        'Hiển thị dữ liệu ra Datagridview'
        dgvDanhSachLoai.DataSource = database.DefaultView
    End Sub 'frmQuanLyLoaiSanPham_Load

    Private Sub Loaddata()
        database.Clear()
        dgvDanhSachLoai.DataSource = database
        dgvDanhSachLoai.DataSource = Nothing
        Dim connect As SqlConnection = New SqlConnection(chuoiconnect)
        Dim Query1 As SqlDataAdapter = New SqlDataAdapter("select * from LoaiSanPham", connect)

        connect.Open()
        Query1.Fill(database)
        dgvDanhSachLoai.DataSource = database.DefaultView
    End Sub 'Loaddata()

    Private Sub dgvDanhSachLoai_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDanhSachLoai.CellContentClick
        Dim index As Integer = dgvDanhSachLoai.CurrentCell.RowIndex
        txtMaLoai.Text = dgvDanhSachLoai.Item(0, index).Value
        txtTenLoai.Text = dgvDanhSachLoai.Item(1, index).Value
    End Sub 'dgvDanhSachLoai_CellContentClick

    Private Sub btnThemLoai_Click(sender As Object, e As EventArgs) Handles btnThemLoai.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiconnect)
        'Tạo query câu truy vấn Insert into'
        Dim Add As String = "insert into LoaiSanPham values (@MaLoai,@TenLoai)"
        'Tạo đối tượng để thực thi câu truy vấn với DB online'
        Dim them As New SqlCommand(Add, connect)
        'Kết nối mở ra
        connect.Open()

        Try
            'Truyền giá trị trong các ô textbox cho các biến tương ứng'
            them.Parameters.AddWithValue("@MaLoai", txtMaLoai.Text)
            them.Parameters.AddWithValue("@TenLoai", txtTenLoai.Text)

            MessageBox.Show("Thêm loại sản phẩm thành công!")
            'Exucute là ghi dữ liệu vào Database'
            them.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Không thành công!")

        End Try
        'Cập nhật dữ liệu'
        Loaddata()
    End Sub 'btnThemLoai_Click

    Private Sub btnSuaLoai_Click(sender As Object, e As EventArgs) Handles btnSuaLoai.Click
        Dim Ketnoisua As New SqlConnection(chuoiconnect)
        Ketnoisua.Open()
        Dim Straddsua As String = "Update LoaiSanPham set TenLoai = @TenLoai where MaLoai = @MaLoai"
        Dim Comsua As New SqlCommand(Straddsua, Ketnoisua)
        Try
            Comsua.Parameters.AddWithValue("@MaSP", txtMaLoai.Text)
            Comsua.Parameters.AddWithValue("@TenSP", txtTenLoai.Text)
            Comsua.ExecuteNonQuery()
            Ketnoisua.Close()
            MessageBox.Show("Sửa thành công")
        Catch ex As Exception
            MessageBox.Show("Sửa không thành công")
        End Try
        Loaddata()
    End Sub 'btnSuaLoai_Click

    Private Sub btnXoaLoai_Click(sender As Object, e As EventArgs) Handles btnXoaLoai.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiconnect)
        connect.Open()
        Dim delete As String = "Delete from LoaiSanPham where MaLoai = @MaLoai"
        Dim xoa As New SqlCommand(delete, connect)
        Try
            xoa.Parameters.AddWithValue("@MaLoai", txtMaLoai.Text)
            xoa.ExecuteNonQuery()
            MessageBox.Show("Xóa Thành Công")
        Catch ex As Exception
            MessageBox.Show("Xóa Không Thành Công")
        End Try
        Loaddata()
    End Sub 'btnXoaLoai_Click

    Private Sub btnThoatLoai_Click(sender As Object, e As EventArgs) Handles btnThoatLoai.Click
        Me.Close()
    End Sub 'btnThoatLoai_Click
End Class 'frmQuanLyLoaiSanPham