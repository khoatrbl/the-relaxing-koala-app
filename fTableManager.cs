using RestaurantIS.DAO;
using RestaurantIS.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantIS
{
    public partial class fTableManager : Form
    {
        private Table currentTable;
        private Button lastButton = null;
        public fTableManager()
        {
            InitializeComponent();
            LoadTable();
        }

        private void loginAsManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadTable()
        {
            flpTableList.Controls.Clear();
            List<Table> tableList = TableDAO.Instance.LoadTableList();

            foreach (Table table in tableList)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.Text = table.Name + Environment.NewLine + "- " + table.Status + " -";

                btn.Click += btn_Click;
                btn.Tag = table;

                switch (table.Status)
                {
                    case "Vacant":
                        btn.BackColor = Color.LightGreen;
                        break;
                    case "Reserved":
                        btn.BackColor = Color.Yellow;
                        break;
                    default:
                        btn.BackColor = Color.LightPink;
                        break;
                }
                flpTableList.Controls.Add(btn);

            }
        }

        private void btn_Click(object? sender, EventArgs e)
        {
            currentTable = (sender as Button).Tag as Table;
            int tableID = currentTable.ID;

            // Change the background color of the button that was clicked
            Control currentBtn = ((Control)sender);

            switch (currentBtn.BackColor.Name)
            {
                case "LightGreen":
                    currentBtn.BackColor = Color.Green;
                    break;
                case "LightPink":
                    currentBtn.BackColor = Color.Red;
                    break;
                case "Yellow":
                    currentBtn.BackColor = Color.Orange;
                    break;

            }


            // Revert the background color of the previously-colored button, if any
            if (lastButton != null)
            {
                switch (lastButton.BackColor.Name)
                {
                    case "Green":
                        lastButton.BackColor = Color.LightGreen;
                        break;
                    case "Red":
                        lastButton.BackColor = Color.LightPink;
                        break;
                    case "Orange":
                        lastButton.BackColor = Color.Yellow;
                        break;

                }

            }

            // Update the previously-colored button
            lastButton = (Button)currentBtn;

            showOrderByTable(tableID);
        }

        private void showOrderByTable(int tableID)
        {
            listViewOrderList.Items.Clear();

            float totalPriceOfOrder = 0;
            totalPriceTxb.Text = totalPriceOfOrder.ToString();

            CultureInfo culture = new CultureInfo("en-US"); // setting the culture to ensure currency is formatted correctly

            List<OrderItem> listOfOrderItems = OrderItemDAO.Instance.getListOfOrderItemsByTableID(tableID);

            foreach (OrderItem item in listOfOrderItems)
            {
                ListViewItem listViewItem = new ListViewItem(item.Item.ToString());
                listViewItem.SubItems.Add(item.Quantity.ToString());
                listViewItem.SubItems.Add(item.Price.ToString("c", culture));
                listViewItem.SubItems.Add(item.Total.ToString("c", culture));

                totalPriceOfOrder += item.Total;
                currentTable.TotalOrderPrice = totalPriceOfOrder;
                totalPriceTxb.Text = totalPriceOfOrder.ToString("c", culture); // "c": short for currency, used to format the total price

                listViewOrderList.Items.Add(listViewItem);
            }
   
        }

        private void OrderBtn_Click(object? sender, EventArgs e)
        {
            if (currentTable != null)
            {
                int tableID = currentTable.ID;

                fOrder fOrder = new fOrder(tableID);
                this.Hide();
                fOrder.ShowDialog();
                this.Show();
                showOrderByTable(tableID);
                LoadTable();
            }
            else
            {
                MessageBox.Show("Please select a table first.");
            }
        }

        private void PaymentBtn_Click(object sender, EventArgs e)
        {
            if (currentTable != null)
            {
                int invoiceID = InvoiceDAO.Instance.GetUnpaidInvoiceIDByTableID(currentTable.ID);

                if (invoiceID != -1)
                {
                    if (MessageBox.Show("Are you sure you want to checkout for " + currentTable.Name + "?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        // TODO: Choose payment method, if cash then calculate change
                        // pass invoiceID into the payment method form
                        // call MakePayment() inside that form with the corresponding payment method
                        fPaymentMethod fPaymentMethod = new fPaymentMethod(currentTable.TotalOrderPrice, invoiceID);
                        this.Hide();
                        fPaymentMethod.ShowDialog();
                        this.Show();

                        
                        showOrderByTable(currentTable.ID);
                        LoadTable();
                    }
                }
            } else
            {
                MessageBox.Show("Please select a table first.");    
            }
            

        }
    }
}
