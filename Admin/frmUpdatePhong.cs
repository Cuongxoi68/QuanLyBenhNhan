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
    public partial class frmUpdatePhong : Form
    {
        public frmUpdatePhong()
        {
            InitializeComponent();
        }
        DataTable dt;
        public string idPhong;
        public string tenPhong;
        public int soLuong;
        public int accountID;
        private void frmUpdatePhong_Load(object sender, EventArgs e)
        {
            loadGiamSat();
            txtTenPhong.Text = tenPhong;
            txtSoLuong.Text = soLuong.ToString();
        }

        void loadGiamSat()
        {
            dt = XuLyDuLieu.docDuLieuStored("getAllUser", new object[] { }, new string[] { });
            for (int i = 0; dt.Rows.Count > i; i++)
            {
                    cbxNhanVien.Items.Add(dt.Rows[i]["tenDayDu"]);
                    if ((int)dt.Rows[i]["accountID"] == accountID)
                    {
                        string name = dt.Rows[i]["tenDayDu"].ToString();
                        cbxNhanVien.SelectedItem = name;
                    }
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn cập nhật" + tenPhong + "không", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                object[] dulieu =
                {
                    idPhong,
                    txtTenPhong.Text,
                    int.Parse(txtSoLuong.Text),
                    int.Parse(dt.Rows[cbxNhanVien.SelectedIndex]["accountID"].ToString())

            };
                string[] thamso =
                {
                    "@idPhong",
                    "@tenPhong",
                    "@soLuong",
                    "@accountID"

                };
                if (XuLyDuLieu.capNhatDuLieuStored("updatePhong", dulieu, thamso) == 1)
                {
                    MessageBox.Show("Cập nhật thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại");
                }
            }
            else
            {
                return;
            }
        }


    }
}