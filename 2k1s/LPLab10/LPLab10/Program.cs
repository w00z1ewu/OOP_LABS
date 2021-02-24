using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Collections.ObjectModel;
using System.Collections.Specialized;


namespace LPLab10
{
    class Program
    {
        static void Main(string[] args)
        {
            // TASK 1
            Dictionary<string, Car> carCollection = new Dictionary<string, Car>();
            Car car1 = new Car("Honda RX", "Bonnet", "Tire-1", "Tire-2", "Tire-3", "Tire-4", "Mirrors");
            Car car2 = new Car("Lada 7", "Tire-1", "Tire-3");
            Car car3 = new Car("Audi 80 B3", "Bonnet", "Tire-1", "Tire-3", "Tire-4", "Mirrors", "Engine", "FrontDoor-1", "FrontDoor-2");
            Car car4 = new Car("Volkswagen Golf2", "Bonnet", "Tire-1", "Tire-2", "Tire-3", "Tire-4", "Mirrors", "Speedometer", "Sigarette Lighter");
            Car car5 = new Car("Lexus", "Clutch");
            carCollection.Add(car1.VehicleModel, car1);
            carCollection.Add(car2.VehicleModel, car2);
            carCollection.Add(car3.VehicleModel, car3);
            carCollection.Add(car4.VehicleModel, car4);
            carCollection.Add(car5.VehicleModel, car5);
            
            Console.WriteLine("========= Printing Collection =======");
            foreach (KeyValuePair<string, Car> el in carCollection)
            {
                Console.WriteLine(carCollection[el.Key].ToString());
            }
            Console.WriteLine("========= Deleting Lada =======");
            carCollection.Remove("Lada 7");

            foreach (KeyValuePair<string, Car> el in carCollection)
            {
                Console.WriteLine(carCollection[el.Key].ToString());
            }

            Console.WriteLine("========= If Lexus print it =======");

            if (carCollection.ContainsKey("Lexus"))
            {
                Console.WriteLine(carCollection["Lexus"]);
            }

            //TASK 2
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Dictionary<int, dynamic> dc = new Dictionary<int, dynamic>();
            dc.Add(0, 'Q');
            dc.Add(1, "string");
            dc.Add(2, (uint)123);
            dc.Add(3, (double)12.5);
            dc.Add(4, (short)(5000));
            dc.Add(5, car2);

            
            Console.WriteLine("=========== UniversalCollection set ===========");
            foreach(KeyValuePair<int, dynamic> el in dc)
            {
                Console.WriteLine(dc[el.Key]);
            }


            Dictionary<int, dynamic>.Enumerator enumer = dc.GetEnumerator();
            int delAmount = 2;
            while(delAmount > 0)
            {
                dc.Remove(enumer.Current.Key);
                enumer.MoveNext();
                delAmount--;
            }

            Console.WriteLine("=========== After deleting ===========");
            foreach (KeyValuePair<int, dynamic> el in dc)
            {
                Console.WriteLine(dc[el.Key]);
            }

            dc.Add(6, new StringBuilder("Строка в StringBuilder"));
            dc.Add(7, (long)7321310192432983902);

            Console.WriteLine("=========== UniversalCollection set ===========");
            foreach (KeyValuePair<int, dynamic> el in dc)
            {
                Console.WriteLine(dc[el.Key]);
            }

            Console.WriteLine("=========== Copying to List from Dictionary.. ===========");
            List<dynamic> lc = new List<dynamic>();
            foreach(KeyValuePair<int, dynamic> pair in dc)
            {
                lc.Add(pair.Value);
            }

            Console.WriteLine("=========== List set ===========");
            foreach(dynamic el in lc)
            {
                Console.WriteLine(el);
            }

            dynamic search = car2;

            if(lc.Contains(search))
            {
                Console.WriteLine(lc.IndexOf(search).ToString() + " - индекс искомого элемента :" + search.ToString());
            }

            //TASK 3
            Console.ForegroundColor = ConsoleColor.Yellow;

            ObservableCollection<Car> obscol = new ObservableCollection<Car>();
            obscol.CollectionChanged += ChangeReaction.Reaction;
            obscol.Add(car1);
            obscol.Add(car2);
            obscol.Remove(car1);
            obscol.Add(car4);
            obscol.Add(car3);
            obscol.Remove(car2);
        }
    }
}
