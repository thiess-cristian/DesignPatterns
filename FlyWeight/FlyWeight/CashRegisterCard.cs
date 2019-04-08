using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    public class CashRegisterCard : CashRegister
    {
        public CashRegisterCard()
        {
            
        }

        public override Money CreateNewMoney()
        {
            return new CardMoney();
        }

        public override bool IsSharedValue(double value)
        {            
            return CardMoney.IsSharedValue(value);
        }
    }
}
