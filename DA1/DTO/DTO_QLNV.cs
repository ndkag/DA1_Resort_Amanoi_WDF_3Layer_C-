using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class DTO_QLNV
    {
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public string ViTri { get; set; }
        public decimal Luong { get; set; }
        public DTO_QLNV() { }

        public DTO_QLNV(string maNV, string tenNV, string diaChi, string sdt, string viTri, decimal luong) 
        {
            MaNV = maNV;
            TenNV = tenNV;
            DiaChi = diaChi;
            SoDienThoai = sdt;
            ViTri = viTri;
            Luong = luong;
                
        }

    }
}
