using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TH6a
{
    public partial class frmMonHoc : Form
    {
        // Chuỗi kết nối (giống hệt bài trước)
        string connStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLSinhVien;Integrated Security=True";

        public frmMonHoc()
        {
            InitializeComponent();
        }

        // CHỨC NĂNG THÊM
        private void btnThem_Click(object sender, EventArgs e)
        {
            // Yêu cầu: Mã môn học, Tên môn học không được để trống
            if (string.IsNullOrWhiteSpace(txtMaMH.Text) || string.IsNullOrWhiteSpace(txtTenMH.Text))
            {
                MessageBox.Show("Mã môn học và Tên môn học không được để trống!", "Lỗi");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string sql = "INSERT INTO MonHoc (MaMonHoc, TenMonHoc) VALUES (@ma, @ten)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ma", txtMaMH.Text);
                    cmd.Parameters.AddWithValue("@ten", txtTenMH.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm môn học thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại. Lỗi: " + ex.Message);
            }
        }

        // CHỨC NĂNG XÓA
        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Yêu cầu: Mã môn học không được để trống, Tên môn học không nhập dữ liệu
            if (string.IsNullOrWhiteSpace(txtMaMH.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã môn học cần xóa!", "Lỗi");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string sql = "DELETE FROM MonHoc WHERE MaMonHoc = @ma";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ma", txtMaMH.Text);

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0) MessageBox.Show("Xóa thành công!");
                    else MessageBox.Show("Không tìm thấy Mã môn học này!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thất bại. Lỗi: " + ex.Message);
            }
        }

        // CHỨC NĂNG SỬA
        private void btnSua_Click(object sender, EventArgs e)
        {
            // Yêu cầu: Mã môn học, Tên môn học không được để trống
            if (string.IsNullOrWhiteSpace(txtMaMH.Text) || string.IsNullOrWhiteSpace(txtTenMH.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã môn học và Tên môn học cần sửa!", "Lỗi");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string sql = "UPDATE MonHoc SET TenMonHoc = @ten WHERE MaMonHoc = @ma";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ma", txtMaMH.Text);
                    cmd.Parameters.AddWithValue("@ten", txtTenMH.Text);

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0) MessageBox.Show("Sửa thành công!");
                    else MessageBox.Show("Không tìm thấy Mã môn học để sửa!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa thất bại. Lỗi: " + ex.Message);
            }
        }
    }
}