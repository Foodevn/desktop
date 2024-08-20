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
    public partial class FormChinh : Form
    {
        public FormChinh()
        {
            InitializeComponent();
        }

        private void bài1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormBai1();
            form.ShowDialog();  
        }

        private void bài2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormBai2();
            form.ShowDialog();
        }

        private void bài3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormBai3();
            form.ShowDialog();
        }

        private void bài4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormBai4();
            form.ShowDialog();
        }

        private void tênCủaBạnLàGìToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
