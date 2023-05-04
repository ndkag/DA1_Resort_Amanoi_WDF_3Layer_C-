namespace GUI
{
    partial class Test_Xuat_HD
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
            this.XuatHD = new System.Windows.Forms.Button();
            this.txt_MaDP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // XuatHD
            // 
            this.XuatHD.Location = new System.Drawing.Point(282, 284);
            this.XuatHD.Name = "XuatHD";
            this.XuatHD.Size = new System.Drawing.Size(75, 23);
            this.XuatHD.TabIndex = 0;
            this.XuatHD.Text = "button1";
            this.XuatHD.UseVisualStyleBackColor = true;
            this.XuatHD.Click += new System.EventHandler(this.XuatHD_Click);
            // 
            // txt_MaDP
            // 
            this.txt_MaDP.Location = new System.Drawing.Point(282, 129);
            this.txt_MaDP.Name = "txt_MaDP";
            this.txt_MaDP.Size = new System.Drawing.Size(100, 22);
            this.txt_MaDP.TabIndex = 1;
            // 
            // Test_Xuat_HD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_MaDP);
            this.Controls.Add(this.XuatHD);
            this.Name = "Test_Xuat_HD";
            this.Text = "Test_Xuat_HD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button XuatHD;
        private System.Windows.Forms.TextBox txt_MaDP;
    }
}