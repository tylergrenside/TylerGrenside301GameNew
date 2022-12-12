using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace TylerGrenside301Game
{
    class Dru
    {


        // declare fields to use in the class
        public int x, y, width, height;//variables for the rectangle
        public Image druImage;//variable for the planet's image

        public Rectangle druRec;//variable for a rectangle to place our image in
        public int score;
        
        //Create a constructor (initialises the values of the fields)
        public Dru(int spacing)
        {
            x = spacing;
            y = 10;
            width = 50;
            height = 39;
            //planetImage contains the plane1.png image
            druImage = Properties.Resources.DruE;
            druRec = new Rectangle(x, y, width, height);
        }
        // Methods for the Planet class
        public void DrawDru(Graphics g)
        {
            druRec = new Rectangle(x, y, width, height);

            g.DrawImage(druImage, druRec);
        }
        public void MoveDru()
        {

            druRec.Location = new Point(x, y);
        }


    }
}
