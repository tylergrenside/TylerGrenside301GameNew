using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TylerGrenside301Game
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Form1.lives = 10;
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void buttonNorm_Click(object sender, EventArgs e)
        {
            Form1.lives = 5;
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void buttonHard_Click(object sender, EventArgs e)
        {
            Form1.lives = 3;
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }
    }
}
