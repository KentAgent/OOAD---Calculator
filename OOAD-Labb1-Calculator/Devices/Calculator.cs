using OOADLabb1Calculator.Devices.SupportComponents;
using System;
namespace OOADLabb1Calculator
{
    public class Calculator : ICalculator, IElectronicDevice
    {
        StackHandler<double> stackHandler = new StackHandler<double>();
        double count = 0;
        private bool PowerOn = false;

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
            PowerOn = true;
            Running();
        }
        private void Running()
        {
            double input2 = 0;
            string initOperation = "+";

            Console.WriteLine("Enter number: ");
            double input1 = Convert.ToDouble(Console.ReadLine());
            PerformOperation(input1, initOperation);

            while (PowerOn)
            {
                /*  Might use this in a future implementation
                 * ICalculator calc = CalculatorDevice.Calculator;
                InputCommand<double> inputCommand = new InputCommand<double>(calc);
                DeviceButton onClick = new DeviceButton(inputCommand); 
                */

                string op = SelectMethods.SelectOperation();
                if (op == "UNDO" || op == "REDO")
                {
                    input2 = count;
                } else 
                {
                    Console.WriteLine("Enter number: ");
                    input2 = Convert.ToDouble(Console.ReadLine());
                }
                    PerformOperation(input2, op);
                    Console.WriteLine(" Count: " + count);
            }
        }

        private void PerformOperation(double input, string op)
        {
            switch (op)
            {
                case "+":
                    AddDoubleCommand command = new AddDoubleCommand(input);
                    count = stackHandler.Do(command, count);
                    break;
                case "-":
                    break;
                case "/":
                    break;
                case "=":
                    break;
                case "UNDO":
                    count = stackHandler.Undo(count);
                    Console.WriteLine("You undid");
                    break;
                case "REDO":
                    count = stackHandler.Redo(count);
                    Console.WriteLine("You redid");
                    break;
                default:
                    break;
            }
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
