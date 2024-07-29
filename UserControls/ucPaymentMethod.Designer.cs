namespace RestaurantIS
{
    partial class ucPaymentMethod
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ptbPaymentMethod = new PictureBox();
            paymentMethodDisplay = new Label();
            ((System.ComponentModel.ISupportInitialize)ptbPaymentMethod).BeginInit();
            SuspendLayout();
            // 
            // ptbPaymentMethod
            // 
            ptbPaymentMethod.Image = Properties.Resources.credit_card;
            ptbPaymentMethod.Location = new Point(16, -3);
            ptbPaymentMethod.Name = "ptbPaymentMethod";
            ptbPaymentMethod.Size = new Size(135, 114);
            ptbPaymentMethod.SizeMode = PictureBoxSizeMode.Zoom;
            ptbPaymentMethod.TabIndex = 0;
            ptbPaymentMethod.TabStop = false;
            // 
            // paymentMethodDisplay
            // 
            paymentMethodDisplay.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            paymentMethodDisplay.Location = new Point(49, 114);
            paymentMethodDisplay.Name = "paymentMethodDisplay";
            paymentMethodDisplay.Size = new Size(67, 44);
            paymentMethodDisplay.TabIndex = 0;
            paymentMethodDisplay.Text = "Method";
            paymentMethodDisplay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ucPaymentMethod
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            Controls.Add(ptbPaymentMethod);
            Controls.Add(paymentMethodDisplay);
            Name = "ucPaymentMethod";
            Size = new Size(165, 187);
            ((System.ComponentModel.ISupportInitialize)ptbPaymentMethod).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox ptbPaymentMethod;
        private Label paymentMethodDisplay;
    }
}
