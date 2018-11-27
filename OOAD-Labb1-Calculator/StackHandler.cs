using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace OOADLabb1Calculator
{
    class StackHandler
    {
        public StackHandler()
        {
            _stack = new Stack();
        }
        Stack _stack;
        Stack Stack
        {
            get
            {
                return _stack;
            }
        }
        public bool Insert(Command command)
        {
            return true;
        }
    }
}
