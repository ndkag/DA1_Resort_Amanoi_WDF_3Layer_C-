using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Collections;
using Microsoft.SqlServer.Management.Sdk.Sfc;
using System.Net.NetworkInformation;
using Microsoft.SqlServer.Management.Smo;

namespace DAL
{
    public class QLPhongDAL : DBConnect
    {

        public DataTable getPhong()
        {
            chuoikn.Open();
            da = new SqlDataAdapter("Select * from Phong", chuoikn);
            dt = new DataTable();
            da.Fill(dt);
            chuoikn.Close();
            return dt;
        }

        #region Tìm Kiếm
        public List<QLPhongDTO> Search(string keyword)
        {
            List<QLPhongDTO> results = new List<QLPhongDTO>();


            chuoikn.Open();

            string sql = "SELECT * FROM Phong WHERE MaPhong LIKE @Keyword OR TenPhong LIKE @Keyword OR TrangThaiPhong LIKE @Keyword OR GiaTien LIKE @Keyword OR SoLuongNguoi LIKE @Keyword OR KhaNangDatPhong LIKE @Keyword";
            using (SqlCommand command = new SqlCommand(sql, chuoikn))
            {
                command.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        QLPhongDTO dto = new QLPhongDTO();
                        dto.MaPhong = reader.GetString(reader.GetOrdinal("MaPhong"));
                        dto.TenPhong = reader.GetString(reader.GetOrdinal("TenPhong"));
                        dto.TrangThaiPhong = reader.GetString(reader.GetOrdinal("TrangThaiPhong"));
                        dto.GiaTien = reader.GetDecimal(reader.GetOrdinal("GiaTien"));
                        dto.SoLuongNguoi = reader.GetInt32(reader.GetOrdinal("SoLuongNguoi"));
                        dto.KhaNangDatPhong = reader.GetInt32(reader.GetOrdinal("KhaNangDatPhong"));

                        results.Add(dto);
                    }
                }
            }
            chuoikn.Close();


            return results;
        }
        #endregion
     
        //Thêm phòng
        public bool ThemP(QLPhongDTO phong)
        {
            string sql = "Insert into Phong(TenPhong,TrangThaiPhong,GiaTien,SoLuongNguoi,KhaNangDatPhong) values(N'" + phong.TenPhong + "',N'" + phong.TrangThaiPhong + "','" + phong.GiaTien + "','" + phong.SoLuongNguoi + "','" + phong.KhaNangDatPhong + "')";
            thucthisql(sql);
            return true;
        }


        public bool SuaP(QLPhongDTO phong)
        {

            string sql = "UPDATE Phong SET MaPhong = '" + phong.MaPhong + "', TenPhong = N'" + phong.TenPhong + "', TrangThaiPhong = N'" + phong.TrangThaiPhong + "', GiaTien = '" + phong.GiaTien + "', SoLuongNguoi ='" + phong.SoLuongNguoi + "', KhaNangDatPhong ='" + phong.KhaNangDatPhong + "' WHERE MaPhong = '" + phong.MaPhong + "' ";
            thucthisql(sql);
            return true;
        }
        public bool XoaP(string phong)
        {
            string sql = "Delete from Phong where MaPhong='" + phong + "'";
            thucthisql(sql);
            return true;
        }

        public QLPhongDTO TimPhong(string maPhong)
        {
            chuoikn.Open();

            string sql = "SELECT * FROM Phong WHERE MaPhong=@maPhong";
            SqlCommand cmd = new SqlCommand(sql, chuoikn);
            cmd.Parameters.AddWithValue("@maPhong", maPhong);
            SqlDataReader reader = cmd.ExecuteReader();

            QLPhongDTO phong = null;
            if (reader.Read())
            {
                phong = new QLPhongDTO();
                phong.MaPhong = reader.GetString(reader.GetOrdinal("MaPhong"));
                phong.TenPhong = reader.GetString(reader.GetOrdinal("TenPhong"));
                phong.TrangThaiPhong = reader.GetString(reader.GetOrdinal("TrangThaiPhong"));
                phong.GiaTien = reader.GetDecimal(reader.GetOrdinal("GiaTien"));
                phong.SoLuongNguoi = reader.GetInt32(reader.GetOrdinal("SoLuongNguoi"));
                phong.KhaNangDatPhong = reader.GetInt32(reader.GetOrdinal("KhaNangDatPhong"));
            }

            chuoikn.Close();
            return phong;
        }





    }
}
