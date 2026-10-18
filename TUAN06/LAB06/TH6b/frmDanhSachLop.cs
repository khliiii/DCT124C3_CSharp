using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TH6b
{
    public partial class frmDanhSachLop : Form
    {
        string connStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLSinhVien;Integrated Security=True";

        public frmDanhSachLop()
        {
            InitializeComponent();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            lvLop.Items.Clear(); // Xóa dữ liệu cũ trên ListView (nếu bấm nhiều lần)
            int stt = 1; // Biến đếm số thứ tự

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string sql = "SELECT MaLop, TenLop, MaKhoa FROM Lop";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader rd = cmd.ExecuteReader();

                    while (rd.Read())
                    {
                        // Tạo 1 dòng mới
                        ListViewItem item = new ListViewItem(stt.ToString());

                        // Thêm các cột tiếp theo
                        item.SubItems.Add(rd["MaLop"].ToString());
                        item.SubItems.Add(rd["TenLop"].ToString());
                        item.SubItems.Add(rd["MaKhoa"].ToString());

                        // Thêm dòng vào ListView
                        lvLop.Items.Add(item);
                        stt++;
                    }
                    rd.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng form
        }
    }
}