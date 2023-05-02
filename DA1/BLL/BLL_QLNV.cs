using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_QLNV
    {
        DAL_QLNV qlnv = new DAL_QLNV();
        public List<DTO_QLNV> TimKiem(string keyword)

        {
            return qlnv.TimKiem(keyword);
        }
        public DataTable getQLNV()
        {
            return qlnv.getQLNV();
        }
        public bool ThemNV(DTO_QLNV NV)
        {
            return qlnv.ThemNV(NV);
        }
        public bool SuaNV(DTO_QLNV NV)
        {
            return qlnv.SuaNV(NV);
        }
        public bool XoaNV(string NV)
        {
            return qlnv.XoaNV(NV);
        }

       
    }
}
