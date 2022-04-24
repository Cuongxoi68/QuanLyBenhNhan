
namespace QuanLyBenhNhan
{
    partial class frmManager
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
            this.txtNameUpdate = new System.Windows.Forms.TextBox();
            this.panelCapNhat = new System.Windows.Forms.Panel();
            this.chon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridview = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.name = new System.Windows.Forms.Label();
            this.btnDoiMatKhau = new Guna.UI.WinForms.GunaGradientButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTong = new System.Windows.Forms.Panel();
            this.btnReload = new Guna.UI.WinForms.GunaCircleButton();
            this.picCoDon = new System.Windows.Forms.PictureBox();
            this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.btnManager = new Guna.UI.WinForms.GunaButton();
            this.btnRoom = new Guna.UI.WinForms.GunaButton();
            this.btnKhanCap = new Guna.UI.WinForms.GunaButton();
            this.btnLogout = new Guna.UI.WinForms.GunaButton();
            this.btnThem = new Guna.UI.WinForms.GunaButton();
            this.btnXoa = new Guna.UI.WinForms.GunaButton();
            this.btnSua = new Guna.UI.WinForms.GunaButton();
            this.panelCapNhat.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridview)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelTong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCoDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNameUpdate
            // 
            this.txtNameUpdate.BackColor = System.Drawing.Color.Khaki;
            this.txtNameUpdate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNameUpdate.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameUpdate.Location = new System.Drawing.Point(9, 0);
            this.txtNameUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNameUpdate.Name = "txtNameUpdate";
            this.txtNameUpdate.ReadOnly = true;
            this.txtNameUpdate.Size = new System.Drawing.Size(429, 26);
            this.txtNameUpdate.TabIndex = 2;
            this.txtNameUpdate.Text = "Click vào tên của tài khoản muốn cập nhật";
            this.txtNameUpdate.TextChanged += new System.EventHandler(this.txtNameUpdate_TextChanged);
            // 
            // panelCapNhat
            // 
            this.panelCapNhat.Controls.Add(this.btnXoa);
            this.panelCapNhat.Controls.Add(this.btnSua);
            this.panelCapNhat.Controls.Add(this.txtNameUpdate);
            this.panelCapNhat.Location = new System.Drawing.Point(564, 5);
            this.panelCapNhat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelCapNhat.Name = "panelCapNhat";
            this.panelCapNhat.Size = new System.Drawing.Size(952, 118);
            this.panelCapNhat.TabIndex = 2;
            // 
            // chon
            // 
            this.chon.DataPropertyName = "chon";
            this.chon.HeaderText = "Chọn";
            this.chon.MinimumWidth = 8;
            this.chon.Name = "chon";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 3000;
            this.timer.Tick += new System.EventHandler(this.time_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Khaki;
            this.panel2.Controls.Add(this.dataGridview);
            this.panel2.Controls.Add(this.picCoDon);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(322, 6);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1785, 766);
            this.panel2.TabIndex = 4;
            // 
            // dataGridview
            // 
            this.dataGridview.AllowUserToAddRows = false;
            this.dataGridview.AllowUserToDeleteRows = false;
            this.dataGridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridview.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chon});
            this.dataGridview.Location = new System.Drawing.Point(36, 21);
            this.dataGridview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridview.Name = "dataGridview";
            this.dataGridview.RowHeadersVisible = false;
            this.dataGridview.RowHeadersWidth = 62;
            this.dataGridview.Size = new System.Drawing.Size(1527, 745);
            this.dataGridview.TabIndex = 1;
            this.dataGridview.Tag = "1";
            this.dataGridview.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(134, 775);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1510, 114);
            this.panel3.TabIndex = 2;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(44, 69);
            this.name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(95, 26);
            this.name.TabIndex = 4;
            this.name.Text = "ADMIN";
            this.name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.AnimationHoverSpeed = 0.07F;
            this.btnDoiMatKhau.AnimationSpeed = 0.03F;
            this.btnDoiMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.btnDoiMatKhau.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.btnDoiMatKhau.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.btnDoiMatKhau.BorderColor = System.Drawing.Color.Black;
            this.btnDoiMatKhau.BorderSize = 2;
            this.btnDoiMatKhau.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDoiMatKhau.FocusedColor = System.Drawing.Color.Empty;
            this.btnDoiMatKhau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiMatKhau.ForeColor = System.Drawing.Color.White;
            this.btnDoiMatKhau.Image = null;
            this.btnDoiMatKhau.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDoiMatKhau.Location = new System.Drawing.Point(65, 251);
            this.btnDoiMatKhau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnDoiMatKhau.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnDoiMatKhau.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDoiMatKhau.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDoiMatKhau.OnHoverImage = null;
            this.btnDoiMatKhau.OnPressedColor = System.Drawing.Color.Black;
            this.btnDoiMatKhau.Radius = 15;
            this.btnDoiMatKhau.Size = new System.Drawing.Size(182, 57);
            this.btnDoiMatKhau.TabIndex = 7;
            this.btnDoiMatKhau.Text = "Đổi mật khẩu";
            this.btnDoiMatKhau.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDoiMatKhau.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.gunaCirclePictureBox1);
            this.panel1.Controls.Add(this.btnDoiMatKhau);
            this.panel1.Controls.Add(this.btnManager);
            this.panel1.Controls.Add(this.btnRoom);
            this.panel1.Controls.Add(this.btnKhanCap);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, -12);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 928);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 47);
            this.label1.TabIndex = 4;
            this.label1.Text = "Manager";
            // 
            // panelTong
            // 
            this.panelTong.Controls.Add(this.btnThem);
            this.panelTong.Controls.Add(this.panelCapNhat);
            this.panelTong.Location = new System.Drawing.Point(470, 777);
            this.panelTong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelTong.Name = "panelTong";
            this.panelTong.Size = new System.Drawing.Size(1542, 128);
            this.panelTong.TabIndex = 7;
            this.panelTong.Visible = false;
            // 
            // btnReload
            // 
            this.btnReload.AnimationHoverSpeed = 0.07F;
            this.btnReload.AnimationSpeed = 0.03F;
            this.btnReload.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnReload.BorderColor = System.Drawing.Color.Black;
            this.btnReload.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReload.FocusedColor = System.Drawing.Color.Empty;
            this.btnReload.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReload.ForeColor = System.Drawing.Color.White;
            this.btnReload.Image = global::QuanLyBenhNhan.Properties.Resources.reload1;
            this.btnReload.ImageSize = new System.Drawing.Size(52, 52);
            this.btnReload.Location = new System.Drawing.Point(358, 795);
            this.btnReload.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReload.Name = "btnReload";
            this.btnReload.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnReload.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnReload.OnHoverForeColor = System.Drawing.Color.White;
            this.btnReload.OnHoverImage = null;
            this.btnReload.OnPressedColor = System.Drawing.Color.Black;
            this.btnReload.Size = new System.Drawing.Size(78, 71);
            this.btnReload.TabIndex = 6;
            this.btnReload.Visible = false;
            this.btnReload.Click += new System.EventHandler(this.button2_Click);
            // 
            // picCoDon
            // 
            this.picCoDon.Location = new System.Drawing.Point(190, 5);
            this.picCoDon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picCoDon.Name = "picCoDon";
            this.picCoDon.Size = new System.Drawing.Size(1498, 757);
            this.picCoDon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCoDon.TabIndex = 3;
            this.picCoDon.TabStop = false;
            // 
            // gunaCirclePictureBox1
            // 
            this.gunaCirclePictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox1.Image = global::QuanLyBenhNhan.Properties.Resources.manager1;
            this.gunaCirclePictureBox1.InitialImage = global::QuanLyBenhNhan.Properties.Resources.doctor;
            this.gunaCirclePictureBox1.Location = new System.Drawing.Point(94, 116);
            this.gunaCirclePictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gunaCirclePictureBox1.Name = "gunaCirclePictureBox1";
            this.gunaCirclePictureBox1.Size = new System.Drawing.Size(118, 115);
            this.gunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaCirclePictureBox1.TabIndex = 9;
            this.gunaCirclePictureBox1.TabStop = false;
            this.gunaCirclePictureBox1.UseTransfarantBackground = false;
            // 
            // btnManager
            // 
            this.btnManager.AnimationHoverSpeed = 0.07F;
            this.btnManager.AnimationSpeed = 0.03F;
            this.btnManager.BackColor = System.Drawing.Color.Transparent;
            this.btnManager.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnManager.BorderColor = System.Drawing.Color.Black;
            this.btnManager.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnManager.FocusedColor = System.Drawing.Color.Empty;
            this.btnManager.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManager.ForeColor = System.Drawing.Color.White;
            this.btnManager.Image = global::QuanLyBenhNhan.Properties.Resources.doctor1;
            this.btnManager.ImageSize = new System.Drawing.Size(25, 25);
            this.btnManager.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.btnManager.Location = new System.Drawing.Point(0, 317);
            this.btnManager.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnManager.Name = "btnManager";
            this.btnManager.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnManager.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnManager.OnHoverForeColor = System.Drawing.Color.White;
            this.btnManager.OnHoverImage = null;
            this.btnManager.OnPressedColor = System.Drawing.Color.Black;
            this.btnManager.Radius = 15;
            this.btnManager.Size = new System.Drawing.Size(314, 102);
            this.btnManager.TabIndex = 6;
            this.btnManager.Text = "    Quản lý cán bộ y tế";
            this.btnManager.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnManager.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnRoom
            // 
            this.btnRoom.AnimationHoverSpeed = 0.07F;
            this.btnRoom.AnimationSpeed = 0.03F;
            this.btnRoom.BackColor = System.Drawing.Color.Transparent;
            this.btnRoom.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnRoom.BorderColor = System.Drawing.Color.Black;
            this.btnRoom.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRoom.FocusedColor = System.Drawing.Color.Empty;
            this.btnRoom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoom.ForeColor = System.Drawing.Color.White;
            this.btnRoom.Image = global::QuanLyBenhNhan.Properties.Resources.folder;
            this.btnRoom.ImageSize = new System.Drawing.Size(25, 25);
            this.btnRoom.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.btnRoom.Location = new System.Drawing.Point(0, 449);
            this.btnRoom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRoom.Name = "btnRoom";
            this.btnRoom.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnRoom.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnRoom.OnHoverForeColor = System.Drawing.Color.White;
            this.btnRoom.OnHoverImage = null;
            this.btnRoom.OnPressedColor = System.Drawing.Color.Black;
            this.btnRoom.Radius = 15;
            this.btnRoom.Size = new System.Drawing.Size(314, 102);
            this.btnRoom.TabIndex = 6;
            this.btnRoom.Text = "     Quản lý hồ sơ cách ly";
            this.btnRoom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRoom.Click += new System.EventHandler(this.btnHoSo_Click);
            // 
            // btnKhanCap
            // 
            this.btnKhanCap.AnimationHoverSpeed = 0.07F;
            this.btnKhanCap.AnimationSpeed = 0.03F;
            this.btnKhanCap.BackColor = System.Drawing.Color.Transparent;
            this.btnKhanCap.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnKhanCap.BorderColor = System.Drawing.Color.Black;
            this.btnKhanCap.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnKhanCap.FocusedColor = System.Drawing.Color.Empty;
            this.btnKhanCap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhanCap.ForeColor = System.Drawing.Color.White;
            this.btnKhanCap.Image = global::QuanLyBenhNhan.Properties.Resources.sos;
            this.btnKhanCap.ImageSize = new System.Drawing.Size(25, 25);
            this.btnKhanCap.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.btnKhanCap.Location = new System.Drawing.Point(0, 585);
            this.btnKhanCap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnKhanCap.Name = "btnKhanCap";
            this.btnKhanCap.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnKhanCap.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnKhanCap.OnHoverForeColor = System.Drawing.Color.White;
            this.btnKhanCap.OnHoverImage = null;
            this.btnKhanCap.OnPressedColor = System.Drawing.Color.Black;
            this.btnKhanCap.Radius = 15;
            this.btnKhanCap.Size = new System.Drawing.Size(314, 102);
            this.btnKhanCap.TabIndex = 6;
            this.btnKhanCap.Text = "       Trường hợp khẩn cấp";
            this.btnKhanCap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnKhanCap.Click += new System.EventHandler(this.btnTruongHopKhanCap_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.AnimationHoverSpeed = 0.07F;
            this.btnLogout.AnimationSpeed = 0.03F;
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnLogout.BorderColor = System.Drawing.Color.Black;
            this.btnLogout.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogout.FocusedColor = System.Drawing.Color.Empty;
            this.btnLogout.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = global::QuanLyBenhNhan.Properties.Resources.outIcon;
            this.btnLogout.ImageSize = new System.Drawing.Size(30, 30);
            this.btnLogout.Location = new System.Drawing.Point(59, 793);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnLogout.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLogout.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLogout.OnHoverImage = null;
            this.btnLogout.OnPressedColor = System.Drawing.Color.Black;
            this.btnLogout.Radius = 15;
            this.btnLogout.Size = new System.Drawing.Size(196, 65);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = " Đăng xuất";
            this.btnLogout.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnThem
            // 
            this.btnThem.AnimationHoverSpeed = 0.07F;
            this.btnThem.AnimationSpeed = 0.03F;
            this.btnThem.BackColor = System.Drawing.Color.Transparent;
            this.btnThem.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnThem.BorderColor = System.Drawing.Color.Black;
            this.btnThem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnThem.FocusedColor = System.Drawing.Color.Empty;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Image = global::QuanLyBenhNhan.Properties.Resources.plus;
            this.btnThem.ImageSize = new System.Drawing.Size(20, 20);
            this.btnThem.Location = new System.Drawing.Point(83, 18);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnThem.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnThem.OnHoverForeColor = System.Drawing.Color.White;
            this.btnThem.OnHoverImage = null;
            this.btnThem.OnPressedColor = System.Drawing.Color.Black;
            this.btnThem.Radius = 15;
            this.btnThem.Size = new System.Drawing.Size(273, 71);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AnimationHoverSpeed = 0.07F;
            this.btnXoa.AnimationSpeed = 0.03F;
            this.btnXoa.BackColor = System.Drawing.Color.Transparent;
            this.btnXoa.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnXoa.BorderColor = System.Drawing.Color.Black;
            this.btnXoa.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnXoa.FocusedColor = System.Drawing.Color.Empty;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Image = global::QuanLyBenhNhan.Properties.Resources.delete;
            this.btnXoa.ImageSize = new System.Drawing.Size(20, 20);
            this.btnXoa.Location = new System.Drawing.Point(527, 13);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnXoa.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnXoa.OnHoverForeColor = System.Drawing.Color.White;
            this.btnXoa.OnHoverImage = null;
            this.btnXoa.OnPressedColor = System.Drawing.Color.Black;
            this.btnXoa.Radius = 15;
            this.btnXoa.Size = new System.Drawing.Size(245, 71);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.AnimationHoverSpeed = 0.07F;
            this.btnSua.AnimationSpeed = 0.03F;
            this.btnSua.BackColor = System.Drawing.Color.Transparent;
            this.btnSua.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnSua.BorderColor = System.Drawing.Color.Black;
            this.btnSua.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSua.FocusedColor = System.Drawing.Color.Empty;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Image = global::QuanLyBenhNhan.Properties.Resources.updated;
            this.btnSua.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSua.Location = new System.Drawing.Point(38, 23);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnSua.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSua.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSua.OnHoverImage = null;
            this.btnSua.OnPressedColor = System.Drawing.Color.Black;
            this.btnSua.Radius = 15;
            this.btnSua.Size = new System.Drawing.Size(303, 71);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // frmManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1924, 877);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTong);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(2119, 933);
            this.MinimumSize = new System.Drawing.Size(1918, 933);
            this.Name = "frmManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang dành cho Quản lý";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUser_FormClosing);
            this.Load += new System.EventHandler(this.frmManager_Load);
            this.panelCapNhat.ResumeLayout(false);
            this.panelCapNhat.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridview)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelTong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCoDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaCircleButton btnReload;
        private Guna.UI.WinForms.GunaButton btnThem;
        private Guna.UI.WinForms.GunaButton btnXoa;
        private Guna.UI.WinForms.GunaButton btnSua;
        private System.Windows.Forms.TextBox txtNameUpdate;
        private System.Windows.Forms.Panel panelCapNhat;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chon;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridview;
        private System.Windows.Forms.PictureBox picCoDon;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI.WinForms.GunaButton btnLogout;
        private System.Windows.Forms.Label name;
        private Guna.UI.WinForms.GunaGradientButton btnDoiMatKhau;
        private Guna.UI.WinForms.GunaButton btnManager;
        private Guna.UI.WinForms.GunaButton btnRoom;
        private Guna.UI.WinForms.GunaButton btnKhanCap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTong;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
    }
}