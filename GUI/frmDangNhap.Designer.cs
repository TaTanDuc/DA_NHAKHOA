namespace GUI
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.gntxtTaiKhoan = new Guna.UI2.WinForms.Guna2TextBox();
            this.gntxtMatKhau = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ToggleSwitchLuuThongTin = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.gnbtnDangNhap = new Guna.UI2.WinForms.Guna2Button();
            this.gnbtnThoat = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.guna2Panel1;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(-58, -48);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(480, 489);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(74, 12);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(132, 97);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 1;
            this.guna2PictureBox2.TabStop = false;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2Panel1.Controls.Add(this.gnbtnThoat);
            this.guna2Panel1.Controls.Add(this.gnbtnDangNhap);
            this.guna2Panel1.Controls.Add(this.linkLabel1);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.guna2ToggleSwitchLuuThongTin);
            this.guna2Panel1.Controls.Add(this.gntxtMatKhau);
            this.guna2Panel1.Controls.Add(this.gntxtTaiKhoan);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox2);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(282, 376);
            this.guna2Panel1.TabIndex = 2;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Panel2.Location = new System.Drawing.Point(270, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(383, 376);
            this.guna2Panel2.TabIndex = 3;
            // 
            // gntxtTaiKhoan
            // 
            this.gntxtTaiKhoan.Animated = true;
            this.gntxtTaiKhoan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.gntxtTaiKhoan.BorderRadius = 6;
            this.gntxtTaiKhoan.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.gntxtTaiKhoan.BorderThickness = 2;
            this.gntxtTaiKhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gntxtTaiKhoan.DefaultText = "";
            this.gntxtTaiKhoan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gntxtTaiKhoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gntxtTaiKhoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gntxtTaiKhoan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gntxtTaiKhoan.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.gntxtTaiKhoan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gntxtTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gntxtTaiKhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.gntxtTaiKhoan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gntxtTaiKhoan.Location = new System.Drawing.Point(22, 158);
            this.gntxtTaiKhoan.Name = "gntxtTaiKhoan";
            this.gntxtTaiKhoan.PasswordChar = '\0';
            this.gntxtTaiKhoan.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.gntxtTaiKhoan.PlaceholderText = "";
            this.gntxtTaiKhoan.SelectedText = "";
            this.gntxtTaiKhoan.Size = new System.Drawing.Size(228, 26);
            this.gntxtTaiKhoan.TabIndex = 2;
            // 
            // gntxtMatKhau
            // 
            this.gntxtMatKhau.Animated = true;
            this.gntxtMatKhau.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.gntxtMatKhau.BorderRadius = 6;
            this.gntxtMatKhau.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.gntxtMatKhau.BorderThickness = 2;
            this.gntxtMatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gntxtMatKhau.DefaultText = "";
            this.gntxtMatKhau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gntxtMatKhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gntxtMatKhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gntxtMatKhau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gntxtMatKhau.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.gntxtMatKhau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gntxtMatKhau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gntxtMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.gntxtMatKhau.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gntxtMatKhau.Location = new System.Drawing.Point(22, 190);
            this.gntxtMatKhau.Name = "gntxtMatKhau";
            this.gntxtMatKhau.PasswordChar = '●';
            this.gntxtMatKhau.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.gntxtMatKhau.PlaceholderText = "";
            this.gntxtMatKhau.SelectedText = "";
            this.gntxtMatKhau.Size = new System.Drawing.Size(228, 26);
            this.gntxtMatKhau.TabIndex = 2;
            this.gntxtMatKhau.UseSystemPasswordChar = true;
            // 
            // guna2ToggleSwitchLuuThongTin
            // 
            this.guna2ToggleSwitchLuuThongTin.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitchLuuThongTin.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitchLuuThongTin.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitchLuuThongTin.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitchLuuThongTin.Location = new System.Drawing.Point(22, 222);
            this.guna2ToggleSwitchLuuThongTin.Name = "guna2ToggleSwitchLuuThongTin";
            this.guna2ToggleSwitchLuuThongTin.Size = new System.Drawing.Size(30, 18);
            this.guna2ToggleSwitchLuuThongTin.TabIndex = 3;
            this.guna2ToggleSwitchLuuThongTin.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitchLuuThongTin.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitchLuuThongTin.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitchLuuThongTin.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lưu đăng nhập";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(164, 227);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(86, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Quên mật khẩu?";
            // 
            // gnbtnDangNhap
            // 
            this.gnbtnDangNhap.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.gnbtnDangNhap.BorderRadius = 6;
            this.gnbtnDangNhap.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.gnbtnDangNhap.BorderThickness = 2;
            this.gnbtnDangNhap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gnbtnDangNhap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gnbtnDangNhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gnbtnDangNhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gnbtnDangNhap.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.gnbtnDangNhap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gnbtnDangNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.gnbtnDangNhap.Location = new System.Drawing.Point(22, 265);
            this.gnbtnDangNhap.Name = "gnbtnDangNhap";
            this.gnbtnDangNhap.Size = new System.Drawing.Size(87, 22);
            this.gnbtnDangNhap.TabIndex = 6;
            this.gnbtnDangNhap.Text = "Đăng nhập";
            this.gnbtnDangNhap.Click += new System.EventHandler(this.gnbtnDangNhap_Click);
            // 
            // gnbtnThoat
            // 
            this.gnbtnThoat.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.gnbtnThoat.BorderRadius = 6;
            this.gnbtnThoat.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.gnbtnThoat.BorderThickness = 2;
            this.gnbtnThoat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gnbtnThoat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gnbtnThoat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gnbtnThoat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gnbtnThoat.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.gnbtnThoat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gnbtnThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.gnbtnThoat.Location = new System.Drawing.Point(156, 265);
            this.gnbtnThoat.Name = "gnbtnThoat";
            this.gnbtnThoat.Size = new System.Drawing.Size(94, 22);
            this.gnbtnThoat.TabIndex = 6;
            this.gnbtnThoat.Text = "Thoát";
            this.gnbtnThoat.Click += new System.EventHandler(this.gnbtnThoat_Click);
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 376);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Button gnbtnThoat;
        private Guna.UI2.WinForms.Guna2Button gnbtnDangNhap;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitchLuuThongTin;
        private Guna.UI2.WinForms.Guna2TextBox gntxtMatKhau;
        private Guna.UI2.WinForms.Guna2TextBox gntxtTaiKhoan;
    }
}

