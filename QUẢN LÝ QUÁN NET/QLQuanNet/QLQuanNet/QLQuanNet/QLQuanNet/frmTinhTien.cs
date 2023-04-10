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
    public partial class frmTinhTien : Form
    {

        SqlConnection con;
        SqlCommand cmd;
        string str = @"Data Source = KIET\SQLEXPRESS;Initial Catalog = QuanLyPhongNet; Integrated Security = True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        SqlDataAdapter adapter2 = new SqlDataAdapter();
        DataTable table2 = new DataTable();

        void loadData()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT *FROM TinhTien";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dtg.DataSource = table;
        }
       
        void chonMay()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT [NHÓM MÁY] FROM NhomMay where [TRẠNG THÁI] LIKE (N'%ĐANG MỞ%') ";
            adapter2.SelectCommand = cmd;
            table2.Clear();
            adapter2.Fill(table2);
            dataGridView2.DataSource = table2;
        }
           





        public frmTinhTien()
        {
            InitializeComponent();
        }

        private void frmTinhTien_Load(object sender, EventArgs e)
        {

            try
            {
                con = new SqlConnection(str);
                con.Open();
                loadData();
                chonMay();





            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối!", "Lỗi!");
            }


        }

        private void dtg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //Hien thi vao texb box
            int i;
            i = dtg.CurrentRow.Index;
            txb_MaDon.Text = dtg.Rows[i].Cells[0].Value.ToString();
            txb_SoGioChoi.Text = dtg.Rows[i].Cells[1].Value.ToString();
            //lab_May.Text = dtg.Rows[i].Cells[2].Value.ToString();
            lab_Tien.Text = dtg.Rows[i].Cells[3].Value.ToString();

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {


            
        }

        private void btxXoa_Click(object sender, EventArgs e)
        {
          

        }//HỦY

  

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txb_MaDon.Text == "" && txb_SoGioChoi.Text == "" && TXB_TienKhac.Text == "" && lab_Tien.Text == "")
                {
                    MessageBox.Show("Thiếu!", "Lôi!");
                }
                else
                {

                    if (lab_May.Text == "")
                    {
                        MessageBox.Show("Chưa chọn máy!", "Lỗi");
                    }
                    else
                    {
                        int tienkhac = Convert.ToInt32(TXB_TienKhac.Text);
                        int num = Convert.ToInt32(txb_SoGioChoi.Text);
                        lab_Tien.Text = (num * 10000 + tienkhac).ToString();


                        cmd = con.CreateCommand();
                        cmd.CommandText = "insert into TinhTien values('" + txb_MaDon.Text + "', '" + txb_SoGioChoi.Text + "','" + lab_May.Text + "','" + lab_Tien.Text + "')";
                        cmd.ExecuteNonQuery();

                        //Cập nhật vào bảng máy trạng thái tắt khi lưu thành công
                        string tat = "ĐANG TẮT";
                        cmd = con.CreateCommand();
                        cmd.CommandText = "update NhomMay set [NHÓM MÁY] = '" + lab_May.Text + "', [TRẠNG THÁI] = N'" + tat + "'where [NHÓM MÁY] = '" + lab_May.Text + "' ";
                        cmd.ExecuteNonQuery();

                        loadData();
                        chonMay();
                    }

                }

            }
            catch (Exception)
            {
                MessageBox.Show("Có thể bị trùng mã đơn!", "Lỗi");
            }

            //Tự động chuyển thành rỗng khi nhấn lưu
            string may = "";
            lab_May.Text = may;

        }


        private void btxThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btxTinhTien_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txb_SoGioChoi.Text == "")
                {
                    MessageBox.Show("Chưa nhập số giờ chơi", "Lỗi");
                }
                else
                {
                    int tienkhac = Convert.ToInt32(TXB_TienKhac.Text);
                    int num = Convert.ToInt32(txb_SoGioChoi.Text);
                    lab_Tien.Text = (num * 10000 + tienkhac).ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Kiểm tra lại", "Kiem tra");
                txb_SoGioChoi.Focus();
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView2.CurrentRow.Index;
            lab_May.Text = dataGridView2.Rows[i].Cells[0].Value.ToString();
        }

        private void btxXoa_Click_1(object sender, EventArgs e)
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "delete from TinhTien where [MÃ ĐƠN]=('" + txb_MaDon.Text + "')";
            cmd.ExecuteNonQuery();
            loadData();
            chonMay();
        }
    }
}
