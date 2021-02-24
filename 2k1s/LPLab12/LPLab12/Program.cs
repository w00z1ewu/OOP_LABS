using System;
using System.Reflection;

namespace LPLab12
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Honda");
            Console.WriteLine(Reflector<Car>.Assembly(car1.GetType().FullName));

            Airline air_3 = new Airline("Minsk", 254, "02:30", Airline.PlaneType.Mid_Size, Airline.Days.Wed, Airline.Days.Thr, Airline.Days.Fri);
            Console.WriteLine(Reflector<Airline>.IsTherePublicConstuctors(air_3.GetType().FullName));

            var pubmet = Reflector<Airline>.GetPublicMethods(air_3.GetType().FullName);
            foreach(string el in pubmet)
            {
                Console.WriteLine(el);
            }

            var fields = Reflector<Airline>.GetFields(air_3.GetType().FullName);
            foreach (string el in fields)
            {
                Console.WriteLine(el);
            }

            var infaces = Reflector<Airline>.GetInterfaces(air_3.GetType().FullName);

            Reflector<Car>.Invoke(car1, "Add");

            Car newcar = Reflector<Car>.Create(typeof(Car));

        }
    }
}
