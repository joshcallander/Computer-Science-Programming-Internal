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
    
        Graphics g; // Declare the graphics for the game
        int y = 25, x = 20; // Set the starting position of sharks
        int y2 = 161, x2 = 520; // Set the starting position of surfer

        // Declare the rectangles to display the bottle, sharks and surfer in
        Rectangle surferRectangle;
        Rectangle bottleRectangle;
        Rectangle[] sharksRectangle = new Rectangle[5];

        // Load the shark, surfer and bottle images onto the panel from the bin\debug folder
        Image surfer = Image.FromFile(Application.StartupPath + @"\Surfer.png");
        Image shark = Image.FromFile(Application.StartupPath + @"\Shark.png");
        Image bottle = Image.FromFile(Application.StartupPath + @"\Bottle.png");

        // Declare the speed of the bottle, and sharks
        int[] sharkSpeed = new int[5];
        int bottleSpeed = 25; // set the speed of the bottle (power-up)

        // Declare the int varibles to to display on the game
        int score = 0;
        int level = 1;
        int lives = 0;
        int timercount = 3;
        int IfButtonClick = 0;
        int usermamevalid = 0;

        // Declare the up, down, left and right keys bool, which is later used to detect a key press
        bool left, right, up, down;

        // Declare random varibles
        Random speed = new Random();
        Random yValue = new Random();
        int RandomXValue = 0;

        public FrmAssessment()
        {
            InitializeComponent();
            
            // Add double buffering to stop the game flickering
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, PnlGame, new object[] { true });

            // Declare the rectangles
            surferRectangle = new Rectangle(x2, y2, 50, 40); // Define the surfers's rectangle	

            RandomXValue = yValue.Next(20, 100); // Generate a random Y valuse for the bottles starting position
            bottleRectangle = new Rectangle(-30, RandomXValue, 30, 30); // Define the bottle rectangle	


            // Position each shark onto the panel using a for loop
            for (int i = 0; i <= 4; i++)
            {
                // Declare the rectangle to put the shark image in for each shark
                sharksRectangle[i] = new Rectangle(y, x + 70 * i, 45, 40);

                if (level == 1)
                { 
                    sharkSpeed[i] = speed.Next(6, 15); // If the level is 1, then each shark has a random speed between 1 and 15
                }

                if (level == 2)
                {
                    sharkSpeed[i] = speed.Next(10, 20); // If the level is 2, then each shark has a random speed between 10 and 20
                }


                if (level == 3)
                {
                    sharkSpeed[i] = speed.Next(15, 20); // If the level is 3, then each shark has a random speed between 15 and 20
                }

                if (level == 4)
                {
                    sharkSpeed[i] = speed.Next(20, 22); // If the level is 4, then each shark has a random speed between 20 and 22
                }

                if (level == 5)
                {
                    sharkSpeed[i] = speed.Next(20, 22); // If the level is 5, then each shark has a random speed between 20 and 22
                }

                if (level == 6)
                {
                    sharkSpeed[i] = speed.Next(21, 24); // If the level is 6, then each shark has a random speed between 21 and 24
                }

                if (level == 7)
                {
                    sharkSpeed[i] = speed.Next(21, 24); // If the level is 7, then each shark has a random speed between 21 and 24
                }

                if (level == 8)
                {
                    sharkSpeed[i] = speed.Next(21, 24); // If the level is 8, then each shark has a random speed between 21 and 24
                }

                if (level == 9)
                {
                    sharkSpeed[i] = speed.Next(25, 30); // If the level is 9, then each shark has a random speed between 25 and 30
                }

                if (level > 9)
                {
                    sharkSpeed[i] = speed.Next(25, 30); // If the level is greater than 9, then each shark has a random speed between 25 and 30
                }
            }
        }

        private void FrmAssessment_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = false; } // If the left key is pressed, then disable the surfer left fuction
            if (e.KeyData == Keys.Right) { right = false; } // If the right key is pressed, then disable the surfer right fuction
            if (e.KeyData == Keys.Up) { up = false; } // If the up key is pressed, then disable the surfer up fuction
            if (e.KeyData == Keys.Down) { down = false; } // If the down key is pressed, then disable the surfer down fuction
        }

        private void FrmAssessment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = true; } // If the left key is pressed, then enable the surfer left fuction
            if (e.KeyData == Keys.Right) { right = true; } // If the right key is pressed, then enable the surfer right fuction
            if (e.KeyData == Keys.Up) { up = true; } // If the up key is pressed, then enable the surfer up fuction
            if (e.KeyData == Keys.Down) { down = true; } // If the down key is pressed, then enable the surfer down fuction
        }

        private void TmrShark_Tick(object sender, EventArgs e)
        {
            if (IfButtonClick == 1)
            { // Only run the code if a difficulty button has been pressed
                for (int i = 0; i <= 4; i++)
                { // Run the code for each of the 5 sharks
                    sharksRectangle[i].X += sharkSpeed[i]; // Set each shark to the correct speed

                    if (sharksRectangle[i].IntersectsWith(surferRectangle))
                    { // If the surfer collides with any shark
                        sharksRectangle[i].X = 20; // Move the shark back to the begining of the panel
                        lives -= 1; // Reduce lives count by one
                        LvsTxt.Text = lives.ToString(); // Display the number of lives remaining on the LvsTxt textbox
                        CheckLives(); // Initiate the function that checks how many lives the user has
                    }

                    if (sharksRectangle[i].X > PnlGame.Width)
                    { // If the shark reaches the end of the panel
                        score += 1; // Add one point to score count
                        sharksRectangle[i].X = 25; // Move the shark back to the begining of the panel
                        ScoreTxt.Text = score.ToString(); // Display the score count on the ScoreTxt textbox

                        // Increase the value/ step the level progressbar by one
                        levelprogress.Value += 1;
                        levelprogress.Step += 1;

                        CheckScore(); // Initiate the function that checks the score the user is on and if the level needs increasing
                    }

                    PnlGame.Invalidate();
                }
            }
        }



        private void BottleTimer_Tick(object sender, EventArgs e)
        {
            bottleRectangle.X += bottleSpeed; // Set the speed of the bottle on timer tick

            // If the bottle rectangle touches the surfer
            if (bottleRectangle.IntersectsWith(surferRectangle))
            {
                Random RandYValue = new Random(); // Generate a random y value 
                int yValueInt = 0; // Generate a intager
                yValueInt = RandYValue.Next(20, 500); // Make the y value between 20 and 500 in the panel
                bottleRectangle.X = -30; // Move the bottle back to the start of the panel, but of the screen so the user cannot see it
                bottleRectangle.Y = yValueInt; // Set the y value of the botttle to the yValueInt varible

                BottleTimer.Enabled = false; // Disable the bottle timer for another 15 seconds

                Random BottlePrize = new Random(); // Genrate a random number
                int BottlePrizeNumber = BottlePrize.Next(1, 5);  // Make the random number between 1 and 4

                if (BottlePrizeNumber == 1)
                { // If the random number generated is equal to 1
                    lives++; // Add one to lives count
                    LvsTxt.Text = lives.ToString(); // Convert it to a string then dispaly it on the LvsTxt textbox
                }

                if (BottlePrizeNumber == 2)
                {
                    lives++; // Add one to lives count
                    LvsTxt.Text = lives.ToString(); // Convert it to a string then dispaly it on the LvsTxt textbox
                }

                if (BottlePrizeNumber == 3)
                {
                    lives++; // Add one to lives count
                    LvsTxt.Text = lives.ToString(); // Convert it to a string then dispaly it on the LvsTxt textbox
                }

                if (BottlePrizeNumber == 4)
                {
                    lives--; // Remove one from the lives count
                    LvsTxt.Text = lives.ToString(); // Convert it to a string then dispaly it on the LvsTxt textbox
                }
            }

            if (bottleRectangle.X > PnlGame.Width)
            { // If the bottle reaches the end of the panel
                Random RandYValue = new Random(); // Generate a random y value 
                int yValueInt = 0; // Generate a intager
                yValueInt = RandYValue.Next(20, 500); // Make the y value between 20 and 500 in the panel
                bottleRectangle.X = -30; // Move the bottle back to the start of the panel, but of the screen so the user cannot see it
                bottleRectangle.Y = yValueInt; // Set the y value of the botttle to the yValueInt varible

                BottleTimer.Enabled = false; // Disable the bottle timer for another 15 seconds
            }
        }

        private void BottleTimeWait_Tick(object sender, EventArgs e)
        {
            BottleTimer.Enabled = true; // Once 15 seconds has passed, re-enable the bottle timer to move the bottle
        }

        private void TbUsername_TextChanged(object sender, EventArgs e)
        { // On change up of the textbox
            string context = TbUsername.Text; // Create a string with the value of the TbUsername value
            bool isletter = true; // Create a bool that sets isletter to ture

            if (context == "")
            { // If the username textbox is empty
                usermamevalid = 1; // Set the usernamevalid to 1, which disables the user from selecting a difficulty
            }

            else
            { // The username is not empty
                usermamevalid = 0; // Set the usernamevalid to 0, which enables the user to select a difficulty
            }
            
            for (int i = 0; i < context.Length; i++)
            {
                if (!char.IsLetter(context[i]))
                { // If the current character is not a letter
                    isletter = false; // Make isletter false
                    usermamevalid = 1; // Set the usernamevalid to 1, which disables the user from selecting a difficulty
                }

                else
                {
                    usermamevalid = 0; // Set the usernamevalid to 0, which enables the user to select a difficulty
                }
            }

            // if not a letter clear the textbox and focus on it
            // to enter name again
            if (isletter == false)
            { // If isletter is equal to false 
                TbUsername.Clear(); // Remove all characters in the username textbox 
                TbUsername.Focus(); // Focuse the user onto the username textbox to set the user to editing the username

                usermamevalid = 1; // Set the usernamevalid to 1, which disables the user from selecting a difficulty
            }

            else
            {
                usermamevalid = 0; // Set the usernamevalid to 0, which enables the user to select a difficulty
            }
        }

        private void BtnEasy_Click(object sender, EventArgs e)
        { // If the user clicks on the easy difficulty button
            if (usermamevalid == 0)
            { // If the user name is valid
                // Show the countdown to the game starts
                LblToStart.Visible = true;
                LblGameStart.Visible = true;

                // Display the sidebar elements such as lives textbox, lives label, etc
                LvlCount.Visible = true;
                LvlTxt.Visible = true;
                ScoreCount.Visible = true;
                ScoreTxt.Visible = true;
                label1.Visible = true;
                LvsCount.Visible = true;
                LvsTxt.Visible = true;
                levelprogress.Visible = true;
                LblName.Visible = true;

                // Hide the welcome to game message, username, instructions
                LblInstructions.Visible = false;
                TbUsername.Visible = false;
                LblWelcome.Visible = false;
                LblUsername.Visible = false;

                // Hide the difficulty buttons
                BtnHard.Visible = false;
                BtnMedium.Visible = false;
                BtnEasy.Visible = false;

                // Disable the difficulty buttons to allow the surfer to move
                BtnHard.Enabled = false;
                BtnMedium.Enabled = false;
                BtnEasy.Enabled = false;

                IfButtonClick = 1; // Set the button as clicked

                // Disable the timers
                TmrShark.Enabled = false;
                TmrSurfer.Enabled = false;
                BottleTimer.Enabled = false;
                BottleTimeWait.Enabled = false;

                lives = 5; // Set the lives count to 5
                LvsTxt.Text = lives.ToString(); // Display the lives count in the LvsText textbox

                TmrCountdown.Start(); // Start the countdown timer

                LblName.Text = "Welcome " + TbUsername.Text; // Edit the text to say Welcome then their name
            }
        }

        private void BtnMedium_Click(object sender, EventArgs e)
        { // If the user clicks on the medium difficulty button
            if (usermamevalid == 0)
            { // If the user name is valid
                // Show the countdown to the game starts
                LblToStart.Visible = true;
                LblGameStart.Visible = true;

                // Display the sidebar elements such as lives textbox, lives label, etc
                LvlCount.Visible = true;
                LvlTxt.Visible = true;
                ScoreCount.Visible = true;
                ScoreTxt.Visible = true;
                label1.Visible = true;
                LvsCount.Visible = true;
                LvsTxt.Visible = true;
                levelprogress.Visible = true;
                LblName.Visible = true;

                // Hide the welcome to game message, username, instructions
                LblInstructions.Visible = false;
                TbUsername.Visible = false;
                LblWelcome.Visible = false;
                LblUsername.Visible = false;

                // Hide the difficulty buttons
                BtnHard.Visible = false;
                BtnMedium.Visible = false;
                BtnEasy.Visible = false;

                // Disable the difficulty buttons to allow the surfer to move
                BtnHard.Enabled = false;
                BtnMedium.Enabled = false;
                BtnEasy.Enabled = false;

                IfButtonClick = 1; // Set the button as clicked

                // Disable the timers
                TmrShark.Enabled = false;
                TmrSurfer.Enabled = false;
                BottleTimer.Enabled = false;
                BottleTimeWait.Enabled = false;

                lives = 3; // Set the lives count to 3
                LvsTxt.Text = lives.ToString(); // Display the lives count in the LvsText textbox

                TmrCountdown.Start(); // Start the countdown timer

                LblName.Text = "Welcome " + TbUsername.Text; // Edit the text to say Welcome then their name
            }
        }

        private void BtnHard_Click(object sender, EventArgs e)
        { // If the user clicks on the hard difficulty button
            if (usermamevalid == 0)
            { // If the user name is valid
                // Show the countdown to the game starts
                LblToStart.Visible = true;
                LblGameStart.Visible = true;

                // Display the sidebar elements such as lives textbox, lives label, etc
                LvlCount.Visible = true;
                LvlTxt.Visible = true;
                ScoreCount.Visible = true;
                ScoreTxt.Visible = true;
                label1.Visible = true;
                LvsCount.Visible = true;
                LvsTxt.Visible = true;
                levelprogress.Visible = true;
                LblName.Visible = true;

                // Hide the welcome to game message, username, instructions
                LblInstructions.Visible = false;
                TbUsername.Visible = false;
                LblWelcome.Visible = false;
                LblUsername.Visible = false;

                // Hide the difficulty buttons
                BtnHard.Visible = false;
                BtnMedium.Visible = false;
                BtnEasy.Visible = false;

                // Disable the difficulty buttons to allow the surfer to move
                BtnHard.Enabled = false;
                BtnMedium.Enabled = false;
                BtnEasy.Enabled = false;

                IfButtonClick = 1; // Set the button as clicked

                // Disable the timers
                TmrShark.Enabled = false;
                TmrSurfer.Enabled = false;
                BottleTimer.Enabled = false;
                BottleTimeWait.Enabled = false;

                lives = 1; // Set the lives count to 1
                LvsTxt.Text = lives.ToString(); // Display the lives count in the LvsText textbox

                TmrCountdown.Start(); // Start the countdown timer

                LblName.Text = "Welcome " + TbUsername.Text; // Edit the text to say Welcome then their name
            }
        }

        private void TmrCountdown_Tick(object sender, EventArgs e)
        { // On tick of the TmrCountdown
            timercount--; // Decrease one from the timer
            LblToStart.Text = timercount.ToString(); // Display the timer value on the panel

            if (timercount == 3)
            { // If the timer value is equal to 3
                LblGameStart.Visible = true; // Display the time till game start text
            }

            if (timercount == 0)
            { // If the timer value is equal to 0
                LblToStart.Visible = false; // Hide the second countdown
                LblGameStart.Visible = false; // Hide the time till game start text
                
                // Enable the games timers
                TmrShark.Enabled = true; 
                TmrSurfer.Enabled = true;
                BottleTimer.Enabled = true;
                BottleTimeWait.Enabled = true;

                TmrCountdown.Stop(); // Stop the TmrCountdown
            }
        }

        private void PnlGame_Paint(object sender, PaintEventArgs e)
        { 
            if (IfButtonClick == 1)
            { // Only if a difficulty button has been pressed

                // Get the methods from the graphic's class to paint on the panel
                g = e.Graphics;

                // Use the DrawImage method to draw the surfer and bottle onto the panel
                g.DrawImage(surfer, surferRectangle);
                g.DrawImage(bottle, bottleRectangle);

                // Use the DrawImage method to draw each of the sharks onto the panel
                for (int i = 0; i <= 4; i++)
                {
                    g.DrawImage(shark, sharksRectangle[i]);
                }
            }
        }

        private void CheckLives()
        { // Initiate the CheckLives method/ function
            if (lives == 0)
            { // If the user has no lives left
                // Disable the timers
                TmrShark.Enabled = false;
                TmrSurfer.Enabled = false;
                BottleTimer.Enabled = false;
                BottleTimeWait.Enabled = false;

                MessageBox.Show("Game Over!! You reached level " + level + ", score " + score + "!"); // Display the game over message, telling the user their level and score count
                this.Close(); // Close the form
            }
        }

        private void CheckScore()
        { // Initiate the CheckScore method/ function
            if (score % 25 == 0)
            { // If the score is divisible by 25
                level += 1; // Add one to level count
                LvlTxt.Text = level.ToString(); // Convert the level to a string, then display it on the LvlTxt textbox

                levelprogress.Value = 0; // Set the levelprogress bar to a value of 0
                levelprogress.Step = 0; // Set the levelprogress bar to a step of 0

                score = 0; // Set the score count to 0
                ScoreTxt.Text = score.ToString(); // Convert the score to a string, then display it on the ScoreTxt textbox

            }
        }

        private void TmrSurfer_Tick(object sender, EventArgs e)
        { // On tick of the TmrSurfer
            if (left)
            { // If the left arrow key is set to true
                if (surferRectangle.X < 10)
                { // If the surfer is within 10 of the left side
                    surferRectangle.X = 10; // Set the surfer to 'bounce' of the side of the panel (at position 10 on the X axis)
                }
                else
                {
                    surferRectangle.X -= 9; // Else move the surfer 9 towards to the left in the panel
                }
            }
            if (right)
            { // If the right arrow key is set to true
                if (surferRectangle.X > PnlGame.Width - 40)
                { // If the surfer is within 10 of the right side
                    surferRectangle.X = PnlGame.Width - 40; // Set the surfer to 'bounce' of the side of the panel (at position of 40 less than the PnlGame width)
                }

                else
                {
                    surferRectangle.X += 9; // Else move the surfer 9 towards to the right in the panel
                }
            }

            if (up)
            { // If the up arrow key is set to true
                if (surferRectangle.Y < 15)
                { // If the surfer is within 15 of the top
                    surferRectangle.Y = 15; // Set the surfer to 'bounce' of the side of the panel (at position of 15 from the top of the panel)
                }
                else
                {
                    surferRectangle.Y -= 9; // Else move the surfer 9 towards to the top in the panel
                }
            }

            if (down)
            { // If the down arrow key is set to true
                if (surferRectangle.Y > PnlGame.Height - 40)
                { // If the surfer is within 10 of the bottom of the panel
                    surferRectangle.Y = PnlGame.Height - 40; // Set the surfer to 'bounce' of the bottom of the panel (at position of 40 of the height of the panel)
                }
                else
                {
                    surferRectangle.Y += 9; // Else move the surfer 9 towards to the bottom in the panel
                }
            }
        }

        private void FrmAssessment_Load(object sender, EventArgs e)
        { // On load of the form
            // Hide the sidebar elements like lives, level and score counts and labels
            LvlCount.Visible = false;
            LvlTxt.Visible = false;
            ScoreCount.Visible = false;
            ScoreTxt.Visible = false;
            label1.Visible = false;
            LvsCount.Visible = false;
            LvsTxt.Visible = false;
            levelprogress.Visible = false;
            LblName.Visible = false;

            // Enable all timers
            TmrShark.Enabled = true;
            TmrSurfer.Enabled = true;
            BottleTimer.Enabled = false;
            BottleTimeWait.Enabled = true;

            // Hide the countdown elements
            LblToStart.Visible = false;
            LblGameStart.Visible = false;

        }
    }
}