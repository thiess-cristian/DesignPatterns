using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }

        public Product(string name,string description,double price,int count)
        {
            Name = name;
            Description = description;
            Price = price;
            Count = count;
        }


        public override bool Equals(object obj)
        {
            Product p = (Product) obj;
            return Name == p.Name && Description == p.Description && Price == p.Price && Count == p.Count;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return "Name:" + Name + " Description:" + Description + " Price:" + Price + " Count:" + Count;
        }
    }
}
