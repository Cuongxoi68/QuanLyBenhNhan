using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace QuanLyBenhNhan
{
    public static class XuLyDuLieu
    {
        private static SqlConnection KetNoiCSLD()
        {
            SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\cuong\Desktop\CDIO\QuanLyBenhNhan\DataBase.mdf;Integrated Security=True");
            connect.Open();
            return connect;
        }
        public static DataTable docDuLieuStored(string tenStored, object[] duLieu, string[] tenThamSo)
        {
            SqlCommand command = new SqlCommand(tenStored, KetNoiCSLD());
            command.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < duLieu.Length; i++)
                command.Parameters.Add(new SqlParameter(tenThamSo[i], duLieu[i]));
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public static SqlDataReader docDuLieuReader(string tenStored)
        {
            SqlCommand command = new SqlCommand(tenStored, KetNoiCSLD());
            command.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }
        public static int capNhatDuLieuStored(string tenStored, object[] duLieu, string[] tenThamSo)
        {
            SqlCommand command = new SqlCommand(tenStored, KetNoiCSLD());
            command.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < duLieu.Length; i++)
                command.Parameters.Add(new SqlParameter(tenThamSo[i], duLieu[i]));
            return command.ExecuteNonQuery();
        }
        public static string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }
    }

}
