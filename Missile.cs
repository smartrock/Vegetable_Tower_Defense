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
        public double missileRotate; // Variable for angle of missile
        public double xSpeed, ySpeed; // Movement speed of missile
        public Image missileImage;//variable for the missile's image
        public Rectangle missileRec;//variable for a rectangle to place our image in
        public Matrix matrixMissile;
        Point centreMissile;

        //Create a constructor (initialises the values of the fields)
        public Missile(Rectangle unitrec)
        {
            width = 20; // Width and height of missile rectange
            height = 20;
            x = unitrec.X + (width / 2); // Starting position at unit location
            y = unitrec.Y + (height / 2); // Starting position at unit location
            missileImage = Properties.Resources.missile; //planetImage contains the plane1.png image
            missileRotate = Math.Atan((GlobalVariables.MouseXPos - x) / (GlobalVariables.MouseYPos - y));
            missileRotated = (int)missileRotate; // Casting double to a int
            //this code works out the speed of the missile to be used in the moveMissile method
            xSpeed = 30 * (Math.Cos((missileRotated - 90) * Math.PI / 180));
            ySpeed = 30 * (Math.Sin((missileRotated + 90) * Math.PI / 180));
            //pass missileRotate angle to missileRotated so that it can be used in the drawMissile method
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
            if (GlobalVariables.play == true)
            {
                x += (int)xSpeed;//cast double to an integer value
                y -= (int)ySpeed;
                missileRec.Location = new Point(x, y);//missiles new location
            }
        }
    }
}
