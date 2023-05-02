using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Thống_kê
{
    public class DAL_ThongKeKH : DBConnect
    {

        public DataTable ThongKeSoKhachHangTheoNam(int nam)
        {
            try
            {
                chuoikn.Open();
                string query = "SELECT MONTH(NgayTao) AS Tháng, COUNT(*) AS SoLuong FROM KhachHang WHERE YEAR(NgayTao) = '" + nam + "' GROUP BY MONTH(NgayTao)";
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
        public DataTable ThongKeSoKhachHangTheoThang(int thang, int nam)
        {
            try
            {
                chuoikn.Open();
                string query = "SELECT Day(NgayTao) AS Ngày, COUNT(*) AS SoLuong FROM KhachHang WHERE MONTH(NgayTao)= '" + thang + "' and YEAR(NgayTao) = '" + nam + "' GROUP BY Day(NgayTao)";
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
        public DataTable BaoCaoKhachHang(int thang, int nam)
        {
            try
            {
                chuoikn.Open();
                string query = "SELECT * FROM KhachHang WHERE MONTH(NgayTao) = @month AND YEAR(NgayTao) = @year";
                SqlCommand command = new SqlCommand(query, chuoikn);
                command.Parameters.AddWithValue("@month", thang);
                command.Parameters.AddWithValue("@year", nam);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
            finally
            {
                chuoikn.Close();
            }

        }
    }
}
