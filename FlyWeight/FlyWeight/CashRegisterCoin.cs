using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    public class CashRegisterCoin : CashRegister
    {
        public  CashRegisterCoin()
        {

        }

        public override Money CreateNewMoney()
        {
            return new CoinMoney();
        }

        public override bool IsSharedValue(double value)
        {            
            return CoinMoney.IsSharedValue(value);
        }
    }
}
