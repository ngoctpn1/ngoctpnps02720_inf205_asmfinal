Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frmDangNhap

    Private Sub btnNhapDN_Click(sender As Object, e As EventArgs) Handles btnNhapDN.Click
        Dim chuoiketnoi As String = "workstation id=ps02720.mssql.somee.com;packet size=4096;user id=ngoctpnps02720_SQLLogin_7;pwd=4hifjkxf1s;data source=ps02720.mssql.somee.com;persist security info=False;initial catalog=ps02720"

        Dim KetNoi As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim sqlAdapter As New SqlDataAdapter("select * from NhanVien where TenDangNhap='" & txtTenDangNhap.Text & "' and MatKhau='" & txtMatKhau.Text & "' ", KetNoi)
        Dim tb As New DataTable

        Try
            KetNoi.Open()
            sqlAdapter.Fill(tb)
            If tb.Rows.Count > 0 Then
                MessageBox.Show("Kết Nối Thành Công")
                frmMain.Show()
                Me.Hide()
            Else
                MessageBox.Show("Sai Tài Khoản Hoặc Mật Khẩu")
            End If

        Catch ex As Exception

        End Try
    End Sub 'btnNhapDN_Click

    Private Sub btnXoaDN_Click(sender As Object, e As EventArgs) Handles btnXoaDN.Click
        txtTenDangNhap.Clear()
        txtMatKhau.Clear()
        txtTenDangNhap.Focus()
    End Sub 'btnXoaDN_Click

    Private Sub btnThoatDN_Click(sender As Object, e As EventArgs) Handles btnThoatDN.Click
        Dim KTDN As String
        KTDN = (MessageBox.Show("Bạn có muốn thoát?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
        If (KTDN = DialogResult.Yes) Then
            Application.Exit()
        End If
    End Sub 'btnThoatDN_Click
End Class 'frmDangNhap
