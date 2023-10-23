namespace GUI
{
    partial class frmQLVatLieu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.gnbtnThoat = new Guna.UI2.WinForms.Guna2Button();
            this.gnbtnThemMoi = new Guna.UI2.WinForms.Guna2Button();
            this.gndgvQLVL = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.gnbtnQLDungCu = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gndgvQLVL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2Panel1.Controls.Add(this.gnbtnThoat);
            this.guna2Panel1.Controls.Add(this.gnbtnQLDungCu);
            this.guna2Panel1.Controls.Add(this.gnbtnThemMoi);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(215, 396);
            this.guna2Panel1.TabIndex = 0;
            // 
            // gnbtnThoat
            // 
            this.gnbtnThoat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gnbtnThoat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gnbtnThoat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gnbtnThoat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gnbtnThoat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gnbtnThoat.ForeColor = System.Drawing.Color.White;
            this.gnbtnThoat.Location = new System.Drawing.Point(-1, 343);
            this.gnbtnThoat.Name = "gnbtnThoat";
            this.gnbtnThoat.Size = new System.Drawing.Size(213, 41);
            this.gnbtnThoat.TabIndex = 1;
            this.gnbtnThoat.Text = "Thoát";
            this.gnbtnThoat.Click += new System.EventHandler(this.gnbtnThoat_Click);
            // 
            // gnbtnThemMoi
            // 
            this.gnbtnThemMoi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gnbtnThemMoi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gnbtnThemMoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gnbtnThemMoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gnbtnThemMoi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gnbtnThemMoi.ForeColor = System.Drawing.Color.White;
            this.gnbtnThemMoi.Location = new System.Drawing.Point(0, 250);
            this.gnbtnThemMoi.Name = "gnbtnThemMoi";
            this.gnbtnThemMoi.Size = new System.Drawing.Size(213, 41);
            this.gnbtnThemMoi.TabIndex = 1;
            this.gnbtnThemMoi.Text = "Danh sách nhập xuất";
            this.gnbtnThemMoi.Click += new System.EventHandler(this.gnbtnThemMoi_Click);
            // 
            // gndgvQLVL
            // 
            this.gndgvQLVL.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.gndgvQLVL.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gndgvQLVL.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gndgvQLVL.ColumnHeadersHeight = 25;
            this.gndgvQLVL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gndgvQLVL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMa,
            this.colTen,
            this.colDVT,
            this.colGia});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gndgvQLVL.DefaultCellStyle = dataGridViewCellStyle6;
            this.gndgvQLVL.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gndgvQLVL.Location = new System.Drawing.Point(214, 67);
            this.gndgvQLVL.Name = "gndgvQLVL";
            this.gndgvQLVL.RowHeadersVisible = false;
            this.gndgvQLVL.Size = new System.Drawing.Size(581, 329);
            this.gndgvQLVL.TabIndex = 1;
            this.gndgvQLVL.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gndgvQLVL.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gndgvQLVL.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gndgvQLVL.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gndgvQLVL.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gndgvQLVL.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gndgvQLVL.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gndgvQLVL.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gndgvQLVL.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gndgvQLVL.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gndgvQLVL.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gndgvQLVL.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gndgvQLVL.ThemeStyle.HeaderStyle.Height = 25;
            this.gndgvQLVL.ThemeStyle.ReadOnly = false;
            this.gndgvQLVL.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gndgvQLVL.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gndgvQLVL.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gndgvQLVL.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gndgvQLVL.ThemeStyle.RowsStyle.Height = 22;
            this.gndgvQLVL.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gndgvQLVL.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // colMa
            // 
            this.colMa.HeaderText = "Mã thiết bị";
            this.colMa.Name = "colMa";
            // 
            // colTen
            // 
            this.colTen.HeaderText = "Tên thiết bị";
            this.colTen.Name = "colTen";
            // 
            // colDVT
            // 
            this.colDVT.HeaderText = "Đơn vị tính";
            this.colDVT.Name = "colDVT";
            // 
            // colGia
            // 
            this.colGia.HeaderText = "Đớn giá";
            this.colGia.Name = "colGia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.label1.Location = new System.Drawing.Point(327, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Danh sách vật liệu, dụng cụ";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::GUI.Properties.Resources.snapedit_1697993603939;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 1);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(214, 243);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // gnbtnQLDungCu
            // 
            this.gnbtnQLDungCu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gnbtnQLDungCu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gnbtnQLDungCu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gnbtnQLDungCu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gnbtnQLDungCu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gnbtnQLDungCu.ForeColor = System.Drawing.Color.White;
            this.gnbtnQLDungCu.Location = new System.Drawing.Point(-1, 296);
            this.gnbtnQLDungCu.Name = "gnbtnQLDungCu";
            this.gnbtnQLDungCu.Size = new System.Drawing.Size(213, 41);
            this.gnbtnQLDungCu.TabIndex = 1;
            this.gnbtnQLDungCu.Text = "Quản lý thiết bị, dụng cụ";
            this.gnbtnQLDungCu.Click += new System.EventHandler(this.gnbtnQLDungCu_Click);
            // 
            // frmQLVatLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(792, 396);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gndgvQLVL);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQLVatLieu";
            this.Text = "frmQLVatLieu";
            this.Load += new System.EventHandler(this.frmQLVatLieu_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gndgvQLVL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button gnbtnThoat;
        private Guna.UI2.WinForms.Guna2Button gnbtnThemMoi;
        private Guna.UI2.WinForms.Guna2DataGridView gndgvQLVL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGia;
        private Guna.UI2.WinForms.Guna2Button gnbtnQLDungCu;
    }
}