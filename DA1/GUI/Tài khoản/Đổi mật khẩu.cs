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

namespace GUI.Hệ_thống
{
    public partial class Đổi_mật_khẩu : Form
    {
        public Đổi_mật_khẩu()
        {
            InitializeComponent();
        }
        AccountBLL accBLL = new AccountBLL();


        private void btn_DoiMK_Click(object sender, EventArgs e)
        {

            string userName = txtTaiKhoan.Texts.Trim();
            string password = txtMKCu.Texts.Trim();
            string mkmoi = accBLL.GetMD5Hash(txtMKMoi.Texts.Trim());
            string xacnhanmk = accBLL.GetMD5Hash(txtXacNhanMK.Texts.Trim());
            AccountDTO account = new AccountDTO
            {
                UserName = userName,

                Password = mkmoi,

            };

            DialogResult dr = MessageBox.Show("Bạn có muốn đổi mật khẩu ko ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (accBLL.kiemtramatrung(password) == 1)
                {
                    MessageBox.Show("Mật khẩu cũ ko đúng, vui lòng nhập lại !!!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    txtMKCu.Texts = " ";
                }
                else if (mkmoi != xacnhanmk)
                {
                    MessageBox.Show("Mật khẩu ko trùng với mật khẩu mới, vui lòng nhập lại !!!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                }
                else

                {
                    if (accBLL.Doimk(account) == true)
                    {
                        MessageBox.Show("Chúc mừng bạn đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtMKMoi.Texts = " ";
                        txtMKCu.Texts = " ";
                        txtXacNhanMK.Texts = " ";


                    }




                }
            }
        }

        private void txtMKCu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) || e.KeyChar >= 128)
            {
                // Nếu ký tự nhập vào không phải là số hoặc chữ tiếng Anh
                // hoặc là ký tự tiếng Việt thì hủy sự kiện
                // Ngoại trừ các phím điều khiển như phím xoá, phím backspace
                e.Handled = true;
            }
        }

        private void txtMKMoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) || e.KeyChar >= 128)
            {
                // Nếu ký tự nhập vào không phải là số hoặc chữ tiếng Anh
                // hoặc là ký tự tiếng Việt thì hủy sự kiện
                // Ngoại trừ các phím điều khiển như phím xoá, phím backspace
                e.Handled = true;
            }
        }

        private void txtXacNhanMK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) || e.KeyChar >= 128)
            {
                // Nếu ký tự nhập vào không phải là số hoặc chữ tiếng Anh
                // hoặc là ký tự tiếng Việt thì hủy sự kiện
                // Ngoại trừ các phím điều khiển như phím xoá, phím backspace
                e.Handled = true;
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
