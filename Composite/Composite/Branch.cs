using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Branch : Vegetation
    {
        public List<Vegetation> Children { get; set; }

        public Branch(string name, string parentName) : base(name, parentName)
        {
            Children = new List<Vegetation>();
        }

        public override void Add(Vegetation vegetation)
        {
            Children.Add(vegetation);
        }

        public override void Display(int value)
        {
            string str = "";
            for (int i = 0; i < value; i++) {
                str += "*";
            }
            Console.WriteLine(str);

            foreach (Vegetation child in Children) {
                child.Display(value+1);
            }
        }

        public override bool Remove(Vegetation vegetation)
        {
            if (Children.Contains(vegetation)) {
                Children.Remove(vegetation);
                return true;
            } else {
                return false;
            }
        }
    }
}
