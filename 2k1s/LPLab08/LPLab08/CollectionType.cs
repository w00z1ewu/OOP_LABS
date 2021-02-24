using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.IO;

namespace LPLab08
{
    public class CollectionType<T> : GenericInterface<T> where T : new()
    {
        //==============================================

        public void Del(int ind)
        {
            this.Delete(ind, 1);
        }

        public void Show()
        {
            Console.WriteLine(this.ToString());
        }

        public void SaveData()
        {
            if (!(typeof(T)).IsSerializable) throw new Exception("Тип обьекта невозможно сохранить!");
            StreamWriter writer = new StreamWriter("data.json");
            foreach (T el in array)
            {
                string jsonINFO = JsonSerializer.Serialize<T>(el);
                writer.WriteLine(jsonINFO);
            }
            writer.Close();
        }

        public void ReadData()
        {
            if (!(typeof(T)).IsSerializable) throw new Exception("Тип обьекта невозможно считать!");

            StreamReader reader = new StreamReader("data.json");
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                T temp = JsonSerializer.Deserialize<T>(line);
                this.Add(temp);
            }
            reader.Close();
            
        }

        //==============================================
        internal List<T> array = new List<T>();
        int size = 0;

        public int Size { get { return size; } }
        public CollectionType()
        {
            StatisticOperation.amount++;
        }

        public CollectionType(params T[] parms)
        {
            StatisticOperation.amount++;

            foreach (T el in parms)
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

        public void Add(CollectionType<T> arr)
        {
            for (int i = 0; i < arr.Size; i++)
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
            for (int i = 0; i < index && i < Size; i++)
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
        {
            if (index >= size || index < 0) throw new Exception("GetEl: Неверный index. (" + index.ToString() + ')');
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
            foreach (T el in array)
            {
                rstr += el.ToString() + '\n';
            }
            return rstr;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is CollectionType<T>)) return false;
            CollectionType<T> arr = obj as CollectionType<T>;
            if (this.Size != arr.Size) return false;
            for (int i = 0; i < this.Size; i++)
            {
                if (!(this.GetEl(i).Equals(arr.GetEl(i)))) return false;
            }
            return true;
        }

        public static CollectionType<T> operator +(CollectionType<T> arr1, CollectionType<T> arr2)
        {
            CollectionType<T> result = new CollectionType<T>();
            result.Add(arr1);
            result.Add(arr2);
            return result;
        }

        public static bool operator ==(CollectionType<T> arr1, CollectionType<T> arr2)
        {
            return arr1.Equals(arr2);
        }

        public static bool operator !=(CollectionType<T> arr1, CollectionType<T> arr2)
        {
            return !(arr1 == arr2);
        }

        public static int operator -(CollectionType<T> arr1, CollectionType<T> arr2)
        {
            return arr1.Size - arr2.Size;
        }

        public static bool operator >(T parmel, CollectionType<T> arr)
        {
            for (int i = 0; i < arr.Size; i++)
            {
                if (arr.GetEl(i).Equals(parmel)) return true;
            }
            return false;
        }

        public static bool operator <(T parmel, CollectionType<T> arr)
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
            for (int i = 0; i < rstr.Length; i++)
            {
                foreach (char el in vowels)
                {
                    if (rstr[i] == el)
                    {
                        rstr = rstr.Remove(i, 1);
                        break;
                    }
                }
            }
            return rstr;
        }

        public static CollectionType<int> RemoveFiveElements(this CollectionType<int> arr)
        {
            arr.Delete(0, 5);
            return arr;
        }
    }
}
