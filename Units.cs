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
                unitimage = Properties.Resources.holding;
            }
            if (unittype == "2")
            {
                unitimage = Properties.Resources.holding2;
            }
            if (unittype == "3")
            {
                unitimage = Properties.Resources.holding3;
            }
            if (unittype == "4")
            {
                unitimage = Properties.Resources.holding4;
            }
            if (unittype == "5")
            {
                unitimage = Properties.Resources.holding5;
            }
        }

        public void DrawUnit(Graphics g)
        {
            unitrec = new Rectangle(xu, yu, width, height);
            g.DrawImage(unitimage, unitrec);
        }
    }
}
