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
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI.Báo_cáo_thống_kê
{
    public partial class BCTK_DatPhong : Form
    {
        BLL_Thống_kê bll = new BLL_Thống_kê();
        public BCTK_DatPhong()
        {
            InitializeComponent();
        }
        public void ThongKeNam(DataTable dt, int nam, string top)
        {
            chart_Nam.Series.Clear();
            chart_Nam.Titles.Clear();
            chart_Nam.Titles.Add("Thống kê phòng được đặt trong năm " + nam +"\n"+top);
            Series series = chart_Nam.Series.Add("Số lần đặt");
            series.ChartType = SeriesChartType.Column;
            foreach (DataRow row in dt.Rows)
            {
                string Thang = row["Phong"].ToString();
                int soLuong = int.Parse(row["SoLanDat"].ToString());
                series.Points.AddXY(Thang, soLuong);
            }
        }

        public void ThongKeThang(DataTable dt, int thang, string top)
        {
            chart_Thang.Series.Clear();
            chart_Thang.Titles.Clear();
            chart_Thang.Titles.Add("Thống kê phòng được đặt trong tháng " + thang + "\n" + top);
            Series series = chart_Thang.Series.Add("Số lần đặt");
            series.ChartType = SeriesChartType.Column;
            foreach (DataRow row in dt.Rows)
            {
                string ngay = row["Phong"].ToString();
                int soLuong = int.Parse(row["SoLanDat"].ToString());
                series.Points.AddXY(ngay, soLuong);
            }

        }
        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            int nam = int.Parse((cbb_nam.SelectedItem ?? "0").ToString());
            int thang = int.Parse((cbb_Thang.SelectedItem ?? "0").ToString());
            string top = (cbb_Top.SelectedItem ?? "Top 5 đặt nhiều nhất").ToString();
            if (top == "Top 5 đặt nhiều nhất")
            {
                if (nam == 0 && thang == 0)
                {
                    MessageBox.Show("Vui lòng chọn tháng và năm muốn thống kê.");
                }
                else if (thang == 0)
                {
                    DataTable dt = bll.ThongKePhongDatTheoNamnhat(nam);
                    ThongKeNam(dt, nam,top);
                }
                else if (nam == 0)
                {
                    MessageBox.Show("Vui lòng chọn năm muốn thống kê.");

                }
                else
                {
                    DataTable dt = bll.ThongKePhongDatTheoNamnhat(nam);
                    ThongKeNam(dt, nam,top);
                    DataTable dtthang = bll.ThongKePhongDatTheoThangnhat(thang, nam);
                    ThongKeThang(dtthang, thang,top);
                }
            }
            else if (top == "Top 5 đặt ít nhất")
            {
                if (nam == 0 && thang == 0)
                {
                    MessageBox.Show("Vui lòng chọn tháng và năm muốn thống kê.");
                }
                else if (thang == 0)
                {
                    DataTable dt = bll.ThongKePhongDatTheoNamit(nam);
                    ThongKeNam(dt, nam, top);
                }
                else if (nam == 0)
                {
                    MessageBox.Show("Vui lòng chọn năm muốn thống kê.");

                }
                else
                {
                    DataTable dt = bll.ThongKePhongDatTheoNamit(nam);
                    ThongKeNam(dt, nam, top);
                    DataTable dtthang = bll.ThongKePhongDatTheoThangit(thang, nam);
                    ThongKeThang(dtthang, thang, top);
                }
            }
           
        }

        private void btn_Xuat_BC_Click(object sender, EventArgs e)
        {

            int nam = int.Parse((cbb_nam.SelectedItem ?? "2023").ToString());
            int thang = int.Parse((cbb_Thang.SelectedItem ?? "4").ToString());
            DataTable dt = bll.ThongKePhongDatTheoThang(thang, nam);
            //khởi tạo đối tượng report
            CR_DatPhong rpt = new CR_DatPhong();
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

        private void cbb_Thang_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nam = int.Parse((cbb_nam.SelectedItem ??"0").ToString());
            int thang = int.Parse((cbb_Thang.SelectedItem ??"0" ).ToString());
            if (nam != 0)
            {
                dgv_BC.DataSource = bll.ThongKePhongDatTheoThang(thang, nam);
                label6.Text = thang.ToString()+" năm "+nam.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập năm:))");
            }
           

        }

        private void cbb_nam_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nam = int.Parse((cbb_nam.SelectedItem ?? "0").ToString());
            int thang = int.Parse((cbb_Thang.SelectedItem ?? "0").ToString());
            if (nam != 0)
            {
                dgv_BC.DataSource = bll.ThongKePhongDatTheoThang(thang, nam);
                label6.Text = thang.ToString() + " năm " + nam.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập năm:))");
            }
        }
    }
}
