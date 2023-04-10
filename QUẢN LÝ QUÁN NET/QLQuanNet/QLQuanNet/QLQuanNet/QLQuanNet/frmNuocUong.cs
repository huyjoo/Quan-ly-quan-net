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
    public partial class frmNuocUong : Form
    {

        SqlConnection con;
        SqlCommand cmd;
        string str = @"Data Source = KIET\SQLEXPRESS;Initial Catalog = QuanLyPhongNet; Integrated Security = True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public frmNuocUong()
        {
            InitializeComponent();
        }


        public void loadData()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT *FROM NuocUong";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void btx_Them_Click(object sender, EventArgs e)
        {
            try
            {
                int tien = Convert.ToInt32(txt_Gia.Text);
                if (txt_Gia.Text == "" && txt_TenNuoc.Text == "" && tien == 0)
                {

                    MessageBox.Show("Kiểm tra lại!", "Lỗi!");

                }
                else
                {
                    cmd = con.CreateCommand();
                    cmd.CommandText = "insert into NuocUong values('" + txt_Ma.Text + "', N'" + txt_TenNuoc.Text + "','" + txt_Gia.Text + "')";
                    cmd.ExecuteNonQuery();
                    loadData();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Kiểm tra lại!", "Thông báo");
            }

        }

        private void frmNuocUong_Load(object sender, EventArgs e)
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

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (txt_Ma.Text == "")//Bắt buộc chọn máy
            {
                MessageBox.Show("Chưa chọn  tài khoản", "Chưa chọn");
            }
            else
            {
                cmd = con.CreateCommand();
                cmd.CommandText = "update NuocUong set [MÃ NƯỚC] = '"+txt_Ma.Text+"', [TÊN NƯỚC] = N'"+txt_TenNuoc.Text+"',[GIÁ NƯỚC]=N'"+txt_Gia.Text+"'   where [MÃ NƯỚC] = '" + txt_Ma.Text + "' ";
                cmd.ExecuteNonQuery();
                loadData();
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {

            if (txt_Ma.Text == "")
            {
                MessageBox.Show("Chưa chọn món!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                cmd = con.CreateCommand();
                cmd.CommandText = "delete from NuocUong where [MÃ NƯỚC]=('" + txt_Ma.Text + "')";
                cmd.ExecuteNonQuery();
                loadData();
            }
        }

        private void btx_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            txt_Ma.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txt_TenNuoc.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txt_Gia.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
        }
    
    }
}
