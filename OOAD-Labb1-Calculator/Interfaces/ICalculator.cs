using System;
namespace OOADLabb1Calculator
{
    public interface ICalculator
    {
        bool Insert(double a);
        double Add(double a, double b);

        double Subtract(double a, double b);

        double Multiply(double a, double b);

        double Divide(double a, double b);

        void Equals();

    }
}
