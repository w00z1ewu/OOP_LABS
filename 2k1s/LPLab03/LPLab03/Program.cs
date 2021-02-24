//2 вариант
using System;
using System.Data;
using System.Linq;
using System.Timers;

namespace LPLab03
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Airline.ClassName();
                Console.WriteLine();

                Airline air_1 = new Airline("Moscow", 24, "15:15", Airline.PlaneType.Light_Passenger, Airline.Days.Sun, Airline.Days.Tue);
                Airline air_2 = new Airline("Minsk", 13, "00:36", Airline.PlaneType.Cargo, Airline.Days.Wed, Airline.Days.Tue);
                Airline air_3 = new Airline("Minsk", 254, "02:30", Airline.PlaneType.Mid_Size, Airline.Days.Wed, Airline.Days.Thr, Airline.Days.Fri);
                Airline air_4 = new Airline("Denver", "00:30", Airline.PlaneType.Cargo, null, Airline.Days.Wed, Airline.Days.Tue);
                Airline air_5 = new Airline("Novogrudok", 17, "23:59", Airline.PlaneType.Jumbo, Airline.Days.Sun, Airline.Days.Tue);

                Airline[] airs = { air_1, air_2, air_3, air_4, air_5 };

                var anonymus = new {dest = "Moscow", time = "22:30", id = 0, type = Airline.PlaneType.Cargo, days = new { Airline.Days.Mon, Airline.Days.Thr } };
                Console.WriteLine(anonymus.ToString() + '\n');

                Console.ForegroundColor = ConsoleColor.Green;
                Airline.Days DayForSearch = Airline.Days.Wed;
                Console.WriteLine($"All the flights on {Airline.strdays[(int)DayForSearch]}: ");
                foreach(Airline el in airs)
                {
                    if (el.days[2]) Console.WriteLine(el.ToString());
                }

                Console.ForegroundColor = ConsoleColor.Red;
                string destsearch = "Minsk";
                Console.WriteLine($"\n\nAll the flights with destination {destsearch}:");
                foreach(Airline el in airs)
                {
                    if(el.Destination == destsearch) Console.WriteLine(el.ToString());
                }

                Console.ResetColor();
            }
            catch (Exception error)
            {
                Console.Beep();
                Console.Beep();
                Console.Beep();
                Console.WriteLine(error.Message);
            }
        }
    }

    partial class Airline
    {
        string             destination;
        int                flightID;
        DateTime           time;
        PlaneType          type;
        static int         total_flights;
        const int          max_flights_amount = 255;
        public bool[]      days = new bool[7];
        static public string[]   
                           strdays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        static bool[]      flight_id_table = new bool[max_flights_amount];
        readonly static string no_plane_type = "No-Type";
        static string[]    plane_types = { no_plane_type,"Jumbo", "Mid-Size", "Light-Passanger", "Cargo" };

        public string Destination
        {
            get
            {
                return destination;
            }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new Exception("Destination field is invalid. ( null or empty )");
                destination = value;
            }
        }
        public int FlightID
        {
            set
            {
                if (value < 0 || value >= 255) throw new Exception($"Invalid flight ID({value}).");
                if (ID_engaged(value)) throw new Exception($"Flight ID '{value}' is already exist.");
                flightID = value;
                flight_id_table[value] = true;
            }
        }

        public string Time
        {
            get
            {
                return time.ToString("HH:mm");
            }
            set
            {
                if (!DateTime.TryParse(value, out time)) throw new Exception("Invalid time.");

            }
        }

        public PlaneType Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }

        public Airline()
        {
            if (ListOverflow()) throw new Exception("Flights list overflow.");

            Destination = "Empty Slot";

            FlightID = SearchFreeID();

            Time = "00:00";

            Type = PlaneType.No_type;

            total_flights++;
        }

        public Airline(string dest, string timestr, PlaneType type, int? id = null, params Days[] dayslist)
        {
            if (id.HasValue) FlightID = (int)id;
            else FlightID = SearchFreeID();

            Destination = dest;

            Time = timestr;

            Type = type;

            foreach (Days el in dayslist)
            {
                days[(int)el] = true;
            }

            total_flights++;

        }
        public Airline(string dest, int id, string timestr, PlaneType type, params Days[] dayslist)
        {
            if (ListOverflow()) throw new Exception("Flights list overflow.");

            Destination = dest;

            FlightID = id;

            Time = timestr;

            Type = type;

            foreach (Days el in dayslist)
            {
                days[(int)el] = true;
            }

            total_flights++;
        }
        static Airline()
        {
            total_flights = 0;
        }

        string[] strtypes = { "Jumbo", "Mid-Size", "Light-Passenger", "Cargo" };

       public enum PlaneType
       {
            Jumbo = 1,
            Mid_Size,
            Light_Passenger,
            Cargo,
            No_type = 0
       }

        public enum Days
        {
            Mon = 0,
            Tue,
            Wed,
            Thr,
            Fri,
            Sat,
            Sun
        }

        bool ListOverflow()
        {
            return total_flights + 1 > max_flights_amount;
        }

        bool ID_engaged(int id)
        {
            return flight_id_table[id];
        }

        int SearchFreeID()
        {
            for (int i = 0; i < max_flights_amount; i++) 
            {
                if (!ID_engaged(i)) return i;
            }
            return -1;
        }
        
        public override string ToString()
        {
            string rs;
            rs = "Destination: " + Destination + '\n' + "ID: " + flightID.ToString() + '\n' + "Time: " + Time + '\n' + "Plane Type: " + plane_types[(int)Type] + '\n' + "Days: |";
            int index = 0;
            foreach(bool el in days)
            {
                if (el) rs += strdays[index] + '|';
                index++;
            }
            return rs;
        }

        public override bool Equals(object obj)
        {

            return obj is Airline ? ((Airline)obj).flightID == this.flightID : false;
        }

        public override int GetHashCode()
        {
            return flightID;
        }

        public static void ClassName()
        {
            Console.WriteLine("Classname: Airline");
            return;
        }

    }

}
