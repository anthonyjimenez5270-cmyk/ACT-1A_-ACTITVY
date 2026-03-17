namespace ACT_1A_DATABASE
{
    partial class Login
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
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            lblUser = new Label();
            lblPassword = new Label();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(109, 43);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(214, 23);
            txtUsername.TabIndex = 0;
            txtUsername.TextChanged += textBox1_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(109, 72);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(214, 23);
            txtPassword.TabIndex = 1;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblUser.Location = new Point(12, 41);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(91, 21);
            lblUser.TabIndex = 2;
            lblUser.Text = "Username:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPassword.Location = new Point(17, 74);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(86, 21);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password:";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ActiveBorder;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLogin.Location = new Point(109, 110);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(214, 48);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(354, 183);
            Controls.Add(btnLogin);
            Controls.Add(lblPassword);
            Controls.Add(lblUser);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label lblUser;
        private Label lblPassword;
        private Button btnLogin;
    }
}