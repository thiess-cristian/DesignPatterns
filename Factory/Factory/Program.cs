using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            CarDealer carDealer = new CarDealer();

            int car1id = carDealer.OrderCar(25000, "dacia", "gri", ECarType.EAuto);
            int car2id = carDealer.OrderCar(25000, "dacia", "gri", ECarType.EAuto);
            int car3id = carDealer.OrderCar(25000, "dacia", "gri", ECarType.EAuto);
            int truck1id = carDealer.OrderCar(5000, "man", "grid", ECarType.ETruck);

            carDealer.StockCar();

            carDealer.DriveTest(car2id);
            carDealer.StockCar();

            carDealer.DriveTest(car2id);
            carDealer.StockCar();

            Car soldCar=carDealer.SellCar(car1id);
            Console.WriteLine(soldCar.ToString());

        }
    }
}
