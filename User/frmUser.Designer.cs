
namespace QuanLyBenhNhan
{
    partial class frmUser
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
            this.nhietDo = new System.Windows.Forms.TextBox();
            this.trieuChung = new System.Windows.Forms.TextBox();
            this.cbxPhong = new System.Windows.Forms.ComboBox();
            this.cbxNguoi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lableName = new System.Windows.Forms.Label();
            this.gunaGradientButton2 = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaGradientButton1 = new Guna.UI.WinForms.GunaGradientButton();
            this.btnCapNhat = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.btnBaoCao = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.SuspendLayout();
            // 
            // nhietDo
            // 
            this.nhietDo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nhietDo.Location = new System.Drawing.Point(418, 301);
            this.nhietDo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nhietDo.Name = "nhietDo";
            this.nhietDo.Size = new System.Drawing.Size(434, 40);
            this.nhietDo.TabIndex = 1;
            this.nhietDo.TextChanged += new System.EventHandler(this.nhietDo_TextChanged);
            this.nhietDo.Validating += new System.ComponentModel.CancelEventHandler(this.nhietDo_Validating);
            this.nhietDo.Validated += new System.EventHandler(this.nhietDo_Validated);
            // 
            // trieuChung
            // 
            this.trieuChung.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trieuChung.Location = new System.Drawing.Point(418, 368);
            this.trieuChung.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trieuChung.Name = "trieuChung";
            this.trieuChung.Size = new System.Drawing.Size(434, 40);
            this.trieuChung.TabIndex = 1;
            this.trieuChung.TextChanged += new System.EventHandler(this.trieuChung_TextChanged);
            this.trieuChung.Validating += new System.ComponentModel.CancelEventHandler(this.lb2_Validating);
            this.trieuChung.Validated += new System.EventHandler(this.trieuChung_Validated);
            // 
            // cbxPhong
            // 
            this.cbxPhong.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPhong.FormattingEnabled = true;
            this.cbxPhong.Location = new System.Drawing.Point(418, 164);
            this.cbxPhong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxPhong.Name = "cbxPhong";
            this.cbxPhong.Size = new System.Drawing.Size(434, 40);
            this.cbxPhong.TabIndex = 2;
            this.cbxPhong.SelectedIndexChanged += new System.EventHandler(this.cbxPhong_SelectedIndexChanged);
            // 
            // cbxNguoi
            // 
            this.cbxNguoi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNguoi.FormattingEnabled = true;
            this.cbxNguoi.Location = new System.Drawing.Point(418, 230);
            this.cbxNguoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxNguoi.Name = "cbxNguoi";
            this.cbxNguoi.Size = new System.Drawing.Size(434, 40);
            this.cbxNguoi.TabIndex = 2;
            this.cbxNguoi.SelectedIndexChanged += new System.EventHandler(this.cbxNguoi_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(304, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(610, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "CẬP NHẬT TÌNH TRẠNG CÁCH LY";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(231, 167);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(231, 233);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cá nhân";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(231, 301);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nhiệt độ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(231, 371);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Triệu chứng";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(869, 300);
            this.lb1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(0, 25);
            this.lb1.TabIndex = 5;
            this.lb1.Click += new System.EventHandler(this.lb1_Click);
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2.Location = new System.Drawing.Point(869, 339);
            this.lb2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(0, 25);
            this.lb2.TabIndex = 5;
            this.lb2.Click += new System.EventHandler(this.lb2_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lableName
            // 
            this.lableName.AutoSize = true;
            this.lableName.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableName.Location = new System.Drawing.Point(46, 46);
            this.lableName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lableName.Name = "lableName";
            this.lableName.Size = new System.Drawing.Size(0, 20);
            this.lableName.TabIndex = 6;
            // 
            // gunaGradientButton2
            // 
            this.gunaGradientButton2.AnimationHoverSpeed = 0.07F;
            this.gunaGradientButton2.AnimationSpeed = 0.03F;
            this.gunaGradientButton2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradientButton2.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.gunaGradientButton2.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.gunaGradientButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaGradientButton2.ForeColor = System.Drawing.Color.White;
            this.gunaGradientButton2.Image = global::QuanLyBenhNhan.Properties.Resources.logout;
            this.gunaGradientButton2.ImageSize = new System.Drawing.Size(25, 25);
            this.gunaGradientButton2.Location = new System.Drawing.Point(881, 517);
            this.gunaGradientButton2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gunaGradientButton2.Name = "gunaGradientButton2";
            this.gunaGradientButton2.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.gunaGradientButton2.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.gunaGradientButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton2.OnHoverImage = null;
            this.gunaGradientButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton2.Radius = 15;
            this.gunaGradientButton2.Size = new System.Drawing.Size(200, 52);
            this.gunaGradientButton2.TabIndex = 10;
            this.gunaGradientButton2.Text = "    Đăng xuất";
            this.gunaGradientButton2.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // gunaGradientButton1
            // 
            this.gunaGradientButton1.AnimationHoverSpeed = 0.07F;
            this.gunaGradientButton1.AnimationSpeed = 0.03F;
            this.gunaGradientButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradientButton1.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.gunaGradientButton1.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.gunaGradientButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaGradientButton1.ForeColor = System.Drawing.Color.White;
            this.gunaGradientButton1.Image = global::QuanLyBenhNhan.Properties.Resources.key;
            this.gunaGradientButton1.ImageSize = new System.Drawing.Size(25, 25);
            this.gunaGradientButton1.Location = new System.Drawing.Point(881, 449);
            this.gunaGradientButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gunaGradientButton1.Name = "gunaGradientButton1";
            this.gunaGradientButton1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.gunaGradientButton1.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.gunaGradientButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton1.OnHoverImage = null;
            this.gunaGradientButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.Radius = 15;
            this.gunaGradientButton1.Size = new System.Drawing.Size(200, 52);
            this.gunaGradientButton1.TabIndex = 10;
            this.gunaGradientButton1.Text = "   Đổi mật khẩu";
            this.gunaGradientButton1.Click += new System.EventHandler(this.button1Change);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.AnimationHoverSpeed = 0.07F;
            this.btnCapNhat.AnimationSpeed = 0.03F;
            this.btnCapNhat.BackColor = System.Drawing.Color.Transparent;
            this.btnCapNhat.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnCapNhat.BorderColor = System.Drawing.Color.Black;
            this.btnCapNhat.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnCapNhat.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnCapNhat.CheckedForeColor = System.Drawing.Color.White;
            this.btnCapNhat.CheckedImage = global::QuanLyBenhNhan.Properties.Resources.updated;
            this.btnCapNhat.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnCapNhat.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCapNhat.FocusedColor = System.Drawing.Color.Empty;
            this.btnCapNhat.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Image = global::QuanLyBenhNhan.Properties.Resources.updated;
            this.btnCapNhat.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCapNhat.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnCapNhat.Location = new System.Drawing.Point(525, 449);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnCapNhat.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCapNhat.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCapNhat.OnHoverImage = null;
            this.btnCapNhat.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnCapNhat.OnPressedColor = System.Drawing.Color.Black;
            this.btnCapNhat.Radius = 15;
            this.btnCapNhat.Size = new System.Drawing.Size(288, 120);
            this.btnCapNhat.TabIndex = 9;
            this.btnCapNhat.Text = "Cập nhật hồ sơ";
            this.btnCapNhat.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.AnimationHoverSpeed = 0.07F;
            this.btnBaoCao.AnimationSpeed = 0.03F;
            this.btnBaoCao.BackColor = System.Drawing.Color.Transparent;
            this.btnBaoCao.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnBaoCao.BorderColor = System.Drawing.Color.Black;
            this.btnBaoCao.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnBaoCao.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnBaoCao.CheckedForeColor = System.Drawing.Color.White;
            this.btnBaoCao.CheckedImage = global::QuanLyBenhNhan.Properties.Resources.virus;
            this.btnBaoCao.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnBaoCao.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBaoCao.FocusedColor = System.Drawing.Color.Empty;
            this.btnBaoCao.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.btnBaoCao.ForeColor = System.Drawing.Color.White;
            this.btnBaoCao.Image = global::QuanLyBenhNhan.Properties.Resources.sos;
            this.btnBaoCao.ImageSize = new System.Drawing.Size(30, 30);
            this.btnBaoCao.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnBaoCao.Location = new System.Drawing.Point(203, 449);
            this.btnBaoCao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnBaoCao.OnHoverBorderColor = System.Drawing.Color.Maroon;
            this.btnBaoCao.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBaoCao.OnHoverImage = null;
            this.btnBaoCao.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnBaoCao.OnPressedColor = System.Drawing.Color.Black;
            this.btnBaoCao.Radius = 15;
            this.btnBaoCao.Size = new System.Drawing.Size(288, 120);
            this.btnBaoCao.TabIndex = 9;
            this.btnBaoCao.Text = "Báo cáo khẩn cấp";
            this.btnBaoCao.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1181, 623);
            this.Controls.Add(this.gunaGradientButton2);
            this.Controls.Add(this.gunaGradientButton1);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnBaoCao);
            this.Controls.Add(this.lableName);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxNguoi);
            this.Controls.Add(this.cbxPhong);
            this.Controls.Add(this.trieuChung);
            this.Controls.Add(this.nhietDo);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUser_FormClosing);
            this.Load += new System.EventHandler(this.frmUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox nhietDo;
        private System.Windows.Forms.TextBox trieuChung;
        private System.Windows.Forms.ComboBox cbxPhong;
        private System.Windows.Forms.ComboBox cbxNguoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lableName;
        private Guna.UI.WinForms.GunaAdvenceTileButton btnBaoCao;
        private Guna.UI.WinForms.GunaAdvenceTileButton btnCapNhat;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton1;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton2;
    }
}