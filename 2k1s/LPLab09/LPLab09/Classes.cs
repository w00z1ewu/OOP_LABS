using System;
using System.Collections.Generic;
using System.Text;

namespace LPLab09
{
    class Rectangle
    {
        //====================================

        public void MoveFigure(int delX, int delY)
        {
            xPos += delX;
            yPos += delY;
            Console.WriteLine($"Rectangle: Обьект переместился. Текущие координаты: ({xPos}, {yPos})");
        }

        public void CompressFigure(double k)
        {
            width = (int)(width / k);
            Console.WriteLine($"Rectangle: Обьект был сжат. Новый размер: {width}");
        }

        //====================================
        public uint color { get; set; } = 0xFFFFFF;
        public int width { get; set; } = 0;
        public string value { get; set; } = "";
        public int xPos { get; set; } = 0;
        public int yPos { get; set; } = 0;
        public int border { get; set; } = 1;

        public Rectangle(int x, int y, int w)
        {
            xPos = x;
            yPos = y;
            width = w;
        }

        public void setcolor(uint newcolor)
        {
            color = newcolor;
        }
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
            rstr += $"X-pos = {xPos}, Y-pos = {yPos}, border = {border}, value = {value}, color = {color.ToString("X2")}, shape = rectangle, width = {width}.";
            return rstr;
        }
    }

    class Circle
    {
        //====================================

        public void MoveFigure(int delX, int delY)
        {
            xPos += delX;
            yPos += delY;
            Console.WriteLine($"Circle: Обьект переместился. Текущие координаты: ({xPos}, {yPos})");
        }

        public void CompressFigure(double k)
        {
            rad = (int)(rad / k);
            Console.WriteLine($"Circle: Обьект был сжат. Новый радиус: {rad}");
        }

        //====================================
        public uint color { get; set; } = 0xFFFFFF;
        public int rad { get; set; } = 0;
        public string value { get; set; } = "";
        public int xPos { get; set; } = 0;
        public int yPos { get; set; } = 0;
        public int border { get; set; } = 1;

        public Circle(int x, int y, int radd)
        {
            xPos = x;
            yPos = y;
            rad = radd;
        }

        public void setcolor(uint newcolor)
        {
            color = newcolor;
        }
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

        public void resize()
        {
            rad = 0;
        }
        public void resize(int size)
        {
            rad = size;
        }

        public override string ToString()
        {
            string rstr = "";
            rstr += $"X-pos = {xPos}, Y-pos = {yPos}, border = {border}, value = {value}, color = {color.ToString("X2")}, shape = circle, radius = {rad}.";
            return rstr;
        }
    }
}
