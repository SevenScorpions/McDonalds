namespace LogInDemo
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.tbPassWord = new System.Windows.Forms.TextBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.logInBttn = new System.Windows.Forms.Button();
            this.signUpBttn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.exitBttn = new System.Windows.Forms.Button();
            this.fgBttn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // tbPassWord
            // 
            this.tbPassWord.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPassWord.Location = new System.Drawing.Point(137, 147);
            this.tbPassWord.Name = "tbPassWord";
            this.tbPassWord.PasswordChar = '*';
            this.tbPassWord.Size = new System.Drawing.Size(313, 36);
            this.tbPassWord.TabIndex = 1;
            // 
            // tbUserName
            // 
            this.tbUserName.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbUserName.Location = new System.Drawing.Point(137, 101);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(313, 36);
            this.tbUserName.TabIndex = 0;
            this.tbUserName.TextChanged += new System.EventHandler(this.tbUserName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(46, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(46, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // logInBttn
            // 
            this.logInBttn.BackColor = System.Drawing.Color.Crimson;
            this.logInBttn.FlatAppearance.BorderSize = 0;
            this.logInBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logInBttn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.logInBttn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.logInBttn.Location = new System.Drawing.Point(286, 189);
            this.logInBttn.Name = "logInBttn";
            this.logInBttn.Size = new System.Drawing.Size(164, 49);
            this.logInBttn.TabIndex = 2;
            this.logInBttn.Text = "Log in";
            this.logInBttn.UseVisualStyleBackColor = false;
            this.logInBttn.Click += new System.EventHandler(this.button1_Click);
            // 
            // signUpBttn
            // 
            this.signUpBttn.BackColor = System.Drawing.Color.Crimson;
            this.signUpBttn.FlatAppearance.BorderSize = 0;
            this.signUpBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signUpBttn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.signUpBttn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.signUpBttn.Location = new System.Drawing.Point(258, 357);
            this.signUpBttn.Name = "signUpBttn";
            this.signUpBttn.Size = new System.Drawing.Size(109, 29);
            this.signUpBttn.TabIndex = 4;
            this.signUpBttn.Text = "Sign up";
            this.signUpBttn.UseVisualStyleBackColor = false;
            this.signUpBttn.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(47, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Don\'t Have Account?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(37, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 39);
            this.label4.TabIndex = 8;
            this.label4.Text = "Log In First";
            // 
            // exitBttn
            // 
            this.exitBttn.BackColor = System.Drawing.Color.Crimson;
            this.exitBttn.FlatAppearance.BorderSize = 0;
            this.exitBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBttn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitBttn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exitBttn.Location = new System.Drawing.Point(740, 361);
            this.exitBttn.Name = "exitBttn";
            this.exitBttn.Size = new System.Drawing.Size(109, 29);
            this.exitBttn.TabIndex = 5;
            this.exitBttn.Text = "Exit";
            this.exitBttn.UseVisualStyleBackColor = false;
            this.exitBttn.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // fgBttn
            // 
            this.fgBttn.BackColor = System.Drawing.Color.White;
            this.fgBttn.FlatAppearance.BorderSize = 0;
            this.fgBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fgBttn.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.fgBttn.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.fgBttn.Location = new System.Drawing.Point(37, 329);
            this.fgBttn.Name = "fgBttn";
            this.fgBttn.Size = new System.Drawing.Size(153, 29);
            this.fgBttn.TabIndex = 3;
            this.fgBttn.Text = "Forgot Password?";
            this.fgBttn.UseVisualStyleBackColor = false;
            this.fgBttn.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::LogInDemo.Properties.Resources.download__3_;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(723, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(137, 147);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // frmLogin
            // 
            this.AcceptButton = this.logInBttn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.exitBttn;
            this.ClientSize = new System.Drawing.Size(872, 412);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.exitBttn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fgBttn);
            this.Controls.Add(this.signUpBttn);
            this.Controls.Add(this.logInBttn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.tbPassWord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbPassWord;
        private TextBox tbUserName;
        private Label label1;
        private Label label2;
        private Button logInBttn;
        private Button signUpBttn;
        private Label label3;
        private Label label4;
        private Button exitBttn;
        private Button fgBttn;
        private Panel panel1;
    }
}