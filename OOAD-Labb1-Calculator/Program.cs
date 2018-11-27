using System;

namespace OOADLabb1Calculator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*
            ElectronicDevice newDevice = CalculatorDevice.GetDevice();

            // Turn Device On

            OnCommand onCommand = new OnCommand(newDevice);

            DeviceButton onPressed = new DeviceButton(onCommand);

            onPressed.press();

            // Turn Device Off

            OffCommand offCommand = new OffCommand(newDevice);

            onPressed = new DeviceButton(offCommand);

            onPressed.press();
            */
            StackHandler<double> stackHandler = new StackHandler<double>();
            double count = 0;

            count = stackHandler.Do(new AddDoubleCommand(10), count);
            count = stackHandler.Do(new AddDoubleCommand(11), count);
            count = stackHandler.Do(new AddDoubleCommand(12), count);
            count = stackHandler.Do(new AddDoubleCommand(13), count);
            Console.WriteLine(count);

            count = stackHandler.Undo(count);
            count = stackHandler.Undo(count);

            Console.WriteLine(count);
            Console.ReadLine();

        }
    }
}
