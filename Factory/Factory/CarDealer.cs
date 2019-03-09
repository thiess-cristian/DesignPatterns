using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class CarDealer
    {
        public Dictionary<int,Car> OrderedCars { get; set; }
        public Dictionary<int, Car> TestDriveCars { get; set; }

        public CarDealer()
        {
            OrderedCars = new Dictionary<int, Car>();
            TestDriveCars = new Dictionary<int, Car>();
        }

        public int OrderCar(int price,string brand,string color,ECarType type)
        {
            Car car=null;
            if (type == ECarType.EAuto) {
                AutomobilFactory factory = new AutomobilFactory();
                car = factory.GetCar(price, brand, color);
            } else {
                TruckFactory factory = new TruckFactory();
                car = factory.GetCar(price, brand, color);
            }
            OrderedCars[car.ID] = car;
            return car.ID;
        }

        public Car SellCar(int id)
        {
            Car car = null;
            string msg;
            if (OrderedCars.ContainsKey(id)) {
                car = OrderedCars[id];
                OrderedCars.Remove(id);            
                msg = "car sold:" + car.ToString();
            } else {
                msg = "not foundl";
            }
            Console.WriteLine(msg);
            return car;
        }

        public Car DriveTest(int id)
        {
            Car car = null;
            if (OrderedCars.ContainsKey(id)) {
                car = OrderedCars[id];
                TestDriveCars[id] = car;
                OrderedCars.Remove(id);
            } else if (TestDriveCars.ContainsKey(id)) {
                car= TestDriveCars[id];
            }

            if (car != null) {
                car.Kilometers += 20;
            }
            return car;
        }

        public void StockCar()
        {
            Console.WriteLine("Ordered cars");
            foreach (KeyValuePair<int, Car>  car in OrderedCars) {
                Console.WriteLine(car.Value.ToString());
            }
            Console.WriteLine("test drive cars");
            foreach (KeyValuePair<int, Car> car in TestDriveCars) {
                Console.WriteLine(car.Value.ToString());
            }
            Console.WriteLine("");
        }
    }
}
