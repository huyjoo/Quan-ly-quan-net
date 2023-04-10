
namespace QLQuanNet
{
    partial class frmNguoiDungVip
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
            this.btxThoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtg = new System.Windows.Forms.DataGridView();
            this.txb_TaiKhoan = new System.Windows.Forms.TextBox();
            this.txb_TienConLai = new System.Windows.Forms.TextBox();
            this.txb_TienNap = new System.Windows.Forms.TextBox();
            this.txb_MatKhau = new System.Windows.Forms.TextBox();
            this.txb_SoGioChoi = new System.Windows.Forms.TextBox();
            this.btx_Sua = new System.Windows.Forms.Button();
            this.btx_Them = new System.Windows.Forms.Button();
            this.bxt_Xoa = new System.Windows.Forms.Button();
            this.lab_TaiKhoan = new System.Windows.Forms.Label();
            this.lab_MatKhau = new System.Windows.Forms.Label();
            this.lab_TienNap = new System.Windows.Forms.Label();
            this.lab_TienConLai = new System.Windows.Forms.Label();
            this.lab_GioChoi = new System.Windows.Forms.Label();
            this.lab_TrangThai = new System.Windows.Forms.Label();
            this.btx_Mo = new System.Windows.Forms.Button();
            this.btx_Khóa = new System.Windows.Forms.Button();
            this.labTrangThai = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btx_CapNhap = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btxThoat
            // 
            this.btxThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btxThoat.Font = new System.Drawing.Font("Times New Roman", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxThoat.Location = new System.Drawing.Point(1333, 680);
            this.btxThoat.Name = "btxThoat";
            this.btxThoat.Size = new System.Drawing.Size(146, 58);
            this.btxThoat.TabIndex = 6;
            this.btxThoat.Text = "THOÁT";
            this.btxThoat.UseVisualStyleBackColor = false;
            this.btxThoat.Click += new System.EventHandler(this.btxThoat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.dtg);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Green;
            this.groupBox1.Location = new System.Drawing.Point(66, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1058, 450);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DANH SÁCH THÀNH VIÊN";
            // 
            // dtg
            // 
            this.dtg.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dtg.Location = new System.Drawing.Point(24, 41);
            this.dtg.Name = "dtg";
            this.dtg.RowHeadersWidth = 72;
            this.dtg.RowTemplate.Height = 31;
            this.dtg.Size = new System.Drawing.Size(1004, 389);
            this.dtg.TabIndex = 0;
            this.dtg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_CellContentClick);
            // 
            // txb_TaiKhoan
            // 
            this.txb_TaiKhoan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_TaiKhoan.Location = new System.Drawing.Point(256, 500);
            this.txb_TaiKhoan.Name = "txb_TaiKhoan";
            this.txb_TaiKhoan.Size = new System.Drawing.Size(180, 35);
            this.txb_TaiKhoan.TabIndex = 8;
            // 
            // txb_TienConLai
            // 
            this.txb_TienConLai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_TienConLai.Location = new System.Drawing.Point(772, 500);
            this.txb_TienConLai.Name = "txb_TienConLai";
            this.txb_TienConLai.Size = new System.Drawing.Size(180, 35);
            this.txb_TienConLai.TabIndex = 9;
            this.txb_TienConLai.Text = "50000";
            // 
            // txb_TienNap
            // 
            this.txb_TienNap.Enabled = false;
            this.txb_TienNap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_TienNap.Location = new System.Drawing.Point(256, 669);
            this.txb_TienNap.Name = "txb_TienNap";
            this.txb_TienNap.Size = new System.Drawing.Size(174, 35);
            this.txb_TienNap.TabIndex = 10;
            this.txb_TienNap.Text = "50000";
            // 
            // txb_MatKhau
            // 
            this.txb_MatKhau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_MatKhau.Location = new System.Drawing.Point(256, 578);
            this.txb_MatKhau.Name = "txb_MatKhau";
            this.txb_MatKhau.Size = new System.Drawing.Size(174, 35);
            this.txb_MatKhau.TabIndex = 11;
            // 
            // txb_SoGioChoi
            // 
            this.txb_SoGioChoi.Enabled = false;
            this.txb_SoGioChoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_SoGioChoi.Location = new System.Drawing.Point(772, 586);
            this.txb_SoGioChoi.Name = "txb_SoGioChoi";
            this.txb_SoGioChoi.Size = new System.Drawing.Size(180, 35);
            this.txb_SoGioChoi.TabIndex = 12;
            // 
            // btx_Sua
            // 
            this.btx_Sua.Font = new System.Drawing.Font("Times New Roman", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btx_Sua.Location = new System.Drawing.Point(1002, 606);
            this.btx_Sua.Name = "btx_Sua";
            this.btx_Sua.Size = new System.Drawing.Size(146, 58);
            this.btx_Sua.TabIndex = 14;
            this.btx_Sua.Text = "SỬA";
            this.btx_Sua.UseVisualStyleBackColor = true;
            this.btx_Sua.Click += new System.EventHandler(this.btx_Sua_Click);
            // 
            // btx_Them
            // 
            this.btx_Them.Font = new System.Drawing.Font("Times New Roman", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btx_Them.Location = new System.Drawing.Point(1002, 498);
            this.btx_Them.Name = "btx_Them";
            this.btx_Them.Size = new System.Drawing.Size(146, 58);
            this.btx_Them.TabIndex = 15;
            this.btx_Them.Text = "THÊM";
            this.btx_Them.UseVisualStyleBackColor = true;
            this.btx_Them.Click += new System.EventHandler(this.btx_Them_Click);
            // 
            // bxt_Xoa
            // 
            this.bxt_Xoa.Font = new System.Drawing.Font("Times New Roman", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bxt_Xoa.Location = new System.Drawing.Point(1171, 682);
            this.bxt_Xoa.Name = "bxt_Xoa";
            this.bxt_Xoa.Size = new System.Drawing.Size(146, 58);
            this.bxt_Xoa.TabIndex = 16;
            this.bxt_Xoa.Text = "XÓA";
            this.bxt_Xoa.UseVisualStyleBackColor = true;
            this.bxt_Xoa.Click += new System.EventHandler(this.bxt_Xoa_Click);
            // 
            // lab_TaiKhoan
            // 
            this.lab_TaiKhoan.AutoSize = true;
            this.lab_TaiKhoan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_TaiKhoan.Location = new System.Drawing.Point(38, 512);
            this.lab_TaiKhoan.Name = "lab_TaiKhoan";
            this.lab_TaiKhoan.Size = new System.Drawing.Size(142, 27);
            this.lab_TaiKhoan.TabIndex = 18;
            this.lab_TaiKhoan.Text = "TÀI KHOẢN";
            // 
            // lab_MatKhau
            // 
            this.lab_MatKhau.AutoSize = true;
            this.lab_MatKhau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_MatKhau.Location = new System.Drawing.Point(38, 602);
            this.lab_MatKhau.Name = "lab_MatKhau";
            this.lab_MatKhau.Size = new System.Drawing.Size(137, 27);
            this.lab_MatKhau.TabIndex = 19;
            this.lab_MatKhau.Text = "MẬT KHẨU";
            // 
            // lab_TienNap
            // 
            this.lab_TienNap.AutoSize = true;
            this.lab_TienNap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_TienNap.Location = new System.Drawing.Point(38, 680);
            this.lab_TienNap.Name = "lab_TienNap";
            this.lab_TienNap.Size = new System.Drawing.Size(120, 27);
            this.lab_TienNap.TabIndex = 20;
            this.lab_TienNap.Text = "TIỀN NẠP";
            // 
            // lab_TienConLai
            // 
            this.lab_TienConLai.AutoSize = true;
            this.lab_TienConLai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_TienConLai.Location = new System.Drawing.Point(526, 512);
            this.lab_TienConLai.Name = "lab_TienConLai";
            this.lab_TienConLai.Size = new System.Drawing.Size(168, 27);
            this.lab_TienConLai.TabIndex = 21;
            this.lab_TienConLai.Text = "TIỀN CÒN LẠI";
            // 
            // lab_GioChoi
            // 
            this.lab_GioChoi.AutoSize = true;
            this.lab_GioChoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_GioChoi.Location = new System.Drawing.Point(526, 594);
            this.lab_GioChoi.Name = "lab_GioChoi";
            this.lab_GioChoi.Size = new System.Drawing.Size(153, 27);
            this.lab_GioChoi.TabIndex = 22;
            this.lab_GioChoi.Text = "SỐ GIỜ CHƠI";
            // 
            // lab_TrangThai
            // 
            this.lab_TrangThai.AutoSize = true;
            this.lab_TrangThai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_TrangThai.Location = new System.Drawing.Point(524, 682);
            this.lab_TrangThai.Name = "lab_TrangThai";
            this.lab_TrangThai.Size = new System.Drawing.Size(155, 27);
            this.lab_TrangThai.TabIndex = 23;
            this.lab_TrangThai.Text = "TRẠNG THÁI";
            // 
            // btx_Mo
            // 
            this.btx_Mo.Font = new System.Drawing.Font("Times New Roman", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btx_Mo.Location = new System.Drawing.Point(1333, 498);
            this.btx_Mo.Name = "btx_Mo";
            this.btx_Mo.Size = new System.Drawing.Size(146, 58);
            this.btx_Mo.TabIndex = 24;
            this.btx_Mo.Text = "NỞ";
            this.btx_Mo.UseVisualStyleBackColor = true;
            this.btx_Mo.Click += new System.EventHandler(this.btx_Mo_Click);
            // 
            // btx_Khóa
            // 
            this.btx_Khóa.BackColor = System.Drawing.Color.White;
            this.btx_Khóa.Font = new System.Drawing.Font("Times New Roman", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btx_Khóa.Location = new System.Drawing.Point(1333, 603);
            this.btx_Khóa.Name = "btx_Khóa";
            this.btx_Khóa.Size = new System.Drawing.Size(146, 61);
            this.btx_Khóa.TabIndex = 25;
            this.btx_Khóa.Text = "KHÓA";
            this.btx_Khóa.UseVisualStyleBackColor = false;
            this.btx_Khóa.Click += new System.EventHandler(this.btx_Khóa_Click);
            // 
            // labTrangThai
            // 
            this.labTrangThai.AutoSize = true;
            this.labTrangThai.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTrangThai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labTrangThai.Location = new System.Drawing.Point(767, 682);
            this.labTrangThai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labTrangThai.Name = "labTrangThai";
            this.labTrangThai.Size = new System.Drawing.Size(172, 30);
            this.labTrangThai.TabIndex = 26;
            this.labTrangThai.Text = "HOẠT ĐỘNG";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLQuanNet.Properties.Resources.kisspng_computer_icons_users_group_google_groups_henna_gruop_5b13319cb83614_3219477715279845407545;
            this.pictureBox1.Location = new System.Drawing.Point(1156, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(344, 422);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // btx_CapNhap
            // 
            this.btx_CapNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btx_CapNhap.Font = new System.Drawing.Font("Times New Roman", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btx_CapNhap.Location = new System.Drawing.Point(1002, 682);
            this.btx_CapNhap.Name = "btx_CapNhap";
            this.btx_CapNhap.Size = new System.Drawing.Size(146, 58);
            this.btx_CapNhap.TabIndex = 28;
            this.btx_CapNhap.Text = "CẬP NHẬT";
            this.btx_CapNhap.UseVisualStyleBackColor = false;
            this.btx_CapNhap.Click += new System.EventHandler(this.btx_CapNhap_Click);
            // 
            // frmNguoiDungVip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1534, 797);
            this.Controls.Add(this.btx_CapNhap);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labTrangThai);
            this.Controls.Add(this.btx_Khóa);
            this.Controls.Add(this.btx_Mo);
            this.Controls.Add(this.lab_TrangThai);
            this.Controls.Add(this.lab_GioChoi);
            this.Controls.Add(this.lab_TienConLai);
            this.Controls.Add(this.lab_TienNap);
            this.Controls.Add(this.lab_MatKhau);
            this.Controls.Add(this.lab_TaiKhoan);
            this.Controls.Add(this.bxt_Xoa);
            this.Controls.Add(this.btx_Them);
            this.Controls.Add(this.btx_Sua);
            this.Controls.Add(this.txb_SoGioChoi);
            this.Controls.Add(this.txb_MatKhau);
            this.Controls.Add(this.txb_TienNap);
            this.Controls.Add(this.txb_TienConLai);
            this.Controls.Add(this.txb_TaiKhoan);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btxThoat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNguoiDungVip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Người chơi VIP";
            this.Load += new System.EventHandler(this.frmNguoiDungVip_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btxThoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtg;
        private System.Windows.Forms.TextBox txb_TaiKhoan;
        private System.Windows.Forms.TextBox txb_TienConLai;
        private System.Windows.Forms.TextBox txb_TienNap;
        private System.Windows.Forms.TextBox txb_MatKhau;
        private System.Windows.Forms.TextBox txb_SoGioChoi;
        private System.Windows.Forms.Button btx_Sua;
        private System.Windows.Forms.Button btx_Them;
        private System.Windows.Forms.Button bxt_Xoa;
        private System.Windows.Forms.Label lab_TaiKhoan;
        private System.Windows.Forms.Label lab_MatKhau;
        private System.Windows.Forms.Label lab_TienNap;
        private System.Windows.Forms.Label lab_TienConLai;
        private System.Windows.Forms.Label lab_GioChoi;
        private System.Windows.Forms.Label lab_TrangThai;
        private System.Windows.Forms.Button btx_Mo;
        private System.Windows.Forms.Button btx_Khóa;
        private System.Windows.Forms.Label labTrangThai;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btx_CapNhap;
    }
}