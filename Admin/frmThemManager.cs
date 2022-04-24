using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBenhNhan.Admin
{
    public partial class frmThemUser : Form
    {
        public frmThemUser()
        {
            InitializeComponent();
        }
        void clear()
        {
            txtTenTaiKhoan.Text = "";
            txtMatKhau.Text = "";
            txtHoVaTen.Text = "";
            txtEmail.Text = "";
            txtSoDienThoai.Text = "";
            txtTuoi.Text = "";
            txtDiaChi.Text = "";
            cbxGioiTinh.SelectedIndex = 0;


        }

        public void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenTaiKhoan.Text == "" || txtMatKhau.Text == "" || txtHoVaTen.Text == "" || txtEmail.Text == "" || txtSoDienThoai.Text == "" || txtTuoi.Text == "" || txtDiaChi.Text == "" || cbxGioiTinh.Text == "")
            {
                MessageBox.Show("Bạn đã nhập thiếu thông tin vui lòng bổ sung!");
            }
            else
            {
                string password = (txtMatKhau.Text);
                try
                {
                    object[] duLieu = new object[]
                    {
                        txtTenTaiKhoan.Text,
                        password,
                        txtHoVaTen.Text,
                        txtEmail.Text,
                        txtSoDienThoai.Text,
                        txtTuoi.Text,
                        txtDiaChi.Text,
                        cbxGioiTinh.Text,
                    };

                    string[] thamSo = new string[]
                    {
                        "@tenTaiKhoan",
                        "@matKhau",
                        "@tenDayDu",
                        "@Email",
                        "SĐT",
                        "@Tuoi",
                        "@diaChi",
                        "@gioiTinh",
                    };
                    if(QuanLyBenhNhan.XuLyDuLieu.capNhatDuLieuStored("addManager", duLieu, thamSo) == 1)
                    {
                        MessageBox.Show("Thêm mới thành công");
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Thêm mới thất bại vui lòng kiểm tra lại");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Thêm thất bại - Có thể bạn đã nhập sai thông tin" +
                            "Vui lòng kiểm tra lại");
                }
            }
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }
    }
}