using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Tree : Branch
    {
        public Tree(string name, string parentName) : base(name, parentName)
        {
        }

        public void Display(int value)
        {
            //Console.WriteLine("tree"+name         );
            base.Display(value+1);
        }
    }
}
