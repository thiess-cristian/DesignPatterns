using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class RectangularSocket
    {
        public string GetSupply(string firstWire, string secondWire)
        {
            return "power "+firstWire+" "+secondWire+" ";
        }
    }
}
