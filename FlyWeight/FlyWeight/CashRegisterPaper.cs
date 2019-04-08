using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    public class CashRegisterPaper : CashRegister
    {
        public CashRegisterPaper()
        {
        }

        public override Money CreateNewMoney()
        {
            return new PaperMoney();
        }

        public override bool IsSharedValue(double value)
        {            
            return PaperMoney.IsSharedValue(value);
        }
    }
}
