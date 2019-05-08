using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products1=new List<Product>();
            Product p1 = new Product("Paine", "mancare", 3.00, 2);
            Product p2 = new Product("Zahar", "mancare", 12.12, 2);
            Product p3 = new Product("Apa", "apa plata", 2.23, 20);
            Product p4 = new Product("Mere", "mancare", 12.12, 2000);

            products1.Add(p1);
            products1.Add(p2);
            products1.Add(p3);

            List<Product> products2 = new List<Product>();
            
            products2.Add(p1);
            products2.Add(p4);
            

            ISubscriber sub1 = new Subscriber("sub1");
            ISubscriber sub2 = new Subscriber("sub2");
            ISubscriber sub3 = new Subscriber("sub3");

            OnlineStore store = new OnlineStore();
            store.Subscribe(sub1);
            store.Subscribe(sub2);
            store.Subscribe(sub3);

            store.AddProducts(products1);
            
            Console.WriteLine("");

            store.AddProducts(products2);          
        }
    }
}
