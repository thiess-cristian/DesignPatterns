using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Order : IVisitable
    {
        public string Name { get; set; }

        public List<Product> Products { get; set; }

        public Order()
        {
            Products = new List<Product>();
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);

            foreach(var product in Products) {
                product.Accept(visitor);
            }
        }

        public void Add(Product product)
        {
            Products.Add(product);
        }
    }
}
