using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TH6b
{
    public partial class frmSinhvien_Combo : Form
    {
        string connStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLSinhVien;Integrated Security=True";

        public frmSinhvien_Combo()
        {
            InitializeComponent();
        }

        // 1. Load dữ liệu Mã Lớp lên ComboBox khi Form chạy
        private void frmSinhvien_Combo_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string sql = "SELECT MaLop FROM Lop";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        cboLop.Items.Add(rd["MaLop"].ToString());
                    }
                    rd.Close();
                }
                if (cboLop.Items.Count > 0) cboLop.SelectedIndex = 0;
            }
            catch (Exception ex) { MessageBox.Show("Lỗi load ComboBox: " + ex.Message); }
        }

        // 2. Hàm kiểm tra trùng Mã Sinh Viên (Trả về true nếu mã CHƯA tồn tại)
        private bool KT_MaSV(string ma)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string sql = "SELECT COUNT(*) FROM SinhVien WHERE MaSinhVien = @ma";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ma", ma);

                    int count = (int)cmd.ExecuteScalar();
                    if (count >= 1) return false; // Đã tồn tại
                    return true; // Chưa tồn tại
                }
            }
            catch { return false; }
        }

        // 3. CHỨC NĂNG THÊM
        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra không được để trống
            if (string.IsNullOrWhiteSpace(txtMaSV.Text) || string.IsNullOrWhiteSpace(txtHoTen.Text) ||
                string.IsNullOrWhiteSpace(txtNgaySinh.Text) || cboLop.SelectedIndex == -1)
            {
                MessageBox.Show("Tất cả thông tin phải được nhập dữ liệu!", "Lỗi");
                return;
            }

            // Kiểm tra định dạng ngày sinh
            DateTime ngaySinh;
            if (!DateTime.TryParse(txtNgaySinh.Text, out ngaySinh))
            {
                MessageBox.Show("Ngày sinh không hợp lệ (VD: 2003-05-15)!", "Lỗi");
                return;
            }

            // Kiểm tra tuổi >= 17 (Tính theo năm sinh)
            int tuoi = DateTime.Now.Year - ngaySinh.Year;
            if (tuoi < 17)
            {
                MessageBox.Show("Sinh viên phải có tuổi từ 17 trở lên!", "Lỗi");
                return;
            }

            // Kiểm tra trùng mã
            if (KT_MaSV(txtMaSV.Text) == true)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connStr))
                    {
                        conn.Open();
                        string sql = "INSERT INTO SinhVien (MaSinhVien, HoTen, NgaySinh, MaLop) VALUES (@ma, @ten, @ns, @malop)";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@ma", txtMaSV.Text);
                        cmd.Parameters.AddWithValue("@ten", txtHoTen.Text);
                        cmd.Parameters.AddWithValue("@ns", ngaySinh);
                        cmd.Parameters.AddWithValue("@malop", cboLop.SelectedItem.ToString());

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm Sinh viên thành công!");
                    }
                }
                catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
            }
            else
            {
                MessageBox.Show("Mã sinh viên đã tồn tại, không thể thêm!", "Lỗi");
            }
        }

        // 4. CHỨC NĂNG XÓA
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã SV cần xóa!", "Lỗi");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    // Xóa sinh viên (Nếu SV này đã có điểm trong bảng Diem, SQL sẽ báo lỗi khóa ngoại)
                    string sql = "DELETE FROM SinhVien WHERE MaSinhVien = @ma";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ma", txtMaSV.Text);

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0) MessageBox.Show("Xóa thành công!");
                    else MessageBox.Show("Không tìm thấy sinh viên này!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể xóa (Có thể sinh viên này đã có Điểm): " + ex.Message);
            }
        }

        // 5. CHỨC NĂNG SỬA
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã SV để sửa!", "Lỗi");
                return;
            }

            DateTime ngaySinh;
            if (!DateTime.TryParse(txtNgaySinh.Text, out ngaySinh))
            {
                MessageBox.Show("Ngày sinh không hợp lệ!", "Lỗi");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string sql = "UPDATE SinhVien SET HoTen = @ten, NgaySinh = @ns, MaLop = @malop WHERE MaSinhVien = @ma";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ma", txtMaSV.Text);
                    cmd.Parameters.AddWithValue("@ten", txtHoTen.Text);
                    cmd.Parameters.AddWithValue("@ns", ngaySinh);
                    cmd.Parameters.AddWithValue("@malop", cboLop.SelectedItem.ToString());

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0) MessageBox.Show("Sửa thành công!");
                    else MessageBox.Show("Không tìm thấy sinh viên để sửa!");
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi sửa: " + ex.Message); }
        }
    }
}