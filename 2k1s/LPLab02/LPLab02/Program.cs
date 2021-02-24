using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace LPLab02
{
    class Program
    {
        static void Main(string[] args)
        {
            //============= Задание 1A =============\\
            Types types = new Types();
            Console.WriteLine("//============= Задание 1A =============\\\\");
            Console.WriteLine("{0,-10}{1}", "Bool:", types.boolv);
            Console.WriteLine("{0,-10}{1}", "Byte:", types.bytev);
            Console.WriteLine("{0,-10}{1}", "Sbyte:", types.sbytev);
            Console.WriteLine("{0,-10}{1}", "Char:", types.charv);
            Console.WriteLine("{0,-10}{1}", "Decimal:", types.decv);
            Console.WriteLine("{0,-10}{1}", "Double:", types.doubv);
            Console.WriteLine("{0,-10}{1}", "Float:", types.floatv);
            Console.WriteLine("{0,-10}{1}", "Int:", types.intv);
            Console.WriteLine("{0,-10}{1}", "Uint", types.uintv);
            Console.WriteLine("{0,-10}{1}", "Long:", types.longv);
            Console.WriteLine("{0,-10}{1}", "Ulong:", types.ulongv);
            Console.WriteLine("{0,-10}{1}", "Short:", types.shortv);
            Console.WriteLine("{0,-10}{1}", "Ushort:", types.ushortv);
            //============= Задание 1B =============\\
            types.intv = types.bytev + 25;
            types.intv = types.intv - 'd';
            types.doubv = types.doubv - types.floatv;
            types.longv = types.shortv + types.intv;
            types.shortv = 'D' - (short)3;

            types.intv = (int)(3 + 12.5f);
            types.charv = (char)(17 + 20);
            types.shortv = (short)(types.ushortv + types.charv);
            types.decv = (decimal)(types.floatv);
            types.longv = (long)types.intv;

            double dv = 2.3e2;
            int iv = Convert.ToInt32(dv);
            char cv = Convert.ToChar(36);
            bool bv = Convert.ToBoolean(1.3e+7m);
            //============= Задание 1C =============\\
            int x = 18;
            object boxed = x;
            int unboxed = (int)boxed;
            byte bunboxed = (byte)(int)boxed;
            //============= Задание 1D =============\\
            Console.WriteLine("//============= Задание 1D =============\\\\");
            var varInt = 13;
            var varBool = true;
            Console.WriteLine($"VarInt:{varInt, 10}\nVarBool:{varBool, 10}");
            //============= Задание 1E =============\\
            Console.WriteLine("//============= Задание 1E =============\\\\");
            Nullable<int>   nlInt1 = 25;
            int?            nlInt2 = null;
            Console.WriteLine($"NullableInt1:{nlInt1,10}\nNullableInt2:{nlInt2,10}");
            //============= Задание 1F =============\\
            var vv = 18;
            //vv = true;

            //============= Задание 2A =============\\
            Console.WriteLine("//============= Задание 2A =============\\\\");
            Console.WriteLine($"Строки равны:{String.Equals("Word1", "Word2"), -5}");
            //============= Задание 2B =============\\
            Console.WriteLine("//============= Задание 2B =============\\\\");
            string fullstr = "My name is Ivan.";
            string newname = "Danila";
            string sayhi   = "Hi!";
            char[] buff = new char[10];
            fullstr = fullstr + ' ' + sayhi;
            Console.WriteLine(fullstr);
            fullstr.CopyTo(3, buff, 0, 4);
            Console.WriteLine(buff);
            string substring = fullstr.Substring(8);
            Console.WriteLine(substring);
            string[] splitedwords = fullstr.Split(new char[] { ' ' } );
            foreach(string str in splitedwords)
            {
                Console.WriteLine(str + ' ') ;
            }
            string insertedstr = fullstr.Insert(10, ' '+"not");
            Console.WriteLine(insertedstr);
            fullstr = fullstr.Remove(fullstr.Length - 3);
            Console.WriteLine(fullstr);
            Console.WriteLine($"Интерполяция это: {3} + {(int)2} = {5}");
            //============= Задание 2C =============\\
            string nullstr = null, emptystr = "";
            Console.WriteLine("//============= Задание 2B =============\\\\");
            Console.WriteLine($"Строки пустые или null: {String.IsNullOrEmpty(nullstr)}, {String.IsNullOrEmpty(emptystr)}");
            emptystr = emptystr.Insert(0, "Not Empty Anymore");
            Console.WriteLine(emptystr);
            //============= Задание 2D =============\\
            Console.WriteLine("//============= Задание 2D =============\\\\");
            StringBuilder strBuild = new StringBuilder("Новая строчка", 50);
            strBuild.Replace(' ', '|');
            strBuild.Insert(0, '!');
            strBuild.Insert(strBuild.Length, '!');
            Console.WriteLine(strBuild);

            //============= Задание 3A =============\\
            int[,] intArr = new int[,]
            {
            {1, 2, 3, 4, 5 },
            {6, 7, 8, 9, 10 },
            {11, 12, 13, 14, 15 },
            {16, 17, 18, 19, 20 },
            {21, 22, 23, 24, 25 }
            };
            Console.WriteLine("//============= Задание 3A =============\\\\");
            for (int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    Console.Write($"{intArr[i, j], -3}");
                }
                Console.WriteLine();
            }
            //============= Задание 3B =============\\
            Console.WriteLine("//============= Задание 3B =============\\\\");
            string[] strArr = new string[]
            { "Sup!", "My", "name", "is", "Danila!" };
            foreach (string str in strArr)
            {
                Console.Write($"{str} ");
            }
            Console.WriteLine($"\nStrLength = {strArr.Length}");
            strArr[4] = strArr[4].Remove(0);
            strArr[4] = strArr[4].Insert(0, "Vladimir");
            foreach (string str in strArr)
            {
                Console.Write($"{str} ");
            }
            Console.WriteLine();
            //============= Задание 3C =============\\???
            float[][] jaggedArr = new float[3][];
            jaggedArr[0] = new float[2];
            jaggedArr[1] = new float[3];
            jaggedArr[2] = new float[4];
            for (int i = 0; i < jaggedArr.Length; i++)
            {
                for (int j = 0; j < jaggedArr[i].Length; j++)
                {
                    jaggedArr[i][j] = float.Parse(Console.ReadLine());
                }
            }

            //============= Задание 3D =============\\

            var nontypearr = jaggedArr;
            var nontypestr = fullstr;

            //============= Задание 4A =============\\
            Console.WriteLine("//============= Задание 4A =============\\\\");
            (int age, string name, char firstL, string surname, ulong maxlong) mytuple = (18, "Danila", 'D', "Apolonik", 0xFFFFFFFFFFFFFFFF);
            //============= Задание 4B =============\\
            Console.WriteLine("//============= Задание 4B =============\\\\");
            Console.WriteLine(mytuple);
            Console.WriteLine($"{mytuple.age}, {mytuple.firstL}, {mytuple.surname}");
            //============= Задание 4C =============\\
            var (one, two, three, four, five) = mytuple;
            var tup3 = mytuple.Item3;
            var tup5 = mytuple.Item4;
            //============= Задание 4D =============\\
            Console.WriteLine("//============= Задание 4D =============\\\\");
            var cmptuple = mytuple; var tuple2 = (3, 9);
            Console.WriteLine(cmptuple == mytuple);
            cmptuple.Item1 = 13;
            Console.WriteLine(cmptuple == mytuple);
            //============= Задание 5A =============\\
            Console.WriteLine("//============= Задание 5A =============\\\\");

            (int maxValue, int minValue, int sum, char firstl) LocalFunc(int[]arr, string str)
            {
                int max = arr[0];
                int min = arr[0];
                char firstl = str[0];
                int sum = 0;

                foreach(int el in arr)
                {
                    if (min > el) min = el;
                    if (max < el) max = el;
                    sum += el;
                }

                return (max, min, sum, firstl);
            }
            int[] arr = { 1, 6, -5, 3, 7, 20, 99, -24 };
            var result = LocalFunc(arr, "Текст для первой буквы");
            Console.WriteLine(result);
            //============= Задание 6 =============\\
            Console.WriteLine("//============= Задание 6 =============\\\\");

            void LF1()
            {
                unchecked
                {
                    int maxint = 0x7FFFFFFF;
                    maxint += 1;
                    Console.WriteLine(maxint);
                }
                return;
            }

            void LF2()
            {
                checked
                {
                    int maxint = 0x7FFFFFFF;
                    maxint += 1;
                    Console.WriteLine(maxint);
                }
                return;
            }

            LF1();
            LF2();

        }

        class Types
        {
            public bool boolv = true;
            public byte bytev = 0xFF;
            public sbyte sbytev = 0x55;
            public char charv = 'D';
            public decimal decv = 15e3m;
            public double doubv = 10e-3;
            public float floatv = 228.3e-3f;
            public int intv = 0x79999999;
            public uint uintv = 0xFFFFFFFF;
            public long longv = 0x7900000000000000;
            public ulong ulongv = 0xFFFFFFFFFFFFFFFF;
            public short shortv = 0x7999;
            public ushort ushortv = 0xFFFF;
        }
    }
}