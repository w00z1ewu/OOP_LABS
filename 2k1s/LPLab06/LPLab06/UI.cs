using System;
using System.Collections.Generic;
using System.Text;

namespace LPLab06
{
    class UI
    {
        public List<ControlElement> list = new List<ControlElement>();

        public int Size { get { return list.Count; } }

        public object Get(int index)
        {
            if (index < list.Count) return list[index]; else return null;
        }

        public void Set(int index, ControlElement newEl)
        {
            list.Insert(index, newEl);
        }

        public void Add(ControlElement el)
        {
            list.Add(el);
        }

        public void Del(int index)
        {
            list.Remove(list[index]);
        }

        public void PrintList()
        {
            foreach(ControlElement el in list)
            {
                Console.WriteLine(el.ToString());;
            }
        }
    }
}
