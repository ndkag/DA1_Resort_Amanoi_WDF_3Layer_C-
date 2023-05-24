using DAL;
using DTO;
using System.Collections.Generic;
using System.Data;

namespace BLL
{
    public class BLL_DichVu
    {
        DAL_DichVu dv = new DAL_DichVu();
        public List<DTO_DichVu> TimKiem(string keyword)

        {
            return dv.TimKiem(keyword);
        }
        public DataTable getDichVu()
        {
            return dv.getDichVu();
        }
        public bool ThemDV(DTO_DichVu NV)
        {
            return dv.ThemDV(NV);
        }
        public bool SuaDV(DTO_DichVu NV)
        {
            return dv.SuaDV(NV);
        }
        public bool XoaDV(string NV)
        {
            return dv.XoaDV(NV);
        }


        public decimal LayGiaTien(string maDV)
        {
            return dv.LayGiaTien(maDV);
        }




    }
}
