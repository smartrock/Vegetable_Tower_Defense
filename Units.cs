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

        public Units(int Type)
        {
            foreach (GetUnitInfo i in GlobalVariables.unitInfo)
            {
                if (i.Type == Type)
                {
                    // Gets the specific unit info from global variables
                    range = i.Range;
                    speed = i.Speed;
                    type = i.Type;
                    damage = i.Damage;
                    cost = i.Cost;
                }
            }

            x = 550;
            y = 30 + 80 * type;
            width = 50;
            height = 50;

            // Sets up the correct image with the corresponding type number
            unitimage[0] = Properties.Resources.unit0;
            unitimage[1] = Properties.Resources.unit1;
            unitimage[2] = Properties.Resources.unit2;
            unitimage[3] = Properties.Resources.unit3;
            unitimage[4] = Properties.Resources.unit4;
            // Creates rectangle for units
            unitrec = new Rectangle(x, y, width, height);
        }

        public void DrawUnit(Graphics g)
        {
            unitrec = new Rectangle(x, y, width, height); // Binds location and size together
            g.DrawImage(unitimage[type], unitrec); // Draws image with its rectangle
        }
        
        public void MoveUnit(int mouseX, int mouseY)
        {
            // Moving unit to mouse location
            x = mouseX - (width / 2);
            y = mouseY - (height / 2);
        }
    }
}
