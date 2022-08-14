﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Vegetable_Tower_Defense
{
    class Waves
    {
        public int x, y, width, height;
        public Image[] vege = new Image[5];//variable for the different vegetable images
        public Rectangle[] vegearea = new Rectangle[5]; // Rectangles to contain the vegetable images
        Point[] turns = new Point[6];

        public Waves()
        {
            x = 0;
            y = 125;
            width = 32;
            height = 32;
            vege[0] = Properties.Resources.pea; 
            vege[1] = Properties.Resources.onion;
            vege[2] = Properties.Resources.carrot;
            vege[3] = Properties.Resources.tomato;
            vege[4] = Properties.Resources.potato;
            vegearea[4] = new Rectangle(x, y, width, height);
        }

        public void DrawWaves(Graphics g)
        {
            for(int i = 0; i<5; i++)
            {
                g.DrawImage(vege[i], vegearea[i]);
            }
        }

        public void moveWaves(Graphics g)
        {
            
        }

    }
}