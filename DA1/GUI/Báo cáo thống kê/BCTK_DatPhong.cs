using BLL.Thống_kê;
using CrystalDecisions.CrystalReports.Engine;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Data;
using System.IO;
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
            chart_Nam.Titles.Add("Thống kê phòng được đặt trong năm " + nam + "\n" + top);
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

            try
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
                        ThongKeNam(dt, nam, top);
                    }
                    else if (nam == 0)
                    {
                        MessageBox.Show("Vui lòng chọn năm muốn thống kê.");

                    }
                    else
                    {
                        DataTable dt = bll.ThongKePhongDatTheoNamnhat(nam);
                        ThongKeNam(dt, nam, top);
                        DataTable dtthang = bll.ThongKePhongDatTheoThangnhat(thang, nam);
                        ThongKeThang(dtthang, thang, top);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo!");
            }
        }


        private void btn_Xuat_BC_Click(object sender, EventArgs e)
        {


            try
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
                    dgv_BC.DataSource = bll.ThongKePhongDatTheoThang(thang, nam);
                    label6.Text = thang.ToString() + " năm " + nam.ToString();
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

        private void cbb_nam_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo!");
            }
        }



        private void btn_XuatExcel_Click(object sender, EventArgs e)
        {


            try
            {
                //Kiểm tra xem DataGridView có dữ liệu hay không
                if (dgv_BC.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu để xuất Excel.", "Thông báo");
                    return;
                }

                // Tạo đối tượng ExcelPackage
                using (ExcelPackage excelPackage = new ExcelPackage())
                {
                    // Tạo một sheet mới trong ExcelPackage
                    ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Danh sách");

                    // Ghi tiêu đề cột từ DataGridView vào Excel
                    for (int i = 0; i < dgv_BC.Columns.Count; i++)
                    {
                        ExcelRange cell = worksheet.Cells[1, i + 1];
                        cell.Value = dgv_BC.Columns[i].HeaderText;
                        cell.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                    }

                    // Ghi dữ liệu từ DataGridView vào Excel
                    for (int i = 0; i < dgv_BC.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgv_BC.Columns.Count; j++)
                        {
                            ExcelRange cell = worksheet.Cells[i + 2, j + 1];
                            cell.Value = dgv_BC.Rows[i].Cells[j].Value;
                            cell.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                        }
                    }

                    // Lưu tệp Excel
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
                    saveFileDialog.DefaultExt = "xlsx";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog.FileName;
                        FileInfo excelFile = new FileInfo(filePath);
                        excelPackage.SaveAs(excelFile);
                        MessageBox.Show("Xuất Excel thành công.", "Thông báo");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xuất Excel: " + ex.Message, "Lỗi");
            }


        }
    }
}
