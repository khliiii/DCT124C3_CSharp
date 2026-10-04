namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chkAnSang = new System.Windows.Forms.CheckBox();
            this.chkKaraoke = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkNuocNong = new System.Windows.Forms.CheckBox();
            this.chkInternet = new System.Windows.Forms.CheckBox();
            this.chkTivi = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdoPhongBa = new System.Windows.Forms.RadioButton();
            this.rdoPhongDoi = new System.Windows.Forms.RadioButton();
            this.rdoPhongDon = new System.Windows.Forms.RadioButton();
            this.txtSoNgay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HoTen = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtTongSoTien = new System.Windows.Forms.TextBox();
            this.txtSoLuotNguoi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTongKet = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtThanhtien = new System.Windows.Forms.TextBox();
            this.btnNhapmoi = new System.Windows.Forms.Button();
            this.btnThanhtoan = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(99, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(948, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "KHÁCH SẠN THANH THANH - TRẢ PHÒNG";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.txtSoNgay);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.HoTen);
            this.groupBox1.Location = new System.Drawing.Point(36, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 759);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.TextChanged += new System.EventHandler(this.Form1_Load);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chkAnSang);
            this.groupBox5.Controls.Add(this.chkKaraoke);
            this.groupBox5.Location = new System.Drawing.Point(500, 283);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(233, 247);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Dịch vụ";
            // 
            // chkAnSang
            // 
            this.chkAnSang.AutoSize = true;
            this.chkAnSang.Location = new System.Drawing.Point(29, 129);
            this.chkAnSang.Name = "chkAnSang";
            this.chkAnSang.Size = new System.Drawing.Size(78, 20);
            this.chkAnSang.TabIndex = 4;
            this.chkAnSang.Text = "Ăn sáng";
            this.chkAnSang.UseVisualStyleBackColor = true;
            // 
            // chkKaraoke
            // 
            this.chkKaraoke.AutoSize = true;
            this.chkKaraoke.Location = new System.Drawing.Point(29, 54);
            this.chkKaraoke.Name = "chkKaraoke";
            this.chkKaraoke.Size = new System.Drawing.Size(80, 20);
            this.chkKaraoke.TabIndex = 5;
            this.chkKaraoke.Text = "Karaoke";
            this.chkKaraoke.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkNuocNong);
            this.groupBox4.Controls.Add(this.chkInternet);
            this.groupBox4.Controls.Add(this.chkTivi);
            this.groupBox4.Location = new System.Drawing.Point(261, 283);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(233, 247);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tiện nghi";
            // 
            // chkNuocNong
            // 
            this.chkNuocNong.AutoSize = true;
            this.chkNuocNong.Location = new System.Drawing.Point(20, 202);
            this.chkNuocNong.Name = "chkNuocNong";
            this.chkNuocNong.Size = new System.Drawing.Size(120, 20);
            this.chkNuocNong.TabIndex = 2;
            this.chkNuocNong.Text = "Máy nước nóng";
            this.chkNuocNong.UseVisualStyleBackColor = true;
            // 
            // chkInternet
            // 
            this.chkInternet.AutoSize = true;
            this.chkInternet.Location = new System.Drawing.Point(20, 130);
            this.chkInternet.Name = "chkInternet";
            this.chkInternet.Size = new System.Drawing.Size(72, 20);
            this.chkInternet.TabIndex = 1;
            this.chkInternet.Text = "Internet";
            this.chkInternet.UseVisualStyleBackColor = true;
            // 
            // chkTivi
            // 
            this.chkTivi.AutoSize = true;
            this.chkTivi.Location = new System.Drawing.Point(20, 55);
            this.chkTivi.Name = "chkTivi";
            this.chkTivi.Size = new System.Drawing.Size(51, 20);
            this.chkTivi.TabIndex = 0;
            this.chkTivi.Text = "Tivi";
            this.chkTivi.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdoPhongBa);
            this.groupBox3.Controls.Add(this.rdoPhongDoi);
            this.groupBox3.Controls.Add(this.rdoPhongDon);
            this.groupBox3.Location = new System.Drawing.Point(22, 283);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(233, 247);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Loại phòng";
            // 
            // rdoPhongBa
            // 
            this.rdoPhongBa.AutoSize = true;
            this.rdoPhongBa.Location = new System.Drawing.Point(13, 201);
            this.rdoPhongBa.Name = "rdoPhongBa";
            this.rdoPhongBa.Size = new System.Drawing.Size(86, 20);
            this.rdoPhongBa.TabIndex = 2;
            this.rdoPhongBa.TabStop = true;
            this.rdoPhongBa.Text = "Phòng ba";
            this.rdoPhongBa.UseVisualStyleBackColor = true;
            this.rdoPhongBa.CheckedChanged += new System.EventHandler(this.KiemTraThongTin);
            // 
            // rdoPhongDoi
            // 
            this.rdoPhongDoi.AutoSize = true;
            this.rdoPhongDoi.Location = new System.Drawing.Point(13, 129);
            this.rdoPhongDoi.Name = "rdoPhongDoi";
            this.rdoPhongDoi.Size = new System.Drawing.Size(89, 20);
            this.rdoPhongDoi.TabIndex = 1;
            this.rdoPhongDoi.TabStop = true;
            this.rdoPhongDoi.Text = "Phòng đôi";
            this.rdoPhongDoi.UseVisualStyleBackColor = true;
            this.rdoPhongDoi.CheckedChanged += new System.EventHandler(this.KiemTraThongTin);
            // 
            // rdoPhongDon
            // 
            this.rdoPhongDon.AutoSize = true;
            this.rdoPhongDon.Location = new System.Drawing.Point(13, 54);
            this.rdoPhongDon.Name = "rdoPhongDon";
            this.rdoPhongDon.Size = new System.Drawing.Size(93, 20);
            this.rdoPhongDon.TabIndex = 0;
            this.rdoPhongDon.TabStop = true;
            this.rdoPhongDon.Text = "Phòng đơn";
            this.rdoPhongDon.UseVisualStyleBackColor = true;
            this.rdoPhongDon.CheckedChanged += new System.EventHandler(this.KiemTraThongTin);
            // 
            // txtSoNgay
            // 
            this.txtSoNgay.Location = new System.Drawing.Point(166, 180);
            this.txtSoNgay.Multiline = true;
            this.txtSoNgay.Name = "txtSoNgay";
            this.txtSoNgay.Size = new System.Drawing.Size(149, 36);
            this.txtSoNgay.TabIndex = 5;
            this.txtSoNgay.TextChanged += new System.EventHandler(this.KiemTraThongTin);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(30, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 36);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số ngày ở :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(166, 115);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(554, 36);
            this.txtDiaChi.TabIndex = 3;
            this.txtDiaChi.TextChanged += new System.EventHandler(this.KiemTraThongTin);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(30, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa chỉ :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(30, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và tên :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // HoTen
            // 
            this.HoTen.Location = new System.Drawing.Point(166, 50);
            this.HoTen.Multiline = true;
            this.HoTen.Name = "HoTen";
            this.HoTen.Size = new System.Drawing.Size(306, 36);
            this.HoTen.TabIndex = 0;
            this.HoTen.TextChanged += new System.EventHandler(this.KiemTraThongTin);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.btnTongKet);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtThanhtien);
            this.groupBox2.Controls.Add(this.btnNhapmoi);
            this.groupBox2.Controls.Add(this.btnThanhtoan);
            this.groupBox2.Location = new System.Drawing.Point(791, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(414, 759);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(11, 476);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(176, 36);
            this.button4.TabIndex = 8;
            this.button4.Text = "Thoát";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtTongSoTien);
            this.groupBox6.Controls.Add(this.txtSoLuotNguoi);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Location = new System.Drawing.Point(23, 246);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(375, 186);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Thông tin tổng kết";
            // 
            // txtTongSoTien
            // 
            this.txtTongSoTien.Location = new System.Drawing.Point(161, 112);
            this.txtTongSoTien.Multiline = true;
            this.txtTongSoTien.Name = "txtTongSoTien";
            this.txtTongSoTien.Size = new System.Drawing.Size(193, 36);
            this.txtTongSoTien.TabIndex = 7;
            // 
            // txtSoLuotNguoi
            // 
            this.txtSoLuotNguoi.Location = new System.Drawing.Point(161, 47);
            this.txtSoLuotNguoi.Multiline = true;
            this.txtSoLuotNguoi.Name = "txtSoLuotNguoi";
            this.txtSoLuotNguoi.Size = new System.Drawing.Size(193, 36);
            this.txtSoLuotNguoi.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(15, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 36);
            this.label7.TabIndex = 5;
            this.label7.Text = "Tổng số tiền :";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(15, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 36);
            this.label6.TabIndex = 4;
            this.label6.Text = "Số lượt người : ";
            // 
            // btnTongKet
            // 
            this.btnTongKet.Location = new System.Drawing.Point(11, 180);
            this.btnTongKet.Name = "btnTongKet";
            this.btnTongKet.Size = new System.Drawing.Size(176, 36);
            this.btnTongKet.TabIndex = 4;
            this.btnTongKet.Text = "Tổng kết";
            this.btnTongKet.UseVisualStyleBackColor = true;
            this.btnTongKet.Click += new System.EventHandler(this.btnTongKet_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(6, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 36);
            this.label5.TabIndex = 3;
            this.label5.Text = "Thành tiền :";
            // 
            // txtThanhtien
            // 
            this.txtThanhtien.Location = new System.Drawing.Point(128, 115);
            this.txtThanhtien.Multiline = true;
            this.txtThanhtien.Name = "txtThanhtien";
            this.txtThanhtien.Size = new System.Drawing.Size(257, 36);
            this.txtThanhtien.TabIndex = 2;
            // 
            // btnNhapmoi
            // 
            this.btnNhapmoi.Location = new System.Drawing.Point(209, 43);
            this.btnNhapmoi.Name = "btnNhapmoi";
            this.btnNhapmoi.Size = new System.Drawing.Size(176, 36);
            this.btnNhapmoi.TabIndex = 1;
            this.btnNhapmoi.Text = "Nhập mới";
            this.btnNhapmoi.UseVisualStyleBackColor = true;
            this.btnNhapmoi.Click += new System.EventHandler(this.btnNhapMoi_Click);
            // 
            // btnThanhtoan
            // 
            this.btnThanhtoan.Location = new System.Drawing.Point(28, 43);
            this.btnThanhtoan.Name = "btnThanhtoan";
            this.btnThanhtoan.Size = new System.Drawing.Size(176, 36);
            this.btnThanhtoan.TabIndex = 0;
            this.btnThanhtoan.Text = "Thanh toán";
            this.btnThanhtoan.UseVisualStyleBackColor = true;
            this.btnThanhtoan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 628);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox HoTen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox chkAnSang;
        private System.Windows.Forms.CheckBox chkKaraoke;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chkNuocNong;
        private System.Windows.Forms.CheckBox chkInternet;
        private System.Windows.Forms.CheckBox chkTivi;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdoPhongBa;
        private System.Windows.Forms.RadioButton rdoPhongDoi;
        private System.Windows.Forms.RadioButton rdoPhongDon;
        private System.Windows.Forms.TextBox txtSoNgay;
        private System.Windows.Forms.Button btnThanhtoan;
        private System.Windows.Forms.Button btnNhapmoi;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTongKet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtThanhtien;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtTongSoTien;
        private System.Windows.Forms.TextBox txtSoLuotNguoi;
        private System.Windows.Forms.Label label7;
    }
}

