using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            SupermarketReport report = new SupermarketReport();

            Customer c = new Customer();

            c.Accept(report);
            report.DisplayResults();

            Product  p = new Product();
            Order o = new Order();
            o.Add(p);
            c.Add(o);

            c.Accept(report);
            report.DisplayResults();
               

        }
    }
}
