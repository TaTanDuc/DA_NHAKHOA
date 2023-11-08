namespace GUI
{
    partial class CreateAccount
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
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPhone = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblSex = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.rbFemale = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbMale = new Guna.UI2.WinForms.Guna2RadioButton();
            this.dpBirthDay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtLogin = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblLoginName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtRePass = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btCreate = new Guna.UI2.WinForms.Guna2Button();
            this.cbbPermission = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblPermission = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btReset = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(82)))), ((int)(((byte)(254)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Red;
            this.guna2ControlBox1.Location = new System.Drawing.Point(743, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 36);
            this.guna2ControlBox1.TabIndex = 5;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(82)))), ((int)(((byte)(254)))));
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel1.Controls.Add(this.guna2ControlBox1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(800, 64);
            this.guna2Panel1.TabIndex = 1;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(236, 4);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(334, 58);
            this.guna2HtmlLabel1.TabIndex = 8;
            this.guna2HtmlLabel1.Text = "Tạo Tài Khoản";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            this.txtName.AutoRoundedCorners = true;
            this.txtName.BorderRadius = 11;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Location = new System.Drawing.Point(139, 98);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderText = "";
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(200, 25);
            this.txtName.TabIndex = 25;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(31, 98);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(77, 20);
            this.lblName.TabIndex = 24;
            this.lblName.Text = "Họ Và Tên";
            this.lblName.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPhone
            // 
            this.txtPhone.AutoRoundedCorners = true;
            this.txtPhone.BorderRadius = 11;
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.DefaultText = "";
            this.txtPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone.Location = new System.Drawing.Point(139, 255);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.PlaceholderText = "";
            this.txtPhone.SelectedText = "";
            this.txtPhone.Size = new System.Drawing.Size(200, 25);
            this.txtPhone.TabIndex = 27;
            // 
            // lblPhone
            // 
            this.lblPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblPhone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(19, 255);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(103, 20);
            this.lblPhone.TabIndex = 26;
            this.lblPhone.Text = "Số Điện Thoại";
            this.lblPhone.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSex
            // 
            this.lblSex.BackColor = System.Drawing.Color.Transparent;
            this.lblSex.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSex.Location = new System.Drawing.Point(34, 152);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(66, 20);
            this.lblSex.TabIndex = 32;
            this.lblSex.Text = "Giới Tính";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbFemale.CheckedState.BorderThickness = 0;
            this.rbFemale.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbFemale.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbFemale.CheckedState.InnerOffset = -4;
            this.rbFemale.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemale.Location = new System.Drawing.Point(265, 149);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(48, 22);
            this.rbFemale.TabIndex = 31;
            this.rbFemale.Text = "Nữ";
            this.rbFemale.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbFemale.UncheckedState.BorderThickness = 2;
            this.rbFemale.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbFemale.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbMale.CheckedState.BorderThickness = 0;
            this.rbMale.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbMale.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbMale.CheckedState.InnerOffset = -4;
            this.rbMale.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMale.Location = new System.Drawing.Point(139, 149);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(59, 22);
            this.rbMale.TabIndex = 30;
            this.rbMale.Text = "Nam";
            this.rbMale.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbMale.UncheckedState.BorderThickness = 2;
            this.rbMale.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbMale.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // dpBirthDay
            // 
            this.dpBirthDay.AutoRoundedCorners = true;
            this.dpBirthDay.BorderRadius = 11;
            this.dpBirthDay.Checked = true;
            this.dpBirthDay.FillColor = System.Drawing.Color.White;
            this.dpBirthDay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dpBirthDay.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dpBirthDay.Location = new System.Drawing.Point(139, 200);
            this.dpBirthDay.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dpBirthDay.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dpBirthDay.Name = "dpBirthDay";
            this.dpBirthDay.Size = new System.Drawing.Size(200, 25);
            this.dpBirthDay.TabIndex = 34;
            this.dpBirthDay.Value = new System.DateTime(2023, 11, 7, 9, 29, 23, 692);
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(30, 200);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(74, 20);
            this.guna2HtmlLabel5.TabIndex = 33;
            this.guna2HtmlLabel5.Text = "Ngày Sinh";
            this.guna2HtmlLabel5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLogin
            // 
            this.txtLogin.AutoRoundedCorners = true;
            this.txtLogin.BorderRadius = 11;
            this.txtLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLogin.DefaultText = "";
            this.txtLogin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLogin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLogin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLogin.Location = new System.Drawing.Point(581, 100);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.PasswordChar = '\0';
            this.txtLogin.PlaceholderText = "";
            this.txtLogin.SelectedText = "";
            this.txtLogin.Size = new System.Drawing.Size(174, 25);
            this.txtLogin.TabIndex = 36;
            // 
            // lblLoginName
            // 
            this.lblLoginName.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginName.Location = new System.Drawing.Point(463, 100);
            this.lblLoginName.Name = "lblLoginName";
            this.lblLoginName.Size = new System.Drawing.Size(112, 20);
            this.lblLoginName.TabIndex = 35;
            this.lblLoginName.Text = "Tên Đăng Nhập";
            this.lblLoginName.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPass
            // 
            this.txtPass.AutoRoundedCorners = true;
            this.txtPass.BorderRadius = 11;
            this.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass.DefaultText = "";
            this.txtPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPass.Location = new System.Drawing.Point(581, 149);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '●';
            this.txtPass.PlaceholderText = "";
            this.txtPass.SelectedText = "";
            this.txtPass.Size = new System.Drawing.Size(174, 25);
            this.txtPass.TabIndex = 38;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(482, 149);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(69, 20);
            this.guna2HtmlLabel2.TabIndex = 37;
            this.guna2HtmlLabel2.Text = "Mật Khẩu";
            this.guna2HtmlLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRePass
            // 
            this.txtRePass.AutoRoundedCorners = true;
            this.txtRePass.BorderRadius = 11;
            this.txtRePass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRePass.DefaultText = "";
            this.txtRePass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRePass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRePass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRePass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRePass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRePass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRePass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRePass.Location = new System.Drawing.Point(581, 202);
            this.txtRePass.Name = "txtRePass";
            this.txtRePass.PasswordChar = '●';
            this.txtRePass.PlaceholderText = "";
            this.txtRePass.SelectedText = "";
            this.txtRePass.Size = new System.Drawing.Size(174, 25);
            this.txtRePass.TabIndex = 40;
            this.txtRePass.UseSystemPasswordChar = true;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(439, 202);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(136, 20);
            this.guna2HtmlLabel3.TabIndex = 39;
            this.guna2HtmlLabel3.Text = "Nhập Lại Mật Khẩu";
            this.guna2HtmlLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btCancel
            // 
            this.btCancel.AutoRoundedCorners = true;
            this.btCancel.BorderColor = System.Drawing.Color.Transparent;
            this.btCancel.BorderRadius = 11;
            this.btCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btCancel.FillColor = System.Drawing.Color.Red;
            this.btCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btCancel.ForeColor = System.Drawing.Color.White;
            this.btCancel.Location = new System.Drawing.Point(350, 304);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(100, 25);
            this.btCancel.TabIndex = 42;
            this.btCancel.Text = "Hủy";
            this.btCancel.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // btCreate
            // 
            this.btCreate.AutoRoundedCorners = true;
            this.btCreate.BorderColor = System.Drawing.Color.Transparent;
            this.btCreate.BorderRadius = 11;
            this.btCreate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btCreate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btCreate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btCreate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btCreate.FillColor = System.Drawing.Color.LimeGreen;
            this.btCreate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btCreate.ForeColor = System.Drawing.Color.White;
            this.btCreate.Location = new System.Drawing.Point(230, 304);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(100, 25);
            this.btCreate.TabIndex = 41;
            this.btCreate.Text = "Tạo";
            this.btCreate.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // cbbPermission
            // 
            this.cbbPermission.AutoRoundedCorners = true;
            this.cbbPermission.BackColor = System.Drawing.Color.Transparent;
            this.cbbPermission.BorderRadius = 12;
            this.cbbPermission.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbPermission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPermission.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbPermission.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbPermission.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbPermission.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbPermission.ItemHeight = 20;
            this.cbbPermission.Location = new System.Drawing.Point(581, 250);
            this.cbbPermission.Name = "cbbPermission";
            this.cbbPermission.Size = new System.Drawing.Size(174, 26);
            this.cbbPermission.TabIndex = 43;
            // 
            // lblPermission
            // 
            this.lblPermission.BackColor = System.Drawing.Color.Transparent;
            this.lblPermission.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPermission.Location = new System.Drawing.Point(482, 255);
            this.lblPermission.Name = "lblPermission";
            this.lblPermission.Size = new System.Drawing.Size(65, 20);
            this.lblPermission.TabIndex = 44;
            this.lblPermission.Text = "Chức Vụ";
            this.lblPermission.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btReset
            // 
            this.btReset.AutoRoundedCorners = true;
            this.btReset.BorderColor = System.Drawing.Color.Transparent;
            this.btReset.BorderRadius = 11;
            this.btReset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btReset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btReset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btReset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btReset.FillColor = System.Drawing.Color.Blue;
            this.btReset.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btReset.ForeColor = System.Drawing.Color.White;
            this.btReset.Location = new System.Drawing.Point(474, 304);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(100, 25);
            this.btReset.TabIndex = 45;
            this.btReset.Text = "Đặt Lại";
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 353);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.lblPermission);
            this.Controls.Add(this.cbbPermission);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btCreate);
            this.Controls.Add(this.txtRePass);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblLoginName);
            this.Controls.Add(this.dpBirthDay);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateAccount";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CreateAccount_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblName;
        private Guna.UI2.WinForms.Guna2TextBox txtPhone;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPhone;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSex;
        private Guna.UI2.WinForms.Guna2RadioButton rbFemale;
        private Guna.UI2.WinForms.Guna2RadioButton rbMale;
        private Guna.UI2.WinForms.Guna2TextBox txtLogin;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblLoginName;
        private Guna.UI2.WinForms.Guna2DateTimePicker dpBirthDay;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2TextBox txtRePass;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox txtPass;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2Button btCancel;
        private Guna.UI2.WinForms.Guna2Button btCreate;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPermission;
        private Guna.UI2.WinForms.Guna2ComboBox cbbPermission;
        private Guna.UI2.WinForms.Guna2Button btReset;
    }
}