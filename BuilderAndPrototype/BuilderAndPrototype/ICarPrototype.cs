using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAndPrototype
{
    interface ICarPrototype
    {
        Car Clone();
    }
}
