using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Models
{
    public interface IPaymentMethod
    {
        public void Pay(decimal amount);
    }
}
