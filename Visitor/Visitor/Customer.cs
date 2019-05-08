using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Customer : IVisitable
    {
        public List<Order> Orders { get; set; }

        public Customer()
        {
            Orders = new List<Order>();
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
            foreach(var order in Orders) {
                order.Accept(visitor);
            }
        }

        public void Add(Order order)
        {
            Orders.Add(order);
        }
    }
}
