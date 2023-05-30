using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_HoaDon : DBConnect
    {
        public DataTable getDatPhongByMaPhong(string maPhong)
        {
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM ChiTietDatPhong WHERE MaDatPhong IN (SELECT MaDatPhong FROM DatPhong WHERE MaPhong = '" + maPhong + "')";
            cmd = new SqlCommand(sql, chuoikn);
            cmd.Parameters.AddWithValue("@maPhong", maPhong);
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }


        public string getMaDatPhongByMaPhong(string maPhong)
        {
            string sql = "SELECT COALESCE(MAX(MaDatPhong), 'DP00000') as MaDatPhong FROM DatPhong WHERE MaPhong = '" + maPhong + "' ";
            dt = new DataTable();
            da = new SqlDataAdapter(sql, chuoikn);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0]["MaDatPhong"].ToString();
            }
            else
            {
                return "";
            }
        }

        #region Datagridview

        public DataTable getHoaDon(string maDatPhong)
        {
            chuoikn.Open();
            da = new SqlDataAdapter("SELECT *FROM HoaDon WHERE MaDatPhong = '" + maDatPhong + "' ", chuoikn);
            dt = new DataTable();
            da.Fill(dt);
            chuoikn.Close();
            return dt;
        }
        public DataTable getDPHD(string maDatPhong)
        {
            chuoikn.Open();
            cmd = new SqlCommand("SELECT DatPhong.MaDatPhong as [Mã ĐP], DatPhong.MaKH as [Mã KH] ,DatPhong.GhiChu as [Ghi chú], DatPhong.NgayDen as [Ngày đến],DatPhong.NgayDi as [Ngày đi] , Phong.MaPhong as [Mã P], Phong.GiaTien [Giá] FROM DatPhong JOIN Phong ON DatPhong.MaPhong = Phong.MaPhong WHERE DatPhong.MaDatPhong = '" + maDatPhong + "' ", chuoikn);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            chuoikn.Close();
            return dt;
        }


        public DTO_DatPhong LayMaKHTuMaDP(string maDP)
        {
            DTO_DatPhong dp = null;
            string query = "SELECT * FROM DatPhong WHERE MaDatPhong = @MaDatPhong";
            SqlCommand cmd = new SqlCommand(query, chuoikn);
            cmd.Parameters.AddWithValue("@MaDatPhong", maDP);

            try
            {
                chuoikn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {

                    string maKH = reader["MaKH"].ToString();
                    string maPhong = reader["MaPhong"].ToString();
                    DateTime ngayDen = DateTime.Parse(reader["NgayDen"].ToString());
                    DateTime ngayDi = DateTime.Parse(reader["NgayDi"].ToString());
                    string ghiChu = reader["GhiChu"].ToString();

                    dp = new DTO_DatPhong(maDP, maKH, maPhong, ngayDen, ngayDi, ghiChu);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                chuoikn.Close();
            }

            return dp;
        }



        public DataTable getChiTietDV(string maDatPhong)
        {
            chuoikn.Open();
            cmd = new SqlCommand("SELECT MaDatPhong as [Mã ĐP], MaDV as [Mã DV], TenDV as [Tên DV], SoLuong as [Số lượng] , TongTien as [Tổng tiền] FROM ChiTietDatPhong WHERE MaDatPhong = '" + maDatPhong + "' ", chuoikn);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            chuoikn.Close();
            return dt;
        }


        #endregion


        public bool ThemHoaDon(DTO_HoaDon hd)
        {
            string ngay = string.Format("{0}/{1}/{2}", hd.NgayThanhToan.Year, hd.NgayThanhToan.Month, hd.NgayThanhToan.Day);

            string sql = "Insert into HoaDon(MaKH, MaNV, MaDatPhong, TongTien, NgayThanhToan, GhiChu) values('" + hd.MaKH + "','" + hd.MaNV + "','" + hd.MaDatPhong + "','" + hd.TongTien + "','" + ngay + "','" + hd.GhiChu + "')";
            thucthisql(sql);
            return true;
        }

        public bool XoaChiTietDV(string DP)
        {
            string sql = string.Format("DELETE FROM ChiTietDatPhong WHERE MaDatPhong = '{0}'", DP);
            thucthisql(sql);
            return true;
        }

        public bool XoaDatPhong(string DP)
        {
            string sql = string.Format("DELETE FROM DatPhong WHERE MaDatPhong = '{0}'", DP);
            thucthisql(sql);
            return true;
        }
        public bool CapNhatTrangThaiPhong(string maPhong, string trangThai)
        {
            try
            {
                chuoikn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Phong SET TrangThaiPhong = @TrangThaiPhong WHERE MaPhong = @MaPhong", chuoikn);
                cmd.Parameters.AddWithValue("@MaPhong", maPhong);
                cmd.Parameters.AddWithValue("@TrangThaiPhong", trangThai);

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                    return true;
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                chuoikn.Close();
            }
        }

        #region form quản lý hoá đơn

        public DataTable getQLHoaDon()
        {
            chuoikn.Open();
            da = new SqlDataAdapter("SELECT MaHD as [Mã HD], MaKH as [Mã KH], MaNV as [Mã NV], MaDatPhong as [Mã ĐP], TongTien as [Tổng tiền], NgayThanhToan as [Ngày TT], Ghichu as [Ghi chú] FROM HoaDon ", chuoikn);
            dt = new DataTable();
            da.Fill(dt);
            chuoikn.Close();
            return dt;
        }

        public DataTable getQLHoaDonwheremahoadon(string mahoadon)
        {
            chuoikn.Open();
            da = new SqlDataAdapter("SELECT MaHD as [Mã HD], MaKH as [Mã KH], MaNV as [Mã NV], MaDatPhong as [Mã ĐP], TongTien as [Tổng tiền], NgayThanhToan as [Ngày TT], Ghichu as [Ghi chú] FROM HoaDon where MaDatPhong =  '" + mahoadon + "' ", chuoikn);
            dt = new DataTable();
            da.Fill(dt);
            chuoikn.Close();
            return dt;
        }
        public bool XoaHoaDon(string HD)
        {
            string sql = string.Format("DELETE FROM HoaDon WHERE MaHD = '{0}'", HD);
            thucthisql(sql);
            return true;
        }
        public bool SuaDH(DTO_HoaDon HD)
        {
            string ngay = string.Format("{0}/{1}/{2}", HD.NgayThanhToan.Year, HD.NgayThanhToan.Month, HD.NgayThanhToan.Day);

            string sql = "UPDATE HoaDon SET MaHD = '" + HD.MaHD + "',MaKH = '" + HD.MaKH + "', MaNV = '" + HD.MaNV + "', MaDatPhong = '" + HD.MaDatPhong + "', TongTien = '" + HD.TongTien + "', NgayThanhToan = '" + ngay + "', GhiChu = N'" + HD.GhiChu + "' WHERE MaHD = '" + HD.MaHD + "' ";
            thucthisql(sql);
            return true;
        }

        public List<DTO_HoaDon> TimKiem(string keyword)
        {
            List<DTO_HoaDon> results = new List<DTO_HoaDon>();
            chuoikn.Open();

            string sql = "SELECT * FROM HoaDon WHERE MaHD LIKE @Keyword OR MaKH LIKE @Keyword OR MaNV LIKE @Keyword OR MaDatPhong LIKE @Keyword OR TongTien LIKE @Keyword OR NgayThanhToan LIKE @Keyword OR GhiChu LIKE @Keyword  ";
            using (SqlCommand command = new SqlCommand(sql, chuoikn))
            {
                command.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DTO_HoaDon dto = new DTO_HoaDon();
                        dto.MaHD = reader.GetString(reader.GetOrdinal("MaHD"));
                        dto.MaKH = reader.GetString(reader.GetOrdinal("MaKH"));
                        dto.MaNV = reader.GetString(reader.GetOrdinal("MaNV"));
                        dto.MaDatPhong = reader.GetString(reader.GetOrdinal("MaDatPhong"));
                        dto.TongTien = reader.GetDecimal(reader.GetOrdinal("TongTien"));
                        dto.NgayThanhToan = reader.GetDateTime(reader.GetOrdinal("NgayThanhToan"));
                        dto.GhiChu = reader.GetString(reader.GetOrdinal("GhiChu"));
                        results.Add(dto);
                    }
                }
            }
            chuoikn.Close();


            return results;
        }


        public int kiemtramatrung(string ma)
        {
            chuoikn.Open();
            int i;
            string sql = "Select count(*) from HoaDon where MaDatPhong='" + ma.Trim() + "'";
            cmd = new SqlCommand(sql, chuoikn);
            i = (int)cmd.ExecuteScalar();
            chuoikn.Close();
            return i;
        }
        #endregion
    }
}
