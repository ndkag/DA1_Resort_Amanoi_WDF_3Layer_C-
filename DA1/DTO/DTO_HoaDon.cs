using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HoaDon
    {
        public string MaHD { get; set; }
        public string MaKH { get; set; }
        public string MaNV { get; set; }
        public string MaDatPhong { get; set; }
        public decimal TongTien { get; set; }
        public DateTime NgayThanhToan { get; set; }
        public string GhiChu { get; set; }

        public DTO_HoaDon() { }
        public DTO_HoaDon(string maHD, string maKH, string maNV, string maDatPhong, decimal tongTien, DateTime ngayThanhToan, string ghiChu)
        {
            MaHD = maHD;
            MaKH = maKH;
            MaNV = maNV;
            MaDatPhong = maDatPhong;
            TongTien = tongTien;
            NgayThanhToan = ngayThanhToan;
            GhiChu = ghiChu;
        }
    }
}
