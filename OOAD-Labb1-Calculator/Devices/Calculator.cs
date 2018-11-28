using System;
namespace OOADLabb1Calculator
{
    public class Calculator : ICalculator, IElectronicDevice
    {
        StackHandler<double> stackHandler = new StackHandler<double>();
        double count = 0;

        public bool Insert(double a)
        {
            return false;
        }

        public double Divide(double a, double b)
        {
            return a / b;
        }

        public void Equals()
        {
            
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public void Off()
        {
            Console.WriteLine("You turned the calculator off");
        }

        public void On()
        {
            Console.WriteLine("You turned the calculator on");
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Add(double a, double b)
        {
            count = stackHandler.Do(new AddDoubleCommand(a), count);
            count = stackHandler.Do(new AddDoubleCommand(b), count);
            Console.WriteLine(count);

            /*count = stackHandler.Undo(count);
            count = stackHandler.Undo(count);
            stackHandler.Redo(count);
            */
            return count;
        }
    }
}
