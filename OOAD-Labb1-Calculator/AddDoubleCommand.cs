using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADLabb1Calculator
{
    class AddDoubleCommand : IUndoRedo<double>
    {
        private double _value;
        public double Value
        {
            get { return _value; }
            set { _value = value; }
        }
        public AddDoubleCommand()
        {
            _value = 0;
        }
        public AddDoubleCommand(double value)
        {
            _value = value;
        }
        public double Do(double input)
        {
            return input + _value;
        }

        public double Undo(double input)
        {
            return input - _value;
        }
    }
}
