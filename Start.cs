using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace TylerGrenside301Game
{
    public partial class Start : Form
    {
        public static string playerName;
        public Start()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)  //Puts game into hard mode (Sets number of lives)
        {
            playerName = txtName.Text;


            if (Regex.IsMatch(playerName, @"^[a-zA-Z]+$"))//checks playerName for letters
            {
                //if playerName valid (only letters) 
                MessageBox.Show("Oh no! It's raining! And you left your pet slime " + playerName + " outside! Slimes are weak against water so you better help guide " + playerName + " to dodge them! Click Ok when you are ready to begin. (This is Easy Mode, you will have Ten Lives)");
                Form1.lives = 10;
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();
            }
            else
            {
                //invalid playerName, clear txtName and focus on it to try again
                MessageBox.Show("please enter a name using letters only!");
                txtName.Clear();

                txtName.Focus();
            }
            
           
            
           

        }

        private void buttonNorm_Click(object sender, EventArgs e) //Puts game into Normal mode (Decreases number of lives)
        {
            playerName = txtName.Text;


            if (Regex.IsMatch(playerName, @"^[a-zA-Z]+$"))//checks playerName for letters
            {
                //if playerName valid (only letters) 
                MessageBox.Show("Oh no! It's raining! And you left your pet slime " + playerName + " outside! Slimes are weak against water so you better help guide " + playerName + " to dodge them! Click Ok when you are ready to begin. (This is Normal Mode, you will have Five Lives)");
                Form1.lives = 5;
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();
            }
            else
            {
                //invalid playerName, clear txtName and focus on it to try again
                MessageBox.Show("please enter a name using letters only!");
                txtName.Clear();

                txtName.Focus();
            }
        }

        private void buttonHard_Click(object sender, EventArgs e) //Puts game into hard mode (Decreases number of lives)
        {
            playerName = txtName.Text;


            if (Regex.IsMatch(playerName, @"^[a-zA-Z]+$"))//checks playerName for letters
            {
                //if playerName valid (only letters) 
                MessageBox.Show("Oh no! It's raining! And you left your pet slime " + playerName + " outside! Slimes are weak against water so you better help guide " + playerName + " to dodge them! Click Ok when you are ready to begin. (This is Hard Mode, you will have Two Lives)");
                Form1.lives = 2;
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();
            }
            else
            {
                //invalid playerName, clear txtName and focus on it to try again
                MessageBox.Show("please enter a name using letters only!");
                txtName.Clear();

                txtName.Focus();
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
