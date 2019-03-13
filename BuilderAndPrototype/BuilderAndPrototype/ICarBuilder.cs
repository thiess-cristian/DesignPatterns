using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAndPrototype
{
    interface ICarBuilder
    {
        void SetModel(ECarModel model);
        void SetColor(string color);
        void SetEngine(EEngineType engineType);
        Car GetCar();
    }
}
