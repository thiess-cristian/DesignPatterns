using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Automobil : Car
    {
        public override ECarType Type()
        {
            return ECarType.EAuto;
        }

        public Automobil(int id, int price, string brand, string color) : base(id, price, brand, color)
        {

        }

        public override string ToString()
        {
            return base.ToString() + " type: Auto";
        }
    }
}
