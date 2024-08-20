using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rb_Nam_CheckedChanged(object sender, EventArgs e)
        {
            if(rb_Nam.Checked)
            MessageBox.Show("bạn đã chọn giới tính nam","thông báo");

        }

        private void rb_Nu_CheckedChanged(object sender, EventArgs e)
        {
            if(rb_Nu.Checked)
            MessageBox.Show("bạn đã chọn giới tính nữ","thông báo");
        }

        private void btnToMAu_Click(object sender, EventArgs e)
        {
            if (rbDo.Checked)
                tbMau.BackColor = Color.Red;
            else tbMau.BackColor = Color.Green;
        }
    }
}
