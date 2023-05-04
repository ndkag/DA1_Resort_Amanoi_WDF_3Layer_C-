using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace DAL
{
    public class DAL_ChiTietDV : DBConnect
    {

        public DataTable getChiTietDV()
        {
            chuoikn.Open();
            da = new SqlDataAdapter("select MaDatPhong as [Mã ĐP], MaDV as [Mã DV], TenDV as [Tên dịch vụ], SoLuong as [Số lượng] , TongTien as [Tổng tiền] from ChiTietDichVu\r\n", chuoikn);
            dt = new DataTable();
            da.Fill(dt);
            chuoikn.Close();
            return dt;
        }

        public int kiemtramatrung(string ma, string madp)
        {
            chuoikn.Open();
            int i;
            string sql = "SELECT COUNT(*) FROM ChiTietDichVu WHERE MaDV='" + ma.Trim() + "' AND MaDatPhong='" + madp + "'";
            cmd = new SqlCommand(sql, chuoikn);
            i = (int)cmd.ExecuteScalar();
            chuoikn.Close();
            return i;
        }

        public decimal TinhTongTien(string maDatPhong)
        {
            decimal tongTien = 0;
            try
            {
                string sql = string.Format("SELECT SUM(TongTien) FROM ChiTietDichVu WHERE MaDatPhong = '{0}'", maDatPhong);
                SqlDataAdapter da = new SqlDataAdapter(sql, chuoikn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0 && dt.Rows[0][0] != DBNull.Value)
                {
                    tongTien = Convert.ToDecimal(dt.Rows[0][0]);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return tongTien;
        }


        public List<string> LayDanhSachMa()
        {
            List<string> listMaDP = new List<string>();
            try
            {
                string sql = "SELECT MaCTDV FROM ChiTietDichVu";
                SqlDataAdapter da = new SqlDataAdapter(sql, chuoikn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        listMaDP.Add(row["MaCTDV"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return listMaDP;
        }
        public void ThemChiTietDichVu(DTO_ChiTietDV ctdv)
        {
            string sql = string.Format("INSERT INTO ChiTietDichVu( MaDatPhong, MaDV,TenDV, SoLuong, TongTien) VALUES ('{0}', '{1}', N'{2}', {3}, {4})", ctdv.MaDatPhong, ctdv.MaDV, ctdv.TenDV, ctdv.SoLuong, ctdv.TongTien);
            thucthisql(sql);
        }

        public bool SuaCTDV(DTO_ChiTietDV ctdv)
        {
            string sql = string.Format("update ChiTietDichVu SET MaDatPhong = '" + ctdv.MaDatPhong + "', MaDV = '" + ctdv.MaDV + "' ,TenDV = N'" + ctdv.TenDV + "' , SoLuong = '" + ctdv.SoLuong + "', TongTien = '" + ctdv.TongTien + "' WHERE MaDV = '" + ctdv.MaDV + "' AND MaDatPhong='" + ctdv.MaDatPhong + "' ");
            thucthisql(sql);
            return true;
        }

        public bool Xoa(string DV, string madp)
        {
            string sql = "Delete from ChiTietDichVu where MaDV='" + DV + "' AND MaDatPhong='" + madp + "' ";
            thucthisql(sql);
            return true;
        }

        #region Tìm Kiếm
        public List<DTO_ChiTietDV> TimKiem(string keyword)
        {
            List<DTO_ChiTietDV> results = new List<DTO_ChiTietDV>();
            chuoikn.Open();

            string sql = "SELECT * FROM ChiTietDichVu WHERE  MaDatPhong LIKE @Keyword OR MaDV LIKE @Keyword OR TenDV LIKE @Keyword OR SoLuong LIKE @Keyword OR TongTien LIKE @Keyword";
            using (SqlCommand command = new SqlCommand(sql, chuoikn))
            {
                command.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DTO_ChiTietDV dto = new DTO_ChiTietDV();
                        dto.MaDatPhong = reader.GetString(reader.GetOrdinal("MaDatPhong"));
                        dto.MaDV = reader.GetString(reader.GetOrdinal("MaDV"));
                        dto.TenDV = reader.GetString(reader.GetOrdinal("TenDV"));

                        dto.SoLuong = reader.GetDecimal(reader.GetOrdinal("SoLuong"));
                        dto.TongTien = reader.GetDecimal(reader.GetOrdinal("TongTien"));
                        results.Add(dto);
                    }
                }
            }
            chuoikn.Close();


            return results;
        }

        #endregion

        public DTO_DichVu LayMaTuMaDV(string maDV)
        {
            DTO_DichVu dp = null;
            string query = "SELECT * FROM DichVu WHERE MaDV = @MaDV";
            SqlCommand cmd = new SqlCommand(query, chuoikn);
            cmd.Parameters.AddWithValue("@MaDV", maDV);

            try
            {
                chuoikn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {

                    string TenDV = reader["TenDV"].ToString();

                    decimal giatien = decimal.Parse(reader["GiaTien"].ToString());


                    dp = new DTO_DichVu(maDV, TenDV, giatien);
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
    }
}
