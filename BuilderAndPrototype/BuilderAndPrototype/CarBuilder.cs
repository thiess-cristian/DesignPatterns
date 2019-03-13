using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAndPrototype
{
    class CarBuilder:ICarBuilder
    {
        public Car Car { get; set; }

        public CarBuilder()
        {
            Car = new Car();
        }

        public void SetColor(string color)
        {
            Car.Color = new Color(color);
        }

        public void SetEngine(EEngineType engineType)
        {
            Car.Engine = engineType;
        }

        public void SetModel(ECarModel model)
        {
            Car.Model = model;
        }

        public Car GetCar()
        {
            return Car;
        }
    }
}
