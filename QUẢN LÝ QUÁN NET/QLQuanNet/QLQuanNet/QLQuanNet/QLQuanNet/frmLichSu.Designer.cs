
namespace QLQuanNet
{
    partial class frmLichSu
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
            this.btx_DangXuat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lab_GhiChu = new System.Windows.Forms.Label();
            this.lab_GiaMua = new System.Windows.Forms.Label();
            this.lab_TenMua = new System.Windows.Forms.Label();
            this.lab_MayMua = new System.Windows.Forms.Label();
            this.lab_acc = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btn_CapNhat = new System.Windows.Forms.Button();
            this.btx_HoanThanh = new System.Windows.Forms.Button();
            this.btx_XoaOder = new System.Windows.Forms.Button();
            this.lab_May = new System.Windows.Forms.Label();
            this.Lab_AccDangNhap = new System.Windows.Forms.Label();
            this.btn_XoaLichSu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btx_DangXuat
            // 
            this.btx_DangXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btx_DangXuat.Location = new System.Drawing.Point(1392, 723);
            this.btx_DangXuat.Name = "btx_DangXuat";
            this.btx_DangXuat.Size = new System.Drawing.Size(135, 64);
            this.btx_DangXuat.TabIndex = 7;
            this.btx_DangXuat.Text = "THOÁT";
            this.btx_DangXuat.UseVisualStyleBackColor = false;
            this.btx_DangXuat.Click += new System.EventHandler(this.btx_DangXuat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lab_GhiChu);
            this.groupBox1.Controls.Add(this.lab_GiaMua);
            this.groupBox1.Controls.Add(this.lab_TenMua);
            this.groupBox1.Controls.Add(this.lab_MayMua);
            this.groupBox1.Controls.Add(this.lab_acc);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(70, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(858, 639);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DANH SÁCH ODER";
            // 
            // lab_GhiChu
            // 
            this.lab_GhiChu.AutoSize = true;
            this.lab_GhiChu.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_GhiChu.ForeColor = System.Drawing.Color.Blue;
            this.lab_GhiChu.Location = new System.Drawing.Point(648, 571);
            this.lab_GhiChu.Name = "lab_GhiChu";
            this.lab_GhiChu.Size = new System.Drawing.Size(128, 30);
            this.lab_GhiChu.TabIndex = 18;
            this.lab_GhiChu.Text = "GHI CHÚ";
            // 
            // lab_GiaMua
            // 
            this.lab_GiaMua.AutoSize = true;
            this.lab_GiaMua.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_GiaMua.ForeColor = System.Drawing.Color.Red;
            this.lab_GiaMua.Location = new System.Drawing.Point(555, 571);
            this.lab_GiaMua.Name = "lab_GiaMua";
            this.lab_GiaMua.Size = new System.Drawing.Size(62, 30);
            this.lab_GiaMua.TabIndex = 17;
            this.lab_GiaMua.Text = "GIÁ";
            // 
            // lab_TenMua
            // 
            this.lab_TenMua.AutoSize = true;
            this.lab_TenMua.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_TenMua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lab_TenMua.Location = new System.Drawing.Point(435, 571);
            this.lab_TenMua.Name = "lab_TenMua";
            this.lab_TenMua.Size = new System.Drawing.Size(75, 30);
            this.lab_TenMua.TabIndex = 16;
            this.lab_TenMua.Text = "MUA";
            // 
            // lab_MayMua
            // 
            this.lab_MayMua.AutoSize = true;
            this.lab_MayMua.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_MayMua.Location = new System.Drawing.Point(250, 571);
            this.lab_MayMua.Name = "lab_MayMua";
            this.lab_MayMua.Size = new System.Drawing.Size(167, 30);
            this.lab_MayMua.TabIndex = 15;
            this.lab_MayMua.Text = "NHÓM MÁY";
            // 
            // lab_acc
            // 
            this.lab_acc.AutoSize = true;
            this.lab_acc.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_acc.ForeColor = System.Drawing.Color.Black;
            this.lab_acc.Location = new System.Drawing.Point(81, 571);
            this.lab_acc.Name = "lab_acc";
            this.lab_acc.Size = new System.Drawing.Size(163, 30);
            this.lab_acc.TabIndex = 14;
            this.lab_acc.Text = "TÀI KHOẢN";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(821, 495);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(1042, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(427, 561);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LỊCH SỬ ĐĂNG NHẬP";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(23, 25);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(380, 495);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.BackColor = System.Drawing.Color.LightGray;
            this.btn_CapNhat.Location = new System.Drawing.Point(1242, 723);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(135, 64);
            this.btn_CapNhat.TabIndex = 10;
            this.btn_CapNhat.Text = "CẬP NHẬT";
            this.btn_CapNhat.UseVisualStyleBackColor = false;
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // btx_HoanThanh
            // 
            this.btx_HoanThanh.BackColor = System.Drawing.Color.LightGray;
            this.btx_HoanThanh.Location = new System.Drawing.Point(615, 723);
            this.btx_HoanThanh.Name = "btx_HoanThanh";
            this.btx_HoanThanh.Size = new System.Drawing.Size(135, 64);
            this.btx_HoanThanh.TabIndex = 11;
            this.btx_HoanThanh.Text = "HOÀN THÀNH";
            this.btx_HoanThanh.UseVisualStyleBackColor = false;
            this.btx_HoanThanh.Click += new System.EventHandler(this.btx_HoanThanh_Click);
            // 
            // btx_XoaOder
            // 
            this.btx_XoaOder.BackColor = System.Drawing.Color.LightGray;
            this.btx_XoaOder.Location = new System.Drawing.Point(815, 723);
            this.btx_XoaOder.Name = "btx_XoaOder";
            this.btx_XoaOder.Size = new System.Drawing.Size(135, 64);
            this.btx_XoaOder.TabIndex = 12;
            this.btx_XoaOder.Text = "XÓA";
            this.btx_XoaOder.UseVisualStyleBackColor = false;
            this.btx_XoaOder.Click += new System.EventHandler(this.btx_XoaOder_Click);
            // 
            // lab_May
            // 
            this.lab_May.AutoSize = true;
            this.lab_May.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_May.Location = new System.Drawing.Point(1286, 622);
            this.lab_May.Name = "lab_May";
            this.lab_May.Size = new System.Drawing.Size(76, 30);
            this.lab_May.TabIndex = 14;
            this.lab_May.Text = "MÁY";
            // 
            // Lab_AccDangNhap
            // 
            this.Lab_AccDangNhap.AutoSize = true;
            this.Lab_AccDangNhap.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_AccDangNhap.Location = new System.Drawing.Point(1090, 622);
            this.Lab_AccDangNhap.Name = "Lab_AccDangNhap";
            this.Lab_AccDangNhap.Size = new System.Drawing.Size(163, 30);
            this.Lab_AccDangNhap.TabIndex = 13;
            this.Lab_AccDangNhap.Text = "TÀI KHOẢN";
            // 
            // btn_XoaLichSu
            // 
            this.btn_XoaLichSu.BackColor = System.Drawing.Color.LightGray;
            this.btn_XoaLichSu.Location = new System.Drawing.Point(1042, 723);
            this.btn_XoaLichSu.Name = "btn_XoaLichSu";
            this.btn_XoaLichSu.Size = new System.Drawing.Size(165, 64);
            this.btn_XoaLichSu.TabIndex = 15;
            this.btn_XoaLichSu.Text = "XÓA ĐĂNG NHẶP";
            this.btn_XoaLichSu.UseVisualStyleBackColor = false;
            this.btn_XoaLichSu.Click += new System.EventHandler(this.btn_XoaLichSu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLQuanNet.Properties.Resources.img_122068;
            this.pictureBox1.Location = new System.Drawing.Point(64, 696);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 747);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 45);
            this.label1.TabIndex = 17;
            this.label1.Text = "ORDER VÀ LỊCH SỬ";
            // 
            // frmLichSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1556, 850);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_XoaLichSu);
            this.Controls.Add(this.lab_May);
            this.Controls.Add(this.Lab_AccDangNhap);
            this.Controls.Add(this.btx_XoaOder);
            this.Controls.Add(this.btx_HoanThanh);
            this.Controls.Add(this.btn_CapNhat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btx_DangXuat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLichSu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmLichSu";
            this.Load += new System.EventHandler(this.frmLichSu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btx_DangXuat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btn_CapNhat;
        private System.Windows.Forms.Button btx_HoanThanh;
        private System.Windows.Forms.Button btx_XoaOder;
        private System.Windows.Forms.Label lab_May;
        private System.Windows.Forms.Label lab_GhiChu;
        private System.Windows.Forms.Label lab_GiaMua;
        private System.Windows.Forms.Label lab_TenMua;
        private System.Windows.Forms.Label lab_MayMua;
        private System.Windows.Forms.Label lab_acc;
        private System.Windows.Forms.Label Lab_AccDangNhap;
        private System.Windows.Forms.Button btn_XoaLichSu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}