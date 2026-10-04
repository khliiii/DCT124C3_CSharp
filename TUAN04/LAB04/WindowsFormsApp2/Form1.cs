using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        int tongLuotKhach = 0;
        int tongTien = 0;
        public Form1()
        {

            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            HoTen.Focus();

            btnThanhtoan.Enabled = false;
            btnNhapmoi.Enabled = false;
            btnTongKet.Enabled = false;
        }
        private void KiemTraThongTin(object sender, EventArgs e)
        {
            int soNgay;

            btnThanhtoan.Enabled =
                HoTen.Text != "" &&
                txtDiaChi.Text != "" &&
                int.TryParse(txtSoNgay.Text, out soNgay) &&
                soNgay > 0 &&
                (rdoPhongDon.Checked ||
                 rdoPhongDoi.Checked ||
                 rdoPhongBa.Checked);
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            int soNgay = int.Parse(txtSoNgay.Text);
            int tienPhong = 0;

            if (rdoPhongDon.Checked)
                tienPhong = 300000 * soNgay;
            else if (rdoPhongDoi.Checked)
                tienPhong = 350000 * soNgay;
            else if (rdoPhongBa.Checked)
                tienPhong = 400000 * soNgay;

            int tienTienNghi = 0;

            if (chkTivi.Checked)
                tienTienNghi += 10000;

            if (chkInternet.Checked)
                tienTienNghi += 10000;

            if (chkNuocNong.Checked)
                tienTienNghi += 10000;

            int tienDichVu = 0;

            if (chkKaraoke.Checked)
                tienDichVu += 50000;

            if (chkAnSang.Checked)
                tienDichVu += 15000 * soNgay;

                int thanhTien = tienPhong + tienTienNghi + tienDichVu;

            txtThanhtien.Text = thanhTien.ToString("N0") + " VND";

            tongLuotKhach++;
            tongTien += thanhTien;

            btnNhapmoi.Enabled = true;
            btnTongKet.Enabled = true;
            btnThanhtoan.Enabled = false;
        }
        private void btnNhapMoi_Click(object sender, EventArgs e)
        {
            HoTen.Clear();
            txtDiaChi.Clear();
            txtSoNgay.Clear();
            txtThanhtien.Clear();

            rdoPhongDon.Checked = false;
            rdoPhongDoi.Checked = false;
            rdoPhongBa.Checked = false;

            chkTivi.Checked = false;
            chkInternet.Checked = false;
            chkNuocNong.Checked = false;
            chkKaraoke.Checked = false;
            chkAnSang.Checked = false;

            btnThanhtoan.Enabled = false;
            btnNhapmoi.Enabled = false;

            HoTen.Focus();
        }
        private void btnTongKet_Click(object sender, EventArgs e)
        {
            txtSoLuotNguoi.Text = tongLuotKhach.ToString();
            txtTongSoTien.Text = tongTien.ToString("N0") + " VND";

            tongLuotKhach = 0;
            tongTien = 0;

            btnTongKet.Enabled = false;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
