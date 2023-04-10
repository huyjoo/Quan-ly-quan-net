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
    public partial class frmNhomMay : Form
    {

        SqlConnection con;
        SqlCommand cmd;
        string str = @"Data Source = KIET\SQLEXPRESS;Initial Catalog = QuanLyPhongNet; Integrated Security = True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();


       public void loadData()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT *FROM NhomMay";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dtg.DataSource = table;
        }
        public frmNhomMay()
        {
            InitializeComponent();
        }

        private void btxThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dtg.CurrentRow.Index;
            txb_MayChoi.Text = dtg.Rows[i].Cells[0].Value.ToString();
            cb_TrangThai.Text = dtg.Rows[i].Cells[1].Value.ToString();
            txb_GhiChu.Text = dtg.Rows[i].Cells[2].Value.ToString();
        }

        private void frmNhomMay_Load(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(str);
                con.Open();
                loadData();
                lab_Text.Text = "ĐÃ KẾT NỐI";


            }
            catch (Exception)
            {
                lab_Con.Text = "xxxxxxxxx";
                lab_Text.Text = "CHƯA KẾT NỐI";
                MessageBox.Show("Lỗi kết nối!", "Lỗi!");
            }

        }

        private void btx_Luu_Click(object sender, EventArgs e)
        {

            if (txb_MayChoi.Text == "")//Bắt buộc chọn máy
            {
                MessageBox.Show("Chưa chọn máy!", "Chưa chọn");
            }
            else
            {
                cmd = con.CreateCommand();
                cmd.CommandText = "update NhomMay set [NHÓM MÁY] = '" + txb_MayChoi.Text + "', [TRẠNG THÁI] = N'" + cb_TrangThai.Text + "', [GHI CHÚ] = N'" + txb_GhiChu.Text + "'where [NHÓM MÁY] = '" + txb_MayChoi.Text + "' ";
                cmd.ExecuteNonQuery();
                loadData();
            }
        }

        private void bxt_TatAll_Click(object sender, EventArgs e)
        {
            string tat = "ĐANG TẮT";
            cmd = con.CreateCommand();
            cmd.CommandText = "update NhomMay set  [TRẠNG THÁI] = N'" +tat+ "'";
            cmd.ExecuteNonQuery();
            loadData();
        }

        private void btx_BatAll_Click(object sender, EventArgs e)
        {
            string mo = "ĐANG MỞ";
            cmd = con.CreateCommand();
            cmd.CommandText = "update NhomMay set  [TRẠNG THÁI] = N'" + mo + "'";
            cmd.ExecuteNonQuery();
            loadData();
        }
    }
}
