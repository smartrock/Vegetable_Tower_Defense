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
        List<Missile> missiles = new List<Missile>();
        Waves[] length = new Waves[5];

        public int units = 0;
        public bool pause = false;
        public int waves = 0;

        public FrmGame()
        {
            InitializeComponent();
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, PnlGame, new object[] { true });
            for (int i = 0; i < 5; i++)
            {
                length[i] = new Waves();
            }
        }

        private void PnlGame_Paint(object sender, PaintEventArgs e)
        {
            //get the graphics used to paint on the panel control
            g = e.Graphics;
            //call the Planet class's DrawPlanet method to draw the image planet1 
            foreach (Missile m in missiles)
            {
                m.drawMissile(g);
                m.moveMissile(g);
            }

            foreach (Waves w in length)
            {
                w.DrawWaves(g);
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
            TmrWave.Enabled = true;
            TmrMissile.Enabled = true;
            pause = false;
        }

        private void TmrScreen_Tick(object sender, EventArgs e)
        {
            PnlGame.Invalidate();
        }
    }
}
