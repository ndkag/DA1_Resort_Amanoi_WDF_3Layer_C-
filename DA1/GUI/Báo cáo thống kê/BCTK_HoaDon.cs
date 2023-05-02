using BLL.Thống_kê;
using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI.Báo_cáo_thống_kê
{
    public partial class BCTK_HoaDon : Form
    {
        public BCTK_HoaDon()
        {
            InitializeComponent();
        }
        BLL_Thống_kê bll = new BLL_Thống_kê();


        public void ThongKeNam(DataTable dt, int nam)
        {
            chart_Nam.Series.Clear();
            chart_Nam.Titles.Clear();
            chart_Nam.Titles.Add("Thống kê doanh thu trong 12 tháng năm " + nam);
            Series series = chart_Nam.Series.Add("Doanh thu");
            series.ChartType = SeriesChartType.Column;
            //foreach (DataRow row in dt.Rows)
            //{
            //    int Thang = int.Parse(row["Thang"].ToString());
            //    int DoanhThu = int.Parse(row["DoanhThu"].ToString());
            //    series.Points.AddXY(Thang, DoanhThu);
            //}
            for (int i = 1; i <= 12; i++)
            {
                // Thiết lập giá trị mặc định cho các cột
                int DoanhThu = 0;

                // Kiểm tra xem có dữ liệu trong DataTable cho tháng hiện tại hay không
                foreach (DataRow row in dt.Rows)
                {
                    int Thang = int.Parse(row["Thang"].ToString());
                    if (Thang == i)
                    {
                        DoanhThu = int.Parse(row["DoanhThu"].ToString());
                        break;
                    }
                }

                // Thêm giá trị của cột vào chuỗi điểm của biểu đồ
                series.Points.AddXY(i, DoanhThu);
            }

        }

        public void ThongKeThang(DataTable dt, int thang, int nam)
        {
            chart_Thang.Series.Clear();
            chart_Thang.Titles.Clear();
            chart_Thang.Titles.Add("Thống kê doanh thu trong tháng " + thang + " năm " + nam);
            Series series = chart_Thang.Series.Add("Doanh thu");
            series.ChartType = SeriesChartType.Line;
            //foreach (DataRow row in dt.Rows)
            //{
            //    int ngay = int.Parse(row["Ngày"].ToString());
            //    int so = int.Parse(row["DoanhThu"].ToString());
            //    series.Points.AddXY(ngay, so);
            //}
            // Thiết lập khoảng cách giữa các giá trị trên trục X
            chart_Thang.ChartAreas[0].AxisX.Interval = 1;

            // Thiết lập kiểu gạch ngang trên trục X để các cột hiển thị liên tục hơn
            chart_Thang.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chart_Thang.ChartAreas[0].AxisX.MajorTickMark.LineWidth = 0;
            chart_Thang.ChartAreas[0].AxisX.MinorGrid.LineWidth = 0;
            chart_Thang.ChartAreas[0].AxisX.MinorTickMark.LineWidth = 0;

            for (int i = 1; i <= 31; i++)
            {
                // Thiết lập giá trị mặc định cho các cột
                int DoanhThu = 0;

                // Kiểm tra xem có dữ liệu trong DataTable cho tháng hiện tại hay không
                foreach (DataRow row in dt.Rows)
                {
                    int ngay = int.Parse(row["Ngày"].ToString());
                    if (ngay == i)
                    {
                        DoanhThu = int.Parse(row["DoanhThu"].ToString());
                        break;
                    }
                }

                // Thêm giá trị của cột vào chuỗi điểm của biểu đồ
                series.Points.AddXY(i, DoanhThu);
            }

        }
        private void btn_ThongKe_Click(object sender, EventArgs e)
        {

            int nam = int.Parse((cbb_nam.SelectedItem ?? "0").ToString());
            int thang = int.Parse((cbb_Thang.SelectedItem ?? "0").ToString());
            if (nam == 0 && thang == 0)
            {
                MessageBox.Show("Vui lòng chọn tháng và năm muốn thống kê.");
            }
            else if (thang == 0)
            {
                DataTable dt = bll.ThongKeDoanhThuTheoNam(nam);
                ThongKeNam(dt, nam);
            }
            else if (nam == 0)
            {
                MessageBox.Show("Vui lòng chọn năm muốn thống kê.");

            }
            else
            {
                DataTable dt = bll.ThongKeDoanhThuTheoNam(nam);
                ThongKeNam(dt, nam);
                DataTable dtthang = bll.ThongKeDoanhThuTheoThang(thang, nam);
                ThongKeThang(dtthang, thang,nam);
            }
        }

        private void btn_Xuat_BC_Click(object sender, EventArgs e)
        {
            int nam = int.Parse((cbb_nam.SelectedItem ?? "0").ToString());
            int thang = int.Parse((cbb_Thang.SelectedItem ?? "0").ToString());
            DataTable dt = bll.BaoCaoHoaDonThang(thang, nam);
            //khởi tạo đối tượng report
            CR_HoaDon rpt = new CR_HoaDon();
            //gán mã loại vào trong report
            ((TextObject)rpt.ReportDefinition.ReportObjects["txt_Thang"]).Text = thang.ToString();
            //thêm dữ liệu vào report
            rpt.SetDataSource(dt);
            //làm mới report-->để rpt rỗng
            rpt.Refresh();
            //khởi tạo đối tượng form chứa report
            Xuất_báo_cáo frm = new Xuất_báo_cáo();
            frm.crystalReportViewer1.ReportSource = rpt;//đổ dữ liệu từ dt
            frm.ShowDialog();
        }
    }
}
