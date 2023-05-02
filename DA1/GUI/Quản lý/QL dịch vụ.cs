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
using System.Windows.Documents;
using System.Windows.Forms;

namespace GUI.Quản_lý
{
    public partial class QL_dịch_vụ : Form
    {
        public QL_dịch_vụ()
        {
            InitializeComponent();
        }

        BLL_DichVu blldv = new BLL_DichVu();
        private DataTable phongs;
   
        private void refreshdatagridview() //giúp load lại trang dữ liệu
        {
            phongs = blldv.getDichVu();
            dgv_DichVu.DataSource = phongs;
            // Thay đổi độ rộng
            dgv_DichVu.Columns[0].Width = 30;
            dgv_DichVu.Columns[1].Width = 50;
            dgv_DichVu.Columns[2].Width = 200;
            dgv_DichVu.Columns[3].Width = 150;




            //thay đổi tiêu đề

            dgv_DichVu.Columns[1].HeaderText = "Mã DV";
            dgv_DichVu.Columns[2].HeaderText = "Tên dịch vụ";
            dgv_DichVu.Columns[3].HeaderText = "Giá tiền";

            dgv_DichVu.Columns["STT"].HeaderText = "STT";
            dgv_DichVu.RowPostPaint += dgv_DichVu_RowPostPaint;


        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            string tenDV = txt_TenDV.Text.Trim();

            decimal giatien = decimal.Parse(txt_GiaTien.Text.Trim());
            DTO_DichVu dv = new DTO_DichVu
            {
                TenDV = tenDV,
                GiaTien = giatien,
            };

       
        
                if (blldv.ThemDV(dv) == true)
                {
                    MessageBox.Show("Thêm thành công");
                    refreshdatagridview();

                }
            
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {

            string madv = txt_MaDV.Text.Trim();
            string tenDV = txt_TenDV.Text.Trim();

            decimal giaTien = decimal.Parse(txt_GiaTien.Text.Trim());


            DTO_DichVu dv = new DTO_DichVu(madv, tenDV, giaTien);

            if (blldv.SuaDV(dv) == true)
            {
                MessageBox.Show("Sửa thành công");
                refreshdatagridview();
            }
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
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

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string madv = txt_MaDV.Text.Trim();


            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                if (blldv.XoaDV(madv) == true)
                {
                    MessageBox.Show("Xoá thành công");
                    refreshdatagridview();
                }
            }
        }





        private void txt_TimKiem__TextChanged(object sender, EventArgs e)
        {
            string keyword = txt_TimKiem.Text.Trim();
            List<DTO_DichVu> results = blldv.TimKiem(keyword);
            dgv_DichVu.DataSource = results;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            // Dữ liệu được hiển thị lên bảng điền thông tin
            if (hang == -1) return;
            txt_MaDV.Text = dgv_DichVu[1, hang].Value.ToString();
            txt_TenDV.Text = dgv_DichVu[2, hang].Value.ToString();
            txt_GiaTien.Text = dgv_DichVu[3, hang].Value.ToString();
        }

        private void QL_dịch_vụ_Load(object sender, EventArgs e)
        {
            refreshdatagridview();
        }

        private void dgv_DichVu_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            // Lấy số thứ tự của hàng hiện tại
            string stt = (e.RowIndex + 1).ToString();

            // Hiển thị số thứ tự trong ô cột STT của hàng hiện tại
            dgv_DichVu.Rows[e.RowIndex].Cells["STT"].Value = stt;
        }

        private void txt_GiaTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Nếu ký tự nhập vào không phải là số và không phải là phím điều khiển
                // (ví dụ như phím xoá, phím backspace) thì hủy sự kiện
                e.Handled = true;
            }
        }

        private void txt_TenDV_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
