using System;
namespace OOADLabb1Calculator
{
    public class SumCommand : ICommand
    {

        Calculator theCalc;

        public SumCommand(Calculator newCalc)
        {
            theCalc = newCalc;
        }

        public void Execute()
        {
            theCalc.Add(1, 2);
        }
        
    }
}
