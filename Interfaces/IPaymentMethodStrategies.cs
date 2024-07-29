using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantIS.Interfaces
{
    public interface IPaymentMethodStrategies
    {
        public bool MakePayment(float amount);
    }
}
