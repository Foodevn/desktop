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
	public partial class Cau3 : Form
	{
		public Cau3()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			New moi = new New();

			string s1="",s2="";
			moi.TachChuoi(textBox1.Text,ref s1,ref s2);
			label1.Text= s1;
			label2.Text= s2;

		}
	}
}
