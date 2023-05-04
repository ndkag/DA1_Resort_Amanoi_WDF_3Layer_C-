namespace GUI.Hoá_đơn
{
    partial class XuatHoaDon
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
            this.dgvCTDV = new System.Windows.Forms.DataGridView();
            this.dgvKH = new System.Windows.Forms.DataGridView();
            this.dgvDatPhong = new System.Windows.Forms.DataGridView();
            this.btn_HoanThanh = new GUI.BC.Button2();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.rjTextBox6 = new GUI.BC.RJTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_XuatHoaDon = new GUI.BC.Button2();
            this.txt_MaPhong = new System.Windows.Forms.TextBox();
            this.txt_MaDatPhong = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCTDV
            // 
            this.dgvCTDV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCTDV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvCTDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTDV.Location = new System.Drawing.Point(35, 233);
            this.dgvCTDV.Name = "dgvCTDV";
            this.dgvCTDV.RowHeadersWidth = 51;
            this.dgvCTDV.RowTemplate.Height = 24;
            this.dgvCTDV.Size = new System.Drawing.Size(940, 147);
            this.dgvCTDV.TabIndex = 0;
            // 
            // dgvKH
            // 
            this.dgvKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKH.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKH.Location = new System.Drawing.Point(35, 102);
            this.dgvKH.Name = "dgvKH";
            this.dgvKH.RowHeadersWidth = 51;
            this.dgvKH.RowTemplate.Height = 24;
            this.dgvKH.Size = new System.Drawing.Size(940, 85);
            this.dgvKH.TabIndex = 1;
            // 
            // dgvDatPhong
            // 
            this.dgvDatPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatPhong.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvDatPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatPhong.Location = new System.Drawing.Point(35, 425);
            this.dgvDatPhong.Name = "dgvDatPhong";
            this.dgvDatPhong.RowHeadersWidth = 51;
            this.dgvDatPhong.RowTemplate.Height = 24;
            this.dgvDatPhong.Size = new System.Drawing.Size(940, 71);
            this.dgvDatPhong.TabIndex = 2;
            // 
            // btn_HoanThanh
            // 
            this.btn_HoanThanh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.btn_HoanThanh.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.btn_HoanThanh.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_HoanThanh.BorderRadius = 14;
            this.btn_HoanThanh.BorderSize = 0;
            this.btn_HoanThanh.FlatAppearance.BorderSize = 0;
            this.btn_HoanThanh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HoanThanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HoanThanh.ForeColor = System.Drawing.Color.White;
            this.btn_HoanThanh.Location = new System.Drawing.Point(803, 662);
            this.btn_HoanThanh.MaDatPhong = null;
            this.btn_HoanThanh.Name = "btn_HoanThanh";
            this.btn_HoanThanh.Size = new System.Drawing.Size(179, 51);
            this.btn_HoanThanh.TabIndex = 5;
            this.btn_HoanThanh.Text = "OK";
            this.btn_HoanThanh.TextColor = System.Drawing.Color.White;
            this.btn_HoanThanh.UseVisualStyleBackColor = false;
            this.btn_HoanThanh.Click += new System.EventHandler(this.btn_HoanThanh_Click);
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDon.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Location = new System.Drawing.Point(42, 542);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersWidth = 51;
            this.dgvHoaDon.RowTemplate.Height = 24;
            this.dgvHoaDon.Size = new System.Drawing.Size(940, 102);
            this.dgvHoaDon.TabIndex = 6;
            // 
            // rjTextBox6
            // 
            this.rjTextBox6.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.rjTextBox6.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.rjTextBox6.BorderRadius = 20;
            this.rjTextBox6.BorderSize = 3;
            this.rjTextBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rjTextBox6.Enabled = false;
            this.rjTextBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox6.ForeColor = System.Drawing.Color.DimGray;
            this.rjTextBox6.Location = new System.Drawing.Point(0, 0);
            this.rjTextBox6.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox6.Multiline = true;
            this.rjTextBox6.Name = "rjTextBox6";
            this.rjTextBox6.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox6.PasswordChar = false;
            this.rjTextBox6.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox6.PlaceholderText = "";
            this.rjTextBox6.Size = new System.Drawing.Size(1029, 725);
            this.rjTextBox6.TabIndex = 29;
            this.rjTextBox6.Texts = "";
            this.rjTextBox6.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(401, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 42);
            this.label1.TabIndex = 30;
            this.label1.Text = "Hoá đơn ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 29);
            this.label2.TabIndex = 31;
            this.label2.Text = "Thông tin khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(458, 29);
            this.label3.TabIndex = 32;
            this.label3.Text = "Chi tiết dịch vụ khách hàng đã sử dụng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(318, 29);
            this.label4.TabIndex = 33;
            this.label4.Text = "Thông tin phiếu đặt phòng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 510);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 29);
            this.label5.TabIndex = 34;
            this.label5.Text = "Thông tin hoá đơn";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.panel1.Location = new System.Drawing.Point(23, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(6, 900);
            this.panel1.TabIndex = 35;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.panel2.Location = new System.Drawing.Point(25, 198);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(700, 3);
            this.panel2.TabIndex = 36;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.panel3.Location = new System.Drawing.Point(25, 393);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(525, 3);
            this.panel3.TabIndex = 37;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.panel4.Location = new System.Drawing.Point(25, 509);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(350, 3);
            this.panel4.TabIndex = 38;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.panel5.Location = new System.Drawing.Point(25, 662);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 3);
            this.panel5.TabIndex = 39;
            // 
            // btn_XuatHoaDon
            // 
            this.btn_XuatHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.btn_XuatHoaDon.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.btn_XuatHoaDon.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_XuatHoaDon.BorderRadius = 14;
            this.btn_XuatHoaDon.BorderSize = 0;
            this.btn_XuatHoaDon.FlatAppearance.BorderSize = 0;
            this.btn_XuatHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XuatHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XuatHoaDon.ForeColor = System.Drawing.Color.White;
            this.btn_XuatHoaDon.Location = new System.Drawing.Point(608, 662);
            this.btn_XuatHoaDon.MaDatPhong = null;
            this.btn_XuatHoaDon.Name = "btn_XuatHoaDon";
            this.btn_XuatHoaDon.Size = new System.Drawing.Size(179, 51);
            this.btn_XuatHoaDon.TabIndex = 40;
            this.btn_XuatHoaDon.Text = "Xuất hoá đơn";
            this.btn_XuatHoaDon.TextColor = System.Drawing.Color.White;
            this.btn_XuatHoaDon.UseVisualStyleBackColor = false;
            this.btn_XuatHoaDon.Click += new System.EventHandler(this.btn_XuatHoaDon_Click);
            // 
            // txt_MaPhong
            // 
            this.txt_MaPhong.Location = new System.Drawing.Point(408, 151);
            this.txt_MaPhong.Name = "txt_MaPhong";
            this.txt_MaPhong.Size = new System.Drawing.Size(100, 22);
            this.txt_MaPhong.TabIndex = 41;
            this.txt_MaPhong.Visible = false;
            // 
            // txt_MaDatPhong
            // 
            this.txt_MaDatPhong.Location = new System.Drawing.Point(536, 151);
            this.txt_MaDatPhong.Name = "txt_MaDatPhong";
            this.txt_MaDatPhong.Size = new System.Drawing.Size(100, 22);
            this.txt_MaDatPhong.TabIndex = 42;
            this.txt_MaDatPhong.Visible = false;
            // 
            // XuatHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1029, 725);
            this.Controls.Add(this.btn_XuatHoaDon);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvHoaDon);
            this.Controls.Add(this.btn_HoanThanh);
            this.Controls.Add(this.dgvDatPhong);
            this.Controls.Add(this.dgvKH);
            this.Controls.Add(this.dgvCTDV);
            this.Controls.Add(this.rjTextBox6);
            this.Controls.Add(this.txt_MaDatPhong);
            this.Controls.Add(this.txt_MaPhong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "XuatHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XuatHoaDon";
            this.Load += new System.EventHandler(this.XuatHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCTDV;
        private System.Windows.Forms.DataGridView dgvKH;
        private System.Windows.Forms.DataGridView dgvDatPhong;
        private BC.Button2 btn_HoanThanh;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        public BC.RJTextBox rjTextBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private BC.Button2 btn_XuatHoaDon;
        public System.Windows.Forms.TextBox txt_MaPhong;
        public System.Windows.Forms.TextBox txt_MaDatPhong;
    }
}