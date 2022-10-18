using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace Vegetable_Tower_Defense
{
    public partial class FrmGame : Form
    {
        Graphics g; //declare a graphics object called g 

        public FrmGame()
        {
            InitializeComponent();
            // Stops panel on game screen flickering when it is redrawn in quick sucession
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, PnlGame, new object[] { true });
            // Enables / disables the game timers
            TmrMissile.Enabled = false;
            TmrScreen.Enabled = true;
            // Gives the rules and aim of the games on start up
            MessageBox.Show("The aim of the game is to stop the vegetables from leaving the farmers field and making it to the farmers market where they can " +
                "start making people healthy. To stop them you must buy and drag units onto the playing area and use the mouse to help shoot at targets. Once the vegetables are" +
                " destroyed, you will recieve more money to buy units and your score wil increase. Be warned though as if you don't shoot the vege in time, they will cost you " +
                "lives, once they run out, game over. It might seem easy at first but prepare for the future as the numbers and frequency will increase.", "How to play");
        }
        
        private void FrmGame_Load(object sender, EventArgs e)
        {
            // Resetting the labels on game screen to show the actual values
            LblLives.Text = GlobalVariables.lives.ToString();
            LblWaves.Text = GlobalVariables.waves.ToString();
            LblMoney.Text = GlobalVariables.money.ToString();
            LblScore.Text = GlobalVariables.score.ToString();
            TxtName.Focus(); // Highlights text box for players to input their name
            MnuPause.Enabled = false; // Sets pause and play to false until the player has entred their name
            MnuPlay.Enabled = false;

            // Vegetables specific info; type, health, speed
            GlobalVariables.vegieInfo.Add(new GetVegieInfo(0,1,5));
            GlobalVariables.vegieInfo.Add(new GetVegieInfo(1, 4, 4));
            GlobalVariables.vegieInfo.Add(new GetVegieInfo(2, 8, 3));
            GlobalVariables.vegieInfo.Add(new GetVegieInfo(3, 15, 2));
            GlobalVariables.vegieInfo.Add(new GetVegieInfo(4, 30, 1));

            // Units specific info; type, speed, range, damage, cost
            GlobalVariables.unitInfo.Add(new GetUnitInfo(0, 1, 150, 1, 50));
            GlobalVariables.unitInfo.Add(new GetUnitInfo(1, 1, 100, 5, 100));
            GlobalVariables.unitInfo.Add(new GetUnitInfo(3, 1, 200, 1, 200));
            GlobalVariables.unitInfo.Add(new GetUnitInfo(4, 1, 150, 1, 350));
            GlobalVariables.unitInfo.Add(new GetUnitInfo(5, 1, 300, 1, 500));
            
            // Assigning values to the global ints
            GlobalVariables.waves = 0;
            GlobalVariables.score = 0;
            GlobalVariables.lives = 50;
            GlobalVariables.money = 200;
            
            // Assigning values to the global bools
            GlobalVariables.play = true;
            GlobalVariables.space;
        }
        
        private void PnlGame_Paint(object sender, PaintEventArgs e)
        {
            //get the graphics used to paint on the panel control
            g = e.Graphics;

            // Updating values on game screen
            LblScore.Text = GlobalVariables.score.ToString();
            LblLives.Text = GlobalVariables.lives.ToString();
            LblWaves.Text = GlobalVariables.waves.ToString();
            LblMoney.Text = GlobalVariables.money.ToString();

            foreach (Units u in GlobalVariables.units) // The drawing and movement controls for the units class
            {
                u.DrawUnit(g);
                //u.MoveUnit(g);
            }
            foreach (Vegetables v in GlobalVariables.vegetables) // The drawing and movement controls for the vegetables 
            {
                v.MoveVegetables(g);
                break;// Stops the code breaking once all the vegetables have been destroyed
            }
        }

        public void PreLevel()
        {
            // Sets up each waves 
            int n;
            n = GlobalVariables.waves;
            for (int i = 0; i < n; i++)
            {  
                // Adds same number of basic level vegetables as wave count
                GlobalVariables.vegetables.Add(new Vegetables(0));
            }
            if (n >= (n - 5))
            {
                // Adds 5 less of second level vegetables as number in wave count
                for (int i = 0; i < (n - 5); i++)
                {
                    GlobalVariables.vegetables.Add(new Vegetables(1));
                }
            }
            if (n >= (n - 10))
            {
                // Adds 10 less of second level vegetables as number in wave count
                for (int i = 0; i < (n - 10); i++)
                {
                    GlobalVariables.vegetables.Add(new Vegetables(2));
                }
            }
            if (n >= (n - 15))
            {
                // Adds 15 less of second level vegetables as number in wave count
                for (int i = 0; i < (n - 15); i++)
                {
                    GlobalVariables.vegetables.Add(new Vegetables(3));
                }
            }
            if (n >= (n - 20))
            {
                // Adds 20 less of second level vegetables as number in wave count
                for (int i = 0; i < (n - 20); i++)
                {
                    GlobalVariables.vegetables.Add(new Vegetables(4));
                }
            }
            if (n >= (n - 25))
            {
                // Adds 25 less of second level vegetables as number in wave count
                for (int i = 0; i < (n - 25); i++)
                {
                    GlobalVariables.vegetables.Add(new Vegetables(5));
                }
            }
        }


        private void MnuPause_Click(object sender, EventArgs e)
        {
            GlobalVariables.play = false; // Sets whole game variable to false to stop the waves in the vegetables class
            TmrWave.Enabled = false; // Stops waves timer
            TmrMissile.Enabled = false; // Stops units missile timer
            MnuPlay.Enabled = true; // Allows players to restart the game
            MnuPause.Enabled = false; // Disables pause until play is clicked again
        }

        private void MnuPlay_Click(object sender, EventArgs e)
        {
            TxtName.Enabled = false; // Freezes name in corner of the screen
            
            if (GlobalVariables.play == true) // If the game isn't paused then start next level
            {
                GlobalVariables.waves = GlobalVariables.waves + 1; // Adds one to the count of the length of waves to bring a harder waves
                TmrWave.Enabled = true; // Starts waves timer
                TmrMissile.Enabled = true; // Starts units missile timer
                TmrScreen.Enabled = true; // Checks screen timer is running
                PreLevel(); // Calls function to run level and add vegetables to the screen
                MnuPause.Enabled = true; // Allows the pause button to be used
                MnuPlay.Enabled = false; // Disables play button while level / waves is in action
            }
            else // If game is pause then just continue on same level with out adding more vegetables
            {
                TmrMissile.Enabled = true; // Starts units missile timer
                TmrScreen.Enabled = true; // Checks screen timer is running
                MnuPause.Enabled = true; // Allows the pause button to be used
                MnuPlay.Enabled = false; // Disables play button while level / waves is in action
            }
        }

        private void TmrScreen_Tick(object sender, EventArgs e)
        {
            // Keeps refreshing the game screen when the vegetables are moving and when units are being added to the playing field 
            PnlGame.Invalidate();
            
            if (GlobalVariables.vegetables.Count() <= 0) // Checks to see if all the vegetables for the wave have been destroyed
            {
                MnuPlay.Enabled = true; // Allows the play button to be pushed to start the next wave
                GlobalVariables.play = true;
            }
        }

        private void TmrWave_Tick(object sender, EventArgs e)
        {
            int i;
            i = GlobalVariables.waves;
        }

        private void TxtName_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            // The code for imputing your name
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                // If key pressed is not a letter then don't add it to text box
                e.Handled = true;
            }
            
            if (TxtName.Text == "") // If the text box isn't empty then enable start button
            {
                MnuPlay.Enabled = false;
                MnuPause.Enabled = false;
            }
            
            if (TxtName.Text != "") // If the text box isn't empty then enable start button
            {
                MnuPlay.Enabled = true;
                MnuPause.Enabled = true;
            }
        }

        private void FrmGame_MouseMove(object sender, MouseEventArgs e)
        {
            if (GlobalVariables.units.Count() <= 0) // Checks to see if the list of units is greater than 1
            {
                Units.MoveUnit(e.X, e.Y); // Moves unit to the mouse X, Y coordinates
            }
        }

        private void BtnUnit0_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.money >= 50) // Checks to see if the unit you have clicked is less than the money you have
            {
                GlobalVariables.money = GlobalVariables.money - 50; // Changes money down
                GlobalVariables.units.Add(new Units(0)); // Creates a new unit
            }
            else
            {
                // Show a message saying the you can't buy the unit
                MessageBox.Show("You don't have enough money to buy this. Try destroying more vegetables before coming back", "Bank Alert!");
            }
        }

        private void BtnUnit1_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.money >= 100) // Checks to see if the unit you have clicked is less than the money you have
            {
                GlobalVariables.money = GlobalVariables.money - 100; // Changes money down
                GlobalVariables.units.Add(new Units(1)); // Creates a new unit
            }
            else
            {
                // Show a message saying the you can't buy the unit
                MessageBox.Show("You don't have enough money to buy this. Try destroying more vegetables before coming back", "Bank Alert!");
            }
        }

        private void BtnUnit2_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.money >= 200) // Checks to see if the unit you have clicked is less than the money you have
            {
                GlobalVariables.money = GlobalVariables.money - 200; // Changes money down
                GlobalVariables.units.Add(new Units(2)); // Creates a new unit
            }
            else
            {
                // Show a message saying the you can't buy the unit
                MessageBox.Show("You don't have enough money to buy this. Try destroying more vegetables before coming back", "Bank Alert!");
            }
        }

        private void BtnUnit3_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.money >= 350) // Checks to see if the unit you have clicked is less than the money you have
            {
                GlobalVariables.money = GlobalVariables.money - 350; // Changes money down
                GlobalVariables.units.Add(new Units(3)); // Creates a new unit
            }
            else
            {
                // Show a message saying the you can't buy the unit
                MessageBox.Show("You don't have enough money to buy this. Try destroying more vegetables before coming back", "Bank Alert!");
            }
        }

        private void BtnUnit4_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.money >= 500) // Checks to see if the unit you have clicked is less than the money you have
            {
                GlobalVariables.money = GlobalVariables.money - 500; // Changes money down
                GlobalVariables.units.Add(new Units(4)); // Creates a new unit
            }
            else
            {
                // Show a message saying the you can't buy the unit
                MessageBox.Show("You don't have enough money to buy this. Try destroying more vegetables before coming back", "Bank Alert!");
            }
        }

        private void FrmGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Space) { GlobalVariables.space = true; } // Checks to see if the space bar is being pressed
        }

        private void FrmGame_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Space) { GlobalVariables.space = false; } // Checks to see if the space bar isn't being pressed
        }

        //private void Form1_MouseDown(object sender, MouseEventArgs e)
        //{
        //    foreach (Rectangle r in units)
        //    {
        //        if (area[count].Contains(e.X, e.Y))
        //        {
        //            area[count].Location = new Point(e.X, e.Y);
        //        }
        //    }
        //}
    }
}
