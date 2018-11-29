using System;

namespace OOADLabb1Calculator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            
            IElectronicDevice newDevice = CalculatorDevice.GetDevice();
            OnCommand onCommand = new OnCommand(newDevice);
            DeviceButton onPressed = new DeviceButton(onCommand);
            Console.WriteLine("Do u want to start the calculator? yes/no");
            string answer = Console.ReadLine();
            if (answer.ToUpper() == "YES")
            {
                onPressed.Press();
            }
            
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
