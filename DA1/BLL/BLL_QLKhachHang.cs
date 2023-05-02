using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BLL
{
    public class BLL_QLKhachHang
    {
        DAL_QLKhachHang QLKH = new DAL_QLKhachHang();
        public List<DTO_QLKhachHang> TimKiems(string keyword)

        {
            return QLKH.TimKiems(keyword);
        }
      
        public DataTable getQLKhachHang()
        {
            return QLKH.getQLKhachHang();
        }
        public bool ThemKH(DTO_QLKhachHang KH)
        {
            
            return QLKH.ThemKH(KH);
        }
        public bool SuaKH(DTO_QLKhachHang KH)
        {
            return QLKH.SuaKH(KH);
        }
        public bool XoaKH(string KH)
        {
            return QLKH.XoaKH(KH);
        }
        public int kiemtramatrung(string ma)
        {
            return QLKH.kiemtramatrung(ma);
        }
    }
}
