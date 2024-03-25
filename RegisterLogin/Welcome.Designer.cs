namespace RegisterLogin
{
    partial class Welcome
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
            lblWelcomeUser = new Label();
            SuspendLayout();
            // 
            // lblWelcomeUser
            // 
            lblWelcomeUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblWelcomeUser.AutoSize = true;
            lblWelcomeUser.Font = new Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcomeUser.ForeColor = Color.DodgerBlue;
            lblWelcomeUser.Location = new Point(128, 131);
            lblWelcomeUser.Name = "lblWelcomeUser";
            lblWelcomeUser.Size = new Size(169, 25);
            lblWelcomeUser.TabIndex = 1;
            lblWelcomeUser.Text = "Welcome User";
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 375);
            Controls.Add(lblWelcomeUser);
            Name = "Welcome";
            Text = "Welcome";
            FormClosed += Welcome_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcomeUser;
    }
}