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
        public int x, y, width, height, speed;
        Point Turn1 = new Point(130, 145);
        Point Turn2 = new Point(130, 355);
        Point Turn3 = new Point(275, 145);
        Point Turn4 = new Point(275, 355);
        Point Turn5 = new Point(435, 145);
        Point Turn6 = new Point(435, 355);

        public Waves()
        {
            // Setting the images to specific rectangle types
            
            //xw = vegearea.X + vegearea.Height / 2;
            //yw = vegearea.Y + vegearea.Width / 2;
        }

        public void DrawWaves(Graphics g)
        {
            //vegecentre = new Point(x, y);
            // Drawing the images and there respective rectangles
        }

        public void MoveWaves(Graphics g)
        {
            if (x < Turn1.X)
            {
                x += speed;
            }
            else if (x == Turn1.X && y != Turn2.Y)
            {
                y += speed;
            }
            else if (y == Turn2.Y && x != Turn3.X)
            {
                x += speed;
            }
            else if (x == Turn3.X && y != Turn4.Y)
            {
                y -= speed;
            }
            else if (y == Turn4.Y && x != Turn5.X)
            {
                x += speed;
            }
            else if (x == Turn5.X && y != Turn6.Y)
            {
                y += speed;
            }
            else if (y == Turn6.Y && x < 580)
            {
                x += speed;
            }
        }

    }
}
