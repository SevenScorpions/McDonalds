namespace McDonalds
{
    partial class ChonCN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChonCN));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bttnExit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bttnDelivery = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bttnCounter = new System.Windows.Forms.Button();
            this.bttnKitchen = new System.Windows.Forms.Button();
            this.bttnStaff = new System.Windows.Forms.Button();
            this.bttnCustomer = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bttnExit);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 512);
            this.panel1.TabIndex = 0;
            // 
            // bttnExit
            // 
            this.bttnExit.BackColor = System.Drawing.Color.IndianRed;
            this.bttnExit.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnExit.Location = new System.Drawing.Point(687, 462);
            this.bttnExit.Name = "bttnExit";
            this.bttnExit.Size = new System.Drawing.Size(98, 38);
            this.bttnExit.TabIndex = 5;
            this.bttnExit.Text = "Thoát";
            this.bttnExit.UseVisualStyleBackColor = false;
            this.bttnExit.Click += new System.EventHandler(this.bttnExit_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Firebrick;
            this.panel3.Controls.Add(this.bttnDelivery);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.bttnCounter);
            this.panel3.Controls.Add(this.bttnKitchen);
            this.panel3.Controls.Add(this.bttnStaff);
            this.panel3.Controls.Add(this.bttnCustomer);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Font = new System.Drawing.Font("Gugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(797, 387);
            this.panel3.TabIndex = 1;
            // 
            // bttnDelivery
            // 
            this.bttnDelivery.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bttnDelivery.BackColor = System.Drawing.Color.IndianRed;
            this.bttnDelivery.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnDelivery.Location = new System.Drawing.Point(625, 183);
            this.bttnDelivery.Margin = new System.Windows.Forms.Padding(20, 25, 20, 25);
            this.bttnDelivery.Name = "bttnDelivery";
            this.bttnDelivery.Size = new System.Drawing.Size(100, 100);
            this.bttnDelivery.TabIndex = 4;
            this.bttnDelivery.Text = "Hoàn tất đơn hàng";
            this.bttnDelivery.UseVisualStyleBackColor = false;
            this.bttnDelivery.Click += new System.EventHandler(this.bttnDelivery_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::McDonalds.Properties.Resources.McDonald_s_Golden_Arches_svg;
            this.pictureBox2.Location = new System.Drawing.Point(33, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(87, 83);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // bttnCounter
            // 
            this.bttnCounter.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bttnCounter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bttnCounter.BackColor = System.Drawing.Color.IndianRed;
            this.bttnCounter.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnCounter.Location = new System.Drawing.Point(345, 183);
            this.bttnCounter.Margin = new System.Windows.Forms.Padding(20, 25, 20, 25);
            this.bttnCounter.Name = "bttnCounter";
            this.bttnCounter.Size = new System.Drawing.Size(100, 100);
            this.bttnCounter.TabIndex = 2;
            this.bttnCounter.Text = "Thu ngân";
            this.bttnCounter.UseVisualStyleBackColor = false;
            this.bttnCounter.Click += new System.EventHandler(this.bttnCounter_Click);
            // 
            // bttnKitchen
            // 
            this.bttnKitchen.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bttnKitchen.BackColor = System.Drawing.Color.IndianRed;
            this.bttnKitchen.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnKitchen.Location = new System.Drawing.Point(485, 183);
            this.bttnKitchen.Margin = new System.Windows.Forms.Padding(20, 25, 20, 25);
            this.bttnKitchen.Name = "bttnKitchen";
            this.bttnKitchen.Size = new System.Drawing.Size(100, 100);
            this.bttnKitchen.TabIndex = 3;
            this.bttnKitchen.Text = "Bếp";
            this.bttnKitchen.UseVisualStyleBackColor = false;
            this.bttnKitchen.Click += new System.EventHandler(this.bttnKitchen_Click);
            // 
            // bttnStaff
            // 
            this.bttnStaff.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bttnStaff.BackColor = System.Drawing.Color.IndianRed;
            this.bttnStaff.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnStaff.Location = new System.Drawing.Point(65, 183);
            this.bttnStaff.Margin = new System.Windows.Forms.Padding(20, 25, 20, 25);
            this.bttnStaff.Name = "bttnStaff";
            this.bttnStaff.Size = new System.Drawing.Size(100, 100);
            this.bttnStaff.TabIndex = 0;
            this.bttnStaff.Text = "Nhân viên";
            this.bttnStaff.UseVisualStyleBackColor = false;
            this.bttnStaff.Click += new System.EventHandler(this.bttnDangNhapNV_Click);
            // 
            // bttnCustomer
            // 
            this.bttnCustomer.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bttnCustomer.BackColor = System.Drawing.Color.IndianRed;
            this.bttnCustomer.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnCustomer.Location = new System.Drawing.Point(205, 183);
            this.bttnCustomer.Margin = new System.Windows.Forms.Padding(20, 25, 20, 25);
            this.bttnCustomer.Name = "bttnCustomer";
            this.bttnCustomer.Size = new System.Drawing.Size(100, 100);
            this.bttnCustomer.TabIndex = 1;
            this.bttnCustomer.Text = "Khách hàng";
            this.bttnCustomer.UseVisualStyleBackColor = false;
            this.bttnCustomer.Click += new System.EventHandler(this.bttnCustomer_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::McDonalds.Properties.Resources.mau1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 387);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(797, 125);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // ChonCN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 512);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ChonCN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Default";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bttnCustomer;
        private System.Windows.Forms.Button bttnStaff;
        private System.Windows.Forms.Button bttnCounter;
        private System.Windows.Forms.Button bttnKitchen;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bttnDelivery;
        private System.Windows.Forms.Button bttnExit;
    }
}