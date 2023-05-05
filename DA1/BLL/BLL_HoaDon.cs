using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace BLL
{
    public class BLL_HoaDon
    {
        DAL_HoaDon dalhd = new DAL_HoaDon();
        public DataTable getDatPhongByMaPhong(string maPhong)
        {
            return dalhd.getDatPhongByMaPhong(maPhong);
        }

        public DTO_DatPhong LayMaKHTuMaDP(string maDP)
        {
            return dalhd.LayMaKHTuMaDP(maDP);
        }
        public string getMaDatPhongByMaPhong(string maPhong)
        {
            return dalhd.getMaDatPhongByMaPhong(maPhong);
        }

        public DataTable getChiTietDV(string maDatPhong)
        {
            return dalhd.getChiTietDV(maDatPhong);
        }
        public DataTable getKHHD(string maDatPhong)
        {
            return dalhd.getKHHD(maDatPhong);

        }
        public DataTable getHoaDon(string maDatPhong)
        {
            return dalhd.getHoaDon(maDatPhong);

        }
        public DataTable getDPHD(string maDatPhong)
        {
            return dalhd.getDPHD(maDatPhong);
        }
        public decimal TinhTongTienChiTietDichVu(DataTable dt)
        {
            decimal tongTien = 0;
            foreach (DataRow row in dt.Rows)
            {
                tongTien += Convert.ToDecimal(row["Tổng tiền"]);
            }
            return tongTien;
        }


        public bool ThemHoaDon(DTO_HoaDon hd)
        {
            return dalhd.ThemHoaDon(hd);
        }

        public bool CapNhatTrangThaiPhong(string maPhong, string trangThai)
        {
            return dalhd.CapNhatTrangThaiPhong(maPhong, trangThai);
        }

        public bool XoaDatPhong(string DP)
        {
            return dalhd.XoaDatPhong(DP);
        }
        public bool XoaChiTietDV(string DP)
        {
            return dalhd.XoaChiTietDV(DP);

        }
        //public bool ChuyendulieuDP(string maDP)
        //{
        //    return dalhd.ChuyendulieuDP(maDP);

        //}
        //public bool ChuyendulieuCTDV(string maDP)
        //{
        //    return dalhd.ChuyendulieuCTDV(maDP);

        //}

        #region from quản lý hoá đơn
        public DataTable getQLHoaDon()
        {
            return dalhd.getQLHoaDon();
        }
        public bool XoaHoaDon(string HD)
        {
            return dalhd.XoaHoaDon(HD);
        }
        public bool SuaDH(DTO_HoaDon HD)
        {
            return dalhd.SuaDH(HD);
        }
        public List<DTO_HoaDon> TimKiem(string keyword)
        {
            return dalhd.TimKiem(keyword);
        }
        #endregion

        // Hàm thống kê doanh thu theo tháng
        public List<Tuple<string, decimal>> ThongKeTheoThang(int nam)
        {
            List<Tuple<string, decimal>> data = new List<Tuple<string, decimal>>();

            for (int i = 1; i <= 12; i++)
            {
                // Lấy doanh thu của tháng i
                decimal doanhThuThang = dalhd.TinhTongDoanhThuTheoThang(nam, i);

                // Thêm vào danh sách data
                data.Add(new Tuple<string, decimal>(i.ToString(), doanhThuThang));
            }

            return data;
        }
        public int kiemtramatrung(string ma)
        {
            return dalhd.kiemtramatrung(ma);
        }

    }
}
