
namespace QLQuanNet
{
    partial class frmTinhTien
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtg = new System.Windows.Forms.DataGridView();
            this.lab_Tien = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lab_May = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TXB_TienKhac = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_SoGioChoi = new System.Windows.Forms.TextBox();
            this.txb_MaDon = new System.Windows.Forms.TextBox();
            this.btxThoat = new System.Windows.Forms.Button();
            this.btx_Xoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btxTinhTien = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtg);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(10, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(730, 725);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LỊCH SỬ THANH TOÁN";
            // 
            // dtg
            // 
            this.dtg.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg.Location = new System.Drawing.Point(0, 28);
            this.dtg.Name = "dtg";
            this.dtg.RowHeadersWidth = 72;
            this.dtg.RowTemplate.Height = 31;
            this.dtg.Size = new System.Drawing.Size(711, 692);
            this.dtg.TabIndex = 12;
            this.dtg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_CellContentClick);
            // 
            // lab_Tien
            // 
            this.lab_Tien.AutoSize = true;
            this.lab_Tien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Tien.Location = new System.Drawing.Point(1077, 594);
            this.lab_Tien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_Tien.Name = "lab_Tien";
            this.lab_Tien.Size = new System.Drawing.Size(0, 36);
            this.lab_Tien.TabIndex = 38;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QLQuanNet.Properties.Resources.conmputer;
            this.pictureBox2.Location = new System.Drawing.Point(1334, 348);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(178, 149);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            // 
            // lab_May
            // 
            this.lab_May.AutoSize = true;
            this.lab_May.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_May.ForeColor = System.Drawing.Color.ForestGreen;
            this.lab_May.Location = new System.Drawing.Point(1354, 502);
            this.lab_May.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_May.Name = "lab_May";
            this.lab_May.Size = new System.Drawing.Size(0, 36);
            this.lab_May.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(898, 553);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 23);
            this.label4.TabIndex = 34;
            this.label4.Text = "TIỀN KHÁC";
            // 
            // TXB_TienKhac
            // 
            this.TXB_TienKhac.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_TienKhac.Location = new System.Drawing.Point(1086, 544);
            this.TXB_TienKhac.Name = "TXB_TienKhac";
            this.TXB_TienKhac.Size = new System.Drawing.Size(224, 37);
            this.TXB_TienKhac.TabIndex = 33;
            this.TXB_TienKhac.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(896, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 23);
            this.label5.TabIndex = 32;
            this.label5.Text = "MÁY CHƠI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(894, 606);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 23);
            this.label3.TabIndex = 31;
            this.label3.Text = "TỔNG TIỀN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(896, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 23);
            this.label2.TabIndex = 30;
            this.label2.Text = "SỐ GIỜ CHƠI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(898, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 23);
            this.label1.TabIndex = 29;
            this.label1.Text = "MÃ ĐƠN";
            // 
            // txb_SoGioChoi
            // 
            this.txb_SoGioChoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_SoGioChoi.Location = new System.Drawing.Point(1084, 286);
            this.txb_SoGioChoi.Name = "txb_SoGioChoi";
            this.txb_SoGioChoi.Size = new System.Drawing.Size(224, 37);
            this.txb_SoGioChoi.TabIndex = 28;
            // 
            // txb_MaDon
            // 
            this.txb_MaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_MaDon.Location = new System.Drawing.Point(1084, 217);
            this.txb_MaDon.Name = "txb_MaDon";
            this.txb_MaDon.Size = new System.Drawing.Size(224, 37);
            this.txb_MaDon.TabIndex = 27;
            // 
            // btxThoat
            // 
            this.btxThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btxThoat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btxThoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btxThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btxThoat.Location = new System.Drawing.Point(1298, 669);
            this.btxThoat.Name = "btxThoat";
            this.btxThoat.Size = new System.Drawing.Size(104, 57);
            this.btxThoat.TabIndex = 26;
            this.btxThoat.Text = "THOÁT";
            this.btxThoat.UseVisualStyleBackColor = false;
            this.btxThoat.Click += new System.EventHandler(this.btxThoat_Click_1);
            // 
            // btx_Xoa
            // 
            this.btx_Xoa.BackColor = System.Drawing.Color.Gray;
            this.btx_Xoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btx_Xoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btx_Xoa.Location = new System.Drawing.Point(1167, 669);
            this.btx_Xoa.Name = "btx_Xoa";
            this.btx_Xoa.Size = new System.Drawing.Size(104, 57);
            this.btx_Xoa.TabIndex = 25;
            this.btx_Xoa.Text = "XÓA";
            this.btx_Xoa.UseVisualStyleBackColor = false;
            this.btx_Xoa.Click += new System.EventHandler(this.btxXoa_Click_1);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLuu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLuu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLuu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLuu.Location = new System.Drawing.Point(1035, 669);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(104, 57);
            this.btnLuu.TabIndex = 24;
            this.btnLuu.Text = "LƯU";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click_1);
            // 
            // btxTinhTien
            // 
            this.btxTinhTien.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btxTinhTien.FlatAppearance.BorderSize = 5;
            this.btxTinhTien.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btxTinhTien.Location = new System.Drawing.Point(910, 669);
            this.btxTinhTien.Name = "btxTinhTien";
            this.btxTinhTien.Size = new System.Drawing.Size(105, 57);
            this.btxTinhTien.TabIndex = 23;
            this.btxTinhTien.Text = "TÍNH TIỀN";
            this.btxTinhTien.UseVisualStyleBackColor = true;
            this.btxTinhTien.Click += new System.EventHandler(this.btxTinhTien_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLQuanNet.Properties.Resources.tinhtien;
            this.pictureBox1.Location = new System.Drawing.Point(940, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(484, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(1090, 368);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.Size = new System.Drawing.Size(219, 161);
            this.dataGridView2.TabIndex = 39;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // frmTinhTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1534, 798);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.lab_Tien);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lab_May);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TXB_TienKhac);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_SoGioChoi);
            this.Controls.Add(this.txb_MaDon);
            this.Controls.Add(this.btxThoat);
            this.Controls.Add(this.btx_Xoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btxTinhTien);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTinhTien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Tính tiền";
            this.Load += new System.EventHandler(this.frmTinhTien_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtg;
        private System.Windows.Forms.Label lab_Tien;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lab_May;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXB_TienKhac;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_SoGioChoi;
        private System.Windows.Forms.TextBox txb_MaDon;
        private System.Windows.Forms.Button btxThoat;
        private System.Windows.Forms.Button btx_Xoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btxTinhTien;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}