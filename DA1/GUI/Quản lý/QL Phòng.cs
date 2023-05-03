using BLL;
using DTO;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Quản_lý
{
    public partial class QL_Phòng : Form
    {
        QLPhongBLL phongBll = new QLPhongBLL();
        private DataTable phongs;
        public QL_Phòng()
        {
            InitializeComponent();
        }
        private void Quản_lý_Phòng_Load(object sender, EventArgs e)
        {

            refreshdatagridview();

        }

        private void btn_ThemP_Click(object sender, EventArgs e)
        {
            try
            {
                string tenPhong = txt_TenP.Text.Trim();
                string trangThaiPhong = txt_TrangThaiP.Text.Trim();
                decimal giaTien;
                if (!decimal.TryParse(txt_GiaTienP.Text.Trim(), out giaTien))
                {
                    MessageBox.Show("Vui lòng nhập giá tiền!");
                    return;
                }
                if (string.IsNullOrEmpty(tenPhong) || string.IsNullOrEmpty(trangThaiPhong) || string.IsNullOrEmpty(txt_SoNguoiP.Text) || string.IsNullOrEmpty(txt_NgayOP.Text))
                {
                    MessageBox.Show("Vui lòng nhập thông tin!");
                    return;
                }
                int soNguoi = int.Parse(txt_SoNguoiP.Text.Trim());
                int NgayO = int.Parse(txt_NgayOP.Text.Trim());
              
                QLPhongDTO phong = new QLPhongDTO
                {
                    TenPhong = tenPhong,
                    TrangThaiPhong = trangThaiPhong,
                    GiaTien = giaTien,
                    SoLuongNguoi = soNguoi,
                    KhaNangDatPhong = NgayO,
                };

                if (phongBll.ThemP(phong) == true)
                {
                    MessageBox.Show("Thêm thành công");
                    refreshdatagridview();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message,"Thông báo!");
            }



        }
        private void refreshdatagridview() //giúp load lại trang dữ liệu
        {
            phongs = phongBll.getPhong();
            dgv_QLP.DataSource = phongs;


            dgv_QLP.Columns[0].Width = 30;
            dgv_QLP.Columns[1].Width = 60;
            dgv_QLP.Columns[2].Width = 110;
            dgv_QLP.Columns[3].Width = 80;
            dgv_QLP.Columns[4].Width = 80;
            dgv_QLP.Columns[5].Width = 50;
            dgv_QLP.Columns[6].Width = 50;




            //thay đổi tiêu đề

            dgv_QLP.Columns[1].HeaderText = "Mã phòng";
            dgv_QLP.Columns[2].HeaderText = "Tên phòng";
            dgv_QLP.Columns[3].HeaderText = "Trạng thái";
            dgv_QLP.Columns[4].HeaderText = "Giá tiền";
            dgv_QLP.Columns[5].HeaderText = "Số người";
            dgv_QLP.Columns[6].HeaderText = "Số ngày";

            dgv_QLP.Columns["STT"].HeaderText = "STT";


            //Đánh số thứ tự
            dgv_QLP.RowPostPaint += dgv_QLP_RowPostPaint;
        }

        private void btn_TimKiemP_Click(object sender, EventArgs e)
        {

        }

        private void btn_SuaP_Click(object sender, EventArgs e)
        {


      
            try
            {
                string maphong = txt_MaP.Text.Trim();
                string tenPhong = txt_TenP.Text.Trim();
                string trangThaiPhong = txt_TrangThaiP.Text.Trim();
                decimal giaTien = decimal.Parse(txt_GiaTienP.Text.Trim());
                int soNguoi = int.Parse(txt_SoNguoiP.Text.Trim());
                int NgayO = int.Parse(txt_NgayOP.Text.Trim());

                QLPhongDTO phong = new QLPhongDTO(maphong, tenPhong, trangThaiPhong, giaTien, soNguoi, NgayO);

                if (phongBll.SuaP(phong) == true)
                {
                    MessageBox.Show("Sửa thành công");
                    refreshdatagridview();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo!");
            }
        }

        private void btn_XoaP_Click(object sender, EventArgs e)
        {
           
            try
            {
                string maphong = txt_MaP.Text.Trim();


                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    if (phongBll.XoaP(maphong) == true)
                    {
                        MessageBox.Show("Xoá thành công");
                        refreshdatagridview();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo!");
            }
        }

        private void btn_LamMoip_Click(object sender, EventArgs e)
        {
         
            try
            {
                foreach (Control ctrl in guna2Panel1.Controls)
                {
                    if (ctrl is Guna2TextBox)
                    {
                        (ctrl as Guna2TextBox).Text = "";
                    }
                }

                refreshdatagridview();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo!");
            }
        }



        private void txt_TimKiemP_TextChanged(object sender, EventArgs e)
        {
           
            try
            {
                string keyword = txt_TimKiemP.Text.Trim();
                List<QLPhongDTO> results = phongBll.Search(keyword);
                dgv_QLP.DataSource = results;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo!");
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void dgv_QLP_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {

            // Lấy số thứ tự của hàng hiện tại
            string stt = (e.RowIndex + 1).ToString();

            // Hiển thị số thứ tự trong ô cột STT của hàng hiện tại
            dgv_QLP.Rows[e.RowIndex].Cells["STT"].Value = stt;

        }

        private void dgv_QLP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         
            try
            {
                int hang = e.RowIndex;
                // Display data in controls
                if (hang == -1) return;

                txt_MaP.Text = dgv_QLP[1, hang].Value.ToString();

                txt_TenP.Text = dgv_QLP[2, hang].Value.ToString();
                txt_TrangThaiP.Text = dgv_QLP[3, hang].Value.ToString();
                txt_GiaTienP.Text = dgv_QLP[4, hang].Value.ToString();
                txt_SoNguoiP.Text = dgv_QLP[5, hang].Value.ToString();
                txt_NgayOP.Text = dgv_QLP[6, hang].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo!");
            }
        }

        private void QL_Phòng_Load(object sender, EventArgs e)
        {
            refreshdatagridview();
        }

        private void txt_GiaTienP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Nếu ký tự nhập vào không phải là số và không phải là phím điều khiển
                // (ví dụ như phím xoá, phím backspace) thì hủy sự kiện
                e.Handled = true;
            }
        }

        private void txt_SoNguoiP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Nếu ký tự nhập vào không phải là số và không phải là phím điều khiển
                // (ví dụ như phím xoá, phím backspace) thì hủy sự kiện
                e.Handled = true;
            }
        }

        private void txt_NgayOP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Nếu ký tự nhập vào không phải là số và không phải là phím điều khiển
                // (ví dụ như phím xoá, phím backspace) thì hủy sự kiện
                e.Handled = true;
            }
        }

        private void txt_TrangThaiP_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Nếu ký tự được nhập không phải là chữ hoặc khoảng trắng thì hủy bỏ sự kiện KeyPress
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txt_TenP_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Nếu ký tự được nhập không phải là chữ hoặc khoảng trắng thì hủy bỏ sự kiện KeyPress
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

        }
    }
}

