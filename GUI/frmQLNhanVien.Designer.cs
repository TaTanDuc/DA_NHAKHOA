namespace GUI
{
    partial class frmQLNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLNhanVien));
            this.dgvDSNhanVien = new System.Windows.Forms.DataGridView();
            this.colCustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPassWord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbThongTin = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtDT = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tlsbtnThem = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip7 = new System.Windows.Forms.ToolStrip();
            this.tlsbtnXoa = new System.Windows.Forms.ToolStripButton();
            this.lblXoa = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip8 = new System.Windows.Forms.ToolStrip();
            this.tlsbtnThoat = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip9 = new System.Windows.Forms.ToolStrip();
            this.tlsbtnSua = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNhanVien)).BeginInit();
            this.grbThongTin.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip7.SuspendLayout();
            this.toolStrip8.SuspendLayout();
            this.toolStrip9.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDSNhanVien
            // 
            this.dgvDSNhanVien.AllowUserToAddRows = false;
            this.dgvDSNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCustomerID,
            this.colFullName,
            this.colPhone,
            this.colPassWord});
            this.dgvDSNhanVien.Location = new System.Drawing.Point(320, 146);
            this.dgvDSNhanVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDSNhanVien.Name = "dgvDSNhanVien";
            this.dgvDSNhanVien.RowHeadersWidth = 51;
            this.dgvDSNhanVien.Size = new System.Drawing.Size(557, 335);
            this.dgvDSNhanVien.TabIndex = 12;
            this.dgvDSNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // colCustomerID
            // 
            this.colCustomerID.HeaderText = "Mã nhân viên";
            this.colCustomerID.MinimumWidth = 6;
            this.colCustomerID.Name = "colCustomerID";
            this.colCustomerID.Width = 125;
            // 
            // colFullName
            // 
            this.colFullName.HeaderText = "Tên nhân viên";
            this.colFullName.MinimumWidth = 6;
            this.colFullName.Name = "colFullName";
            this.colFullName.Width = 125;
            // 
            // colPhone
            // 
            this.colPhone.HeaderText = "Số điện thoại";
            this.colPhone.MinimumWidth = 6;
            this.colPhone.Name = "colPhone";
            this.colPhone.Width = 125;
            // 
            // colPassWord
            // 
            this.colPassWord.HeaderText = "Mật khẩu";
            this.colPassWord.MinimumWidth = 6;
            this.colPassWord.Name = "colPassWord";
            this.colPassWord.Width = 125;
            // 
            // grbThongTin
            // 
            this.grbThongTin.Controls.Add(this.label4);
            this.grbThongTin.Controls.Add(this.label3);
            this.grbThongTin.Controls.Add(this.label2);
            this.grbThongTin.Controls.Add(this.label1);
            this.grbThongTin.Controls.Add(this.txtMK);
            this.grbThongTin.Controls.Add(this.txtTen);
            this.grbThongTin.Controls.Add(this.txtDT);
            this.grbThongTin.Controls.Add(this.txtMa);
            this.grbThongTin.Location = new System.Drawing.Point(16, 146);
            this.grbThongTin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbThongTin.Size = new System.Drawing.Size(291, 208);
            this.grbThongTin.TabIndex = 21;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Thông tin nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 133);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 165);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã nhân viên";
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(149, 165);
            this.txtMK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(132, 22);
            this.txtMK.TabIndex = 0;
            this.txtMK.UseSystemPasswordChar = true;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(149, 101);
            this.txtTen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(132, 22);
            this.txtTen.TabIndex = 0;
            // 
            // txtDT
            // 
            this.txtDT.Location = new System.Drawing.Point(149, 133);
            this.txtDT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDT.Name = "txtDT";
            this.txtDT.Size = new System.Drawing.Size(132, 22);
            this.txtDT.TabIndex = 0;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(149, 69);
            this.txtMa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(132, 22);
            this.txtMa.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsbtnThem,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(13, 378);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(127, 27);
            this.toolStrip1.TabIndex = 22;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tlsbtnThem
            // 
            this.tlsbtnThem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsbtnThem.Image = ((System.Drawing.Image)(resources.GetObject("tlsbtnThem.Image")));
            this.tlsbtnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsbtnThem.Name = "tlsbtnThem";
            this.tlsbtnThem.Size = new System.Drawing.Size(29, 24);
            this.tlsbtnThem.Text = "toolStripButton1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(46, 24);
            this.toolStripLabel1.Text = "Thêm";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // toolStrip7
            // 
            this.toolStrip7.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip7.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip7.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsbtnXoa,
            this.lblXoa});
            this.toolStrip7.Location = new System.Drawing.Point(223, 378);
            this.toolStrip7.Name = "toolStrip7";
            this.toolStrip7.Size = new System.Drawing.Size(77, 31);
            this.toolStrip7.TabIndex = 22;
            this.toolStrip7.Text = "toolStrip1";
            // 
            // tlsbtnXoa
            // 
            this.tlsbtnXoa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsbtnXoa.Image = ((System.Drawing.Image)(resources.GetObject("tlsbtnXoa.Image")));
            this.tlsbtnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsbtnXoa.Name = "tlsbtnXoa";
            this.tlsbtnXoa.Size = new System.Drawing.Size(29, 28);
            this.tlsbtnXoa.Text = "toolStripButton1";
            // 
            // lblXoa
            // 
            this.lblXoa.Name = "lblXoa";
            this.lblXoa.Size = new System.Drawing.Size(35, 28);
            this.lblXoa.Text = "Xóa";
            // 
            // toolStrip8
            // 
            this.toolStrip8.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip8.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip8.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsbtnThoat,
            this.toolStripLabel4});
            this.toolStrip8.Location = new System.Drawing.Point(209, 436);
            this.toolStrip8.Name = "toolStrip8";
            this.toolStrip8.Size = new System.Drawing.Size(89, 31);
            this.toolStrip8.TabIndex = 22;
            this.toolStrip8.Text = "toolStrip1";
            // 
            // tlsbtnThoat
            // 
            this.tlsbtnThoat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsbtnThoat.Image = ((System.Drawing.Image)(resources.GetObject("tlsbtnThoat.Image")));
            this.tlsbtnThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsbtnThoat.Name = "tlsbtnThoat";
            this.tlsbtnThoat.Size = new System.Drawing.Size(29, 28);
            this.tlsbtnThoat.Text = "toolStripButton1";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(47, 28);
            this.toolStripLabel4.Text = "Thoát";
            // 
            // toolStrip9
            // 
            this.toolStrip9.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip9.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip9.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsbtnSua,
            this.toolStripLabel3});
            this.toolStrip9.Location = new System.Drawing.Point(13, 436);
            this.toolStrip9.Name = "toolStrip9";
            this.toolStrip9.Size = new System.Drawing.Size(80, 31);
            this.toolStrip9.TabIndex = 22;
            this.toolStrip9.Text = "toolStrip1";
            // 
            // tlsbtnSua
            // 
            this.tlsbtnSua.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsbtnSua.Image = ((System.Drawing.Image)(resources.GetObject("tlsbtnSua.Image")));
            this.tlsbtnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsbtnSua.Name = "tlsbtnSua";
            this.tlsbtnSua.Size = new System.Drawing.Size(29, 28);
            this.tlsbtnSua.Text = "toolStripButton1";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(38, 28);
            this.toolStripLabel3.Text = "Sữa ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(722, 69);
            this.label5.TabIndex = 23;
            this.label5.Text = "DANH SÁCH NHÂN VIÊN";
            // 
            // frmQLNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 490);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.toolStrip9);
            this.Controls.Add(this.toolStrip8);
            this.Controls.Add(this.toolStrip7);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.grbThongTin);
            this.Controls.Add(this.dgvDSNhanVien);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmQLNhanVien";
            this.Text = "Danh sách nhân viên";
            this.Load += new System.EventHandler(this.frmQLNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNhanVien)).EndInit();
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip7.ResumeLayout(false);
            this.toolStrip7.PerformLayout();
            this.toolStrip8.ResumeLayout(false);
            this.toolStrip8.PerformLayout();
            this.toolStrip9.ResumeLayout(false);
            this.toolStrip9.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvDSNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPassWord;
        private System.Windows.Forms.GroupBox grbThongTin;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtDT;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tlsbtnThem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStrip toolStrip7;
        private System.Windows.Forms.ToolStrip toolStrip8;
        private System.Windows.Forms.ToolStrip toolStrip9;
        private System.Windows.Forms.ToolStripButton tlsbtnXoa;
        private System.Windows.Forms.ToolStripLabel lblXoa;
        private System.Windows.Forms.ToolStripButton tlsbtnThoat;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripButton tlsbtnSua;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.Label label5;
    }
}