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
    public partial class frmThemHoSo : Form
    {
        public frmThemHoSo()
        {
            InitializeComponent();
        }
        void clear()
        {
            txtHoVaTen.Text = "";
            txtTuoi.Text = "";
            txtDiaChi.Text = "";


        }
        DataTable dt;
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtHoVaTen.Text == "" || txtTuoi.Text == "" || txtDiaChi.Text == "")
            {
                MessageBox.Show("Bạn đã nhập thiếu thông tin vui lòng bổ sung!");
            }
            else
            {
                try
                {
                    //tenTaiKhoan,matKhau,tenDayDu,Email,SĐT,Tuoi,diaChi,gioiTinh,Active,chucVuID
                    //@tenTaiKhoan,@matKhau,@hoVaten,@email,@sdt,@tuoi,@diaChi,@gioiTinh,1,2
                    object[] duLieu = new object[]
                    {
                        txtHoVaTen.Text,
                        txtTuoi.Text,
                        txtDiaChi.Text,
                        int.Parse(dt.Rows[cbxPhong.SelectedIndex]["phongID"].ToString())
                        };

                    string[] thamSo = new string[]
                    {
                        "@hoTen",
                        "@tuoi",
                        "@diaChi",
                        "@phongID"
                    };
                    if (XuLyDuLieu.capNhatDuLieuStored("addHoSo", duLieu, thamSo) == 1)
                    {
                        clear();
                        MessageBox.Show("Thêm mới thành công");
                    }
                    else
                    {
                        MessageBox.Show("Thêm mới thất bại");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void frmThemHoSo_Load(object sender, EventArgs e)
        {
            dt = XuLyDuLieu.docDuLieuStored("getAllPhong", new object[] { }, new string[] { });
            for(int i = 0; dt.Rows.Count > i; i++)
            {
                cbxPhong.Items.Add(dt.Rows[i]["Tên_Phòng"].ToString());
            }
        }
    }
}
