using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double so = 0;
        string pheptinh = "";
        bool somoi = true;
        public Form1()
        {
            InitializeComponent();
        }
        void nhapso(string chuso)
        {
            if (somoi)
            {
                textBox1.Text = chuso;
                somoi = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + chuso;
            }
        }
        private void button1_Click(object sender, EventArgs e) { nhapso("1"); }
        private void button2_Click(object sender, EventArgs e) { nhapso("2"); }
        private void button3_Click(object sender, EventArgs e) { nhapso("3"); }
        private void button4_Click(object sender, EventArgs e) { nhapso("4"); }
        private void button5_Click(object sender, EventArgs e) { nhapso("5"); }
        private void button6_Click(object sender, EventArgs e) { nhapso("6"); }
        private void button7_Click(object sender, EventArgs e) { nhapso("7"); }
        private void button8_Click(object sender, EventArgs e) { nhapso("8"); }
        private void button9_Click(object sender, EventArgs e) { nhapso("9"); }
        private void button10_Click(object sender, EventArgs e) { nhapso("0"); }
        private void NutSo_Click(object sender, EventArgs e)
        {
            Button nut = (Button)sender;   // nút vừa được bấm
            nhapso(nut.Text);              // lấy chữ trên nút: "1", "2", ... "0"
        }
        private void chonpheptinh(string pt)
        {
            pheptinh = pt;
            so = double.Parse(textBox1.Text);
            somoi = true;
        }
        private void button13_Click(object sender, EventArgs e) { chonpheptinh("+"); }
        private void button14_Click(object sender, EventArgs e) { chonpheptinh("-"); }
        private void button15_Click(object sender, EventArgs e) { chonpheptinh("*"); }
        private void button16_Click(object sender, EventArgs e) { chonpheptinh("/"); }
        private void button11_Click(object sender, EventArgs e)
        {
            double soThuHai = double.Parse(textBox1.Text);
            double ketQua = 0;
            if (pheptinh == "+")
            {
                ketQua = so + soThuHai;
            }
            else if (pheptinh == "-")
            {
                ketQua = so - soThuHai;
            }
            else if (pheptinh == "*")
            {
                ketQua = so * soThuHai;
            }
            else if (pheptinh == "/")
            {   
                if (soThuHai == 0)
                {
                    MessageBox.Show("Không thể chia cho 0");
                    return;
                }
                ketQua = so / soThuHai;
            }
            textBox1.Text = ketQua.ToString();
            somoi = true;
        }
        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            so = 0;
            pheptinh = "";
            somoi = true;
        }


    }
}
