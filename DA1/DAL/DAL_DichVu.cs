using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace DAL
{
    public class DAL_DichVu : DBConnect
    {
        public List<string> LayDanhSachMa()
        {
            List<string> listMaDP = new List<string>();
            try
            {
                string sql = "SELECT MaDV FROM DichVu";
                SqlDataAdapter da = new SqlDataAdapter(sql, chuoikn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        listMaDP.Add(row["MaDV"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return listMaDP;
        }

        public DataTable getDichVu()
        {
            chuoikn.Open();
            da = new SqlDataAdapter("Select * from DichVu", chuoikn);
            dt = new DataTable();
            da.Fill(dt);
            chuoikn.Close();
            return dt;
        }

        #region Tìm Kiếm
        public List<DTO_DichVu> TimKiem(string keyword)
        {
            List<DTO_DichVu> results = new List<DTO_DichVu>();


            chuoikn.Open();

            string sql = "SELECT * FROM DichVu WHERE MaDV LIKE @Keyword OR TenDV LIKE @Keyword OR GiaTien LIKE @Keyword";
            using (SqlCommand command = new SqlCommand(sql, chuoikn))
            {
                command.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DTO_DichVu dto = new DTO_DichVu();
                        dto.MaDV = reader.GetString(reader.GetOrdinal("MaDV"));
                        dto.TenDV = reader.GetString(reader.GetOrdinal("TenDV"));
                        dto.GiaTien = reader.GetDecimal(reader.GetOrdinal("GiaTien"));

                        results.Add(dto);
                    }
                }
            }
            chuoikn.Close();


            return results;
        }

        #endregion
        public int kiemtramatrung(string ma)
        {
            chuoikn.Open();
            int i;
            string sql = "Select count(*) from DichVu where MaDV='" + ma.Trim() + "'";
            cmd = new SqlCommand(sql, chuoikn);
            i = (int)cmd.ExecuteScalar();
            chuoikn.Close();
            return i;
        }
        //Thêm phòng
        public bool ThemDV(DTO_DichVu DV)
        {
            string sql = "Insert into DichVu(TenDV,GiaTien) values(N'" + DV.TenDV + "','" + DV.GiaTien + "')";
            thucthisql(sql);
            return true;
        }


        public bool SuaDV(DTO_DichVu DV)
        {

            string sql = "UPDATE DichVu SET MaDV = '" + DV.MaDV + "', TenDV = N'" + DV.TenDV + "', GiaTien = '" + DV.GiaTien + "' WHERE MaDV = '" + DV.MaDV + "' ";


            thucthisql(sql);
            return true;
        }
        public bool XoaDV(string DV)
        {
            string sql = "Delete from DichVu where MaDV='" + DV + "'";
            thucthisql(sql);
            return true;
        }

        public decimal LayGiaTien(string maDV)
        {
            decimal giaTien = 0;
            string query = "SELECT GiaTien FROM DichVu WHERE MaDV = @maDV";
            using (SqlCommand command = new SqlCommand(query, chuoikn))
            {
                command.Parameters.AddWithValue("@maDV", maDV);
                chuoikn.Open();
                object result = command.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    giaTien = (decimal)result;
                }
                chuoikn.Close();
            }
            return giaTien;
        }





    }
}
