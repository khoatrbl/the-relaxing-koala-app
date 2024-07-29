namespace RestaurantIS
{
    partial class fLogin
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
            panel1 = new Panel();
            usernameInput = new TextBox();
            usernameLabel = new Label();
            panel2 = new Panel();
            passwordInput = new TextBox();
            passwordLabel = new Label();
            panel3 = new Panel();
            staffLoginBtn = new Button();
            managerLoginBtn = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(usernameInput);
            panel1.Controls.Add(usernameLabel);
            panel1.Location = new Point(14, 3);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(456, 59);
            panel1.TabIndex = 0;
            // 
            // usernameInput
            // 
            usernameInput.Location = new Point(114, 16);
            usernameInput.Margin = new Padding(3, 4, 3, 4);
            usernameInput.Name = "usernameInput";
            usernameInput.Size = new Size(338, 27);
            usernameInput.TabIndex = 1;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            usernameLabel.Location = new Point(3, 16);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(111, 28);
            usernameLabel.TabIndex = 0;
            usernameLabel.Text = "Username:";
            usernameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(passwordInput);
            panel2.Controls.Add(passwordLabel);
            panel2.Location = new Point(14, 69);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(456, 59);
            panel2.TabIndex = 2;
            // 
            // passwordInput
            // 
            passwordInput.Location = new Point(114, 16);
            passwordInput.Margin = new Padding(3, 4, 3, 4);
            passwordInput.Name = "passwordInput";
            passwordInput.Size = new Size(338, 27);
            passwordInput.TabIndex = 1;
            passwordInput.UseSystemPasswordChar = true;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            passwordLabel.Location = new Point(3, 16);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(106, 28);
            passwordLabel.TabIndex = 0;
            passwordLabel.Text = "Password:";
            passwordLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Controls.Add(staffLoginBtn);
            panel3.Controls.Add(managerLoginBtn);
            panel3.Location = new Point(14, 136);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(456, 44);
            panel3.TabIndex = 3;
            // 
            // staffLoginBtn
            // 
            staffLoginBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            staffLoginBtn.Location = new Point(307, 0);
            staffLoginBtn.Margin = new Padding(3, 4, 3, 4);
            staffLoginBtn.Name = "staffLoginBtn";
            staffLoginBtn.Size = new Size(145, 31);
            staffLoginBtn.TabIndex = 5;
            staffLoginBtn.Text = "Continue as Staff";
            staffLoginBtn.UseVisualStyleBackColor = true;
            staffLoginBtn.Click += staffLoginBtn_Click;
            // 
            // managerLoginBtn
            // 
            managerLoginBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            managerLoginBtn.Location = new Point(155, 0);
            managerLoginBtn.Margin = new Padding(3, 4, 3, 4);
            managerLoginBtn.Name = "managerLoginBtn";
            managerLoginBtn.Size = new Size(145, 31);
            managerLoginBtn.TabIndex = 4;
            managerLoginBtn.Text = "Login as Manager";
            managerLoginBtn.UseVisualStyleBackColor = true;
            managerLoginBtn.Click += managerLoginBtn_Click;
            // 
            // fLogin
            // 
            AcceptButton = managerLoginBtn;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 183);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "fLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            FormClosing += fLogin_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox usernameInput;
        private Label usernameLabel;
        private Panel panel2;
        private TextBox passwordInput;
        private Label passwordLabel;
        private Panel panel3;
        private Button staffLoginBtn;
        private Button managerLoginBtn;
    }
}