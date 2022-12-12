namespace McDonalds
{
    partial class FrmCounter
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewDonHang = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxMaNhanVien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTienNhan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelTienThua = new System.Windows.Forms.Label();
            this.buttonXuatHoaDon = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Beige;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 13);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(293, 778);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Beige;
            this.panel1.Controls.Add(this.lbTongTien);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.listViewDonHang);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(317, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 457);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Roboto Th", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(294, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN ĐƠN HÀNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listViewDonHang
            // 
            this.listViewDonHang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewDonHang.HideSelection = false;
            this.listViewDonHang.Location = new System.Drawing.Point(10, 40);
            this.listViewDonHang.Name = "listViewDonHang";
            this.listViewDonHang.Size = new System.Drawing.Size(814, 367);
            this.listViewDonHang.TabIndex = 1;
            this.listViewDonHang.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Th", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(565, 415);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tổng cộng";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbTongTien
            // 
            this.lbTongTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTongTien.Font = new System.Drawing.Font("Roboto Th", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongTien.Location = new System.Drawing.Point(696, 415);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(135, 29);
            this.lbTongTien.TabIndex = 3;
            this.lbTongTien.Text = "000000 VND";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.buttonXuatHoaDon);
            this.panel2.Controls.Add(this.labelTienThua);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBoxTienNhan);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBoxMaNhanVien);
            this.panel2.Location = new System.Drawing.Point(317, 476);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(833, 256);
            this.panel2.TabIndex = 2;
            // 
            // textBoxMaNhanVien
            // 
            this.textBoxMaNhanVien.Font = new System.Drawing.Font("Roboto Th", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaNhanVien.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxMaNhanVien.Location = new System.Drawing.Point(18, 18);
            this.textBoxMaNhanVien.Name = "textBoxMaNhanVien";
            this.textBoxMaNhanVien.Size = new System.Drawing.Size(451, 34);
            this.textBoxMaNhanVien.TabIndex = 0;
            this.textBoxMaNhanVien.Text = "Mã nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Th", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 27);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tiền khách đưa";
            // 
            // textBoxTienNhan
            // 
            this.textBoxTienNhan.Font = new System.Drawing.Font("Roboto Th", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTienNhan.Location = new System.Drawing.Point(253, 64);
            this.textBoxTienNhan.Name = "textBoxTienNhan";
            this.textBoxTienNhan.Size = new System.Drawing.Size(216, 34);
            this.textBoxTienNhan.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Th", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 27);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tiền thừa";
            // 
            // labelTienThua
            // 
            this.labelTienThua.AutoSize = true;
            this.labelTienThua.Font = new System.Drawing.Font("Roboto Th", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTienThua.Location = new System.Drawing.Point(336, 111);
            this.labelTienThua.Name = "labelTienThua";
            this.labelTienThua.Size = new System.Drawing.Size(143, 27);
            this.labelTienThua.TabIndex = 4;
            this.labelTienThua.Text = "000000 VND";
            // 
            // buttonXuatHoaDon
            // 
            this.buttonXuatHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonXuatHoaDon.BackColor = System.Drawing.Color.Firebrick;
            this.buttonXuatHoaDon.Font = new System.Drawing.Font("Roboto Th", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXuatHoaDon.ForeColor = System.Drawing.Color.Gold;
            this.buttonXuatHoaDon.Location = new System.Drawing.Point(662, 202);
            this.buttonXuatHoaDon.Name = "buttonXuatHoaDon";
            this.buttonXuatHoaDon.Size = new System.Drawing.Size(170, 51);
            this.buttonXuatHoaDon.TabIndex = 5;
            this.buttonXuatHoaDon.Text = "Xuất hóa đơn";
            this.buttonXuatHoaDon.UseVisualStyleBackColor = false;
            // 
            // FrmCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1163, 731);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Roboto Th", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmCounter";
            this.Text = "Thu Ngân";
            this.Load += new System.EventHandler(this.FrmCounter_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listViewDonHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelTienThua;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxTienNhan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMaNhanVien;
        private System.Windows.Forms.Button buttonXuatHoaDon;
    }
}