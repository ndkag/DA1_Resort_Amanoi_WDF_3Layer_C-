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
using System.Windows.Documents;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GUI.Quản_lý
{
    public partial class QL_CTDV : Form
    {
        BLL_DatPhong bll_DP = new BLL_DatPhong();
        BLL_DichVu bll_dv = new BLL_DichVu();
        public QL_CTDV()
        {
            InitializeComponent();

            DataTable listPhongTrong = bll_DP.getDatPhong();

            cbb_MaDatPhong.DataSource = listPhongTrong;
            cbb_MaDatPhong.DisplayMember = "Mã ĐP";
            cbb_MaDatPhong.ValueMember = "Mã ĐP";
            DataTable dsdv = bll_dv.getDichVu();

            cbb_MaDV.DataSource = dsdv;
            cbb_MaDV.DisplayMember = "TenDV";
            cbb_MaDV.ValueMember = "MaDV";
            //thay đổi tiêu đề
            dgv_CTDV.Columns["STT"].HeaderText = "STT";

            //Đánh số thứ tự
            dgv_CTDV.RowPostPaint += dgv_CTDV_RowPostPaint;
        }
   
        BLL_ChiTietDV bll_CTDV = new BLL_ChiTietDV();
        private void txt_TimKiem__TextChanged(object sender, EventArgs e)
        {
          
            try
            {
                string keyword = txt_TimKiem.Text.Trim();
                List<DTO_ChiTietDV> results = bll_CTDV.TimKiem(keyword);
                dgv_CTDV.DataSource = results;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo!");
            }
        }

        private void cbb_MaDV_SelectedIndexChanged(object sender, EventArgs e)
        {
       

            try
            {
                // Gọi hàm lấy thông tin khách hàng từ DAL
                string madv = cbb_MaDV.SelectedValue.ToString();
                DTO_DichVu DP = bll_CTDV.LayMaTuMaDV(madv);

                // Nếu mã đặt phòng không tồn tại, hiển thị thông báo cho người dùng
                if (DP == null)
                {
                    return;
                }
                // Gán các giá trị khác tương tự

                txt_TenDV.Text = DP.TenDV;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo!");
            }
        }

        private void btn_DatP_Click(object sender, EventArgs e)
        {

           

            try
            {
                string maDP = cbb_MaDatPhong.SelectedValue.ToString();
                string maDV = cbb_MaDV.SelectedValue.ToString();
                string tenDV = txt_TenDV.Text.Trim();
                decimal soLUong;
                if (!decimal.TryParse(txt_SoLuong.Text.Trim(), out soLUong))
                {
                    MessageBox.Show("Vui lòng nhập số lượng hợp lệ!");
                    return;
                }
                decimal TongTien = bll_CTDV.TinhTongTien(maDV, soLUong);

                if (string.IsNullOrEmpty(maDP) || string.IsNullOrEmpty(maDV) || string.IsNullOrEmpty(tenDV))
                {
                    MessageBox.Show("Vui lòng nhập thông tin!");
                    return;
                }
                DTO_ChiTietDV DP = new DTO_ChiTietDV(maDP, maDV, tenDV, soLUong, TongTien);

                if (bll_CTDV.kiemtramatrung(maDV, maDP) == 1)
                {
                    MessageBox.Show("Mã trùng");
                }
                else
                {
                    bll_CTDV.ThemChiTietDichVu(DP);
                    refreshdatagridview();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo!");
            }
        }

        private void QL_CTDV_Load(object sender, EventArgs e)
        {
            refreshdatagridview();
            dgv_CTDV.Columns[0].Width = 50;
            dgv_CTDV.Columns[1].Width = 90;
            dgv_CTDV.Columns[2].Width = 90;
            dgv_CTDV.Columns[3].Width = 250;
            dgv_CTDV.Columns[4].Width = 90;

        }
        private void refreshdatagridview() //giúp load lại trang dữ liệu
        {
            dgv_CTDV.DataSource = bll_CTDV.getChiTietDV();

        }

        private void dgv_CTDV_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            // Lấy số thứ tự của hàng hiện tại
            string stt = (e.RowIndex + 1).ToString();

            // Hiển thị số thứ tự trong ô cột STT của hàng hiện tại
            dgv_CTDV.Rows[e.RowIndex].Cells["STT"].Value = stt;
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                string maDP = cbb_MaDatPhong.SelectedValue.ToString();
                string maDV = cbb_MaDV.SelectedValue.ToString();
                string tendv = txt_TenDV.Text.Trim();

                decimal soLUong = decimal.Parse(txt_SoLuong.Text.Trim());
                decimal TongTien = bll_CTDV.TinhTongTien(maDV, soLUong);

                DTO_ChiTietDV DP = new DTO_ChiTietDV(maDP, maDV, tendv, soLUong, TongTien);
                if (bll_CTDV.SuaCTDV(DP) == true)
                {
                    MessageBox.Show("Sửa thành công");
                    refreshdatagridview();
                }
                else
                {
                    MessageBox.Show("Sửa không thành công vui lòng kiểm tra lại.");

                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
           
            try
            {
                string madv = cbb_MaDV.SelectedValue.ToString();
                string madp = cbb_MaDatPhong.SelectedValue.ToString();


                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    if (bll_CTDV.Xoa(madv, madp) == true)
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

        private void dgv_CTDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         
            try
            {
                int hang = e.RowIndex;
                // Display data in controls
                if (hang == -1) return;
                cbb_MaDatPhong.Text = dgv_CTDV[1, hang].Value.ToString();
                cbb_MaDV.Text = dgv_CTDV[2, hang].Value.ToString();
                txt_TenDV.Text = dgv_CTDV[3, hang].Value.ToString();
                txt_SoLuong.Text = dgv_CTDV[4, hang].Value.ToString();
                cbb_MaDatPhong.Enabled = false;
                cbb_MaDV.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo!");
            }

        }

        private void txt_SoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Nếu ký tự nhập vào không phải là số và không phải là phím điều khiển
                // (ví dụ như phím xoá, phím backspace) thì hủy sự kiện
                e.Handled = true;
            }
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            

            try
            {
                cbb_MaDV.Enabled = true;
                cbb_MaDatPhong.Enabled = true;
                txt_SoLuong.Text = "";
                txt_TenDV.Text = "";
                refreshdatagridview();
                foreach (Control ctrl in pl_Nhap.Controls)
                {
                    if (ctrl is Guna2TextBox)
                    {
                        (ctrl as Guna2TextBox).Text = "";
                    }
                    if (ctrl is ComboBox)
                    {
                        (ctrl as ComboBox).Text = "";
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo!");
            }
        }
    }
}
