using DTO;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace DAL
{
    public class DAL_QLNV : DBConnect
    {

        public DataTable getQLNV()
        {
            chuoikn.Open();
            da = new SqlDataAdapter("Select * from NhanVien", chuoikn);
            dt = new DataTable();
            da.Fill(dt);
            chuoikn.Close();
            return dt;
        }

        #region Tìm Kiếm
        public List<DTO_QLNV> TimKiem(string keyword)
        {
            List<DTO_QLNV> results = new List<DTO_QLNV>();


            chuoikn.Open();

            string sql = "SELECT * FROM NhanVien WHERE MaNV LIKE @Keyword OR TenNV LIKE @Keyword OR DiaChi LIKE @Keyword OR SoDienThoai LIKE @Keyword OR ViTri LIKE @Keyword OR Luong LIKE @Keyword";
            using (SqlCommand command = new SqlCommand(sql, chuoikn))
            {
                command.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DTO_QLNV dto = new DTO_QLNV();
                        dto.MaNV = reader.GetString(reader.GetOrdinal("MaNV"));
                        dto.TenNV = reader.GetString(reader.GetOrdinal("TenNV"));
                        dto.DiaChi = reader.GetString(reader.GetOrdinal("DiaChi"));
                        dto.SoDienThoai = reader.GetString(reader.GetOrdinal("SoDienThoai"));
                        dto.ViTri = reader.GetString(reader.GetOrdinal("ViTri"));
                        dto.Luong = reader.GetDecimal(reader.GetOrdinal("Luong"));

                        results.Add(dto);
                    }
                }
            }
            chuoikn.Close();


            return results;
        }

        #endregion


        public bool ThemNV(DTO_QLNV NV)
        {
            string sql = "Insert into NhanVien(TenNV,DiaChi,SoDienThoai,ViTri,Luong) values(N'" + NV.TenNV + "',N'" + NV.DiaChi + "','" + NV.SoDienThoai + "',N'" + NV.ViTri + "','" + NV.Luong + "')";
            thucthisql(sql);
            return true;
        }


        public bool SuaNV(DTO_QLNV NV)
        {

            string sql = "UPDATE NhanVien SET MaNV = '" + NV.MaNV + "', TenNV = N'" + NV.TenNV + "', DiaChi = N'" + NV.DiaChi + "', SoDienThoai = '" + NV.SoDienThoai + "', ViTri =N'" + NV.ViTri + "', Luong ='" + NV.Luong + "' WHERE MaNV = '" + NV.MaNV + "' ";


            thucthisql(sql);
            return true;
        }
        public bool XoaNV(string NV)
        {
            string sql = "Delete from NhanVien where MaNV='" + NV + "'";
            thucthisql(sql);
            return true;
        }
    }
}
