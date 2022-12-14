namespace McDonalds
{
    partial class quanlynhanvien
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.hoVaTen = new System.Windows.Forms.Label();
            this.chucVu = new System.Windows.Forms.Label();
            this.soDienThoai = new System.Windows.Forms.Label();
            this.maNhanVien = new System.Windows.Forms.Label();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_chiTiet = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // hoVaTen
            // 
            this.hoVaTen.AutoSize = true;
            this.hoVaTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.hoVaTen.Location = new System.Drawing.Point(131, 20);
            this.hoVaTen.Name = "hoVaTen";
            this.hoVaTen.Size = new System.Drawing.Size(53, 20);
            this.hoVaTen.TabIndex = 1;
            this.hoVaTen.Text = "label1";
            this.hoVaTen.Click += new System.EventHandler(this.label1_Click);
            // 
            // chucVu
            // 
            this.chucVu.AutoSize = true;
            this.chucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chucVu.Location = new System.Drawing.Point(321, 79);
            this.chucVu.Name = "chucVu";
            this.chucVu.Size = new System.Drawing.Size(53, 20);
            this.chucVu.TabIndex = 2;
            this.chucVu.Text = "label2";
            // 
            // soDienThoai
            // 
            this.soDienThoai.AutoSize = true;
            this.soDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.soDienThoai.Location = new System.Drawing.Point(131, 79);
            this.soDienThoai.Name = "soDienThoai";
            this.soDienThoai.Size = new System.Drawing.Size(53, 20);
            this.soDienThoai.TabIndex = 3;
            this.soDienThoai.Text = "label3";
            this.soDienThoai.Click += new System.EventHandler(this.soDienThoai_Click);
            // 
            // maNhanVien
            // 
            this.maNhanVien.AutoSize = true;
            this.maNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.maNhanVien.Location = new System.Drawing.Point(321, 20);
            this.maNhanVien.Name = "maNhanVien";
            this.maNhanVien.Size = new System.Drawing.Size(53, 20);
            this.maNhanVien.TabIndex = 4;
            this.maNhanVien.Text = "label4";
            this.maNhanVien.Click += new System.EventHandler(this.maNhanVien_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.Gray;
            this.btn_xoa.Font = new System.Drawing.Font("Roboto Th", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_xoa.ForeColor = System.Drawing.Color.Gold;
            this.btn_xoa.Location = new System.Drawing.Point(550, 72);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(125, 35);
            this.btn_xoa.TabIndex = 5;
            this.btn_xoa.Text = "XÓA";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_chiTiet
            // 
            this.btn_chiTiet.BackColor = System.Drawing.Color.Gray;
            this.btn_chiTiet.Font = new System.Drawing.Font("Roboto Th", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_chiTiet.ForeColor = System.Drawing.Color.Gold;
            this.btn_chiTiet.Location = new System.Drawing.Point(550, 13);
            this.btn_chiTiet.Name = "btn_chiTiet";
            this.btn_chiTiet.Size = new System.Drawing.Size(125, 35);
            this.btn_chiTiet.TabIndex = 6;
            this.btn_chiTiet.Text = "CHI TIẾT";
            this.btn_chiTiet.UseVisualStyleBackColor = false;
            this.btn_chiTiet.Click += new System.EventHandler(this.btn_chiTiet_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::McDonalds.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(13, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // quanlynhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btn_chiTiet);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.maNhanVien);
            this.Controls.Add(this.soDienThoai);
            this.Controls.Add(this.chucVu);
            this.Controls.Add(this.hoVaTen);
            this.Controls.Add(this.pictureBox1);
            this.Name = "quanlynhanvien";
            this.Size = new System.Drawing.Size(700, 117);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label hoVaTen;
        private System.Windows.Forms.Label chucVu;
        private System.Windows.Forms.Label soDienThoai;
        private System.Windows.Forms.Label maNhanVien;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_chiTiet;
    }
}
