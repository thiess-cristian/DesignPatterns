using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class SoldState : State
    {
        public override bool BuyProduct()
        {
            return false;
        }

        public override bool Dispense()
        {
            return true;
        }

        public override bool EjectCoin()
        {
            return false;            
        }

        public override bool InsertCoin()
        {
            return true;
        }
    }
}
