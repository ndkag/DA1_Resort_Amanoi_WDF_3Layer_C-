namespace GUI.Báo_cáo_thống_kê
{
    partial class BCTK_HoaDon
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.chart_Thang = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ThongKe = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Xuat_BC = new Guna.UI2.WinForms.Guna2Button();
            this.cbb_nam = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbb_Thang = new Guna.UI2.WinForms.Guna2ComboBox();
            this.chart_Nam = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.rjTextBox1 = new GUI.BC.RJTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Thang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Nam)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 40;
            this.bunifuElipse1.TargetControl = this.panel3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.Controls.Add(this.chart_Thang);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btn_ThongKe);
            this.panel3.Controls.Add(this.btn_Xuat_BC);
            this.panel3.Controls.Add(this.cbb_nam);
            this.panel3.Controls.Add(this.cbb_Thang);
            this.panel3.Controls.Add(this.chart_Nam);
            this.panel3.Controls.Add(this.rjTextBox1);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(30, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1424, 737);
            this.panel3.TabIndex = 17;
            // 
            // chart_Thang
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_Thang.ChartAreas.Add(chartArea1);
            this.chart_Thang.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend1.Name = "Legend1";
            this.chart_Thang.Legends.Add(legend1);
            this.chart_Thang.Location = new System.Drawing.Point(0, 449);
            this.chart_Thang.Name = "chart_Thang";
            this.chart_Thang.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Doanh thu";
            this.chart_Thang.Series.Add(series1);
            this.chart_Thang.Size = new System.Drawing.Size(1424, 288);
            this.chart_Thang.TabIndex = 89;
            this.chart_Thang.Text = "chart1";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.panel6.Location = new System.Drawing.Point(22, 14);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(6, 62);
            this.panel6.TabIndex = 87;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.panel5.Location = new System.Drawing.Point(34, 419);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1344, 4);
            this.panel5.TabIndex = 83;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(216, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 29);
            this.label2.TabIndex = 82;
            this.label2.Text = "Năm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(206, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 29);
            this.label1.TabIndex = 81;
            this.label1.Text = "Tháng";
            // 
            // btn_ThongKe
            // 
            this.btn_ThongKe.BorderColor = System.Drawing.Color.White;
            this.btn_ThongKe.BorderRadius = 15;
            this.btn_ThongKe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ThongKe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ThongKe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ThongKe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ThongKe.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.btn_ThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThongKe.ForeColor = System.Drawing.Color.White;
            this.btn_ThongKe.Image = global::GUI.Properties.Resources.icons8_cloud_bar_chart_48px_1;
            this.btn_ThongKe.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_ThongKe.Location = new System.Drawing.Point(264, 339);
            this.btn_ThongKe.Name = "btn_ThongKe";
            this.btn_ThongKe.Size = new System.Drawing.Size(195, 56);
            this.btn_ThongKe.TabIndex = 66;
            this.btn_ThongKe.Text = "Thống kê";
            this.btn_ThongKe.Click += new System.EventHandler(this.btn_ThongKe_Click);
            // 
            // btn_Xuat_BC
            // 
            this.btn_Xuat_BC.BorderColor = System.Drawing.Color.White;
            this.btn_Xuat_BC.BorderRadius = 15;
            this.btn_Xuat_BC.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Xuat_BC.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Xuat_BC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Xuat_BC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Xuat_BC.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.btn_Xuat_BC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xuat_BC.ForeColor = System.Drawing.Color.White;
            this.btn_Xuat_BC.Image = global::GUI.Properties.Resources.icons8_Add_Pie_Chart_Report_60px_1;
            this.btn_Xuat_BC.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_Xuat_BC.Location = new System.Drawing.Point(55, 339);
            this.btn_Xuat_BC.Name = "btn_Xuat_BC";
            this.btn_Xuat_BC.Size = new System.Drawing.Size(195, 56);
            this.btn_Xuat_BC.TabIndex = 65;
            this.btn_Xuat_BC.Text = "Báo cáo";
            this.btn_Xuat_BC.Click += new System.EventHandler(this.btn_Xuat_BC_Click);
            // 
            // cbb_nam
            // 
            this.cbb_nam.BackColor = System.Drawing.Color.Transparent;
            this.cbb_nam.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbb_nam.BorderRadius = 10;
            this.cbb_nam.BorderThickness = 2;
            this.cbb_nam.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_nam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_nam.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_nam.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_nam.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.cbb_nam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbb_nam.ItemHeight = 40;
            this.cbb_nam.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029"});
            this.cbb_nam.Location = new System.Drawing.Point(111, 166);
            this.cbb_nam.Name = "cbb_nam";
            this.cbb_nam.Size = new System.Drawing.Size(293, 46);
            this.cbb_nam.TabIndex = 5;
            // 
            // cbb_Thang
            // 
            this.cbb_Thang.BackColor = System.Drawing.Color.Transparent;
            this.cbb_Thang.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbb_Thang.BorderRadius = 10;
            this.cbb_Thang.BorderThickness = 2;
            this.cbb_Thang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_Thang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Thang.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_Thang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_Thang.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_Thang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbb_Thang.ItemHeight = 40;
            this.cbb_Thang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbb_Thang.Location = new System.Drawing.Point(111, 259);
            this.cbb_Thang.Name = "cbb_Thang";
            this.cbb_Thang.Size = new System.Drawing.Size(293, 46);
            this.cbb_Thang.TabIndex = 4;
            // 
            // chart_Nam
            // 
            chartArea2.Name = "ChartArea1";
            this.chart_Nam.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart_Nam.Legends.Add(legend2);
            this.chart_Nam.Location = new System.Drawing.Point(561, 104);
            this.chart_Nam.Name = "chart_Nam";
            this.chart_Nam.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Doanh thu";
            this.chart_Nam.Series.Add(series2);
            this.chart_Nam.Size = new System.Drawing.Size(817, 309);
            this.chart_Nam.TabIndex = 2;
            this.chart_Nam.Text = "chart1";
            // 
            // rjTextBox1
            // 
            this.rjTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.rjTextBox1.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.rjTextBox1.BorderRadius = 15;
            this.rjTextBox1.BorderSize = 3;
            this.rjTextBox1.Enabled = false;
            this.rjTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.rjTextBox1.Location = new System.Drawing.Point(39, 104);
            this.rjTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox1.Multiline = true;
            this.rjTextBox1.Name = "rjTextBox1";
            this.rjTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox1.PasswordChar = false;
            this.rjTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox1.PlaceholderText = "";
            this.rjTextBox1.Size = new System.Drawing.Size(438, 305);
            this.rjTextBox1.TabIndex = 70;
            this.rjTextBox1.Texts = "";
            this.rjTextBox1.UnderlinedStyle = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 28.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.label9.Location = new System.Drawing.Point(22, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(397, 52);
            this.label9.TabIndex = 90;
            this.label9.Text = "Báo Cáo Thống Kê";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1454, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(30, 737);
            this.panel2.TabIndex = 16;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel1.Location = new System.Drawing.Point(30, 762);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1454, 25);
            this.guna2Panel1.TabIndex = 15;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel3.Location = new System.Drawing.Point(30, 0);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(1454, 25);
            this.guna2Panel3.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(30, 787);
            this.panel1.TabIndex = 13;
            // 
            // BCTK_HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.Nền2;
            this.ClientSize = new System.Drawing.Size(1484, 787);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.panel1);
            this.Name = "BCTK_HoaDon";
            this.Text = "BCTK_HoaDon";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Thang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Nam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_ThongKe;
        private Guna.UI2.WinForms.Guna2Button btn_Xuat_BC;
        private Guna.UI2.WinForms.Guna2ComboBox cbb_nam;
        private Guna.UI2.WinForms.Guna2ComboBox cbb_Thang;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Nam;
        private BC.RJTextBox rjTextBox1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Thang;
        private System.Windows.Forms.Label label9;
    }
}