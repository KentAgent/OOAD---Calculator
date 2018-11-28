using System;
namespace OOADLabb1Calculator
{
    public class OffCommand : ICommand
    {

        IElectronicDevice theDevice;

        public OffCommand(IElectronicDevice newDevice)
        {
            theDevice = newDevice;
        }

        public void Execute()
        {
            theDevice.Off();
        }
    }
}
