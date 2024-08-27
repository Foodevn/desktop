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
    public partial class Cau1 : Form
    {
        public Cau1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            SanPham sp=new SanPham("1212","may","l",new DateTime(2004,08,25));
            label1.Text = sp.ToString();

           label3.Text=sp.NamHetHan().ToString();

        }
    }
}
