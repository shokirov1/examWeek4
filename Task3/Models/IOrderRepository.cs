using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Models
{
    public interface IOrderRepository
    {
        public bool Creat(Order order);
        public List<Order> Read();
        public bool Update(Order order);
        public bool Delete(int id);
    }
}
