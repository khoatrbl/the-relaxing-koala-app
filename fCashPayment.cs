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
    public partial class fCashPayment : Form
    {
        private float amountGiven;
        public fCashPayment()
        {
            InitializeComponent();
        }

        public float AmountGiven { get => amountGiven; set => amountGiven = value; }

        private void paymentConfirmBtn_Click(object sender, EventArgs e)
        {
            amountGiven = (float)Convert.ToDouble(txbAmountGiven.Text);
            this.Close();
        }
    }
}
