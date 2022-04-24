using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBenhNhan
{
    public partial class frmManager : Form
    {
        public int idLogin;
        public string uNameLogin;
        public string fullNameLogin;
        public string pass;

        public frmManager()
        {
            InitializeComponent();
        }

        int check;

        //=============================================== Chuyen Chuc Nang ==============================
        private void btnUser_Click(object sender, EventArgs e)
        {
            check = 1;
            btnManager.BaseColor = Color.Khaki;
            btnRoom.BaseColor = Color.FromArgb(100, 88, 255);
            btnKhanCap.BaseColor = Color.FromArgb(100, 88, 255);
            picCoDon.Visible = false;
            dataGridview.Visible = true;
            btnReload.Visible = true;
            txtNameUpdate.Visible = true;
            panelTong.Visible = true;
            btnThem.Visible = true;
            btnSua.Visible = true;
            btnXoa.Visible = true;
            btnThem.Text = "Thêm cán bộ y tế";
            btnSua.Text = "Cập nhật cán bộ y tế";
            btnXoa.Text = "Xoá cán bộ y tế";
            txtNameUpdate.Text = "Click vào tên cán bộ muốn cập nhật";

            loadUser();
        }

        private void btnHoSo_Click(object sender, EventArgs e)
        {
            btnRoom.BaseColor = Color.Khaki;
            btnManager.BaseColor = Color.FromArgb(100, 88, 255);
            btnKhanCap.BaseColor = Color.FromArgb(100, 88, 255);
            check = 2;
            dataGridview.Visible = true;
            btnReload.Visible = true;
            txtNameUpdate.Visible = true;
            picCoDon.Visible = false;
            panelTong.Visible = true;
            btnThem.Visible = true;
            btnSua.Visible = true;
            btnXoa.Visible = true;
            btnThem.Text = "Thêm hồ sơ";
            btnSua.Text = "Cập nhật hồ sơ";
            btnXoa.Text = "Xoá hồ sơ";
            txtNameUpdate.Text = "Click vào tên hồ sơ muốn cập nhật";
            loadHoSo();
        }

        //=============================================== /Chuyen Chuc Nang ================================
        //=================================================== Void Load ====================================
        void loadUser()
        {
            dataGridview.DataSource = XuLyDuLieu.docDuLieuStored("getAllUser", new object[] { }, new string[] { });
            dataGridview.Columns[1].Visible = false;
        }

        void loadHoSo()
        {
            dataGridview.DataSource = XuLyDuLieu.docDuLieuStored("getAllHoSo", new object[] { }, new string[] { });
            dataGridview.Columns[1].Visible = false;
            dataGridview.Columns[5].Visible = false;
        }

        //=================================================== /Void Load ====================================
        //===================================================== BTN Them =====================================
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (check == 1)
            {
                frmThemUser themUser = new frmThemUser();
                themUser.Show();
            }
            else if (check == 2)
            {
                frmThemHoSo themHoSo = new frmThemHoSo();
                themHoSo.Show();
            }
        }

        //=================================================== /BTN Them =====================================
        //=================================================== /BTN Xoa =====================================
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
                            XuLyDuLieu.capNhatDuLieuStored("deleteUser", dulieu, thamso);
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

                loadUser();
            }
            else if (
                check == 2) //------------------------------------------------ Ho SO -----------------------------------
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
                                "@hoSoID"
                            };
                            XuLyDuLieu.capNhatDuLieuStored("deleteHoSo", dulieu, thamso);
                        }

                        MessageBox.Show("Xoá thành công " + dt.Rows.Count + " Hồ sơ ");
                    }
                    else
                    {
                        MessageBox.Show("Cần tick chọn Hồ sơ muốn xoá ở đầu bảng");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                loadHoSo();
            }
        }

        //=================================================== /BTN Xoa =====================================
        //==================================================== BTN Cap Nhat ================================
        frmCapNhatUser CapNhatUser = new frmCapNhatUser();
        frmCapNhatHoSo capNhatHoSo = new frmCapNhatHoSo();

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (check == 1)
            {
                if (txtNameUpdate.Text != "Click vào tên cán bộ muốn cập nhật")
                {
                    if (CapNhatUser.ShowDialog() == DialogResult.OK)
                    {
                        loadUser();
                        txtNameUpdate.Text = "Click vào tên cán bộ muốn cập nhật";
                    }
                }
            }
            else
            {
                if (txtNameUpdate.Text != "Click vào tên hồ sơ muốn cập nhật")
                {
                    if (capNhatHoSo.ShowDialog() == DialogResult.OK)
                    {
                        loadHoSo();
                        txtNameUpdate.Text = "Click vào tên hồ sơ muốn cập nhật";
                    }
                }
            }
        }

        private void dataGridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (check == 2)
            {
                try
                {
                    CapNhatUser.id = Convert.ToInt32(dataGridview.Rows[e.RowIndex].Cells[1].FormattedValue.ToString());
                    CapNhatUser.fullName = txtNameUpdate.Text =
                        dataGridview.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                    CapNhatUser.userName = dataGridview.Rows[e.RowIndex].Cells[2].Value.ToString();
                    CapNhatUser.email = dataGridview.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                    CapNhatUser.phoneNumber = dataGridview.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
                    CapNhatUser.diaChi = dataGridview.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
                    CapNhatUser.tuoi = int.Parse(dataGridview.Rows[e.RowIndex].Cells[7].FormattedValue.ToString());
                    CapNhatUser.gioitinh = dataGridview.Rows[e.RowIndex].Cells[8].FormattedValue.ToString();
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
                    txtNameUpdate.Text = capNhatHoSo.tenDayDu = dataGridview.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                    capNhatHoSo.tuoi = int.Parse(dataGridview.Rows[e.RowIndex].Cells[3].Value.ToString());
                    capNhatHoSo.diaChi = dataGridview.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                    capNhatHoSo.hoSoID = int.Parse(dataGridview.Rows[e.RowIndex].Cells[1].Value.ToString());
                    capNhatHoSo.phongID = int.Parse(dataGridview.Rows[e.RowIndex].Cells[7].Value.ToString());
                    capNhatHoSo.ngayBatDau = dataGridview.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (check == 1)
            {
                loadUser();
            }
            else if (check == 2)
            {
                loadHoSo();
            }
        }

        int i = 1;

        private void time_Tick(object sender, EventArgs e)
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
                picCoDon.Image = Properties.Resources.codong4;
                i++;
            }
            else if (i == 4)
            {
                picCoDon.Image = Properties.Resources.codong5;
                i = 0;
            }
        }

        private void frmManager_Load(object sender, EventArgs e)
        {
            picCoDon.Image = Properties.Resources.codong1;
            timer.Interval = 4000;
            timer.Start();
            name.Text = fullNameLogin;
        }

        //=================================================== /BTN Cap Nhat ================================
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }

        private void btnTruongHopKhanCap_Click(object sender, EventArgs e)
        {
            btnKhanCap.BaseColor = Color.Aqua;
            btnManager.BaseColor = Color.FromArgb(100, 88, 255);
            btnRoom.BaseColor = Color.FromArgb(100, 88, 255);
            btnReload.Visible = false;
            txtNameUpdate.Visible = false;
            picCoDon.Visible = false;
            btnThem.Visible = false;
            btnSua.Visible = false;
            btnXoa.Visible = false;
            dataGridview.Visible = true;
            panelTong.Visible = true;
            loadKhanCap();
            check = 3;
        }

        public void loadKhanCap()
        {
            dataGridview.DataSource = XuLyDuLieu.docDuLieuStored("getKhanCap", new object[] { }, new string[] { });
            dataGridview.Columns[1].Visible = true;
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
    }
}