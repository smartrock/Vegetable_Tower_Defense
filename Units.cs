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
        public int x, y, width, height, type, speed, range, damage;
        public string unittype;
        public Rectangle unitrec = new Rectangle();
        public Image[] unitimage = new Image[5];

        public Units(int X, int Y, int Type)
        {
            foreach (GetUnitInfo i in GlobalVariables.unitInfo)
            {
                if (i.Type == Type)
                {
                    health = i.Health;
                    speed = i.Speed;
                    type = i.Type;
                    damage = i.Damage;
                }
            }

            x = X;
            y = Y;
            width = 50;
            height = 50;

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
            unitrec = new Rectangle(x, y, width, height);
        }

        public void DrawUnit(Graphics g)
        {
            unitrec = new Rectangle(x, y, width, height);
            g.DrawImage(unitimage, unitrec);
        }
        
        public void MoveUnit(Graphics g)
        {
            unitrec.Location = new Point(x,y);
        }
    }
}
