using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    abstract class ICommand
    {
        public char Operator { get; set; }
        public double Operand { get; set; }

        public abstract void Execute();
        public abstract void Reverse();

    }
}
