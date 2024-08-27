using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
	internal class HangHoa
	{
		public string Mahang {  get; set; }
		public string TenHang { get; set; }
		public string DVT {  get; set; }
		public int SoLuong {  get; set; }
		public float DonGia {  get; set; }
        public HangHoa()
        {
            
        }
		public HangHoa(string mahang, string tenHang, string dVT, int soLuong, float donGia)
		{
			Mahang = mahang;
			TenHang = tenHang;
			DVT = dVT;
			SoLuong = soLuong;
			DonGia = donGia;
		}

		public string HienThi()
		{
			return string.Format("{0},{1},{2},{3},{4}",
				Mahang,TenHang,DVT,SoLuong,DonGia);
		}








    }
}
