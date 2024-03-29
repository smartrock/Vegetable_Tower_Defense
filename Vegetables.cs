﻿using System;
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
        public int x, y, width, height, speed, health, type, movespeed; // Declearing int variables
        public Image[] vegeImg = new Image[5];//variable for the different vegetable images
        public Rectangle vegearea = new Rectangle(); // Rectangles to contain the vegetable images

        //Adding the coordinates where the game map changes direction
        Point Turn1 = new Point(130, 120);
        Point Turn2 = new Point(130, 345);
        Point Turn3 = new Point(265, 345);
        Point Turn4 = new Point(265, 125);
        Point Turn5 = new Point(422, 125);
        Point Turn6 = new Point(422, 350);

        public Vegetables(int Type)
        {
            foreach (GetVegieInfo i in GlobalVariables.vegieInfo) // Repeats this function the same number as vegieInfo length
            {
                if (i.Type == Type)
                {
                    // Gathering and setting vegetable info for in class use
                    health = i.Health;
                    speed = i.Speed;
                    type = i.Type;
                }
            }

            x = 0; // Starting coordinates for the vegetables
            y = 120;
            width = 32; // Vegetable rectangle dimentions
            height = 32;
            movespeed = speed + 1; // Makes a fair speed for the vegetables to move on screen
            // Sets different images with their type
            vegeImg[0] = Properties.Resources.pea;
            vegeImg[1] = Properties.Resources.onion;
            vegeImg[2] = Properties.Resources.carrot;
            vegeImg[3] = Properties.Resources.tomato;
            vegeImg[4] = Properties.Resources.potato;
            vegearea = new Rectangle(x, y, width, height);
        }

        public void DrawVegetables(Graphics g)
        {
            vegearea = new Rectangle(x, y, width, height); //Creates rectangle with location and size
            g.DrawImage(vegeImg[type], vegearea); // Binds image and rectangle and draws them together
        }

        public void MoveVegetables(Graphics g)
        {

            if (GlobalVariables.play == true) // Checks that the game isn't paused
            {
                //Changes path that waves move at the turning pints on the background map
                if (x < Turn1.X)
                {
                    x += movespeed;
                }
                else if (x >= Turn1.X && y <= Turn2.Y && x <= Turn3.X)
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
                    GlobalVariables.lives = GlobalVariables.lives - health; // Changes lives once the vegetables reach the end
                    GlobalVariables.vegetables.Remove(this); // Removes vegetable once it is off the screen
                }
            }

            vegearea.Location = new Point(x, y); // Updates vegeares' location
            DrawVegetables(g); // Calls the draw function to draw the vegetable in its new position
        }
    }
}
