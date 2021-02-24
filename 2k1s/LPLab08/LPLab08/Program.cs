using System.Text.Json;
using System;

namespace LPLab08
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CollectionType<int> col1 = new CollectionType<int>(0, 1, 2, 3, 4, 5);
                col1.Show();
                col1.Del(3);
                col1.Show();
                col1.Add(6, 7, 8, 9);
                col1.Show();

                CollectionType<double> col2 = new CollectionType<double>(1.4, 1.5, 1.666);
                col2.Show();

                CollectionType<Rectangle> colRect = new CollectionType<Rectangle>();
                Rectangle rec1 = new Rectangle();
                rec1.resize(13);
                Rectangle rec2 = new Rectangle();
                rec2.resize(25);
                Rectangle rec3 = new Rectangle();
                rec3.resize(1);
                colRect.Add(rec1, rec2, rec3);
                colRect += colRect;
                colRect.Show();

                Console.ForegroundColor = ConsoleColor.Green;
                colRect.SaveData();
                CollectionType<Rectangle> fromFile = new CollectionType<Rectangle>();
                fromFile.ReadData();
                Console.WriteLine("====================== Data from file =====================");
                fromFile.Show();

                
            }
            catch(Exception er)
            {
                Console.WriteLine(er.Message);
            }



        }
    }
}
