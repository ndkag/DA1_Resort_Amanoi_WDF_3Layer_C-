using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_DatPhong
    {
        DAL_DatPhong daldatPhong = new DAL_DatPhong();

        public int kiemtramatrung(string ma)
        {
            return daldatPhong.kiemtramatrung(ma);
        }
        public DataTable getDatPhong()
        {
            return daldatPhong.getDatPhong();
        }
        public List<QLPhongDTO> LayDanhSachPhongTrong()
        {
            return daldatPhong.LayDanhSachPhongTrong();
        }
    
        public bool SuaDP(DTO_DatPhong datPhong)
        {
            return daldatPhong.SuaDP(datPhong);
        }
        public bool ThemDP(DTO_DatPhong datPhong)
        {
            return daldatPhong.ThemDP(datPhong);

        }
        public decimal TinhTongDatPhong(DataTable dt)
        {
            decimal GiaTien = 0;
            foreach (DataRow row in dt.Rows)
            {
                GiaTien += Convert.ToDecimal(row["Giá"]);
            }
            return GiaTien;
        }
        public bool XoaDatPhong(string DV)
        {
            return daldatPhong.XoaDatPhong(DV);
        }
      


    }
}
