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
    public partial class frmCapNhatUser : Form
    {
        public string fullName;
        public string userName;
        public string email;
        public string phoneNumber;
        public string diaChi;
        public int tuoi;
        public string gioitinh;
        public int id;
        public frmCapNhatUser()
        {
            InitializeComponent();
        }

        private void frmCapNhatUser_Load(object sender, EventArgs e)
        {

            txtHoVaTen.Text = fullName;
            if (gioitinh == "Nam")
            {
                cbxGioiTinh.SelectedIndex = 0;
            }
            else
            {
                cbxGioiTinh.SelectedIndex = 1;
            }
            txtTuoi.Text = tuoi.ToString();
            txtEmail.Text = email;
            txtSoDienThoai.Text = phoneNumber;
            txtDiaChi.Text = diaChi;
            cbxGioiTinh.SelectedValue = gioitinh;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            object[] duLieu = new object[]
             {
                 id,
                 txtHoVaTen.Text,
                 txtEmail.Text,
                 txtSoDienThoai.Text,
                 txtDiaChi.Text,
                 int.Parse(txtTuoi.Text),
                 cbxGioiTinh.Text,
                 cbxKhoa.Checked,
             };

            string[] thamSo = new string[]
            {
                "@id",
                "@tenDayDu",
                 "@email",
                 "sdt",
                  "@diaChi",
                  "@tuoi",
                  "@gioiTinh",
                  "@active"
            };

            if (QuanLyBenhNhan.XuLyDuLieu.capNhatDuLieuStored("updateManager", duLieu, thamSo) == 1)
            {
                MessageBox.Show("Cập nhật thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại");
                return;
            }
        }
    }
}
