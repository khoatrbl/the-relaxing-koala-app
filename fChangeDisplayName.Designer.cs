namespace RestaurantIS
{
    partial class fChangeDisplayName
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
            txbChangeDisplayName = new TextBox();
            label1 = new Label();
            btnConfirm = new Button();
            btnBack = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txbChangeDisplayName);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(658, 63);
            panel1.TabIndex = 0;
            // 
            // txbChangeDisplayName
            // 
            txbChangeDisplayName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txbChangeDisplayName.Location = new Point(214, 13);
            txbChangeDisplayName.Name = "txbChangeDisplayName";
            txbChangeDisplayName.Size = new Size(321, 38);
            txbChangeDisplayName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(63, 16);
            label1.Name = "label1";
            label1.Size = new Size(145, 31);
            label1.TabIndex = 0;
            label1.Text = "Enter Name:";
            // 
            // btnConfirm
            // 
            btnConfirm.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirm.Location = new Point(169, 93);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(155, 43);
            btnConfirm.TabIndex = 1;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.Location = new Point(330, 93);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(155, 43);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // fChangeDisplayName
            // 
            AcceptButton = btnConfirm;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnBack;
            ClientSize = new Size(686, 150);
            Controls.Add(btnBack);
            Controls.Add(btnConfirm);
            Controls.Add(panel1);
            Name = "fChangeDisplayName";
            Text = "fChangeDisplayName";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txbChangeDisplayName;
        private Label label1;
        private Button btnConfirm;
        private Button btnBack;
    }
}