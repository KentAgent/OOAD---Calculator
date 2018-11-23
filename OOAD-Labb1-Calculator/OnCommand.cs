using System;
namespace OOADLabb1Calculator
{
    public class OnCommand : Command
    {

        ElectronicDevice theDevice;

        public OnCommand(ElectronicDevice newDevice)
        {
            theDevice = newDevice;
        }

        public void execute()
        {
            theDevice.On();
        }
    }
}
