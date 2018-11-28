using System;

namespace OOADLabb1Calculator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*
            IElectronicDevice newDevice = CalculatorDevice.GetDevice();
            OnCommand onCommand = new OnCommand(newDevice);
            DeviceButton onPressed = new DeviceButton(onCommand);
            onPressed.Press();
            */

            ICalculator calc = CalculatorDevice.Calculator;
            InputCommand<double> inputCommand = new InputCommand<double>(calc);
            DeviceButton onClick = new DeviceButton(inputCommand);
         
            onClick.Press();


            /*

            // Turn Device On
            

            // Turn Device Off

            OffCommand offCommand = new OffCommand(newDevice);

            onPressed = new DeviceButton(offCommand);

            onPressed.press();
            */
           

            Console.ReadLine();
            
        }
    }
}
