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
                string password = XuLyDuLieu.MD5Hash(txtMatKhau.Text);
                try
                {
                    //tenTaiKhoan,matKhau,tenDayDu,Email,SĐT,Tuoi,diaChi,gioiTinh,Active,chucVuID
                    //@tenTaiKhoan,@matKhau,@hoVaten,@email,@sdt,@tuoi,@diaChi,@gioiTinh,1,2
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
                    if(XuLyDuLieu.capNhatDuLieuStored("addUser",duLieu,thamSo)==1)
                    {
                        clear();
                        MessageBox.Show("Thêm mới thành công");
                    }
                    else
                    {
                        MessageBox.Show("Thêm mới thất bại");
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Thêm thất bại - Có thể tài khoản đã bị trùng" +
                            "Vui lòng kiểm tra lại");
                }
            }
        }
    }
}
