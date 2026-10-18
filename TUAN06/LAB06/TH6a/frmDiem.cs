using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TH6a
{
    public partial class frmDiem : Form
    {
        string connStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLSinhVien;Integrated Security=True";

        public frmDiem()
        {
            InitializeComponent();
        }

        // --- CHỨC NĂNG THÊM ---
        private void btnThem_Click(object sender, EventArgs e)
        {
            // Yêu cầu: Không được để trống trường nào
            if (string.IsNullOrWhiteSpace(txtMaSV.Text) || string.IsNullOrWhiteSpace(txtMaMH.Text) || string.IsNullOrWhiteSpace(txtDiem.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã SV, Mã MH và Điểm!", "Lỗi");
                return;
            }

            // Yêu cầu: Điểm phải là số
            float diem;
            if (!float.TryParse(txtDiem.Text, out diem))
            {
                MessageBox.Show("Điểm phải là một con số (ví dụ: 8.5)!", "Lỗi");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string sql = "INSERT INTO Diem (MaSinhVien, MaMonHoc, Diem) VALUES (@maSV, @maMH, @diem)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@maSV", txtMaSV.Text);
                    cmd.Parameters.AddWithValue("@maMH", txtMaMH.Text);
                    cmd.Parameters.AddWithValue("@diem", diem); // Truyền kiểu số thực

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm điểm thành công!");
                }
            }
            catch (Exception ex)
            {
                // Lỗi thường gặp: Trùng khóa chính (SV này đã có điểm môn này rồi) 
                // hoặc Mã SV/Mã MH không tồn tại
                MessageBox.Show("Thêm thất bại. Lỗi: " + ex.Message);
            }
        }

        // --- CHỨC NĂNG XÓA ---
        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Yêu cầu: Mã SV, Mã MH không được để trống, Điểm không cần nhập
            if (string.IsNullOrWhiteSpace(txtMaSV.Text) || string.IsNullOrWhiteSpace(txtMaMH.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã SV và Mã MH cần xóa!", "Lỗi");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string sql = "DELETE FROM Diem WHERE MaSinhVien = @maSV AND MaMonHoc = @maMH";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@maSV", txtMaSV.Text);
                    cmd.Parameters.AddWithValue("@maMH", txtMaMH.Text);

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0) MessageBox.Show("Xóa điểm thành công!");
                    else MessageBox.Show("Không tìm thấy dữ liệu điểm của sinh viên này!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thất bại. Lỗi: " + ex.Message);
            }
        }

        // --- CHỨC NĂNG SỬA ---
        private void btnSua_Click(object sender, EventArgs e)
        {
            // Yêu cầu: Mã SV, Mã MH, Điểm không được để trống
            if (string.IsNullOrWhiteSpace(txtMaSV.Text) || string.IsNullOrWhiteSpace(txtMaMH.Text) || string.IsNullOrWhiteSpace(txtDiem.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã SV, Mã MH và Điểm mới!", "Lỗi");
                return;
            }

            // Yêu cầu: Điểm phải là số
            float diem;
            if (!float.TryParse(txtDiem.Text, out diem))
            {
                MessageBox.Show("Điểm phải là một con số!", "Lỗi");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string sql = "UPDATE Diem SET Diem = @diem WHERE MaSinhVien = @maSV AND MaMonHoc = @maMH";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@maSV", txtMaSV.Text);
                    cmd.Parameters.AddWithValue("@maMH", txtMaMH.Text);
                    cmd.Parameters.AddWithValue("@diem", diem);

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0) MessageBox.Show("Sửa điểm thành công!");
                    else MessageBox.Show("Không tìm thấy dữ liệu để sửa!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa thất bại. Lỗi: " + ex.Message);
            }
        }
    }
}