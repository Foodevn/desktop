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
	public partial class Cau1 : Form
	{
		public Cau1()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{
		
			NhanVien nv = new NhanVien("12", "hoang phuc", new DateTime(2024, 08, 25), 4, 4);
			label1.Text = nv.ToString();
		}
	}
}
