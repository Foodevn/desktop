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
	public partial class Form4 : Form
	{
		public Form4()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
				
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var item = listBox1.SelectedItem;
			listBox2.Items.Add(item);
			listBox1.Items.Remove(item);
		}
	}
}
