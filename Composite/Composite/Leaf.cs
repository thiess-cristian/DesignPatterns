using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Leaf : Vegetation
    {
        public Leaf(string name, string parentName) : base(name, parentName)
        {
        }

        public override void Add(Vegetation vegetation)
        {
            Console.WriteLine("NO ADD ON LEAFS");
        }

        public override void Display(int value)
        {
            string str = "";
            for(int i = 0; i < value; i++) {
                str += "*";
            }
            Console.WriteLine(str);           
        }

        public override bool Remove(Vegetation vegetation)
        {
            Console.WriteLine("NO REMOVE ON LEAFS");
            return false;
        }
    }
}
