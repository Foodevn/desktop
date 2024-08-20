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
    public partial class FormBai1 : Form
    {
        public FormBai1()
        {
            InitializeComponent();
        }
        private void rbXanh_CheckedChanged(object sender, EventArgs e)
        {
            txtDonGia.Text = "22000";
        }

        private void rbDo_CheckedChanged(object sender, EventArgs e)
        {
            txtDonGia.Text = "21000";
        }


        private void rbTrang_CheckedChanged(object sender, EventArgs e)
        {
            txtDonGia.Text = "20000";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSoLuong_Click(object sender, EventArgs e)
        {
            int TinhTien= int.Parse(txtDonGia.Text) *int.Parse(txtSOLuong.Text);
            lbTien.Text=TinhTien.ToString();
        }
    }
}
