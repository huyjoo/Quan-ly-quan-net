
namespace QLQuanNet
{
    partial class frmChoiGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChoiGame));
            this.lab_TaiKhoan = new System.Windows.Forms.Label();
            this.lab_May = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lab_Loai = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lab_Tien = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btx_DangXuat = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.lab_Ten = new System.Windows.Forms.Label();
            this.lab_Gia = new System.Windows.Forms.Label();
            this.lab_Ma = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btx_Mua = new System.Windows.Forms.Button();
            this.btn_CapNhat = new System.Windows.Forms.Button();
            this.btx_MuaNuoc = new System.Windows.Forms.Button();
            this.lab_MaNuoc = new System.Windows.Forms.Label();
            this.lab_GiaNuoc = new System.Windows.Forms.Label();
            this.lab_TenNuoc = new System.Windows.Forms.Label();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Seri = new System.Windows.Forms.TextBox();
            this.txt_MaThe = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.com_MenhGia = new System.Windows.Forms.ComboBox();
            this.btn_ = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lab_TongTien = new System.Windows.Forms.Label();
            this.ttt = new System.Windows.Forms.Label();
            this.pictureGame = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGame)).BeginInit();
            this.SuspendLayout();
            // 
            // lab_TaiKhoan
            // 
            this.lab_TaiKhoan.AutoSize = true;
            this.lab_TaiKhoan.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_TaiKhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lab_TaiKhoan.Location = new System.Drawing.Point(204, 41);
            this.lab_TaiKhoan.Name = "lab_TaiKhoan";
            this.lab_TaiKhoan.Size = new System.Drawing.Size(177, 32);
            this.lab_TaiKhoan.TabIndex = 0;
            this.lab_TaiKhoan.Text = "TÀI KHOẢN";
            // 
            // lab_May
            // 
            this.lab_May.AutoSize = true;
            this.lab_May.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_May.Location = new System.Drawing.Point(204, 107);
            this.lab_May.Name = "lab_May";
            this.lab_May.Size = new System.Drawing.Size(82, 32);
            this.lab_May.TabIndex = 2;
            this.lab_May.Text = "MÁY";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(1135, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(0, 0);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lab_Loai);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lab_Tien);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lab_May);
            this.groupBox1.Controls.Add(this.lab_TaiKhoan);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1007, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(547, 229);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔN TIN";
            // 
            // lab_Loai
            // 
            this.lab_Loai.AutoSize = true;
            this.lab_Loai.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Loai.ForeColor = System.Drawing.Color.Black;
            this.lab_Loai.Location = new System.Drawing.Point(333, 31);
            this.lab_Loai.Name = "lab_Loai";
            this.lab_Loai.Size = new System.Drawing.Size(123, 45);
            this.lab_Loai.TabIndex = 9;
            this.lab_Loai.Text = "LOẠI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 33);
            this.label3.TabIndex = 8;
            this.label3.Text = "TIỀN CÒN LẠI";
            // 
            // lab_Tien
            // 
            this.lab_Tien.AutoSize = true;
            this.lab_Tien.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Tien.ForeColor = System.Drawing.Color.Red;
            this.lab_Tien.Location = new System.Drawing.Point(204, 168);
            this.lab_Tien.Name = "lab_Tien";
            this.lab_Tien.Size = new System.Drawing.Size(82, 32);
            this.lab_Tien.TabIndex = 8;
            this.lab_Tien.Text = "TIỀN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 33);
            this.label2.TabIndex = 6;
            this.label2.Text = "TÀI KHOẢN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "MÁY CHƠI";
            // 
            // btx_DangXuat
            // 
            this.btx_DangXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btx_DangXuat.Location = new System.Drawing.Point(1419, 783);
            this.btx_DangXuat.Name = "btx_DangXuat";
            this.btx_DangXuat.Size = new System.Drawing.Size(135, 64);
            this.btx_DangXuat.TabIndex = 6;
            this.btx_DangXuat.Text = "ĐĂNG XUẤT";
            this.btx_DangXuat.UseVisualStyleBackColor = false;
            this.btx_DangXuat.Click += new System.EventHandler(this.btx_DangXuat_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(704, 156);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(90, 57);
            this.dataGridView2.TabIndex = 7;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(1007, 259);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 62;
            this.dataGridView3.RowTemplate.Height = 28;
            this.dataGridView3.Size = new System.Drawing.Size(547, 183);
            this.dataGridView3.TabIndex = 9;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // lab_Ten
            // 
            this.lab_Ten.AutoSize = true;
            this.lab_Ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Ten.ForeColor = System.Drawing.Color.Black;
            this.lab_Ten.Location = new System.Drawing.Point(1150, 466);
            this.lab_Ten.Name = "lab_Ten";
            this.lab_Ten.Size = new System.Drawing.Size(55, 25);
            this.lab_Ten.TabIndex = 10;
            this.lab_Ten.Text = "TÊN";
            // 
            // lab_Gia
            // 
            this.lab_Gia.AutoSize = true;
            this.lab_Gia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Gia.ForeColor = System.Drawing.Color.Red;
            this.lab_Gia.Location = new System.Drawing.Point(1295, 466);
            this.lab_Gia.Name = "lab_Gia";
            this.lab_Gia.Size = new System.Drawing.Size(49, 25);
            this.lab_Gia.TabIndex = 11;
            this.lab_Gia.Text = "GIÁ";
            // 
            // lab_Ma
            // 
            this.lab_Ma.AutoSize = true;
            this.lab_Ma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Ma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lab_Ma.Location = new System.Drawing.Point(1014, 466);
            this.lab_Ma.Name = "lab_Ma";
            this.lab_Ma.Size = new System.Drawing.Size(45, 25);
            this.lab_Ma.TabIndex = 12;
            this.lab_Ma.Text = "MÃ";
            // 
            // btx_Mua
            // 
            this.btx_Mua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btx_Mua.Location = new System.Drawing.Point(1419, 459);
            this.btx_Mua.Name = "btx_Mua";
            this.btx_Mua.Size = new System.Drawing.Size(135, 43);
            this.btx_Mua.TabIndex = 13;
            this.btx_Mua.Text = "MUA";
            this.btx_Mua.UseVisualStyleBackColor = false;
            this.btx_Mua.Click += new System.EventHandler(this.btx_Mua_Click);
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_CapNhat.Location = new System.Drawing.Point(1232, 783);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(135, 64);
            this.btn_CapNhat.TabIndex = 14;
            this.btn_CapNhat.Text = "CẬP NHẬT";
            this.btn_CapNhat.UseVisualStyleBackColor = false;
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // btx_MuaNuoc
            // 
            this.btx_MuaNuoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btx_MuaNuoc.Location = new System.Drawing.Point(1419, 708);
            this.btx_MuaNuoc.Name = "btx_MuaNuoc";
            this.btx_MuaNuoc.Size = new System.Drawing.Size(135, 43);
            this.btx_MuaNuoc.TabIndex = 19;
            this.btx_MuaNuoc.Text = "MUA";
            this.btx_MuaNuoc.UseVisualStyleBackColor = false;
            this.btx_MuaNuoc.Click += new System.EventHandler(this.btx_MuaNuoc_Click);
            // 
            // lab_MaNuoc
            // 
            this.lab_MaNuoc.AutoSize = true;
            this.lab_MaNuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_MaNuoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lab_MaNuoc.Location = new System.Drawing.Point(1014, 715);
            this.lab_MaNuoc.Name = "lab_MaNuoc";
            this.lab_MaNuoc.Size = new System.Drawing.Size(45, 25);
            this.lab_MaNuoc.TabIndex = 18;
            this.lab_MaNuoc.Text = "MÃ";
            // 
            // lab_GiaNuoc
            // 
            this.lab_GiaNuoc.AutoSize = true;
            this.lab_GiaNuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_GiaNuoc.ForeColor = System.Drawing.Color.Red;
            this.lab_GiaNuoc.Location = new System.Drawing.Point(1295, 715);
            this.lab_GiaNuoc.Name = "lab_GiaNuoc";
            this.lab_GiaNuoc.Size = new System.Drawing.Size(49, 25);
            this.lab_GiaNuoc.TabIndex = 17;
            this.lab_GiaNuoc.Text = "GIÁ";
            // 
            // lab_TenNuoc
            // 
            this.lab_TenNuoc.AutoSize = true;
            this.lab_TenNuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_TenNuoc.ForeColor = System.Drawing.Color.Black;
            this.lab_TenNuoc.Location = new System.Drawing.Point(1150, 715);
            this.lab_TenNuoc.Name = "lab_TenNuoc";
            this.lab_TenNuoc.Size = new System.Drawing.Size(55, 25);
            this.lab_TenNuoc.TabIndex = 16;
            this.lab_TenNuoc.Text = "TÊN";
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(1007, 508);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 62;
            this.dataGridView4.RowTemplate.Height = 28;
            this.dataGridView4.Size = new System.Drawing.Size(547, 183);
            this.dataGridView4.TabIndex = 15;
            this.dataGridView4.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 799);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 32);
            this.label4.TabIndex = 20;
            this.label4.Text = "SERI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(616, 801);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 32);
            this.label5.TabIndex = 21;
            // 
            // txt_Seri
            // 
            this.txt_Seri.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Seri.Location = new System.Drawing.Point(136, 801);
            this.txt_Seri.Name = "txt_Seri";
            this.txt_Seri.Size = new System.Drawing.Size(175, 30);
            this.txt_Seri.TabIndex = 23;
            // 
            // txt_MaThe
            // 
            this.txt_MaThe.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaThe.Location = new System.Drawing.Point(441, 797);
            this.txt_MaThe.Name = "txt_MaThe";
            this.txt_MaThe.Size = new System.Drawing.Size(175, 30);
            this.txt_MaThe.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(355, 795);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 32);
            this.label6.TabIndex = 24;
            this.label6.Text = "MÃ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(666, 799);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 32);
            this.label7.TabIndex = 26;
            this.label7.Text = "MỆNH GIÁ";
            // 
            // com_MenhGia
            // 
            this.com_MenhGia.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_MenhGia.FormattingEnabled = true;
            this.com_MenhGia.Items.AddRange(new object[] {
            "10000",
            "20000",
            "50000",
            "100000",
            "500000"});
            this.com_MenhGia.Location = new System.Drawing.Point(844, 801);
            this.com_MenhGia.Name = "com_MenhGia";
            this.com_MenhGia.Size = new System.Drawing.Size(144, 30);
            this.com_MenhGia.TabIndex = 27;
            // 
            // btn_
            // 
            this.btn_.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_.Location = new System.Drawing.Point(1030, 783);
            this.btn_.Name = "btn_";
            this.btn_.Size = new System.Drawing.Size(135, 64);
            this.btn_.TabIndex = 28;
            this.btn_.Text = "NẠP";
            this.btn_.UseVisualStyleBackColor = false;
            this.btn_.Click += new System.EventHandler(this.btn__Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(50, 728);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(289, 32);
            this.label8.TabIndex = 29;
            this.label8.Text = "TỔNG TIỀN ĐÃ  NẠP";
            // 
            // lab_TongTien
            // 
            this.lab_TongTien.AutoSize = true;
            this.lab_TongTien.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_TongTien.ForeColor = System.Drawing.Color.Red;
            this.lab_TongTien.Location = new System.Drawing.Point(377, 728);
            this.lab_TongTien.Name = "lab_TongTien";
            this.lab_TongTien.Size = new System.Drawing.Size(170, 32);
            this.lab_TongTien.TabIndex = 30;
            this.lab_TongTien.Text = "TỔNG TIỀN";
            // 
            // ttt
            // 
            this.ttt.AutoSize = true;
            this.ttt.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ttt.Location = new System.Drawing.Point(772, 728);
            this.ttt.Name = "ttt";
            this.ttt.Size = new System.Drawing.Size(177, 32);
            this.ttt.TabIndex = 31;
            this.ttt.Text = "TÀI KHOẢN";
            // 
            // pictureGame
            // 
            this.pictureGame.Image = global::QLQuanNet.Properties.Resources.Game4V_tiem_net_cuoi_nam_2020_co_game_gi_3;
            this.pictureGame.Location = new System.Drawing.Point(56, 1);
            this.pictureGame.Name = "pictureGame";
            this.pictureGame.Size = new System.Drawing.Size(911, 713);
            this.pictureGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureGame.TabIndex = 8;
            this.pictureGame.TabStop = false;
            this.pictureGame.Click += new System.EventHandler(this.pictureGame_Click);
            // 
            // frmChoiGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1591, 877);
            this.Controls.Add(this.ttt);
            this.Controls.Add(this.lab_TongTien);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_);
            this.Controls.Add(this.com_MenhGia);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_MaThe);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Seri);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btx_MuaNuoc);
            this.Controls.Add(this.lab_MaNuoc);
            this.Controls.Add(this.lab_GiaNuoc);
            this.Controls.Add(this.lab_TenNuoc);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.btn_CapNhat);
            this.Controls.Add(this.btx_Mua);
            this.Controls.Add(this.lab_Ma);
            this.Controls.Add(this.lab_Gia);
            this.Controls.Add(this.lab_Ten);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.pictureGame);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btx_DangXuat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmChoiGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHƠI GAME";
            this.Load += new System.EventHandler(this.frmChoiGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_TaiKhoan;
        private System.Windows.Forms.Label lab_May;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btx_DangXuat;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lab_Tien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureGame;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label lab_Ten;
        private System.Windows.Forms.Label lab_Gia;
        private System.Windows.Forms.Label lab_Ma;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btx_Mua;
        private System.Windows.Forms.Button btn_CapNhat;
        private System.Windows.Forms.Button btx_MuaNuoc;
        private System.Windows.Forms.Label lab_MaNuoc;
        private System.Windows.Forms.Label lab_GiaNuoc;
        private System.Windows.Forms.Label lab_TenNuoc;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Seri;
        private System.Windows.Forms.TextBox txt_MaThe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox com_MenhGia;
        private System.Windows.Forms.Button btn_;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lab_TongTien;
        private System.Windows.Forms.Label ttt;
        private System.Windows.Forms.Label lab_Loai;
    }
}