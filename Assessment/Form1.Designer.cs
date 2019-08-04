namespace Assessment
{
    partial class FrmAssessment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAssessment));
            this.TmrShark = new System.Windows.Forms.Timer(this.components);
            this.PnlGame = new System.Windows.Forms.Panel();
            this.LblUsername = new System.Windows.Forms.Label();
            this.TbUsername = new System.Windows.Forms.TextBox();
            this.LblInstructions = new System.Windows.Forms.Label();
            this.LblWelcome = new System.Windows.Forms.Label();
            this.TmrSurfer = new System.Windows.Forms.Timer(this.components);
            this.LvlCount = new System.Windows.Forms.Label();
            this.LvlTxt = new System.Windows.Forms.TextBox();
            this.ScoreTxt = new System.Windows.Forms.TextBox();
            this.ScoreCount = new System.Windows.Forms.Label();
            this.LvsTxt = new System.Windows.Forms.TextBox();
            this.LvsCount = new System.Windows.Forms.Label();
            this.levelprogress = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.BottleTimer = new System.Windows.Forms.Timer(this.components);
            this.BottleTimeWait = new System.Windows.Forms.Timer(this.components);
            this.LblName = new System.Windows.Forms.Label();
            this.BtnEasy = new System.Windows.Forms.Button();
            this.BtnMedium = new System.Windows.Forms.Button();
            this.BtnHard = new System.Windows.Forms.Button();
            this.TmrCountdown = new System.Windows.Forms.Timer(this.components);
            this.LblGameStart = new System.Windows.Forms.Label();
            this.LblToStart = new System.Windows.Forms.Label();
            this.PnlGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // TmrShark
            // 
            this.TmrShark.Tick += new System.EventHandler(this.TmrShark_Tick_1);
            // 
            // PnlGame
            // 
            this.PnlGame.BackColor = System.Drawing.Color.White;
            this.PnlGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PnlGame.Controls.Add(this.LblToStart);
            this.PnlGame.Controls.Add(this.LblGameStart);
            this.PnlGame.Controls.Add(this.LblUsername);
            this.PnlGame.Controls.Add(this.TbUsername);
            this.PnlGame.Controls.Add(this.LblInstructions);
            this.PnlGame.Controls.Add(this.LblWelcome);
            this.PnlGame.Cursor = System.Windows.Forms.Cursors.Default;
            this.PnlGame.Location = new System.Drawing.Point(2, 46);
            this.PnlGame.Name = "PnlGame";
            this.PnlGame.Size = new System.Drawing.Size(579, 362);
            this.PnlGame.TabIndex = 0;
            this.PnlGame.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlGame_Paint);
            // 
            // LblUsername
            // 
            this.LblUsername.AutoSize = true;
            this.LblUsername.BackColor = System.Drawing.Color.Transparent;
            this.LblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsername.Location = new System.Drawing.Point(178, 93);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(130, 20);
            this.LblUsername.TabIndex = 15;
            this.LblUsername.Text = "Enter Username:";
            // 
            // TbUsername
            // 
            this.TbUsername.AccessibleDescription = "Enter username";
            this.TbUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbUsername.Location = new System.Drawing.Point(182, 116);
            this.TbUsername.MaxLength = 20;
            this.TbUsername.Name = "TbUsername";
            this.TbUsername.Size = new System.Drawing.Size(195, 21);
            this.TbUsername.TabIndex = 13;
            this.TbUsername.TextChanged += new System.EventHandler(this.TbUsername_TextChanged);
            // 
            // LblInstructions
            // 
            this.LblInstructions.AutoSize = true;
            this.LblInstructions.BackColor = System.Drawing.Color.White;
            this.LblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInstructions.Location = new System.Drawing.Point(78, 161);
            this.LblInstructions.Name = "LblInstructions";
            this.LblInstructions.Size = new System.Drawing.Size(407, 180);
            this.LblInstructions.TabIndex = 12;
            this.LblInstructions.Text = resources.GetString("LblInstructions.Text");
            this.LblInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblWelcome
            // 
            this.LblWelcome.AutoSize = true;
            this.LblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.LblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWelcome.Location = new System.Drawing.Point(102, 44);
            this.LblWelcome.Name = "LblWelcome";
            this.LblWelcome.Size = new System.Drawing.Size(360, 31);
            this.LblWelcome.TabIndex = 9;
            this.LblWelcome.Text = "Welcome To Josh\'s Game!";
            this.LblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblWelcome.Click += new System.EventHandler(this.LblWelcome_Click);
            // 
            // TmrSurfer
            // 
            this.TmrSurfer.Tick += new System.EventHandler(this.TmrSurfer_Tick_1);
            // 
            // LvlCount
            // 
            this.LvlCount.AutoSize = true;
            this.LvlCount.Location = new System.Drawing.Point(600, 46);
            this.LvlCount.Name = "LvlCount";
            this.LvlCount.Size = new System.Drawing.Size(33, 13);
            this.LvlCount.TabIndex = 1;
            this.LvlCount.Text = "Level";
            // 
            // LvlTxt
            // 
            this.LvlTxt.Enabled = false;
            this.LvlTxt.Location = new System.Drawing.Point(603, 63);
            this.LvlTxt.Name = "LvlTxt";
            this.LvlTxt.Size = new System.Drawing.Size(109, 20);
            this.LvlTxt.TabIndex = 2;
            this.LvlTxt.Text = "1";
            this.LvlTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ScoreTxt
            // 
            this.ScoreTxt.Enabled = false;
            this.ScoreTxt.Location = new System.Drawing.Point(603, 183);
            this.ScoreTxt.Name = "ScoreTxt";
            this.ScoreTxt.Size = new System.Drawing.Size(109, 20);
            this.ScoreTxt.TabIndex = 3;
            this.ScoreTxt.Text = "0";
            this.ScoreTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ScoreCount
            // 
            this.ScoreCount.AutoSize = true;
            this.ScoreCount.Location = new System.Drawing.Point(600, 108);
            this.ScoreCount.Name = "ScoreCount";
            this.ScoreCount.Size = new System.Drawing.Size(77, 13);
            this.ScoreCount.TabIndex = 4;
            this.ScoreCount.Text = "Level Progress";
            // 
            // LvsTxt
            // 
            this.LvsTxt.Enabled = false;
            this.LvsTxt.Location = new System.Drawing.Point(603, 239);
            this.LvsTxt.Name = "LvsTxt";
            this.LvsTxt.Size = new System.Drawing.Size(109, 20);
            this.LvsTxt.TabIndex = 5;
            this.LvsTxt.Text = "3";
            this.LvsTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LvsCount
            // 
            this.LvsCount.AutoSize = true;
            this.LvsCount.Location = new System.Drawing.Point(600, 223);
            this.LvsCount.Name = "LvsCount";
            this.LvsCount.Size = new System.Drawing.Size(32, 13);
            this.LvsCount.TabIndex = 6;
            this.LvsCount.Text = "Lives";
            // 
            // levelprogress
            // 
            this.levelprogress.BackColor = System.Drawing.Color.Black;
            this.levelprogress.Cursor = System.Windows.Forms.Cursors.Default;
            this.levelprogress.ForeColor = System.Drawing.Color.Black;
            this.levelprogress.Location = new System.Drawing.Point(603, 124);
            this.levelprogress.Maximum = 25;
            this.levelprogress.Name = "levelprogress";
            this.levelprogress.Size = new System.Drawing.Size(109, 23);
            this.levelprogress.Step = 25;
            this.levelprogress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.levelprogress.TabIndex = 7;
            this.levelprogress.Click += new System.EventHandler(this.levelprogress_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(600, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Score";
            // 
            // BottleTimer
            // 
            this.BottleTimer.Tick += new System.EventHandler(this.BottleTimer_Tick_1);
            // 
            // BottleTimeWait
            // 
            this.BottleTimeWait.Interval = 10000;
            this.BottleTimeWait.Tick += new System.EventHandler(this.BottleTimeWait_Tick_1);
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(12, 9);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(162, 24);
            this.LblName.TabIndex = 10;
            this.LblName.Text = "Username Display";
            // 
            // BtnEasy
            // 
            this.BtnEasy.BackColor = System.Drawing.Color.Transparent;
            this.BtnEasy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnEasy.BackgroundImage")));
            this.BtnEasy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEasy.Location = new System.Drawing.Point(619, 46);
            this.BtnEasy.Name = "BtnEasy";
            this.BtnEasy.Size = new System.Drawing.Size(75, 67);
            this.BtnEasy.TabIndex = 11;
            this.BtnEasy.UseVisualStyleBackColor = false;
            this.BtnEasy.Click += new System.EventHandler(this.BtnEasy_Click);
            // 
            // BtnMedium
            // 
            this.BtnMedium.BackColor = System.Drawing.Color.Transparent;
            this.BtnMedium.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnMedium.BackgroundImage")));
            this.BtnMedium.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMedium.Location = new System.Drawing.Point(619, 136);
            this.BtnMedium.Name = "BtnMedium";
            this.BtnMedium.Size = new System.Drawing.Size(75, 67);
            this.BtnMedium.TabIndex = 12;
            this.BtnMedium.UseVisualStyleBackColor = false;
            this.BtnMedium.Click += new System.EventHandler(this.BtnMedium_Click);
            // 
            // BtnHard
            // 
            this.BtnHard.BackColor = System.Drawing.Color.Transparent;
            this.BtnHard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnHard.BackgroundImage")));
            this.BtnHard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnHard.Location = new System.Drawing.Point(619, 223);
            this.BtnHard.Name = "BtnHard";
            this.BtnHard.Size = new System.Drawing.Size(75, 67);
            this.BtnHard.TabIndex = 13;
            this.BtnHard.UseVisualStyleBackColor = false;
            this.BtnHard.Click += new System.EventHandler(this.BtnHard_Click);
            // 
            // TmrCountdown
            // 
            this.TmrCountdown.Interval = 1000;
            this.TmrCountdown.Tick += new System.EventHandler(this.TmrCountdown_Tick);
            // 
            // LblGameStart
            // 
            this.LblGameStart.AutoSize = true;
            this.LblGameStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGameStart.Location = new System.Drawing.Point(207, 112);
            this.LblGameStart.Name = "LblGameStart";
            this.LblGameStart.Size = new System.Drawing.Size(182, 20);
            this.LblGameStart.TabIndex = 16;
            this.LblGameStart.Text = "Seconds till game starts:";
            this.LblGameStart.Visible = false;
            // 
            // LblToStart
            // 
            this.LblToStart.AutoSize = true;
            this.LblToStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblToStart.Location = new System.Drawing.Point(272, 144);
            this.LblToStart.Name = "LblToStart";
            this.LblToStart.Size = new System.Drawing.Size(31, 33);
            this.LblToStart.TabIndex = 17;
            this.LblToStart.Text = "3";
            // 
            // FrmAssessment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(737, 482);
            this.Controls.Add(this.BtnHard);
            this.Controls.Add(this.BtnMedium);
            this.Controls.Add(this.BtnEasy);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.levelprogress);
            this.Controls.Add(this.LvsCount);
            this.Controls.Add(this.LvsTxt);
            this.Controls.Add(this.ScoreCount);
            this.Controls.Add(this.ScoreTxt);
            this.Controls.Add(this.LvlTxt);
            this.Controls.Add(this.LvlCount);
            this.Controls.Add(this.PnlGame);
            this.Name = "FrmAssessment";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmAssessment_Load_1);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmAssessment_KeyDown_1);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmAssessment_KeyUp_1);
            this.PnlGame.ResumeLayout(false);
            this.PnlGame.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlGame;
        private System.Windows.Forms.Timer TmrSurfer;
        private System.Windows.Forms.Timer TmrShark;
        private System.Windows.Forms.Label LvlCount;
        private System.Windows.Forms.TextBox LvlTxt;
        private System.Windows.Forms.TextBox ScoreTxt;
        private System.Windows.Forms.Label ScoreCount;
        private System.Windows.Forms.TextBox LvsTxt;
        private System.Windows.Forms.Label LvsCount;
        private System.Windows.Forms.ProgressBar levelprogress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer BottleTimer;
        private System.Windows.Forms.Timer BottleTimeWait;
        private System.Windows.Forms.Label LblWelcome;
        private System.Windows.Forms.Label LblInstructions;
        private System.Windows.Forms.TextBox TbUsername;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.Button BtnEasy;
        private System.Windows.Forms.Button BtnMedium;
        private System.Windows.Forms.Button BtnHard;
        private System.Windows.Forms.Timer TmrCountdown;
        private System.Windows.Forms.Label LblToStart;
        private System.Windows.Forms.Label LblGameStart;
    }
}

