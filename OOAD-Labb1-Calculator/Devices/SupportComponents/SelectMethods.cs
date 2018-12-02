using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADLabb1Calculator.Devices.SupportComponents
{
    class SelectMethods
    {
        public static string SelectOperation()
        {
            string op;
            do
            {
                Console.WriteLine("Choose a valid operator. ( +  -  /  *  = ) , undo by entering UNDO or REDO to redo");
                op = Console.ReadLine();
            } while (!CheckValidOperator(op));
            return op;
        }

        private static bool CheckValidOperator(string op)
        {
            if (op == "+" || op == "-" || op == "/" || op == "*" || op.ToUpper() == "UNDO" || op.ToUpper() == "REDO")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
