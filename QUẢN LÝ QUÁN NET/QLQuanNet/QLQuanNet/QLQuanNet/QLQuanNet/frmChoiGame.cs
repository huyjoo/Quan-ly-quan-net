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
    public partial class frmChoiGame : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string str = @"Data Source = KIET\SQLEXPRESS;Initial Catalog = QuanLyPhongNet; Integrated Security = True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        //

        SqlDataAdapter adapter2 = new SqlDataAdapter();
        DataTable table2 = new DataTable();
        //table món ăn
        SqlDataAdapter adapter3 = new SqlDataAdapter();
        DataTable table3 = new DataTable();

        //Nuoc uong
        SqlDataAdapter adapter4 = new SqlDataAdapter();
        DataTable table4 = new DataTable();
        public void loadData()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * from DangNhapGame  ";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        public frmChoiGame()
        {
            InitializeComponent();
        }
        public void loadData2()//load dữ liệu từ bảng nguoichoivip
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * from NguoiChoiVip where [TÊN TÀI KHOẢN] = '" + lab_TaiKhoan.Text + "'   ";
            adapter2.SelectCommand = cmd;
            table2.Clear();
            adapter2.Fill(table2);
            dataGridView2.DataSource = table2;
        }
        public void loadDoAN()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * from DoAN  ";
            adapter3.SelectCommand = cmd;
            table3.Clear();
            adapter3.Fill(table3);
            dataGridView3.DataSource = table3;
        }
        public void loadNuocUong()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * from NuocUong";
            adapter4.SelectCommand = cmd;
            table4.Clear();
            adapter4.Fill(table4);
            dataGridView4.DataSource = table4;
        }
        private void frmChoiGame_Load(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(str);
                con.Open();
                loadData();
                loadDoAN();
                loadNuocUong();

                //Nhập thông tin tài khoản và tên máy vào bảng thông tin
                int i;
                i = dataGridView1.CurrentRow.Index;
                lab_TaiKhoan.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                lab_May.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();

                ///Load Tiền sau khi bảng thông tin loa
                loadData2();
                int b;
                b = dataGridView2.CurrentRow.Index;
                lab_TongTien.Text = dataGridView2.Rows[b].Cells[2].Value.ToString();
                lab_Tien.Text = dataGridView2.Rows[b].Cells[3].Value.ToString();
                


                //Xếp loại tài khoản
                int xeploai = Convert.ToInt32(lab_TongTien.Text);
                if (xeploai > 500000)
                {
                    string loai = "VIP";
                    lab_Loai.Text = loai;
                }
                else
                {
                        string thuong = "THƯỜNG";
                        lab_Loai.Text = thuong;
                }

                //Nếu tiền < 0 thoát
                int tien = Convert.ToInt32(lab_Tien.Text);

                if (tien < 1)
                {
                    DialogResult ok = MessageBox.Show("Hết thời gian chơi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (ok == DialogResult.OK)
                    {
                        this.Close();
                    }
                }


            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối!", "Lỗi!");
                this.Show();
            }



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            lab_TaiKhoan.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            lab_May.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
        }



        private void btx_DangXuat_Click(object sender, EventArgs e)
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "delete from DangNhapGame where [TÊN TÀI KHOẢN]=('" + lab_TaiKhoan.Text+"')";
            cmd.ExecuteNonQuery();
            loadData();
            string trangthai = "ĐĂNG XUẤT";
            cmd = con.CreateCommand();
            cmd.CommandText = "update NguoiChoiVip set [TÊN TÀI KHOẢN] = '" + lab_TaiKhoan.Text + "',  [TRẠNG THÁI]=N'" + trangthai + "'where [TÊN TÀI KHOẢN] = '" + lab_TaiKhoan.Text + "'";
            cmd.ExecuteNonQuery();
            loadData();
            this.Close();

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int b;
            b = dataGridView2.CurrentRow.Index;
            lab_Tien.Text = dataGridView2.Rows[b].Cells[3].Value.ToString();
            //lab_TongTien.Text = dataGridView2.Rows[b].Cells[2].Value.ToString();


        }

        private void pictureGame_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ĐANG CẬP NHẬT!", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView3.CurrentRow.Index;
            lab_Ma.Text = dataGridView3.Rows[i].Cells[0].Value.ToString();
            lab_Ten.Text = dataGridView3.Rows[i].Cells[1].Value.ToString();
            lab_Gia.Text = dataGridView3.Rows[i].Cells[2].Value.ToString();

        }

        private void btx_Mua_Click(object sender, EventArgs e) //Mua đồ ăn
        {




            if (lab_Ma.Text == "MÃ")
            {
                MessageBox.Show("Chưa chọn món", "Thông báo");
            }
            else
            {
                int gia = Convert.ToInt32(lab_Gia.Text);
                int tienco = Convert.ToInt32(lab_Tien.Text);
                int thanhtoan;
                thanhtoan = tienco - gia;
                int mua = Convert.ToInt32(lab_Gia.Text);
                int tien = Convert.ToInt32(lab_Tien.Text);
                if (tien < mua)
                {
                    MessageBox.Show("Không đủ tiền, vui lòng nạp thêm", "Thông báo");
                }
                else
                {
                    cmd = con.CreateCommand();

                    cmd.CommandText = "update NguoiChoiVip set  [TIỀN CÒN LẠI] = '" + thanhtoan + "' where [TÊN TÀI KHOẢN] = '" + lab_TaiKhoan.Text + "'  ";
                    cmd.ExecuteNonQuery();
                    loadData();
                    loadData();
                    //Thêm vào lịch sử
                    //Thêm vào lịch sử
                    string ghichu = "ĐANG CHỜ";
                    cmd = con.CreateCommand();
                    cmd.CommandText = "insert into LichSuMua values('" + lab_TaiKhoan.Text + "', N'" +lab_May.Text+ "',N'" +lab_Ten.Text+ "', '"+lab_Gia.Text+"',N'"+ghichu+"')";
                    cmd.ExecuteNonQuery();
                    loadData();
                    DialogResult ok = MessageBox.Show("Mua thành công!", "Thông báo", MessageBoxButtons.OK);
                    if (ok == DialogResult.OK)
                    {
                        loadData();
                        loadDoAN();
                        loadNuocUong();

                        //Nhập thông tin tài khoản và tên máy vào bảng thông tin
                        int i;
                        i = dataGridView1.CurrentRow.Index;
                        lab_TaiKhoan.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                        lab_May.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();

                        ///Load Tiền sau khi bảng thông tin loa
                        loadData2();
                        int b;
                        b = dataGridView2.CurrentRow.Index;
                        lab_TongTien.Text = dataGridView2.Rows[b].Cells[2].Value.ToString();
                        lab_Tien.Text = dataGridView2.Rows[b].Cells[3].Value.ToString();

                        //Xếp loại tài khoản
                        int xeploai = Convert.ToInt32(lab_TongTien.Text);
                        if (xeploai > 500000)
                        {
                            string loai = "VIP";
                            lab_Loai.Text = loai;
                        }
                        else
                        {
                            if (xeploai < 50000)
                            {
                                string thuong = "THƯỜNG";
                                lab_Loai.Text = thuong;
                            }

                        }



                    }//Nhan ok updatethongtin


                }


            }
            
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {

            loadData();
            loadDoAN();
            loadNuocUong();

            //Nhập thông tin tài khoản và tên máy vào bảng thông tin
            int i;
            i = dataGridView1.CurrentRow.Index;
            lab_TaiKhoan.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            lab_May.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();

            ///Load Tiền sau khi bảng thông tin loa
            loadData2();
            int b;
            b = dataGridView2.CurrentRow.Index;
            lab_TongTien.Text = dataGridView2.Rows[b].Cells[2].Value.ToString();
            lab_Tien.Text = dataGridView2.Rows[b].Cells[3].Value.ToString();

            //Xếp loại tài khoản
            int xeploai = Convert.ToInt32(lab_TongTien.Text);
            if (xeploai > 500000)
            {
                string loai = "VIP";
                lab_Loai.Text = loai;
            }
            else
            {
                if (xeploai < 50000)
                {
                    string thuong = "THƯỜNG";
                    lab_Loai.Text = thuong;
                }

            }
            MessageBox.Show("Cập nhật thành công!", "Thông báo");
            

            


        }//Cập nhật lại thông tin

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView4.CurrentRow.Index;
            lab_MaNuoc.Text = dataGridView4.Rows[i].Cells[0].Value.ToString();
            lab_TenNuoc.Text = dataGridView4.Rows[i].Cells[1].Value.ToString();
            lab_GiaNuoc.Text = dataGridView4.Rows[i].Cells[2].Value.ToString();

        }

        private void btx_MuaNuoc_Click(object sender, EventArgs e)
        {
            
            if (lab_MaNuoc.Text == "MÃ")
            {
                MessageBox.Show("Chưa chọn nước", "Thông báo");
            }
            else
            {


                int gia = Convert.ToInt32(lab_GiaNuoc.Text);
                int tienco = Convert.ToInt32(lab_Tien.Text);
                int thanhtoan;
                thanhtoan = tienco - gia;
                int mua = Convert.ToInt32(lab_GiaNuoc.Text);
                int tien = Convert.ToInt32(lab_Tien.Text);
                if (tien < mua)
                {
                    MessageBox.Show("Không đủ tiền, vui lòng nạp thêm", "Thông báo");
                }
                else
                {
                    cmd = con.CreateCommand();

                    cmd.CommandText = "update NguoiChoiVip set [TIỀN CÒN LẠI] = '" + thanhtoan + "' where [TÊN TÀI KHOẢN] = '" + lab_TaiKhoan.Text + "'  ";
                    cmd.ExecuteNonQuery();
                    loadData();

                    //Thêm vào lịch sử
                    //Thêm vào lịch sử
                    string ghichu = "ĐANG CHỜ";
                    cmd = con.CreateCommand();
                    cmd.CommandText = "insert into LichSuMua values('" + lab_TaiKhoan.Text + "', N'" + lab_May.Text + "',N'" + lab_TenNuoc.Text + "', '" + lab_GiaNuoc.Text + "',N'" + ghichu + "')";
                    cmd.ExecuteNonQuery();
                    loadData();

                    DialogResult ok = MessageBox.Show("Mua thành công!", "Thông báo", MessageBoxButtons.OK);
                    if (ok == DialogResult.OK)
                    {
                        loadData();
                        loadDoAN();
                        loadNuocUong();

                        //Nhập thông tin tài khoản và tên máy vào bảng thông tin
                        int i;
                        i = dataGridView1.CurrentRow.Index;
                        lab_TaiKhoan.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                        lab_May.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();

                        ///Load Tiền sau khi bảng thông tin loa
                        loadData2();
                        int b;
                        b = dataGridView2.CurrentRow.Index;
                        lab_TongTien.Text = dataGridView2.Rows[b].Cells[2].Value.ToString();
                        lab_Tien.Text = dataGridView2.Rows[b].Cells[3].Value.ToString();

                        //Xếp loại tài khoản
                        int xeploai = Convert.ToInt32(lab_TongTien.Text);
                        if (xeploai > 500000)
                        {
                            string loai = "VIP";
                            lab_Loai.Text = loai;
                        }
                        else
                        {
                            if (xeploai < 50000)
                            {
                                string thuong = "THƯỜNG";
                                lab_Loai.Text = thuong;
                            }

                        }

                    }//Nhan ok updatethongtin

                }


            }
        }
        private void btn__Click(object sender, EventArgs e)
        {
            string seri = txt_Seri.Text;
            string ma = txt_MaThe.Text;
            string tien = com_MenhGia.Text;

            string SQL = @"Data Source = KIET\SQLEXPRESS;Initial Catalog = QuanLyPhongNet; Integrated Security = True";
            SqlConnection connec = new SqlConnection(SQL);
            connec.Open();
            string sql = "SELECT * FROM TheCao where SERI = '" + seri + "' AND [SỐ THẺ]= '" + ma + "' AND [MỆNH GIÁ]='" + tien + "' ";
            SqlCommand cm = new SqlCommand(sql, connec);
            SqlDataReader dta = cm.ExecuteReader();

            if (dta.Read() == true)

            {
                //Thêm tiền vào nạp tiền
                int tiennap = Convert.ToInt32(com_MenhGia.Text);
                int tongtien = Convert.ToInt32(lab_TongTien.Text);
                int congtien = tiennap + tongtien;
                cmd = con.CreateCommand();
                cmd.CommandText = "update NguoiChoiVip set [TIỀN NẠP] = '" + congtien + "' where [TÊN TÀI KHOẢN]='" + lab_TaiKhoan.Text + "'";
                cmd.ExecuteNonQuery();
                loadData();

                //Cộng tiền vào tài khoản còn lại
                int tiendangco = Convert.ToInt32(lab_Tien.Text);
                int congtiendangco = tiennap + tiendangco;
                cmd = con.CreateCommand();
                cmd.CommandText = "update NguoiChoiVip set [TIỀN CÒN LẠI] = '" + congtiendangco + "' where [TÊN TÀI KHOẢN]='" + lab_TaiKhoan.Text + "'";
                cmd.ExecuteNonQuery();
                loadData();

                //Trừ thẻ trước đó
                cmd = con.CreateCommand();
                cmd.CommandText = "delete from TheCao where [SERI]=('" +txt_Seri.Text+ "')";
                cmd.ExecuteNonQuery();
                loadData();


                DialogResult ok = MessageBox.Show("Nạp Thành công thành công!", "Thông báo", MessageBoxButtons.OK); //Nhan oke xac nhan và Update thong tin
                if (ok == DialogResult.OK)
                {
                    loadData();
                    loadDoAN();
                    loadNuocUong();

                    //Nhập thông tin tài khoản và tên máy vào bảng thông tin
                    int i;
                    i = dataGridView1.CurrentRow.Index;
                    lab_TaiKhoan.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    lab_May.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();

                    ///Load Tiền sau khi bảng thông tin loa
                    loadData2();
                    int b;
                    b = dataGridView2.CurrentRow.Index;
                    lab_TongTien.Text = dataGridView2.Rows[b].Cells[2].Value.ToString();
                    lab_Tien.Text = dataGridView2.Rows[b].Cells[3].Value.ToString();

                    //Xếp loại tài khoản
                    int xeploai = Convert.ToInt32(lab_TongTien.Text);
                    if (xeploai > 500000)
                    {
                        string loai = "VIP";
                        lab_Loai.Text = loai;
                    }
                    else
                    {
                        if (xeploai < 50000)
                        {
                            string thuong = "THƯỜNG";
                            lab_Loai.Text = thuong;
                        }

                    }

                }
                
                 


            }//if (dta.Read() == true)
            else
            {
                MessageBox.Show("Kiểm tra lại", "Thông báo");
            }



        }//private void btn__Click

    }
    
}
