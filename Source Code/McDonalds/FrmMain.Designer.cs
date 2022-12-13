namespace McDonalds
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.mainPanel = new System.Windows.Forms.TabControl();
            this.tabMenu = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tabCart = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bttnOrder = new System.Windows.Forms.Button();
            this.tabProfile = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.bttnSignOut = new System.Windows.Forms.Button();
            this.bttnChangePassword = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bttnSave = new System.Windows.Forms.Button();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.tbRePassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rbttnFemale = new System.Windows.Forms.RadioButton();
            this.rbttnMale = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.mainPanel.SuspendLayout();
            this.tabMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabCart.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabProfile.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.tabMenu);
            this.mainPanel.Controls.Add(this.tabCart);
            this.mainPanel.Controls.Add(this.tabProfile);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Font = new System.Drawing.Font("Roboto Th", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.SelectedIndex = 0;
            this.mainPanel.Size = new System.Drawing.Size(1242, 758);
            this.mainPanel.TabIndex = 2;
            // 
            // tabMenu
            // 
            this.tabMenu.BackgroundImage = global::McDonalds.Properties.Resources._1600px_COLOURBOX54593006;
            this.tabMenu.Controls.Add(this.panel2);
            this.tabMenu.Font = new System.Drawing.Font("Roboto Th", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMenu.Location = new System.Drawing.Point(4, 37);
            this.tabMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabMenu.Size = new System.Drawing.Size(1234, 717);
            this.tabMenu.TabIndex = 0;
            this.tabMenu.Text = "Thực đơn";
            this.tabMenu.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(28, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1165, 631);
            this.panel2.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(183, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(982, 628);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(177, 631);
            this.panel3.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 115);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(177, 50);
            this.button3.TabIndex = 5;
            this.button3.Text = "Combo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 50);
            this.button2.TabIndex = 4;
            this.button2.Text = "Món ăn";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Tất cả";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Roboto Th", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(-14, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(0, 0);
            this.button4.TabIndex = 3;
            this.button4.Text = "Tất cả";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // tabCart
            // 
            this.tabCart.BackgroundImage = global::McDonalds.Properties.Resources.istockphoto_1176097155_612x612;
            this.tabCart.Controls.Add(this.panel1);
            this.tabCart.Font = new System.Drawing.Font("Roboto Th", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCart.Location = new System.Drawing.Point(4, 37);
            this.tabCart.Name = "tabCart";
            this.tabCart.Padding = new System.Windows.Forms.Padding(3);
            this.tabCart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabCart.Size = new System.Drawing.Size(1234, 717);
            this.tabCart.TabIndex = 3;
            this.tabCart.Text = "Giỏ hàng";
            this.tabCart.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.bttnOrder);
            this.panel1.Location = new System.Drawing.Point(28, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(946, 685);
            this.panel1.TabIndex = 5;
            // 
            // bttnOrder
            // 
            this.bttnOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnOrder.BackColor = System.Drawing.Color.DarkOrange;
            this.bttnOrder.FlatAppearance.BorderSize = 0;
            this.bttnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnOrder.Font = new System.Drawing.Font("Roboto Th", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnOrder.Location = new System.Drawing.Point(572, 607);
            this.bttnOrder.Name = "bttnOrder";
            this.bttnOrder.Size = new System.Drawing.Size(128, 49);
            this.bttnOrder.TabIndex = 0;
            this.bttnOrder.Text = "Đặt hàng";
            this.bttnOrder.UseVisualStyleBackColor = false;
            // 
            // tabProfile
            // 
            this.tabProfile.BackgroundImage = global::McDonalds.Properties.Resources.istockphoto_1182393436_612x612;
            this.tabProfile.Controls.Add(this.panel5);
            this.tabProfile.Font = new System.Drawing.Font("Roboto Th", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabProfile.Location = new System.Drawing.Point(4, 37);
            this.tabProfile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabProfile.Name = "tabProfile";
            this.tabProfile.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabProfile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabProfile.Size = new System.Drawing.Size(1234, 717);
            this.tabProfile.TabIndex = 4;
            this.tabProfile.Text = "Thông tin";
            this.tabProfile.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel5.BackColor = System.Drawing.Color.Firebrick;
            this.panel5.Controls.Add(this.bttnSignOut);
            this.panel5.Controls.Add(this.bttnChangePassword);
            this.panel5.Controls.Add(this.textBox1);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.bttnSave);
            this.panel5.Controls.Add(this.dtpBirthday);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.tbRePassword);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.rbttnFemale);
            this.panel5.Controls.Add(this.rbttnMale);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.tbAddress);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.tbName);
            this.panel5.Controls.Add(this.tbEmail);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.tbPhone);
            this.panel5.Location = new System.Drawing.Point(216, 25);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(801, 660);
            this.panel5.TabIndex = 4;
            // 
            // bttnSignOut
            // 
            this.bttnSignOut.BackColor = System.Drawing.Color.DarkGray;
            this.bttnSignOut.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnSignOut.Location = new System.Drawing.Point(231, 600);
            this.bttnSignOut.Name = "bttnSignOut";
            this.bttnSignOut.Size = new System.Drawing.Size(129, 45);
            this.bttnSignOut.TabIndex = 50;
            this.bttnSignOut.Text = "Đăng xuất";
            this.bttnSignOut.UseVisualStyleBackColor = false;
            // 
            // bttnChangePassword
            // 
            this.bttnChangePassword.BackColor = System.Drawing.Color.Tan;
            this.bttnChangePassword.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnChangePassword.Location = new System.Drawing.Point(29, 600);
            this.bttnChangePassword.Name = "bttnChangePassword";
            this.bttnChangePassword.Size = new System.Drawing.Size(196, 45);
            this.bttnChangePassword.TabIndex = 49;
            this.bttnChangePassword.Text = "Đổi mật khẩu";
            this.bttnChangePassword.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(515, 121);
            this.textBox1.Margin = new System.Windows.Forms.Padding(15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 30);
            this.textBox1.TabIndex = 48;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Roboto Th", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(511, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 25);
            this.label11.TabIndex = 47;
            this.label11.Text = "Tên";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Roboto Th", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(307, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 25);
            this.label10.TabIndex = 46;
            this.label10.Text = "Họ";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Th", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 37);
            this.label3.TabIndex = 45;
            this.label3.Text = "Thông tin cá nhân";
            // 
            // bttnSave
            // 
            this.bttnSave.BackColor = System.Drawing.Color.Tan;
            this.bttnSave.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnSave.Location = new System.Drawing.Point(655, 600);
            this.bttnSave.Name = "bttnSave";
            this.bttnSave.Size = new System.Drawing.Size(129, 45);
            this.bttnSave.TabIndex = 44;
            this.bttnSave.Text = "Lưu";
            this.bttnSave.UseVisualStyleBackColor = false;
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dtpBirthday.CalendarFont = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthday.Font = new System.Drawing.Font("Roboto Th", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthday.Location = new System.Drawing.Point(311, 298);
            this.dtpBirthday.Margin = new System.Windows.Forms.Padding(15);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(361, 32);
            this.dtpBirthday.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto Th", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gold;
            this.label9.Location = new System.Drawing.Point(29, 531);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(306, 25);
            this.label9.TabIndex = 42;
            this.label9.Text = "Nhập mật khẩu để lưu thay đổi";
            // 
            // tbRePassword
            // 
            this.tbRePassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tbRePassword.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbRePassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbRePassword.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRePassword.ForeColor = System.Drawing.Color.Black;
            this.tbRePassword.Location = new System.Drawing.Point(310, 527);
            this.tbRePassword.Margin = new System.Windows.Forms.Padding(15);
            this.tbRePassword.Name = "tbRePassword";
            this.tbRePassword.PasswordChar = '.';
            this.tbRePassword.Size = new System.Drawing.Size(361, 30);
            this.tbRePassword.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto Th", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gold;
            this.label8.Location = new System.Drawing.Point(165, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 25);
            this.label8.TabIndex = 40;
            this.label8.Text = "Giới tính";
            // 
            // rbttnFemale
            // 
            this.rbttnFemale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rbttnFemale.AutoSize = true;
            this.rbttnFemale.Font = new System.Drawing.Font("Roboto Th", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbttnFemale.ForeColor = System.Drawing.Color.LightGray;
            this.rbttnFemale.Location = new System.Drawing.Point(511, 241);
            this.rbttnFemale.Margin = new System.Windows.Forms.Padding(15);
            this.rbttnFemale.Name = "rbttnFemale";
            this.rbttnFemale.Size = new System.Drawing.Size(60, 29);
            this.rbttnFemale.TabIndex = 39;
            this.rbttnFemale.TabStop = true;
            this.rbttnFemale.Text = "Nữ";
            this.rbttnFemale.UseVisualStyleBackColor = true;
            // 
            // rbttnMale
            // 
            this.rbttnMale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rbttnMale.AutoSize = true;
            this.rbttnMale.Font = new System.Drawing.Font("Roboto Th", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbttnMale.ForeColor = System.Drawing.Color.LightGray;
            this.rbttnMale.Location = new System.Drawing.Point(311, 241);
            this.rbttnMale.Margin = new System.Windows.Forms.Padding(15);
            this.rbttnMale.Name = "rbttnMale";
            this.rbttnMale.Size = new System.Drawing.Size(79, 29);
            this.rbttnMale.TabIndex = 38;
            this.rbttnMale.TabStop = true;
            this.rbttnMale.Text = "Nam";
            this.rbttnMale.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto Th", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(165, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 25);
            this.label6.TabIndex = 37;
            this.label6.Text = "Ngày sinh";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto Th", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gold;
            this.label7.Location = new System.Drawing.Point(165, 421);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 25);
            this.label7.TabIndex = 36;
            this.label7.Text = "Địa chỉ";
            // 
            // tbAddress
            // 
            this.tbAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tbAddress.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAddress.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddress.ForeColor = System.Drawing.Color.Black;
            this.tbAddress.Location = new System.Drawing.Point(310, 417);
            this.tbAddress.Margin = new System.Windows.Forms.Padding(15);
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(361, 57);
            this.tbAddress.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Th", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(165, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 34;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Th", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(165, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 25);
            this.label5.TabIndex = 33;
            this.label5.Text = "Họ và tên";
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tbName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbName.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.ForeColor = System.Drawing.Color.Black;
            this.tbName.Location = new System.Drawing.Point(310, 121);
            this.tbName.Margin = new System.Windows.Forms.Padding(15);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(197, 30);
            this.tbName.TabIndex = 31;
            // 
            // tbEmail
            // 
            this.tbEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tbEmail.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEmail.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.ForeColor = System.Drawing.Color.Black;
            this.tbEmail.Location = new System.Drawing.Point(310, 357);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(15);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.PasswordChar = '.';
            this.tbEmail.Size = new System.Drawing.Size(361, 30);
            this.tbEmail.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Th", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(165, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "Số điện thoại";
            // 
            // tbPhone
            // 
            this.tbPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tbPhone.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPhone.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhone.ForeColor = System.Drawing.Color.Black;
            this.tbPhone.Location = new System.Drawing.Point(310, 181);
            this.tbPhone.Margin = new System.Windows.Forms.Padding(15);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(361, 30);
            this.tbPhone.TabIndex = 27;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 758);
            this.Controls.Add(this.mainPanel);
            this.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "McDonalds";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.mainPanel.ResumeLayout(false);
            this.tabMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tabCart.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabProfile.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabCart;
        private System.Windows.Forms.TabPage tabMenu;
        private System.Windows.Forms.TabPage tabProfile;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bttnSave;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbRePassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rbttnFemale;
        private System.Windows.Forms.RadioButton rbttnMale;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button bttnChangePassword;
        private System.Windows.Forms.Button bttnSignOut;
        private System.Windows.Forms.Button bttnOrder;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public System.Windows.Forms.TabControl mainPanel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}