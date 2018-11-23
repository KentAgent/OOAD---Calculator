using System;
namespace OOADLabb1Calculator
{
    public class CalculatorDevice
    {
        public static ElectronicDevice GetDevice() 
        {
            return new Calculator();
        }
    }
}
