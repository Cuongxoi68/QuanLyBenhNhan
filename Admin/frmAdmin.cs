using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QuanLyBenhNhan.Admin;
using System.IO;

namespace QuanLyBenhNhan
{

    public partial class frmAdmin : Form
    {
        public int idLogin;
        public string uNameLogin;
        public string fullNameLogin;
        public string pass;
        public frmAdmin()
        {
            InitializeComponent();
        }
        int check;
        //===================================Click Chuyen chuc Nang ============================
        private void btnQuanLyManager_Click(object sender, EventArgs e)
        {
            btnManager.BaseColor = Color.Khaki;
            btnRoom.BaseColor = Color.FromArgb(100, 88, 255);
            btnKhanCap.BaseColor = Color.FromArgb(100, 88, 255);
            btnReload.Visible = true;
            picCoDon.Visible = false;
            dataGridview.Visible = true;
            panelTong.Visible = true;
            btnThem.Visible = true;
            check = 1;
            btnSua.Visible = true;
            btnXoa.Visible = true;
            txtNameUpdate.Visible = true;
            btnReload.Visible = true;
            btnThem.Text = "Thêm Quản lý";
            btnSua.Text = "Sửa Quản lý";
            btnXoa.Text = "Xoá Quản lý";
            loadManager();

        }
        private void btnQuanLyPhong_Click(object sender, EventArgs e)
        {
            btnReload.Visible = true;
            btnReload.Visible = true;
            check = 2;
            btnRoom.BaseColor = Color.Khaki;
            btnManager.BaseColor = Color.FromArgb(100, 88, 255);
            btnKhanCap.BaseColor = Color.FromArgb(100, 88, 255);
            btnThem.Visible = true;
            btnSua.Visible = true;
            btnXoa.Visible = true;
            picCoDon.Visible = false;
            dataGridview.Visible = true;
            panelTong.Visible = true;
            btnThem.Text = "Thêm phòng";
            btnSua.Text = "Sửa phòng";
            btnXoa.Text = "Xoá Phòng";
            txtNameUpdate.Visible = true;
            txtNameUpdate.Text = "Click vào tên phòng muốn cập nhật";
            loadPhong();
        }
        private void btnTruongHopKhanCap_Click(object sender, EventArgs e)
        {
            check = 3;
            btnReload.Visible = false;
            panelTong.Visible = false;
            btnThem.Visible = false;
            btnSua.Visible = false;
            btnXoa.Visible = false;
            txtNameUpdate.Visible = false;
            picCoDon.Visible = false;
            dataGridview.Visible = true;
            panelTong.Visible = true;
            btnKhanCap.BaseColor = Color.Khaki;
            btnManager.BaseColor = Color.FromArgb(100, 88, 255);
            btnRoom.BaseColor = Color.FromArgb(100, 88, 255);
            loadKhanCap();

        }
        //===================================/Click Chuyen chuc Nang ============================
        //============================================= Ham Load ===========================
        public void loadKhanCap()
        {
            dataGridview.DataSource = XuLyDuLieu.docDuLieuStored("getKhanCap", new object[] { }, new string[] { });
            dataGridview.Columns[1].Visible = true;
            dataGridview.Columns[0].Visible = false;
        }
        public void loadManager()
        {
            DataTable dt = XuLyDuLieu.docDuLieuStored("getAllManager", new object[] { }, new string[] { });
            dataGridview.Columns[0].Visible = true;
            dataGridview.DataSource = dt;
            dataGridview.Columns[1].Visible = false;

        }
        void loadPhong()
        {
            dataGridview.Columns[0].Visible = true;
            dataGridview.DataSource = XuLyDuLieu.docDuLieuStored("getAllPhong", new object[] { }, new string[] { });
            dataGridview.Columns[1].Visible = false;
        }
        //=======================================/Ham Load =====================================
        //========================================= Them ============================
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (check == 1)
            {
                Admin.frmThemUser frmThemManager = new Admin.frmThemUser();
                frmThemManager.Show();
            }
            else if(check == 2)
            {
                frmThemPhong frmThemPhong = new frmThemPhong();
                frmThemPhong.Show();
            }
        }
        //======================================= /Them ============================
        //=========================================== Xoa ===============================
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dataGridview.DataSource;
            dt = dt.GetChanges();
            if (check == 1)
            {
                try
                {
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        for (int i = 0; dt.Rows.Count > i; i++)
                        {
                            object[] dulieu = new object[]
                            {
                        int.Parse(dt.Rows[i][1].ToString())
                            };
                            string[] thamso = new string[]
                            {
                        "@idAccount"
                            };
                            XuLyDuLieu.capNhatDuLieuStored("deleteManager", dulieu, thamso);
                        }
                        MessageBox.Show("Xoá thành công " + dt.Rows.Count + " tài Khoản");

                    }
                    else
                    {
                        MessageBox.Show("Cần tích chọn tài khoản muốn xoá ở đầu bảng");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Có lỗi vui lòng thử lại");
                }
                loadManager();
            }
            else  //--------------------------------Phong --------------
            {
                try
                {
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        for (int i = 0; dt.Rows.Count > i; i++)
                        {
                            object[] dulieu = new object[]
                            {
                                int.Parse(dt.Rows[i][1].ToString())
                            };
                            string[] thamso = new string[]
                            {
                                "@idPhong"
                            };
                            XuLyDuLieu.capNhatDuLieuStored("deletePhong", dulieu, thamso);
                        }
                        MessageBox.Show("Xoá thành công " + dt.Rows.Count + " Phòng ");

                    }
                    else
                    {
                        MessageBox.Show("Cần tick chọn phòng muốn xoá ở đầu bảng");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Có lỗi vui lòng thử lại");
                }
                loadPhong();
            }
        }
        //===============================================/Xoa ========================================
        //=============================================== Update =================================
        frmUpdateManager frmUpdate = new frmUpdateManager();
        frmUpdatePhong frmUpdatePhong = new frmUpdatePhong();
        private void dataGridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (check == 1)
            {
                try
                {
                    frmUpdate.id = Convert.ToInt32(dataGridview.Rows[e.RowIndex].Cells[1].FormattedValue.ToString());
                    frmUpdate.fullName = txtNameUpdate.Text = dataGridview.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                    frmUpdate.userName = dataGridview.Rows[e.RowIndex].Cells[2].Value.ToString();
                    frmUpdate.email = dataGridview.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                    frmUpdate.phoneNumber = dataGridview.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
                    frmUpdate.diaChi = dataGridview.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
                    frmUpdate.tuoi = int.Parse(dataGridview.Rows[e.RowIndex].Cells[7].FormattedValue.ToString());
                    frmUpdate.gioitinh = dataGridview.Rows[e.RowIndex].Cells[8].FormattedValue.ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("Địa điểm chọn không hợp lệ");
                }
            }
            else
            {
                try
                {
                    frmUpdatePhong.idPhong = dataGridview.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                    frmUpdatePhong.tenPhong = txtNameUpdate.Text = dataGridview.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                    frmUpdatePhong.soLuong = int.Parse(dataGridview.Rows[e.RowIndex].Cells[3].FormattedValue.ToString());
                    frmUpdatePhong.accountID = int.Parse(dataGridview.Rows[e.RowIndex].Cells[4].FormattedValue.ToString());
                }
                catch (Exception)
                {
                    MessageBox.Show("Địa điểm chọn không hợp lệ");
                }
            }
        }
        private void btnSua_Click(object sender, EventArgs e) // BTN Sua
        {
            if (check == 1)
            {
                if (txtNameUpdate.Text != "Click vào tên của tài khoản muốn cập nhật")
                {
                    if (frmUpdate.ShowDialog() == DialogResult.OK)
                    {
                        loadManager();
                        txtNameUpdate.Text = "Click vào tên của tài khoản muốn cập nhật";
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn tài khoản muốn cập nhật");
                }
            }
            else
            {
                if (txtNameUpdate.Text != "Click vào tên phòng muốn cập nhật")
                {
                    if (frmUpdatePhong.ShowDialog() == DialogResult.OK)
                    {
                        loadPhong();
                        txtNameUpdate.Text = "Click vào tên phòng muốn cập nhật";
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn phòng muốn cập nhật");
                }
            }
        }
        //==========================/Update===============================
        int i = 1;
        private void timer_Tick(object sender, EventArgs e)
        {
            if (check == 3)
            {
                loadKhanCap();
            }
            if (i == 0)
            {
                picCoDon.Image = Properties.Resources.codong1;
                i++;
            }
            else if (i == 1)
            {
                picCoDon.Image = Properties.Resources.codong2;
                i++;
            }
            else if (i == 2)
            {
                picCoDon.Image = Properties.Resources.codong3;
                i++;
            }
            else if (i == 3)
            {
                picCoDon.Image = Properties.Resources.codong4; i++;
            }
            else if (i == 4)
            {
                picCoDon.Image = Properties.Resources.codong5; i = 0;
            }
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            picCoDon.Image = Properties.Resources.codong1;
            timer.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (check == 1)
            {
                loadManager();
            }
            else if(check == 2)
            {
                loadPhong();
            }
        }
        private void frmAdmin_Load(object sender, EventArgs e)
        {
            timer.Start();
            name.Text = fullNameLogin;
        }
        //!===================================================================Quan Ly Phong ====================================================================
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.id = idLogin;
            form2.matKhauCu = pass;
            form2.Show();
        }

        private void txtNameUpdate_TextChanged(object sender, EventArgs e)
        {

        }

        private void name_Click(object sender, EventArgs e)
        {

        }
    }
}
