using RestaurantIS.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantIS.DTO
{
    public class Payment
    {
        private IPaymentMethodStrategies strategies;

        public Payment() { }

        public Payment(IPaymentMethodStrategies paymentMethodStrategies)
        {
            Strategies = paymentMethodStrategies;
        }

        public void SetStrategy(IPaymentMethodStrategies paymentMethodStrategies)
        {
            Strategies = paymentMethodStrategies;
        }

        public bool MakePayment(float amount)
        {
            return Strategies.MakePayment(amount);
        }

        public IPaymentMethodStrategies Strategies { get => strategies; set => strategies = value; }


    }
}
