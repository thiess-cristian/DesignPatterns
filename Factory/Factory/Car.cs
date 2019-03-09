using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    abstract class Car
    {
        public int ID { get; set; }
        public int Price { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public int Kilometers { get; set; }

        public abstract ECarType Type();

        public Car(int id,int price, string brand, string color)
        {
            ID = id;
            Price = price;
            Brand = brand;
            Color = color;
        }

        public override string ToString()
        {
            return "id:" + ID + " brand:" + Brand + " color:" + Color + " price:" + Price + " km:" + Kilometers;
        }

    }
}
