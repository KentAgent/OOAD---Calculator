using System;
namespace OOADLabb1Calculator
{
    public class OnCommand : ICommand
    {

        IElectronicDevice theDevice;

        public OnCommand(IElectronicDevice newDevice)
        {
            theDevice = newDevice;
        }

        public void Execute()
        {
            theDevice.On();
        }
    }
}
