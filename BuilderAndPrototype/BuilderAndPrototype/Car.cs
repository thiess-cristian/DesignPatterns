using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAndPrototype
{
    class Car:ICarPrototype
    {
        public Color Color { get; set; }
        public ECarModel Model { get; set; }
        public EEngineType Engine { get; set; }
        public bool IsClone { get; set; }

        public Car Clone()
        {
            Car clone = (Car) this.MemberwiseClone();                 
            clone.IsClone = true;
            return clone;
        }

        public Car DeepClone()
        {
            Car temp = (Car) this.MemberwiseClone();
            temp.Color = new Color(this.Color.Name);
            temp.IsClone = true;
            return temp;
        }

        public override string ToString()
        {
            return "Color:" + Color.Name + " Clone:" + IsClone;
        }
    }
}
