namespace McDonalds
{
    partial class GiaoDienNV
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabKiemKho = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabNhapKho = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.bttnTimKiem = new System.Windows.Forms.Button();
            this.cbNguyenLieuKK = new System.Windows.Forms.ComboBox();
            this.cbNhapHangKK = new System.Windows.Forms.ComboBox();
            this.lvLoHangKK = new System.Windows.Forms.ListView();
            this.tabControl.SuspendLayout();
            this.tabKiemKho.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabKiemKho);
            this.tabControl.Controls.Add(this.tabNhapKho);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1200, 759);
            this.tabControl.TabIndex = 0;
            // 
            // tabKiemKho
            // 
            this.tabKiemKho.Controls.Add(this.panel2);
            this.tabKiemKho.Controls.Add(this.panel1);
            this.tabKiemKho.Location = new System.Drawing.Point(4, 36);
            this.tabKiemKho.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabKiemKho.Name = "tabKiemKho";
            this.tabKiemKho.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabKiemKho.Size = new System.Drawing.Size(1192, 719);
            this.tabKiemKho.TabIndex = 0;
            this.tabKiemKho.Text = "Kiểm Kho";
            this.tabKiemKho.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lvLoHangKK);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(4, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1184, 609);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.cbNhapHangKK);
            this.panel1.Controls.Add(this.cbNguyenLieuKK);
            this.panel1.Controls.Add(this.bttnTimKiem);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nguyên Liệu";
            // 
            // tabNhapKho
            // 
            this.tabNhapKho.Location = new System.Drawing.Point(4, 36);
            this.tabNhapKho.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabNhapKho.Name = "tabNhapKho";
            this.tabNhapKho.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabNhapKho.Size = new System.Drawing.Size(1192, 719);
            this.tabNhapKho.TabIndex = 1;
            this.tabNhapKho.Text = "Nhập Kho";
            this.tabNhapKho.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đợt Nhập Hàng";
            // 
            // bttnTimKiem
            // 
            this.bttnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnTimKiem.Location = new System.Drawing.Point(1047, 13);
            this.bttnTimKiem.Name = "bttnTimKiem";
            this.bttnTimKiem.Size = new System.Drawing.Size(133, 68);
            this.bttnTimKiem.TabIndex = 2;
            this.bttnTimKiem.Text = "Tìm Kiếm";
            this.bttnTimKiem.UseVisualStyleBackColor = true;
            this.bttnTimKiem.Click += new System.EventHandler(this.bttnTimKiem_Click);
            // 
            // cbNguyenLieuKK
            // 
            this.cbNguyenLieuKK.FormattingEnabled = true;
            this.cbNguyenLieuKK.Location = new System.Drawing.Point(172, 10);
            this.cbNguyenLieuKK.Name = "cbNguyenLieuKK";
            this.cbNguyenLieuKK.Size = new System.Drawing.Size(304, 35);
            this.cbNguyenLieuKK.TabIndex = 3;
            // 
            // cbNhapHangKK
            // 
            this.cbNhapHangKK.FormattingEnabled = true;
            this.cbNhapHangKK.Location = new System.Drawing.Point(172, 51);
            this.cbNhapHangKK.Name = "cbNhapHangKK";
            this.cbNhapHangKK.Size = new System.Drawing.Size(304, 35);
            this.cbNhapHangKK.TabIndex = 4;
            // 
            // lvLoHangKK
            // 
            this.lvLoHangKK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvLoHangKK.HideSelection = false;
            this.lvLoHangKK.Location = new System.Drawing.Point(0, 0);
            this.lvLoHangKK.Name = "lvLoHangKK";
            this.lvLoHangKK.Size = new System.Drawing.Size(1184, 609);
            this.lvLoHangKK.TabIndex = 0;
            this.lvLoHangKK.UseCompatibleStateImageBehavior = false;
            // 
            // GiaoDienNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 759);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GiaoDienNV";
            this.Text = "GiaoDienNV";
            this.tabControl.ResumeLayout(false);
            this.tabKiemKho.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabKiemKho;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabNhapKho;
        private System.Windows.Forms.ComboBox cbNhapHangKK;
        private System.Windows.Forms.ComboBox cbNguyenLieuKK;
        private System.Windows.Forms.Button bttnTimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvLoHangKK;
    }
}