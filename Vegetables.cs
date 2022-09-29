using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;

namespace Vegetable_Tower_Defense
{
    class Vegetables
    {
        public int x, y, width, height, speed, health, type, movespeed;
        public Image[] vegeImg = new Image[5];//variable for the different vegetable images
        public Rectangle vegearea = new Rectangle(); // Rectangles to contain the vegetable images

        //Adding the coordinates where 
        Point Turn1 = new Point(120, 145);
        Point Turn2 = new Point(120, 345);
        Point Turn3 = new Point(265, 345);
        Point Turn4 = new Point(265, 140);
        Point Turn5 = new Point(425, 140);
        Point Turn6 = new Point(425, 355);

        public Vegetables(int Type)
        {
            foreach (GetVegieInfo i in GlobalVariables.vegieInfo)
            {
                if (i.Type == Type)
                {
                    health = i.Health;
                    speed = i.Speed;
                    type = i.Type;
                }
            }

            x = 0;
            y = 122;
            width = 32;
            height = 32;
            movespeed = speed * 2;
            vegeImg[0] = Properties.Resources.pea;
            vegeImg[1] = Properties.Resources.onion;
            vegeImg[2] = Properties.Resources.carrot;
            vegeImg[3] = Properties.Resources.tomato;
            vegeImg[4] = Properties.Resources.potato;
            vegearea = new Rectangle(x, y, width, height);
        }

        public void DrawVegetables(Graphics g)
        {
            vegearea = new Rectangle(x, y, width, height);
            g.DrawImage(vegeImg[type], vegearea);
        }

        public void MoveVegetables(Graphics g)
        {
            //Changes path that waves move at the turning pints on the background map
            if (x < Turn1.X)
            {
                x += movespeed;
            }
            else if (x == Turn1.X && y <= Turn2.Y)
            {
                y += movespeed;
            }
            else if (y >= Turn2.Y && x <= Turn3.X)
            {
                x += movespeed;
            }
            else if (x >= Turn3.X && y >= Turn4.Y && x <= Turn5.X)
            {
                y -= movespeed;
            }
            else if (y <= Turn4.Y && x <= Turn5.X)
            {
                x += movespeed;
            }
            else if (x >= Turn5.X && y <= Turn6.Y)
            {
                y += movespeed;
            }
            else if (y >= Turn6.Y && x < 580)
            {
                x += movespeed;
            }
            else
            {

                GlobalVariables.vegetables.Remove(this);
            }

            vegearea.Location = new Point(x, y);
        }
    }
}
