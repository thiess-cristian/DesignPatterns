using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Client
    {
        private CalculatorInvoker _calculatorInvoker;

        public Client()
        {
            _calculatorInvoker = new CalculatorInvoker();
        }

        public void Compute(char arithmOperator, double operand)
        {
            _calculatorInvoker.Compute(arithmOperator, operand);            
        }
        
    }
}
