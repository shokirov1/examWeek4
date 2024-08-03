using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Models;

namespace Task1.Service
{
    public class PaymentProcessor : IPaymentMethod
    {
        private IPaymentMethod paymentMethod; 

        public PaymentProcessor(IPaymentMethod _paymentMethod)
        {
            paymentMethod = _paymentMethod;
            
        }
        public void Pay(decimal amount)
        {
            paymentMethod.Pay(amount);
        }
    }
}
