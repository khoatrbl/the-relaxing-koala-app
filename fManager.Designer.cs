namespace RestaurantIS
{
    partial class fManager
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
            tabControl = new TabControl();
            tpInvoice = new TabPage();
            panel2 = new Panel();
            dtpkToDate = new DateTimePicker();
            showInvoiceBtn = new Button();
            dtpkFromDate = new DateTimePicker();
            panel1 = new Panel();
            dtgvInvoice = new DataGridView();
            tpMenu = new TabPage();
            panel9 = new Panel();
            label1 = new Label();
            panel6 = new Panel();
            panel22 = new Panel();
            txbKeywords = new TextBox();
            label7 = new Label();
            panel11 = new Panel();
            numericMenuItemPrice = new NumericUpDown();
            menuItemPriceLabel = new Label();
            panel10 = new Panel();
            cbItemCategory = new ComboBox();
            menuItemCategoryLabel = new Label();
            panel8 = new Panel();
            txbItemName = new TextBox();
            itemNameLabel = new Label();
            panel7 = new Panel();
            txbItemID = new TextBox();
            itemIdLabel = new Label();
            panel5 = new Panel();
            searchMenuItemBtn = new Button();
            txbSearchMenuItem = new TextBox();
            panel4 = new Panel();
            dtgvMenu = new DataGridView();
            panel3 = new Panel();
            viewMenuItemBtn = new Button();
            updateMenuItemBtn = new Button();
            deleteMenuItemBtn = new Button();
            addMenuItemBtn = new Button();
            tpCategory = new TabPage();
            panel12 = new Panel();
            categoryViewBtn = new Button();
            categoryUpdateBtn = new Button();
            categoryDeleteBtn = new Button();
            categoryAddBtn = new Button();
            dtgvCategory = new DataGridView();
            panel13 = new Panel();
            panel16 = new Panel();
            txbCategoryName = new TextBox();
            label4 = new Label();
            panel17 = new Panel();
            txbCategoryID = new TextBox();
            label5 = new Label();
            tpTable = new TabPage();
            panel14 = new Panel();
            tableViewBtn = new Button();
            tableUpdateBtn = new Button();
            tableDeleteBtn = new Button();
            tableAddBtn = new Button();
            dtgvTableList = new DataGridView();
            panel15 = new Panel();
            panel20 = new Panel();
            cbTableStatus = new ComboBox();
            label6 = new Label();
            panel18 = new Panel();
            txbTableName = new TextBox();
            label2 = new Label();
            panel19 = new Panel();
            txbTableID = new TextBox();
            label3 = new Label();
            tpAccount = new TabPage();
            panel21 = new Panel();
            resetPwdBtn = new Button();
            panel23 = new Panel();
            txbDisplayName = new TextBox();
            label8 = new Label();
            panel24 = new Panel();
            txbUsername = new TextBox();
            label9 = new Label();
            dtgvAccount = new DataGridView();
            panel27 = new Panel();
            accountViewBtn = new Button();
            accountUpdateBtn = new Button();
            accountDeleteBtn = new Button();
            accountAddBtn = new Button();
            menuStrip1 = new MenuStrip();
            updateAccountToolStripMenuItem = new ToolStripMenuItem();
            changeCredentialsToolStripMenuItem = new ToolStripMenuItem();
            changeDisplayNameToolStripMenuItem = new ToolStripMenuItem();
            tableManagementToolStripMenuItem = new ToolStripMenuItem();
            tabPage1 = new TabPage();
            dtgvReport = new DataGridView();
            tabControl.SuspendLayout();
            tpInvoice.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvInvoice).BeginInit();
            tpMenu.SuspendLayout();
            panel9.SuspendLayout();
            panel6.SuspendLayout();
            panel22.SuspendLayout();
            panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericMenuItemPrice).BeginInit();
            panel10.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvMenu).BeginInit();
            panel3.SuspendLayout();
            tpCategory.SuspendLayout();
            panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvCategory).BeginInit();
            panel13.SuspendLayout();
            panel16.SuspendLayout();
            panel17.SuspendLayout();
            tpTable.SuspendLayout();
            panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvTableList).BeginInit();
            panel15.SuspendLayout();
            panel20.SuspendLayout();
            panel18.SuspendLayout();
            panel19.SuspendLayout();
            tpAccount.SuspendLayout();
            panel21.SuspendLayout();
            panel23.SuspendLayout();
            panel24.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvAccount).BeginInit();
            panel27.SuspendLayout();
            menuStrip1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvReport).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tpInvoice);
            tabControl.Controls.Add(tpMenu);
            tabControl.Controls.Add(tpCategory);
            tabControl.Controls.Add(tpTable);
            tabControl.Controls.Add(tpAccount);
            tabControl.Controls.Add(tabPage1);
            tabControl.Location = new Point(12, 39);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(977, 593);
            tabControl.TabIndex = 0;
            // 
            // tpInvoice
            // 
            tpInvoice.Controls.Add(panel2);
            tpInvoice.Controls.Add(panel1);
            tpInvoice.Location = new Point(4, 29);
            tpInvoice.Name = "tpInvoice";
            tpInvoice.Padding = new Padding(3);
            tpInvoice.Size = new Size(969, 560);
            tpInvoice.TabIndex = 0;
            tpInvoice.Text = "Invoice";
            tpInvoice.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(dtpkToDate);
            panel2.Controls.Add(showInvoiceBtn);
            panel2.Controls.Add(dtpkFromDate);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(963, 36);
            panel2.TabIndex = 1;
            // 
            // dtpkToDate
            // 
            dtpkToDate.Location = new Point(418, 3);
            dtpkToDate.Name = "dtpkToDate";
            dtpkToDate.Size = new Size(395, 27);
            dtpkToDate.TabIndex = 2;
            // 
            // showInvoiceBtn
            // 
            showInvoiceBtn.Location = new Point(830, 3);
            showInvoiceBtn.Name = "showInvoiceBtn";
            showInvoiceBtn.Size = new Size(130, 29);
            showInvoiceBtn.TabIndex = 1;
            showInvoiceBtn.Text = "Show Invoices";
            showInvoiceBtn.UseVisualStyleBackColor = true;
            showInvoiceBtn.Click += showInvoiceBtn_Click;
            // 
            // dtpkFromDate
            // 
            dtpkFromDate.Location = new Point(3, 3);
            dtpkFromDate.Name = "dtpkFromDate";
            dtpkFromDate.Size = new Size(395, 27);
            dtpkFromDate.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(dtgvInvoice);
            panel1.Location = new Point(3, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(963, 512);
            panel1.TabIndex = 0;
            // 
            // dtgvInvoice
            // 
            dtgvInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvInvoice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvInvoice.Location = new Point(3, 3);
            dtgvInvoice.Name = "dtgvInvoice";
            dtgvInvoice.RowHeadersWidth = 51;
            dtgvInvoice.RowTemplate.Height = 29;
            dtgvInvoice.Size = new Size(957, 506);
            dtgvInvoice.TabIndex = 0;
            // 
            // tpMenu
            // 
            tpMenu.Controls.Add(panel9);
            tpMenu.Controls.Add(panel6);
            tpMenu.Controls.Add(panel5);
            tpMenu.Controls.Add(panel4);
            tpMenu.Controls.Add(panel3);
            tpMenu.Location = new Point(4, 29);
            tpMenu.Name = "tpMenu";
            tpMenu.Padding = new Padding(3);
            tpMenu.Size = new Size(969, 560);
            tpMenu.TabIndex = 1;
            tpMenu.Text = "Menu";
            tpMenu.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            panel9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel9.Controls.Add(label1);
            panel9.Location = new Point(553, 223);
            panel9.Margin = new Padding(3, 4, 3, 4);
            panel9.Name = "panel9";
            panel9.Size = new Size(0, 59);
            panel9.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 16);
            label1.Name = "label1";
            label1.Size = new Size(103, 28);
            label1.TabIndex = 0;
            label1.Text = "Category:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(panel22);
            panel6.Controls.Add(panel11);
            panel6.Controls.Add(panel10);
            panel6.Controls.Add(panel8);
            panel6.Controls.Add(panel7);
            panel6.Location = new Point(554, 85);
            panel6.Name = "panel6";
            panel6.Size = new Size(412, 475);
            panel6.TabIndex = 3;
            // 
            // panel22
            // 
            panel22.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel22.Controls.Add(txbKeywords);
            panel22.Controls.Add(label7);
            panel22.Location = new Point(0, 214);
            panel22.Margin = new Padding(3, 4, 3, 4);
            panel22.Name = "panel22";
            panel22.Size = new Size(407, 59);
            panel22.TabIndex = 3;
            // 
            // txbKeywords
            // 
            txbKeywords.Location = new Point(120, 16);
            txbKeywords.Margin = new Padding(3, 4, 3, 4);
            txbKeywords.Name = "txbKeywords";
            txbKeywords.Size = new Size(275, 27);
            txbKeywords.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(3, 16);
            label7.Name = "label7";
            label7.Size = new Size(109, 28);
            label7.TabIndex = 0;
            label7.Text = "Keywords:";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel11
            // 
            panel11.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel11.Controls.Add(numericMenuItemPrice);
            panel11.Controls.Add(menuItemPriceLabel);
            panel11.Location = new Point(0, 297);
            panel11.Margin = new Padding(3, 4, 3, 4);
            panel11.Name = "panel11";
            panel11.Size = new Size(407, 59);
            panel11.TabIndex = 3;
            // 
            // numericMenuItemPrice
            // 
            numericMenuItemPrice.DecimalPlaces = 2;
            numericMenuItemPrice.Location = new Point(121, 18);
            numericMenuItemPrice.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numericMenuItemPrice.Name = "numericMenuItemPrice";
            numericMenuItemPrice.Size = new Size(275, 27);
            numericMenuItemPrice.TabIndex = 1;
            // 
            // menuItemPriceLabel
            // 
            menuItemPriceLabel.AutoSize = true;
            menuItemPriceLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            menuItemPriceLabel.Location = new Point(3, 16);
            menuItemPriceLabel.Name = "menuItemPriceLabel";
            menuItemPriceLabel.Size = new Size(64, 28);
            menuItemPriceLabel.TabIndex = 0;
            menuItemPriceLabel.Text = "Price:";
            menuItemPriceLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel10
            // 
            panel10.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel10.Controls.Add(cbItemCategory);
            panel10.Controls.Add(menuItemCategoryLabel);
            panel10.Location = new Point(0, 138);
            panel10.Margin = new Padding(3, 4, 3, 4);
            panel10.Name = "panel10";
            panel10.Size = new Size(407, 59);
            panel10.TabIndex = 3;
            // 
            // cbItemCategory
            // 
            cbItemCategory.FormattingEnabled = true;
            cbItemCategory.Location = new Point(121, 16);
            cbItemCategory.Name = "cbItemCategory";
            cbItemCategory.Size = new Size(275, 28);
            cbItemCategory.TabIndex = 1;
            // 
            // menuItemCategoryLabel
            // 
            menuItemCategoryLabel.AutoSize = true;
            menuItemCategoryLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            menuItemCategoryLabel.Location = new Point(3, 16);
            menuItemCategoryLabel.Name = "menuItemCategoryLabel";
            menuItemCategoryLabel.Size = new Size(103, 28);
            menuItemCategoryLabel.TabIndex = 0;
            menuItemCategoryLabel.Text = "Category:";
            menuItemCategoryLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            panel8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel8.Controls.Add(txbItemName);
            panel8.Controls.Add(itemNameLabel);
            panel8.Location = new Point(1, 71);
            panel8.Margin = new Padding(3, 4, 3, 4);
            panel8.Name = "panel8";
            panel8.Size = new Size(407, 59);
            panel8.TabIndex = 2;
            // 
            // txbItemName
            // 
            txbItemName.Location = new Point(120, 16);
            txbItemName.Margin = new Padding(3, 4, 3, 4);
            txbItemName.Name = "txbItemName";
            txbItemName.Size = new Size(275, 27);
            txbItemName.TabIndex = 1;
            // 
            // itemNameLabel
            // 
            itemNameLabel.AutoSize = true;
            itemNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            itemNameLabel.Location = new Point(3, 16);
            itemNameLabel.Name = "itemNameLabel";
            itemNameLabel.Size = new Size(73, 28);
            itemNameLabel.TabIndex = 0;
            itemNameLabel.Text = "Name:";
            itemNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel7.Controls.Add(txbItemID);
            panel7.Controls.Add(itemIdLabel);
            panel7.Location = new Point(1, 4);
            panel7.Margin = new Padding(3, 4, 3, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(407, 59);
            panel7.TabIndex = 1;
            // 
            // txbItemID
            // 
            txbItemID.Location = new Point(120, 16);
            txbItemID.Margin = new Padding(3, 4, 3, 4);
            txbItemID.Name = "txbItemID";
            txbItemID.ReadOnly = true;
            txbItemID.Size = new Size(275, 27);
            txbItemID.TabIndex = 1;
            txbItemID.TextChanged += txbItemID_TextChanged;
            // 
            // itemIdLabel
            // 
            itemIdLabel.AutoSize = true;
            itemIdLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            itemIdLabel.Location = new Point(3, 16);
            itemIdLabel.Name = "itemIdLabel";
            itemIdLabel.Size = new Size(87, 28);
            itemIdLabel.TabIndex = 0;
            itemIdLabel.Text = "Item ID:";
            itemIdLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(searchMenuItemBtn);
            panel5.Controls.Add(txbSearchMenuItem);
            panel5.Location = new Point(553, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(413, 75);
            panel5.TabIndex = 2;
            // 
            // searchMenuItemBtn
            // 
            searchMenuItemBtn.Location = new Point(300, 2);
            searchMenuItemBtn.Name = "searchMenuItemBtn";
            searchMenuItemBtn.Size = new Size(110, 70);
            searchMenuItemBtn.TabIndex = 1;
            searchMenuItemBtn.Text = "Search";
            searchMenuItemBtn.UseVisualStyleBackColor = true;
            // 
            // txbSearchMenuItem
            // 
            txbSearchMenuItem.Location = new Point(4, 24);
            txbSearchMenuItem.Name = "txbSearchMenuItem";
            txbSearchMenuItem.Size = new Size(290, 27);
            txbSearchMenuItem.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(dtgvMenu);
            panel4.Location = new Point(4, 85);
            panel4.Name = "panel4";
            panel4.Size = new Size(545, 475);
            panel4.TabIndex = 1;
            // 
            // dtgvMenu
            // 
            dtgvMenu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvMenu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvMenu.Location = new Point(4, 0);
            dtgvMenu.Name = "dtgvMenu";
            dtgvMenu.RowHeadersWidth = 51;
            dtgvMenu.RowTemplate.Height = 29;
            dtgvMenu.Size = new Size(538, 469);
            dtgvMenu.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(viewMenuItemBtn);
            panel3.Controls.Add(updateMenuItemBtn);
            panel3.Controls.Add(deleteMenuItemBtn);
            panel3.Controls.Add(addMenuItemBtn);
            panel3.Location = new Point(4, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(545, 75);
            panel3.TabIndex = 0;
            // 
            // viewMenuItemBtn
            // 
            viewMenuItemBtn.Location = new Point(408, 2);
            viewMenuItemBtn.Name = "viewMenuItemBtn";
            viewMenuItemBtn.Size = new Size(134, 70);
            viewMenuItemBtn.TabIndex = 3;
            viewMenuItemBtn.Text = "View";
            viewMenuItemBtn.UseVisualStyleBackColor = true;
            viewMenuItemBtn.Click += viewMenuItemBtn_Click;
            // 
            // updateMenuItemBtn
            // 
            updateMenuItemBtn.Location = new Point(271, 2);
            updateMenuItemBtn.Name = "updateMenuItemBtn";
            updateMenuItemBtn.Size = new Size(131, 70);
            updateMenuItemBtn.TabIndex = 2;
            updateMenuItemBtn.Text = "Update";
            updateMenuItemBtn.UseVisualStyleBackColor = true;
            updateMenuItemBtn.Click += updateMenuItemBtn_Click;
            // 
            // deleteMenuItemBtn
            // 
            deleteMenuItemBtn.Location = new Point(138, 2);
            deleteMenuItemBtn.Name = "deleteMenuItemBtn";
            deleteMenuItemBtn.Size = new Size(127, 70);
            deleteMenuItemBtn.TabIndex = 1;
            deleteMenuItemBtn.Text = "Delete";
            deleteMenuItemBtn.UseVisualStyleBackColor = true;
            deleteMenuItemBtn.Click += deleteMenuItemBtn_Click;
            // 
            // addMenuItemBtn
            // 
            addMenuItemBtn.Location = new Point(3, 2);
            addMenuItemBtn.Name = "addMenuItemBtn";
            addMenuItemBtn.Size = new Size(129, 70);
            addMenuItemBtn.TabIndex = 0;
            addMenuItemBtn.Text = "Add";
            addMenuItemBtn.UseVisualStyleBackColor = true;
            addMenuItemBtn.Click += addMenuItemBtn_Click;
            // 
            // tpCategory
            // 
            tpCategory.Controls.Add(panel12);
            tpCategory.Controls.Add(dtgvCategory);
            tpCategory.Controls.Add(panel13);
            tpCategory.Location = new Point(4, 29);
            tpCategory.Name = "tpCategory";
            tpCategory.Padding = new Padding(3);
            tpCategory.Size = new Size(969, 560);
            tpCategory.TabIndex = 2;
            tpCategory.Text = "Category";
            tpCategory.UseVisualStyleBackColor = true;
            // 
            // panel12
            // 
            panel12.Controls.Add(categoryViewBtn);
            panel12.Controls.Add(categoryUpdateBtn);
            panel12.Controls.Add(categoryDeleteBtn);
            panel12.Controls.Add(categoryAddBtn);
            panel12.Location = new Point(3, 4);
            panel12.Name = "panel12";
            panel12.Size = new Size(545, 75);
            panel12.TabIndex = 4;
            // 
            // categoryViewBtn
            // 
            categoryViewBtn.Location = new Point(408, 2);
            categoryViewBtn.Name = "categoryViewBtn";
            categoryViewBtn.Size = new Size(134, 70);
            categoryViewBtn.TabIndex = 3;
            categoryViewBtn.Text = "View";
            categoryViewBtn.UseVisualStyleBackColor = true;
            categoryViewBtn.Click += categoryViewBtn_Click;
            // 
            // categoryUpdateBtn
            // 
            categoryUpdateBtn.Location = new Point(271, 2);
            categoryUpdateBtn.Name = "categoryUpdateBtn";
            categoryUpdateBtn.Size = new Size(131, 70);
            categoryUpdateBtn.TabIndex = 2;
            categoryUpdateBtn.Text = "Update";
            categoryUpdateBtn.UseVisualStyleBackColor = true;
            categoryUpdateBtn.Click += categoryUpdateBtn_Click;
            // 
            // categoryDeleteBtn
            // 
            categoryDeleteBtn.Enabled = false;
            categoryDeleteBtn.Location = new Point(138, 2);
            categoryDeleteBtn.Name = "categoryDeleteBtn";
            categoryDeleteBtn.Size = new Size(127, 70);
            categoryDeleteBtn.TabIndex = 1;
            categoryDeleteBtn.Text = "Delete";
            categoryDeleteBtn.UseVisualStyleBackColor = true;
            // 
            // categoryAddBtn
            // 
            categoryAddBtn.Location = new Point(3, 2);
            categoryAddBtn.Name = "categoryAddBtn";
            categoryAddBtn.Size = new Size(129, 70);
            categoryAddBtn.TabIndex = 0;
            categoryAddBtn.Text = "Add";
            categoryAddBtn.UseVisualStyleBackColor = true;
            categoryAddBtn.Click += categoryAddBtn_Click;
            // 
            // dtgvCategory
            // 
            dtgvCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvCategory.Location = new Point(3, 85);
            dtgvCategory.Name = "dtgvCategory";
            dtgvCategory.RowHeadersWidth = 51;
            dtgvCategory.RowTemplate.Height = 29;
            dtgvCategory.Size = new Size(546, 475);
            dtgvCategory.TabIndex = 5;
            // 
            // panel13
            // 
            panel13.BorderStyle = BorderStyle.FixedSingle;
            panel13.Controls.Add(panel16);
            panel13.Controls.Add(panel17);
            panel13.Location = new Point(553, 85);
            panel13.Name = "panel13";
            panel13.Size = new Size(412, 475);
            panel13.TabIndex = 7;
            // 
            // panel16
            // 
            panel16.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel16.Controls.Add(txbCategoryName);
            panel16.Controls.Add(label4);
            panel16.Location = new Point(1, 71);
            panel16.Margin = new Padding(3, 4, 3, 4);
            panel16.Name = "panel16";
            panel16.Size = new Size(408, 59);
            panel16.TabIndex = 2;
            // 
            // txbCategoryName
            // 
            txbCategoryName.Location = new Point(120, 16);
            txbCategoryName.Margin = new Padding(3, 4, 3, 4);
            txbCategoryName.Name = "txbCategoryName";
            txbCategoryName.Size = new Size(275, 27);
            txbCategoryName.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(3, 16);
            label4.Name = "label4";
            label4.Size = new Size(73, 28);
            label4.TabIndex = 0;
            label4.Text = "Name:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel17
            // 
            panel17.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel17.Controls.Add(txbCategoryID);
            panel17.Controls.Add(label5);
            panel17.Location = new Point(1, 4);
            panel17.Margin = new Padding(3, 4, 3, 4);
            panel17.Name = "panel17";
            panel17.Size = new Size(408, 59);
            panel17.TabIndex = 1;
            // 
            // txbCategoryID
            // 
            txbCategoryID.Location = new Point(120, 16);
            txbCategoryID.Margin = new Padding(3, 4, 3, 4);
            txbCategoryID.Name = "txbCategoryID";
            txbCategoryID.ReadOnly = true;
            txbCategoryID.Size = new Size(275, 27);
            txbCategoryID.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(3, 16);
            label5.Name = "label5";
            label5.Size = new Size(38, 28);
            label5.TabIndex = 0;
            label5.Text = "ID:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tpTable
            // 
            tpTable.Controls.Add(panel14);
            tpTable.Controls.Add(dtgvTableList);
            tpTable.Controls.Add(panel15);
            tpTable.Location = new Point(4, 29);
            tpTable.Name = "tpTable";
            tpTable.Padding = new Padding(3);
            tpTable.Size = new Size(969, 560);
            tpTable.TabIndex = 3;
            tpTable.Text = "Table";
            tpTable.UseVisualStyleBackColor = true;
            // 
            // panel14
            // 
            panel14.Controls.Add(tableViewBtn);
            panel14.Controls.Add(tableUpdateBtn);
            panel14.Controls.Add(tableDeleteBtn);
            panel14.Controls.Add(tableAddBtn);
            panel14.Location = new Point(3, 2);
            panel14.Name = "panel14";
            panel14.Size = new Size(545, 75);
            panel14.TabIndex = 8;
            // 
            // tableViewBtn
            // 
            tableViewBtn.Location = new Point(408, 2);
            tableViewBtn.Name = "tableViewBtn";
            tableViewBtn.Size = new Size(134, 70);
            tableViewBtn.TabIndex = 3;
            tableViewBtn.Text = "View";
            tableViewBtn.UseVisualStyleBackColor = true;
            tableViewBtn.Click += tableViewBtn_Click;
            // 
            // tableUpdateBtn
            // 
            tableUpdateBtn.Location = new Point(271, 2);
            tableUpdateBtn.Name = "tableUpdateBtn";
            tableUpdateBtn.Size = new Size(131, 70);
            tableUpdateBtn.TabIndex = 2;
            tableUpdateBtn.Text = "Update";
            tableUpdateBtn.UseVisualStyleBackColor = true;
            tableUpdateBtn.Click += tableUpdateBtn_Click;
            // 
            // tableDeleteBtn
            // 
            tableDeleteBtn.Enabled = false;
            tableDeleteBtn.Location = new Point(138, 2);
            tableDeleteBtn.Name = "tableDeleteBtn";
            tableDeleteBtn.Size = new Size(127, 70);
            tableDeleteBtn.TabIndex = 1;
            tableDeleteBtn.Text = "Delete";
            tableDeleteBtn.UseVisualStyleBackColor = true;
            // 
            // tableAddBtn
            // 
            tableAddBtn.Location = new Point(3, 2);
            tableAddBtn.Name = "tableAddBtn";
            tableAddBtn.Size = new Size(129, 70);
            tableAddBtn.TabIndex = 0;
            tableAddBtn.Text = "Add";
            tableAddBtn.UseVisualStyleBackColor = true;
            tableAddBtn.Click += tableAddBtn_Click;
            // 
            // dtgvTableList
            // 
            dtgvTableList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvTableList.Location = new Point(3, 83);
            dtgvTableList.Name = "dtgvTableList";
            dtgvTableList.RowHeadersWidth = 51;
            dtgvTableList.RowTemplate.Height = 29;
            dtgvTableList.Size = new Size(546, 475);
            dtgvTableList.TabIndex = 9;
            // 
            // panel15
            // 
            panel15.BorderStyle = BorderStyle.FixedSingle;
            panel15.Controls.Add(panel20);
            panel15.Controls.Add(panel18);
            panel15.Controls.Add(panel19);
            panel15.Location = new Point(553, 83);
            panel15.Name = "panel15";
            panel15.Size = new Size(412, 475);
            panel15.TabIndex = 10;
            // 
            // panel20
            // 
            panel20.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel20.Controls.Add(cbTableStatus);
            panel20.Controls.Add(label6);
            panel20.Location = new Point(1, 138);
            panel20.Margin = new Padding(3, 4, 3, 4);
            panel20.Name = "panel20";
            panel20.Size = new Size(408, 59);
            panel20.TabIndex = 2;
            // 
            // cbTableStatus
            // 
            cbTableStatus.FormattingEnabled = true;
            cbTableStatus.Location = new Point(120, 15);
            cbTableStatus.Name = "cbTableStatus";
            cbTableStatus.Size = new Size(275, 28);
            cbTableStatus.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(3, 16);
            label6.Name = "label6";
            label6.Size = new Size(76, 28);
            label6.TabIndex = 0;
            label6.Text = "Status:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel18
            // 
            panel18.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel18.Controls.Add(txbTableName);
            panel18.Controls.Add(label2);
            panel18.Location = new Point(1, 71);
            panel18.Margin = new Padding(3, 4, 3, 4);
            panel18.Name = "panel18";
            panel18.Size = new Size(408, 59);
            panel18.TabIndex = 2;
            // 
            // txbTableName
            // 
            txbTableName.Location = new Point(120, 16);
            txbTableName.Margin = new Padding(3, 4, 3, 4);
            txbTableName.Name = "txbTableName";
            txbTableName.Size = new Size(275, 27);
            txbTableName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 16);
            label2.Name = "label2";
            label2.Size = new Size(73, 28);
            label2.TabIndex = 0;
            label2.Text = "Name:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel19
            // 
            panel19.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel19.Controls.Add(txbTableID);
            panel19.Controls.Add(label3);
            panel19.Location = new Point(1, 4);
            panel19.Margin = new Padding(3, 4, 3, 4);
            panel19.Name = "panel19";
            panel19.Size = new Size(408, 59);
            panel19.TabIndex = 1;
            // 
            // txbTableID
            // 
            txbTableID.Location = new Point(120, 16);
            txbTableID.Margin = new Padding(3, 4, 3, 4);
            txbTableID.Name = "txbTableID";
            txbTableID.ReadOnly = true;
            txbTableID.Size = new Size(275, 27);
            txbTableID.TabIndex = 1;
            txbTableID.TextChanged += txbTableID_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(3, 16);
            label3.Name = "label3";
            label3.Size = new Size(94, 28);
            label3.TabIndex = 0;
            label3.Text = "Table ID:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tpAccount
            // 
            tpAccount.Controls.Add(panel21);
            tpAccount.Controls.Add(dtgvAccount);
            tpAccount.Controls.Add(panel27);
            tpAccount.Location = new Point(4, 29);
            tpAccount.Name = "tpAccount";
            tpAccount.Padding = new Padding(3);
            tpAccount.Size = new Size(969, 560);
            tpAccount.TabIndex = 4;
            tpAccount.Text = "Account";
            tpAccount.UseVisualStyleBackColor = true;
            // 
            // panel21
            // 
            panel21.BorderStyle = BorderStyle.FixedSingle;
            panel21.Controls.Add(resetPwdBtn);
            panel21.Controls.Add(panel23);
            panel21.Controls.Add(panel24);
            panel21.Location = new Point(553, 85);
            panel21.Name = "panel21";
            panel21.Size = new Size(412, 475);
            panel21.TabIndex = 7;
            // 
            // resetPwdBtn
            // 
            resetPwdBtn.Location = new Point(276, 137);
            resetPwdBtn.Name = "resetPwdBtn";
            resetPwdBtn.Size = new Size(124, 74);
            resetPwdBtn.TabIndex = 4;
            resetPwdBtn.Text = "Reset Password";
            resetPwdBtn.UseVisualStyleBackColor = true;
            resetPwdBtn.Click += resetPwdBtn_Click;
            // 
            // panel23
            // 
            panel23.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel23.Controls.Add(txbDisplayName);
            panel23.Controls.Add(label8);
            panel23.Location = new Point(4, 71);
            panel23.Margin = new Padding(3, 4, 3, 4);
            panel23.Name = "panel23";
            panel23.Size = new Size(402, 59);
            panel23.TabIndex = 3;
            // 
            // txbDisplayName
            // 
            txbDisplayName.Location = new Point(158, 20);
            txbDisplayName.Margin = new Padding(3, 4, 3, 4);
            txbDisplayName.Name = "txbDisplayName";
            txbDisplayName.Size = new Size(238, 27);
            txbDisplayName.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(3, 16);
            label8.Name = "label8";
            label8.Size = new Size(149, 28);
            label8.TabIndex = 0;
            label8.Text = "Display Name:";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel24
            // 
            panel24.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel24.Controls.Add(txbUsername);
            panel24.Controls.Add(label9);
            panel24.Location = new Point(4, 4);
            panel24.Margin = new Padding(3, 4, 3, 4);
            panel24.Name = "panel24";
            panel24.Size = new Size(403, 59);
            panel24.TabIndex = 2;
            // 
            // txbUsername
            // 
            txbUsername.Location = new Point(157, 16);
            txbUsername.Margin = new Padding(3, 4, 3, 4);
            txbUsername.Name = "txbUsername";
            txbUsername.Size = new Size(238, 27);
            txbUsername.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(3, 16);
            label9.Name = "label9";
            label9.Size = new Size(111, 28);
            label9.TabIndex = 0;
            label9.Text = "Username:";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtgvAccount
            // 
            dtgvAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvAccount.Location = new Point(3, 85);
            dtgvAccount.Name = "dtgvAccount";
            dtgvAccount.RowHeadersWidth = 51;
            dtgvAccount.RowTemplate.Height = 29;
            dtgvAccount.Size = new Size(545, 469);
            dtgvAccount.TabIndex = 4;
            // 
            // panel27
            // 
            panel27.Controls.Add(accountViewBtn);
            panel27.Controls.Add(accountUpdateBtn);
            panel27.Controls.Add(accountDeleteBtn);
            panel27.Controls.Add(accountAddBtn);
            panel27.Location = new Point(3, 4);
            panel27.Name = "panel27";
            panel27.Size = new Size(545, 75);
            panel27.TabIndex = 5;
            // 
            // accountViewBtn
            // 
            accountViewBtn.Location = new Point(408, 2);
            accountViewBtn.Name = "accountViewBtn";
            accountViewBtn.Size = new Size(134, 70);
            accountViewBtn.TabIndex = 3;
            accountViewBtn.Text = "View";
            accountViewBtn.UseVisualStyleBackColor = true;
            accountViewBtn.Click += accountViewBtn_Click;
            // 
            // accountUpdateBtn
            // 
            accountUpdateBtn.Location = new Point(271, 2);
            accountUpdateBtn.Name = "accountUpdateBtn";
            accountUpdateBtn.Size = new Size(131, 70);
            accountUpdateBtn.TabIndex = 2;
            accountUpdateBtn.Text = "Update";
            accountUpdateBtn.UseVisualStyleBackColor = true;
            accountUpdateBtn.Click += accountUpdateBtn_Click;
            // 
            // accountDeleteBtn
            // 
            accountDeleteBtn.Location = new Point(138, 2);
            accountDeleteBtn.Name = "accountDeleteBtn";
            accountDeleteBtn.Size = new Size(127, 70);
            accountDeleteBtn.TabIndex = 1;
            accountDeleteBtn.Text = "Delete";
            accountDeleteBtn.UseVisualStyleBackColor = true;
            accountDeleteBtn.Click += accountDeleteBtn_Click;
            // 
            // accountAddBtn
            // 
            accountAddBtn.Location = new Point(3, 2);
            accountAddBtn.Name = "accountAddBtn";
            accountAddBtn.Size = new Size(129, 70);
            accountAddBtn.TabIndex = 0;
            accountAddBtn.Text = "Add";
            accountAddBtn.UseVisualStyleBackColor = true;
            accountAddBtn.Click += accountAddBtn_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { updateAccountToolStripMenuItem, tableManagementToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1001, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // updateAccountToolStripMenuItem
            // 
            updateAccountToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { changeCredentialsToolStripMenuItem, changeDisplayNameToolStripMenuItem });
            updateAccountToolStripMenuItem.Name = "updateAccountToolStripMenuItem";
            updateAccountToolStripMenuItem.Size = new Size(80, 24);
            updateAccountToolStripMenuItem.Text = "Account:";
            // 
            // changeCredentialsToolStripMenuItem
            // 
            changeCredentialsToolStripMenuItem.Name = "changeCredentialsToolStripMenuItem";
            changeCredentialsToolStripMenuItem.Size = new Size(239, 26);
            changeCredentialsToolStripMenuItem.Text = "Change Password";
            changeCredentialsToolStripMenuItem.Click += changeCredentialsToolStripMenuItem_Click;
            // 
            // changeDisplayNameToolStripMenuItem
            // 
            changeDisplayNameToolStripMenuItem.Name = "changeDisplayNameToolStripMenuItem";
            changeDisplayNameToolStripMenuItem.Size = new Size(239, 26);
            changeDisplayNameToolStripMenuItem.Text = "Change Display Name";
            changeDisplayNameToolStripMenuItem.Click += changeDisplayNameToolStripMenuItem_Click;
            // 
            // tableManagementToolStripMenuItem
            // 
            tableManagementToolStripMenuItem.Name = "tableManagementToolStripMenuItem";
            tableManagementToolStripMenuItem.Size = new Size(150, 24);
            tableManagementToolStripMenuItem.Text = "Table Management";
            tableManagementToolStripMenuItem.Click += tableManagementToolStripMenuItem_Click;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dtgvReport);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(969, 560);
            tabPage1.TabIndex = 5;
            tabPage1.Text = "Report";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dtgvReport
            // 
            dtgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvReport.Location = new Point(2, 0);
            dtgvReport.Name = "dtgvReport";
            dtgvReport.ReadOnly = true;
            dtgvReport.RowHeadersWidth = 51;
            dtgvReport.RowTemplate.Height = 29;
            dtgvReport.Size = new Size(967, 560);
            dtgvReport.TabIndex = 0;
            // 
            // fManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1001, 644);
            Controls.Add(tabControl);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "fManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            tabControl.ResumeLayout(false);
            tpInvoice.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvInvoice).EndInit();
            tpMenu.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel6.ResumeLayout(false);
            panel22.ResumeLayout(false);
            panel22.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericMenuItemPrice).EndInit();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvMenu).EndInit();
            panel3.ResumeLayout(false);
            tpCategory.ResumeLayout(false);
            panel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvCategory).EndInit();
            panel13.ResumeLayout(false);
            panel16.ResumeLayout(false);
            panel16.PerformLayout();
            panel17.ResumeLayout(false);
            panel17.PerformLayout();
            tpTable.ResumeLayout(false);
            panel14.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvTableList).EndInit();
            panel15.ResumeLayout(false);
            panel20.ResumeLayout(false);
            panel20.PerformLayout();
            panel18.ResumeLayout(false);
            panel18.PerformLayout();
            panel19.ResumeLayout(false);
            panel19.PerformLayout();
            tpAccount.ResumeLayout(false);
            panel21.ResumeLayout(false);
            panel23.ResumeLayout(false);
            panel23.PerformLayout();
            panel24.ResumeLayout(false);
            panel24.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvAccount).EndInit();
            panel27.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl;
        private TabPage tpInvoice;
        private TabPage tpMenu;
        private TabPage tpCategory;
        private Panel panel2;
        private Panel panel1;
        private DataGridView dtgvInvoice;
        private TabPage tpTable;
        private TabPage tpAccount;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem updateAccountToolStripMenuItem;
        private Button showInvoiceBtn;
        private DateTimePicker dtpkFromDate;
        private Panel panel3;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private DataGridView dtgvMenu;
        private Button viewMenuItemBtn;
        private Button updateMenuItemBtn;
        private Button deleteMenuItemBtn;
        private Button addMenuItemBtn;
        private Button searchMenuItemBtn;
        private TextBox txbSearchMenuItem;
        private Panel panel8;
        private TextBox txbItemName;
        private Label itemNameLabel;
        private Panel panel7;
        private TextBox txbItemID;
        private Label itemIdLabel;
        private Panel panel9;
        private Label label1;
        private Panel panel11;
        private NumericUpDown numericMenuItemPrice;
        private Label menuItemPriceLabel;
        private Panel panel10;
        private Label menuItemCategoryLabel;
        private Panel panel12;
        private Button categoryViewBtn;
        private Button categoryUpdateBtn;
        private Button categoryDeleteBtn;
        private Button categoryAddBtn;
        private DataGridView dtgvCategory;
        private Panel panel13;
        private Panel panel16;
        private TextBox txbCategoryName;
        private Label label4;
        private Panel panel17;
        private TextBox txbCategoryID;
        private Label label5;
        private Panel panel14;
        private Button tableViewBtn;
        private Button tableUpdateBtn;
        private Button tableDeleteBtn;
        private Button tableAddBtn;
        private DataGridView dtgvTableList;
        private Panel panel15;
        private Panel panel18;
        private TextBox txbTableName;
        private Label label2;
        private Panel panel19;
        private TextBox txbTableID;
        private Label label3;
        private Panel panel20;
        private ComboBox cbTableStatus;
        private Label label6;
        private Panel panel21;
        private Panel panel23;
        private Label label8;
        private Panel panel24;
        private TextBox txbUsername;
        private Label label9;
        private DataGridView dtgvAccount;
        private Panel panel27;
        private Button accountViewBtn;
        private Button accountUpdateBtn;
        private Button accountDeleteBtn;
        private Button accountAddBtn;
        private TextBox txbDisplayName;
        private Button resetPwdBtn;
        private ToolStripMenuItem changeCredentialsToolStripMenuItem;
        private DateTimePicker dtpkToDate;
        private ToolStripMenuItem tableManagementToolStripMenuItem;
        private ToolStripMenuItem changeDisplayNameToolStripMenuItem;
        private Panel panel22;
        private TextBox txbKeywords;
        private Label label7;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn id;
        private ComboBox cbItemCategory;
        private TabPage tabPage1;
        private DataGridView dtgvReport;
    }
}