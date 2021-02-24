using System;
using System.Collections.Generic;
using System.Text;

namespace LPLab06
{
    abstract partial class ControlElement
    {
        public string value = "";
        public int
                xPos = 0,
                yPos = 0;
        public BORDER border = new BORDER(BORDERCOLOR.RED, BORDERTYPE.SOL, 1);

        public void setcoords(int x, int y)
        {
            xPos = x;
            yPos = y;
        }
        public void setvalue()
        {
            value = "";
        }
        public void setvalue(string newValue)
        {
            value = newValue;
        }

        public override string ToString()
        {
            string rstr = "";
            rstr += $"X-pos = {xPos}, Y-pos = {yPos}, border = {border.size}, value = {value}.";
            return rstr;
        }
    }

    abstract class ControlFigure : ControlElement
    {
        public uint color = 0xFFFFFF;
        public void setcolor(uint newcolor)
        {
            color = newcolor;
        }
        public override string ToString()
        {
            string rstr = "";
            rstr += $"X-pos = {xPos}, Y-pos = {yPos}, border = {border.size}, value = {value}, color = {color.ToString("X2")}.";
            return rstr;
        }
    }

    class Rectangle : ControlFigure
    {
        public int width = 0;

        public void resize()
        {
            width = 0;
        }
        public void resize(int size)
        {
            width = size;
        }

        public override string ToString()
        {
            string rstr = "";
            rstr += $"X-pos = {xPos}, Y-pos = {yPos}, border = {border.size}, value = {value}, color = {color.ToString("X2")}, shape = rectangle, width = {width}.";
            return rstr;
        }
    }

    class Circle : ControlFigure
    {
        public int radius = 0;

        virtual public void resize()
        {
            radius = 0;
        }
        virtual public void resize(int newRad)
        {
            radius = newRad;
        }

        public override string ToString()
        {
            string rstr = "";
            rstr += $"X-pos = {xPos}, Y-pos = {yPos}, border = {border.size}, value = {value}, color = {color.ToString("X2")}, shape = circle, radius = {radius}.";
            return rstr;
        }
    }

    sealed class CheckBox : Rectangle, IControl
    {
        bool flag;
        public void input()
        {
            flag = !flag;
            Console.WriteLine($"Кнопка была нажата, текущее значение: {flag}");
        }

        public void show()
        {
            Console.WriteLine($"X-position: {xPos}, Y-position: {yPos}, Size: {width}, Color: #{color.ToString("X2")}.");
        }

        public override string ToString()
        {
            string rstr = "";
            rstr += $"X-pos = {xPos}, Y-pos = {yPos}, border = {border.size}, value = {value}, color = {color.ToString("X2")}, shape = rectangle, width = {width}, flag = {flag}.";
            return rstr;
        }
    }

    class Button : Circle, IControl
    {
        virtual public void show()
        {
            Console.WriteLine($"X-position: {xPos}, Y-position: {yPos}, Radius: {radius}, Color: #{color.ToString("X2")}.");
        }

        virtual public void input()
        {
            Console.WriteLine("Кнопка была нажата! Взрыв через 3... 2... 1...");
        }

    }

    sealed class RadioButton : Button
    {
        bool flag = false;

        int innerRadius = 0;
        public override void resize()
        {
            base.resize();
            innerRadius = 0;
        }
        public void resize(int newRad, int newInnerRad)
        {
            if (newInnerRad > newRad || newRad < 0 || newInnerRad < 0)
            {
                Console.WriteLine("Ошибочно введенные радиусы.");
                resize();
                return;
            }

            radius = newRad;
            innerRadius = newInnerRad;
        }

        public override void show()
        {
            Console.WriteLine($"X-position: {xPos}, Y-position: {yPos}, Radius: {radius}, InnerRadius: {innerRadius} Color: #{color.ToString("X2")}.");
        }

        public override void input()
        {
            if (!flag)
            {
                flag = !flag;
            }
            Console.WriteLine($"Кнопка была нажата, текущее значение: {flag}");
        }

        public override string ToString()
        {
            string rstr = "";
            rstr += $"X-pos = {xPos}, Y-pos = {yPos}, border = {border.size}, value = {value}, color = {color.ToString("X2")}, shape = circle, radius = {radius}, innerRad = {innerRadius}, flag = {flag}.";
            return rstr;
        }
    }
}
