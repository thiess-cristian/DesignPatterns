using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    interface IAccount
    {
        void Deposit(double value);
        void Withdraw(double value);
        void DisplayBalance();

    }
}
