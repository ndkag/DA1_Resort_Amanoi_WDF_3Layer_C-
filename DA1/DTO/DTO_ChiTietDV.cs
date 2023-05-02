using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ChiTietDV
    {
        public string MaDatPhong { get; set; }
        public string MaDV { get; set; }
        public string TenDV { get; set; }

        public decimal SoLuong { get; set; }
        public decimal TongTien { get; set; }

        public DTO_ChiTietDV() { }

        public DTO_ChiTietDV( string maDatPhong, string maDV,string tendv, decimal soLuong, decimal tongTien)
        {
            MaDatPhong = maDatPhong;
            MaDV = maDV;
            TenDV = tendv;

            SoLuong = soLuong;
            TongTien = tongTien;
        }
    }
}
