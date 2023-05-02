using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Security.Cryptography;

namespace GUI.Hệ_thống
{
    public partial class Quản_lý_tài_khoản : Form
    { 
        private DataTable accounts;
        AccountBLL tkbll = new AccountBLL();

        public Quản_lý_tài_khoản()
        {
            InitializeComponent();
      

        }
        private void Quản_lý_tài_khoản_Load(object sender, EventArgs e)
        {
            refreshdatagridview();
            dataGridView1.DataSource = tkbll.getAccount();
            //dataGridView1.Columns[0].Width = 30;
            //dataGridView1.Columns[1].Width = 60;
            //dataGridView1.Columns[2].Width = 110;
        }


        private void refreshdatagridview() //giúp load lại trang dữ liệu
        {
            accounts = tkbll.getAccount();
            dataGridView1.DataSource = accounts;
        }
        public string GetMD5Hash(string input) // mã hoá mật khẩu
        {
            using (MD5 md5Hash = MD5.Create())
            {
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < data.Length; i++)
                {
                    builder.Append(data[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }
    

 

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string userName = txt_UserName.Texts;

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                if (tkbll.DeleteAccount(userName) == true)
                {
                    MessageBox.Show("Xoa thanh cong");
                    dataGridView1.DataSource = tkbll.getAccount();
                  

                }
            }
        }

     

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            txt_UserName.Texts = "";
            txt_DisplayName.Texts = "";
            txt_Password.Texts = "";
            txt_UserName.Enabled = true;
            refreshdatagridview();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            // Get data from controls
            string userName = txt_UserName.Texts.Trim();
            string displayName = txt_DisplayName.Texts.Trim();
            string password = GetMD5Hash(txt_Password.Texts.Trim());
            int type = checkBoxIsAdmin.Checked ? 0 : 1;
            AccountDTO acc = new AccountDTO(userName, displayName, password, type);
            if (tkbll.UpdateAccount(acc) == true)
            {
                MessageBox.Show("Sua thanh cong");
                dataGridView1.DataSource = tkbll.getAccount();
               

            }
        }

 


        private void btn_Them_Click(object sender, EventArgs e)
        {
            string userName = txt_UserName.Texts.Trim();
            string displayName = txt_DisplayName.Texts.Trim();
            string password = GetMD5Hash(txt_Password.Texts.Trim());
            int type = checkBoxIsAdmin.Checked ? 0 : 1;
            AccountDTO acc = new AccountDTO(userName, displayName, password, type);
            if (tkbll.kiemtramatrung(userName) == 1)
            {
                MessageBox.Show("Tài khoản trùng");
            }
            else
            {
                if (tkbll.ThemTK(acc) == true)
                {
                    MessageBox.Show("Them thanh cong");
                    dataGridView1.DataSource = tkbll.getAccount();

                }
            }
        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            // Display data in controls
            if (hang == -1) return;

            txt_UserName.Texts = dataGridView1[0, hang].Value.ToString();
            txt_DisplayName.Texts = dataGridView1[1, hang].Value.ToString();
            checkBoxIsAdmin.Checked = dataGridView1[3, hang].Value.ToString() == "0";
            txt_UserName.Enabled = false;
        }

     

        
    }
}
