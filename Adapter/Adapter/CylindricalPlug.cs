using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class CylindricalPlug
    {
        public string FirstWire { get; set; }
        public string SecondWire { get; set; }

        public CylindricalPlug(string firstWire,string secondWire)
        {
            FirstWire = firstWire;
            SecondWire = secondWire;
        }

        public string GetPowerSupply(EAdapterType type)
        {
            string power = "";
            switch (type) {
                case EAdapterType.eClassAdapter:
                    CylindricalClassAdapter classAdapter = new CylindricalClassAdapter();
                    power = classAdapter.GetPowerSupply(FirstWire, SecondWire);
                    break;
                case EAdapterType.eObjectAdapter:
                    CylindricalObjectAdapter objectAdapter = new CylindricalObjectAdapter();
                    power = objectAdapter.GetPowerSupply(FirstWire, SecondWire);
                    break;
                default:
                    break;
            }
            return power;
        }
    }
}
