using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace LP_Lab04
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                OD_Array<int> newArray = new OD_Array<int>(1, 1, 0, 1, 1, 1, 1, 0);
                OD_Array<int> addArray = new OD_Array<int>(0, 1, 2, 3, 4, 5 ,6, 7, 8, 9, 10, 11, 12);
                addArray.Delete(0, 1);
                Console.WriteLine(addArray.ToString() + "size:" + addArray.Size.ToString());
                Console.WriteLine(addArray.RemoveFiveElements());
                Console.WriteLine(2 < newArray);

                string teststr = "Мама мыла раму.";
                Console.WriteLine(teststr +  " => " + teststr.VowelsDelete());
                Console.WriteLine(OD_Array<int>.Date.DateAndTime.ToString());
                Console.WriteLine(OD_Array<int>.Owner.Id.ToString() + '\n' + OD_Array<int>.Owner.Name + '\n' + OD_Array<int>.Owner.Company);
                Console.WriteLine(StatisticOperation.TotalAmount());
            

            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }
    }

    public class OD_Array<T>
    {
        internal List<T> array = new List<T>();
        int size = 0;

        public int Size { get { return size; } }
        public OD_Array()
        {
            StatisticOperation.amount++;
        }

        public OD_Array(params T[] parms)
        {
            StatisticOperation.amount++;

            foreach(T el in parms)
            {
                Add(el);
            }
        }

        public void Add(T el)
        {
            array.Add(el);
            size++;
        }

        public void Add(params T[] parms)
        {
            foreach (T el in parms)
            {
                Add(el);
            }
        }

        public void Add(OD_Array<T> arr)
        {
            for(int i = 0; i < arr.Size; i++)
            {
                Add(arr.GetEl(i));
            }
        }

        public void Delete(int index)
        {
            
            List<T> buff = new List<T>();
            for (int i = 0; i < index && i < Size; i++) 
            {
                buff.Add(array[i]);
            }
            array = buff;
        }

        public void Delete(int index, int count)
        {
            List<T> buff = new List<T>();
            for (int i = 0; i < index  && i < Size; i++)
            {
                buff.Add(array[i]);
            }
            for (int i = index + count; i < Size; i++)
            {
                buff.Add(array[i]);
            }
            array = buff;
            size = size - count;
        }

        public T GetEl(int index)
        {   if (index >= size || index < 0) throw new Exception("GetEl: Неверный index. (" + index.ToString() + ')');
            return array[index];
        }

        public void SetEl(int index, T el)
        {
            if (index >= size || index < 0) throw new Exception("SetEl: Неверный index. (" + index.ToString() + ')');
            array[index] = el;
        }

        public override string ToString()
        {
            string rstr = "";
            foreach(T el in array)
            {
                rstr += el.ToString() + ' ';
            }
            return rstr;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is OD_Array<T>)) return false;
            OD_Array<T> arr = obj as OD_Array<T>;
            if (this.Size != arr.Size) return false;
            for(int i = 0; i < this.Size; i++)
            {
                if (!(this.GetEl(i).Equals(arr.GetEl(i)))) return false;
            }
            return true;
        }

        public static OD_Array<T> operator +(OD_Array<T> arr1, OD_Array<T> arr2)
        {
            OD_Array<T> result = new OD_Array<T>();
            result.Add(arr1);
            result.Add(arr2);
            return result;
        }

        public static bool operator ==(OD_Array<T> arr1, OD_Array<T> arr2)
        {
            return arr1.Equals(arr2);
        }

        public static bool operator !=(OD_Array<T> arr1, OD_Array<T> arr2)
        {
            return !(arr1 == arr2);
        }

        public static int operator -(OD_Array<T> arr1, OD_Array<T> arr2)
        {
            return arr1.Size - arr2.Size;
        }

        public static bool operator >(T parmel, OD_Array<T> arr)
        {
            for (int i = 0; i < arr.Size; i++) 
            {
                if (arr.GetEl(i).Equals(parmel)) return true;
            }
            return false;
        }

        public static bool operator <(T parmel, OD_Array<T> arr)
        {
            return !(parmel > arr);
        }

        public static class Owner
        {
            static int id = 25042002; 
            static string name = "Danila";
            static string company = "Apolo CO";

            public static int Id { get { return id; } }
            public static string Name { get { return name; } }
            public static string Company { get { return company; } }
        }

        public static class Date
        {
            public static DateTime DateAndTime = Convert.ToDateTime("30/10/2020 23:21");
        }

    }

    public static class StatisticOperation
    {
        public static int amount = 0;
        public static int TotalAmount()
        {
            return amount;
        }

        public static string VowelsDelete(this string str)
        {
            string vowels = "аеёиоуыэюяАЕЁИОУЫЭЮЯ";
            string rstr = str;
            for(int i = 0; i < rstr.Length; i++)
            {
                foreach(char el in vowels)
                {
                    if(rstr[i] == el)
                    {
                        rstr = rstr.Remove(i, 1);
                        break;
                    }
                }
            }
            return rstr;
        }

        public static OD_Array<int> RemoveFiveElements(this OD_Array<int> arr)
        {
            arr.Delete(0, 5);
            return arr;
        }
    }

}
