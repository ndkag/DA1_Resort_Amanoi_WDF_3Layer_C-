using BLL;
using BLL.Thống_kê;
using DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace GUI
{
    public partial class Chi_tiết_đặt_phòng : Form
    {
        BLL_HoaDon bllhd = new BLL_HoaDon();
        BLL_ChiTietDV bll_CTDV = new BLL_ChiTietDV();
        BLL_DichVu bllDichVu = new BLL_DichVu();
        BLL_DatPhong bllDP = new BLL_DatPhong();
        BLL_QLNV bllnv = new BLL_QLNV();

        public Chi_tiết_đặt_phòng()
        {
            InitializeComponent();
            // Load danh sách dịch vụ vào combobox
            cbb_MaDV.DataSource = bllDichVu.getDichVu();
            cbb_MaDV.DisplayMember = "TenDV";
            cbb_MaDV.ValueMember = "MaDV";
        }

        BLL_XuatHD dal = new BLL_XuatHD();
        private void HienThiTongTienChiTietDichVu()
        {
            DataTable dt = bllhd.getChiTietDV(txt_MaDatPhong.Texts);
            DataTable hd = bllhd.getDPHD(txt_MaDatPhong.Texts);

            decimal giatien = bllDP.TinhTongDatPhong(hd);
            decimal tongTien = bllhd.TinhTongTienChiTietDichVu(dt);
            decimal TTHD = tongTien + giatien;
            txt_TongTienCTDV.Texts = TTHD.ToString();
        }

        private void refreshdatagridview()
        {
            string madp = txt_MaDatPhong.Texts;
            dgvCTDV.DataSource = bllhd.getChiTietDV(madp);
            dgvDatPhong.DataSource = bllhd.getDPHD(madp);


        }
        private void btn_Them_Click(object sender, EventArgs e)
        {

            try
            {
                string maDP = txt_MaDatPhong.Texts.Trim();
                string maDV = cbb_MaDV.SelectedValue.ToString();
                string tenDV = txt_TenDV.Text.Trim();
                if (string.IsNullOrEmpty(maDP) || string.IsNullOrEmpty(maDV) || string.IsNullOrEmpty(tenDV) || string.IsNullOrEmpty(txt_SoLuong.Texts))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin chi tiết dịch vụ!");
                    return;
                }
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

                    MessageBox.Show("Thêm dịch vụ " + tenDV + " thành công");

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
                string maDP = txt_MaDatPhong.Texts.Trim();
                string maDV = cbb_MaDV.SelectedValue.ToString();
                string tendv = txt_TenDV.Text.Trim();

                decimal soLUong = decimal.Parse(txt_SoLuong.Texts.Trim());
                decimal TongTien = bll_CTDV.TinhTongTien(maDV, soLUong);

                DTO_ChiTietDV DP = new DTO_ChiTietDV(maDP, maDV, tendv, soLUong, TongTien);
                if (bll_CTDV.SuaCTDV(DP) == true)
                {
                    MessageBox.Show("Sửa chi đặt phòng có mã " + maDP + " thành công");
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

        private void btn_Xoa_Click_1(object sender, EventArgs e)
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
                            MessageBox.Show("Xoá dịch vụ " + madv + " trong chi tiết đặt phòng có mã " + madp + " thành công");

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

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {


            try
            {
                cbb_MaDV.Enabled = true;
                txt_SoLuong.Texts = "";

                cbb_MaDV.Text = "";
                txt_TenDV.Text = "";

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

        private void Chi_tiết_đặt_phòng_Load(object sender, EventArgs e)
        {
            HienThiTongTienChiTietDichVu();
            refreshdatagridview();
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            Hoá_đơn hd = new Hoá_đơn();
            hd.txt_MaDPHD.Texts = txt_MaDatPhong.Texts;
            hd.txt_MaPhong.Texts = txt_MaPhong.Texts;
            Trang_Chủ.Instance.openChildFormInPanel(hd);

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

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
