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
    public partial class QL_Đặt_Phòng : Form
    {
        public QL_Đặt_Phòng()
        {
            InitializeComponent();
            phongBLL = new QLPhongBLL();

            // Đổ dữ liệu MaKH vào comboBox
            DataTable dtKhachHang = new BLL_QLKhachHang().getQLKhachHang();
            cbb_MaKH.DataSource = dtKhachHang;
            cbb_MaKH.DisplayMember = "TenKH";
            cbb_MaKH.ValueMember = "MaKH";

        }


        BLL_DatPhong blldp = new BLL_DatPhong();
        DTO_DatPhong dtoDP = new DTO_DatPhong();
        BLL_HoaDon bllhd = new BLL_HoaDon();
        private readonly QLPhongBLL phongBLL;

        private void refreshdatagridview() //giúp load lại trang dữ liệu
        {
            dgv_DatPhong.DataSource = blldp.getDatPhong();
        }
        //đổ dữ liệu vào combobox Phòng
        private void LoadPhong()
        {
            List<QLPhongDTO> listPhongTrong = blldp.LayDanhSachPhongTrong();

            cbb_MaP.DataSource = listPhongTrong;
            cbb_MaP.DisplayMember = "MaPhong";
            cbb_MaP.ValueMember = "MaPhong";

         


            dgv_DatPhong.Columns["STT"].HeaderText = "STT";

            //Đánh số thứ tự
            dgv_DatPhong.RowPostPaint += dgv_DatPhong_RowPostPaint;
        }
        private void btn_DatP_Click(object sender, EventArgs e)
        {

            string maKH = cbb_MaKH.SelectedValue.ToString();
            string maPhong = cbb_MaP.SelectedValue.ToString();

            DateTime ngayDen = DateTime.Now;
            DateTime ngayDi = DateTime.Parse(dtp_NgayDi.Value.ToShortDateString());
            string ghiChu = txt_GhiChu.Text.Trim();

            DTO_DatPhong DP = new DTO_DatPhong
            {
                MaKH = maKH,
                MaPhong = maPhong,
                NgayDen = ngayDen,
                NgayDi = ngayDi,
                GhiChu = ghiChu
            };
            if (ngayDen >= ngayDi)
            {
                MessageBox.Show("Ngày đi phải lớn hơn ngày đến");
            }
            else if (blldp.ThemDP(DP) == true)
            {
                refreshdatagridview();
                LoadPhong();
            }




        }

        private void Đặt_phòng_Load(object sender, EventArgs e)
        {
            refreshdatagridview();
            LoadPhong();

            dgv_DatPhong.Columns[0].Width = 50;
            dgv_DatPhong.Columns[1].Width = 90;
            dgv_DatPhong.Columns[2].Width = 90;
            dgv_DatPhong.Columns[3].Width = 100;
            dgv_DatPhong.Columns[4].Width = 110;
            dgv_DatPhong.Columns[5].Width = 110;

            foreach (Control ctrl in pl_Nhap.Controls)
            {
               
                if (ctrl is Guna2DateTimePicker)
                {
                    (ctrl as Guna2DateTimePicker).Value = DateTime.Now;
                }
            }

        }


        private void btn_Sua_Click(object sender, EventArgs e)
        {

            string maDP = txt_MaDP.Text.Trim();
            string maKH = cbb_MaKH.SelectedValue.ToString();
            string maPhong = cbb_MaP.SelectedValue.ToString();
            string maphongcu = txt_MaPhongCu.Text;
            DateTime ngayDen = DateTime.Parse(dtp_NgayDat.Value.ToShortDateString());
            DateTime ngayDi = DateTime.Parse(dtp_NgayDi.Value.ToShortDateString());
            string ghiChu = txt_GhiChu.Text.Trim();
            DTO_DatPhong DP = new DTO_DatPhong(maDP, maKH, maPhong, ngayDen, ngayDi, ghiChu);
            if (blldp.SuaDP(DP) == true)
            {
                bllhd.CapNhatTrangThaiPhong(maphongcu, "Trống");
                MessageBox.Show("Sửa thành công");
                refreshdatagridview();
                LoadPhong();

            }

        }

        private void dgv_DatPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            // Display data in controls
            if (hang == -1) return;

            txt_MaDP.Text = dgv_DatPhong[1, hang].Value.ToString();

            cbb_MaKH.Text = dgv_DatPhong[2, hang].Value.ToString();
            cbb_MaP.Text = dgv_DatPhong[3, hang].Value.ToString();
            txt_MaPhongCu.Text = dgv_DatPhong[3, hang].Value.ToString();
            dtp_NgayDat.Text = dgv_DatPhong[4, hang].Value.ToString();
            dtp_NgayDi.Text = dgv_DatPhong[5, hang].Value.ToString();
            txt_GhiChu.Text = dgv_DatPhong[6, hang].Value.ToString();


            txt_MaDP.Enabled = false;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {

            try
            {

                string mp = cbb_MaP.Text;
                string maDP = txt_MaDP.Text.Trim();

                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    if (blldp.XoaDatPhong(maDP) == true)
                    {
                        bllhd.CapNhatTrangThaiPhong(mp, "Trống");
                        MessageBox.Show("Xoá đặt phòng thành công");
                        refreshdatagridview();
                        LoadPhong();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông tin không thể xoá vì hoá đơn vẫn có hiệu lực.");
            }

        }





        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in pl_Nhap.Controls)
            {
                if (ctrl is Guna2TextBox)
                {
                    (ctrl as Guna2TextBox).Text ="";
                }
                if (ctrl is ComboBox)
                {
                    (ctrl as ComboBox).Text ="";
                }
                if (ctrl is Guna2DateTimePicker)
                {
                    (ctrl as Guna2DateTimePicker).Value = DateTime.Now;
                }
            }


            refreshdatagridview();
        }


        private void dgv_DatPhong_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            // Lấy số thứ tự của hàng hiện tại
            string stt = (e.RowIndex + 1).ToString();

            // Hiển thị số thứ tự trong ô cột STT của hàng hiện tại
            dgv_DatPhong.Rows[e.RowIndex].Cells["STT"].Value = stt;
        }
    }
}
