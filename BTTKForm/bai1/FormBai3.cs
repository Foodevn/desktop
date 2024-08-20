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
    public partial class FormBai3 : Form
    {
        List<string>list = new List<string>();

        public FormBai3()
        {
            InitializeComponent();
        }

        private void txtTuMoi_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void btnThemTu_Click(object sender, EventArgs e)
        {
            string tu=txtTuMoi.Text;
            string nghia=txtNghia.Text;
            listBox1.Items.Add(tu);
            list.Add(nghia);
            txtTuMoi.Clear();
            txtNghia.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int stt = listBox1.SelectedIndex;
            txtHienThiNghia.Text = list[stt];
        }
    }
}
