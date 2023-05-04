using System.Data;
using System.Data.SqlClient;

namespace DAL.Thống_kê
{
    public class DAL_Thống_kê : DBConnect
    {
        public DataTable ThongKeDoanhThuTheoNam(int nam)
        {
            try
            {
                chuoikn.Open();
                string query = "SELECT MONTH(NgayThanhToan) AS Thang, SUM(TongTien) AS DoanhThu FROM HoaDon WHERE YEAR(NgayThanhToan) = '" + nam + "' GROUP BY MONTH(NgayThanhToan)";
                SqlCommand cmd = new SqlCommand(query, chuoikn);
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                return dt;
            }
            finally
            {
                chuoikn.Close();
            }
        }

        public DataTable ThongKeDoanhThuTheoThang(int thang, int nam)
        {


            // Bắt đầu try-catch để xử lý lỗi
            try
            {
                // Mở kết nối tới database
                chuoikn.Open();
                // Câu truy vấn SQL để lấy dữ liệu
                string query = "SELECT DAY(NgayThanhToan) AS Ngày, SUM(TongTien) AS DoanhThu FROM HoaDon WHERE MONTH(NgayThanhToan) = '" + thang + "' and YEAR(NgayThanhToan) = '" + nam + "' GROUP BY DAY(NgayThanhToan)";

                SqlCommand cmd = new SqlCommand(query, chuoikn);
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                return dt;
            }
            finally
            {
                chuoikn.Close();
            }

        }

        public DataTable BaoCaoHoaDonThang(int thang, int nam)
        {
            //Bắt đầu try-catch để xử lý lỗi 
            try
            {
                //kết nối đến sql
                chuoikn.Open();
                //Câu lệnh truy vấn sql để lấy dữ liệu
                string query = "select*from HoaDon where MONTH(NgayThanhToan) = '" + thang + "' AND YEAR(NgayThanhToan) = '" + nam + "' ";
                //tạo đối tượng sqlcommanđ để lưu dữ liệu trả về từ câu truy vấn
                SqlCommand cmd = new SqlCommand(query, chuoikn);

                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);

                return dt;


            }
            finally
            {
                chuoikn.Close();
            }
        }


    }
}
