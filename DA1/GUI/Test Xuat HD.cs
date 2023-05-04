using BLL.Thống_kê;
using GUI.Báo_cáo_thống_kê;
using System;
using System.Data;
using System.Windows.Forms;

namespace GUI
{
    public partial class Test_Xuat_HD : Form
    {
        public Test_Xuat_HD()
        {
            InitializeComponent();
        }
        BLL_XuatHD dal = new BLL_XuatHD();
        private void XuatHD_Click(object sender, EventArgs e)
        {
            string maDatPhong = txt_MaDP.Text;

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
