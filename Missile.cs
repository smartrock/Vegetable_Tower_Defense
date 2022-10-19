using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;

namespace Vegetable_Tower_Defense
{
    class Missile
    {
        // declare fields to use in the class
        public int x, y, width, height;//variables for the rectangle
        public int missileRotated;
        public double xSpeed, ySpeed;
        public Image missileImage;//variable for the missile's image
        public Rectangle missileRec;//variable for a rectangle to place our image in
        public Matrix matrixMissile;
        Point centreMissile;

        //Create a constructor (initialises the values of the fields)
        public Missile()
        {
            x = 250;
            y = 250;
            width = 20;
            height = 20;
            //planetImage contains the plane1.png image
            missileImage = Properties.Resources.missile; 
            //this code works out the speed of the missile to be used in the moveMissile method
            xSpeed = 30 * (Math.Cos(( - 90) * Math.PI / 180));
            ySpeed = 30 * (Math.Sin(( + 90) * Math.PI / 180));
            //calculate x,y to move missile to middle of spaceship in drawMissile method
            //x = unitrec.X + spaceRec.Width / 2;
            //y = spaceRec.Y + spaceRec.Height / 2;
            //pass missileRotate angle to missileRotated so that it can be used in the drawMissile method
            missileRotated = 0;
            missileRec = new Rectangle(x, y, width, height);
        }
        
        public void DrawMissile(Graphics g)
        {
            missileRec = new Rectangle(x, y, width, height); 
            //centre missile 
            centreMissile = new Point(x, y);
            //instantiate a Matrix object called matrixMissile
            matrixMissile = new Matrix();
            //rotate the matrix (in this case missileRec) about its centre
            matrixMissile.RotateAt(missileRotated, centreMissile);
            //Set the current draw location to the rotated matrix point i.e. where missileRec is now
            g.Transform = matrixMissile;
            //Draw the missile
            g.DrawImage(missileImage, missileRec);
        }
        
        public void MoveMissile(Graphics g)
        {
            x += (int)xSpeed;//cast double to an integer value
            y -= (int)ySpeed;
            missileRec.Location = new Point(x, y);//missiles new location
        }
    }
}
