using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;

namespace Vegetable_Tower_Defense
{
    class Waves
    {
        public int x, y, movespeed, number; //Declearing class variables
        public List<Vegetables> Number = new List<Vegetables>();
        //Adding the coordinates where 
        Point Turn1 = new Point(130, 145);
        Point Turn2 = new Point(130, 355);
        Point Turn3 = new Point(275, 145);
        Point Turn4 = new Point(275, 355);
        Point Turn5 = new Point(435, 145);
        Point Turn6 = new Point(435, 355);

        public Waves(int speed, int waves)
        {
            movespeed = speed * 2;
            number = waves;
        }

        public void DrawWaves(Graphics g)
        {
            for (int i = 0; i< number; i++)
            {
                Number.Add(new Vegetables(2));
            }
        }

        public void MoveWaves(Graphics g)
        {
            //Changes path that waves move at the turning pints on the background map
            if (x < Turn1.X)
            {
                x += movespeed;
            }
            else if (x == Turn1.X && y != Turn2.Y)
            {
                y += movespeed;
            }
            else if (y == Turn2.Y && x != Turn3.X)
            {
                x += movespeed;
            }
            else if (x == Turn3.X && y != Turn4.Y)
            {
                y -= movespeed;
            }
            else if (y == Turn4.Y && x != Turn5.X)
            {
                x += movespeed;
            }
            else if (x == Turn5.X && y != Turn6.Y)
            {
                y += movespeed;
            }
            else if (y == Turn6.Y && x < 580)
            {
                x += movespeed;
            }
        }

    }
}
