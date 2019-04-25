using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class Client
    {
        public VendingMachine Machine;

        public Client()
        {
            Machine = new VendingMachine();
        }

        public EUserOption GetUserOption()
        {
            EUserOption option=EUserOption.BuyProduct;
            string read = Console.ReadLine();
            int userNumber;
            int.TryParse(read,out userNumber);

            switch (userNumber) {
                case 0:
                    option = EUserOption.InsertCoin;
                    break;
                case 1:
                    option = EUserOption.EjectCoin;
                    break;
                case 2:
                    option = EUserOption.BuyProduct;
                    break;
                case 3:
                    option = EUserOption.FillMachine;
                    break;
                case 4:
                    option = EUserOption.InspectMachine;
                    break;
                case 5:
                    option = EUserOption.Exit;
                    break;
                    
            }
            return option;
        }
        public void ShowMenu()
        {
            Console.WriteLine("0. insert coin");
            Console.WriteLine("1. eject coin");
            Console.WriteLine("2. buy product");
            Console.WriteLine("3. fill machine");
            Console.WriteLine("4. inspect machine");
            Console.WriteLine("5. exit");
        }
    }
}
