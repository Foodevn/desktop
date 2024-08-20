using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai1
{
    public partial class FormBai2 : Form
    {
        public FormBai2()
        {
            InitializeComponent();
          
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lbTinhTien_Click(object sender, EventArgs e)
        {

        }

        private void btn_ChonHang_Click(object sender, EventArgs e)
        {
           
            var item = listBox1.SelectedItem;
            listBox2.Items.Add(item);
        }
        private void enable()
        {
            btn_ChonHang.Enabled = true;

        }
        private void Disenable()
        {
            btn_ChonHang.Enabled = false;

        }

        private void btnBoHang_Click(object sender, EventArgs e)
        {
             
            listBox2.Items.Remove(listBox2.SelectedItem);
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int Tong = 0;
            foreach (string item in listBox2.Items)
            {
                switch(item)
                {
                    case "Chuột":
                        Tong += 100000;
                        break;
                    case "Bàn Phím":
                        Tong += 150000;
                        break;
                    case "Máy In":
                        Tong += 200000;
                        break;
                    case "USB Kingmax":
                        Tong += 200000;
                        break;
                    default:
                        break;

                }

            }
            lbTinhTien.Text=Tong.ToString();
        }
    }
}
