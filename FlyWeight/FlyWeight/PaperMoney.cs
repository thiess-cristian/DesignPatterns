using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    public class PaperMoney : Money
    {
        public override EMoneyType GetMoneyType()
        {
            return EMoneyType.Paper;
        }

        public static bool IsSharedValue(double value)
        {
            double[] values = { 1.0, 5.0, 10.0, 50.0, 100.0, 200.0, 500.0 };
            
            for(int i = 0; i < 7; i++) {
                if (values[i] == value) {
                    return true;
                }
            }
            return false;
        }
    }
}
