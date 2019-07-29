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

namespace Assessment
{
    public partial class FrmAssessment : Form
    {
        Graphics g; // declare the graphics
        int y = 25, x = 20;// starting position of planet

        //Declare the rectangles to display the sharks and surfer in
        Rectangle surferRectangle;
        Rectangle bottleRectangle;
        
        Rectangle[] sharksRectangle = new Rectangle[8];//sharks[0] to sharks[8]
        int y2 = 50, x2 = 290; //starting position of surfer

        //Load our two images from the bin\debug folder
        Image surfer = Image.FromFile(Application.StartupPath + @"\surfer.jpg");
        Image shark = Image.FromFile(Application.StartupPath + @"\shark.jpg");

        Image bottle = Image.FromFile(Application.StartupPath + @"\bottle.jpg");

        int[] sharkSpeed = new int[5];
        int bottleSpeed = 17;
        int score = 0;
        int level = 1;
        int lives = 300;
        int IfButtonClick = 0;

        int usermamevalid = 0;
        int DifficultyLevel = 0;

        bool left, right, up, down;

        Random speed = new Random();

        Random xValue = new Random();
        int randThing = 0;


        public FrmAssessment()
        {
            InitializeComponent();

            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, PnlGame, new object[] { true });

            surferRectangle = new Rectangle(x2, y2, 30, 30);//surfers's rectangle	

            randThing = xValue.Next(20, 500);
            bottleRectangle = new Rectangle(randThing, -30, 30, 30);//surfers's rectangle	


            //position the sharks

            for (int i = 0; i <= 4; i++)
            {
                sharksRectangle[i] = new Rectangle(y, x + 70 * i, 35, 35);
                sharkSpeed[i] = speed.Next(5, 10);//each planet has a random speed
            }
        }

