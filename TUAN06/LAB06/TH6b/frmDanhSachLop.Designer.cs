namespace TH6b
{
    partial class frmDanhSachLop
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
            this.btnHienThi = new System.Windows.Forms.Button();
            this.lvLop = new System.Windows.Forms.ListView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.STT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaLop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenLop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaKhoa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnHienThi
            // 
            this.btnHienThi.Location = new System.Drawing.Point(50, 42);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(161, 23);
            this.btnHienThi.TabIndex = 0;
            this.btnHienThi.Text = "Hiển thị dữ liệu";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // lvLop
            // 
            this.lvLop.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.MaLop,
            this.TenLop,
            this.MaKhoa});
            this.lvLop.FullRowSelect = true;
            this.lvLop.GridLines = true;
            this.lvLop.HideSelection = false;
            this.lvLop.Location = new System.Drawing.Point(50, 71);
            this.lvLop.Name = "lvLop";
            this.lvLop.Size = new System.Drawing.Size(655, 307);
            this.lvLop.TabIndex = 1;
            this.lvLop.UseCompatibleStateImageBehavior = false;
            this.lvLop.View = System.Windows.Forms.View.Details;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(630, 396);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // STT
            // 
            this.STT.Text = "STT";
            this.STT.Width = 50;
            // 
            // MaLop
            // 
            this.MaLop.Text = "Mã lớp";
            this.MaLop.Width = 100;
            // 
            // TenLop
            // 
            this.TenLop.Text = "Tên lớp";
            this.TenLop.Width = 200;
            // 
            // MaKhoa
            // 
            this.MaKhoa.Text = "Mã khoa";
            this.MaKhoa.Width = 100;
            // 
            // frmDanhSachLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lvLop);
            this.Controls.Add(this.btnHienThi);
            this.Name = "frmDanhSachLop";
            this.Text = "frmDanhSachLop";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.ListView lvLop;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ColumnHeader STT;
        private System.Windows.Forms.ColumnHeader MaLop;
        private System.Windows.Forms.ColumnHeader TenLop;
        private System.Windows.Forms.ColumnHeader MaKhoa;
    }
}