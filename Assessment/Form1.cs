using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment
{
    public partial class FrmAssessment : Form
    {
        Graphics g; // declare the graphics
        int x = 20, y = 25;// starting position of planet

        //Declare the rectangles to display the sharks and surfer in
        Rectangle surferRectangle;
        Rectangle[] sharksRectangle = new Rectangle[8];//sharks[0] to sharks[8]
        int x2 = 50, y2 = 290; //starting position of surfer

        //Load our two images from the bin\debug folder
        Image surfer = Image.FromFile(Application.StartupPath + @"\surfer.jpg");
        Image shark = Image.FromFile(Application.StartupPath + @"\shark.jpg");

        int[] sharkSpeed = new int[8];
        int score = 0;
        int lives = 5;

        Random speed = new Random();

        public FrmAssessment()
        {
            InitializeComponent();

            surferRectangle = new Rectangle(x2, y2, 30, 30);//spaceship's rectangle	
            
            //position the planets
            for (int i = 0; i <= 7; i++)
            {
                sharksRectangle[i] = new Rectangle(x + 70 * i, y, 40, 40);
                sharkSpeed[i] = speed.Next(5, 10);//each planet has a random speed
            }
        }

        private void PnlGame_Paint(object sender, PaintEventArgs e)
        {
            //get the methods from the graphic's class to paint on the panel
            g = e.Graphics;
            //use the DrawImage method to draw the spaceship on the panel
            g.DrawImage(surfer, surferRectangle);
            //use the DrawImage method to draw the planet on the panel
            for (int i = 0; i <= 7; i++)
            {
                g.DrawImage(shark, sharksRectangle[i]);
            }
        }

        private void TmrMove_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i <= 7; i++)
            {
                sharksRectangle[i].Y += sharkSpeed[i];
                //if spaceship collides with any planet lose a life and move planet to the top of the panel
                if (sharksRectangle[i].IntersectsWith(surferRectangle))
                {
                    sharksRectangle[i].Y = 25;
                    lives -= 1; // reduce lives by 1
                }
                if (sharksRectangle[i].Y > PnlGame.Height)
                {
                    score += 1; //add 1 to score

                    sharksRectangle[i].Y = 25;
                }

                PnlGame.Invalidate();
            }
            
        }

    }
}
