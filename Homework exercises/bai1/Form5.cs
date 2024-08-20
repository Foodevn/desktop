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
	public partial class Form5 : Form
	{
		public Form5()
		{
			InitializeComponent();
		}

		private void cbDoiMau_CheckedChanged(object sender, EventArgs e)
		{
			if (this.cbDoiMau.Checked)
			{
				this.button1.ForeColor = Color.Red;
			}else this.button1.ForeColor = Color.Black;
		}

		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
			if (this.cbDoiNen.Checked)
			{
				this.button1.BackColor = Color.LightCyan;
			}
			else this.button1.BackColor = this.btnFlat.BackColor;

		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{

			if (this.radioButton1.Checked)
			{
				this.btnFlat.FlatStyle = FlatStyle.Flat;
			}
			else this.btnFlat.FlatStyle = FlatStyle.Popup;
		}
	}
}
