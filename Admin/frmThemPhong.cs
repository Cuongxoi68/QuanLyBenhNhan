using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBenhNhan
{
    public partial class frmThemPhong : Form
    {
        public frmThemPhong()
        {
            InitializeComponent();
        }
        private void frmThemPhong_Load(object sender, EventArgs e)
        {
            loadGiamSat();
        }
        DataTable dt;
        void loadGiamSat()
        {
            dt = XuLyDuLieu.docDuLieuStored("getAllUser", new object[] { }, new string[] { });
            for (int i = 0; dt.Rows.Count > i; i++)
            {
                cbxNhanVien.Items.Add(dt.Rows[i]["tenDayDu"]);
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtSoLuong.Text != ""||txtTenPhong.Text != ""||cbxNhanVien.SelectedIndex != -1)
            {
                try
                {
                    object[] dulieu = new object[]
                {
                txtTenPhong.Text,
                int.Parse(txtSoLuong.Text),
                int.Parse(dt.Rows[cbxNhanVien.SelectedIndex]["accountID"].ToString())
                };
                    string[] thamso = new string[]
                    {
                "@tenPhong",
                "@soLuong",
                "accountID"
                    };
                    if (XuLyDuLieu.capNhatDuLieuStored("addPhong", dulieu, thamso) == 1)
                    {
                        MessageBox.Show("Thêm phòng thành công");
                    }
                    else
                    {
                        MessageBox.Show("Thêm phòng thất bại");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Có lỗi vui lòng kiểm tra lại giá trị");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ giá trị");
            }

        }


    }
}
