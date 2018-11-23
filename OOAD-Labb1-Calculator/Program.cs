using System;

namespace OOADLabb1Calculator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ElectronicDevice newDevice = CalculatorDevice.GetDevice();

            OnCommand onCommand = new OnCommand(newDevice);

            DeviceButton onPressed = new DeviceButton(onCommand);

            onPressed.press();
        }
    }
}
