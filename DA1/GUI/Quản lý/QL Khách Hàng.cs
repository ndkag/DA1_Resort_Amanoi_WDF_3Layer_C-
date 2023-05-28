using BLL;
using DTO;
using GUI.BC;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace GUI.Quản_lý
{
    public partial class QL_Khách_Hàng : Form
    {
        BLL_QLKhachHang qlkh = new BLL_QLKhachHang();
        private DataTable phongs;

        private void refreshdatagridview() //giúp load lại trang dữ liệu
        {
            phongs = qlkh.getQLKhachHang();
            dgv_QLKH.DataSource = phongs;
            // Thay đổi độ rộng


            dgv_QLKH.Columns[0].Width = 30;
            dgv_QLKH.Columns[1].Width = 70;
            dgv_QLKH.Columns[2].Width = 130;
            dgv_QLKH.Columns[3].Width = 100;
            dgv_QLKH.Columns[4].Width = 100;
            dgv_QLKH.Columns[5].Width = 110;



            //thay đổi tiêu đề

            dgv_QLKH.Columns[1].HeaderText = "Mã KH";
            dgv_QLKH.Columns[2].HeaderText = "Tên KH";
            dgv_QLKH.Columns[3].HeaderText = "Quê";
            dgv_QLKH.Columns[4].HeaderText = "SĐT";
            dgv_QLKH.Columns[5].HeaderText = "Ngày tạo";

            dgv_QLKH.Columns["STT"].HeaderText = "STT";

            //Đánh số thứ tự
            dgv_QLKH.RowPostPaint += dgv_QLKH_RowPostPaint;


        }
        public QL_Khách_Hàng()
        {
            InitializeComponent();
        }

        private void QL_Khách_Hàng_Load(object sender, EventArgs e)
        {
            refreshdatagridview();
            foreach (Control ctrl in guna2Panel1.Controls)
            {

                if (ctrl is Guna2DateTimePicker)
                {
                    (ctrl as Guna2DateTimePicker).Value = DateTime.Now;
                }
            }

        }
        private void btn_Thêm_Click(object sender, EventArgs e)
        {


            try
            {
                string tenkh = txt_TenKH.Text.Trim();
                string diachi = txt_DiaChi.Text.Trim();
                string sdt = txt_SDT.Text.Trim();
                DateTime ngaytao = DateTime.Now;

                if (string.IsNullOrEmpty(tenkh) || string.IsNullOrEmpty(diachi) || string.IsNullOrEmpty(sdt))
                {
                    MessageBox.Show("Vui lòng nhập thông tin!");
                    return;
                }
                DTO_QLKhachHang KH = new DTO_QLKhachHang
                {
                    TenKH = tenkh,
                    DiaChi = diachi,
                    SoDienThoai = sdt,
                    NgayTao = ngaytao,
                };
                if (qlkh.ThemKH(KH) == true)
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
                string makh = txt_MaKH.Text.Trim();
                string tenkh = txt_TenKH.Text.Trim();
                string diachi = txt_DiaChi.Text.Trim();
                string sdt = txt_SDT.Text.Trim();
                DateTime ngaytao = DateTime.Parse(dtp_NgayTao.Value.ToShortDateString());
                DTO_QLKhachHang NV = new DTO_QLKhachHang(makh, tenkh, diachi, sdt, ngaytao);
                if (qlkh.SuaKH(NV) == true)
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
                    else if (ctrl is Guna2DateTimePicker)
                    {
                        (ctrl as Guna2DateTimePicker).Text = "";
                    }

                    if (ctrl is Guna2DateTimePicker)
                    {
                        (ctrl as Guna2DateTimePicker).Value = DateTime.Now;
                    }

                }


                refreshdatagridview();

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
                string makh = txt_MaKH.Text.Trim();


                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    if (qlkh.XoaKH(makh) == true)
                    {
                        MessageBox.Show("Xoá thành công");
                        foreach (Control ctrl in panel3.Controls)
                        {
                            if (ctrl is RJTextBox)
                            {
                                (ctrl as RJTextBox).Texts = "";
                            }
                        }
                        txt_MaKH.Enabled = true;
                        refreshdatagridview();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo!");
            }
        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            try
            {
                int hang = e.RowIndex;
                // Display data in controls
                if (hang == -1) return;

                txt_MaKH.Text = dgv_QLKH[1, hang].Value.ToString();
                txt_TenKH.Text = dgv_QLKH[2, hang].Value.ToString();
                txt_DiaChi.Text = dgv_QLKH[3, hang].Value.ToString();
                txt_SDT.Text = dgv_QLKH[4, hang].Value.ToString();
                dtp_NgayTao.Text = dgv_QLKH[5, hang].Value.ToString();


                txt_MaKH.Enabled = false;

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
                List<DTO_QLKhachHang> results = qlkh.TimKiems(keyword);
                dgv_QLKH.DataSource = results;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo!");
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

        private void dgv_QLKH_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            // Lấy số thứ tự của hàng hiện tại
            string stt = (e.RowIndex + 1).ToString();

            // Hiển thị số thứ tự trong ô cột STT của hàng hiện tại
            dgv_QLKH.Rows[e.RowIndex].Cells["STT"].Value = stt;
        }

        private void txt_TenKH_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
