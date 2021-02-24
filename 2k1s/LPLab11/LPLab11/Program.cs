using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;

namespace LPLab11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("___________________TASK-1___________________");
            string[] Monthes = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            Console.WriteLine("@Enter the month's length:");
            int n = Convert.ToInt32(Console.ReadLine());
        

            var res = Monthes.Where(el => el.Length == n).Select(n => n);
            res = from el in Monthes            // selecting Length == n
                  where el.Length == n
                  select el;
            Console.WriteLine($"@Elements with lengths = {n} :");
            foreach (string el in res)
            {
                Console.WriteLine(el);
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("@Summer monthes:");
            res = from el in Monthes
                  where el.Equals("June") || el.Equals("July") || el.Equals("August")
                  select el;
            foreach(string el in res)
            {
                Console.WriteLine(el);
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("@Winter monthes:");
            res = from el in Monthes
                  where el.Equals("January") || el.Equals("February") || el.Equals("December")
                  select el;
            foreach (string el in res)
            {
                Console.WriteLine(el);
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("@Monthes using OrderBy:");
            res = Monthes.OrderBy(el => el);
            foreach(string el in res)
            {
                Console.WriteLine(el);
            }

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            res = from el in Monthes
                  where el.Contains('u') && (el.Length >= 4)
                  select el;

            Console.WriteLine("@All the elements which contains 'u' and Lengths is >= 4:");
            foreach(string el in res)
            {
                Console.WriteLine(el);
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine();
            Console.WriteLine("___________________TASK-2___________________");

            List<Airline> airlist = new List<Airline>();
            Airline air_1 = new Airline("Moscow", 24, "15:15", Airline.PlaneType.Light_Passenger, Airline.Days.Sun, Airline.Days.Tue);
            Airline air_2 = new Airline("Minsk", 13, "00:36", Airline.PlaneType.Cargo, Airline.Days.Mon, Airline.Days.Tue);
            Airline air_3 = new Airline("Minsk", 254, "02:30", Airline.PlaneType.Mid_Size, Airline.Days.Wed, Airline.Days.Thr, Airline.Days.Fri);
            Airline air_4 = new Airline("Denver", "00:30", Airline.PlaneType.Cargo, null, Airline.Days.Wed, Airline.Days.Tue);
            Airline air_5 = new Airline("Novogrudok", 17, "23:59", Airline.PlaneType.Jumbo, Airline.Days.Sun, Airline.Days.Tue);
            Airline air_6 = new Airline("Moscow", 25, "15:15", Airline.PlaneType.Light_Passenger, Airline.Days.Sun, Airline.Days.Mon);
            Airline air_7 = new Airline("Minsk", 3, "00:36", Airline.PlaneType.Cargo, Airline.Days.Wed, Airline.Days.Tue);
            Airline air_8 = new Airline("Krakov", 15, "02:35", Airline.PlaneType.Mid_Size, Airline.Days.Wed, Airline.Days.Thr, Airline.Days.Fri);
            airlist.Add(air_1);
            airlist.Add(air_2);
            airlist.Add(air_3);
            airlist.Add(air_4);
            airlist.Add(air_5);
            airlist.Add(air_6);
            airlist.Add(air_7);
            airlist.Add(air_8);
            Console.WriteLine("===> ================ Current AirList: ===============");
            foreach(Airline el in airlist)
            {
                Console.WriteLine(el.ToString());
            }

            Console.WriteLine("===> Enter the destination-name for searching:");
            string CitySearch = Console.ReadLine();

            var airResult = from element in airlist
                            where element.Destination.Equals(CitySearch)
                            select element;
            Console.WriteLine($"===> ================== {CitySearch} - Destination elements: ==================");
            foreach(Airline el in airResult)
            {
                Console.WriteLine(el.ToString());
            }

            Airline.Days DaySearch = Airline.Days.Fri;
            airResult = from element in airlist
                        where element.days[(int)DaySearch] == true
                        select element;
            Console.WriteLine("===> Amount of AirFlights on Friday is - " + airResult.Count());

            airResult = from element in airlist
                        where element.days[(int)Airline.Days.Mon] == true
                        orderby element.Time
                        select element;
            Console.WriteLine($"===> Earliest fly on monday is : \n{airResult.First<Airline>().ToString()}");

            airResult = from element in airlist
                        where element.days[(int)Airline.Days.Wed] == true || element.days[(int)Airline.Days.Fri] == true
                        orderby element.Time
                        select element;
            Console.WriteLine($"===> Last fly in wed or fri is:\n{airResult.Last().ToString()}");

            airResult = from element in airlist
                        orderby element.Time
                        select element;
            Console.WriteLine("===> Elements, ordered by TIME:");
            foreach(Airline el in airResult)
            {
                Console.WriteLine(el.ToString());
            }

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine();
            Console.WriteLine("___________________TASK-3___________________");

            string[] Destinations = { "Minsk", "Novogrudok", "Moscow", "Denver" };

            var task3Res = airlist.Join(
                                    Destinations,
                                    dest => dest.Destination,
                                    s => s,
                                    (dest, s) => dest
                                    ).
                                    Where(el => el.days[(int)Airline.Days.Sat] == false && el.days[(int)Airline.Days.Sun] == false).
                                    OrderBy(t => t.Time).
                                    ThenBy(name => name.Destination).
                                    Distinct().
                                    Select(el => el);
            Console.WriteLine("===> My requests:");
            foreach(Airline el in task3Res)
            {
                Console.WriteLine(el.ToString());
            }              
        }
    }
}
