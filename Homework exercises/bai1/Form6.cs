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
	public partial class Form6 : Form
	{
		public Form6()
		{
			InitializeComponent();
		}

		private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			CheckedListBox.CheckedItemCollection item;
			item =checkedListBox1.CheckedItems;
			string s = " ";
			foreach (string item2 in item)
			{
				s += item2.ToString()+",";
			}
			MessageBox.Show(s);
		}
	}
}
