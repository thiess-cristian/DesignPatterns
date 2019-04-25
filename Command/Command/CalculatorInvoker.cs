using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class CalculatorInvoker
    {
        private ICommand _calculatorCommand;
        private List<ICommand> _inputs;
        private int _index;

        public CalculatorInvoker()
        {
            _calculatorCommand = new CalculatorCommand();
            _inputs = new List<ICommand>();
            _index = 0;
        }

        public void Compute(char arithmOperator, double operand)
        {
            _calculatorCommand.Operator = arithmOperator;
            _calculatorCommand.Operand = operand;
            _calculatorCommand.Execute();

            _inputs.Add(new CalculatorCommand(arithmOperator, operand));

            _index++;
        }

        public void Undo()
        {
            ICommand input = _inputs.ElementAt(_index-1);
            input.Reverse();
            input.Execute();
            _index--;
        }

        public void Redo()
        {
            ICommand input = _inputs.ElementAt(_index);
            input.Reverse();
            input.Execute();
            _index++;
        }

    }
}
