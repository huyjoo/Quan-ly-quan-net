using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLQuanNet
{
    public partial class PanelFrom : Form
    {
        public PanelFrom()
        {
            InitializeComponent();
        }

     

        private void PanelFrom_Load(object sender, EventArgs e)
        {

        }


        private void pctDangXuat_Click(object sender, EventArgs e)
        {
            LoginFrom login = new LoginFrom();
            login.Show();
            this.Hide();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Form3 NguoiDung = new Form3();
            NguoiDung.Show();//Hiển thị from mới
            this.Hide();//Ân from hiện tại 
            
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form3 NguoiDung = new Form3();
            NguoiDung.Show();//Hiển thị from mới
            this.Hide();//Ân from hiện tại 
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form3 NguoiDung = new Form3();
            NguoiDung.Show();//Hiển thị from mới
            this.Hide();//Ân from hiện tại 
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form5 DV = new Form5();
            DV.Show();
            this.Hide();

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form6 login = new Form6();
            login.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form6 login = new Form6();
            login.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
