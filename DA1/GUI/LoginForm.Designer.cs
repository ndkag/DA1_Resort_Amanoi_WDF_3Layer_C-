namespace GUI
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.loginButton = new GUI.BC.Button2();
            this.btn_Exit = new GUI.BC.Button2();
            this.txtPassword = new GUI.BC.RJTextBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuCheckBox1 = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.bunifuCheckBox2 = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.bunifuCheckBox3 = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.hienthimk = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.guna2CustomCheckBox1 = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new GUI.BC.RJTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Calligraphy", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.label3.Location = new System.Drawing.Point(96, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(323, 78);
            this.label3.TabIndex = 9;
            this.label3.Text = "Welcome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Magneto", 24F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(161, 156);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 48);
            this.label4.TabIndex = 10;
            this.label4.Text = "Amanoi";
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.loginButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.loginButton.BorderColor = System.Drawing.Color.Gray;
            this.loginButton.BorderRadius = 15;
            this.loginButton.BorderSize = 0;
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(57, 455);
            this.loginButton.MaDatPhong = null;
            this.loginButton.Margin = new System.Windows.Forms.Padding(4);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(401, 49);
            this.loginButton.TabIndex = 22;
            this.loginButton.Text = "Login";
            this.loginButton.TextColor = System.Drawing.Color.White;
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Exit.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_Exit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Exit.BorderRadius = 20;
            this.btn_Exit.BorderSize = 1;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btn_Exit.ForeColor = System.Drawing.Color.RosyBrown;
            this.btn_Exit.Location = new System.Drawing.Point(83, 525);
            this.btn_Exit.MaDatPhong = null;
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(349, 49);
            this.btn_Exit.TabIndex = 23;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.TextColor = System.Drawing.Color.RosyBrown;
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.txtPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.txtPassword.BorderRadius = 0;
            this.txtPassword.BorderSize = 2;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.txtPassword.Location = new System.Drawing.Point(94, 327);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPassword.PasswordChar = true;
            this.txtPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPassword.PlaceholderText = "Mật khẩu";
            this.txtPassword.Size = new System.Drawing.Size(364, 40);
            this.txtPassword.TabIndex = 20;
            this.txtPassword.Texts = "";
            this.txtPassword.UnderlinedStyle = true;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Location = new System.Drawing.Point(46, 329);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 34);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(46, 260);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 34);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuCheckBox1
            // 
            this.bunifuCheckBox1.AllowBindingControlAnimation = true;
            this.bunifuCheckBox1.AllowBindingControlColorChanges = false;
            this.bunifuCheckBox1.AllowBindingControlLocation = true;
            this.bunifuCheckBox1.AllowCheckBoxAnimation = false;
            this.bunifuCheckBox1.AllowCheckmarkAnimation = true;
            this.bunifuCheckBox1.AllowOnHoverStates = true;
            this.bunifuCheckBox1.AutoCheck = true;
            this.bunifuCheckBox1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCheckBox1.BackgroundImage")));
            this.bunifuCheckBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuCheckBox1.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.bunifuCheckBox1.BorderRadius = 12;
            this.bunifuCheckBox1.Checked = true;
            this.bunifuCheckBox1.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.bunifuCheckBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuCheckBox1.CustomCheckmarkImage = null;
            this.bunifuCheckBox1.Location = new System.Drawing.Point(-19, -19);
            this.bunifuCheckBox1.MinimumSize = new System.Drawing.Size(17, 17);
            this.bunifuCheckBox1.Name = "bunifuCheckBox1";
            this.bunifuCheckBox1.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuCheckBox1.OnCheck.BorderRadius = 12;
            this.bunifuCheckBox1.OnCheck.BorderThickness = 2;
            this.bunifuCheckBox1.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.bunifuCheckBox1.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.bunifuCheckBox1.OnCheck.CheckmarkThickness = 2;
            this.bunifuCheckBox1.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.bunifuCheckBox1.OnDisable.BorderRadius = 12;
            this.bunifuCheckBox1.OnDisable.BorderThickness = 2;
            this.bunifuCheckBox1.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox1.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.bunifuCheckBox1.OnDisable.CheckmarkThickness = 2;
            this.bunifuCheckBox1.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuCheckBox1.OnHoverChecked.BorderRadius = 12;
            this.bunifuCheckBox1.OnHoverChecked.BorderThickness = 2;
            this.bunifuCheckBox1.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuCheckBox1.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.bunifuCheckBox1.OnHoverChecked.CheckmarkThickness = 2;
            this.bunifuCheckBox1.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuCheckBox1.OnHoverUnchecked.BorderRadius = 12;
            this.bunifuCheckBox1.OnHoverUnchecked.BorderThickness = 1;
            this.bunifuCheckBox1.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox1.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.bunifuCheckBox1.OnUncheck.BorderRadius = 12;
            this.bunifuCheckBox1.OnUncheck.BorderThickness = 1;
            this.bunifuCheckBox1.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox1.Size = new System.Drawing.Size(21, 21);
            this.bunifuCheckBox1.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.bunifuCheckBox1.TabIndex = 22;
            this.bunifuCheckBox1.ThreeState = false;
            this.bunifuCheckBox1.ToolTipText = null;
            // 
            // bunifuCheckBox2
            // 
            this.bunifuCheckBox2.AllowBindingControlAnimation = true;
            this.bunifuCheckBox2.AllowBindingControlColorChanges = false;
            this.bunifuCheckBox2.AllowBindingControlLocation = true;
            this.bunifuCheckBox2.AllowCheckBoxAnimation = false;
            this.bunifuCheckBox2.AllowCheckmarkAnimation = true;
            this.bunifuCheckBox2.AllowOnHoverStates = true;
            this.bunifuCheckBox2.AutoCheck = true;
            this.bunifuCheckBox2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCheckBox2.BackgroundImage")));
            this.bunifuCheckBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuCheckBox2.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.bunifuCheckBox2.BorderRadius = 12;
            this.bunifuCheckBox2.Checked = true;
            this.bunifuCheckBox2.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.bunifuCheckBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuCheckBox2.CustomCheckmarkImage = null;
            this.bunifuCheckBox2.Location = new System.Drawing.Point(-19, -19);
            this.bunifuCheckBox2.MinimumSize = new System.Drawing.Size(17, 17);
            this.bunifuCheckBox2.Name = "bunifuCheckBox2";
            this.bunifuCheckBox2.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuCheckBox2.OnCheck.BorderRadius = 12;
            this.bunifuCheckBox2.OnCheck.BorderThickness = 2;
            this.bunifuCheckBox2.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.bunifuCheckBox2.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.bunifuCheckBox2.OnCheck.CheckmarkThickness = 2;
            this.bunifuCheckBox2.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.bunifuCheckBox2.OnDisable.BorderRadius = 12;
            this.bunifuCheckBox2.OnDisable.BorderThickness = 2;
            this.bunifuCheckBox2.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox2.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.bunifuCheckBox2.OnDisable.CheckmarkThickness = 2;
            this.bunifuCheckBox2.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuCheckBox2.OnHoverChecked.BorderRadius = 12;
            this.bunifuCheckBox2.OnHoverChecked.BorderThickness = 2;
            this.bunifuCheckBox2.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuCheckBox2.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.bunifuCheckBox2.OnHoverChecked.CheckmarkThickness = 2;
            this.bunifuCheckBox2.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuCheckBox2.OnHoverUnchecked.BorderRadius = 12;
            this.bunifuCheckBox2.OnHoverUnchecked.BorderThickness = 1;
            this.bunifuCheckBox2.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox2.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.bunifuCheckBox2.OnUncheck.BorderRadius = 12;
            this.bunifuCheckBox2.OnUncheck.BorderThickness = 1;
            this.bunifuCheckBox2.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox2.Size = new System.Drawing.Size(21, 21);
            this.bunifuCheckBox2.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.bunifuCheckBox2.TabIndex = 23;
            this.bunifuCheckBox2.ThreeState = false;
            this.bunifuCheckBox2.ToolTipText = null;
            // 
            // bunifuCheckBox3
            // 
            this.bunifuCheckBox3.AllowBindingControlAnimation = true;
            this.bunifuCheckBox3.AllowBindingControlColorChanges = false;
            this.bunifuCheckBox3.AllowBindingControlLocation = true;
            this.bunifuCheckBox3.AllowCheckBoxAnimation = false;
            this.bunifuCheckBox3.AllowCheckmarkAnimation = true;
            this.bunifuCheckBox3.AllowOnHoverStates = true;
            this.bunifuCheckBox3.AutoCheck = true;
            this.bunifuCheckBox3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCheckBox3.BackgroundImage")));
            this.bunifuCheckBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuCheckBox3.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.bunifuCheckBox3.BorderRadius = 12;
            this.bunifuCheckBox3.Checked = true;
            this.bunifuCheckBox3.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.bunifuCheckBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuCheckBox3.CustomCheckmarkImage = null;
            this.bunifuCheckBox3.Location = new System.Drawing.Point(-19, -19);
            this.bunifuCheckBox3.MinimumSize = new System.Drawing.Size(17, 17);
            this.bunifuCheckBox3.Name = "bunifuCheckBox3";
            this.bunifuCheckBox3.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuCheckBox3.OnCheck.BorderRadius = 12;
            this.bunifuCheckBox3.OnCheck.BorderThickness = 2;
            this.bunifuCheckBox3.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.bunifuCheckBox3.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.bunifuCheckBox3.OnCheck.CheckmarkThickness = 2;
            this.bunifuCheckBox3.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.bunifuCheckBox3.OnDisable.BorderRadius = 12;
            this.bunifuCheckBox3.OnDisable.BorderThickness = 2;
            this.bunifuCheckBox3.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox3.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.bunifuCheckBox3.OnDisable.CheckmarkThickness = 2;
            this.bunifuCheckBox3.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuCheckBox3.OnHoverChecked.BorderRadius = 12;
            this.bunifuCheckBox3.OnHoverChecked.BorderThickness = 2;
            this.bunifuCheckBox3.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuCheckBox3.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.bunifuCheckBox3.OnHoverChecked.CheckmarkThickness = 2;
            this.bunifuCheckBox3.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuCheckBox3.OnHoverUnchecked.BorderRadius = 12;
            this.bunifuCheckBox3.OnHoverUnchecked.BorderThickness = 1;
            this.bunifuCheckBox3.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox3.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.bunifuCheckBox3.OnUncheck.BorderRadius = 12;
            this.bunifuCheckBox3.OnUncheck.BorderThickness = 1;
            this.bunifuCheckBox3.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox3.Size = new System.Drawing.Size(21, 21);
            this.bunifuCheckBox3.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.bunifuCheckBox3.TabIndex = 24;
            this.bunifuCheckBox3.ThreeState = false;
            this.bunifuCheckBox3.ToolTipText = null;
            // 
            // hienthimk
            // 
            this.hienthimk.AllowBindingControlAnimation = true;
            this.hienthimk.AllowBindingControlColorChanges = false;
            this.hienthimk.AllowBindingControlLocation = true;
            this.hienthimk.AllowCheckBoxAnimation = false;
            this.hienthimk.AllowCheckmarkAnimation = true;
            this.hienthimk.AllowOnHoverStates = true;
            this.hienthimk.AutoCheck = true;
            this.hienthimk.BackColor = System.Drawing.Color.Transparent;
            this.hienthimk.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hienthimk.BackgroundImage")));
            this.hienthimk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.hienthimk.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.hienthimk.BorderRadius = 12;
            this.hienthimk.Checked = false;
            this.hienthimk.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            this.hienthimk.Cursor = System.Windows.Forms.Cursors.Default;
            this.hienthimk.CustomCheckmarkImage = null;
            this.hienthimk.Location = new System.Drawing.Point(94, 374);
            this.hienthimk.MinimumSize = new System.Drawing.Size(17, 17);
            this.hienthimk.Name = "hienthimk";
            this.hienthimk.OnCheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.hienthimk.OnCheck.BorderRadius = 12;
            this.hienthimk.OnCheck.BorderThickness = 2;
            this.hienthimk.OnCheck.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.hienthimk.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.hienthimk.OnCheck.CheckmarkThickness = 2;
            this.hienthimk.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.hienthimk.OnDisable.BorderRadius = 12;
            this.hienthimk.OnDisable.BorderThickness = 2;
            this.hienthimk.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.hienthimk.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.hienthimk.OnDisable.CheckmarkThickness = 2;
            this.hienthimk.OnHoverChecked.BorderColor = System.Drawing.Color.Gray;
            this.hienthimk.OnHoverChecked.BorderRadius = 12;
            this.hienthimk.OnHoverChecked.BorderThickness = 2;
            this.hienthimk.OnHoverChecked.CheckBoxColor = System.Drawing.Color.Gray;
            this.hienthimk.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.hienthimk.OnHoverChecked.CheckmarkThickness = 2;
            this.hienthimk.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.hienthimk.OnHoverUnchecked.BorderRadius = 12;
            this.hienthimk.OnHoverUnchecked.BorderThickness = 1;
            this.hienthimk.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.hienthimk.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.hienthimk.OnUncheck.BorderRadius = 12;
            this.hienthimk.OnUncheck.BorderThickness = 1;
            this.hienthimk.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.hienthimk.Size = new System.Drawing.Size(27, 27);
            this.hienthimk.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.hienthimk.TabIndex = 21;
            this.hienthimk.ThreeState = false;
            this.hienthimk.ToolTipText = "";
            this.hienthimk.CheckedChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs>(this.hienthimk_CheckedChanged);
            // 
            // guna2CustomCheckBox1
            // 
            this.guna2CustomCheckBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CustomCheckBox1.CheckedState.BorderRadius = 2;
            this.guna2CustomCheckBox1.CheckedState.BorderThickness = 0;
            this.guna2CustomCheckBox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CustomCheckBox1.Location = new System.Drawing.Point(-19, -19);
            this.guna2CustomCheckBox1.Name = "guna2CustomCheckBox1";
            this.guna2CustomCheckBox1.Size = new System.Drawing.Size(20, 20);
            this.guna2CustomCheckBox1.TabIndex = 26;
            this.guna2CustomCheckBox1.Text = "guna2CustomCheckBox1";
            this.guna2CustomCheckBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CustomCheckBox1.UncheckedState.BorderRadius = 2;
            this.guna2CustomCheckBox1.UncheckedState.BorderThickness = 0;
            this.guna2CustomCheckBox1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(126, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 22);
            this.label1.TabIndex = 27;
            this.label1.Text = "Hiển thị mật khẩu";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.txtUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsername.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.txtUsername.BorderRadius = 0;
            this.txtUsername.BorderSize = 2;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.txtUsername.Location = new System.Drawing.Point(94, 258);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtUsername.PasswordChar = false;
            this.txtUsername.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUsername.PlaceholderText = "Tài khoản";
            this.txtUsername.Size = new System.Drawing.Size(364, 40);
            this.txtUsername.TabIndex = 19;
            this.txtUsername.Texts = "";
            this.txtUsername.UnderlinedStyle = true;
            this.txtUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsername_KeyPress);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.loginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1177, 783);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2CustomCheckBox1);
            this.Controls.Add(this.hienthimk);
            this.Controls.Add(this.bunifuCheckBox3);
            this.Controls.Add(this.bunifuCheckBox2);
            this.Controls.Add(this.bunifuCheckBox1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ad";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private BC.Button2 loginButton;
        private BC.Button2 btn_Exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private BC.RJTextBox txtPassword;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2CustomCheckBox guna2CustomCheckBox1;
        private Bunifu.UI.WinForms.BunifuCheckBox hienthimk;
        private Bunifu.UI.WinForms.BunifuCheckBox bunifuCheckBox3;
        private Bunifu.UI.WinForms.BunifuCheckBox bunifuCheckBox2;
        private Bunifu.UI.WinForms.BunifuCheckBox bunifuCheckBox1;
        private System.Windows.Forms.Label label1;
        public BC.RJTextBox txtUsername;
    }
}