        private void FrmAssessment_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = false; }
            if (e.KeyData == Keys.Right) { right = false; }
            if (e.KeyData == Keys.Up) { up = false; }
            if (e.KeyData == Keys.Down) { down = false; }
        }

        private void FrmAssessment_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = true; }
            if (e.KeyData == Keys.Right) { right = true; }
            if (e.KeyData == Keys.Up) { up = true; }
            if (e.KeyData == Keys.Down) { down = true; }
        }

        private void TmrShark_Tick_1(object sender, EventArgs e)
        {
            for (int i = 0; i <= 4; i++)
            {
                sharksRectangle[i].X += sharkSpeed[i];
                //if spaceship collides with any planet lose a life and move planet to the top of the panel
                if (sharksRectangle[i].IntersectsWith(surferRectangle))
                {
                    sharksRectangle[i].X = 25;
                    lives -= 1; // reduce lives by 1

                    //display the number of lives on the form
                    LvsTxt.Text = lives.ToString();
                    CheckLives();
                }
                if (sharksRectangle[i].X > PnlGame.Height)
                {
                    score += 1; //add 1 to score
                    sharksRectangle[i].X = 25;

                    ScoreTxt.Text = score.ToString();

                    levelprogress.Value += 1;

                    // Set the Step property to a value of 1 to represent each file being copied.
                    levelprogress.Step += 1;

                    CheckScore();
                }

                PnlGame.Invalidate();
            }

            if (level == 1)
            {
                for (int i = 0; i <= 4; i++)
                {                    
                        sharkSpeed[i] = speed.Next(1, 13);// each shark has a random speed
                }

            }

            if (level == 2)
            {
                for (int i = 0; i <= 4; i++)
                {
                    sharkSpeed[i] = speed.Next(8, 13);// each shark has a random speed
                }

            }


            if (level == 3)
            {
                for (int i = 0; i <= 4; i++)
                {
                    sharkSpeed[i] = speed.Next(15, 20);// each shark has a random speed
                }

            }



            if (level == 4)
            {
                for (int i = 0; i <= 4; i++)
                {
                    sharkSpeed[i] = speed.Next(20, 22);// each shark has a random speed
                }

            }


            if (level == 5)
            {
                for (int i = 0; i <= 4; i++)
                {
                    sharkSpeed[i] = speed.Next(20, 22);// each shark has a random speed
                }

            }

            if (level == 6)
            {
                for (int i = 0; i <= 4; i++)
                {
                    sharkSpeed[i] = speed.Next(21, 24);// each shark has a random speed
                }

            }

            if (level == 7)
            {
                for (int i = 0; i <= 4; i++)
                {
                    sharkSpeed[i] = speed.Next(21, 24);// each shark has a random speed
                }

            }

            if (level == 8)
            {
                for (int i = 0; i <= 4; i++)
                {
                    sharkSpeed[i] = speed.Next(21, 24);// each shark has a random speed
                }

            }

            if (level == 9)
            {
                for (int i = 0; i <= 4; i++)
                {
                    sharkSpeed[i] = speed.Next(25, 30);// each shark has a random speed
                }

            }

            if (level > 9)
            {
                for (int i = 0; i <= 4; i++)
                {
                    sharkSpeed[i] = speed.Next(25, 30);// each shark has a random speed
                }
            }




        }



        private void BottleTimer_Tick_1(object sender, EventArgs e)
        {
                bottleRectangle.Y += bottleSpeed;
                //if spaceship collides with any planet lose a life and move planet to the top of the panel
                if (bottleRectangle.IntersectsWith(surferRectangle))
                {
                    Random randXValue = new Random();
                    int xValueInt = 0;
                    xValueInt = randXValue.Next(20, 500);
                    bottleRectangle.Y = -30;
                    bottleRectangle.X = xValueInt;

                BottleTimer.Enabled = false;
            }

                if (bottleRectangle.Y > PnlGame.Height)
                {
                Random randXValue = new Random();
                int xValueInt = 0;
                xValueInt = randXValue.Next(20, 500);
                bottleRectangle.Y = -30;
                bottleRectangle.X = xValueInt;

                BottleTimer.Enabled = false;
            }

        }


        private void BottleTimeWait_Tick_1(object sender, EventArgs e)
        {
            BottleTimer.Enabled = true;
        }

        private void LblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void TbUsername_TextChanged(object sender, EventArgs e)
        {
            string context = TbUsername.Text;
            bool isletter = true;
            //for loop checks for letters as characters are entered
            for (int i = 0; i < context.Length; i++)
            {
                if (!char.IsLetter(context[i]))// if current character not a letter
                {
                    isletter = false;//make isletter false
                    usermamevalid = 1;
                    break; // exit the for loop

                }

            }

            // if not a letter clear the textbox and focus on it
            // to enter name again
            if (isletter == false)
            {
                TbUsername.Clear();
                TbUsername.Focus();

                usermamevalid = 1;
            }

        }


        private void BtnEasy_Click(object sender, EventArgs e)
        {
            if (usermamevalid == 0)
            {
                DifficultyLevel = 1;

                LvlCount.Visible = true;
                LvlTxt.Visible = true;
                ScoreCount.Visible = true;
                ScoreTxt.Visible = true;
                label1.Visible = true;
                LvsCount.Visible = true;
                LvsTxt.Visible = true;
                levelprogress.Visible = true;
                LblName.Visible = true;

                LblInstructions.Visible = false;
                TbUsername.Visible = false;
                LblWelcome.Visible = false;

                LblUsername.Visible = false;

                IfButtonClick = 1;

                TmrShark.Enabled = true;
                TmrSurfer.Enabled = true;
                BottleTimer.Enabled = true;
                BottleTimeWait.Enabled = true;

                PnlGame.Width = 579;

                LblName.Text = "Welcome " + TbUsername.Text;
            }
        }

        private void BtnMedium_Click(object sender, EventArgs e)
        {
            if (usermamevalid == 0)
            {
                DifficultyLevel = 2;

                LvlCount.Visible = true;
                LvlTxt.Visible = true;
                ScoreCount.Visible = true;
                ScoreTxt.Visible = true;
                label1.Visible = true;
                LvsCount.Visible = true;
                LvsTxt.Visible = true;
                levelprogress.Visible = true;
                LblName.Visible = true;

                LblInstructions.Visible = false;
                TbUsername.Visible = false;
                LblWelcome.Visible = false;

                LblUsername.Visible = false;

                IfButtonClick = 1;

                TmrShark.Enabled = true;
                TmrSurfer.Enabled = true;
                BottleTimer.Enabled = true;
                BottleTimeWait.Enabled = true;

                PnlGame.Width = 579;

                LblName.Text = "Welcome " + TbUsername.Text;
            }
        }

        private void BtnHard_Click(object sender, EventArgs e)
        {
            if (usermamevalid == 0)
            {
                DifficultyLevel = 3;

                LvlCount.Visible = true;
                LvlTxt.Visible = true;
                ScoreCount.Visible = true;
                ScoreTxt.Visible = true;
                label1.Visible = true;
                LvsCount.Visible = true;
                LvsTxt.Visible = true;
                levelprogress.Visible = true;
                LblName.Visible = true;

                LblInstructions.Visible = false;
                TbUsername.Visible = false;
                LblWelcome.Visible = false;

                LblUsername.Visible = false;

                IfButtonClick = 1;

                TmrShark.Enabled = true;
                TmrSurfer.Enabled = true;
                BottleTimer.Enabled = true;
                BottleTimeWait.Enabled = true;

                PnlGame.Width = 579;

                LblName.Text = "Welcome " + TbUsername.Text;
            }
        }

        private void PnlGame_Paint(object sender, PaintEventArgs e)
        {
            if (IfButtonClick == 1)
            {
                //get the methods from the graphic's class to paint on the panel
                g = e.Graphics;
                //use the DrawImage method to draw the spaceship on the panel
                g.DrawImage(surfer, surferRectangle);

                g.DrawImage(bottle, bottleRectangle);

                //use the DrawImage method to draw the planet on the panel
                for (int i = 0; i <= 7; i++)
                {
                    g.DrawImage(shark, sharksRectangle[i]);
                }
            }
        }





        //the CheckLives method will stop the planets and spaceship moving if there are no lives left
        // and a game over message will be displayed  
        private void CheckLives()
        {
            if (lives == 0)
            {
                TmrShark.Enabled = false;
                TmrSurfer.Enabled = false;
                BottleTimer.Enabled = false;
                BottleTimeWait.Enabled = false;
                MessageBox.Show("Game Over!! You reached level " + level + "!");
                this.Close();
            }
        }

        //the CheckLives method will stop the planets and spaceship moving if there are no lives left
        // and a game over message will be displayed  
        private void CheckScore()
        {
            if (score % 25 == 0)
            {
                level += 1; //add 1 to level
                LvlTxt.Text = level.ToString();

                levelprogress.Value = 0;

                // Set the Step property to a value of 1 to represent each file being copied.
                levelprogress.Step = 0;

                score = 0;
                ScoreTxt.Text = score.ToString();

            }
        }




        private void TmrSurfer_Tick_1(object sender, EventArgs e)
        {
            if (left) // if left arrow pressed
            {
                if (surferRectangle.X < 10) //check to see if spaceship within 10 of left side
                {
                    surferRectangle.X = 10; //if it is < 10 away "bounce" it (set position at 10)
                }
                else
                {
                    surferRectangle.X -= 5; //else move 5 to the left
                }
            }
            if (right) // if right arrow key pressed
            {
                if (surferRectangle.X > PnlGame.Width - 40)// is spaceship within 40 of right side
                {
                    surferRectangle.X = PnlGame.Width - 40;
                }
                else
                {
                    surferRectangle.X += 5;
                }

            }

            if (up) // if right arrow key pressed
            {
                if (surferRectangle.Y < 15)// is spaceship within 40 of right side
                {
                    surferRectangle.Y = 15;
                }
                else
                {
                    surferRectangle.Y -= 5;
                }
            }

            if (down) // if right arrow key pressed
            {
                if (surferRectangle.Y > PnlGame.Height - 40)// is spaceship within 40 of right side
                {
                    surferRectangle.Y = PnlGame.Height - 40;
                }
                else
                {
                    surferRectangle.Y += 5;
                }
            }
        }

        

   

        private void FrmAssessment_Load_1(object sender, EventArgs e)
        {
            LvlCount.Visible = false;
            LvlTxt.Visible = false;
            ScoreCount.Visible = false;
            ScoreTxt.Visible = false;
            label1.Visible = false;
            LvsCount.Visible = false;
            LvsTxt.Visible = false;
            levelprogress.Visible = false;
            LblName.Visible = false;

            TmrShark.Enabled = true;
            TmrSurfer.Enabled = true;
            BottleTimer.Enabled = false;
            BottleTimeWait.Enabled = true;

            PnlGame.Width = 753;
        }


    }
}
