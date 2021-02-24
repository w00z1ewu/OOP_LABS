using System;
using System.Collections.Generic;
using System.Text;

namespace LPLab11
{
    partial class Airline
    {
        string destination;
        int flightID;
        DateTime time;
        PlaneType type;
        static int total_flights;
        const int max_flights_amount = 255;
        public bool[] days = new bool[7];
        static public string[]
                           strdays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        static bool[] flight_id_table = new bool[max_flights_amount];
        readonly static string no_plane_type = "No-Type";
        static string[] plane_types = { no_plane_type, "Jumbo", "Mid-Size", "Light-Passanger", "Cargo" };

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
            foreach (bool el in days)
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
