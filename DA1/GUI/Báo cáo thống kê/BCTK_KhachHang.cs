using BLL.Thống_kê;
using CrystalDecisions.CrystalReports.Engine;
using GUI.Báo_cáo_thống_kê;
using GUI.Hoá_đơn;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI
{
    public partial class BCTK_KhachHang : Form
    {
   
        public BCTK_KhachHang()
        {
            InitializeComponent();
        }
   
        BLL_ThongKeKH bll = new BLL_ThongKeKH();

        public void ThongKeNam(DataTable dt, int nam)
        {
            chart_Nam.Series.Clear();
            chart_Nam.Titles.Clear();
            chart_Nam.Titles.Add("Thống kê số khách hàng được tạo trong 12 tháng năm "+nam);
            Series series = chart_Nam.Series.Add("Số lượng khách hàng");
            series.ChartType = SeriesChartType.Column;
            foreach (DataRow row in dt.Rows)
            {
                int Thang = int.Parse(row["Tháng"].ToString());
                int soLuong = int.Parse(row["SoLuong"].ToString());
                series.Points.AddXY(Thang, soLuong);
            }
        }

        public void ThongKeThang(DataTable dt,int thang)
        {
            chart_Thang.Series.Clear();
            chart_Thang.Titles.Clear();
            chart_Thang.Titles.Add("Thống kê số khách hàng được tạo trong tháng "+ thang);
            Series series = chart_Thang.Series.Add("Số lượng khách hàng");
            series.ChartType = SeriesChartType.Column;
            foreach (DataRow row in dt.Rows)
            {
                int ngay = int.Parse(row["Ngày"].ToString());
                int soLuong = int.Parse(row["SoLuong"].ToString());
                series.Points.AddXY(ngay, soLuong);
            }

        }
      
        private void btn_Xuat_BC_Click(object sender, EventArgs e)
        {

           

            try
            {
                int nam = int.Parse((cbb_nam.SelectedItem ?? "0").ToString());
                int thang = int.Parse((cbb_Thang.SelectedItem ?? "0").ToString());
                DataTable dt = bll.BaoCaoKhachHang(thang, nam);
                //khởi tạo đối tượng report
                CR_KhachHang rpt = new CR_KhachHang();
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo!");
            }
        }

        private void btn_ThongKe_Click(object sender, EventArgs e)
        {

           
            try
            {
                int nam = int.Parse((cbb_nam.SelectedItem ?? "0").ToString());
                int thang = int.Parse((cbb_Thang.SelectedItem ?? "0").ToString());
                if (nam == 0 && thang == 0)
                {
                    MessageBox.Show("Vui lòng chọn tháng và năm muốn thống kê.");
                }
                else if (thang == 0)
                {
                    DataTable dt = bll.ThongKeSoKhachHangTheoNam(nam);
                    ThongKeNam(dt, nam);
                }
                else if (nam == 0)
                {
                    MessageBox.Show("Vui lòng chọn năm muốn thống kê.");

                }
                else
                {
                    DataTable dt = bll.ThongKeSoKhachHangTheoNam(nam);
                    ThongKeNam(dt, nam);
                    DataTable dtthang = bll.ThongKeSoKhachHangTheoThang(thang, nam);
                    ThongKeThang(dtthang, thang);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo!");
            }


        }

        private void cbb_nam_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            try
            {
                int nam = int.Parse((cbb_nam.SelectedItem ?? "0").ToString());
                int thang = int.Parse((cbb_Thang.SelectedItem ?? "0").ToString());
                if (nam != 0)
                {
                    dgv_BC.DataSource = bll.BaoCaoKhachHang(thang, nam);
                    label3.Text = thang.ToString() + " năm " + nam.ToString();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập năm:))");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo!");
            }
        }

        private void cbb_Thang_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            try
            {
                int nam = int.Parse((cbb_nam.SelectedItem ?? "0").ToString());
                int thang = int.Parse((cbb_Thang.SelectedItem ?? "0").ToString());
                if (nam != 0)
                {
                    dgv_BC.DataSource = bll.BaoCaoKhachHang(thang, nam);
                    label3.Text = thang.ToString() + " năm " + nam.ToString();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập năm:))");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo!");
            }
        }
    }
}
