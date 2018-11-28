using System;
namespace OOADLabb1Calculator
{
    public class CalculatorDevice
    {
        public static IElectronicDevice GetDevice() 
        {
            return new Calculator();
        }
    }
}
