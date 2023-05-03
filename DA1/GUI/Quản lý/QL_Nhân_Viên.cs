using BLL;
using DTO;
using GUI.BC;
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
    public partial class QL_Nhân_Viên : Form
    {
        public QL_Nhân_Viên()
        {
            InitializeComponent();
        }

        BLL_QLNV nvBLL = new BLL_QLNV();
        private DataTable phongs;



        private void QL_Nhân_Viên_Load(object sender, EventArgs e)
        {
            refreshdatagridview();

            dgv_QLNV.Columns[0].Width = 30;
            dgv_QLNV.Columns[1].Width = 50;
            dgv_QLNV.Columns[2].Width = 110;
            dgv_QLNV.Columns[3].Width = 80;
            dgv_QLNV.Columns[4].Width = 80;
            dgv_QLNV.Columns[5].Width = 80;
            dgv_QLNV.Columns[6].Width = 90;




            //thay đổi tiêu đề

            dgv_QLNV.Columns[1].HeaderText = "Mã NV";
            dgv_QLNV.Columns[2].HeaderText = "Tên NV";
            dgv_QLNV.Columns[3].HeaderText = "Quê";
            dgv_QLNV.Columns[4].HeaderText = "SĐT";
            dgv_QLNV.Columns[5].HeaderText = "Vị trí";
            dgv_QLNV.Columns[6].HeaderText = "Lương";


            dgv_QLNV.Columns["STT"].HeaderText = "STT";

            //Đánh số thứ tự
            dgv_QLNV.RowPostPaint += dgv_QLNV_RowPostPaint;
        }

        private void refreshdatagridview() //giúp load lại trang dữ liệu
        {
            phongs = nvBLL.getQLNV();
            dgv_QLNV.DataSource = phongs;
        }
        private void btn_Thêm_Click(object sender, EventArgs e)
        {
            try
            {
                string tenNV = txt_TenNV.Text.Trim();
                string diachi = txt_DiaChi.Text.Trim();
                string sdt = txt_SDT.Text.Trim();
                string vitri = txt_ViTri.Text.Trim();
                decimal luong;
                if (!decimal.TryParse(txt_Luong.Text.Trim(), out luong))
                {
                    MessageBox.Show("Vui lòng nhập lương!");
                    return;
                }
                if (string.IsNullOrEmpty(tenNV) || string.IsNullOrEmpty(diachi) || string.IsNullOrEmpty(sdt) || string.IsNullOrEmpty(vitri))
                {
                    MessageBox.Show("Vui lòng nhập thông tin!");
                    return;
                }
                DTO_QLNV NV = new DTO_QLNV
                {
                    TenNV = tenNV,
                    DiaChi = diachi,
                    SoDienThoai = sdt,
                    ViTri = vitri,
                    Luong = luong,
                };


                if (nvBLL.ThemNV(NV) == true)
                {
                    MessageBox.Show("Thêm thành công");
                    refreshdatagridview();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo!");
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
         

            try
            {
                string manv = txt_MaNV.Text.Trim();
                string tenNV = txt_TenNV.Text.Trim();
                string diachi = txt_DiaChi.Text.Trim();
                string sdt = txt_SDT.Text.Trim();
                string vitri = txt_ViTri.Text.Trim();
                decimal luong = decimal.Parse(txt_Luong.Text.Trim());
                DTO_QLNV NV = new DTO_QLNV(manv, tenNV, diachi, sdt, vitri, luong);
                if (nvBLL.SuaNV(NV) == true)
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

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
           


            try
            {
                string manv = txt_MaNV.Text.Trim();


                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    if (nvBLL.XoaNV(manv) == true)
                    {
                        MessageBox.Show("Xoá thành công");
                        foreach (Control ctrl in guna2Panel1.Controls)
                        {
                            if (ctrl is Guna2TextBox)
                            {
                                (ctrl as Guna2TextBox).Text = "";
                            }
                        }
                        refreshdatagridview();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo!");
            }
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
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


        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
        
            try
            {

                string keyword = txt_TimKiem.Text.Trim();
                List<DTO_QLNV> results = nvBLL.TimKiem(keyword);
                dgv_QLNV.DataSource = results;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo!");
            }
        }

        private void dgv_QLNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            


            try
            {
                int hang = e.RowIndex;
                // Display data in controls
                if (hang == -1) return;

                txt_MaNV.Text = dgv_QLNV[1, hang].Value.ToString();
                txt_TenNV.Text = dgv_QLNV[2, hang].Value.ToString();
                txt_DiaChi.Text = dgv_QLNV[3, hang].Value.ToString();
                txt_SDT.Text = dgv_QLNV[4, hang].Value.ToString();
                txt_ViTri.Text = dgv_QLNV[5, hang].Value.ToString();
                txt_Luong.Text = dgv_QLNV[6, hang].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo!");
            }
        }

        private void dgv_QLNV_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
          

            try
            {
                // Lấy số thứ tự của hàng hiện tại
                string stt = (e.RowIndex + 1).ToString();

                // Hiển thị số thứ tự trong ô cột STT của hàng hiện tại
                dgv_QLNV.Rows[e.RowIndex].Cells["STT"].Value = stt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo!");
            }
        }

        private void txt_Luong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Nếu ký tự nhập vào không phải là số và không phải là phím điều khiển
                // (ví dụ như phím xoá, phím backspace) thì hủy sự kiện
                e.Handled = true;
            }

        }

        private void txt_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            // kiểm tra xem ký tự được nhập vào có phải là số hay không
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                // không cho phép người dùng nhập ký tự khác số và không phải phím backspace
                e.Handled = true;
            }
            // kiểm tra độ dài của textbox
            if (txt_SDT.TextLength >= 10 && e.KeyChar != '\b')
            {
                // không cho phép người dùng nhập thêm ký tự
                e.Handled = true;
            }
        }

        private void txt_TenNV_KeyPress(object sender, KeyPressEventArgs e)
        {
          
                // Nếu ký tự được nhập không phải là chữ hoặc khoảng trắng thì hủy bỏ sự kiện KeyPress
                if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar))
                {
                    e.Handled = true;
                }

            
        }

        private void txt_DiaChi_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Nếu ký tự được nhập không phải là chữ hoặc khoảng trắng thì hủy bỏ sự kiện KeyPress
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txt_ViTri_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Nếu ký tự được nhập không phải là chữ hoặc khoảng trắng thì hủy bỏ sự kiện KeyPress
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

        }
    }
}
