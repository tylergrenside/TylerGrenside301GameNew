using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Reflection;
using System.Diagnostics;
using System.IO;
using System.Xml.Linq;


namespace TylerGrenside301Game
{
    public partial class Form1 : Form
    {
        Graphics g; //declare a graphics object called g
        Dru[] dru = new Dru[7]; //Create enemies
        Random yspeed = new Random();
        Slime slime = new Slime();//create object called slime 
        
        bool left, right, up, down;
        public static int score, lives;
        string move;
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 7; i++)
            {
                int x = 10 + (i * 100);
                dru[i] = new Dru(x);
            }



            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, pnlGame, new object[] { true });

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tmrSlime.Enabled = true;
            // pass lives from LblLives Text property to lives variable
            lblLives.Text = lives.ToString();
            lblName.Text = "Protect " + Start.playerName +"!" ;
        }

        


        private void pnlGame_Paint(object sender, PaintEventArgs e)
        {

            //get the graphics used to paint on the panel control
            g = e.Graphics;
            //call the enemy's class's DrawDru method to draw the image Dru
            for (int i = 0; i < 7; i++)
            {
                // generate a random number from 5 to 20 and put it in rndmspeed
                int rndmspeed = yspeed.Next(1, 8);
                dru[i].y += rndmspeed;

                //call the enemy's class's drawDru method to draw the images
                dru[i].DrawDru(g);
            }





            slime.drawSlime(g);
            
            

        }

        private void tmrDru_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 7; i++)
            {
                dru[i].MoveDru();
                if (slime.slimeRec.IntersectsWith(dru[i].druRec))
                {
                    //reset planet[i] back to top of panel
                    dru[i].y = 30; // set  y value of planetRec
                    lives -= 1;// lose a life
                    lblLives.Text = lives.ToString();// display number of lives
                    CheckLives();
                }

                //if an enemy reaches the bottom of the Game Area reposition it at the top
                if (dru[i].y >= pnlGame.Height)
                {
                    score += 1;//update the score
                    lblScore.Text = score.ToString();// display score
                    dru[i].y = 10;
                }

                pnlGame.Invalidate();//makes the paint event fire to redraw the panel

            }

        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            FrmHighScore FrmHighScore2 = new FrmHighScore(Start.playerName, lblScore.Text);

            Hide();
            FrmHighScore2.ShowDialog();

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.A) { left = true; }
            if (e.KeyData == Keys.D) { right = true; }
            if (e.KeyData == Keys.W) { up = true; }
            if (e.KeyData == Keys.S) { down = true; }

        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.A) { left = false; }
            if (e.KeyData == Keys.D) { right = false; }
            if (e.KeyData == Keys.W) { up = false; }
            if (e.KeyData == Keys.S) { down = false; }
        }



        private void tmrSlime_Tick(object sender, EventArgs e)
        {
            if (right) // if right arrow key pressed
            {

                move = "right";
                slime.MoveSlime(move);
            }
            if (left) // if left arrow key pressed
            {

                move = "left";
                slime.MoveSlime(move);
            }
            if (up) // if up arrow key pressed
            {

                move = "up";
                slime.MoveSlime(move);
            }
            if (down) // if down arrow key pressed
            {

                move = "down";
                slime.MoveSlime(move);
            }
            pnlGame.Invalidate();
            for (int i =0; i<1; i++)
            { 
            
            }
        }
        private void CheckLives()
        {
            if (lives == 0)
            {
                tmrDru.Enabled = false;
                tmrSlime.Enabled = false;
                MessageBox.Show("Game Over");

            }
        }


    }
}