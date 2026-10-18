using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TH6a
{
    public partial class frmSinhVien : Form
    {
        string connStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLSinhVien;Integrated Security=True";

        public frmSinhVien()
        {
            InitializeComponent();
        }

        // --- CHỨC NĂNG THÊM ---
        private void btnThem_Click(object sender, EventArgs e)
        {
            // Yêu cầu: Không được để trống bất kỳ trường nào
            if (string.IsNullOrWhiteSpace(txtMaLop.Text) || string.IsNullOrWhiteSpace(txtMaSV.Text) ||
                string.IsNullOrWhiteSpace(txtTenSV.Text) || string.IsNullOrWhiteSpace(txtNgaySinh.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tất cả các trường!", "Lỗi");
                return;
            }

            // Kiểm tra định dạng ngày sinh (ví dụ: dd/MM/yyyy hoặc MM/dd/yyyy tùy máy bạn)
            DateTime ngaySinh;
            if (!DateTime.TryParse(txtNgaySinh.Text, out ngaySinh))
            {
                MessageBox.Show("Ngày sinh không hợp lệ! Vui lòng nhập theo định dạng (yyyy-MM-dd) hoặc (dd/MM/yyyy).", "Lỗi");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string sql = "INSERT INTO SinhVien (MaSinhVien, HoTen, NgaySinh, MaLop) VALUES (@maSV, @ten, @ngay, @maLop)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@maSV", txtMaSV.Text);
                    cmd.Parameters.AddWithValue("@ten", txtTenSV.Text);
                    cmd.Parameters.AddWithValue("@ngay", ngaySinh); // Truyền kiểu DateTime
                    cmd.Parameters.AddWithValue("@maLop", txtMaLop.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm sinh viên thành công!");
                }
            }
            catch (Exception ex)
            {
                // Lỗi thường gặp: Nhập Mã lớp không tồn tại trong bảng Lop
                MessageBox.Show("Thêm thất bại. Lỗi: " + ex.Message);
            }
        }

        // --- CHỨC NĂNG XÓA ---
        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Yêu cầu: Mã SV và Tên SV không được để trống, Mã lớp & Ngày sinh không cần nhập
            if (string.IsNullOrWhiteSpace(txtMaSV.Text) || string.IsNullOrWhiteSpace(txtTenSV.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã sinh viên và Tên sinh viên để xóa!", "Lỗi");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    // Xóa dòng có cả Mã SV và Tên SV trùng khớp
                    string sql = "DELETE FROM SinhVien WHERE MaSinhVien = @maSV AND HoTen = @ten";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@maSV", txtMaSV.Text);
                    cmd.Parameters.AddWithValue("@ten", txtTenSV.Text);

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0) MessageBox.Show("Xóa thành công!");
                    else MessageBox.Show("Không tìm thấy sinh viên nào có Mã và Tên này!");
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
            // Yêu cầu: Mã SV không được trống
            if (string.IsNullOrWhiteSpace(txtMaSV.Text))
            {
                MessageBox.Show("Mã sinh viên không được để trống!", "Lỗi");
                return;
            }

            // Yêu cầu: Ít nhất một trong 3 trường (Mã lớp, Tên, Ngày sinh) phải có dữ liệu
            if (string.IsNullOrWhiteSpace(txtMaLop.Text) && string.IsNullOrWhiteSpace(txtTenSV.Text) && string.IsNullOrWhiteSpace(txtNgaySinh.Text))
            {
                MessageBox.Show("Phải nhập ít nhất một thông tin cần sửa (Mã lớp, Tên hoặc Ngày sinh)!", "Lỗi");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    // Xây dựng câu lệnh SQL động (chỉ cập nhật những trường có dữ liệu)
                    string sql = "UPDATE SinhVien SET ";
                    SqlCommand cmd = new SqlCommand();
                    bool hasField = false;

                    if (!string.IsNullOrWhiteSpace(txtMaLop.Text))
                    {
                        sql += "MaLop = @maLop";
                        cmd.Parameters.AddWithValue("@maLop", txtMaLop.Text);
                        hasField = true;
                    }

                    if (!string.IsNullOrWhiteSpace(txtTenSV.Text))
                    {
                        if (hasField) sql += ", ";
                        sql += "HoTen = @ten";
                        cmd.Parameters.AddWithValue("@ten", txtTenSV.Text);
                        hasField = true;
                    }

                    if (!string.IsNullOrWhiteSpace(txtNgaySinh.Text))
                    {
                        DateTime ngaySinh;
                        if (!DateTime.TryParse(txtNgaySinh.Text, out ngaySinh))
                        {
                            MessageBox.Show("Ngày sinh không hợp lệ!", "Lỗi");
                            return;
                        }
                        if (hasField) sql += ", ";
                        sql += "NgaySinh = @ngay";
                        cmd.Parameters.AddWithValue("@ngay", ngaySinh);
                    }

                    // Thêm điều kiện WHERE
                    sql += " WHERE MaSinhVien = @maSV";
                    cmd.Parameters.AddWithValue("@maSV", txtMaSV.Text);

                    cmd.CommandText = sql;
                    cmd.Connection = conn;

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0) MessageBox.Show("Sửa thông tin thành công!");
                    else MessageBox.Show("Không tìm thấy sinh viên có mã này!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa thất bại. Lỗi: " + ex.Message);
            }
        }
    }
}