using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TH6b
{
    public partial class frmDiem_combo : Form
    {
        string connStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLSinhVien;Integrated Security=True";

        public frmDiem_combo()
        {
            InitializeComponent();
        }

        private void frmDiem_combo_Load(object sender, EventArgs e)
        {
            // Load Sinh Viên
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmdSV = new SqlCommand("SELECT MaSinhVien FROM SinhVien", conn);
                SqlDataReader rdSV = cmdSV.ExecuteReader();
                while (rdSV.Read()) cboSinhVien.Items.Add(rdSV[0].ToString());
                rdSV.Close();

                SqlCommand cmdMH = new SqlCommand("SELECT MaMonHoc FROM MonHoc", conn);
                SqlDataReader rdMH = cmdMH.ExecuteReader();
                while (rdMH.Read()) cboMonHoc.Items.Add(rdMH[0].ToString());
                rdMH.Close();
            }
            if (cboSinhVien.Items.Count > 0) cboSinhVien.SelectedIndex = 0;
            if (cboMonHoc.Items.Count > 0) cboMonHoc.SelectedIndex = 0;
        }

        // Hàm kiểm tra trùng khóa chính (MaSV + MaMH)
        private bool KT_KhoaChinh(string maSV, string maMH)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string sql = "SELECT COUNT(*) FROM Diem WHERE MaSinhVien = @maSV AND MaMonHoc = @maMH";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@maSV", maSV);
                cmd.Parameters.AddWithValue("@maMH", maMH);

                int count = (int)cmd.ExecuteScalar();
                return count == 0; // True là chưa tồn tại (được thêm)
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDiem.Text) || cboSinhVien.SelectedIndex == -1 || cboMonHoc.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đủ dữ liệu!", "Lỗi");
                return;
            }

            float diem;
            if (!float.TryParse(txtDiem.Text, out diem) || diem < 0 || diem > 10)
            {
                MessageBox.Show("Điểm phải là số từ 0 đến 10!", "Lỗi");
                return;
            }

            string maSV = cboSinhVien.SelectedItem.ToString();
            string maMH = cboMonHoc.SelectedItem.ToString();

            if (KT_KhoaChinh(maSV, maMH) == true)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connStr))
                    {
                        conn.Open();
                        string sql = "INSERT INTO Diem VALUES (@maSV, @maMH, @diem)";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@maSV", maSV);
                        cmd.Parameters.AddWithValue("@maMH", maMH);
                        cmd.Parameters.AddWithValue("@diem", diem);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm điểm thành công!");
                    }
                }
                catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
            }
            else
            {
                MessageBox.Show("Sinh viên này đã có điểm môn học này rồi!", "Lỗi");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (cboSinhVien.SelectedIndex == -1 || cboMonHoc.SelectedIndex == -1) return;

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string sql = "DELETE FROM Diem WHERE MaSinhVien = @maSV AND MaMonHoc = @maMH";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@maSV", cboSinhVien.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@maMH", cboMonHoc.SelectedItem.ToString());

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0) MessageBox.Show("Xóa thành công!");
                    else MessageBox.Show("Không tìm thấy dữ liệu!");
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDiem.Text)) return;

            float diem;
            if (!float.TryParse(txtDiem.Text, out diem) || diem < 0 || diem > 10)
            {
                MessageBox.Show("Điểm phải từ 0 đến 10!"); return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string sql = "UPDATE Diem SET Diem = @diem WHERE MaSinhVien = @maSV AND MaMonHoc = @maMH";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@maSV", cboSinhVien.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@maMH", cboMonHoc.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@diem", diem);

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0) MessageBox.Show("Sửa thành công!");
                    else MessageBox.Show("Không tìm thấy dữ liệu!");
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }
    }
}