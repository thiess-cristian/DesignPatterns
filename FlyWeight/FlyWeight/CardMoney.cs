using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    public class CardMoney : Money
    {
        public CardMoney()
        {
        }

        public override EMoneyType GetMoneyType()
        {
            return EMoneyType.Card;
        }

        public static bool IsSharedValue(double value)
        {
            return false;
        }
    }
}
