using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace LPLab14
{
    [Serializable]
    public class ControlElement
    {
        public string value = "";
        public int
                xPos = 0,
                yPos = 0;
        [NonSerialized]
        public int
                border = 1;

        public ControlElement()
        {
            xPos = 0;
            yPos = 0;
            border = 1;
            value = "No-Value";
        }
        public ControlElement(int x, int y, string str)
        {
            xPos = x;
            yPos = y;
            border = 1;
            value = str;
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

        public override string ToString()
        {
            string rstr = "";
            rstr += $"X-pos = {xPos}, Y-pos = {yPos}, border = {border}, value = {value}.";
            return rstr;
        }
    }
    [Serializable]
    public class ControlFigure : ControlElement
    {
        public uint color = 0xFFFFFF;
        public ControlFigure()
        {
            color = 0xFFEEFFEE;
        }
        public ControlFigure(uint c, int x, int y, string vl) : base(x, y, vl)
        {
            color = c;
        }
        public void setcolor(uint newcolor)
        {
            color = newcolor;
        }
        public override string ToString()
        {
            string rstr = "";
            rstr += $"X-pos = {xPos}, Y-pos = {yPos}, border = {border}, value = {value}, color = {color.ToString("X2")}.";
            return rstr;
        }
    }
}
