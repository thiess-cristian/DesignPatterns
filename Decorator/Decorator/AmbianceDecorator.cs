using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class AmbianceDecorator:CarDecorator
    {
        public AmbianceDecorator(ICar decoratedCar) : base(decoratedCar)
        {
            DecoratedCar.Type = ECarType.AMBIACE;
            SetAccesories();
        }

        public override void SetAccesories()
        {
            
            DecoratedCar.Accessories += 900;
        }
    }
}
