using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyBenhNhan
{
    public partial class frmUser : Form
    {
        public int idLogin;
        public string uNameLogin;
        public string fullNameLogin;
        public string pass;

        public frmUser()
        {
            InitializeComponent();
        }

        DataTable table = new DataTable();

        private void frmUser_Load(object sender, EventArgs e)
        {
            lableName.Text = "CÁN BỘ QUẢN LÝ:  '" + fullNameLogin + "'";

            object[] dulieu = new object[]
            {
                idLogin
            };
            string[] thamso = new string[]
            {
                "accountID"
            };
            table = XuLyDuLieu.docDuLieuStored("getPhongU", dulieu, thamso);
            for (int i = 0; table.Rows.Count > i; i++)
            {
                cbxPhong.Items.Add(table.Rows[i]["tenPhong"].ToString());
            }
        }

        DataTable dtHoSo;

        private void cbxPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            object[] dulieu = new object[]
            {
                int.Parse(table.Rows[cbxPhong.SelectedIndex]["phongID"].ToString())
            };
            string[] thamso = new string[]
            {
                "@idPhong"
            };
            dtHoSo = XuLyDuLieu.docDuLieuStored("getNguoiCachLy", dulieu, thamso);
            for (int i = 0; dtHoSo.Rows.Count > i; i++)
            {
                cbxNguoi.Items.Add(dtHoSo.Rows[i]["tenDayDu"].ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cbxPhong.SelectedIndex == -1 || cbxNguoi.SelectedIndex == -1 || nhietDo.Text == "" ||
                trieuChung.Text == "" || nhietDo == null || trieuChung == null || cbxPhong.Text =="")
            {
                MessageBox.Show("Bạn đã nhập thiếu dữ liệu cần thiết");
            }
            else
            {
                try
                {
                    object[] dulieu = new object[]
                    {
                        int.Parse(dtHoSo.Rows[cbxNguoi.SelectedIndex]["hoSoID"].ToString()),
                        true,
                        int.Parse(nhietDo.Text),
                        trieuChung.Text
                    };
                    string[] thamso = new string[]
                    {
                        "@idHoSo",
                        "@tinhTrang",
                        "@nhietDo",
                        "@trieuChung"
                    };
                    if (XuLyDuLieu.capNhatDuLieuStored("updateTinhtrang", dulieu, thamso) == 1)
                    {
                        MessageBox.Show("Cập nhật tình trạng thành công");
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật tình trạng thất bại vui lòng kiểm tra lại");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("có lỗi dữ liệu vui lòng kiểm tra lại");
                }
            }
        }

        void clear()
        {
            trieuChung.Text = "";
            nhietDo.Text = "";
            cbxNguoi.SelectedIndex = -1;
            btnCapNhat.Visible = true;
            lb1.Text = "";
            lb2.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                object[] dulieu = new object[]
                {
                    int.Parse(dtHoSo.Rows[cbxNguoi.SelectedIndex]["hoSoID"].ToString()),
                    false,
                    int.Parse(nhietDo.Text),
                    trieuChung.Text
                };
                string[] thamso = new string[]
                {
                    "@idHoSo",
                    "@tinhTrang",
                    "@nhietDo",
                    "@trieuChung"
                };
                if (XuLyDuLieu.capNhatDuLieuStored("updateTinhtrang", dulieu, thamso) == 1)
                {
                    MessageBox.Show("Báo cáo thành công");
                    clear();
                }
                else
                {
                    MessageBox.Show("Cập nhật tình trạng thất bại vui lòng kiểm tra lại");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi dữ liệu vui lòng kiểm tra lại");
            }
        }

        private void nhietDo_Validating(object sender, CancelEventArgs e)
        {
            if (int.Parse(nhietDo.Text) >= 38 || int.Parse(nhietDo.Text) <= 36)
            {
                lb1.Text = "có bất thường về nhiệt độ \n cần báo cáo khẩn cấp!!!";
                lb1.ForeColor = Color.Red;
                btnCapNhat.Visible = false;
            }
            else
            {
                lb1.Text = "Nhiệt độ bình thường";
                lb1.ForeColor = Color.Green;
                btnCapNhat.Visible = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lb1.ForeColor == Color.Red || lb2.ForeColor == Color.Red)
            {
                lb1.ForeColor = Color.Blue;
                lb2.ForeColor = Color.Blue;
            }
            else if (lb1.ForeColor == Color.Blue || lb2.ForeColor == Color.Red)
            {
                lb1.ForeColor = Color.Red;
                lb2.ForeColor = Color.Red;
            }
        }

        private void lb2_Validating(object sender, CancelEventArgs e)
        {
            if (trieuChung.Text == "sốt" || trieuChung.Text == "sot" || trieuChung.Text == "đau họng" ||
                trieuChung.Text == "dau hong")
            {
                lb2.Text = "Có triệu chứng bất thường\n Cần báo cáo khẩn cấp!!!";
                lb2.ForeColor = Color.Red;
                btnCapNhat.Visible = false;
            }
            else
            {
                btnCapNhat.Visible = true;
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }

        private void button1Change(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.id = idLogin;
            form2.matKhauCu = pass;
            form2.Show();
        }

        private void trieuChung_Validated(object sender, EventArgs e)
        {
            if (trieuChung.Text == "sốt" || trieuChung.Text == "sot" || trieuChung.Text == "đau họng" ||
                trieuChung.Text == "dau hong")
            {
                lb2.Text = "có triệu chứng bất thường\n cần báo cáo khẩn cấp!!!";
                lb2.ForeColor = Color.Red;
                btnCapNhat.Visible = false;
            }
            else
            {
                btnCapNhat.Visible = true;
            }
        }

        private void nhietDo_Validated(object sender, EventArgs e)
        {
            if (int.Parse(nhietDo.Text) >= 38 || int.Parse(nhietDo.Text) <= 36)
            {
                lb1.Text = "có bất thường về nhiệt độ \n cần báo cáo khẩn cấp!!!";
                lb1.ForeColor = Color.Red;
                btnCapNhat.Visible = false;
            }
            else
            {
                lb1.Text = "Nhiệt độ bình thường";
                lb1.ForeColor = Color.Green;
                btnCapNhat.Visible = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nhietDo_TextChanged(object sender, EventArgs e)
        {

        }

        private void trieuChung_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxNguoi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lb2_Click(object sender, EventArgs e)
        {

        }

        private void lb1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}