using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ExtendableConsoleApplication
{
    internal class SumCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Enter a, b");
            var result = Sum(Convert.ToDouble(Console.ReadLine()), 
                Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("a + b = {0}", result);
        }

        private double Sum(double a, double b)
        {
            return a + b;
        }

        public string GetCommandDescription()
        {
            return "Command - SUM: Enter a, b to get a + b";
        }
    }
}
