using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class CarDecorator:ICar
    {
        public ICar DecoratedCar { get; set; }
        public ECarType Type { get; set; }
        public string Color { get; set; }
        public string Motorization { get; set; }
        public int Accessories { get; set; }

        public CarDecorator(ICar decoratedCar)
        {
            DecoratedCar = decoratedCar;
        }

        public void Assemble(string color, string motorization)
        {
            DecoratedCar.Assemble(color, motorization);
        }

        public virtual void SetAccesories()
        {
            DecoratedCar.SetAccesories();
        }

        public override string ToString()
        {
            return DecoratedCar.ToString();
        }
    }
}
