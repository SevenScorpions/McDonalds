namespace McDonalds
{
    partial class ItemChitiet
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pic_Food = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Food)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Roboto Th", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(24, 176);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(60, 22);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "label1";
            this.lbl_title.Click += new System.EventHandler(this.lbl_title_Click);
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Roboto Th", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.Location = new System.Drawing.Point(24, 233);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(60, 22);
            this.lbl_price.TabIndex = 2;
            this.lbl_price.Text = "label2";
            this.lbl_price.Click += new System.EventHandler(this.lbl_price_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.Font = new System.Drawing.Font("Roboto Th", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(186, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 38);
            this.button1.TabIndex = 3;
            this.button1.Tag = "Mon";
            this.button1.Text = "Chọn";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pic_Food
            // 
            this.pic_Food.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_Food.Location = new System.Drawing.Point(28, 14);
            this.pic_Food.Name = "pic_Food";
            this.pic_Food.Size = new System.Drawing.Size(233, 149);
            this.pic_Food.TabIndex = 0;
            this.pic_Food.TabStop = false;
            this.pic_Food.Click += new System.EventHandler(this.pic_Food_Click);
            // 
            // ItemChitiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.pic_Food);
            this.Name = "ItemChitiet";
            this.Size = new System.Drawing.Size(318, 276);
            this.Load += new System.EventHandler(this.ItemChitiet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Food)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_Food;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Button button1;
    }
}
