using System;
using System.Collections.Generic;
using System.Text;

namespace LPLab08
{
    interface GenericInterface<T>
    {
        void Add(T el);
        void Del(int ind);
        void Show();
    }
}
