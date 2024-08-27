using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    internal class SanPham
    {
        public string MaSP {  get; set; }
        public string TenSP {  get; set; }
        public string LoaiSP {  get; set; }
        public DateTime NgaySX { get; set; }
        public SanPham() { }    
        public SanPham(string maSP, string tenSP, string loaiSP, DateTime ngaySX)
        {
            MaSP = maSP;
            TenSP = tenSP;
            LoaiSP = loaiSP;
            NgaySX = ngaySX;
        }
        public int NamHetHan ()
        {
            return NgaySX.Year+3;
        }
        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}, {3}",
                MaSP,TenSP,LoaiSP,NgaySX.Date.ToString("dd/MM/yyyy"));

        }
    }
}
