namespace RestaurantIS
{
    partial class fReservationManagement
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
            dtpkFromDate = new DateTimePicker();
            dtpkToDate = new DateTimePicker();
            dtgvReservationList = new DataGridView();
            panel1 = new Panel();
            btnView = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            panel2 = new Panel();
            panel10 = new Panel();
            txbReservationEmail = new TextBox();
            label8 = new Label();
            panel9 = new Panel();
            txbReservationTableId = new TextBox();
            label7 = new Label();
            panel8 = new Panel();
            numericReservationSeats = new NumericUpDown();
            label6 = new Label();
            panel7 = new Panel();
            txbReservationTime = new TextBox();
            label5 = new Label();
            panel6 = new Panel();
            dtpkReservationDate = new DateTimePicker();
            label4 = new Label();
            panel5 = new Panel();
            txbReservationPhone = new TextBox();
            label3 = new Label();
            panel4 = new Panel();
            txbReservationName = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            txbReservationId = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgvReservationList).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel10.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericReservationSeats).BeginInit();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // dtpkFromDate
            // 
            dtpkFromDate.Location = new Point(12, 14);
            dtpkFromDate.Name = "dtpkFromDate";
            dtpkFromDate.Size = new Size(494, 27);
            dtpkFromDate.TabIndex = 0;
            // 
            // dtpkToDate
            // 
            dtpkToDate.Location = new Point(12, 47);
            dtpkToDate.Name = "dtpkToDate";
            dtpkToDate.Size = new Size(494, 27);
            dtpkToDate.TabIndex = 1;
            // 
            // dtgvReservationList
            // 
            dtgvReservationList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvReservationList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvReservationList.Location = new Point(12, 80);
            dtgvReservationList.Name = "dtgvReservationList";
            dtgvReservationList.RowHeadersWidth = 51;
            dtgvReservationList.RowTemplate.Height = 29;
            dtgvReservationList.Size = new Size(494, 541);
            dtgvReservationList.TabIndex = 3;
            dtgvReservationList.DataBindingComplete += dtgvReservationList_DataBindingComplete;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnView);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnDelete);
            panel1.Location = new Point(521, 14);
            panel1.Name = "panel1";
            panel1.Size = new Size(367, 65);
            panel1.TabIndex = 4;
            // 
            // btnView
            // 
            btnView.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnView.Location = new Point(246, 3);
            btnView.Name = "btnView";
            btnView.Size = new Size(116, 56);
            btnView.TabIndex = 3;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(121, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(119, 56);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(3, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 56);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(panel10);
            panel2.Controls.Add(panel9);
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(521, 80);
            panel2.Name = "panel2";
            panel2.Size = new Size(367, 541);
            panel2.TabIndex = 5;
            // 
            // panel10
            // 
            panel10.Controls.Add(txbReservationEmail);
            panel10.Controls.Add(label8);
            panel10.Location = new Point(3, 471);
            panel10.Name = "panel10";
            panel10.Size = new Size(359, 60);
            panel10.TabIndex = 3;
            // 
            // txbReservationEmail
            // 
            txbReservationEmail.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txbReservationEmail.Location = new Point(103, 16);
            txbReservationEmail.Name = "txbReservationEmail";
            txbReservationEmail.Size = new Size(242, 31);
            txbReservationEmail.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(17, 18);
            label8.Name = "label8";
            label8.Size = new Size(63, 25);
            label8.TabIndex = 0;
            label8.Text = "Email:";
            // 
            // panel9
            // 
            panel9.Controls.Add(txbReservationTableId);
            panel9.Controls.Add(label7);
            panel9.Location = new Point(3, 75);
            panel9.Name = "panel9";
            panel9.Size = new Size(359, 60);
            panel9.TabIndex = 2;
            // 
            // txbReservationTableId
            // 
            txbReservationTableId.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txbReservationTableId.Location = new Point(103, 16);
            txbReservationTableId.Name = "txbReservationTableId";
            txbReservationTableId.ReadOnly = true;
            txbReservationTableId.Size = new Size(242, 31);
            txbReservationTableId.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(17, 18);
            label7.Name = "label7";
            label7.Size = new Size(86, 25);
            label7.TabIndex = 0;
            label7.Text = "Table ID:";
            // 
            // panel8
            // 
            panel8.Controls.Add(numericReservationSeats);
            panel8.Controls.Add(label6);
            panel8.Location = new Point(3, 405);
            panel8.Name = "panel8";
            panel8.Size = new Size(359, 60);
            panel8.TabIndex = 5;
            // 
            // numericReservationSeats
            // 
            numericReservationSeats.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            numericReservationSeats.Location = new Point(103, 16);
            numericReservationSeats.Name = "numericReservationSeats";
            numericReservationSeats.Size = new Size(244, 31);
            numericReservationSeats.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(17, 18);
            label6.Name = "label6";
            label6.Size = new Size(62, 25);
            label6.TabIndex = 0;
            label6.Text = "Seats:";
            // 
            // panel7
            // 
            panel7.Controls.Add(txbReservationTime);
            panel7.Controls.Add(label5);
            panel7.Location = new Point(3, 339);
            panel7.Name = "panel7";
            panel7.Size = new Size(359, 60);
            panel7.TabIndex = 4;
            // 
            // txbReservationTime
            // 
            txbReservationTime.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txbReservationTime.Location = new Point(103, 16);
            txbReservationTime.Name = "txbReservationTime";
            txbReservationTime.Size = new Size(242, 31);
            txbReservationTime.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(17, 18);
            label5.Name = "label5";
            label5.Size = new Size(59, 25);
            label5.TabIndex = 0;
            label5.Text = "Time:";
            // 
            // panel6
            // 
            panel6.Controls.Add(dtpkReservationDate);
            panel6.Controls.Add(label4);
            panel6.Location = new Point(3, 273);
            panel6.Name = "panel6";
            panel6.Size = new Size(359, 60);
            panel6.TabIndex = 4;
            // 
            // dtpkReservationDate
            // 
            dtpkReservationDate.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dtpkReservationDate.Location = new Point(103, 18);
            dtpkReservationDate.Name = "dtpkReservationDate";
            dtpkReservationDate.Size = new Size(242, 31);
            dtpkReservationDate.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(17, 18);
            label4.Name = "label4";
            label4.Size = new Size(57, 25);
            label4.TabIndex = 0;
            label4.Text = "Date:";
            // 
            // panel5
            // 
            panel5.Controls.Add(txbReservationPhone);
            panel5.Controls.Add(label3);
            panel5.Location = new Point(3, 207);
            panel5.Name = "panel5";
            panel5.Size = new Size(359, 60);
            panel5.TabIndex = 3;
            // 
            // txbReservationPhone
            // 
            txbReservationPhone.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txbReservationPhone.Location = new Point(103, 16);
            txbReservationPhone.Name = "txbReservationPhone";
            txbReservationPhone.Size = new Size(242, 31);
            txbReservationPhone.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(17, 18);
            label3.Name = "label3";
            label3.Size = new Size(71, 25);
            label3.TabIndex = 0;
            label3.Text = "Phone:";
            // 
            // panel4
            // 
            panel4.Controls.Add(txbReservationName);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(3, 141);
            panel4.Name = "panel4";
            panel4.Size = new Size(359, 60);
            panel4.TabIndex = 2;
            // 
            // txbReservationName
            // 
            txbReservationName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txbReservationName.Location = new Point(103, 16);
            txbReservationName.Name = "txbReservationName";
            txbReservationName.Size = new Size(242, 31);
            txbReservationName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(17, 18);
            label2.Name = "label2";
            label2.Size = new Size(67, 25);
            label2.TabIndex = 0;
            label2.Text = "Name:";
            // 
            // panel3
            // 
            panel3.Controls.Add(txbReservationId);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(3, 8);
            panel3.Name = "panel3";
            panel3.Size = new Size(359, 60);
            panel3.TabIndex = 0;
            // 
            // txbReservationId
            // 
            txbReservationId.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txbReservationId.Location = new Point(103, 16);
            txbReservationId.Name = "txbReservationId";
            txbReservationId.ReadOnly = true;
            txbReservationId.Size = new Size(242, 31);
            txbReservationId.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(17, 18);
            label1.Name = "label1";
            label1.Size = new Size(36, 25);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // fReservationManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 630);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dtgvReservationList);
            Controls.Add(dtpkToDate);
            Controls.Add(dtpkFromDate);
            Name = "fReservationManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reservation Manager";
            ((System.ComponentModel.ISupportInitialize)dtgvReservationList).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericReservationSeats).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dtpkFromDate;
        private DateTimePicker dtpkToDate;
        private DataGridView dtgvReservationList;
        private Panel panel1;
        private Button btnDelete;
        private Button btnAdd;
        private Button btnView;
        private Button btnUpdate;
        private Panel panel2;
        private Panel panel3;
        private TextBox txbReservationId;
        private Label label1;
        private Panel panel4;
        private TextBox txbReservationName;
        private Label label2;
        private Panel panel5;
        private TextBox txbReservationPhone;
        private Label label3;
        private Panel panel6;
        private Label label4;
        private Panel panel8;
        private NumericUpDown numericUpDown1;
        private Label label6;
        private Panel panel7;
        private TextBox txbReservationTime;
        private Label label5;
        private DateTimePicker dtpkReservationDate;
        private Panel panel9;
        private TextBox txbReservationTableId;
        private Label label7;
        private NumericUpDown numericReservationSeats;
        private Panel panel10;
        private TextBox txbReservationEmail;
        private Label label8;
    }
}