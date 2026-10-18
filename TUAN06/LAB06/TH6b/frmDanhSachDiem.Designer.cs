namespace TH6b
{
    partial class frmDanhSachDiem
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
            this.cboMonHoc = new System.Windows.Forms.ComboBox();
            this.btnLoc = new System.Windows.Forms.Button();
            this.lvDiem = new System.Windows.Forms.ListView();
            this.STT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NgaySinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenMH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Diem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.txtTongDiem = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Môn học";
            // 
            // cboMonHoc
            // 
            this.cboMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMonHoc.FormattingEnabled = true;
            this.cboMonHoc.Location = new System.Drawing.Point(120, 26);
            this.cboMonHoc.Name = "cboMonHoc";
            this.cboMonHoc.Size = new System.Drawing.Size(204, 24);
            this.cboMonHoc.TabIndex = 2;
            this.cboMonHoc.SelectedIndexChanged += new System.EventHandler(this.cboMonHoc_SelectedIndexChanged);
            // 
            // btnLoc
            // 
            this.btnLoc.Location = new System.Drawing.Point(414, 26);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(129, 23);
            this.btnLoc.TabIndex = 3;
            this.btnLoc.Text = "Lọc dữ liệu";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // lvDiem
            // 
            this.lvDiem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.TenSV,
            this.NgaySinh,
            this.TenMH,
            this.Diem});
            this.lvDiem.FullRowSelect = true;
            this.lvDiem.GridLines = true;
            this.lvDiem.HideSelection = false;
            this.lvDiem.Location = new System.Drawing.Point(45, 70);
            this.lvDiem.Name = "lvDiem";
            this.lvDiem.Size = new System.Drawing.Size(605, 310);
            this.lvDiem.TabIndex = 4;
            this.lvDiem.UseCompatibleStateImageBehavior = false;
            this.lvDiem.View = System.Windows.Forms.View.Details;
            // 
            // STT
            // 
            this.STT.Text = "STT";
            this.STT.Width = 50;
            // 
            // TenSV
            // 
            this.TenSV.Text = "Tên SV";
            this.TenSV.Width = 150;
            // 
            // NgaySinh
            // 
            this.NgaySinh.Text = "Ngày sinh";
            this.NgaySinh.Width = 100;
            // 
            // TenMH
            // 
            this.TenMH.Text = "Tên môn học";
            this.TenMH.Width = 150;
            // 
            // Diem
            // 
            this.Diem.Text = "Điểm";
            this.Diem.Width = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(411, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tổng điểm";
            // 
            // txtTongDiem
            // 
            this.txtTongDiem.Location = new System.Drawing.Point(500, 399);
            this.txtTongDiem.Name = "txtTongDiem";
            this.txtTongDiem.ReadOnly = true;
            this.txtTongDiem.Size = new System.Drawing.Size(150, 22);
            this.txtTongDiem.TabIndex = 6;
            // 
            // frmDanhSachDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTongDiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvDiem);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.cboMonHoc);
            this.Controls.Add(this.label1);
            this.Name = "frmDanhSachDiem";
            this.Text = "frmDanhSachDiem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboMonHoc;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.ListView lvDiem;
        private System.Windows.Forms.ColumnHeader STT;
        private System.Windows.Forms.ColumnHeader TenSV;
        private System.Windows.Forms.ColumnHeader NgaySinh;
        private System.Windows.Forms.ColumnHeader TenMH;
        private System.Windows.Forms.ColumnHeader Diem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTongDiem;
    }
}