using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class QLPhongDTO
    {
        
        
        public string MaPhong { get; set; }
        public string TenPhong { get; set; }
        public string TrangThaiPhong { get; set; }
        public decimal GiaTien { get; set; }
        public int SoLuongNguoi { get; set; }
        public int KhaNangDatPhong { get; set; }

        public QLPhongDTO() { }
        public QLPhongDTO(string maPhong, string tenPhong, string trangThaiPhong, decimal giaTien, int soLuongNguoi, int khaNangDatPhong)
        {
            MaPhong = maPhong;
            TenPhong = tenPhong;
            TrangThaiPhong = trangThaiPhong;
            GiaTien = giaTien;
            SoLuongNguoi = soLuongNguoi;
            KhaNangDatPhong = khaNangDatPhong;
        }

    }
}
