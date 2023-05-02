using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Thống_kê;

namespace BLL.Thống_kê
{
    public class BLL_Thống_kê
    {
        DAL_Thống_kê daltk = new DAL_Thống_kê();
        public DataTable ThongKeDoanhThuTheoNam(int nam)
        {
            return daltk.ThongKeDoanhThuTheoNam(nam);

        }
        public DataTable ThongKeDoanhThuTheoThang(int thang, int nam)
        {
            return daltk.ThongKeDoanhThuTheoThang( thang,nam);
        }
        public DataTable BaoCaoHoaDonThang(int thang, int nam)
        {
            return daltk.BaoCaoHoaDonThang(thang, nam);
        }
   


        DAL_ThongKePhongDuocDat daldd = new DAL_ThongKePhongDuocDat();
        public DataTable ThongKePhongDatTheoThangnhat(int thang, int nam)
        {
            return daldd.ThongKePhongDatTheoThangnhat(thang,nam);
        }
        public DataTable ThongKePhongDatTheoThangit(int thang, int nam)
        {
            return daldd.ThongKePhongDatTheoThangit(thang, nam);
        }
        public DataTable ThongKePhongDatTheoNamnhat(int nam)
        {
            return daldd.ThongKePhongDatTheoNamnhat(nam);
        }
        public DataTable ThongKePhongDatTheoNamit(int nam)
        {
            return daldd.ThongKePhongDatTheoNamit(nam);
        }
        public DataTable ThongKePhongDatTheoThang(int thang, int nam)
        {
            return daldd.ThongKePhongDatTheoThang(thang, nam);
        }
    }
}
