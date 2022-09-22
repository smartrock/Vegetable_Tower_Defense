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
        public int x, y, width, height, speed, health, type;
        public Image[] vege = new Image[5];//variable for the different vegetable images
        public Rectangle[] vegearea = new Rectangle[5]; // Rectangles to contain the vegetable images

        public Vegetables(int Type)
        {
            foreach (GetVegieInfo i in GlobalVariables.vegieInfo)
            {
                if (i.Type == Type)
                {

                }
            }

            x = 0;
            y = 122;
            width = 32;
            height = 32;
            vege[0] = Properties.Resources.pea;
            vege[1] = Properties.Resources.onion;
            vege[2] = Properties.Resources.carrot;
            vege[3] = Properties.Resources.tomato;
            vege[4] = Properties.Resources.potato;
            //vegearea = new Rectangle(x, y, width, height);
            type = Type;
        }

        public void DrawVegetables(Graphics g)
        {
            for (int i = 0; i < 5; i++)
            {
                g.DrawImage(vege[i], vegearea[i]);
            }
        }
    }
}
