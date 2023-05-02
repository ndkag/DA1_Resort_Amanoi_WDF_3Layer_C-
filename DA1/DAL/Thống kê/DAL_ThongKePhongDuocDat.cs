using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Thống_kê
{
    public class DAL_ThongKePhongDuocDat:DBConnect
    {

   
        public DataTable ThongKePhongDatTheoNamnhat(int nam)
        {
            try 
            {
                chuoikn.Open();
                string sql = "SELECT TOP 5 p.MaPhong as Phong, p.TenPhong, COUNT(dp.MaPhong) AS SoLanDat FROM Phong p LEFT JOIN DatPhong dp ON p.MaPhong = dp.MaPhong AND YEAR(dp.NgayDen) = '" + nam + "' GROUP BY p.MaPhong, p.TenPhong ORDER BY SoLanDat desc";
                SqlCommand cmd = new SqlCommand(sql, chuoikn);
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

        public DataTable ThongKePhongDatTheoNamit(int nam)
        {
            try
            {
                chuoikn.Open();
                string sql = "SELECT TOP 5 p.MaPhong as Phong, p.TenPhong, COUNT(dp.MaPhong) AS SoLanDat FROM Phong p LEFT JOIN DatPhong dp ON p.MaPhong = dp.MaPhong AND YEAR(dp.NgayDen) = '" + nam + "' GROUP BY p.MaPhong, p.TenPhong ORDER BY SoLanDat ASC";
                SqlCommand cmd = new SqlCommand(sql, chuoikn);
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

        public DataTable ThongKePhongDatTheoThangnhat(int thang, int nam)
        {
            try
            {
                chuoikn.Open();
                string sql = "SELECT TOP 5 p.MaPhong as Phong, p.TenPhong, COUNT(dp.MaPhong) AS SoLanDat FROM Phong p Left JOIN DatPhong dp ON p.MaPhong = dp.MaPhong AND MONTH(dp.NgayDen) = '" + thang + "' AND YEAR(dp.NgayDen) = '" + nam + "' GROUP BY p.MaPhong, p.TenPhong  ORDER BY SoLanDat desc";
                SqlCommand cmd = new SqlCommand(sql, chuoikn);
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
        public DataTable ThongKePhongDatTheoThangit(int thang, int nam)
        {
            try
            {
                chuoikn.Open();
                string sql = "SELECT TOP 5 p.MaPhong as Phong, p.TenPhong, COUNT(dp.MaPhong) AS SoLanDat FROM Phong p Left JOIN DatPhong dp ON p.MaPhong = dp.MaPhong AND MONTH(dp.NgayDen) = '" + thang + "' AND YEAR(dp.NgayDen) = '" + nam + "' GROUP BY p.MaPhong, p.TenPhong  ORDER BY SoLanDat ASC";
                SqlCommand cmd = new SqlCommand(sql, chuoikn);
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
        public DataTable ThongKePhongDatTheoThang(int thang, int nam)
        {
            try
            {
                chuoikn.Open();
                string sql = "select dp.MaDatPhong,dp.MaPhong,p.TenPhong,dp.NgayDen,dp.NgayDi from DatPhong dp inner join Phong p on dp.MaPhong = p.MaPhong where month(dp.NgayDen)='" + thang+ "' and YEAR(dp.NgayDen)='"+nam+"' ";
                SqlCommand cmd = new SqlCommand(sql, chuoikn);
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
