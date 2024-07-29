namespace RestaurantIS
{
    partial class fOrder
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
            flpMenuItem = new FlowLayoutPanel();
            panel1 = new Panel();
            OrderAddBtn = new Button();
            OrderBackBtn = new Button();
            panel2 = new Panel();
            label1 = new Label();
            flpCategory = new FlowLayoutPanel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // flpMenuItem
            // 
            flpMenuItem.AutoScroll = true;
            flpMenuItem.Location = new Point(167, 0);
            flpMenuItem.Name = "flpMenuItem";
            flpMenuItem.Size = new Size(599, 605);
            flpMenuItem.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(OrderAddBtn);
            panel1.Controls.Add(OrderBackBtn);
            panel1.Location = new Point(772, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(170, 604);
            panel1.TabIndex = 1;
            // 
            // OrderAddBtn
            // 
            OrderAddBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            OrderAddBtn.Location = new Point(7, 368);
            OrderAddBtn.Name = "OrderAddBtn";
            OrderAddBtn.Size = new Size(158, 107);
            OrderAddBtn.TabIndex = 2;
            OrderAddBtn.Text = "Add/Delete";
            OrderAddBtn.UseVisualStyleBackColor = true;
            OrderAddBtn.Click += OrderAddBtn_Click;
            // 
            // OrderBackBtn
            // 
            OrderBackBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            OrderBackBtn.Location = new Point(7, 481);
            OrderBackBtn.Name = "OrderBackBtn";
            OrderBackBtn.Size = new Size(158, 107);
            OrderBackBtn.TabIndex = 1;
            OrderBackBtn.Text = "Back";
            OrderBackBtn.UseVisualStyleBackColor = true;
            OrderBackBtn.Click += OrderBackBtn_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(1, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(165, 56);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(25, 9);
            label1.Name = "label1";
            label1.Size = new Size(111, 31);
            label1.TabIndex = 3;
            label1.Text = "Category";
            // 
            // flpCategory
            // 
            flpCategory.BorderStyle = BorderStyle.FixedSingle;
            flpCategory.Location = new Point(0, 60);
            flpCategory.Name = "flpCategory";
            flpCategory.Size = new Size(166, 545);
            flpCategory.TabIndex = 3;
            // 
            // fOrder
            // 
            AcceptButton = OrderAddBtn;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = OrderBackBtn;
            ClientSize = new Size(954, 611);
            Controls.Add(flpCategory);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(flpMenuItem);
            Name = "fOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Order";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpMenuItem;
        private Panel panel1;
        private Button OrderBackBtn;
        private Button OrderAddBtn;
        private Panel panel2;
        private Label label1;
        private FlowLayoutPanel flpCategory;
    }
}