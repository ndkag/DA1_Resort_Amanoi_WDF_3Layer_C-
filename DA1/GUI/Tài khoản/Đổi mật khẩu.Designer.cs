namespace GUI.Hệ_thống
{
    partial class Đổi_mật_khẩu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Đổi_mật_khẩu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_thoat = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtXacNhanMK = new GUI.BC.RJTextBox();
            this.txtMKMoi = new GUI.BC.RJTextBox();
            this.txtMKCu = new GUI.BC.RJTextBox();
            this.txtTaiKhoan = new GUI.BC.RJTextBox();
            this.btn_DoiMK = new GUI.BC.Button2();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.rjTextBox1 = new GUI.BC.RJTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.panel1.Controls.Add(this.btn_thoat);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(118, 450);
            this.panel1.TabIndex = 9;
            // 
            // btn_thoat
            // 
            this.btn_thoat.BorderColor = System.Drawing.Color.White;
            this.btn_thoat.BorderRadius = 15;
            this.btn_thoat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_thoat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_thoat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_thoat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_thoat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_thoat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.ForeColor = System.Drawing.Color.White;
            this.btn_thoat.Image = global::GUI.Properties.Resources.icons8_Close_64px_2;
            this.btn_thoat.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_thoat.Location = new System.Drawing.Point(0, 390);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(118, 60);
            this.btn_thoat.TabIndex = 66;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 190);
            this.label5.TabIndex = 0;
            this.label5.Text = "ĐỔI\r\n\r\nMẬT\r\n\r\nKHẨU\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(124, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Điền thông tin:";
            // 
            // txtXacNhanMK
            // 
            this.txtXacNhanMK.BackColor = System.Drawing.SystemColors.Window;
            this.txtXacNhanMK.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtXacNhanMK.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.txtXacNhanMK.BorderRadius = 13;
            this.txtXacNhanMK.BorderSize = 2;
            this.txtXacNhanMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXacNhanMK.ForeColor = System.Drawing.Color.DimGray;
            this.txtXacNhanMK.Location = new System.Drawing.Point(150, 282);
            this.txtXacNhanMK.Margin = new System.Windows.Forms.Padding(4);
            this.txtXacNhanMK.Multiline = false;
            this.txtXacNhanMK.Name = "txtXacNhanMK";
            this.txtXacNhanMK.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtXacNhanMK.PasswordChar = false;
            this.txtXacNhanMK.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtXacNhanMK.PlaceholderText = "Ghi lại mật khẩu";
            this.txtXacNhanMK.Size = new System.Drawing.Size(250, 40);
            this.txtXacNhanMK.TabIndex = 13;
            this.txtXacNhanMK.Texts = "";
            this.txtXacNhanMK.UnderlinedStyle = false;
            this.txtXacNhanMK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtXacNhanMK_KeyPress);
            // 
            // txtMKMoi
            // 
            this.txtMKMoi.BackColor = System.Drawing.SystemColors.Window;
            this.txtMKMoi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMKMoi.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.txtMKMoi.BorderRadius = 13;
            this.txtMKMoi.BorderSize = 2;
            this.txtMKMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMKMoi.ForeColor = System.Drawing.Color.DimGray;
            this.txtMKMoi.Location = new System.Drawing.Point(150, 216);
            this.txtMKMoi.Margin = new System.Windows.Forms.Padding(4);
            this.txtMKMoi.Multiline = false;
            this.txtMKMoi.Name = "txtMKMoi";
            this.txtMKMoi.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMKMoi.PasswordChar = false;
            this.txtMKMoi.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMKMoi.PlaceholderText = "Mật khẩu mới";
            this.txtMKMoi.Size = new System.Drawing.Size(250, 40);
            this.txtMKMoi.TabIndex = 12;
            this.txtMKMoi.Texts = "";
            this.txtMKMoi.UnderlinedStyle = false;
            this.txtMKMoi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMKMoi_KeyPress);
            // 
            // txtMKCu
            // 
            this.txtMKCu.BackColor = System.Drawing.SystemColors.Window;
            this.txtMKCu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMKCu.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.txtMKCu.BorderRadius = 13;
            this.txtMKCu.BorderSize = 2;
            this.txtMKCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMKCu.ForeColor = System.Drawing.Color.DimGray;
            this.txtMKCu.Location = new System.Drawing.Point(150, 152);
            this.txtMKCu.Margin = new System.Windows.Forms.Padding(4);
            this.txtMKCu.Multiline = false;
            this.txtMKCu.Name = "txtMKCu";
            this.txtMKCu.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMKCu.PasswordChar = false;
            this.txtMKCu.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMKCu.PlaceholderText = "Mật khẩu cũ";
            this.txtMKCu.Size = new System.Drawing.Size(250, 40);
            this.txtMKCu.TabIndex = 11;
            this.txtMKCu.Texts = "";
            this.txtMKCu.UnderlinedStyle = false;
            this.txtMKCu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMKCu_KeyPress);
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.BackColor = System.Drawing.SystemColors.Window;
            this.txtTaiKhoan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTaiKhoan.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.txtTaiKhoan.BorderRadius = 13;
            this.txtTaiKhoan.BorderSize = 2;
            this.txtTaiKhoan.Enabled = false;
            this.txtTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaiKhoan.ForeColor = System.Drawing.Color.DimGray;
            this.txtTaiKhoan.Location = new System.Drawing.Point(150, 84);
            this.txtTaiKhoan.Margin = new System.Windows.Forms.Padding(4);
            this.txtTaiKhoan.Multiline = false;
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTaiKhoan.PasswordChar = false;
            this.txtTaiKhoan.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTaiKhoan.PlaceholderText = "";
            this.txtTaiKhoan.Size = new System.Drawing.Size(250, 40);
            this.txtTaiKhoan.TabIndex = 10;
            this.txtTaiKhoan.Texts = "";
            this.txtTaiKhoan.UnderlinedStyle = false;
            // 
            // btn_DoiMK
            // 
            this.btn_DoiMK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.btn_DoiMK.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.btn_DoiMK.BorderColor = System.Drawing.Color.Gray;
            this.btn_DoiMK.BorderRadius = 20;
            this.btn_DoiMK.BorderSize = 0;
            this.btn_DoiMK.FlatAppearance.BorderSize = 0;
            this.btn_DoiMK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DoiMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DoiMK.ForeColor = System.Drawing.Color.White;
            this.btn_DoiMK.Location = new System.Drawing.Point(192, 360);
            this.btn_DoiMK.MaDatPhong = null;
            this.btn_DoiMK.Name = "btn_DoiMK";
            this.btn_DoiMK.Size = new System.Drawing.Size(152, 46);
            this.btn_DoiMK.TabIndex = 0;
            this.btn_DoiMK.Text = "Đổi mật khẩu";
            this.btn_DoiMK.TextColor = System.Drawing.Color.White;
            this.btn_DoiMK.UseVisualStyleBackColor = false;
            this.btn_DoiMK.Click += new System.EventHandler(this.btn_DoiMK_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // rjTextBox1
            // 
            this.rjTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.rjTextBox1.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.rjTextBox1.BorderRadius = 15;
            this.rjTextBox1.BorderSize = 3;
            this.rjTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rjTextBox1.Enabled = false;
            this.rjTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.rjTextBox1.Location = new System.Drawing.Point(0, 0);
            this.rjTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox1.Multiline = true;
            this.rjTextBox1.Name = "rjTextBox1";
            this.rjTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox1.PasswordChar = false;
            this.rjTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox1.PlaceholderText = "";
            this.rjTextBox1.Size = new System.Drawing.Size(434, 450);
            this.rjTextBox1.TabIndex = 71;
            this.rjTextBox1.Texts = "";
            this.rjTextBox1.UnderlinedStyle = false;
            // 
            // Đổi_mật_khẩu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(434, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtXacNhanMK);
            this.Controls.Add(this.txtMKMoi);
            this.Controls.Add(this.txtMKCu);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_DoiMK);
            this.Controls.Add(this.rjTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Đổi_mật_khẩu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi_mật_khẩu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BC.Button2 btn_DoiMK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private BC.RJTextBox txtMKCu;
        private BC.RJTextBox txtMKMoi;
        private BC.RJTextBox txtXacNhanMK;
        private System.Windows.Forms.Label label1;
        public BC.RJTextBox txtTaiKhoan;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Guna.UI2.WinForms.Guna2Button btn_thoat;
        private BC.RJTextBox rjTextBox1;
    }
}