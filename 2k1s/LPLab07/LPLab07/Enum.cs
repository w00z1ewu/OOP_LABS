using System;
using System.Collections.Generic;
using System.Text;

namespace LPLab07
{
    abstract partial class ControlElement 
    {
        public enum BORDERTYPE
        {
            SOL = 0,
            DOT,
            TRANSPAR
        }
        public enum BORDERCOLOR
        {
            RED,
            GREEN,
            BLUE,
            WHITE,
            BLACK,
            PINK,
            CYAN,
            ORANGE,
            YELLOW
        }

        struct BORDER
        {
            public BORDERCOLOR bcolor;
            public BORDERTYPE  btype;
            public int         size;

            public BORDER(BORDERCOLOR bc, BORDERTYPE bt, int bs)
            {
                bcolor = bc;
                btype = bt;
                size = bs;
            }
        }
    }
}
