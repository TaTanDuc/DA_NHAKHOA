namespace GUI
{
    partial class FrmQLDichVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQLDichVu));
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dgvDSDV = new System.Windows.Forms.DataGridView();
            this.toolStrip9 = new System.Windows.Forms.ToolStrip();
            this.tlsbtnSua = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip8 = new System.Windows.Forms.ToolStrip();
            this.tlsbtnThoat = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip7 = new System.Windows.Forms.ToolStrip();
            this.tlsbtnXoa = new System.Windows.Forms.ToolStripButton();
            this.lblXoa = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tlsbtnThem = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.colMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChuanDoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtChuanDoan = new System.Windows.Forms.TextBox();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.txtDVT = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDV)).BeginInit();
            this.toolStrip9.SuspendLayout();
            this.toolStrip8.SuspendLayout();
            this.toolStrip7.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label1.Location = new System.Drawing.Point(294, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "BẢNG DỊCH VỤ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(428, 281);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // dgvDSDV
            // 
            this.dgvDSDV.AllowUserToAddRows = false;
            this.dgvDSDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMa,
            this.colChuanDoan,
            this.colMota,
            this.colSL,
            this.colGia});
            this.dgvDSDV.Location = new System.Drawing.Point(271, 71);
            this.dgvDSDV.Name = "dgvDSDV";
            this.dgvDSDV.Size = new System.Drawing.Size(542, 282);
            this.dgvDSDV.TabIndex = 2;
            // 
            // toolStrip9
            // 
            this.toolStrip9.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip9.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsbtnSua,
            this.toolStripLabel3});
            this.toolStrip9.Location = new System.Drawing.Point(8, 328);
            this.toolStrip9.Name = "toolStrip9";
            this.toolStrip9.Size = new System.Drawing.Size(64, 25);
            this.toolStrip9.TabIndex = 23;
            this.toolStrip9.Text = "toolStrip1";
            // 
            // tlsbtnSua
            // 
            this.tlsbtnSua.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsbtnSua.Image = ((System.Drawing.Image)(resources.GetObject("tlsbtnSua.Image")));
            this.tlsbtnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsbtnSua.Name = "tlsbtnSua";
            this.tlsbtnSua.Size = new System.Drawing.Size(23, 22);
            this.tlsbtnSua.Text = "toolStripButton1";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(29, 22);
            this.toolStripLabel3.Text = "Sữa ";
            // 
            // toolStrip8
            // 
            this.toolStrip8.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip8.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsbtnThoat,
            this.toolStripLabel4});
            this.toolStrip8.Location = new System.Drawing.Point(155, 328);
            this.toolStrip8.Name = "toolStrip8";
            this.toolStrip8.Size = new System.Drawing.Size(72, 25);
            this.toolStrip8.TabIndex = 24;
            this.toolStrip8.Text = "toolStrip1";
            // 
            // tlsbtnThoat
            // 
            this.tlsbtnThoat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsbtnThoat.Image = ((System.Drawing.Image)(resources.GetObject("tlsbtnThoat.Image")));
            this.tlsbtnThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsbtnThoat.Name = "tlsbtnThoat";
            this.tlsbtnThoat.Size = new System.Drawing.Size(23, 22);
            this.tlsbtnThoat.Text = "toolStripButton1";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(37, 22);
            this.toolStripLabel4.Text = "Thoát";
            // 
            // toolStrip7
            // 
            this.toolStrip7.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip7.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsbtnXoa,
            this.lblXoa});
            this.toolStrip7.Location = new System.Drawing.Point(155, 281);
            this.toolStrip7.Name = "toolStrip7";
            this.toolStrip7.Size = new System.Drawing.Size(62, 25);
            this.toolStrip7.TabIndex = 25;
            this.toolStrip7.Text = "toolStrip1";
            // 
            // tlsbtnXoa
            // 
            this.tlsbtnXoa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsbtnXoa.Image = ((System.Drawing.Image)(resources.GetObject("tlsbtnXoa.Image")));
            this.tlsbtnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsbtnXoa.Name = "tlsbtnXoa";
            this.tlsbtnXoa.Size = new System.Drawing.Size(23, 22);
            this.tlsbtnXoa.Text = "toolStripButton1";
            // 
            // lblXoa
            // 
            this.lblXoa.Name = "lblXoa";
            this.lblXoa.Size = new System.Drawing.Size(27, 22);
            this.lblXoa.Text = "Xóa";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsbtnThem,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(8, 281);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(72, 25);
            this.toolStrip1.TabIndex = 26;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tlsbtnThem
            // 
            this.tlsbtnThem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsbtnThem.Image = ((System.Drawing.Image)(resources.GetObject("tlsbtnThem.Image")));
            this.tlsbtnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsbtnThem.Name = "tlsbtnThem";
            this.tlsbtnThem.Size = new System.Drawing.Size(23, 22);
            this.tlsbtnThem.Text = "toolStripButton1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(37, 22);
            this.toolStripLabel1.Text = "Thêm";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDonGia);
            this.groupBox1.Controls.Add(this.txtDVT);
            this.groupBox1.Controls.Add(this.txtMoTa);
            this.groupBox1.Controls.Add(this.txtChuanDoan);
            this.groupBox1.Controls.Add(this.txtMa);
            this.groupBox1.Location = new System.Drawing.Point(8, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 197);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin dịch vụ";
            // 
            // colMa
            // 
            this.colMa.HeaderText = "Mã điều trị";
            this.colMa.Name = "colMa";
            // 
            // colChuanDoan
            // 
            this.colChuanDoan.HeaderText = "Chuẩn đoán";
            this.colChuanDoan.Name = "colChuanDoan";
            // 
            // colMota
            // 
            this.colMota.HeaderText = "Mô tả điều trị";
            this.colMota.Name = "colMota";
            // 
            // colSL
            // 
            this.colSL.HeaderText = "Đơn vị tính";
            this.colSL.Name = "colSL";
            // 
            // colGia
            // 
            this.colGia.HeaderText = "Đơn giá";
            this.colGia.Name = "colGia";
            // 
            // txtChuanDoan
            // 
            this.txtChuanDoan.Location = new System.Drawing.Point(101, 79);
            this.txtChuanDoan.Name = "txtChuanDoan";
            this.txtChuanDoan.Size = new System.Drawing.Size(146, 20);
            this.txtChuanDoan.TabIndex = 0;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(101, 105);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(146, 20);
            this.txtMoTa.TabIndex = 0;
            // 
            // txtDVT
            // 
            this.txtDVT.Location = new System.Drawing.Point(101, 131);
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Size = new System.Drawing.Size(146, 20);
            this.txtDVT.TabIndex = 0;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(101, 157);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(146, 20);
            this.txtDonGia.TabIndex = 0;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(101, 53);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(146, 20);
            this.txtMa.TabIndex = 0;
            this.txtMa.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã điều trị";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Chuẩn đoán";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mô tả điều trị";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Đơn vị tính";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Đơn giá";
            // 
            // FrmQLDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 360);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip9);
            this.Controls.Add(this.toolStrip8);
            this.Controls.Add(this.toolStrip7);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvDSDV);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Name = "FrmQLDichVu";
            this.Text = "FrmQLDichVu";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDV)).EndInit();
            this.toolStrip9.ResumeLayout(false);
            this.toolStrip9.PerformLayout();
            this.toolStrip8.ResumeLayout(false);
            this.toolStrip8.PerformLayout();
            this.toolStrip7.ResumeLayout(false);
            this.toolStrip7.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvDSDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChuanDoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMota;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGia;
        private System.Windows.Forms.ToolStrip toolStrip9;
        private System.Windows.Forms.ToolStripButton tlsbtnSua;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStrip toolStrip8;
        private System.Windows.Forms.ToolStripButton tlsbtnThoat;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStrip toolStrip7;
        private System.Windows.Forms.ToolStripButton tlsbtnXoa;
        private System.Windows.Forms.ToolStripLabel lblXoa;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tlsbtnThem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtDVT;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.TextBox txtChuanDoan;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}