using DAL.Thống_kê;
using System.Data;

namespace BLL.Thống_kê
{
    public class BLL_XuatHD
    {
        DAL_XuatHD dal = new DAL_XuatHD();

        public DataTable GetHoaDon(string maDatPhong)
        {
            return dal.GetHoaDon(maDatPhong);
        }
        public DataTable GetChiTietDichVu(string maDatPhong)
        {
            return dal.GetChiTietDichVu(maDatPhong);
        }
    }
}
