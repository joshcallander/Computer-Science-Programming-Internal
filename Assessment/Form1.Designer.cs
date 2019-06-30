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
            this.TmrShark = new System.Windows.Forms.Timer(this.components);
            this.PnlGame = new System.Windows.Forms.Panel();
            this.TmrSurfer = new System.Windows.Forms.Timer(this.components);
            this.LvlCount = new System.Windows.Forms.Label();
            this.LvlTxt = new System.Windows.Forms.TextBox();
            this.ScoreTxt = new System.Windows.Forms.TextBox();
            this.ScoreCount = new System.Windows.Forms.Label();
            this.LvsTxt = new System.Windows.Forms.TextBox();
            this.LvsCount = new System.Windows.Forms.Label();
            this.StartGame = new System.Windows.Forms.Button();
            this.StopGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TmrShark
            // 
            this.TmrShark.Enabled = true;
            // 
            // PnlGame
            // 
            this.PnlGame.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.PnlGame.Cursor = System.Windows.Forms.Cursors.Default;
            this.PnlGame.Location = new System.Drawing.Point(2, 46);
            this.PnlGame.Name = "PnlGame";
            this.PnlGame.Size = new System.Drawing.Size(579, 376);
            this.PnlGame.TabIndex = 0;
            this.PnlGame.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlGame_Paint);
            // 
            // TmrSurfer
            // 
            this.TmrSurfer.Enabled = true;
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
            this.ScoreTxt.Location = new System.Drawing.Point(603, 124);
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
            this.ScoreCount.Size = new System.Drawing.Size(35, 13);
            this.ScoreCount.TabIndex = 4;
            this.ScoreCount.Text = "Score";
            // 
            // LvsTxt
            // 
            this.LvsTxt.Enabled = false;
            this.LvsTxt.Location = new System.Drawing.Point(603, 188);
            this.LvsTxt.Name = "LvsTxt";
            this.LvsTxt.Size = new System.Drawing.Size(109, 20);
            this.LvsTxt.TabIndex = 5;
            this.LvsTxt.Text = "3";
            this.LvsTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LvsCount
            // 
            this.LvsCount.AutoSize = true;
            this.LvsCount.Location = new System.Drawing.Point(600, 172);
            this.LvsCount.Name = "LvsCount";
            this.LvsCount.Size = new System.Drawing.Size(32, 13);
            this.LvsCount.TabIndex = 6;
            this.LvsCount.Text = "Lives";
            // 
            // StartGame
            // 
            this.StartGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.StartGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartGame.ForeColor = System.Drawing.Color.White;
            this.StartGame.Location = new System.Drawing.Point(12, 437);
            this.StartGame.Name = "StartGame";
            this.StartGame.Size = new System.Drawing.Size(112, 23);
            this.StartGame.TabIndex = 7;
            this.StartGame.Text = "Start Game";
            this.StartGame.UseVisualStyleBackColor = false;
            // 
            // StopGame
            // 
            this.StopGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.StopGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StopGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopGame.ForeColor = System.Drawing.Color.White;
            this.StopGame.Location = new System.Drawing.Point(163, 437);
            this.StopGame.Name = "StopGame";
            this.StopGame.Size = new System.Drawing.Size(112, 23);
            this.StopGame.TabIndex = 8;
            this.StopGame.Text = "Stop Game";
            this.StopGame.UseVisualStyleBackColor = false;
            // 
            // FrmAssessment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(737, 482);
            this.Controls.Add(this.StopGame);
            this.Controls.Add(this.StartGame);
            this.Controls.Add(this.LvsCount);
            this.Controls.Add(this.LvsTxt);
            this.Controls.Add(this.ScoreCount);
            this.Controls.Add(this.ScoreTxt);
            this.Controls.Add(this.LvlTxt);
            this.Controls.Add(this.LvlCount);
            this.Controls.Add(this.PnlGame);
            this.Name = "FrmAssessment";
            this.Text = "Form1";
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
        private System.Windows.Forms.Button StartGame;
        private System.Windows.Forms.Button StopGame;
    }
}

