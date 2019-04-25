using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class CalculatorCommand : ICommand
    {
        static private Calculator _calculator= new Calculator();
        

        public CalculatorCommand()
        {
           
        }

        public CalculatorCommand(char arithmOperator, double operand)
        {
            
            Operator = arithmOperator;
            Operand = operand;
        }

        public override void Execute()
        {
            _calculator.DoOperation(Operator, Operand);
        }

        public override void Reverse()
        {
            if (Operator == '+') {
                Operator = '-';
            } else if (Operator == '-') {
                Operator = '+';
            } else if (Operator == '*') {
                Operator = '/';
            } else if (Operator == '/') {
                Operator = '*';
            }
        }
    }
}
