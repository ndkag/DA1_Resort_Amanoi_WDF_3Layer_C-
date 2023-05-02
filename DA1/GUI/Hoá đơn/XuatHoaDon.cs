using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        private void btn_HoanThanh_Click(object sender, EventArgs e)
        {

            string mp = txt_MaPhong.Texts;
            string madp = txt_MaDatPhong.Texts;
            if(bllhd.CapNhatTrangThaiPhong(mp, "Trống") == true)
            {

                // Hiển thị thông báo thành công
                MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
          




        }


        
        private void refreshdatagridview()
        {

            string madp = txt_MaDatPhong.Texts;

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
            MessageBox.Show("Hiện không thể sử dụng chức năng này \n\n Xin lỗi chúng tôi đang hoàn thiện phần mềm, chức năng này sẽ sớm \n được sử dụng.");
        }
    }
}
