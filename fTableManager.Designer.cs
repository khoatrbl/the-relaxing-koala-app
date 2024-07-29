namespace RestaurantIS
{
    partial class fTableManager
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
            menuStrip1 = new MenuStrip();
            loginAsManagerToolStripMenuItem = new ToolStripMenuItem();
            OrderListLabel = new Label();
            panel2 = new Panel();
            listViewOrderList = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            panel4 = new Panel();
            panel3 = new Panel();
            PaymentBtn = new Button();
            OrderBtn = new Button();
            panel5 = new Panel();
            totalPriceTxb = new TextBox();
            label1 = new Label();
            flpTableList = new FlowLayoutPanel();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { loginAsManagerToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(999, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // loginAsManagerToolStripMenuItem
            // 
            loginAsManagerToolStripMenuItem.Name = "loginAsManagerToolStripMenuItem";
            loginAsManagerToolStripMenuItem.Size = new Size(141, 24);
            loginAsManagerToolStripMenuItem.Text = "Login as Manager";
            loginAsManagerToolStripMenuItem.Click += loginAsManagerToolStripMenuItem_Click;
            // 
            // OrderListLabel
            // 
            OrderListLabel.AutoSize = true;
            OrderListLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            OrderListLabel.Location = new Point(3, 8);
            OrderListLabel.Name = "OrderListLabel";
            OrderListLabel.Size = new Size(110, 28);
            OrderListLabel.TabIndex = 0;
            OrderListLabel.Text = "Order List:";
            // 
            // panel2
            // 
            panel2.Controls.Add(listViewOrderList);
            panel2.Controls.Add(panel4);
            panel2.Location = new Point(430, 41);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(414, 555);
            panel2.TabIndex = 2;
            // 
            // listViewOrderList
            // 
            listViewOrderList.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listViewOrderList.Location = new Point(2, 51);
            listViewOrderList.Name = "listViewOrderList";
            listViewOrderList.Size = new Size(415, 504);
            listViewOrderList.TabIndex = 3;
            listViewOrderList.UseCompatibleStateImageBehavior = false;
            listViewOrderList.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Item";
            columnHeader1.Width = 160;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Quantity";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Price";
            columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Total";
            columnHeader4.Width = 80;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(OrderListLabel);
            panel4.Location = new Point(1, 0);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(413, 46);
            panel4.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(PaymentBtn);
            panel3.Controls.Add(OrderBtn);
            panel3.Location = new Point(847, 41);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(152, 348);
            panel3.TabIndex = 3;
            // 
            // PaymentBtn
            // 
            PaymentBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            PaymentBtn.Location = new Point(3, 105);
            PaymentBtn.Margin = new Padding(3, 4, 3, 4);
            PaymentBtn.Name = "PaymentBtn";
            PaymentBtn.Size = new Size(142, 93);
            PaymentBtn.TabIndex = 1;
            PaymentBtn.Text = "Payment";
            PaymentBtn.UseVisualStyleBackColor = true;
            PaymentBtn.Click += PaymentBtn_Click;
            // 
            // OrderBtn
            // 
            OrderBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            OrderBtn.Location = new Point(3, 4);
            OrderBtn.Margin = new Padding(3, 4, 3, 4);
            OrderBtn.Name = "OrderBtn";
            OrderBtn.Size = new Size(142, 93);
            OrderBtn.TabIndex = 0;
            OrderBtn.Text = "Order";
            OrderBtn.UseVisualStyleBackColor = true;
            OrderBtn.Click += OrderBtn_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(totalPriceTxb);
            panel5.Controls.Add(label1);
            panel5.Location = new Point(847, 495);
            panel5.Name = "panel5";
            panel5.Size = new Size(152, 101);
            panel5.TabIndex = 4;
            // 
            // totalPriceTxb
            // 
            totalPriceTxb.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            totalPriceTxb.Location = new Point(3, 57);
            totalPriceTxb.Name = "totalPriceTxb";
            totalPriceTxb.ReadOnly = true;
            totalPriceTxb.Size = new Size(146, 34);
            totalPriceTxb.TabIndex = 1;
            totalPriceTxb.Text = "0";
            totalPriceTxb.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 26);
            label1.Name = "label1";
            label1.Size = new Size(64, 28);
            label1.TabIndex = 0;
            label1.Text = "Total:";
            // 
            // flpTableList
            // 
            flpTableList.AutoScroll = true;
            flpTableList.Location = new Point(12, 41);
            flpTableList.Name = "flpTableList";
            flpTableList.Size = new Size(414, 555);
            flpTableList.TabIndex = 5;
            // 
            // fTableManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(999, 612);
            Controls.Add(flpTableList);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "fTableManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RK Table Manager";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem loginAsManagerToolStripMenuItem;
        private Panel panel2;
        private Label OrderListLabel;
        private Panel panel3;
        private Button OrderBtn;
        private Button PaymentBtn;
        private Panel panel4;
        private Panel panel5;
        private TextBox totalPriceTxb;
        private Label label1;
        private FlowLayoutPanel flpTableList;
        private ListView listViewOrderList;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}