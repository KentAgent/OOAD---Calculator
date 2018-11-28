using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADLabb1Calculator
{
    class InputCommand<T> : ICommand
    {
        ICalculator calc;
        public InputCommand(ICalculator calcu)
        {
            calc = calcu;
        }
        public void Execute()
        {
            //Tvek
            Console.WriteLine("Type a : ");
            string a = Console.ReadLine();
            string b = Console.ReadLine();

            try
            {
                double a2 = Convert.ToDouble(a);
                double b2 = Convert.ToDouble(b);
                calc.Add(a2, b2);
            }
            catch (Exception e)
            {

            }
        }
    }
}
