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
        public int x, y, width, height, type, speed, range, damage, cost; // Declearing in use variables 
        public Rectangle unitrec = new Rectangle(); // rectangle for unit image to be inside
        public Image[] unitimage = new Image[5]; // Image array for the different unit types

        public Units(int X, int Y, int Type)
        {
            foreach (GetUnitInfo i in GlobalVariables.unitInfo)
            {
                if (i.Type == Type)
                {
                    // Gets the specific unit info from global variables
                    health = i.Health;
                    speed = i.Speed;
                    type = i.Type;
                    damage = i.Damage;
                    cost = i.Cost;
                }
            }

            x = X;
            y = Y;
            width = 50;
            height = 50;

            // Sets up the correct image with the corresponding type number
            unitimage[0] = Properties.Resources.holding;
            unitimage[1] = Properties.Resources.holding1;
            unitimage[2] = Properties.Resources.holding2;
            unitimage[3] = Properties.Resources.holding3;
            unitimage[4] = Properties.Resources.holding4;
            // Creates rectangle for units
            unitrec = new Rectangle(x, y, width, height);
        }

        public void DrawUnit(Graphics g)
        {
            unitrec = new Rectangle(x, y, width, height); // Binds location and size together
            g.DrawImage(unitimage[type], unitrec); // Draws image with its rectangle
        }
        
        public void MoveUnit(Graphics g)
        {
            
            unitrec.Location = new Point(x,y); // Sets new rectangle location
        }
    }
}
