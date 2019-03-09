using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Truck : Car
    {
        public Truck(int id, int price, string brand, string color):base(id,price,brand,color)
        {
        }

        public override ECarType Type()
        {
            return ECarType.ETruck;
        }

        public override string ToString()
        {
            return base.ToString() + " type: Truck";
        }
    }
}
