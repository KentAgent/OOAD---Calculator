﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADLabb1Calculator
{
    class InputCommand<T> : ICommand
    {
        ICalculator calc;
        public InputCommand(ICalculator calcu)
        {
            calc = calcu;
        }
        public void Execute()
        {
        }
    }
}
