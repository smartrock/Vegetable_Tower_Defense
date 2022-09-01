using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;

namespace Vegetable_Tower_Defense
{
    class Units
    {
        public int xu, yu, width, height;
        public int unitslength;
        public double speed, range, reload;
        public string unittype;
        public Rectangle unitrec;
        public Image unitimage;

        public Units(int X, int Y, string Name)
        {
            xu = X;
            yu = Y;
            width = 50;
            height = 50;
            unittype = Name;

            if (unittype == "1")
            {

            }
            if (unittype == "2")
            {

            }
            if (unittype == "3")
            {

            }
            if (unittype == "4")
            {

            }
            if (unittype == "5")
            {

            }
        }
    }
}
