using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class HasCoinState : State
    {
        public override bool BuyProduct()
        {
            return true;
        }

        public override bool Dispense()
        {
            return false;
        }

        public override bool EjectCoin()
        {
            return true;
        }

        public override bool InsertCoin()
        {
            return false;
        }
    }
}
