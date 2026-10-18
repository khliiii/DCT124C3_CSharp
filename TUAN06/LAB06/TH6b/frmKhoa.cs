using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TH6b
{
    public partial class frmKhoa : Form
    {
        // Chuỗi kết nối SQL Server (giống bài 6a)
        string connStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLSinhVien;Integrated Security=True";

        public frmKhoa()
        {
            InitializeComponent();
        }

        // Hàm kiểm tra trùng Mã Khoa (Trả về true nếu mã CHƯA tồn tại)
        private bool KT_MaKhoa(string ma)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string sql = "SELECT COUNT(*) FROM Khoa WHERE MaKhoa = @ma";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ma", ma);

                    // ExecuteScalar trả về giá trị đầu tiên của dòng đầu tiên
                    int count = (int)cmd.ExecuteScalar();

                    if (count >= 1) return false; // Đã tồn tại
                    return true; // Chưa tồn tại
                }
            }
            catch { return false; }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaKhoa.Text) || string.IsNullOrWhiteSpace(txtTenKhoa.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Lỗi");
                return;
            }

            if (KT_MaKhoa(txtMaKhoa.Text) == true)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connStr))
                    {
                        conn.Open();
                        string sql = "INSERT INTO Khoa VALUES (@ma, @ten)";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@ma", txtMaKhoa.Text);
                        cmd.Parameters.AddWithValue("@ten", txtTenKhoa.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm thành công!");
                    }
                }
                catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
            }
            else
            {
                MessageBox.Show("Trùng mã khoa, không thể thêm!", "Lỗi");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // (Code Xóa và Sửa giống hệt bài 6a, bạn tự viết lại hoặc copy từ bài trước sang)
            // Lưu ý: Bảng Khoa đang bị ràng buộc khóa ngoại bởi bảng Lop, nên nếu xóa Khoa đang có Lớp, SQL sẽ báo lỗi.
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Tương tự bài 6a
        }
    }
}