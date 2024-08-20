using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuongDan
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ten=txt_Ten.Text;

            MessageBox.Show($"Xin chào bạn: {ten}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtCopy.Text = txt_Ten.Text; 
        }

        private void txt_Ten_TextChanged(object sender, EventArgs e)
        {
            txtCopy.Text = txt_Ten.Text;
            txt_Ten.Focus();
        }
    }
}
