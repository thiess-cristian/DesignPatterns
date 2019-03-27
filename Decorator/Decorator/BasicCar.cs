using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class BasicCar : ICar
    {
        public ECarType Type { get; set; }
        public string Color { get; set; }
        public string Motorization { get; set; }
        public int Accessories { get; set; }

        public BasicCar()
        {
            Type = ECarType.BASIC;
            SetAccesories();
        }

        public void Assemble(string color, string motorization)
        {
            Color = color;
            Motorization = motorization;
        }

        public void SetAccesories()
        {
            Accessories += 7800;
        }

        public override string ToString()
        {
            return "Type:" + Type.ToString() + " Color:" + Color + " Motorization:" + Motorization + " Accesories:" + Accessories;
        }
    }
}
