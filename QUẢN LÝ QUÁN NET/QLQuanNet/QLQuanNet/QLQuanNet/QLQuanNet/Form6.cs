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
namespace QLQuanNet
{


    public partial class Form6 : Form
    {

        SqlConnection con;
        SqlCommand cmd;
        string str = @"Data Source = KIET\SQLEXPRESS;Initial Catalog = QuanLyPhongNet; Integrated Security = True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        public Form6()
        {
            InitializeComponent();
        }

        public void loadData()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT [NHÓM MÁY] FROM NhomMay where [TRẠNG THÁI] LIKE (N'%ĐANG TẮT%')";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dtg.DataSource = table;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection login = new SqlConnection(@"Data Source=KIET\SQLEXPRESS;Initial Catalog=QuanLyPhongNet;Integrated Security=True");

            try
            {
                string kh = "a";
                login.Open();
                string tk = txbTaiKhoan.Text;
                string mk = txbMatKhau.Text;
                string sql = "SELECT * from NguoiChoiVip  where [TÊN TÀI KHOẢN] = '" + tk + "' AND [MẬT KHẨU]= '" + mk + "' AND [KÍCH HOẠT] = '" + kh + "'";
                loadData();
                SqlCommand cmd = new SqlCommand(sql, login);
                SqlDataReader kiemtra = cmd.ExecuteReader();
                //
                if (kiemtra.Read() == true)
                {
                    String may = "Máy";
                    if (lab_May.Text == may)
                    {
                        MessageBox.Show("Hết máy!", "Lỗi");

                    }
                    else
                    {
                        string mo = "ĐANG MỞ";
                        cmd = con.CreateCommand();
                        cmd.CommandText = "update NhomMay set [NHÓM MÁY] = '" + lab_May.Text + "', [TRẠNG THÁI] = N'" + mo + "'where [NHÓM MÁY] = '" + lab_May.Text + "' ";
                        cmd.ExecuteNonQuery();
                        loadData();

                        string trangthai = "ĐĂNG NHẬP";
                        cmd = con.CreateCommand();
                        cmd.CommandText = "update NguoiChoiVip set [TÊN TÀI KHOẢN] = '" + txbTaiKhoan.Text + "',  [TRẠNG THÁI]=N'" + trangthai + "'where [TÊN TÀI KHOẢN] = '" + txbTaiKhoan.Text + "'";
                        cmd.ExecuteNonQuery();
                        loadData();
                        //
                        cmd = con.CreateCommand();
                        cmd.CommandText = "insert into DangNhapGame values('" + txbTaiKhoan.Text + "','"+lab_May.Text+"')";
                        cmd.ExecuteNonQuery();
                        frmChoiGame GAME = new frmChoiGame();
                        GAME.Show();
                        this.Hide();
                        
                    }


                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc đã bị khóa liên hệ Admin", "Lỗi");
                    txbMatKhau.Focus();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối!", "Lỗi");

            }

        }

        private void dtg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dtg.CurrentRow.Index;
            lab_May.Text = dtg.Rows[i].Cells[0].Value.ToString();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            con.Open();
            loadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
