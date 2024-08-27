using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4
{
    public partial class Cau2 : Form
    {
        public Cau2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbThongbao.Text = XepLoai(double.Parse(textBox1.Text), double.Parse(textBox2.Text));


        }
        public string XepLoai(double DiemTH, double DiemLT)
        {
            double DiemTB =( DiemTH + DiemLT) / 2;
            string s = "false";
            if (DiemTH < 5 || DiemLT < 5)
                return s = "yếu";
            if (DiemTH < 7 || DiemLT < 7)
                return s = "trung Bình";
            if (DiemTB >= 7 && DiemTB < 8)
                return s = "Khá";
            if (DiemTB >= 8 && DiemTB < 9)
                return s = "Giỏi";
            if (DiemTB >= 9)
                s = "Xuất Sắc";
            return s;
        }




    }
}
