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

    
    public partial class Form5 : Form
    {

        SqlConnection con;
        string str = @"Data Source = KIET\SQLEXPRESS;Initial Catalog = QuanLyPhongNet; Integrated Security = True";
        public Form5()
        {
            InitializeComponent();
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

        private void đĂNGXUẤTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginFrom l = new LoginFrom();
            l.Show();
            this.Hide();
        }

        private void kIỂMTRAKẾTNỐIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(str);
                con.Open();
                MessageBox.Show("Đã kết nối!", "Kết nối");




            }
            catch (Exception)
            {
                MessageBox.Show("Chưa kết nối, kiểm tra lại!", "Lỗi!");
            }
        }

        private void tÀIKHOẢNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoAn DoAn = new frmDoAn();
            DoAn.MdiParent = this;
            DoAn.Show();
        }

        private void nHÓMMÁYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNuocUong Nuoc = new frmNuocUong();
            Nuoc.MdiParent = this;
            Nuoc.Show();
        }

        private void mnTinhTien_Click(object sender, EventArgs e)
        {
            frmTheNap the = new frmTheNap();
            the.MdiParent = this;
            the.Show();

        }

        private void lỊCHSỬToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLichSu lichsu = new frmLichSu();
            lichsu.MdiParent = this;
            lichsu.Show();
        }
    }
}
