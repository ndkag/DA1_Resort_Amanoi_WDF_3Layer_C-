using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
using GUI.Hệ_thống;

namespace GUI
{
    public partial class LoginForm : Form
    {
        private AccountBLL accountBLL;
        public LoginForm()
        {
            InitializeComponent();
            accountBLL = new AccountBLL();
        }

    
        public void loginButton_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Texts;
            string password = txtPassword.Texts;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu và tài khoản!");
                return;
            }
            AccountDTO account = accountBLL.GetAccountByUsernameAndPassword(username, password);

            if (account == null)
            {
                MessageBox.Show("Mật khẩu hoặc tài khoản bạn sai, vui lòng nhập lại!");
            }
            else
            {
                if (account.Type == 0)
                {
                    // Admin login
                    MessageBox.Show("Chào mừng Admin " + account.DisplayName + " đăng nhập thành công.");

                    Menu mainMenu = new Menu();
                    mainMenu.lb_Ten.Text = account.DisplayName;
                    mainMenu.lb_ID.Text = account.UserName;

                    this.Hide();
                    mainMenu.ShowDialog();
                }
                else
                {
                    // User login
                    MessageBox.Show("Chào mừng " + account.DisplayName + "đăng nhập thành công.");
                    Menu mainMenu = new Menu();
                    mainMenu.btn_TaiKhoan.Visible = false;
                    mainMenu.btn_QLDichVu.Visible = false;
                    mainMenu.btn_QLPhong.Visible = false;
                    mainMenu.btn_Nhanvien.Visible = false;


                    mainMenu.lb_Ten.Text = account.DisplayName;
                    mainMenu.lb_ID.Text = account.UserName;
                    this.Hide();
                    mainMenu.Show();
                }
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }


        private void hienthimk_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            string Name = txtPassword.Texts;

            String thanhvien = hienthimk.Text;
            if (hienthimk.Checked)
                txtPassword.PasswordChar = false;
            else
                txtPassword.PasswordChar = true;
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) || e.KeyChar >= 128)
            {
                // Nếu ký tự nhập vào không phải là số hoặc chữ tiếng Anh
                // hoặc là ký tự tiếng Việt thì hủy sự kiện
                // Ngoại trừ các phím điều khiển như phím xoá, phím backspace
                e.Handled = true;
            }


        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) || e.KeyChar >= 128)
            {
                // Nếu ký tự nhập vào không phải là số hoặc chữ tiếng Anh
                // hoặc là ký tự tiếng Việt thì hủy sự kiện
                // Ngoại trừ các phím điều khiển như phím xoá, phím backspace
                e.Handled = true;
            }
        }
    }
    
}
