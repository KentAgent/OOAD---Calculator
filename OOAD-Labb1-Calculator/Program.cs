using System;

namespace OOADLabb1Calculator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ElectronicDevice newDevice = CalculatorDevice.GetDevice();

            // Turn Device On

            OnCommand onCommand = new OnCommand(newDevice);

            DeviceButton onPressed = new DeviceButton(onCommand);

            onPressed.press();

            // Turn Device Off

            OffCommand offCommand = new OffCommand(newDevice);

            onPressed = new DeviceButton(offCommand);

            onPressed.press();
        }
    }
}
