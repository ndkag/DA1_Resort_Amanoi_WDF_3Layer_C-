using BLL;
using BLL.Thống_kê;
using DTO;
using GUI.Báo_cáo_thống_kê;
using System;
using System.Data;
using System.Windows.Forms;

namespace GUI
{
    public partial class Hoá_đơn : Form
    {
        public Hoá_đơn()
        {
            InitializeComponent();
            cbb_MaNV.DataSource = bllnv.getQLNV();
            cbb_MaNV.DisplayMember = "TenNV";
            cbb_MaNV.ValueMember = "MaNV";
        }
        BLL_HoaDon bllhd = new BLL_HoaDon();
        BLL_ChiTietDV bll_CTDV = new BLL_ChiTietDV();
        BLL_DichVu bllDichVu = new BLL_DichVu();
        BLL_DatPhong bllDP = new BLL_DatPhong();
        BLL_QLNV bllnv = new BLL_QLNV();


        BLL_XuatHD dal = new BLL_XuatHD();
        private void Hoá_đơn_Load(object sender, EventArgs e)
        {
            HienThiTongTienChiTietDichVu();
            refreshdatagridview();
        }
        private void XuatHD(string maDatPhong)
        {


            if (string.IsNullOrEmpty(maDatPhong))
            {
                MessageBox.Show("Vui lòng nhập mã đặt phòng để in hóa đơn.");
                return;
            }

            DataTable dtHoaDon = dal.GetHoaDon(maDatPhong);
            DataTable dtChiTietDV = dal.GetChiTietDichVu(maDatPhong);

            if (dtHoaDon.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy hóa đơn nào cho mã đặt phòng này.");
                return;
            }

            //khởi tạo đối tượng report
            CR_XuatHD rpt = new CR_XuatHD();
            //thêm dữ liệu vào report
            rpt.SetDataSource(dtHoaDon);
            rpt.Subreports[0].SetDataSource(dtChiTietDV);
            //làm mới report-->để rpt rỗng
            rpt.Refresh();
            //khởi tạo đối tượng form chứa report
            Xuất_báo_cáo frm = new Xuất_báo_cáo();
            frm.crystalReportViewer1.ReportSource = rpt;//đổ dữ liệu từ dt
            frm.ShowDialog();
        }
        private void btn_Xuat_Bao_Cao_Click(object sender, EventArgs e)
        {
            string mdp = txt_MaDPHD.Texts;
            if (string.IsNullOrEmpty(mdp))
            {
                MessageBox.Show("Vui lòng hoá đơn muốn xuất!");
                return;
            }
            DialogResult result = MessageBox.Show("Bạn có muốn xuất hóa đơn không?", "Xuất hóa đơn", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Thực hiện các lệnh nếu người dùng chọn Yes
                XuatHD(mdp);
            }
        }
        private void HienThiTongTienChiTietDichVu()
        {
            DataTable dt = bllhd.getChiTietDV(txt_MaDPHD.Texts);
            DataTable hd = bllhd.getDPHD(txt_MaDPHD.Texts);

            decimal giatien = bllDP.TinhTongDatPhong(hd);
            decimal tongTien = bllhd.TinhTongTienChiTietDichVu(dt);
            decimal TTHD = tongTien + giatien;
            txt_TongTienCTDV.Texts = TTHD.ToString();
        }

        private void refreshdatagridview()
        {

            string madp = txt_MaDPHD.Texts;

            dgvCTDV.DataSource = bllhd.getChiTietDV(madp);
            dgv_HoaDon.DataSource = bllhd.getQLHoaDonwheremahoadon(madp);

            dgvDatPhong.DataSource = bllhd.getDPHD(madp);


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
                string mp = txt_MaPhong.Texts.Trim();
                if (string.IsNullOrEmpty(maDP) || string.IsNullOrEmpty(makh) || string.IsNullOrEmpty(maNV) || string.IsNullOrEmpty(mp) || string.IsNullOrEmpty(txt_TongTienCTDV.Texts))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin hoá đơn!");
                    return;
                }

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
                if (bllhd.kiemtramatrung(maDP) == 1)
                {
                    MessageBox.Show("Hoá đơn đã được tạo.", "Thông báo");
                }
                else
                {
                    if (bllhd.ThemHoaDon(DP))
                    {
                        bllhd.CapNhatTrangThaiPhong(mp, "Trống");
                        MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        refreshdatagridview();
                        HienThiTongTienChiTietDichVu();
                    }
                    else
                    {
                        MessageBox.Show("Tạo hoá đơn không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo!");
            }
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

        private void btn_LamMoiHD_Click(object sender, EventArgs e)
        {
            refreshdatagridview();
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
    }
}
