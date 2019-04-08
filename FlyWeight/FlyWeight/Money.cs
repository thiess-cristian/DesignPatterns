using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    public abstract class Money
    {
        public double TotalCashValue { get; set; }

        public abstract EMoneyType GetMoneyType();        
    }
}
