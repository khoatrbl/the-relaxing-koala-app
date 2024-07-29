namespace RestaurantIS
{
    partial class fCashPayment
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
            txbAmountGiven = new TextBox();
            label1 = new Label();
            paymentConfirmBtn = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txbAmountGiven);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(453, 62);
            panel1.TabIndex = 0;
            // 
            // txbAmountGiven
            // 
            txbAmountGiven.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txbAmountGiven.Location = new Point(220, 9);
            txbAmountGiven.Name = "txbAmountGiven";
            txbAmountGiven.Size = new Size(225, 38);
            txbAmountGiven.TabIndex = 1;
            txbAmountGiven.Text = "0";
            txbAmountGiven.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(26, 12);
            label1.Name = "label1";
            label1.Size = new Size(175, 31);
            label1.TabIndex = 0;
            label1.Text = "Amount Given:";
            // 
            // paymentConfirmBtn
            // 
            paymentConfirmBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            paymentConfirmBtn.Location = new Point(160, 98);
            paymentConfirmBtn.Name = "paymentConfirmBtn";
            paymentConfirmBtn.Size = new Size(140, 45);
            paymentConfirmBtn.TabIndex = 2;
            paymentConfirmBtn.Text = "Confirm";
            paymentConfirmBtn.UseVisualStyleBackColor = true;
            paymentConfirmBtn.Click += paymentConfirmBtn_Click;
            // 
            // fCashPayment
            // 
            AcceptButton = paymentConfirmBtn;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 155);
            Controls.Add(paymentConfirmBtn);
            Controls.Add(panel1);
            Name = "fCashPayment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Payment";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txbAmountGiven;
        private Label label1;
        private Button paymentConfirmBtn;
    }
}