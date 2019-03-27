using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class SafeAccountProxy : AccountProtected
    {
        public string Password { get; set; }

        public void Deposit(double value)
        {
            throw new NotImplementedException();
        }

        public void DisplayBalance()
        {
            throw new NotImplementedException();
        }

        public void Withdraw(double value)
        {
            throw new NotImplementedException();
        }
    }
}
