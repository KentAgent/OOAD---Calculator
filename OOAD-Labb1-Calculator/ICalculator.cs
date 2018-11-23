using System;
namespace OOADLabb1Calculator
{
    public interface ICalculator
    {

        double Sum(double a, double b);

        double Subtract(double a, double b);

        double Multiply(double a, double b);

        double Divide(double a, double b);

        void Equals();

    }
}
