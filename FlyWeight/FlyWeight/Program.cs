using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    class Program
    {
        static void Main(string[] args)
        {
            Cashier cashier = new Cashier();
            
            cashier.CashIn(10.0, EMoneyType.Paper);
            cashier.CashIn(0.01, EMoneyType.Coin);
            //cashier.CashIn(0.02, EMoneyType.Coin);
            cashier.CashIn(123.0, EMoneyType.Card);
            
            Console.WriteLine(cashier.GetTotalCash());

        }
    }
}
