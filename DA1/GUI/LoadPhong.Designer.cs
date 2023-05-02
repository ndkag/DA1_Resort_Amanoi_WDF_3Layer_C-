namespace GUI
{
    partial class LoadPhong
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
            this.panelTieuDe = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.formchildForm = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_DatP = new Guna.UI2.WinForms.Guna2Button();
            this.panelTieuDe.SuspendLayout();
            this.formchildForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTieuDe
            // 
            this.panelTieuDe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.panelTieuDe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTieuDe.Controls.Add(this.btn_DatP);
            this.panelTieuDe.Controls.Add(this.panel1);
            this.panelTieuDe.Controls.Add(this.label1);
            this.panelTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTieuDe.Location = new System.Drawing.Point(0, 0);
            this.panelTieuDe.Name = "panelTieuDe";
            this.panelTieuDe.Size = new System.Drawing.Size(1113, 87);
            this.panelTieuDe.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(12, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(7, 60);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH PHÒNG";
            // 
            // formchildForm
            // 
            this.formchildForm.BackColor = System.Drawing.Color.White;
            this.formchildForm.Controls.Add(this.flowLayoutPanel1);
            this.formchildForm.Controls.Add(this.panelTieuDe);
            this.formchildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formchildForm.Location = new System.Drawing.Point(0, 0);
            this.formchildForm.Name = "formchildForm";
            this.formchildForm.Size = new System.Drawing.Size(1113, 666);
            this.formchildForm.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 87);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1113, 579);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // btn_DatP
            // 
            this.btn_DatP.BorderColor = System.Drawing.Color.White;
            this.btn_DatP.BorderRadius = 15;
            this.btn_DatP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_DatP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_DatP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_DatP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_DatP.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_DatP.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.btn_DatP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DatP.ForeColor = System.Drawing.Color.White;
            this.btn_DatP.Image = global::GUI.Properties.Resources.icons8_Close_64px_2;
            this.btn_DatP.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_DatP.Location = new System.Drawing.Point(1044, 0);
            this.btn_DatP.Name = "btn_DatP";
            this.btn_DatP.Size = new System.Drawing.Size(69, 87);
            this.btn_DatP.TabIndex = 65;
            this.btn_DatP.Click += new System.EventHandler(this.btn_DatP_Click);
            // 
            // LoadPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(192)))), ((int)(((byte)(188)))));
            this.ClientSize = new System.Drawing.Size(1113, 666);
            this.Controls.Add(this.formchildForm);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "LoadPhong";
            this.Text = "LoadPhong";
            this.panelTieuDe.ResumeLayout(false);
            this.panelTieuDe.PerformLayout();
            this.formchildForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTieuDe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel formchildForm;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button btn_DatP;
    }
}