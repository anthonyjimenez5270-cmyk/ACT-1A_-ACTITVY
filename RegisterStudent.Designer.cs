namespace ACT_1A_DATABASE
{
    partial class RegisterStudent
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
            lblUser = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtAge = new TextBox();
            btnSave = new Button();
            label5 = new Label();
            cmbCourse = new ComboBox();
            cmbSection = new ComboBox();
            SuspendLayout();
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblUser.Location = new Point(61, 74);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(96, 21);
            lblUser.TabIndex = 3;
            lblUser.Text = "First Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(63, 103);
            label1.Name = "label1";
            label1.Size = new Size(94, 21);
            label1.TabIndex = 4;
            label1.Text = "Last Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(91, 132);
            label2.Name = "label2";
            label2.Size = new Size(66, 21);
            label2.TabIndex = 5;
            label2.Text = "Course:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(86, 161);
            label3.Name = "label3";
            label3.Size = new Size(71, 21);
            label3.TabIndex = 6;
            label3.Text = "Section:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(113, 190);
            label4.Name = "label4";
            label4.Size = new Size(44, 21);
            label4.TabIndex = 7;
            label4.Text = "Age:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(166, 76);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(214, 23);
            txtFirstName.TabIndex = 8;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(166, 105);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(214, 23);
            txtLastName.TabIndex = 9;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(166, 192);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(214, 23);
            txtAge.TabIndex = 12;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.ActiveBorder;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSave.Location = new Point(166, 221);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(214, 57);
            btnSave.TabIndex = 13;
            btnSave.Text = "SAVE RECORD";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(115, 29);
            label5.Name = "label5";
            label5.Size = new Size(275, 21);
            label5.TabIndex = 14;
            label5.Text = "REGISTER STUDENT INFORMATION";
            // 
            // cmbCourse
            // 
            cmbCourse.FormattingEnabled = true;
            cmbCourse.Location = new Point(166, 134);
            cmbCourse.Name = "cmbCourse";
            cmbCourse.Size = new Size(214, 23);
            cmbCourse.TabIndex = 31;
            // 
            // cmbSection
            // 
            cmbSection.FormattingEnabled = true;
            cmbSection.Location = new Point(166, 163);
            cmbSection.Name = "cmbSection";
            cmbSection.Size = new Size(214, 23);
            cmbSection.TabIndex = 32;
            // 
            // RegisterStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 311);
            Controls.Add(cmbSection);
            Controls.Add(cmbCourse);
            Controls.Add(label5);
            Controls.Add(btnSave);
            Controls.Add(txtAge);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblUser);
            Name = "RegisterStudent";
            Text = "RegisterStudent";
            Load += RegisterStudent_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUser;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox txtAge;
        private Button btnSave;
        private Label label5;
        private ComboBox cmbCourse;
        private ComboBox cmbSection;
    }
}