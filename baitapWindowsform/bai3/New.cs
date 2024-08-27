using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3
{
	internal class New
	{
		public void TachChuoi(string hoten,ref string s1,ref string s2)
		{
			string[] ketqua = hoten.Split(' ');
			s1=ketqua[0] ;
			s2=ketqua[ketqua.Length-1] ;
		}
		public bool ThuTu(int s1,int s2)
		{
			return s2==s1+1?true : false;
		}
	}
}
