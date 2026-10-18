using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TH6b
{
    public partial class frmLop : Form
    {
        string connStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLSinhVien;Integrated Security=True";

        public frmLop()
        {
            InitializeComponent();
        }

        // 1. Load dữ liệu lên ComboBox khi Form chạy
        private void frmLop_Load(object sender, EventArgs e)
        {
            LoadKhoa_ComboBox();
        }

        private void LoadKhoa_ComboBox()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string sql = "SELECT MaKhoa FROM Khoa"; // Chỉ lấy Mã Khoa
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    SqlDataReader rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        cboKhoa.Items.Add(rd["MaKhoa"].ToString());
                    }
                    rd.Close();
                }
                // Chọn mặc định dòng đầu tiên
                if (cboKhoa.Items.Count > 0) cboKhoa.SelectedIndex = 0;
            }
            catch (Exception ex) { MessageBox.Show("Lỗi load ComboBox: " + ex.Message); }
        }

        // 2. Hàm kiểm tra trùng Mã Lớp
        public bool KT_KhoaChinh(string maLop)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string sql = "SELECT * FROM Lop WHERE MaLop = @ma";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", maLop);
                SqlDataReader rd = cmd.ExecuteReader();

                if (rd.HasRows) { rd.Close(); return false; } // Đã tồn tại
                else { rd.Close(); return true; } // Chưa tồn tại
            }
        }

        // 3. Chức năng Thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaLop.Text) || string.IsNullOrWhiteSpace(txtTenLop.Text) || cboKhoa.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin và chọn Khoa!", "Lỗi");
                return;
            }

            if (KT_KhoaChinh(txtMaLop.Text) == true)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connStr))
                    {
                        conn.Open();
                        string sql = "INSERT INTO Lop (MaLop, TenLop, MaKhoa) VALUES (@maLop, @tenLop, @maKhoa)";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@maLop", txtMaLop.Text);
                        cmd.Parameters.AddWithValue("@tenLop", txtTenLop.Text);
                        cmd.Parameters.AddWithValue("@maKhoa", cboKhoa.SelectedItem.ToString());

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm Lớp thành công!");
                    }
                }
                catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
            }
            else
            {
                MessageBox.Show("Trùng Mã lớp, không thể thêm!", "Lỗi");
            }
        }

        // 4. Chức năng Xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaLop.Text)) { MessageBox.Show("Nhập Mã lớp để xóa!"); return; }

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string sql = "DELETE FROM Lop WHERE MaLop = @maLop";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@maLop", txtMaLop.Text);

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0) MessageBox.Show("Xóa thành công!");
                    else MessageBox.Show("Không tìm thấy mã lớp!");
                }
            }
            catch (Exception ex) { MessageBox.Show("Không thể xóa (Có thể do ràng buộc dữ liệu Sinh Viên): " + ex.Message); }
        }

        // 5. Chức năng Sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaLop.Text) || string.IsNullOrWhiteSpace(txtTenLop.Text) || cboKhoa.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã lớp, Tên lớp và chọn Khoa để sửa!", "Lỗi");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string sql = "UPDATE Lop SET TenLop = @tenLop, MaKhoa = @maKhoa WHERE MaLop = @maLop";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@maLop", txtMaLop.Text);
                    cmd.Parameters.AddWithValue("@tenLop", txtTenLop.Text);
                    cmd.Parameters.AddWithValue("@maKhoa", cboKhoa.SelectedItem.ToString());

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0) MessageBox.Show("Sửa thành công!");
                    else MessageBox.Show("Không tìm thấy Mã lớp để sửa!");
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi sửa: " + ex.Message); }
        }
    }
}