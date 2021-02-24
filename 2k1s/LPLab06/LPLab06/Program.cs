using System;

namespace LPLab06
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            CheckBox check = new CheckBox();
            ControlElement ContEl = check;
            ControlFigure ContFi = rect;
            Rectangle Rect = new Rectangle();
            Rect.resize(3);
            Circle Circ = new Circle();
            Circ.resize(3);
            CheckBox Check = new CheckBox();
            Check.input();
            Check.setvalue("defined value");
            Button But = new Button();
            But.setcolor(0xDFEEEE);
            RadioButton RadBut = new RadioButton();
            RadBut.resize(3, 1);
            object[] objs = new object[7];
            objs[0] = ContEl;
            objs[1] = ContFi;
            objs[2] = Rect;
            objs[3] = Check;
            objs[4] = But;
            objs[5] = RadBut;
            objs[6] = Circ;

            UI ui = new UI();

            foreach (ControlElement el in objs)
            {
                ui.Add(el);
            }

            ui.PrintList();

            Console.WriteLine($"Total UI amount: {UI_Controller.UI_Amount(ui)}, Total square: {UI_Controller.UI_Square(ui)}.");
        }
    }
}
