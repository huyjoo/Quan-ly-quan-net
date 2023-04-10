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
    public partial class frmNguoiDungVip : Form
    {


        SqlConnection con;
        SqlCommand cmd;
        string str = @"Data Source = KIET\SQLEXPRESS;Initial Catalog = QuanLyPhongNet; Integrated Security = True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public frmNguoiDungVip()
        {
            InitializeComponent();
        }

        private void btxThoat_Click(object sender, EventArgs e)
        {
            this.Close();

        }


        public void loadData()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT [TÊN TÀI KHOẢN],[MẬT KHẨU],[TIỀN NẠP],[TIỀN CÒN LẠI],[SỐ GIỜ CHƠI CÒN LẠI],[TRẠNG THÁI] FROM NguoiChoiVip";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dtg.DataSource = table;
        }
        private void frmNguoiDungVip_Load(object sender, EventArgs e)
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

        private void dtg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dtg.CurrentRow.Index;
            txb_TaiKhoan.Text = dtg.Rows[i].Cells[0].Value.ToString();
            txb_MatKhau.Text = dtg.Rows[i].Cells[1].Value.ToString();
            txb_TienNap.Text = dtg.Rows[i].Cells[2].Value.ToString();
            txb_TienConLai.Text = dtg.Rows[i].Cells[3].Value.ToString();
            txb_SoGioChoi.Text = dtg.Rows[i].Cells[4].Value.ToString();
            labTrangThai.Text = dtg.Rows[i].Cells[5].Value.ToString();
        }

        private void btx_Them_Click(object sender, EventArgs e)
        {
 
                try
            {

                    int tiennap = Convert.ToInt32(txb_TienConLai.Text);
                    if (tiennap <= 49999)
                    {
                        MessageBox.Show("Phải nạp trên 50.000 VNĐ");
                    }
                    else
                    {
                        
                        int tienapvo = Convert.ToInt32(txb_TienNap.Text);
                        int tienconlai = Convert.ToInt32(txb_TienConLai.Text);

                       
                        txb_SoGioChoi.Text = (tiennap / 10000).ToString();
                        string trangthai = "KÍCH HOẠT";
                        string kh = "a";
                        
                        cmd = con.CreateCommand();
                        cmd.CommandText = "insert into NguoiChoiVip values('" + txb_TaiKhoan.Text + "', '" + txb_MatKhau.Text + "','" + txb_TienNap.Text + "','" +tiennap+ "', '" + txb_SoGioChoi.Text + "', N'" + trangthai + "', '" + kh + "')";
                        cmd.ExecuteNonQuery();
                        loadData();

                    DialogResult xoa = MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK);
                    if (xoa == DialogResult.OK)
                    {
                        int gio = 0;
                        txb_SoGioChoi.Text = gio.ToString();

                        int tienReset = 50000;
                        txb_TienConLai.Text = tienReset.ToString();

                        txb_TienNap.Text = tienReset.ToString();
                    }
                }
                    //Tự động xóa khi tài khoảng rỗng
                string rong = "";
                cmd = con.CreateCommand();
                cmd.CommandText = "delete from NguoiChoiVIP where [TÊN TÀI KHOẢN]=('" + rong + "')";
                cmd.ExecuteNonQuery();
                //Tự động xóa khi mật khẩu rỗng
                loadData();
                cmd = con.CreateCommand();
                cmd.CommandText = "delete from NguoiChoiVIP where [MẬT KHẨU]=('" + rong + "')";
                cmd.ExecuteNonQuery();
                loadData();



            }
            catch (Exception)
            {
                MessageBox.Show("Có thể tài khoản tồn tại!", "Lỗi");
            }
        }

        private void bxt_Xoa_Click(object sender, EventArgs e)
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "delete from NguoiChoiVIP where [TÊN TÀI KHOẢN]=('" + txb_TaiKhoan.Text + "')";
            cmd.ExecuteNonQuery();
            loadData();

            DialogResult xoa = MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK);
            if (xoa == DialogResult.OK)
            {
                int gio = 0;
                txb_SoGioChoi.Text = gio.ToString();

                int tienReset = 50000;
                txb_TienConLai.Text = tienReset.ToString();

                txb_TienNap.Text = tienReset.ToString();
            }
        }

        private void btx_Sua_Click(object sender, EventArgs e)
        {
            if (txb_TaiKhoan.Text == "")//Bắt buộc chọn máy
            {
                MessageBox.Show("Chưa chọn  tài khoản", "Chưa chọn");
            }
            else
            {
                int tiennap = Convert.ToInt32(txb_TienConLai.Text);
                txb_SoGioChoi.Text = (tiennap / 10000).ToString();
                cmd = con.CreateCommand();
                cmd.CommandText = "update NguoiChoiVip set [TÊN TÀI KHOẢN] = '" +txb_TaiKhoan.Text+ "', [MẬT KHẨU] = '"+txb_MatKhau.Text+ "', [TIỀN NẠP] = '" +txb_TienNap.Text+ "',[TIỀN CÒN LẠI] = '"+tiennap+"', [SỐ GIỜ CHƠI CÒN LẠI]='"+txb_SoGioChoi.Text+"',[TRẠNG THÁI]=N'"+lab_TrangThai.Text+"' where [TÊN TÀI KHOẢN] = '" +txb_TaiKhoan.Text+ "' ";
                cmd.ExecuteNonQuery();
                loadData();

                DialogResult xoa = MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK);
                if (xoa == DialogResult.OK)
                {
                    int gio = 0;
                    txb_SoGioChoi.Text = gio.ToString();

                    int tienReset = 50000;
                    txb_TienConLai.Text = tienReset.ToString();

                    txb_TienNap.Text = tienReset.ToString();
                }


            }
        }

        private void btx_Khóa_Click(object sender, EventArgs e)
        {
            string kh = "b";
            string trangthai = "BỊ KHÓA";
            txb_TienConLai.Text = txb_TienNap.Text;
            int tiennap = Convert.ToInt32(txb_TienConLai.Text);
            txb_SoGioChoi.Text = (tiennap / 10000).ToString();

            cmd = con.CreateCommand();
            cmd.CommandText = "update NguoiChoiVip set [TÊN TÀI KHOẢN] = '" + txb_TaiKhoan.Text + "', [MẬT KHẨU] = '" + txb_MatKhau.Text + "', [TIỀN NẠP] = '" + txb_TienNap.Text + "',[TIỀN CÒN LẠI] = '" + txb_TienConLai.Text + "', [SỐ GIỜ CHƠI CÒN LẠI]='" + txb_SoGioChoi.Text + "',[TRẠNG THÁI]=N'" + trangthai + "', [KÍCH HOẠT] ='" + kh + "' where [TÊN TÀI KHOẢN] = '" + txb_TaiKhoan.Text + "' ";
            cmd.ExecuteNonQuery();
            loadData();

            DialogResult xoa = MessageBox.Show("Khóa thành công!", "Thông báo", MessageBoxButtons.OK);
            if (xoa == DialogResult.OK)
            {
                int gio = 0;
                txb_SoGioChoi.Text = gio.ToString();

                int tienReset = 50000;
                txb_TienConLai.Text = tienReset.ToString();

                txb_TienNap.Text = tienReset.ToString();
            }
        }

        private void btx_Mo_Click(object sender, EventArgs e)
        {
            txb_TienNap.ReadOnly = true;
            string kh = "a";
            string trangthai = "HOẠT ĐỘNG";
            txb_TienConLai.Text = txb_TienNap.Text;
            int tiennap = Convert.ToInt32(txb_TienConLai.Text);
            txb_SoGioChoi.Text = (tiennap / 10000).ToString();

            cmd = con.CreateCommand();
            cmd.CommandText = "update NguoiChoiVip set [TÊN TÀI KHOẢN] = '" + txb_TaiKhoan.Text + "', [MẬT KHẨU] = '" + txb_MatKhau.Text + "', [TIỀN NẠP] = '" + txb_TienNap.Text + "',[TIỀN CÒN LẠI] = '" + txb_TienConLai.Text + "', [SỐ GIỜ CHƠI CÒN LẠI]='" + txb_SoGioChoi.Text + "',[TRẠNG THÁI]=N'" + trangthai + "', [KÍCH HOẠT] ='" + kh + "' where [TÊN TÀI KHOẢN] = '" + txb_TaiKhoan.Text + "' ";
            cmd.ExecuteNonQuery();
            loadData();

            DialogResult xoa = MessageBox.Show("Mở thành công!", "Thông báo", MessageBoxButtons.OK);
            if (xoa == DialogResult.OK)
            {
                int gio = 0;
                txb_SoGioChoi.Text = gio.ToString();

                int tienReset = 50000;
                txb_TienConLai.Text = tienReset.ToString();

                txb_TienNap.Text = tienReset.ToString();
            }
        }

        private void btx_CapNhap_Click(object sender, EventArgs e)
        {

            int tiennap = Convert.ToInt32(txb_TienConLai.Text);
            txb_SoGioChoi.Text = (tiennap / 10000).ToString();
            cmd = con.CreateCommand();
            cmd.CommandText = "update NguoiChoiVip set [TÊN TÀI KHOẢN] = '" + txb_TaiKhoan.Text + "', [MẬT KHẨU] = '" + txb_MatKhau.Text + "', [TIỀN NẠP] = '" + txb_TienNap.Text + "',[TIỀN CÒN LẠI] = '" + tiennap + "', [SỐ GIỜ CHƠI CÒN LẠI]='" + txb_SoGioChoi.Text + "',[TRẠNG THÁI]=N'" +labTrangThai.Text + "' where [TÊN TÀI KHOẢN] = '" + txb_TaiKhoan.Text + "' ";
            cmd.ExecuteNonQuery();
            loadData();
            DialogResult xoa = MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK);
            if (xoa == DialogResult.OK)
            {
                int gio = 0;
                txb_SoGioChoi.Text = gio.ToString();

                int tienReset = 50000;
                txb_TienConLai.Text = tienReset.ToString();

                txb_TienNap.Text = tienReset.ToString();
            }
        }
    }
}
