namespace RestaurantIS
{
    partial class fUpdateAccount
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
            panel1 = new Panel();
            txbUsername = new TextBox();
            label1 = new Label();
            panel3 = new Panel();
            txbNewPassword = new TextBox();
            label3 = new Label();
            panel4 = new Panel();
            txbReEnterPassword = new TextBox();
            label4 = new Label();
            confirmBtn = new Button();
            BackBtn = new Button();
            panel5 = new Panel();
            txbOldPassword = new TextBox();
            label5 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txbUsername);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 66);
            panel1.TabIndex = 0;
            // 
            // txbUsername
            // 
            txbUsername.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txbUsername.Location = new Point(324, 13);
            txbUsername.Name = "txbUsername";
            txbUsername.Size = new Size(402, 38);
            txbUsername.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(64, 16);
            label1.Name = "label1";
            label1.Size = new Size(127, 31);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // panel3
            // 
            panel3.Controls.Add(txbNewPassword);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(0, 148);
            panel3.Name = "panel3";
            panel3.Size = new Size(799, 66);
            panel3.TabIndex = 2;
            // 
            // txbNewPassword
            // 
            txbNewPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txbNewPassword.Location = new Point(324, 13);
            txbNewPassword.Name = "txbNewPassword";
            txbNewPassword.Size = new Size(402, 38);
            txbNewPassword.TabIndex = 2;
            txbNewPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(64, 16);
            label3.Name = "label3";
            label3.Size = new Size(174, 31);
            label3.TabIndex = 2;
            label3.Text = "New Password:";
            // 
            // panel4
            // 
            panel4.Controls.Add(txbReEnterPassword);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(0, 220);
            panel4.Name = "panel4";
            panel4.Size = new Size(799, 66);
            panel4.TabIndex = 3;
            // 
            // txbReEnterPassword
            // 
            txbReEnterPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txbReEnterPassword.Location = new Point(324, 13);
            txbReEnterPassword.Name = "txbReEnterPassword";
            txbReEnterPassword.Size = new Size(402, 38);
            txbReEnterPassword.TabIndex = 3;
            txbReEnterPassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(64, 16);
            label4.Name = "label4";
            label4.Size = new Size(217, 31);
            label4.TabIndex = 3;
            label4.Text = "Re-Enter Password:";
            // 
            // confirmBtn
            // 
            confirmBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            confirmBtn.Location = new Point(221, 311);
            confirmBtn.Name = "confirmBtn";
            confirmBtn.Size = new Size(167, 49);
            confirmBtn.TabIndex = 4;
            confirmBtn.Text = "Confirm";
            confirmBtn.UseVisualStyleBackColor = true;
            confirmBtn.Click += confirmBtn_Click;
            // 
            // BackBtn
            // 
            BackBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            BackBtn.Location = new Point(394, 311);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(167, 49);
            BackBtn.TabIndex = 5;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(txbOldPassword);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(0, 76);
            panel5.Name = "panel5";
            panel5.Size = new Size(799, 66);
            panel5.TabIndex = 1;
            // 
            // txbOldPassword
            // 
            txbOldPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txbOldPassword.Location = new Point(324, 13);
            txbOldPassword.Name = "txbOldPassword";
            txbOldPassword.Size = new Size(402, 38);
            txbOldPassword.TabIndex = 1;
            txbOldPassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(64, 16);
            label5.Name = "label5";
            label5.Size = new Size(164, 31);
            label5.TabIndex = 1;
            label5.Text = "Old Password:";
            // 
            // fUpdateAccount
            // 
            AcceptButton = confirmBtn;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = BackBtn;
            ClientSize = new Size(800, 374);
            Controls.Add(panel5);
            Controls.Add(BackBtn);
            Controls.Add(confirmBtn);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "fUpdateAccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Update Account";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txbUsername;
        private Label label1;
        private Panel panel3;
        private TextBox txbNewPassword;
        private Label label3;
        private Panel panel4;
        private TextBox txbReEnterPassword;
        private Label label4;
        private Button confirmBtn;
        private Button BackBtn;
        private Panel panel5;
        private TextBox txbOldPassword;
        private Label label5;
    }
}