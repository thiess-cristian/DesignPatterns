using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorInvoker client = new CalculatorInvoker();

            client.Compute('+', 12);
            client.Compute('+', 12);
            client.Compute('/', 3);
            client.Compute('*', 3);
            client.Compute('-', 3);

            Console.WriteLine("undos: ");
            client.Undo();
            client.Undo();
            client.Undo();
            client.Undo();
            client.Undo();

            Console.WriteLine("redos: ");
            client.Redo();
            client.Redo();
            client.Redo();
            client.Redo();
            
        }
    }
}
