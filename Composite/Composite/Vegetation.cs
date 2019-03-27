using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    abstract class Vegetation
    {
        public string Name { get; set; }
        public string ParentName { get; set; }

        public Vegetation(string name,string parentName)
        {
            Name = name;
            ParentName = parentName;
        }

        public abstract void Add(Vegetation vegetation);
        public abstract bool Remove(Vegetation vegetation);
        public abstract void Display(int value);
    }
}
