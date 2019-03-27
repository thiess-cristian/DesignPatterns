using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class AccessDecorator : CarDecorator
    {
        public AccessDecorator(ICar decoratedCar) : base(decoratedCar)
        {
            DecoratedCar.Type = ECarType.ACCESS;
            SetAccesories();
        }

        public override void SetAccesories()
        {
            DecoratedCar.Accessories += 700;
        }

    }
}
