using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    abstract class ICarFactory
    {
        public static int LastID { get; set; }
        public abstract Car GetCar(int price, string brand, string color);

    }
}
