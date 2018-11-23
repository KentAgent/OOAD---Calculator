using System;
namespace OOADLabb1Calculator
{
    public class SumCommand : Command
    {

        Calculator theCalc;

        public SumCommand(Calculator newCalc)
        {
            theCalc = newCalc;
        }

        public void execute()
        {
            theCalc.Sum(1, 2);
        }
    }
}
