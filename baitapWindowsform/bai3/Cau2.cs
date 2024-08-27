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
	public partial class Cau2 : Form
	{
		public Cau2()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int ketqua=0;
			if(radioButton1.Checked==true)
			{ ketqua= TinhTong1_N(int.Parse(textBox1.Text)); }
			if (radioButton2.Checked == true)
			{ ketqua = TinhN(int.Parse(textBox1.Text)); }

			label3.Text= ketqua.ToString();

		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{

		}
		int TinhTong1_N(int n)	
		{
			if (n == 0) {return 0;}	
			return n + TinhTong1_N(n - 1);
		}
		int TinhN(int n)
		{
			if (n == 1) { return 1; }
			return n * TinhN(n - 1);
		}
	}
}
