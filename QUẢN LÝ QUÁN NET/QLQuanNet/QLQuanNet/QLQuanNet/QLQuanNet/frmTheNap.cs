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
    public partial class frmTheNap : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string str = @"Data Source = KIET\SQLEXPRESS;Initial Catalog = QuanLyPhongNet; Integrated Security = True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public frmTheNap()
        {
            InitializeComponent();
        }


        public void loadData()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM TheCao";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTheNap_Load(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(str);
                con.Open();
                loadData();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối!", "Lỗi!");
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                int tien = Convert.ToInt32(com_MenhGia.Text);
                if (txt_Ma.Text == "" && txt_Seri.Text == "" && tien == 0)
                {

                    MessageBox.Show("Kiểm tra lại!", "Lỗi!");

                }
                else
                {
                    cmd = con.CreateCommand();
                    cmd.CommandText = "insert into TheCao  values('" + txt_Seri.Text + "', N'" + txt_Ma.Text + "','" + com_MenhGia.Text + "')";
                    cmd.ExecuteNonQuery();
                    loadData();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Kiểm tra lại!", "Thông báo");
            }
        }

        private void btx_Xoa_Click(object sender, EventArgs e)
        {

            if (txt_Seri.Text == "")
            {
                MessageBox.Show("Chưa chọn thẻ!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                cmd = con.CreateCommand();
                cmd.CommandText = "delete from TheCao where [SERI]=('" + txt_Seri.Text + "')";
                cmd.ExecuteNonQuery();
                loadData();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            txt_Seri.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txt_Ma.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            com_MenhGia.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
        }
    }
}
