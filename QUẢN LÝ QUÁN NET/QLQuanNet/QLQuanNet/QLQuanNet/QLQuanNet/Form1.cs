using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace QLQuanNet
{
    public partial class LoginFrom : Form
    {

       


        public LoginFrom()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            string mk = txbMatKhau.Text;
            MD5 mh = MD5.Create();
            //Chuyển kiểu chuổi thành kiểu byte
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(mk);//Truyền vào chuổi mã hóa
            //mã hóa chuỗi đã chuyển
            byte[] hash = mh.ComputeHash(inputBytes);
            //tạo đối tượng StringBuilder (làm việc với kiểu dữ liệu lớn)
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            string SQL = @"Data Source = KIET\SQLEXPRESS;Initial Catalog = QuanLyPhongNet; Integrated Security = True";
            SqlConnection con = new SqlConnection(SQL);
            try
            {
                con.Open();
                string tk = txbTaiKhoan.Text;
                string mk2 = sb.ToString();
                string sql = "SELECT * FROM Login where TaiKhoan = '" +tk+ "' AND MatKhau= '" +mk2+ "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    Form7 fm = new Form7();
                    fm.Show();
                    PanelFrom Login = new PanelFrom();
                    Login.Show();
                    

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi");
                    txbMatKhau.Focus();
                }


            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối!", "Lỗi");

            }
        }

        private void Login_DangXuat(object sender, EventArgs e)
        {
            (sender as PanelFrom).Close();
            this.Show();
        }
    }

        
}
