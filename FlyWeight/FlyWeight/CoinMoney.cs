using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    public class CoinMoney : Money
    {
        public override EMoneyType GetMoneyType()
        {
            return EMoneyType.Coin;
        }

        public static bool IsSharedValue(double value)
        {
            double[] values = { 0.01, 0.05, 0.10, 0.50 };

            for (int i = 0; i < 4; i++) {
                if (values[i] == value) {
                    return true;
                }
            }
            return false;
        }
    }
}
