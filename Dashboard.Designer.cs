namespace ACT_1A_DATABASE
{
    partial class Dashboard
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
            btnRegister = new Button();
            btnStudent = new Button();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.BackColor = SystemColors.ActiveBorder;
            btnRegister.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnRegister.Location = new Point(146, 181);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(227, 74);
            btnRegister.TabIndex = 0;
            btnRegister.Text = "REGISTER STUDENT";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnStudent
            // 
            btnStudent.BackColor = SystemColors.ActiveBorder;
            btnStudent.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnStudent.Location = new Point(448, 181);
            btnStudent.Name = "btnStudent";
            btnStudent.Size = new Size(218, 74);
            btnStudent.TabIndex = 1;
            btnStudent.Text = "STUDENT LIST";
            btnStudent.UseVisualStyleBackColor = false;
            btnStudent.Click += btnStudent_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnStudent);
            Controls.Add(btnRegister);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnRegister;
        private Button btnStudent;
    }
}