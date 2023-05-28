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
            da = new SqlDataAdapter("select MaDatPhong as [Mã ĐP], MaDV as [Mã DV], TenDV as [Tên dịch vụ], SoLuong as [Số lượng] , TongTien as [Tổng tiền] from ChiTietDatPhong\r\n", chuoikn);
            dt = new DataTable();
            da.Fill(dt);
            chuoikn.Close();
            return dt;
        }

        public int kiemtramatrung(string ma, string madp)
        {
            chuoikn.Open();
            int i;
            string sql = "SELECT COUNT(*) FROM ChiTietDatPhong WHERE MaDV='" + ma.Trim() + "' AND MaDatPhong='" + madp + "'";
            cmd = new SqlCommand(sql, chuoikn);
            i = (int)cmd.ExecuteScalar();
            chuoikn.Close();
            return i;
        }

        //tính tổng tiền cho chi tiết đặt phòng. giá dịch vụ * số lượng
        public decimal TinhTongTien(string maDatPhong)
        {
            decimal tongTien = 0; // Khởi tạo biến tổng tiền với giá trị ban đầu là 0
            try
            {
                string sql = string.Format("SELECT SUM(TongTien) FROM ChiTietDatPhong WHERE MaDatPhong = '{0}'", maDatPhong);
                SqlDataAdapter da = new SqlDataAdapter(sql, chuoikn);
                DataTable dt = new DataTable();
                da.Fill(dt); // Thực hiện truy vấn và lưu kết quả vào DataTable
                if (dt.Rows.Count > 0 && dt.Rows[0][0] != DBNull.Value)
                {
                    tongTien = Convert.ToDecimal(dt.Rows[0][0]); // Gán giá trị tổng tiền từ kết quả truy vấn
                }
            }
            catch (Exception ex)
            {
                throw ex; // Xử lý ngoại lệ và ném lại ngoại lệ cho phần gọi hàm xử lý
            }
            return tongTien; // Trả về tổng tiền
        }





        public void ThemChiTietDichVu(DTO_ChiTietDV ctdv)
        {
            string sql = string.Format("INSERT INTO ChiTietDatPhong( MaDatPhong, MaDV,TenDV, SoLuong, TongTien) VALUES ('{0}', '{1}', N'{2}', {3}, {4})", ctdv.MaDatPhong, ctdv.MaDV, ctdv.TenDV, ctdv.SoLuong, ctdv.TongTien);
            thucthisql(sql);
        }

        public bool SuaCTDV(DTO_ChiTietDV ctdv)
        {
            string sql = string.Format("update ChiTietDatPhong SET MaDatPhong = '" + ctdv.MaDatPhong + "', MaDV = '" + ctdv.MaDV + "' ,TenDV = N'" + ctdv.TenDV + "' , SoLuong = '" + ctdv.SoLuong + "', TongTien = '" + ctdv.TongTien + "' WHERE MaDV = '" + ctdv.MaDV + "' AND MaDatPhong='" + ctdv.MaDatPhong + "' ");
            thucthisql(sql);
            return true;
        }

        public bool Xoa(string DV, string madp)
        {
            string sql = "Delete from ChiTietDatPhong where MaDV='" + DV + "' AND MaDatPhong='" + madp + "' ";
            thucthisql(sql);
            return true;
        }

        #region Tìm Kiếm
        public List<DTO_ChiTietDV> TimKiem(string keyword)
        {
            List<DTO_ChiTietDV> results = new List<DTO_ChiTietDV>();
            chuoikn.Open();

            string sql = "SELECT * FROM ChiTietDatPhong WHERE  MaDatPhong LIKE @Keyword OR MaDV LIKE @Keyword OR TenDV LIKE @Keyword OR SoLuong LIKE @Keyword OR TongTien LIKE @Keyword";
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

        //Khi chọn mã dịch vụ sẽ lấy thông tin trong dịch vụ được chọn. vd: chọn mã sẽ đổ ra tên
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
                    string TenDV = reader["TenDV"].ToString(); // Lấy giá trị của cột "TenDV" từ đọc giả và chuyển đổi thành chuỗi

                    decimal giatien = decimal.Parse(reader["GiaTien"].ToString()); // Lấy giá trị của cột "GiaTien" từ đọc giả và chuyển đổi thành số thực

                    dp = new DTO_DichVu(maDV, TenDV, giatien); // Khởi tạo đối tượng DTO_DichVu với các thông tin lấy được từ cơ sở dữ liệu
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                throw ex; // Ném ra ngoại lệ nếu có lỗi xảy ra
            }
            finally
            {
                chuoikn.Close(); // Đảm bảo rằng kết nối sẽ được đóng ngay cả khi có ngoại lệ xảy ra
            }

            return dp; // Trả về đối tượng DTO_DichVu
        }

    }
}
