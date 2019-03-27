using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree("t","");

            Branch branch1 = new Branch("b1", "t");

            Branch branch11 = new Branch("b11", "b1");
            Branch branch12 = new Branch("b12", "b1");

            branch1.Add(branch11);
            branch1.Add(branch12);

            Leaf leaf1 = new Leaf("l1", "b11");
            Leaf leaf2 = new Leaf("l1", "b11");
            Leaf leaf3 = new Leaf("l1", "b11");

            branch11.Add(leaf1);
            branch12.Add(leaf2);
            branch12.Add(leaf3);

            tree.Add(branch1);

            tree.Display(0);
        }
    }
}
