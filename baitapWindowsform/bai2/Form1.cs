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

		private void btnResult_Click(object sender, EventArgs e)
		{
			int results = 0;
			if (rbCong.Checked == true)
			{
				results=int.Parse(tbSOThuHai.Text)+int.Parse(tbSoThuNhat.Text);

			}
			if (rbTru.Checked == true)
			{
				results = int.Parse(tbSOThuHai.Text) - int.Parse(tbSoThuNhat.Text);
			}
			if (rbNhan.Checked == true)
			{
				results = int.Parse(tbSOThuHai.Text) * int.Parse(tbSoThuNhat.Text);
			}
			if (rbChia.Checked == true)
			{
				results = int.Parse(tbSOThuHai.Text) / int.Parse(tbSoThuNhat.Text);
			}
			lbKetQua.Text = results.ToString();
		}
	}
}
