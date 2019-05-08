using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class SupermarketReport : IVisitor
    {
        public int ProductNo { get; set; }
        public int OrderNo { get; set; }
        public int CustomerNo { get; set; }
        public double TotalPrice { get; set; }

        public void Visit(Product product)
        {
            ProductNo++;
        }

        public void Visit(Order order)
        {
            OrderNo++;
        }

        public void Visit(Customer customer)
        {
            CustomerNo++;
        }
        public void DisplayResults()
        {
            Console.WriteLine("product nr:" + ProductNo + " order nr:" + OrderNo + " customer nr:" + CustomerNo);
        }
    }
}
