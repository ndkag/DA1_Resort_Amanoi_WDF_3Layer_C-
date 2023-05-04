using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace DAL
{
    public class DAL_DatPhong : DBConnect
    {

        public DataTable getDatPhong()
        {
            chuoikn.Open();
            da = new SqlDataAdapter("select MaDatPhong as [Mã ĐP], MaKH as [Mã KH], MaPhong as [Mã Phòng], NgayDen as [Ngày đến], NgayDi as [Ngày đi], GhiChu as [Ghi chú] from DatPhong", chuoikn);
            dt = new DataTable();
            da.Fill(dt);
            chuoikn.Close();
            return dt;
        }

        public int kiemtramatrung(string ma)
        {
            chuoikn.Open();
            int i;
            string sql = "Select count(*) from DatPhong where MaDatPhong='" + ma.Trim() + "'";
            cmd = new SqlCommand(sql, chuoikn);
            i = (int)cmd.ExecuteScalar();
            chuoikn.Close();
            return i;
        }

        public List<QLPhongDTO> LayDanhSachPhongTrong()
        {
            List<QLPhongDTO> listPhongTrong = new List<QLPhongDTO>();
            string query = "SELECT * FROM Phong WHERE TrangThaiPhong = N'Trống'";
            SqlCommand command = new SqlCommand(query, chuoikn);
            chuoikn.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                QLPhongDTO phong = new QLPhongDTO();
                phong.MaPhong = reader.GetString(0);
                phong.TenPhong = reader.GetString(1);
                phong.TrangThaiPhong = reader.GetString(2);
                phong.GiaTien = reader.GetDecimal(3);
                phong.SoLuongNguoi = reader.GetInt32(4);
                phong.KhaNangDatPhong = reader.GetInt32(5);
                listPhongTrong.Add(phong);
            }
            reader.Close();
            chuoikn.Close();
            return listPhongTrong;
        }


        public bool ThemDP(DTO_DatPhong datPhong)
        {
            try
            {
                string ngayden = string.Format("{0}/{1}/{2}", datPhong.NgayDen.Year, datPhong.NgayDen.Month, datPhong.NgayDen.Day);
                string ngaydi = string.Format("{0}/{1}/{2}", datPhong.NgayDi.Year, datPhong.NgayDi.Month, datPhong.NgayDi.Day);
                string sql = "Insert into DatPhong(MaKH,MaPhong,NgayDen,NgayDi,GhiChu) values('" + datPhong.MaKH + "','" + datPhong.MaPhong + "','" + ngayden + "','" + ngaydi + "',N'" + datPhong.GhiChu + "')";
                thucthisql(sql);
                string tt = string.Format("UPDATE Phong SET TrangThaiPhong = N'Đã có khách' WHERE MaPhong = '" + datPhong.MaPhong + "' ", chuoikn);
                thucthisql(tt);
            }

            catch (Exception ex)
            {
                throw ex;
            }
            return true;
        }

        public bool SuaDP(DTO_DatPhong datPhong)
        {
            try
            {
                string ngayden = string.Format("{0}/{1}/{2}", datPhong.NgayDen.Year, datPhong.NgayDen.Month, datPhong.NgayDen.Day);
                string ngaydi = string.Format("{0}/{1}/{2}", datPhong.NgayDi.Year, datPhong.NgayDi.Month, datPhong.NgayDi.Day);

                string sql = string.Format("update DatPhong SET MaDatPhong = '" + datPhong.MaDatPhong + "', MaKH = '" + datPhong.MaKH + "', MaPhong = '" + datPhong.MaPhong + "' , NgayDen = '" + ngayden + "', NgayDi = '" + ngaydi + "', GhiChu = '" + datPhong.GhiChu + "' WHERE MaDatPhong = '" + datPhong.MaDatPhong + "' ");
                thucthisql(sql);
                string tt = string.Format("UPDATE Phong SET TrangThaiPhong = N'Đã có khách' WHERE MaPhong = '" + datPhong.MaPhong + "' ", chuoikn);
                thucthisql(tt);

            }

            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }



        public bool XoaDatPhong(string DV)
        {
            string sql = string.Format("DELETE FROM DatPhong WHERE MaDatPhong = '{0}'", DV);
            thucthisql(sql);
            return true;
        }

        public List<string> LayDanhSachMaDP()
        {
            List<string> listMaDP = new List<string>();
            try
            {
                string sql = "SELECT MaDatPhong FROM DatPhong";
                SqlDataAdapter da = new SqlDataAdapter(sql, chuoikn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        listMaDP.Add(row["MaDatPhong"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return listMaDP;
        }
    }
}
