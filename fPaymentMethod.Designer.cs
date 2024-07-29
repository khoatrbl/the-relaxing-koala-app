namespace RestaurantIS
{
    partial class fPaymentMethod
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
            flpPaymentMethod = new FlowLayoutPanel();
            panel2 = new Panel();
            txbTotalAmoutDisplay = new TextBox();
            label1 = new Label();
            panel3 = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(flpPaymentMethod);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(798, 446);
            panel1.TabIndex = 0;
            // 
            // flpPaymentMethod
            // 
            flpPaymentMethod.Location = new Point(225, 221);
            flpPaymentMethod.Name = "flpPaymentMethod";
            flpPaymentMethod.Size = new Size(364, 215);
            flpPaymentMethod.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.Controls.Add(txbTotalAmoutDisplay);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(175, 112);
            panel2.Name = "panel2";
            panel2.Size = new Size(439, 53);
            panel2.TabIndex = 4;
            // 
            // txbTotalAmoutDisplay
            // 
            txbTotalAmoutDisplay.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            txbTotalAmoutDisplay.Location = new Point(117, 4);
            txbTotalAmoutDisplay.Name = "txbTotalAmoutDisplay";
            txbTotalAmoutDisplay.ReadOnly = true;
            txbTotalAmoutDisplay.Size = new Size(310, 43);
            txbTotalAmoutDisplay.TabIndex = 3;
            txbTotalAmoutDisplay.TabStop = false;
            txbTotalAmoutDisplay.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(28, 14);
            label1.Name = "label1";
            label1.Size = new Size(64, 28);
            label1.TabIndex = 2;
            label1.Text = "Total:";
            // 
            // panel3
            // 
            panel3.Controls.Add(label2);
            panel3.Location = new Point(0, 34);
            panel3.Name = "panel3";
            panel3.Size = new Size(798, 56);
            panel3.TabIndex = 3;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(798, 56);
            label2.TabIndex = 4;
            label2.Text = "CHOOSE A PAYMENT METHOD";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // fPaymentMethod
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "fPaymentMethod";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Payment";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox txbTotalAmoutDisplay;
        private Label label1;
        private Panel panel3;
        private Label label2;
        private FlowLayoutPanel flpPaymentMethod;
    }
}