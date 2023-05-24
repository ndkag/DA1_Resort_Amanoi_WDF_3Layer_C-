using DTO;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace DAL
{
    public class DAL_QLKhachHang : DBConnect
    {
        //public int kiemtramatrung(string ma)
        //{
        //    chuoikn.Open();
        //    int i;
        //    string sql = "Select count(*) from KhachHang where MaKH='" + ma.Trim() + "'";
        //    cmd = new SqlCommand(sql, chuoikn);
        //    i = (int)cmd.ExecuteScalar();
        //    chuoikn.Close();
        //    return i;
        //}

        public DataTable getQLKhachHang()
        {
            chuoikn.Open();
            da = new SqlDataAdapter("Select * from KhachHang", chuoikn);
            dt = new DataTable();
            da.Fill(dt);
            chuoikn.Close();
            return dt;
        }

        #region Tìm Kiếm
        public List<DTO_QLKhachHang> TimKiems(string keyword)
        {
            List<DTO_QLKhachHang> results = new List<DTO_QLKhachHang>();


            chuoikn.Open();

            string sql = "SELECT * FROM KhachHang WHERE MaKH LIKE @Keyword OR TenKH LIKE @Keyword OR DiaChi LIKE @Keyword OR SoDienThoai LIKE @Keyword OR NgayTao LIKE @Keyword ";
            using (SqlCommand command = new SqlCommand(sql, chuoikn))
            {
                command.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DTO_QLKhachHang dto = new DTO_QLKhachHang();
                        dto.MaKH = reader.GetString(reader.GetOrdinal("MaKH"));
                        dto.TenKH = reader.GetString(reader.GetOrdinal("TenKH"));
                        dto.DiaChi = reader.GetString(reader.GetOrdinal("DiaChi"));
                        dto.SoDienThoai = reader.GetString(reader.GetOrdinal("SoDienThoai"));
                        dto.NgayTao = reader.GetDateTime(reader.GetOrdinal("NgayTao"));


                        results.Add(dto);
                    }
                }
            }
            chuoikn.Close();


            return results;
        }

        #endregion


        //Thêm phòng
        public bool ThemKH(DTO_QLKhachHang KH)
        {
            string sql = "Insert into KhachHang(TenKH, DiaChi, SoDienThoai) values(N'" + KH.TenKH + "',N'" + KH.DiaChi + "','" + KH.SoDienThoai + "')";
            thucthisql(sql);
            return true;
        }

        public bool SuaKH(DTO_QLKhachHang KH)
        {
            string ngay = string.Format("{0}/{1}/{2}", KH.NgayTao.Year, KH.NgayTao.Month, KH.NgayTao.Day);
            string sql = "UPDATE KhachHang SET MaKH = '" + KH.MaKH + "', TenKH = N'" + KH.TenKH + "', DiaChi = N'" + KH.DiaChi + "', SoDienThoai = '" + KH.SoDienThoai + "',NgayTao = '" + ngay + "' WHERE MaKH = '" + KH.MaKH + "' ";


            thucthisql(sql);
            return true;
        }
        public bool XoaKH(string KH)
        {
            string sql = "Delete from KhachHang where MaKH='" + KH + "'";
            thucthisql(sql);
            return true;
        }
    }
}
