using System;
namespace OOADLabb1Calculator
{
    public class OffCommand : Command
    {

        ElectronicDevice theDevice;

        public OffCommand(ElectronicDevice newDevice)
        {
            theDevice = newDevice;
        }

        public void Execute()
        {
            theDevice.Off();
        }
    }
}
