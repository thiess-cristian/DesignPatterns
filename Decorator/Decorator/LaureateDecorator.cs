using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class LaureateDecorator : CarDecorator
    {
        public LaureateDecorator(ICar decoratedCar) : base(decoratedCar)
        {
            DecoratedCar.Type = ECarType.LAUREATE;
            SetAccesories();
        }

        public override void SetAccesories()
        {
            DecoratedCar.Accessories += 1100;
        }
    }
}
