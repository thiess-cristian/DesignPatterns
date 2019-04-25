using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    abstract class State
    {
        public VendingMachine Machine { get; set; }

        public abstract bool InsertCoin();
        public abstract bool EjectCoin();
        public abstract bool BuyProduct();
        public abstract bool Dispense();
    }
}
