using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class AccountProtected : IAccount
    {
        public double Balance { get; set; }

        public void Deposit(double value)
        {
            Balance += value;
        }

        public void DisplayBalance()
        {
            Console.WriteLine(Balance);
        }

        public void Withdraw(double value)
        {
            Balance -= value;
        }
    }
}
