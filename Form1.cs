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
        List<Units> unit = new List<Units>();

        public int units = 0;
        public int waves = 0;
        public int score = 0;
        public int lives = 20;
        public int money = 200;
        public bool pause = false;

        public FrmGame()
        {
            InitializeComponent();
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, PnlGame, new object[] { true });
            //for (int i = 0; i < 5; i++)
            //{
            //    length[i] = new Waves();
            //}
            TmrMissile.Enabled = false;
            TmrWave.Enabled = false;
            TmrScreen.Enabled = true;
            MessageBox.Show("The aim of the game is to stop the vegetables from leaving the farmers field and making it to the farmers market where they can " +
                "start making people healthy. To stop them you must buy and drag units onto the playing area and use the mouse to help shoot at targets. Once the vegetables are" +
                " destroyed, you will recieve more money to buy units and your score wil increase. Be warned though as if you don't shoot the vege in time, they will cost you " +
                "lives, once they run out, game over. It might seem easy at first but prepare for the future as the numbers and frequency will increase.", "How to play");
        }

        private void PnlGame_Paint(object sender, PaintEventArgs e)
        {
            //get the graphics used to paint on the panel control
            g = e.Graphics;
            //call the Planet class's DrawPlanet method to draw the image planet1 
            //foreach (Missile m in missiles)
            //{
            //    m.drawMissile(g);
            //    m.moveMissile(g);
            //}

            //foreach (Vegetables v in length)
            //{
            //    v.DrawVegetables(g);
            //}

            foreach (Units u in unit)
            {
                u.DrawUnit(g);
            }
        }

        private void MnuPause_Click(object sender, EventArgs e)
        {
            TmrWave.Enabled = false;
            TmrMissile.Enabled = false;
            pause = true;
        }

        private void MnuPlay_Click(object sender, EventArgs e)
        {
            TxtName.Enabled = false;
            TmrWave.Enabled = true;
            TmrMissile.Enabled = true;
            pause = false;
        }

        private void TmrScreen_Tick(object sender, EventArgs e)
        {
            PnlGame.Invalidate();
        }

        private void TmrWave_Tick(object sender, EventArgs e)
        {
            //if ()
            //{
            //    for (int i = 0; i < waves; i++)
            //    {
            //        length.Add(new Waves());
            //    }
            //}
            //TmrWave.Enabled = false;
        }

        private void FrmGame_Load(object sender, EventArgs e)
        {
            LblLives.Text = lives.ToString();
            LblWaves.Text = waves.ToString();
            LblMoney.Text = money.ToString();
            LblScore.Text = score.ToString();
            TxtName.Focus();
            MnuPause.Enabled = false;
            MnuPlay.Enabled = false;

            //Vegetables specific info
            GlobalVariables.vegieInfo.Add(new GetVegieInfo(0,1,5));
            GlobalVariables.vegieInfo.Add(new GetVegieInfo(1, 4, 4));
            GlobalVariables.vegieInfo.Add(new GetVegieInfo(2, 8, 3));
            GlobalVariables.vegieInfo.Add(new GetVegieInfo(3, 15, 2));
            GlobalVariables.vegieInfo.Add(new GetVegieInfo(4, 30, 1));

            //Units specific info
            GlobalVariables.unitInfo.Add(new GetUnitInfo(1, 1, 1, 1));
        }
        private void TxtName_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            // The code for imputing your name
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                // If key pressed not letter then don't add it to text box
                e.Handled = true;
            }

            if (TxtName.Text != "") // If the text box isn't empty then enable start button
            {
                MnuPlay.Enabled = true;
                MnuPause.Enabled = true;
            }
            if (TxtName.Text == "") // If the text box isn't empty then enable start button
            {
                MnuPlay.Enabled = false;
                MnuPause.Enabled = false;
            }
        }
    }
}
