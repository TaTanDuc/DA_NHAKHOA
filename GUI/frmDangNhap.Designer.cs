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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            this.grbDangNhap = new System.Windows.Forms.GroupBox();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.lblTaiKhoan = new System.Windows.Forms.Label();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tolstxtMatMa = new System.Windows.Forms.ToolStripTextBox();
            this.tolsbtnMatMa = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tolstxtTenDangNhap = new System.Windows.Forms.ToolStripTextBox();
            this.tlsbtnTenDangNhap = new System.Windows.Forms.ToolStripButton();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ptbQC = new System.Windows.Forms.PictureBox();
            this.ptbLogo = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grbDangNhap.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbQC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // grbDangNhap
            // 
            this.grbDangNhap.Controls.Add(this.lblMatKhau);
            this.grbDangNhap.Controls.Add(this.lblTaiKhoan);
            this.grbDangNhap.Controls.Add(this.toolStrip2);
            this.grbDangNhap.Controls.Add(this.toolStrip1);
            this.grbDangNhap.Controls.Add(this.btnDangNhap);
            this.grbDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.grbDangNhap.Location = new System.Drawing.Point(266, 66);
            this.grbDangNhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbDangNhap.Name = "grbDangNhap";
            this.grbDangNhap.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbDangNhap.Size = new System.Drawing.Size(374, 497);
            this.grbDangNhap.TabIndex = 0;
            this.grbDangNhap.TabStop = false;
            this.grbDangNhap.Text = "Đăng nhập";
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Location = new System.Drawing.Point(9, 191);
            this.lblMatKhau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(101, 25);
            this.lblMatKhau.TabIndex = 1;
            this.lblMatKhau.Text = "Mật khẩu";
            // 
            // lblTaiKhoan
            // 
            this.lblTaiKhoan.AutoSize = true;
            this.lblTaiKhoan.Location = new System.Drawing.Point(9, 52);
            this.lblTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTaiKhoan.Name = "lblTaiKhoan";
            this.lblTaiKhoan.Size = new System.Drawing.Size(107, 25);
            this.lblTaiKhoan.TabIndex = 1;
            this.lblTaiKhoan.Text = "Tài khoản";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tolstxtMatMa,
            this.tolsbtnMatMa});
            this.toolStrip2.Location = new System.Drawing.Point(4, 235);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip2.Size = new System.Drawing.Size(355, 33);
            this.toolStrip2.TabIndex = 3;
            this.toolStrip2.Text = "toolStrip1";
            this.toolStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // tolstxtMatMa
            // 
            this.tolstxtMatMa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tolstxtMatMa.Name = "tolstxtMatMa";
            this.tolstxtMatMa.Size = new System.Drawing.Size(298, 33);
            // 
            // tolsbtnMatMa
            // 
            this.tolsbtnMatMa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tolsbtnMatMa.Image = ((System.Drawing.Image)(resources.GetObject("tolsbtnMatMa.Image")));
            this.tolsbtnMatMa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tolsbtnMatMa.Name = "tolsbtnMatMa";
            this.tolsbtnMatMa.Size = new System.Drawing.Size(34, 28);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tolstxtTenDangNhap,
            this.tlsbtnTenDangNhap});
            this.toolStrip1.Location = new System.Drawing.Point(4, 94);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(355, 33);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // tolstxtTenDangNhap
            // 
            this.tolstxtTenDangNhap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tolstxtTenDangNhap.Name = "tolstxtTenDangNhap";
            this.tolstxtTenDangNhap.Size = new System.Drawing.Size(298, 33);
            this.tolstxtTenDangNhap.Click += new System.EventHandler(this.tolstxtTenDangNhap_Click);
            // 
            // tlsbtnTenDangNhap
            // 
            this.tlsbtnTenDangNhap.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsbtnTenDangNhap.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tlsbtnTenDangNhap.Image = ((System.Drawing.Image)(resources.GetObject("tlsbtnTenDangNhap.Image")));
            this.tlsbtnTenDangNhap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsbtnTenDangNhap.Name = "tlsbtnTenDangNhap";
            this.tlsbtnTenDangNhap.Size = new System.Drawing.Size(34, 28);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Location = new System.Drawing.Point(14, 352);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(346, 78);
            this.btnDangNhap.TabIndex = 2;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTieuDe.Location = new System.Drawing.Point(18, 122);
            this.lblTieuDe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(227, 36);
            this.lblTieuDe.TabIndex = 1;
            this.lblTieuDe.Text = "  Cổng thông tin";
            this.lblTieuDe.Click += new System.EventHandler(this.lblTieuDe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(58, 160);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "  dịch vụ";
            this.label1.Click += new System.EventHandler(this.lblTieuDe_Click);
            // 
            // ptbQC
            // 
            this.ptbQC.Image = ((System.Drawing.Image)(resources.GetObject("ptbQC.Image")));
            this.ptbQC.Location = new System.Drawing.Point(24, 228);
            this.ptbQC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ptbQC.Name = "ptbQC";
            this.ptbQC.Size = new System.Drawing.Size(216, 291);
            this.ptbQC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbQC.TabIndex = 3;
            this.ptbQC.TabStop = false;
            // 
            // ptbLogo
            // 
            this.ptbLogo.Image = ((System.Drawing.Image)(resources.GetObject("ptbLogo.Image")));
            this.ptbLogo.Location = new System.Drawing.Point(-6, -15);
            this.ptbLogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ptbLogo.Name = "ptbLogo";
            this.ptbLogo.Size = new System.Drawing.Size(114, 108);
            this.ptbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbLogo.TabIndex = 4;
            this.ptbLogo.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(114, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Phòng khám nha khoa";
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 572);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ptbLogo);
            this.Controls.Add(this.ptbQC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.grbDangNhap);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDangNhap";
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            this.grbDangNhap.ResumeLayout(false);
            this.grbDangNhap.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbQC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDangNhap;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.ToolStripTextBox tolstxtTenDangNhap;
        private System.Windows.Forms.ToolStripButton tlsbtnTenDangNhap;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripTextBox tolstxtMatMa;
        private System.Windows.Forms.ToolStripButton tolsbtnMatMa;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.Label lblTaiKhoan;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ptbQC;
        private System.Windows.Forms.PictureBox ptbLogo;
        private System.Windows.Forms.Label label2;
    }
}

