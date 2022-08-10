
namespace Vegetable_Tower_Defense
{
    partial class FrmGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGame));
            this.MnuGame = new System.Windows.Forms.MenuStrip();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuPlay = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuPause = new System.Windows.Forms.ToolStripMenuItem();
            this.TmrWave = new System.Windows.Forms.Timer(this.components);
            this.LblScore = new System.Windows.Forms.Label();
            this.LblWaves = new System.Windows.Forms.Label();
            this.LblMoney = new System.Windows.Forms.Label();
            this.LblLives = new System.Windows.Forms.Label();
            this.TmrScreen = new System.Windows.Forms.Timer(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PnlGame = new System.Windows.Forms.Panel();
            this.TmrMissile = new System.Windows.Forms.Timer(this.components);
            this.MnuGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MnuGame
            // 
            this.MnuGame.BackColor = System.Drawing.Color.DarkGray;
            this.MnuGame.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playToolStripMenuItem,
            this.MnuPlay,
            this.MnuPause});
            resources.ApplyResources(this.MnuGame, "MnuGame");
            this.MnuGame.Name = "MnuGame";
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem});
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            resources.ApplyResources(this.playToolStripMenuItem, "playToolStripMenuItem");
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            resources.ApplyResources(this.homeToolStripMenuItem, "homeToolStripMenuItem");
            // 
            // MnuPlay
            // 
            this.MnuPlay.Name = "MnuPlay";
            resources.ApplyResources(this.MnuPlay, "MnuPlay");
            this.MnuPlay.Click += new System.EventHandler(this.MnuPlay_Click);
            // 
            // MnuPause
            // 
            this.MnuPause.Name = "MnuPause";
            resources.ApplyResources(this.MnuPause, "MnuPause");
            this.MnuPause.Click += new System.EventHandler(this.MnuPause_Click);
            // 
            // LblScore
            // 
            resources.ApplyResources(this.LblScore, "LblScore");
            this.LblScore.Name = "LblScore";
            // 
            // LblWaves
            // 
            resources.ApplyResources(this.LblWaves, "LblWaves");
            this.LblWaves.Name = "LblWaves";
            // 
            // LblMoney
            // 
            resources.ApplyResources(this.LblMoney, "LblMoney");
            this.LblMoney.Name = "LblMoney";
            // 
            // LblLives
            // 
            resources.ApplyResources(this.LblLives, "LblLives");
            this.LblLives.Name = "LblLives";
            // 
            // TmrScreen
            // 
            this.TmrScreen.Tick += new System.EventHandler(this.TmrScreen_Tick);
            // 
            // pictureBox3
            // 
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Vegetable_Tower_Defense.Properties.Resources.coin;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Vegetable_Tower_Defense.Properties.Resources.wave;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Vegetable_Tower_Defense.Properties.Resources.heart;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // PnlGame
            // 
            this.PnlGame.BackgroundImage = global::Vegetable_Tower_Defense.Properties.Resources.mapp;
            resources.ApplyResources(this.PnlGame, "PnlGame");
            this.PnlGame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlGame.Name = "PnlGame";
            this.PnlGame.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlGame_Paint);
            // 
            // TmrMissile
            // 
            this.TmrMissile.Interval = 50;
            // 
            // FrmGame
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LblLives);
            this.Controls.Add(this.LblMoney);
            this.Controls.Add(this.LblWaves);
            this.Controls.Add(this.LblScore);
            this.Controls.Add(this.PnlGame);
            this.Controls.Add(this.MnuGame);
            this.DoubleBuffered = true;
            this.Name = "FrmGame";
            this.MnuGame.ResumeLayout(false);
            this.MnuGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlGame;
        private System.Windows.Forms.MenuStrip MnuGame;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuPlay;
        private System.Windows.Forms.ToolStripMenuItem MnuPause;
        private System.Windows.Forms.Timer TmrWave;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.Label LblScore;
        private System.Windows.Forms.Label LblWaves;
        private System.Windows.Forms.Label LblMoney;
        private System.Windows.Forms.Label LblLives;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Timer TmrScreen;
        private System.Windows.Forms.Timer TmrMissile;
    }
}

