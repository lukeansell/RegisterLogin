namespace RegisterLogin
{
    partial class Form1
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pnlWelcome = new Panel();
            btnStart = new Button();
            lblWelcome = new Label();
            pnlLogin = new Panel();
            lblLoginStatus = new Label();
            label4 = new Label();
            label3 = new Label();
            btnLogin = new Button();
            btnRegister = new Button();
            txtLoginPassword = new TextBox();
            txtLoginUser = new TextBox();
            label1 = new Label();
            label2 = new Label();
            pnlRegister = new Panel();
            lblRegisterStatus = new Label();
            label6 = new Label();
            btnEnter = new Button();
            txtRegisterPassword = new TextBox();
            txtUserRegister = new TextBox();
            label7 = new Label();
            label8 = new Label();
            pnlLoggedIn = new Panel();
            lblWelcomeUser = new Label();
            pnlWelcome.SuspendLayout();
            pnlLogin.SuspendLayout();
            pnlRegister.SuspendLayout();
            pnlLoggedIn.SuspendLayout();
            SuspendLayout();
            // 
            // pnlWelcome
            // 
            pnlWelcome.Controls.Add(btnStart);
            pnlWelcome.Controls.Add(lblWelcome);
            pnlWelcome.Location = new Point(12, 12);
            pnlWelcome.Name = "pnlWelcome";
            pnlWelcome.Size = new Size(315, 231);
            pnlWelcome.TabIndex = 0;
            // 
            // btnStart
            // 
            btnStart.ForeColor = SystemColors.Desktop;
            btnStart.Location = new Point(112, 103);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(87, 35);
            btnStart.TabIndex = 1;
            btnStart.Text = "Get Started";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += button1_Click_1;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Georgia", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.DodgerBlue;
            lblWelcome.Location = new Point(86, 64);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(141, 31);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome";
            lblWelcome.Click += lblWelcome_Click;
            // 
            // pnlLogin
            // 
            pnlLogin.Controls.Add(lblLoginStatus);
            pnlLogin.Controls.Add(label4);
            pnlLogin.Controls.Add(label3);
            pnlLogin.Controls.Add(btnLogin);
            pnlLogin.Controls.Add(btnRegister);
            pnlLogin.Controls.Add(txtLoginPassword);
            pnlLogin.Controls.Add(txtLoginUser);
            pnlLogin.Controls.Add(label1);
            pnlLogin.Controls.Add(label2);
            pnlLogin.Location = new Point(339, 12);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(315, 231);
            pnlLogin.TabIndex = 1;
            pnlLogin.Paint += pnlLogin_Paint;
            // 
            // lblLoginStatus
            // 
            lblLoginStatus.AutoSize = true;
            lblLoginStatus.Location = new Point(110, 174);
            lblLoginStatus.Name = "lblLoginStatus";
            lblLoginStatus.Size = new Size(94, 15);
            lblLoginStatus.TabIndex = 8;
            lblLoginStatus.Text = "Login successful";
            lblLoginStatus.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(100, 212);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 7;
            label4.Text = "No account?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DodgerBlue;
            label3.Location = new Point(44, 30);
            label3.Name = "label3";
            label3.Size = new Size(73, 25);
            label3.TabIndex = 6;
            label3.Text = "Login";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(119, 148);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(188, 204);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(75, 23);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtLoginPassword
            // 
            txtLoginPassword.Location = new Point(163, 103);
            txtLoginPassword.Name = "txtLoginPassword";
            txtLoginPassword.Size = new Size(100, 23);
            txtLoginPassword.TabIndex = 3;
            txtLoginPassword.UseSystemPasswordChar = true;
            // 
            // txtLoginUser
            // 
            txtLoginUser.Location = new Point(163, 69);
            txtLoginUser.Name = "txtLoginUser";
            txtLoginUser.Size = new Size(100, 23);
            txtLoginUser.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 111);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 1;
            label1.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 77);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 0;
            label2.Text = "Username";
            // 
            // pnlRegister
            // 
            pnlRegister.Controls.Add(lblRegisterStatus);
            pnlRegister.Controls.Add(label6);
            pnlRegister.Controls.Add(btnEnter);
            pnlRegister.Controls.Add(txtRegisterPassword);
            pnlRegister.Controls.Add(txtUserRegister);
            pnlRegister.Controls.Add(label7);
            pnlRegister.Controls.Add(label8);
            pnlRegister.Location = new Point(12, 258);
            pnlRegister.Name = "pnlRegister";
            pnlRegister.Size = new Size(315, 231);
            pnlRegister.TabIndex = 2;
            // 
            // lblRegisterStatus
            // 
            lblRegisterStatus.AutoSize = true;
            lblRegisterStatus.Location = new Point(103, 174);
            lblRegisterStatus.Name = "lblRegisterStatus";
            lblRegisterStatus.Size = new Size(106, 15);
            lblRegisterStatus.TabIndex = 7;
            lblRegisterStatus.Text = "Register successful";
            lblRegisterStatus.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DodgerBlue;
            label6.Location = new Point(44, 30);
            label6.Name = "label6";
            label6.Size = new Size(102, 25);
            label6.TabIndex = 6;
            label6.Text = "Register";
            // 
            // btnEnter
            // 
            btnEnter.Location = new Point(119, 148);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(75, 23);
            btnEnter.TabIndex = 4;
            btnEnter.Text = "Register";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // txtRegisterPassword
            // 
            txtRegisterPassword.Location = new Point(163, 103);
            txtRegisterPassword.Name = "txtRegisterPassword";
            txtRegisterPassword.Size = new Size(100, 23);
            txtRegisterPassword.TabIndex = 3;
            txtRegisterPassword.UseSystemPasswordChar = true;
            // 
            // txtUserRegister
            // 
            txtUserRegister.Location = new Point(163, 69);
            txtUserRegister.Name = "txtUserRegister";
            txtUserRegister.Size = new Size(100, 23);
            txtUserRegister.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(44, 111);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 1;
            label7.Text = "Password";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(44, 77);
            label8.Name = "label8";
            label8.Size = new Size(60, 15);
            label8.TabIndex = 0;
            label8.Text = "Username";
            // 
            // pnlLoggedIn
            // 
            pnlLoggedIn.Controls.Add(lblWelcomeUser);
            pnlLoggedIn.Location = new Point(339, 258);
            pnlLoggedIn.Name = "pnlLoggedIn";
            pnlLoggedIn.Size = new Size(315, 231);
            pnlLoggedIn.TabIndex = 8;
            // 
            // lblWelcomeUser
            // 
            lblWelcomeUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblWelcomeUser.AutoSize = true;
            lblWelcomeUser.Font = new Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcomeUser.ForeColor = Color.DodgerBlue;
            lblWelcomeUser.Location = new Point(70, 99);
            lblWelcomeUser.Name = "lblWelcomeUser";
            lblWelcomeUser.Size = new Size(169, 25);
            lblWelcomeUser.TabIndex = 0;
            lblWelcomeUser.Text = "Welcome User";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(678, 502);
            Controls.Add(pnlLogin);
            Controls.Add(pnlLoggedIn);
            Controls.Add(pnlRegister);
            Controls.Add(pnlWelcome);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            pnlWelcome.ResumeLayout(false);
            pnlWelcome.PerformLayout();
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            pnlRegister.ResumeLayout(false);
            pnlRegister.PerformLayout();
            pnlLoggedIn.ResumeLayout(false);
            pnlLoggedIn.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel pnlWelcome;
        private Label lblWelcome;
        private Panel pnlLogin;
        private Label label2;
        private Button btnStart;
        private Label label4;
        private Label label3;
        private Button btnLogin;
        private Button btnRegister;
        private TextBox txtLoginPassword;
        private TextBox txtLoginUser;
        private Label label1;
        private Panel pnlRegister;
        private Label label6;
        private Button btnEnter;
        private TextBox txtRegisterPassword;
        private TextBox txtUserRegister;
        private Label label7;
        private Label label8;
        private Label lblLoginStatus;
        private Label lblRegisterStatus;
        private Panel pnlLoggedIn;
        private Label lblWelcomeUser;
    }
}
