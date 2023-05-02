using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_QLKhachHang
    {
        public string MaKH { get; set; }
        public string TenKH { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public DateTime NgayTao { get; set; }

        public DTO_QLKhachHang() { }

        public DTO_QLKhachHang(string maKH, string tenKH, string diachi, string sdt, DateTime ngayTao)
        {
            MaKH = maKH;
            TenKH = tenKH;
            DiaChi = diachi;
            SoDienThoai = sdt;
            NgayTao = ngayTao;
        }
    }
}
