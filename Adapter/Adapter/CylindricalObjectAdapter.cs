using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class CylindricalObjectAdapter
    {
        private RectangularSocket _socket;

        public CylindricalObjectAdapter()
        {
            _socket = new RectangularSocket();
        }

        public string GetPowerSupply(string firstWire,string secondWire)
        {
            return _socket.GetSupply(firstWire, secondWire) + "from object adapter";
        }
    }
}
