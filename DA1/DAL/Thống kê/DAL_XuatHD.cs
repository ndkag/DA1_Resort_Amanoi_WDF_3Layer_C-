using System.Data;
using System.Data.SqlClient;

namespace DAL.Thống_kê
{
    public class DAL_XuatHD : DBConnect
    {
        public DataTable GetHoaDon(string maDatPhong)
        {
            string query = "SELECT hd.MaHD, hd.MaNV, nv.TenNV, dp.MaKH, kh.TenKH, dp.MaDatPhong, dp.MaPhong, p.TenPhong, p.GiaTien, dp.NgayDen, dp.NgayDi, hd.NgayThanhToan, hd.TongTien " +
                           "FROM DatPhong dp " +
                           "INNER JOIN HoaDon hd ON dp.MaDatPhong=hd.MaDatPhong " +
                           "INNER JOIN Phong p ON dp.MaPhong=p.MaPhong " +
                           "INNER JOIN KhachHang kh ON dp.MaKH=kh.MaKH " +
                           "INNER JOIN NhanVien nv ON hd.MaNV = nv.MaNV " +
                           "WHERE dp.MaDatPhong = @maDatPhong";

            using (SqlCommand command = new SqlCommand(query, chuoikn))
            {
                command.Parameters.AddWithValue("@maDatPhong", maDatPhong);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable;
            }
        }

        public DataTable GetChiTietDichVu(string maDatPhong)
        {
            string query = "SELECT ctdv.MaDV, ctdv.TenDV, dv.GiaTien, ctdv.SoLuong, ctdv.TongTien " +
                           "FROM ChiTietDatPhong ctdv " +
                           "INNER JOIN DatPhong dp ON ctdv.MaDatPhong=dp.MaDatPhong " +
                           "INNER JOIN DichVu dv ON ctdv.MaDV= dv.MaDV " +
                           "WHERE dp.MaDatPhong = @maDatPhong";

            using (SqlCommand command = new SqlCommand(query, chuoikn))
            {
                command.Parameters.AddWithValue("@maDatPhong", maDatPhong);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable;
            }
        }
    }
}
