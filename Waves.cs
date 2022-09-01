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
        public int xw, yw, width, height;
        public Image[] vege = new Image[5];//variable for the different vegetable images
        public Rectangle[] vegearea = new Rectangle[5]; // Rectangles to contain the vegetable images
        public double xTrans, yTrans;
        Point[] turns = new Point[6];
        //Point vegecentre = new Point();

        public Waves(Rectangle vegearea)
        {
            xw = 0;
            yw = 122;
            width = 32;
            height = 32;
            // Setting the images to specific rectangle types
            vege[0] = Properties.Resources.pea;
            vege[1] = Properties.Resources.onion;
            vege[2] = Properties.Resources.carrot;
            vege[3] = Properties.Resources.tomato;
            vege[4] = Properties.Resources.potato;
            vegearea = new Rectangle(xw, yw, width, height);
            xTrans = 10;
            yTrans = 0;
            xw = vegearea.X + vegearea.Height / 2;
            yw = vegearea.Y + vegearea.Width / 2;
        }

        public void DrawWaves(Graphics g)
        {
            //vegecentre = new Point(x, y);
            // Drawing the images and there respective rectangles
            for (int i = 0; i < 5; i++)
            {
                g.DrawImage(vege[i], vegearea[i]);
            }
        }

        public void moveWaves(Graphics g)
        {
            xw += (int)xTrans;//cast double to an integer value
            yw -= (int)yTrans;
            //vegearea.Location = new Point(x, y);//missiles new location
        }

    }
}
