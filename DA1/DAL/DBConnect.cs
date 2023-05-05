
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;



namespace DAL
{
    public class DBConnect
    {

        protected SqlConnection chuoikn = new SqlConnection(@"Data Source=LAPTOP-B8V4R50K\SQLEXPRESS;Initial Catalog=QL_Resort_DA1;Integrated Security=True");
        protected SqlCommand cmd;
        protected SqlDataAdapter da;
        protected DataTable dt;
        public void thucthisql(string sql)
        {
            chuoikn.Open();
            cmd = new SqlCommand(sql, chuoikn);
            cmd.ExecuteNonQuery();
            chuoikn.Close();
        }

        public string GetMD5Hash(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                // Chuyển đổi chuỗi đầu vào thành một mảng byte và tính toán chuỗi băm.
                byte[] inputBytes = Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Chuyển đổi mảng byte thành một chuỗi hexa.
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }
    }
}
