using System;
namespace OOADLabb1Calculator
{
    public class DeviceButton
    {

        ICommand theCommand;

        public DeviceButton(ICommand newCommand)
        {
            theCommand = newCommand;
        }

        public void Press() 
        {
            theCommand.Execute();
        }
    }
}
