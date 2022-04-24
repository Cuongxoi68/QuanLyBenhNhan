using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBenhNhan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i = 3;
        
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\cuong\Desktop\CDIO\QuanLyBenhNhan\DataBase.mdf;Integrated Security=True");
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("login", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@tenTaiKhoan", txtTenTaiKhoan.Text));
                cmd.Parameters.Add(new SqlParameter("@matKhau", txtMatKhau.Text));
                SqlDataReader dta = cmd.ExecuteReader();
                if (!dta.HasRows == false)
                {
                    dta.Read();
                    if (dta[9].ToString() == "False")
                    {
                       
                        if (dta[10].ToString() == "1")
                        {
                            frmAdmin adminForm = new frmAdmin();
                            adminForm.idLogin = int.Parse(dta[0].ToString());
                            adminForm.uNameLogin = dta[1].ToString();
                            adminForm.fullNameLogin = dta[3].ToString();
                            adminForm.pass = dta[2].ToString();
                            adminForm.Show();
                            this.Hide();
                        }
                        else if (dta[10].ToString() == "2")
                        {
                            frmManager formManager = new frmManager();
                            formManager.idLogin = int.Parse(dta[0].ToString());
                            formManager.uNameLogin = dta[1].ToString();
                            formManager.fullNameLogin = dta[3].ToString();
                            formManager.pass = dta[2].ToString();
                            formManager.Show();
                            this.Hide();
                        }
                        else if (dta[10].ToString() == "3")
                        {
                            frmUser formUserGet = new frmUser();
                            formUserGet.idLogin = int.Parse(dta[0].ToString());
                            formUserGet.uNameLogin = dta[1].ToString();
                            formUserGet.fullNameLogin = dta[3].ToString();
                            formUserGet.pass = dta[2].ToString();
                            formUserGet.Show();
                            this.Hide();
                    }
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản của bạn đã bị khoá");
                    }


                }
                else
                {
                    if (i != 0)
                    {
                        MessageBox.Show("Sai tên tài khoản hoặc mật khẩu rồi :( \n Bạn còn '"+i+"' Lần thử");
                        i--;
                    }
                    else
                    {
                        MessageBox.Show("Bạn nhập sai quá nhiều lần vui lòng đợi 20 giây và thử lại!");
                        btnDangNhap.Visible = false;
                        Thread.Sleep(20000);
                        i = 3;
                        btnDangNhap.Visible = true;
                    }
                }

            }
            catch (SqlException)
            {
                MessageBox.Show("CÓ LỖI KẾT NỐI RỒI :(");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gunaElipsePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtTenTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
