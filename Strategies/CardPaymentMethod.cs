using RestaurantIS.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantIS.Strategies
{
    public class CardPaymentMethod : IPaymentMethodStrategies
    {
        private string cardNumber;
        private int cvv;
        private string expDate;

        public CardPaymentMethod(string cardNumber, int cvv, string expDate)
        {
            this.cardNumber = cardNumber;
            this.cvv = cvv;
            this.expDate = expDate;
        }

        public string CardNumber { get => cardNumber; set => cardNumber = value; }
        public int Cvv { get => cvv; set => cvv = value; }
        public string ExpDate { get => expDate; set => expDate = value; }

        public bool MakePayment(float amount)
        {
            // Deduct money from account: 
            // check if (expDate > today)
            // Check if (account's money > amount)
            // if true -> deduct(account.money, amount)
            // if false -> messageBox

            return true;
        }
    }
}
