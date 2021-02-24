using System;
using System.Collections.Generic;
using System.Text;

namespace LPLab09
{
    static class StringMethods
    {
        public static void StringChanger(StringBuilder str, Action<StringBuilder> dgt)
        {
            Console.WriteLine("========= String Changer Method started =========");
            if (dgt != null)
                dgt(str);

            Console.WriteLine("========= String Changer Method finished =========");


        }

        static public void DelPunct(StringBuilder str)
        {
            for (int i = 0; i < str.Length; i++)
            {
               if (str[i] == ',' || str[i] == '.' || str[i] == '-') { str = str.Remove(i, 1); i--; }
            }
            Console.WriteLine($"DelPunct    : str was changed to: {str}");
        }

        static public void DelSpaces(StringBuilder str)
        {
            for(int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] == ' ' && str[i + 1] == ' ') { str = str.Remove(i, 1); i--; }
            }

            Console.WriteLine($"DelSpaces   : str was changed to: {str}");
        }

        static public void UpperCase(StringBuilder str)
        {
            string temp = str.ToString().ToUpper();
            str.Clear();
            str.Append(temp);
            Console.WriteLine($"UpperCase   : str was changed to: {str}");
        }

        static public void SpaceReplace(StringBuilder str)
        {
            str.Replace(' ', '_');
            Console.WriteLine($"SpaceReplace: str was changed to: {str}");
        }

        static public void FinishMark(StringBuilder str)
        {
            str.Append("[finished]");
            Console.WriteLine($"FinishMark  : str was changed to: {str}");
        }

    }
}
