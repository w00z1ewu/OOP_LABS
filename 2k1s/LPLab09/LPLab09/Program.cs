using System;
using System.Text;

namespace LPLab09
{
    public delegate void MoveDelegate(int x, int y);
    public delegate void CompressDelegate(double k);
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec1 = new Rectangle(1800, 2, 35);
            Rectangle rec2 = new Rectangle(190, -3, 3025);
            Rectangle rec3 = new Rectangle(20, 0, 3);
            Rectangle rec4 = new Rectangle(20, 145, 2);
            Rectangle rec5 = new Rectangle(20, -2341, 90);
            Circle cir1 = new Circle(0, 0, 3);
            Circle cir2 = new Circle(3, 420, 23);
            Circle cir3 = new Circle(29, 90, 500);
            Circle cir4 = new Circle(333, -50, 2);
            Circle cir5 = new Circle(2020, -2020, 30);
            User mainUser = new User();
            Console.ForegroundColor = ConsoleColor.Red;
            mainUser.Move += new MoveDelegate(cir1.MoveFigure);
            mainUser.Move += new MoveDelegate(rec1.MoveFigure);
            mainUser.Move += new MoveDelegate(rec2.MoveFigure);
            mainUser.Move += new MoveDelegate(rec3.MoveFigure);
            mainUser.Move += new MoveDelegate(cir5.MoveFigure);
            mainUser.MoveFigure(3, -50);

            Console.ForegroundColor = ConsoleColor.Green;
            User additionalUser = new User();
            additionalUser.Compress += new CompressDelegate(rec3.CompressFigure);
            additionalUser.Compress += new CompressDelegate(cir3.CompressFigure);
            additionalUser.Compress += new CompressDelegate(rec4.CompressFigure);
            additionalUser.Compress += new CompressDelegate(rec5.CompressFigure);
            additionalUser.Compress += new CompressDelegate(cir2.CompressFigure);
            additionalUser.CompressFigure(2.0);

            Console.ForegroundColor = ConsoleColor.Cyan;
            StringBuilder testSTR = new StringBuilder("There is      some text,  it is for program testing.");
            Action<StringBuilder> d;
            d = StringMethods.DelPunct;
            d += StringMethods.DelSpaces;
            d += StringMethods.UpperCase;
            d += StringMethods.SpaceReplace;
            d += StringMethods.FinishMark;
            StringMethods.StringChanger(testSTR, d);
            




        }
    }
}
