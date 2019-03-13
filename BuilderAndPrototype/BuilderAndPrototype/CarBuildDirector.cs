using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAndPrototype
{
    class CarBuildDirector
    {
        public ICarBuilder CarBuilder { get; set; }

        public CarBuildDirector(ICarBuilder carbuilder)
        {
            CarBuilder = carbuilder;
        }

        public void Construct(string color,ECarModel carModel,EEngineType engineType)
        {
            CarBuilder.SetColor(color);
            CarBuilder.SetEngine(engineType);
            CarBuilder.SetModel(carModel);
        }

        public void Construct()
        {
            CarBuilder.SetColor("green");
            CarBuilder.SetEngine(EEngineType.EDiesel);
            CarBuilder.SetModel(ECarModel.ECrossover);
        }

        public Car GetResult()
        {
            return CarBuilder.GetCar();
        }

    }
}
