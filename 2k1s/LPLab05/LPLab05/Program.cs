//Геометрическая фигура, Круг, Прямоугольник, Управление
//(интерфейс с методами show, input, resize и т.д.), Элемент управления,
//Checktbox, Radiobutton, Button.

using System;

namespace LPLab05
{
    class Program
    {
        static void Main(string[] args)
        {
            COneName test = new COneName();
            test.onename();
            ((IOneName)test).onename();
            Console.WriteLine("=============================================");

            Rectangle rect = new Rectangle();
            CheckBox check = new CheckBox();

            ControlFigure cf = rect;
            ((Rectangle)cf).resize(3);
            Console.WriteLine(rect.width);

            Console.WriteLine($"Можно ли сделать |ControlFigure as Rectangle;|? -{cf is Rectangle}");

            IControl ic = check;
            (ic as CheckBox).resize(8);
            ((CheckBox)ic).setcoords(3, 2);
            ((CheckBox)ic).setcolor(0xF88800);
            ic.input();
            ic.input();
            ic.input();
            ic.input();
            ((CheckBox)ic).setvalue("myvalue");
            ic.show();
            Console.WriteLine(check.ToString());


            Console.WriteLine("=============================================");

            ControlElement ContEl = check;
            ControlFigure ContFi = rect;
            Rectangle Rect = new Rectangle();
            Rect.resize(3);
            Circle Circ = new Circle();
            Circ.resize(2280);
            CheckBox Check = new CheckBox();
            Check.input();
            check.setvalue("defined value");
            Button But = new Button();
            But.setcolor(0xDFEEEE);
            RadioButton RadBut = new RadioButton();
            RadBut.resize(3, 1);
            object[] objs = new object[6];
            objs[0] = ContEl;
            objs[1] = ContFi;
            objs[2] = Rect;
            objs[3] = Check;
            objs[4] = But;
            objs[5] = RadBut;

            foreach (object el in objs)
            {
                if (el is ControlElement)
                {
                    ControlElement temp = el as ControlElement;
                    Printer.IAmPrinting(temp);
                }
            }
        }

       
    }
}