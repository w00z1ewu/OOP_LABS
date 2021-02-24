using System;
using System.Collections.Generic;
using System.Text;

namespace LPLab08
{
    [Serializable]
    class Rectangle
    {
        public uint color { get; set; } = 0xFFFFFF;
        public void setcolor(uint newcolor)
        {
            color = newcolor;
        }
        public int width { get; set; } = 0;
        public string value { get; set; } = "";
        public int xPos { get; set; } = 0;
        public int yPos { get; set; } = 0;
        public int border { get; set; } = 1;
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
}
