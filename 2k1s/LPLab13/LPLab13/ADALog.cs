using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPLab13
{
    static class ADALog
    {
        public static void WriteMessage(string message)
        {
            using (StreamWriter writer = new StreamWriter("../../../logfile.txt", true))
                writer.WriteLine("Время: " + DateTime.Now.ToString() + "   " + message);
        }
        public static void SearchbyDate()
        {
            try
            {
                string logstr;
                Console.WriteLine("Введите номер дня");
                string day = Console.ReadLine();
                if (Convert.ToInt32(day) > 31 || Convert.ToInt32(day) < 1) throw new Exception("Неверный ввод дня.");
                day = day.Length == 2 ? day : '0' + day;
                using (StreamReader reader = new StreamReader("../../../logfile.txt"))
                {
                    while (reader.EndOfStream == false)
                    {
                        logstr = reader.ReadLine();
                        if (logstr.Contains("Время: " + day)) Console.WriteLine(logstr);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
      
}