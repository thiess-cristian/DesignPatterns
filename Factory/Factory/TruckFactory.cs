using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class TruckFactory:ICarFactory
    {
        public override Car GetCar(int price, string brand, string color)
        {
            LastID++;
            return new Truck(LastID, price, brand, color);
        }

    }
}
