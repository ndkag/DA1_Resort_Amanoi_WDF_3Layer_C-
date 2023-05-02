using BLL;
using DTO;
using GUI.Báo_cáo_thống_kê;
using GUI.BC;
using GUI.Chức_năng;
using GUI.Hệ_thống;
using GUI.Quản_lý;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GUI
{
    public partial class Menu : Form
    {
        //private bool isLoggedIn = false;
        QLPhongDTO p = new QLPhongDTO();
        QLPhongBLL bll = new QLPhongBLL();

        public Menu()
        {
            InitializeComponent();
            customizeDesign();
          
        }
     

        private void customizeDesign()
        {
            panelHethongSubmenu.Visible = false;
            //panelTroGiupSubmenu.Visible = false;
            panelThongKeSubmenu.Visible = false;
            panelChucNangSubmenu.Visible = false;

        }

        private void hideSubMenu()
        {
            if (panelHethongSubmenu.Visible == true)
                panelHethongSubmenu.Visible = false;   
            if (panelThongKeSubmenu.Visible == true)
                panelThongKeSubmenu.Visible = false;
            if (panelChucNangSubmenu.Visible == true)
                panelChucNangSubmenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
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
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void CollapseMenu()
        {
            if (this.panelSlideMenu.Width > 180) //Collapse menu
            {
                panelSlideMenu.Width = 55;
                lb_LOGO.Visible = false;
                btn_Menu.Dock = DockStyle.Top;
                lb_ID.Visible = false;
                lb_Ten.Visible = false;
                label1.Visible = false;

                label2.Visible = false;
                foreach (Guna2Button menuButton in panelSlideMenu.Controls.OfType<Guna2Button>())
                {
                    menuButton.Text = "";
                    menuButton.Padding = new Padding(0);
                    
                }
            }
            else
            { //Expand menu
                panelSlideMenu.Width = 199;
                lb_LOGO.Visible = true;
                lb_ID.Visible = true;
                lb_Ten.Visible = true;
                label1.Visible = true;

                label2.Visible = true;
                btn_Menu.Dock = DockStyle.None;
                foreach (Guna2Button menuButton in panelSlideMenu.Controls.OfType<Guna2Button>())
                {
                    menuButton.Text = "   " + menuButton.Tag.ToString();
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }
        private void CollapseMenu2()
        {
            //Expand menu
            panelSlideMenu.Width = 199;
            lb_LOGO.Visible = true;
            lb_ID.Visible = true;
            lb_Ten.Visible = true;
            label1.Visible = true;

            label2.Visible = true;
            btn_Menu.Dock = DockStyle.None;
            foreach (Guna2Button menuButton in panelSlideMenu.Controls.OfType<Guna2Button>())
            {
                menuButton.Text = "   " + menuButton.Tag.ToString();
                menuButton.Padding = new Padding(10, 0, 0, 0);
            }
        }
        private void CollapseMenu3()
        {
            panelSlideMenu.Width = 55;
            lb_LOGO.Visible = false;
            lb_ID.Visible = false;
            lb_Ten.Visible = false;
            label1.Visible = false;

            label2.Visible = false;
            btn_Menu.Dock = DockStyle.Top;
            foreach (Guna2Button menuButton in panelSlideMenu.Controls.OfType<Guna2Button>())
            {
                menuButton.Text = "";
                menuButton.Padding = new Padding(0);
            }
        }

        #region HeThong Menu
        public void btn_HeThong_Click(object sender, EventArgs e)
        {
            showSubMenu(panelHethongSubmenu);
            CollapseMenu2();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            //isLoggedIn = false; // Đánh dấu đã đăng xuất
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.ShowDialog();
        }
        private void btn_DoiMK_Click(object sender, EventArgs e)
        {

            // Tạo form đổi mật khẩu
            Đổi_mật_khẩu doi = new Đổi_mật_khẩu();
            doi.txtTaiKhoan.Texts = lb_ID.Text;
            doi.ShowDialog();
     

            hideSubMenu();
        }

        private void btnQuanLyTK_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Quản_lý_tài_khoản());
            hideSubMenu();
            CollapseMenu3();

        }
        #endregion

        #region Quản lý Menu


        private void btn_KhachHang_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new QL_Khách_Hàng());
            CollapseMenu3();

            hideSubMenu();
        }
        private void btn_Nhanvien_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new QL_Nhân_Viên());
            CollapseMenu3();

            hideSubMenu();
        }
        private void btn_QLPhong_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new QL_Phòng());

            hideSubMenu();
            CollapseMenu3();

        }
        private void btn_QLDichVu_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new QL_dịch_vụ());
            hideSubMenu();
            CollapseMenu3();


        }
        #endregion

        #region Chức năng
        private void btn_ChucNang_Click(object sender, EventArgs e)
        {
            showSubMenu(panelChucNangSubmenu);
            CollapseMenu2();


        }
        private void btn_DatPhong_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new QL_Đặt_Phòng());
            CollapseMenu3();

            hideSubMenu();
        }
        private void btn_ChiTietDV_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new QL_CTDV());
            CollapseMenu3();

            hideSubMenu();
        }
        #endregion
        #region Thống kê Menu


        #endregion

        #region Trợ giúp Menu
        private void btn_TroGiup_Click(object sender, EventArgs e)
        {
            //showSubMenu(panelTroGiupSubmenu);
        }
        private void button217_Click(object sender, EventArgs e)
        {
        
            hideSubMenu();
        }

        #endregion


  
        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            
            LoginForm lg = new LoginForm();
            this.Hide();
            lg.ShowDialog();
        }

        private void btn_TrangChu_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new LoadPhong());
            customizeDesign();
            hideSubMenu();
            CollapseMenu3();


        }

        private void Menu_Load(object sender, EventArgs e)
        {
            CollapseMenu();

        }

        private void btn_HoaDon_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Hoá_Đơn());
            CollapseMenu3();

            hideSubMenu();

        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            CollapseMenu();
            customizeDesign();

        }

        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            showSubMenu(panelThongKeSubmenu);
            CollapseMenu2();


        }

        private void btn_TroGiup_Click_1(object sender, EventArgs e)
        {
            customizeDesign();
            hideSubMenu();
            CollapseMenu3();
        }

        private void btn_ThongKeKH_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new BCTK_KhachHang());
            CollapseMenu3();

            hideSubMenu();
        }

        private void btn_DoanhThu_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new BCTK_HoaDon());
            CollapseMenu3();

            hideSubMenu();
        }

        private void btn_Phong_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new BCTK_DatPhong());
            CollapseMenu3();

            hideSubMenu();
        }
    }
}
