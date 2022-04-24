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
    public partial class frmCapNhatHoSo : Form
    {
        public frmCapNhatHoSo()
        {
            InitializeComponent();
        }
        DataTable dt;
        public int hoSoID;
        public string tenDayDu;
        public int tuoi;
        public string diaChi;
        public string ngayBatDau;
        public int phongID;

        private void frmCapNhatHoSo_Load(object sender, EventArgs e)
        {
            txtHoVaTen.Text = tenDayDu;
            txtTuoi.Text = tuoi.ToString();
            txtDiaChi.Text = diaChi;
            dateTimePicker1.Text = ngayBatDau.ToString();
            dt = XuLyDuLieu.docDuLieuStored("getAllPhong", new object[] { }, new string[] { });
            for (int i = 0; dt.Rows.Count > i; i++)
            {
                cbxPhong.Items.Add(dt.Rows[i]["Tên_Phòng"].ToString());
                if(phongID == int.Parse(dt.Rows[i]["phongID"].ToString()))
                {
                    string name = dt.Rows[i]["Tên_Phòng"].ToString();
                    cbxPhong.SelectedItem = name;
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            phongID = int.Parse(dt.Rows[cbxPhong.SelectedIndex]["phongID"].ToString());
            object[] dulieu = new object[]
            {
                hoSoID,
                txtHoVaTen.Text,
                txtTuoi.Text,
                txtDiaChi.Text,
                dateTimePicker1.Value,
                phongID
            };
            string[] thamso = new string[]
            {
                "@hoSoID",
                "@tenDayDu",
                "@tuoi",
                "@diaChi",
                "@thoiGianBatDau",
                "@phongID"
            };
            if (XuLyDuLieu.capNhatDuLieuStored("updateHoSo", dulieu, thamso) == 1)
            {
                MessageBox.Show("Cập nhật thành công","Thành công!");
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại vui lòng kiểm tra và thử lại!", "Lỗi!!!!!");
            }
        }
    }
}
