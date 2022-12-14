namespace McDonalds
{
    partial class MenuCart
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
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.pic_food = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_food)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Roboto Th", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(116, 10);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(97, 25);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Tên món";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Roboto Th", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.Location = new System.Drawing.Point(117, 82);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(38, 22);
            this.lbl_price.TabIndex = 2;
            this.lbl_price.Text = "Giá";
            this.lbl_price.Click += new System.EventHandler(this.lbl_price_Click);
            // 
            // pic_food
            // 
            this.pic_food.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_food.Image = global::McDonalds.Properties.Resources.mcdonalds_cone;
            this.pic_food.Location = new System.Drawing.Point(10, 10);
            this.pic_food.Name = "pic_food";
            this.pic_food.Size = new System.Drawing.Size(100, 100);
            this.pic_food.TabIndex = 0;
            this.pic_food.TabStop = false;
            this.pic_food.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.IndianRed;
            this.button2.Location = new System.Drawing.Point(387, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 27);
            this.button2.TabIndex = 4;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MenuCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.pic_food);
            this.Name = "MenuCart";
            this.Size = new System.Drawing.Size(494, 118);
            this.Load += new System.EventHandler(this.MenuCart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_food)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_food;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Button button2;
    }
}
