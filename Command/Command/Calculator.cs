using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Calculator
    {
        private double _currentValue;

        public void DoOperation(char arithmOperator,double operand)
        {
            var prev = _currentValue;
            switch (arithmOperator) {
                case '+':
                    _currentValue += operand;
                    break;
                case '-':
                    _currentValue -= operand;
                    break;
                case '/':
                    _currentValue /= operand;
                    break;
                case '*':
                    _currentValue *= operand;
                    break;
            }
            Console.WriteLine(prev + arithmOperator.ToString() + operand.ToString() +"="+_currentValue.ToString());
        }
    }
}
