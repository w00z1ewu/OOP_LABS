using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LPLab12
{
    class Car : IList<string>
    {
        List<string> details;
        string vehicle = "";

        public string VehicleModel { get { return vehicle; } }
        public int Count
        {
            get
            {
                return details.Count;
            }
        }
        public bool IsReadOnly { get; set; }

        public Car()
        {

        }

        public Car(string veh)
        {
            details = new List<string>();
            vehicle = veh;
        }
        public Car(string veh, params string[] parms)
        {
            details = new List<string>();
            vehicle = veh;
            foreach(string el in parms)
            {
                this.Add(el);
            }
        }

        public override string ToString()
        {
            string ri = "Список всех деталей автомобиля " + vehicle + " : \n";
            foreach(string el in details)
            {
                ri += (el + '\n');
            }
            return ri;
        }

        public int IndexOf(string det)
        {
            for (int i = 0; i < details.Count; i++)
            {
                if (det == details[i]) return i;
            }
            return -1;
        }

        public void Insert(int index, string det)
        {
            if (index < details.Count) details[index] = det;
        }

        public void RemoveAt(int index)
        {
            if (index < details.Count) details.Remove(details[index]);
        }

        public string this[int index]
        {
            get
            {
                return details[index];
            }

            set
            {
                details[index] = value;
            }
        }

        public void Add(string det)
        {
            details.Add(det);
        }

        public void Clear()
        {
            details = new List<string>();
        }

        public bool Contains(string el)
        {
            for (int i = 0; i < details.Count; i++)
            {
                if (details[i] == el) return true;
            }
            return false;
        }

        public void CopyTo(string[] els, int index)
        {
            foreach (string el in els)
            {
                if (index < details.Count) { Insert(index, el); index++; continue; }
                if (index >= details.Count) { Add(el); index++; continue; }
            }
        }

        public bool Remove(string el)
        {
            for (int i = 0; i < details.Count; i++)
            {
                if (details[i] == el) { RemoveAt(i); return true; }
            }
            return false;
        }

        public void Show()
        {
            Console.WriteLine("All the details of a car are:");
            foreach (string el in details)
            {
                Console.WriteLine(el);
            }
        }

        public IEnumerator<string> GetEnumerator()
        {
            return details.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return details.GetEnumerator();
        }
    }
}
