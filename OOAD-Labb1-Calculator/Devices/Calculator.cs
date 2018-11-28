using System;
namespace OOADLabb1Calculator
{
    public class Calculator : ICalculator, IElectronicDevice
    {

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

        public double Sum(double a, double b)
        {
            return a + b;
        }
    }
}
