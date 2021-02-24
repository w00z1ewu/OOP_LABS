using System;
using System.Collections.Generic;
using System.Text;

namespace LPLab06
{
    static class UI_Controller
    {
        public static int UI_Amount(UI ui)
        {
            return ui.Size;
        }

        public static int UI_Square(UI ui)
        {
            int ri = 0;

            foreach(ControlFigure el in ui.list)
            {
                if (el is Rectangle) ri+= ((Rectangle)el).width*((Rectangle)el).width;
                if (el is Circle) ri += (int)(((Circle)el).radius * ((Circle)el).radius * Math.PI);

            }

            return ri;
        }
    }
}
