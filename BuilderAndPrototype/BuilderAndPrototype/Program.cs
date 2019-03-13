using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAndPrototype
{
    class Program
    {
        static void Main(string[] args)
        {
            CarBuilder builder = new CarBuilder();
            CarBuildDirector director = new CarBuildDirector(builder);

            director.Construct();
            Car car1 = director.GetResult();
            Car carClone = car1.DeepClone();

            carClone.Color.Name="blue";

            Console.WriteLine(car1.ToString());
            Console.WriteLine(carClone.ToString());
        }
    }
}
