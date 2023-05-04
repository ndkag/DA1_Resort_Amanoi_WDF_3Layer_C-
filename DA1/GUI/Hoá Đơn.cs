using BLL;
using DTO;
using GUI.BC;
using GUI.Hoá_đơn;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace GUI.Chức_năng
{
    public partial class Hoá_Đơn : Form
    {
        BLL_HoaDon bllhd = new BLL_HoaDon();
        BLL_ChiTietDV bll_CTDV = new BLL_ChiTietDV();
        BLL_DichVu bllDichVu = new BLL_DichVu();
        BLL_DatPhong bllDP = new BLL_DatPhong();
        BLL_QLNV bllnv = new BLL_QLNV();

        public Hoá_Đơn()
        {
            InitializeComponent();
            // Load danh sách dịch vụ vào combobox
            cbb_MaDV.DataSource = bllDichVu.getDichVu();
            cbb_MaDV.DisplayMember = "MaDV";
            cbb_MaDV.ValueMember = "MaDV";

            cbb_MaNV.DataSource = bllnv.getQLNV();
            cbb_MaNV.DisplayMember = "TenNV";
            cbb_MaNV.ValueMember = "MaNV";
        }



        private void btn_Them_Click(object sender, EventArgs e)
        {

            try
            {
                string maDP = txt_MaDatPhong.Texts.Trim();
                string maDV = cbb_MaDV.SelectedValue.ToString();
                string tenDV = txt_TenDV.Text.Trim();
                decimal soLUong = decimal.Parse(txt_SoLuong.Texts.Trim());
                decimal TongTien = bll_CTDV.TinhTongTien(maDV, soLUong);

                DTO_ChiTietDV DP = new DTO_ChiTietDV(maDP, maDV, tenDV, soLUong, TongTien);

                if (bll_CTDV.kiemtramatrung(maDV, maDP) == 1)
                {
                    MessageBox.Show("Dịch vụ đã được sử dụng, vui lòng cập nhập lại dịch vụ " + tenDV + " để sử dụng tiếp hoặc chọn dịch vụ khác.");
                }
                else
                {
                    bll_CTDV.ThemChiTietDichVu(DP);
                    refreshdatagridview();
                    HienThiTongTienChiTietDichVu();


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
                cbb_MaDV.Enabled = true;
                txt_SoLuong.Texts = "";

                cbb_MaDV.Text = "";
                txt_TenDV.Text = "";
                txt_MaDatPhong.Texts = "";

                refreshdatagridview();
                HienThiTongTienChiTietDichVu();

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

                string madv = cbb_MaDV.SelectedValue.ToString();
                string madp = txt_MaDatPhong.Texts.Trim();

                if (string.IsNullOrEmpty(madv) || string.IsNullOrEmpty(madp))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                    return;
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dr == DialogResult.Yes)
                    {
                        if (bll_CTDV.Xoa(madv, madp) == true)
                        {
                            MessageBox.Show("Xoá thành công");

                            refreshdatagridview();
                            HienThiTongTienChiTietDichVu();

                        }
                    }

                }




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo!");
            }

        }


        private void refreshdatagridview()
        {

            string madp = txt_MaDPHD.Texts;

            dgvCTDV.DataSource = bllhd.getChiTietDV(madp);
            dgv_HoaDon.DataSource = bllhd.getQLHoaDon();

            dgvDatPhong.DataSource = bllhd.getDPHD(madp);


        }
        private void Hoá_Đơn_Load(object sender, EventArgs e)
        {
            HienThiTongTienChiTietDichVu();
            refreshdatagridview();


        }
        private void HienThiTongTienChiTietDichVu()
        {
            DataTable dt = bllhd.getChiTietDV(txt_MaDatPhong.Texts);
            DataTable hd = bllhd.getDPHD(txt_MaDatPhong.Texts);

            decimal giatien = bllDP.TinhTongDatPhong(hd);
            decimal tongTien = bllhd.TinhTongTienChiTietDichVu(dt);
            decimal TTHD = tongTien + giatien;
            txt_TongTienCTDV.Texts = TTHD.ToString();
        }





        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                string maDP = txt_MaDatPhong.Texts.Trim();
                string maDV = cbb_MaDV.SelectedValue.ToString();
                string tendv = txt_TenDV.Text.Trim();

                decimal soLUong = decimal.Parse(txt_SoLuong.Texts.Trim());
                decimal TongTien = bll_CTDV.TinhTongTien(maDV, soLUong);

                DTO_ChiTietDV DP = new DTO_ChiTietDV(maDP, maDV, tendv, soLUong, TongTien);
                if (bll_CTDV.SuaCTDV(DP) == true)
                {
                    MessageBox.Show("Sửa thành công");
                    refreshdatagridview();
                    HienThiTongTienChiTietDichVu();
                }
                else
                {
                    MessageBox.Show("Vui lòng điền thông tin muốn sửa");

                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo!");
            }

        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {




            try
            {

                string maDP = txt_MaDPHD.Texts.Trim();
                string makh = txt_MaKH.Texts.Trim();
                string maNV = cbb_MaNV.SelectedValue.ToString();
                string ghichu = txt_GhiChu.Texts.Trim();

                DateTime ngaytao = DateTime.Now;
                decimal tongtien = decimal.Parse(txt_TongTienCTDV.Texts.Trim());
                DTO_HoaDon DP = new DTO_HoaDon
                {
                    MaKH = makh,
                    MaNV = maNV,
                    MaDatPhong = maDP,
                    TongTien = tongtien,
                    NgayThanhToan = ngaytao,
                    GhiChu = ghichu
                };

                bllhd.ThemHoaDon(DP);

                XuatHoaDon xhd = new XuatHoaDon();
                xhd.txt_MaDatPhong.Text = txt_MaDatPhong.Texts.Trim();
                xhd.txt_MaPhong.Text = txt_MaPhong.Texts.Trim();
                xhd.ShowDialog();
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo!");
            }

        }

        private void txt_MaDPHD__TextChanged(object sender, EventArgs e)
        {


            try
            {
                // Gọi hàm lấy thông tin khách hàng từ DAL
                string maDP = txt_MaDPHD.Texts.Trim();
                DTO_DatPhong DP = bllhd.LayMaKHTuMaDP(maDP);

                // Nếu mã đặt phòng không tồn tại, hiển thị thông báo cho người dùng
                if (DP == null)
                {

                    return;
                }
                // Gán các giá trị khác tương tự

                txt_MaKH.Texts = DP.MaKH;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo!");
            }
        }



        private void checkbox_chinhsuahd_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
            if (checkbox_chinhsuahd.Checked)
            {

                txt_MaKH.Visible = true;
                dtp_NgayThanhToan.Visible = true;
                btn_SuaHD.Visible = true;
                btn_XoaHD.Visible = true;
                btn_LamMoiHD.Visible = true;
                label7.Visible = true;
                label8.Visible = true;


            }
            else
            {
                // nếu checkbox không được chọn thì trả lại vị trí ban đầu của textbox và label


                txt_MaKH.Visible = false;
                dtp_NgayThanhToan.Visible = false;
                btn_SuaHD.Visible = false;
                btn_XoaHD.Visible = false;
                btn_LamMoiHD.Visible = false;
                label7.Visible = false;
                label8.Visible = false;



            }

        }


        private void btn_LamMoiHD_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in panel3.Controls)
            {
                if (ctrl is Guna2TextBox)
                {
                    (ctrl as Guna2TextBox).Text = "";
                }

                else if (ctrl is RJTextBox)
                {
                    (ctrl as RJTextBox).Texts = "";
                }
                else if (ctrl is ComboBox)
                {
                    (ctrl as ComboBox).Text = "";
                }


                if (ctrl is Guna2DateTimePicker)
                {
                    (ctrl as Guna2DateTimePicker).Value = DateTime.Now;
                }


            }
            txt_TongTienCTDV.Texts = "";
            refreshdatagridview();
        }

        private void btn_SuaHD_Click(object sender, EventArgs e)
        {
            try
            {
                string maHD = txt_MaHD.Text.Trim();
                string maDP = txt_MaDPHD.Texts.Trim();
                string makh = txt_MaKH.Texts.Trim();
                string maNV = cbb_MaNV.SelectedValue.ToString();
                string ghichu = txt_GhiChu.Texts.Trim();

                DateTime ngaytao = DateTime.Parse(dtp_NgayThanhToan.Value.ToShortDateString());
                decimal tongtien = decimal.Parse(txt_TongTienCTDV.Texts.Trim());
                DTO_HoaDon DP = new DTO_HoaDon(maHD, makh, maNV, maDP, tongtien, ngaytao, ghichu);
                if (!decimal.TryParse(txt_TongTienCTDV.Text.Trim(), out tongtien))
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng số cho Tổng tiền.");
                    return;
                }

                if (string.IsNullOrEmpty(maHD) || string.IsNullOrEmpty(maDP) || string.IsNullOrEmpty(makh) || string.IsNullOrEmpty(maNV))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                    return;
                }
                else
                {
                    bllhd.SuaDH(DP);
                    MessageBox.Show("Sửa thành công");
                    refreshdatagridview();

                }





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo!");
            }

        }
        private void btn_XoaHD_Click(object sender, EventArgs e)
        {

            try
            {
                string mahd = txt_MaHD.Text.Trim();

                if (string.IsNullOrEmpty(mahd))
                {
                    MessageBox.Show("Vui lòng chọn thông tin muốn xoá");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dr == DialogResult.Yes)
                    {
                        if (bllhd.XoaHoaDon(mahd) == true)
                        {
                            MessageBox.Show("Xoá thành công");
                            refreshdatagridview();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo!");
            }


        }

        private void dgv_HoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            try
            {
                int hang = e.RowIndex;
                // Dữ liệu được hiển thị lên bảng điền thông tin
                if (hang == -1) return;
                txt_MaHD.Text = dgv_HoaDon[0, hang].Value.ToString();
                txt_MaKH.Texts = dgv_HoaDon[1, hang].Value.ToString();
                cbb_MaNV.Text = dgv_HoaDon[2, hang].Value.ToString();
                txt_MaDPHD.Texts = dgv_HoaDon[3, hang].Value.ToString();
                txt_MaDatPhong.Texts = dgv_HoaDon[3, hang].Value.ToString();

                txt_TongTienCTDV.Texts = dgv_HoaDon[4, hang].Value.ToString();
                dtp_NgayThanhToan.Text = dgv_HoaDon[5, hang].Value.ToString();
                txt_GhiChu.Texts = dgv_HoaDon[6, hang].Value.ToString();

                string madp = txt_MaDPHD.Texts;

                dgvCTDV.DataSource = bllhd.getChiTietDV(madp);

                dgvDatPhong.DataSource = bllhd.getDPHD(madp);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo!");
            }
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txt_TimKiem.Text.Trim();
            List<DTO_HoaDon> results = bllhd.TimKiem(keyword);
            dgv_HoaDon.DataSource = results;
        }

        private void cbb_MaDV_SelectedIndexChanged(object sender, EventArgs e)
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

        private void dgvCTDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                int hang = e.RowIndex;
                // Display data in controls
                if (hang == -1) return;

                txt_MaPhong.Texts = dgvCTDV[0, hang].Value.ToString();
                cbb_MaDV.Text = dgvCTDV[1, hang].Value.ToString();
                txt_TenDV.Text = dgvCTDV[2, hang].Value.ToString();
                txt_SoLuong.Texts = dgvCTDV[3, hang].Value.ToString();
                txt_MaPhong.Enabled = false;
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
    }
}
