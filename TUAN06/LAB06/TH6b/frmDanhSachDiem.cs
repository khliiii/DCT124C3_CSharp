using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TH6b
{
    public partial class frmDanhSachDiem : Form
    {
        string connStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLSinhVien;Integrated Security=True";

        public frmDanhSachDiem()
        {
            InitializeComponent();
        }

        // 1. Load dữ liệu khi Form chạy
        private void frmDanhSachDiem_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    // Thêm một item khoảng trắng đầu tiên (đại diện cho Tất cả)
                    cboMonHoc.Items.Add(" ");

                    string sql = "SELECT MaMonHoc FROM MonHoc";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        cboMonHoc.Items.Add(rd["MaMonHoc"].ToString());
                    }
                    rd.Close();
                }
                cboMonHoc.SelectedIndex = 0; // Mặc định chọn khoảng trắng

                // Hiển thị tất cả dữ liệu ban đầu
                HienThiDanhSach("");
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        // 2. Hàm hiển thị danh sách (Dùng chung cho cả lúc mới load và lúc lọc)
        private void HienThiDanhSach(string maMH_Loc)
        {
            lvDiem.Items.Clear();
            int stt = 1;
            float tongDiem = 0; // Biến tính tổng

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    // Câu lệnh JOIN 3 bảng để lấy Tên SV, Tên Môn, và Điểm
                    string sql = @"SELECT sv.HoTen, sv.NgaySinh, mh.TenMonHoc, d.Diem 
                                   FROM Diem d
                                   INNER JOIN SinhVien sv ON d.MaSinhVien = sv.MaSinhVien
                                   INNER JOIN MonHoc mh ON d.MaMonHoc = mh.MaMonHoc";

                    // Nếu có chọn môn học cụ thể (khác khoảng trắng) thì thêm điều kiện WHERE
                    if (maMH_Loc != "")
                    {
                        sql += " WHERE d.MaMonHoc = @maMH";
                    }

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    if (maMH_Loc != "")
                    {
                        cmd.Parameters.AddWithValue("@maMH", maMH_Loc);
                    }

                    SqlDataReader rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        ListViewItem item = new ListViewItem(stt.ToString());
                        item.SubItems.Add(rd["HoTen"].ToString());

                        // Định dạng lại ngày sinh cho đẹp (bỏ phần giờ phút giây)
                        DateTime ns = Convert.ToDateTime(rd["NgaySinh"]);
                        item.SubItems.Add(ns.ToString("dd/MM/yyyy"));

                        item.SubItems.Add(rd["TenMonHoc"].ToString());

                        float diem = Convert.ToSingle(rd["Diem"]);
                        item.SubItems.Add(diem.ToString());

                        lvDiem.Items.Add(item);

                        tongDiem += diem; // Cộng dồn điểm
                        stt++;
                    }
                    rd.Close();
                }

                // Gán tổng điểm ra TextBox
                txtTongDiem.Text = tongDiem.ToString();
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        // 3. Sự kiện nút Lọc
        private void btnLoc_Click(object sender, EventArgs e)
        {
            string maMH = cboMonHoc.SelectedItem.ToString().Trim();

            if (maMH == "") // Nếu chọn khoảng trắng -> Hiển thị tất cả
            {
                HienThiDanhSach("");
            }
            else // Chọn môn cụ thể -> Lọc theo môn
            {
                HienThiDanhSach(maMH);
            }
        }
    }
}