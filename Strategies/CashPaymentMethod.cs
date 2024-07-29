using RestaurantIS.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantIS.Strategies
{
    public class CashPaymentMethod : IPaymentMethodStrategies
    {
        private float amountGiven;
        private float change;

        public CashPaymentMethod(float amountGiven)
        {
            AmountGiven = amountGiven;
            Change = 0;
        }

        public float AmountGiven { get => amountGiven; set => amountGiven = value; }
        public float Change { get => change; set => change = value; }

        public bool MakePayment(float amount)
        {
            if (AmountGiven >= amount)
            {
                Change = AmountGiven - amount;
                decimal decimalValue = Math.Round((decimal)Change, 2);

                Change = (float)decimalValue;

                return true;
            } else
            {
                return false;
            }
        }
    }
}
