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
    public partial class Form2 : Form
    {
        public int id;
        public string matKhauCu;

        public Form2()
        {
            InitializeComponent();
        }

        int i = 4;

        private void Form2_Load(object sender, EventArgs e)
        {
            object[] dulieu = new object[]
            {
                id
            };
            string[] thamso = new string[]
            {
                "@id"
            };
            DataTable dt = XuLyDuLieu.docDuLieuStored("getPass", dulieu, thamso);
            matKhauCu = dt.Rows[0][0].ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string mkCuHash = XuLyDuLieu.MD5Hash(textBox1.Text);
            if (i != 0)
            {
                if (textBox2.Text == textBox3.Text)
                {
                    if (mkCuHash == matKhauCu)
                    {
                        try
                        {
                            string mkMoi = XuLyDuLieu.MD5Hash(textBox2.Text);
                            object[] dulieu = new object[]
                            {
                                id,
                                mkMoi,
                                0
                            };
                            string[] thamso = new string[]
                            {
                                "@id",
                                "@pas",
                                "@khoa"
                            };
                            if (XuLyDuLieu.capNhatDuLieuStored("doiMatKhau", dulieu, thamso) == 1)
                            {
                                MessageBox.Show("Đổi mật khẩu thành công");
                                this.Close();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bạn nhập sai mật khẩu cũ\nBạn còn '" + i + "' lần thử ");
                        i--;
                    }
                }
                else
                {
                    MessageBox.Show("Nhập lại mật khẩu không trùng khớp!");
                }
            }
            else
            {
                try
                {
                    object[] dulieu = new object[]
                    {
                        id,
                        matKhauCu,
                        1
                    };
                    string[] thamso = new string[]
                    {
                        "@id",
                        "@pas",
                        "@khoa"
                    };
                    if (XuLyDuLieu.capNhatDuLieuStored("doiMatKhau", dulieu, thamso) == 1)
                    {
                        MessageBox.Show("Tài khoản của bạn đã bị khoá!!");
                        Form1 form = new Form1();
                        form.ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Application.Exit();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}