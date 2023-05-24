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

        //gọi ra các phòng trống để hiển thị trong form đặt phòng
        public List<QLPhongDTO> LayDanhSachPhongTrong()
        {
            // Tạo một danh sách mới để lưu trữ các phòng trống
            List<QLPhongDTO> listPhongTrong = new List<QLPhongDTO>();

            // Câu truy vấn SQL để lấy danh sách các phòng trống
            string query = "SELECT * FROM Phong WHERE TrangThaiPhong = N'Trống'";

            // Tạo một đối tượng SqlCommand với câu truy vấn và kết nối cơ sở dữ liệu
            SqlCommand command = new SqlCommand(query, chuoikn);

            // Mở kết nối đến cơ sở dữ liệu
            chuoikn.Open();

            // Thực thi câu truy vấn và lấy dữ liệu trả về dưới dạng SqlDataReader
            SqlDataReader reader = command.ExecuteReader();

            // Duyệt qua từng dòng dữ liệu trong SqlDataReader
            while (reader.Read())
            {
                // Tạo một đối tượng QLPhongDTO mới để lưu trữ thông tin của phòng
                QLPhongDTO phong = new QLPhongDTO();

                // Đọc dữ liệu từ từng cột trong SqlDataReader và gán cho thuộc tính tương ứng trong QLPhongDTO
                phong.MaPhong = reader.GetString(0);
                phong.TenPhong = reader.GetString(1);
                phong.TrangThaiPhong = reader.GetString(2);
                phong.GiaTien = reader.GetDecimal(3);
                phong.SoLuongNguoi = reader.GetInt32(4);
                phong.KhaNangDatPhong = reader.GetInt32(5);

                // Thêm đối tượng phòng vào danh sách các phòng trống
                listPhongTrong.Add(phong);
            }

            // Đóng SqlDataReader để giải phóng tài nguyên
            reader.Close();

            // Đóng kết nối đến cơ sở dữ liệu
            chuoikn.Close();

            // Trả về danh sách các phòng trống
            return listPhongTrong;
        }


        public bool ThemDP(DTO_DatPhong datPhong)
        {
            try
            {
                // Chuyển đổi ngày đến và ngày đi thành chuỗi theo định dạng "ngày/tháng/năm"
                string ngayden = string.Format("{0}/{1}/{2}", datPhong.NgayDen.Year, datPhong.NgayDen.Month, datPhong.NgayDen.Day);
                string ngaydi = string.Format("{0}/{1}/{2}", datPhong.NgayDi.Year, datPhong.NgayDi.Month, datPhong.NgayDi.Day);

                // Tạo câu truy vấn SQL để thêm thông tin đặt phòng vào bảng DatPhong
                string sql = "Insert into DatPhong(MaKH,MaPhong,NgayDen,NgayDi,GhiChu) values('" + datPhong.MaKH + "','" + datPhong.MaPhong + "','" + ngayden + "','" + ngaydi + "',N'" + datPhong.GhiChu + "')";

                // Thực thi câu truy vấn SQL để thêm đặt phòng
                thucthisql(sql);

                // Tạo câu truy vấn SQL để cập nhật trạng thái phòng thành "Đã có khách" trong bảng Phong
                string tt = string.Format("UPDATE Phong SET TrangThaiPhong = N'Đã có khách' WHERE MaPhong = '" + datPhong.MaPhong + "' ", chuoikn);

                // Thực thi câu truy vấn SQL để cập nhật trạng thái phòng
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
                // Chuyển đổi ngày đến và ngày đi thành chuỗi theo định dạng "ngày/tháng/năm"
                string ngayden = string.Format("{0}/{1}/{2}", datPhong.NgayDen.Year, datPhong.NgayDen.Month, datPhong.NgayDen.Day);
                string ngaydi = string.Format("{0}/{1}/{2}", datPhong.NgayDi.Year, datPhong.NgayDi.Month, datPhong.NgayDi.Day);

                // Tạo câu truy vấn SQL để cập nhật thông tin đặt phòng trong bảng DatPhong
                string sql = string.Format("update DatPhong SET MaDatPhong = '" + datPhong.MaDatPhong + "', MaKH = '" + datPhong.MaKH + "', MaPhong = '" + datPhong.MaPhong + "' , NgayDen = '" + ngayden + "', NgayDi = '" + ngaydi + "', GhiChu = '" + datPhong.GhiChu + "' WHERE MaDatPhong = '" + datPhong.MaDatPhong + "' ");

                // Thực thi câu truy vấn SQL để cập nhật thông tin đặt phòng
                thucthisql(sql);

                // Tạo câu truy vấn SQL để cập nhật trạng thái phòng thành "Đã có khách" trong bảng Phong
                string tt = string.Format("UPDATE Phong SET TrangThaiPhong = N'Đã có khách' WHERE MaPhong = '" + datPhong.MaPhong + "' ", chuoikn);

                // Thực thi câu truy vấn SQL để cập nhật trạng thái phòng
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

        //public List<string> LayDanhSachMaDP()
        //{
        //    List<string> listMaDP = new List<string>();
        //    try
        //    {
        //        string sql = "SELECT MaDatPhong FROM DatPhong";
        //        SqlDataAdapter da = new SqlDataAdapter(sql, chuoikn);
        //        DataTable dt = new DataTable();
        //        da.Fill(dt);
        //        if (dt.Rows.Count > 0)
        //        {
        //            foreach (DataRow row in dt.Rows)
        //            {
        //                listMaDP.Add(row["MaDatPhong"].ToString());
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    return listMaDP;
        //}
    }
}
