using BLL;
using BLL.Thống_kê;
using GUI.Báo_cáo_thống_kê;
using System;
using System.Data;
using System.Windows.Forms;

namespace GUI.Hoá_đơn
{
    public partial class XuatHoaDon : Form
    {
        public XuatHoaDon()
        {
            InitializeComponent();
            refreshdatagridview();
        }
        BLL_HoaDon bllhd = new BLL_HoaDon();
        BLL_XuatHD dal = new BLL_XuatHD();
        private void btn_HoanThanh_Click(object sender, EventArgs e)
        {

            string mp = txt_MaPhong.Text;
            string madp = txt_MaDatPhong.Text;
            if (bllhd.CapNhatTrangThaiPhong(mp, "Trống") == true)
            {

                // Hiển thị thông báo thành công
                MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }





        }



        private void refreshdatagridview()
        {
            string madp = txt_MaDatPhong.Text;
            dgvCTDV.DataSource = bllhd.getChiTietDV(madp);
            dgvKH.DataSource = bllhd.getKHHD(madp);
            dgvHoaDon.DataSource = bllhd.getHoaDon(madp);
            dgvDatPhong.DataSource = bllhd.getDPHD(madp);


        }

        private void XuatHoaDon_Load(object sender, EventArgs e)
        {
            refreshdatagridview();
        }

        private void btn_XuatHoaDon_Click(object sender, EventArgs e)
        {
            string maDatPhong = txt_MaDatPhong.Text;

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
    }
}
