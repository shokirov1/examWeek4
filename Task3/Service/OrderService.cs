using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.Models;

namespace Task3.Service
{
    public class OrderService : IOrderRepository
    {
        private List<Order> orders=new List<Order> { };
        public bool Creat(Order order)
        {
            if(order != null)
            {
                orders.Add(order);
                return true;
            }
            else
            {
                return false;
            }    
        }

        public bool Delete(int id)
        {
            var delete=orders.Find(x => x.Id == id);
            if(delete != null)
            {
                orders.Remove(delete);
                return true;
            }
            else
            { 
                return false; 
            }
        }

        public List<Order> Read()
        {
            return orders;
        }

        public bool Update(Order order)
        {
            var update1=orders.Find(x => x.Id==order.Id);
            if(update1 == null)return false;
            update1.Id =order.Id;
            update1.Price = order.Price;
            update1.OrderName = order.OrderName;
            return true;  
        }
        public Order GetOrderById(int id)
        {
            var oneOrder=orders.Find(x => x.Id == id);
            if(oneOrder!= null)
            {
                return oneOrder;
            }
            else
            {
                return null;
            }
        }
    }
}


