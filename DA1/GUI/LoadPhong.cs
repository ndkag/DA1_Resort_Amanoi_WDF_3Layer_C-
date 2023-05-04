using BLL;
using GUI.BC;
using GUI.Chức_năng;
using GUI.Quản_lý;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    public partial class LoadPhong : Form
    {
        QLPhongBLL bll = new QLPhongBLL();
        BLL_HoaDon bllhd = new BLL_HoaDon();

        public LoadPhong()
        {
            InitializeComponent();
            LoadTbale(bll.getPhong());
        }

        void LoadTbale(DataTable p)
        {
            foreach (DataRow item in p.Rows)
            {
                Button2 btn = new Button2();
                btn.Width = 120;
                btn.Height = 120;
                btn.Text = item["MaPhong"].ToString() + "\n" + item["TrangThaiPhong"].ToString() + "\n" + "Số người " + item["SoLuongNguoi"].ToString();

                // Thay đổi màu sắc của button dựa trên trạng thái của phòng
                if (item["TrangThaiPhong"].ToString() == "Trống")
                {

                    btn.BackColor = Color.FromArgb(199, 176, 122);
                    btn.Font = new Font(btn.Font.FontFamily, btn.Font.Size + 6); // Tăng kích thước chữ lên 10
                    // Thêm sự kiện click cho button                                              
                    btn.Click += (sender, e) =>
                    {
                        string maPhong = item["MaPhong"].ToString();
                        QL_Đặt_Phòng qldp = new QL_Đặt_Phòng();

                        openChildFormInPanel(qldp);
                        panelTieuDe.Visible = false;
                        qldp.cbb_MaP.Text = maPhong;

                    };
                }
                else if (item["TrangThaiPhong"].ToString() == "Đã có khách")
                {
                    btn.BackColor = Color.FromArgb(204, 202, 200);
                    btn.ForeColor = Color.FromArgb(64, 64, 64);
                    btn.Font = new Font(btn.Font.FontFamily, btn.Font.Size + 4); // Tăng kích thước chữ lên 10
                    // Thêm sự kiện click cho button
                    btn.Click += (sender, e) =>
                    {

                        // Lấy mã phòng từ button
                        string maPhong = item["MaPhong"].ToString();

                        string maDatPhong = bllhd.getMaDatPhongByMaPhong(maPhong); //Giả sử hàm getMaDatPhongByMaPhong() đã được thực hiện trong lớp QLPhongBLL

                        // Gán mã phòng vào textbox txtMaPhong trên form Hoá Đơn
                        Hoá_Đơn formHoaDon = new Hoá_Đơn();
                        formHoaDon.txt_MaDatPhong.Texts = maDatPhong;
                        formHoaDon.txt_MaDPHD.Texts = maDatPhong;
                        formHoaDon.txt_MaPhong.Texts = maPhong;
                        formHoaDon.label4.Visible = false;
                        formHoaDon.rjTextBox1.Visible = false;
                        formHoaDon.checkbox_chinhsuahd.Visible = false;

                        // Tìm kiếm các đặt phòng tương ứng với mã phòng
                        DataTable dt = bllhd.getDatPhongByMaPhong(maPhong);

                        // Hiển thị kết quả trong datagridview
                        formHoaDon.dgvCTDV.DataSource = dt;
                        openChildFormInPanel(formHoaDon);
                        panelTieuDe.Visible = false;
                    };
                }
                else
                {
                    btn.BackColor = Color.FromArgb(217, 123, 132);
                    btn.Font = new Font(btn.Font.FontFamily, btn.Font.Size + 4); // Tăng kích thước chữ lên 10


                }

                flowLayoutPanel1.Controls.Add(btn);
            }

        }
        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            formchildForm.Controls.Add(childForm);
            formchildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btn_DatP_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
