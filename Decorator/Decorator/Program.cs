using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            BasicCar car = new BasicCar();
            car.Assemble("blue", "diesel");
            Console.WriteLine(car.ToString());

            //CarDecorator decorator = new AccessDecorator(new AmbianceDecorator(new LaureateDecorator(car)));           
            //Console.WriteLine(car.ToString());


            LaureateDecorator decorator2 = new LaureateDecorator(car);
            Console.WriteLine(car.ToString());

            
            AmbianceDecorator decorator3 = new AmbianceDecorator(car);
            Console.WriteLine(car.ToString());

            
            AccessDecorator decorator4 = new AccessDecorator(car);
            Console.WriteLine(car.ToString());
        }
    }
}
