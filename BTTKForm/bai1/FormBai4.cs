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
    public partial class FormBai4 : Form
    {
        public FormBai4()
        {
            InitializeComponent();
            Form4_launch();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }
        private void Form4_launch()
        {
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                int so = random.Next(0, 100);
                listBox1.Items.Add(so);
            }
        }

        private void btnTimSo_Click(object sender, EventArgs e)
        {
            int SoCanTim = int.Parse(textSoCanTim.Text);
            string s;
            foreach (int i in listBox1.Items)
            {

                if (i == SoCanTim)
                {
                    label3.Text = "Tìm Thấy";
                    break;
                }
                else
                {
                    label3.Text = "Không tìm thấy";
                }
            }

        }
    }
}
