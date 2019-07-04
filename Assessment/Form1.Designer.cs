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
            this.SuspendLayout();
            // 
            // TmrShark
            // 
            this.TmrShark.Tick += new System.EventHandler(this.TmrShark_Tick_1);
            // 
            // PnlGame
            // 
            this.PnlGame.BackColor = System.Drawing.Color.White;
            this.PnlGame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PnlGame.BackgroundImage")));
            this.PnlGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PnlGame.Cursor = System.Windows.Forms.Cursors.Default;
            this.PnlGame.Location = new System.Drawing.Point(2, 46);
            this.PnlGame.Name = "PnlGame";
            this.PnlGame.Size = new System.Drawing.Size(579, 376);
            this.PnlGame.TabIndex = 0;
            this.PnlGame.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlGame_Paint);
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
            this.BottleTimeWait.Interval = 15000;
            this.BottleTimeWait.Tick += new System.EventHandler(this.BottleTimeWait_Tick);
            // 
            // FrmAssessment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(737, 482);
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
    }
}

