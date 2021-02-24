using System;
using System.Collections.Generic;
using System.Text;

namespace LPLab05
{
    static class Printer
    {
        public static void IAmPrinting(ControlElement obj)
        {
            Console.WriteLine(obj.ToString());
        }
    }
}
