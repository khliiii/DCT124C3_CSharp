using System;
using System.Data.SqlClient; // Thư viện kết nối SQL Server
using System.Windows.Forms;

namespace TH6a
{
    public partial class Form1 : Form
    {
        // Chuỗi kết nối (Đã khớp với LocalDB trên máy bạn)
        string connStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLSinhVien;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        // 1. CHỨC NĂNG THÊM
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaKhoa.Text) || string.IsNullOrWhiteSpace(txtTenKhoa.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã khoa và Tên khoa!", "Thông báo");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string sql = "INSERT INTO Khoa (MaKhoa, TenKhoa) VALUES (@ma, @ten)";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    // Dùng Parameter để tránh lỗi font tiếng Việt và SQL Injection
                    cmd.Parameters.AddWithValue("@ma", txtMaKhoa.Text);
                    cmd.Parameters.AddWithValue("@ten", txtTenKhoa.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại. Lỗi: " + ex.Message);
            }
        }

        // 2. CHỨC NĂNG XÓA
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaKhoa.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã khoa cần xóa!", "Thông báo");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string sql = "DELETE FROM Khoa WHERE MaKhoa = @ma";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ma", txtMaKhoa.Text);

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0) MessageBox.Show("Xóa thành công!");
                    else MessageBox.Show("Không tìm thấy Mã khoa này!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thất bại. Lỗi: " + ex.Message);
            }
        }

        // 3. CHỨC NĂNG SỬA
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaKhoa.Text) || string.IsNullOrWhiteSpace(txtTenKhoa.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã khoa và Tên khoa cần sửa!", "Thông báo");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string sql = "UPDATE Khoa SET TenKhoa = @ten WHERE MaKhoa = @ma";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ma", txtMaKhoa.Text);
                    cmd.Parameters.AddWithValue("@ten", txtTenKhoa.Text);

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0) MessageBox.Show("Sửa thành công!");
                    else MessageBox.Show("Không tìm thấy Mã khoa để sửa!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa thất bại. Lỗi: " + ex.Message);
            }
        }
    }
}