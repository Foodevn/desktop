using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai3
{
	public partial class formMain : Form
	{
		public formMain()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
		Form form = new Cau1();
			form.ShowDialog();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Form form = new Cau2();
			form.ShowDialog();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Form form = new Cau3();
			form.ShowDialog();
		}
	}
}
