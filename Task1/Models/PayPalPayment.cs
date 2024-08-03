using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Models
{
    public class PayPalPayment : IPaymentMethod
    {
        public void Pay(decimal amount)
        {
            try
            {
                if (amount != null)
                {
                    Console.WriteLine("You used PayPalPayment");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
