using RestaurantIS.DAO;
using RestaurantIS.DTO;
using RestaurantIS.Interfaces;
using RestaurantIS.Properties;
using RestaurantIS.Strategies;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantIS
{
    public partial class fPaymentMethod : Form
    {
        private float totalPrice;
        private int invoiceID;
        public fPaymentMethod(float totalPrice, int invoiceID)
        {
            this.totalPrice = totalPrice;
            InitializeComponent();
            LoadTotalPrice();
            LoadPaymentMethods();
            this.InvoiceID = invoiceID;
        }

        public float TotalPrice { get => totalPrice; set => totalPrice = value; }
        public int InvoiceID { get => invoiceID; set => invoiceID = value; }

        #region Methods
        public void LoadTotalPrice()
        {
            txbTotalAmoutDisplay.Text = totalPrice.ToString("c");
        }

        public void LoadPaymentMethods()
        {
            List<PaymentMethod> paymentMethods = new List<PaymentMethod>() { PaymentMethod.Card, PaymentMethod.Cash };
            foreach (PaymentMethod paymentMethod in paymentMethods)
            {
                ucPaymentMethod paymentMethodLayout = new ucPaymentMethod();
                paymentMethodLayout.Method = paymentMethod.ToString();

                paymentMethodLayout.Click += PaymentMethodLayout_Click;
                paymentMethodLayout.GetPictureBox().Click += PaymentMethodLayout_Click;
                paymentMethodLayout.GetMethodDisplay().Click += PaymentMethodLayout_Click;

                paymentMethodLayout.Tag = paymentMethod;
                paymentMethodLayout.GetPictureBox().Tag = paymentMethod;
                paymentMethodLayout.GetMethodDisplay().Tag = paymentMethod;


                switch (paymentMethod)
                {
                    case PaymentMethod.Card:
                        paymentMethodLayout.Icon = Resources.credit_card;
                        break;
                    case PaymentMethod.Cash:
                        paymentMethodLayout.Icon = Resources.cash;
                        break;
                }

                flpPaymentMethod.Controls.Add(paymentMethodLayout);
            }
        }

        #endregion

        #region Events
        private void PaymentMethodLayout_Click(object? sender, EventArgs e)
        {
            PaymentMethod paymentMethod;
            if (sender is ucPaymentMethod)
            {
                paymentMethod = (PaymentMethod)(sender as ucPaymentMethod).Tag;
            } else if (sender is PictureBox)
            {
                paymentMethod = (PaymentMethod)(sender as PictureBox).Tag;
            } else if (sender is Label)
            {
                paymentMethod = (PaymentMethod)(sender as Label).Tag;
            }
            else
            {
                paymentMethod = PaymentMethod.Cash;
              
            }
            
            Payment payment = new Payment();
            bool isSuccessful = false;

            switch (paymentMethod)
            {
                case PaymentMethod.Card:
                    payment.SetStrategy(new CardPaymentMethod("1234 5678 9012 3456", 278, "07/26"));
                    isSuccessful = payment.MakePayment(totalPrice);

                    break;
                case PaymentMethod.Cash:
                    fCashPayment fCashPayment = new fCashPayment();
                    fCashPayment.ShowDialog();

                    float amountGiven = fCashPayment.AmountGiven;
                    CashPaymentMethod strategy = new CashPaymentMethod(amountGiven);

                    payment.SetStrategy(strategy);

                    isSuccessful = payment.MakePayment(totalPrice);
                    MessageBox.Show("Total change: $" + strategy.Change);

                    break;
            }

            if (isSuccessful)
            {
                InvoiceDAO.Instance.MakePayment(InvoiceID, totalPrice);
                MessageBox.Show("Transaction successful!");

                this.Close();
            }
            else
            {
                MessageBox.Show("Transaction failed!");
            }
        }

        #endregion
    }


}
