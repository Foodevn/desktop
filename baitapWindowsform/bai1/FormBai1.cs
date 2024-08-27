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
	public partial class FormBai1 : Form
	{
		public FormBai1()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{
			HangHoa hh = new HangHoa("111", "Cái Bàn", "Cái", 1000, 11000);
			
			label1.Text= hh.HienThi();
		}
	}
}
