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
    public class QLPhongBLL
    {
        QLPhongDAL phongDAL = new QLPhongDAL();


        public DataTable getPhong()
        {
            return phongDAL.getPhong();
        }
        public List<QLPhongDTO> Search(string keyword)
        {
            return phongDAL.Search(keyword);
        }

        public bool ThemP(QLPhongDTO phong)
        {
            return phongDAL.ThemP(phong);
        }
        public bool SuaP(QLPhongDTO phong)
        {
            return phongDAL.SuaP(phong);
        }
        public bool XoaP(string phong)
        {
            return phongDAL.XoaP(phong);
        }
   
      


    }
}
