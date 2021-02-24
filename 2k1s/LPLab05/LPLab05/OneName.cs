using System;
using System.Collections.Generic;
using System.Text;

namespace LPLab05
{
    abstract class COneNameBase
    {
        abstract public void onename();
    }

    class COneName : COneNameBase, IOneName
    {
        override public void onename()
        {
            Console.WriteLine("AbsClass");
        }

        void IOneName.onename()
        {
            Console.WriteLine("Interface");
        }
    }

    interface IOneName
    {
        void onename();
    }
}
