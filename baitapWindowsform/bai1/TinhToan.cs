using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
	internal class TinhToan
	{
		public void CongHaiSo(int a,int b,int s)
		{
			s = a + b;
		}
		public int TongDaySo(int n)
		{
			int s=0;
			for (int i = 0; i <= n; i++)
			{
				s+= i;
			}return s;
		}
	}
}
