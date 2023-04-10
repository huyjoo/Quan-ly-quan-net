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
    public partial class frmLichSu : Form
    {

        SqlConnection con;
        SqlCommand cmd;
        string str = @"Data Source = KIET\SQLEXPRESS;Initial Catalog = QuanLyPhongNet; Integrated Security = True";
        //table 1
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        //table 2 Lich su dang nhap
        SqlDataAdapter adapter2 = new SqlDataAdapter();
        DataTable table2 = new DataTable();
        public frmLichSu()
        {
            InitializeComponent();
        }


        public void loadData()//Lich su Oder
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT *FROM LichSuMua ";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        public void loadData2()//Lich su dang nhap
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT *FROM DangNhapGame ";
            adapter2.SelectCommand = cmd;
            table2.Clear();
            adapter2.Fill(table2);
            dataGridView2.DataSource = table2;
        }
        private void frmLichSu_Load(object sender, EventArgs e)
        {

            try
            {
                con = new SqlConnection(str);
                con.Open();
                loadData();
                loadData2();

            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối!", "Lỗi!");
            }

        }

        private void btx_DangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            con.Open();
            loadData();
            loadData2();

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView2.CurrentRow.Index;
            Lab_AccDangNhap.Text = dataGridView2.Rows[i].Cells[0].Value.ToString();
            lab_May.Text = dataGridView2.Rows[i].Cells[1].Value.ToString();
            

        }//Nhấn vào và hiển thị ở laB

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            lab_acc.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            lab_MayMua.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            lab_TenMua.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            lab_GiaMua.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            lab_GhiChu.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();

        }//Nhấn vào bà hiển thị ở các lable

        private void btx_XoaOder_Click(object sender, EventArgs e)
        {
            if (lab_acc.Text == "")
            {
                MessageBox.Show("Chưa chọn món!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                cmd = con.CreateCommand();
                cmd.CommandText = "delete from LichSuMua where [TÊN TÀI KHOẢN]='" + lab_acc.Text + "' AND [NHÓM MÁY] = '" + lab_MayMua.Text + "'";
                cmd.ExecuteNonQuery();
                loadData();

                DialogResult thongbao = MessageBox.Show("Xác nhận xóa", "Thông báo", MessageBoxButtons.OK);
                if (thongbao == DialogResult.OK)
                {
                    string rong = "";
                    lab_acc.Text = rong;
                    lab_MayMua.Text = rong;
                    lab_TenMua.Text = rong;
                    lab_GiaMua.Text = rong;
                    lab_GhiChu.Text = rong;

                }
            }
         }//xoa lich oder

        private void btn_XoaLichSu_Click(object sender, EventArgs e)
        {
            if (Lab_AccDangNhap.Text == "")
            {
                MessageBox.Show("Chưa chọn máy!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                cmd = con.CreateCommand();
                cmd.CommandText = "delete from DangNhapGame where [TÊN TÀI KHOẢN]='" + Lab_AccDangNhap.Text + "'";
                cmd.ExecuteNonQuery();
                loadData();

                DialogResult traloi = MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                if (traloi == DialogResult.OK)
                {
                    con = new SqlConnection(str);
                    con.Open();
                    loadData();
                    loadData2();

                }
            }
            }

        private void btx_HoanThanh_Click(object sender, EventArgs e)
        {
            if (lab_acc.Text == "")//Bắt buộc chọn máy
            {
                MessageBox.Show("Chưa chọn  tài khoản", "Chưa chọn");
            }
            else
            {
                string ghichu = "HOÀN THÀNH";
                
                cmd = con.CreateCommand();
                cmd.CommandText = "update LichSuMua set [GHI CHÚ] = '" +ghichu + "' where [TÊN TÀI KHOẢN] = '" + lab_acc.Text +"'";
                cmd.ExecuteNonQuery();
                loadData();
            }
        }
    }
}
