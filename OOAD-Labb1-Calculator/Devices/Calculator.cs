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
            while (PowerOn)
            {
                ICalculator calc = CalculatorDevice.Calculator;
                InputCommand<double> inputCommand = new InputCommand<double>(calc);
                DeviceButton onClick = new DeviceButton(inputCommand);

                Console.WriteLine("Enter number: ");
                double input1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Chose an operator. ( +  -  /  *  = ) or undo by entering UNDO");
                string op = Console.ReadLine();
                switch (op)
                {
                    case "+":
                        AddDoubleCommand command = new AddDoubleCommand(input1);
                        count = stackHandler.Do(command, count);
                        break;
                    case "-":
                        break;
                    case "/":
                        break;
                    case "=":
                        break;
                    case "UNDO":
                        break;
                    default:
                        Console.WriteLine("Dont be a retard. Select a valid operator");
                        break;
                }
                Console.WriteLine(" Count: " + count);
            }
            


            Console.WriteLine("Do u want to undo this?");

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
