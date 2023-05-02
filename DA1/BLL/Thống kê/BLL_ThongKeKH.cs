using DAL.Thống_kê;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Thống_kê
{
    public class BLL_ThongKeKH
    {
        DAL_ThongKeKH dalKhachHang = new DAL_ThongKeKH();
        public DataTable ThongKeSoKhachHangTheoNam(int nam)
        {
            return dalKhachHang.ThongKeSoKhachHangTheoNam(nam);
        }
        public DataTable ThongKeSoKhachHangTheoThang(int thang,int nam)
        {
            return dalKhachHang.ThongKeSoKhachHangTheoThang(thang,nam);
        }
        public DataTable BaoCaoKhachHang(int thang, int nam)
        {
            return dalKhachHang.BaoCaoKhachHang(thang, nam);
        }
    }
}
