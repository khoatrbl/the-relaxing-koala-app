namespace RestaurantIS
{
    partial class ucMenuItemLayout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucMenuItemLayout));
            menuItemPtb = new PictureBox();
            menuItemQuantityCtrl = new NumericUpDown();
            panel1 = new Panel();
            panel2 = new Panel();
            menuItemNameLabel = new Label();
            panel3 = new Panel();
            menuItemPriceLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)menuItemPtb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)menuItemQuantityCtrl).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // menuItemPtb
            // 
            menuItemPtb.Image = (Image)resources.GetObject("menuItemPtb.Image");
            menuItemPtb.Location = new Point(5, 7);
            menuItemPtb.Name = "menuItemPtb";
            menuItemPtb.Size = new Size(269, 157);
            menuItemPtb.SizeMode = PictureBoxSizeMode.Zoom;
            menuItemPtb.TabIndex = 0;
            menuItemPtb.TabStop = false;
            // 
            // menuItemQuantityCtrl
            // 
            menuItemQuantityCtrl.Location = new Point(59, 239);
            menuItemQuantityCtrl.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            menuItemQuantityCtrl.Name = "menuItemQuantityCtrl";
            menuItemQuantityCtrl.Size = new Size(150, 27);
            menuItemQuantityCtrl.TabIndex = 3;
            menuItemQuantityCtrl.ValueChanged += menuItemQuantityCtrl_ValueChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(menuItemNameLabel);
            panel1.Location = new Point(0, 166);
            panel1.Name = "panel1";
            panel1.Size = new Size(274, 32);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(274, 25);
            panel2.TabIndex = 5;
            // 
            // menuItemNameLabel
            // 
            menuItemNameLabel.Dock = DockStyle.Fill;
            menuItemNameLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            menuItemNameLabel.Location = new Point(0, 0);
            menuItemNameLabel.Name = "menuItemNameLabel";
            menuItemNameLabel.Size = new Size(274, 32);
            menuItemNameLabel.TabIndex = 2;
            menuItemNameLabel.Text = "Name";
            menuItemNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Controls.Add(menuItemPriceLabel);
            panel3.Location = new Point(0, 200);
            panel3.Name = "panel3";
            panel3.Size = new Size(274, 33);
            panel3.TabIndex = 5;
            // 
            // menuItemPriceLabel
            // 
            menuItemPriceLabel.Dock = DockStyle.Fill;
            menuItemPriceLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            menuItemPriceLabel.Location = new Point(0, 0);
            menuItemPriceLabel.Name = "menuItemPriceLabel";
            menuItemPriceLabel.Size = new Size(274, 33);
            menuItemPriceLabel.TabIndex = 3;
            menuItemPriceLabel.Text = "$00.00";
            menuItemPriceLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // fMenuItemLayout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(menuItemQuantityCtrl);
            Controls.Add(menuItemPtb);
            Name = "fMenuItemLayout";
            Size = new Size(274, 276);
            ((System.ComponentModel.ISupportInitialize)menuItemPtb).EndInit();
            ((System.ComponentModel.ISupportInitialize)menuItemQuantityCtrl).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox menuItemPtb;
        private NumericUpDown menuItemQuantityCtrl;
        private Panel panel1;
        private Panel panel2;
        private Label menuItemNameLabel;
        private Panel panel3;
        private Label menuItemPriceLabel;
    }
}
