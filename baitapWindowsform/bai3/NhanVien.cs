using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3
{
	internal class NhanVien
	{
		public string MaNV {  get; set; }
		public string HoTen {  get; set; }
		public DateTime NgaySinh { get; set; }
		public int HeSoLuong {  get; set; }
		public int HeSoPhuCap {  get; set; }

        public NhanVien()
        {
            
        }
		public NhanVien(string manv, string hoTen,DateTime ngaysinh,
			int hesoluong,int hesophucap)
		{
			MaNV = manv;
			HoTen = hoTen;
			NgaySinh = ngaysinh;
			HeSoLuong = hesoluong;
			HeSoPhuCap = hesophucap;
		}
		public int TinhLuong()
		{
			
			return (HeSoLuong + HeSoPhuCap) * 1150000;

		}
		public override string ToString()
		{
			return string.Format("{0},{1},{2},{3},{4}"
				,MaNV,HoTen,NgaySinh.Date.ToString("dd/MM/yyyy"),HeSoLuong,HeSoPhuCap);

		}





	}
}
