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
    public partial class Form3 : Form
    {
        SqlConnection con;
        string str = @"Data Source = KIET\SQLEXPRESS;Initial Catalog = QuanLyPhongNet; Integrated Security = True";

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void đĂNGXUẤTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginFrom l = new LoginFrom();
            l.Show();
            this.Hide();
        }

        private void tRANGCHỦToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PanelFrom pn = new PanelFrom();
            pn.Show();
            this.Hide();
        }

        private void tHOÁTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnVip_Click(object sender, EventArgs e)
        {
            frmNguoiDungVip vip = new frmNguoiDungVip();
            vip.MdiParent = this;
            vip.Show();

        }

        private void mnTinhTien_Click(object sender, EventArgs e)
        {
            
            frmTinhTien tt = new frmTinhTien();
            tt.MdiParent = this;
            tt.Show();
            
        }

        private void kIỂMTRAKẾTNỐIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(str);
                con.Open();
                MessageBox.Show("Đã kết nối!","Kết nối");

                


            }
            catch (Exception)
            {
                MessageBox.Show("Chưa kết nối, kiểm tra lại!", "Lỗi!");
            }
        }

        private void nHÓMMÁYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhomMay nm = new frmNhomMay();
            nm.MdiParent = this;
            nm.Show();
        }

        private void tÀIKHOẢNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNguoiDungVip vip = new frmNguoiDungVip();
            vip.MdiParent = this;
            vip.Show();
        }

    }
}
