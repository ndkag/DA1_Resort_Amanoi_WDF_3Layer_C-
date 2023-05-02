using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DatPhong
    {
        public string MaDatPhong { get; set; }
        public string MaKH { get; set; }
        public string MaPhong { get; set; }
        public DateTime NgayDen { get; set; }
        public DateTime NgayDi { get; set; }
        public string GhiChu { get; set; }

        public DTO_DatPhong() { }
        public DTO_DatPhong(string maDatPhong, string maKH, string maPhong, DateTime ngayDen, DateTime ngayDi, string ghiChu)
        {
            MaDatPhong = maDatPhong;
            MaKH = maKH;
            MaPhong = maPhong;
            NgayDen = ngayDen;
            NgayDi = ngayDi;
            GhiChu = ghiChu;
        }

    }
}
