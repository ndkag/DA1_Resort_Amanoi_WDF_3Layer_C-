using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BLL
{
    public class BLL_ChiTietDV
    {
        DAL_ChiTietDV chiTietDichVuDAL = new DAL_ChiTietDV();
        DAL_DichVu daldv = new DAL_DichVu();
        public DataTable getChiTietDV()
        {
            return chiTietDichVuDAL.getChiTietDV();
        }

        public int kiemtramatrung(string ma, string madp)
        {
            return chiTietDichVuDAL.kiemtramatrung(ma, madp);
        }

        public void ThemChiTietDichVu(DTO_ChiTietDV ctdv)
        {
           

            chiTietDichVuDAL.ThemChiTietDichVu(ctdv);
        }
        public decimal TinhTongTien(string maDichVu, decimal soLuong)
        {
            decimal giaTien = daldv.LayGiaTien(maDichVu);
            decimal tongTien = giaTien * soLuong;
            return tongTien;
        }
     

        public bool SuaCTDV(DTO_ChiTietDV ctdv)
        {

            return chiTietDichVuDAL.SuaCTDV(ctdv);
        }

        public bool Xoa(string DV, string maDP)
        {
            return chiTietDichVuDAL.Xoa(DV, maDP);
        }

        public List<DTO_ChiTietDV> TimKiem(string keyword)
        {
            return chiTietDichVuDAL.TimKiem(keyword);
        }
        public DTO_DichVu LayMaTuMaDV(string maDV)
        {
            return chiTietDichVuDAL.LayMaTuMaDV(maDV);
        }
        }

}
