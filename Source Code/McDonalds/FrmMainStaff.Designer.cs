namespace McDonalds
{
    partial class FrmMainStaff
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainStaff));
            this.khoNguyenLieu = new System.Windows.Forms.TabPage();
            this.chiTietDonNhap = new System.Windows.Forms.TabPage();
            this.quanLyDonNhap = new System.Windows.Forms.TabPage();
            this.quanLyNhanVien = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.quanLyHoaDon = new System.Windows.Forms.TabPage();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.quanLyNhanVien.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // khoNguyenLieu
            // 
            this.khoNguyenLieu.Font = new System.Drawing.Font("Roboto Cn", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.khoNguyenLieu.Location = new System.Drawing.Point(4, 24);
            this.khoNguyenLieu.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.khoNguyenLieu.Name = "khoNguyenLieu";
            this.khoNguyenLieu.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.khoNguyenLieu.Size = new System.Drawing.Size(992, 474);
            this.khoNguyenLieu.TabIndex = 4;
            this.khoNguyenLieu.Text = "Kho Nguyên Liệu";
            this.khoNguyenLieu.UseVisualStyleBackColor = true;
            // 
            // chiTietDonNhap
            // 
            this.chiTietDonNhap.Font = new System.Drawing.Font("Roboto Cn", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chiTietDonNhap.Location = new System.Drawing.Point(4, 24);
            this.chiTietDonNhap.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chiTietDonNhap.Name = "chiTietDonNhap";
            this.chiTietDonNhap.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chiTietDonNhap.Size = new System.Drawing.Size(992, 474);
            this.chiTietDonNhap.TabIndex = 3;
            this.chiTietDonNhap.Text = "Chi Tiết Đơn Nhập";
            this.chiTietDonNhap.UseVisualStyleBackColor = true;
            // 
            // quanLyDonNhap
            // 
            this.quanLyDonNhap.Font = new System.Drawing.Font("Roboto Cn", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.quanLyDonNhap.Location = new System.Drawing.Point(4, 24);
            this.quanLyDonNhap.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.quanLyDonNhap.Name = "quanLyDonNhap";
            this.quanLyDonNhap.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.quanLyDonNhap.Size = new System.Drawing.Size(992, 474);
            this.quanLyDonNhap.TabIndex = 1;
            this.quanLyDonNhap.Text = "Quản Lý Đơn Nhập";
            this.quanLyDonNhap.UseVisualStyleBackColor = true;
            // 
            // quanLyNhanVien
            // 
            this.quanLyNhanVien.Controls.Add(this.flowLayoutPanel1);
            this.quanLyNhanVien.Font = new System.Drawing.Font("Roboto Cn", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.quanLyNhanVien.Location = new System.Drawing.Point(4, 24);
            this.quanLyNhanVien.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.quanLyNhanVien.Name = "quanLyNhanVien";
            this.quanLyNhanVien.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.quanLyNhanVien.Size = new System.Drawing.Size(992, 474);
            this.quanLyNhanVien.TabIndex = 0;
            this.quanLyNhanVien.Text = "Quản Lý Nhân Viên";
            this.quanLyNhanVien.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.quanLyNhanVien);
            this.tabControl1.Controls.Add(this.quanLyDonNhap);
            this.tabControl1.Controls.Add(this.chiTietDonNhap);
            this.tabControl1.Controls.Add(this.khoNguyenLieu);
            this.tabControl1.Controls.Add(this.quanLyHoaDon);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1000, 502);
            this.tabControl1.TabIndex = 0;
            // 
            // quanLyHoaDon
            // 
            this.quanLyHoaDon.Font = new System.Drawing.Font("Roboto Cn", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.quanLyHoaDon.Location = new System.Drawing.Point(4, 24);
            this.quanLyHoaDon.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.quanLyHoaDon.Name = "quanLyHoaDon";
            this.quanLyHoaDon.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.quanLyHoaDon.Size = new System.Drawing.Size(992, 474);
            this.quanLyHoaDon.TabIndex = 5;
            this.quanLyHoaDon.Text = "Quản Lý Hóa Đơn";
            this.quanLyHoaDon.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(20, 20);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(950, 360);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // FrmMainStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 502);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Roboto Cn", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FrmMainStaff";
            this.Text = "McDonalds";
            this.Load += new System.EventHandler(this.FrmMainStaff_Load);
            this.quanLyNhanVien.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage khoNguyenLieu;
        private System.Windows.Forms.TabPage chiTietDonNhap;
        private System.Windows.Forms.TabPage quanLyDonNhap;
        private System.Windows.Forms.TabPage quanLyNhanVien;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage quanLyHoaDon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}