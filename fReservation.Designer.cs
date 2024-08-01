namespace RestaurantIS
{
    partial class fReservation
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
            panel5 = new Panel();
            txbReservationName = new TextBox();
            label5 = new Label();
            BackBtn = new Button();
            confirmBtn = new Button();
            panel1 = new Panel();
            txbReservationPhone = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            txbReservationTime = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            dtpkReservationDate = new DateTimePicker();
            label3 = new Label();
            panel4 = new Panel();
            txbReservationEmail = new TextBox();
            label4 = new Label();
            panel6 = new Panel();
            label6 = new Label();
            numericNumberOfSeats = new NumericUpDown();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericNumberOfSeats).BeginInit();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.Controls.Add(txbReservationName);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(0, 12);
            panel5.Name = "panel5";
            panel5.Size = new Size(400, 55);
            panel5.TabIndex = 0;
            // 
            // txbReservationName
            // 
            txbReservationName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txbReservationName.Location = new Point(139, 9);
            txbReservationName.Name = "txbReservationName";
            txbReservationName.Size = new Size(254, 38);
            txbReservationName.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(41, 16);
            label5.Name = "label5";
            label5.Size = new Size(83, 31);
            label5.TabIndex = 1;
            label5.Text = "Name:";
            // 
            // BackBtn
            // 
            BackBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            BackBtn.Location = new Point(399, 219);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(167, 49);
            BackBtn.TabIndex = 10;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // confirmBtn
            // 
            confirmBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            confirmBtn.Location = new Point(226, 219);
            confirmBtn.Name = "confirmBtn";
            confirmBtn.Size = new Size(167, 49);
            confirmBtn.TabIndex = 9;
            confirmBtn.Text = "Confirm";
            confirmBtn.UseVisualStyleBackColor = true;
            confirmBtn.Click += confirmBtn_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(txbReservationPhone);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(399, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 55);
            panel1.TabIndex = 1;
            // 
            // txbReservationPhone
            // 
            txbReservationPhone.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txbReservationPhone.Location = new Point(121, 9);
            txbReservationPhone.Name = "txbReservationPhone";
            txbReservationPhone.Size = new Size(245, 38);
            txbReservationPhone.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(23, 16);
            label1.Name = "label1";
            label1.Size = new Size(88, 31);
            label1.TabIndex = 1;
            label1.Text = "Phone:";
            // 
            // panel2
            // 
            panel2.Controls.Add(txbReservationTime);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(399, 73);
            panel2.Name = "panel2";
            panel2.Size = new Size(400, 55);
            panel2.TabIndex = 3;
            // 
            // txbReservationTime
            // 
            txbReservationTime.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txbReservationTime.Location = new Point(121, 9);
            txbReservationTime.Name = "txbReservationTime";
            txbReservationTime.Size = new Size(245, 38);
            txbReservationTime.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(23, 16);
            label2.Name = "label2";
            label2.Size = new Size(73, 31);
            label2.TabIndex = 1;
            label2.Text = "Time:";
            // 
            // panel3
            // 
            panel3.Controls.Add(dtpkReservationDate);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(0, 73);
            panel3.Name = "panel3";
            panel3.Size = new Size(400, 55);
            panel3.TabIndex = 2;
            // 
            // dtpkReservationDate
            // 
            dtpkReservationDate.Location = new Point(139, 20);
            dtpkReservationDate.Name = "dtpkReservationDate";
            dtpkReservationDate.Size = new Size(254, 27);
            dtpkReservationDate.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(41, 16);
            label3.Name = "label3";
            label3.Size = new Size(70, 31);
            label3.TabIndex = 1;
            label3.Text = "Date:";
            // 
            // panel4
            // 
            panel4.Controls.Add(txbReservationEmail);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(399, 134);
            panel4.Name = "panel4";
            panel4.Size = new Size(400, 55);
            panel4.TabIndex = 5;
            // 
            // txbReservationEmail
            // 
            txbReservationEmail.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txbReservationEmail.Location = new Point(121, 9);
            txbReservationEmail.Name = "txbReservationEmail";
            txbReservationEmail.Size = new Size(245, 38);
            txbReservationEmail.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(23, 16);
            label4.Name = "label4";
            label4.Size = new Size(79, 31);
            label4.TabIndex = 1;
            label4.Text = "Email:";
            // 
            // panel6
            // 
            panel6.Controls.Add(numericNumberOfSeats);
            panel6.Controls.Add(label6);
            panel6.Location = new Point(0, 134);
            panel6.Name = "panel6";
            panel6.Size = new Size(400, 55);
            panel6.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(41, 16);
            label6.Name = "label6";
            label6.Size = new Size(76, 31);
            label6.TabIndex = 1;
            label6.Text = "Seats:";
            // 
            // numericNumberOfSeats
            // 
            numericNumberOfSeats.Location = new Point(139, 16);
            numericNumberOfSeats.Name = "numericNumberOfSeats";
            numericNumberOfSeats.Size = new Size(254, 27);
            numericNumberOfSeats.TabIndex = 2;
            // 
            // fReservation
            // 
            AcceptButton = confirmBtn;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = BackBtn;
            ClientSize = new Size(800, 288);
            Controls.Add(panel4);
            Controls.Add(panel6);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel5);
            Controls.Add(BackBtn);
            Controls.Add(confirmBtn);
            Name = "fReservation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reservation";
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericNumberOfSeats).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel5;
        private TextBox txbReservationName;
        private Label label5;
        private Button BackBtn;
        private Button confirmBtn;
        private Panel panel1;
        private TextBox txbReservationPhone;
        private Label label1;
        private Panel panel2;
        private TextBox txbReservationTime;
        private Label label2;
        private Panel panel3;
        private DateTimePicker dtpkReservationDate;
        private Label label3;
        private Panel panel4;
        private TextBox txbReservationEmail;
        private Label label4;
        private Panel panel6;
        private Label label6;
        private NumericUpDown numericNumberOfSeats;
    }
}