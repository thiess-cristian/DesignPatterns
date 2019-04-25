using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {

            VendingMachine vendingMachine = new VendingMachine();
            vendingMachine.SetMachineState(vendingMachine.NoCoinState);
            Client client = new Client();
            client.Machine = vendingMachine;

            EUserOption option;
            do {
                client.ShowMenu();
                option = client.GetUserOption();
                client.Machine.UpdateState(option);
                Console.WriteLine("");
                
            } while (option != EUserOption.Exit);
        }
    }
}
