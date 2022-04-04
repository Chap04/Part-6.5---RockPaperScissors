namespace Part_6._5___RockPaperScissors
{
    partial class frmRockPaperScissors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRockPaperScissors));
            this.lblEnemyWins = new System.Windows.Forms.Label();
            this.lblPLayerWinCounter = new System.Windows.Forms.Label();
            this.lblPlayerWins = new System.Windows.Forms.Label();
            this.lblEnemyWinsCounter = new System.Windows.Forms.Label();
            this.imgPlayer = new System.Windows.Forms.PictureBox();
            this.imgOpponent = new System.Windows.Forms.PictureBox();
            this.grpPlayerChoice = new System.Windows.Forms.GroupBox();
            this.radScissors = new System.Windows.Forms.RadioButton();
            this.radPaper = new System.Windows.Forms.RadioButton();
            this.radRock = new System.Windows.Forms.RadioButton();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblGamesPlayed = new System.Windows.Forms.Label();
            this.lblGamesPlayedCounter = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOpponent)).BeginInit();
            this.grpPlayerChoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEnemyWins
            // 
            this.lblEnemyWins.Location = new System.Drawing.Point(12, 362);
            this.lblEnemyWins.Name = "lblEnemyWins";
            this.lblEnemyWins.Size = new System.Drawing.Size(302, 35);
            this.lblEnemyWins.TabIndex = 2;
            this.lblEnemyWins.Text = "Enemy Wins";
            this.lblEnemyWins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPLayerWinCounter
            // 
            this.lblPLayerWinCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPLayerWinCounter.Location = new System.Drawing.Point(379, 397);
            this.lblPLayerWinCounter.Name = "lblPLayerWinCounter";
            this.lblPLayerWinCounter.Size = new System.Drawing.Size(302, 81);
            this.lblPLayerWinCounter.TabIndex = 3;
            this.lblPLayerWinCounter.Text = "0";
            this.lblPLayerWinCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayerWins
            // 
            this.lblPlayerWins.Location = new System.Drawing.Point(379, 362);
            this.lblPlayerWins.Name = "lblPlayerWins";
            this.lblPlayerWins.Size = new System.Drawing.Size(302, 35);
            this.lblPlayerWins.TabIndex = 4;
            this.lblPlayerWins.Text = "Player Wins";
            this.lblPlayerWins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEnemyWinsCounter
            // 
            this.lblEnemyWinsCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemyWinsCounter.Location = new System.Drawing.Point(12, 397);
            this.lblEnemyWinsCounter.Name = "lblEnemyWinsCounter";
            this.lblEnemyWinsCounter.Size = new System.Drawing.Size(302, 81);
            this.lblEnemyWinsCounter.TabIndex = 5;
            this.lblEnemyWinsCounter.Text = "0";
            this.lblEnemyWinsCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgPlayer
            // 
            this.imgPlayer.Image = global::Part_6._5___RockPaperScissors.Properties.Resources.Between_Rounds;
            this.imgPlayer.Location = new System.Drawing.Point(379, 49);
            this.imgPlayer.Name = "imgPlayer";
            this.imgPlayer.Size = new System.Drawing.Size(318, 310);
            this.imgPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPlayer.TabIndex = 1;
            this.imgPlayer.TabStop = false;
            // 
            // imgOpponent
            // 
            this.imgOpponent.ErrorImage = ((System.Drawing.Image)(resources.GetObject("imgOpponent.ErrorImage")));
            this.imgOpponent.Image = global::Part_6._5___RockPaperScissors.Properties.Resources.Between_Rounds;
            this.imgOpponent.InitialImage = ((System.Drawing.Image)(resources.GetObject("imgOpponent.InitialImage")));
            this.imgOpponent.Location = new System.Drawing.Point(12, 49);
            this.imgOpponent.Name = "imgOpponent";
            this.imgOpponent.Size = new System.Drawing.Size(302, 310);
            this.imgOpponent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgOpponent.TabIndex = 0;
            this.imgOpponent.TabStop = false;
            // 
            // grpPlayerChoice
            // 
            this.grpPlayerChoice.BackColor = System.Drawing.Color.DarkCyan;
            this.grpPlayerChoice.Controls.Add(this.radScissors);
            this.grpPlayerChoice.Controls.Add(this.radPaper);
            this.grpPlayerChoice.Controls.Add(this.radRock);
            this.grpPlayerChoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpPlayerChoice.ForeColor = System.Drawing.Color.Black;
            this.grpPlayerChoice.Location = new System.Drawing.Point(703, 92);
            this.grpPlayerChoice.Name = "grpPlayerChoice";
            this.grpPlayerChoice.Size = new System.Drawing.Size(99, 100);
            this.grpPlayerChoice.TabIndex = 6;
            this.grpPlayerChoice.TabStop = false;
            this.grpPlayerChoice.Text = "Player Choice";
            // 
            // radScissors
            // 
            this.radScissors.AutoSize = true;
            this.radScissors.Location = new System.Drawing.Point(8, 77);
            this.radScissors.Name = "radScissors";
            this.radScissors.Size = new System.Drawing.Size(64, 17);
            this.radScissors.TabIndex = 2;
            this.radScissors.TabStop = true;
            this.radScissors.Text = "Scissors";
            this.radScissors.UseVisualStyleBackColor = true;
            // 
            // radPaper
            // 
            this.radPaper.AutoSize = true;
            this.radPaper.Location = new System.Drawing.Point(8, 54);
            this.radPaper.Name = "radPaper";
            this.radPaper.Size = new System.Drawing.Size(53, 17);
            this.radPaper.TabIndex = 1;
            this.radPaper.TabStop = true;
            this.radPaper.Text = "Paper";
            this.radPaper.UseVisualStyleBackColor = true;
            // 
            // radRock
            // 
            this.radRock.AutoSize = true;
            this.radRock.Location = new System.Drawing.Point(8, 31);
            this.radRock.Name = "radRock";
            this.radRock.Size = new System.Drawing.Size(51, 17);
            this.radRock.TabIndex = 0;
            this.radRock.TabStop = true;
            this.radRock.Text = "Rock";
            this.radRock.UseVisualStyleBackColor = true;
            // 
            // btnPlay
            // 
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Location = new System.Drawing.Point(703, 211);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(99, 23);
            this.btnPlay.TabIndex = 7;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(12, 9);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(685, 37);
            this.lblOutput.TabIndex = 8;
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGamesPlayed
            // 
            this.lblGamesPlayed.AutoSize = true;
            this.lblGamesPlayed.Location = new System.Drawing.Point(310, 373);
            this.lblGamesPlayed.Name = "lblGamesPlayed";
            this.lblGamesPlayed.Size = new System.Drawing.Size(75, 13);
            this.lblGamesPlayed.TabIndex = 9;
            this.lblGamesPlayed.Text = "Games Played";
            // 
            // lblGamesPlayedCounter
            // 
            this.lblGamesPlayedCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGamesPlayedCounter.Location = new System.Drawing.Point(267, 401);
            this.lblGamesPlayedCounter.Name = "lblGamesPlayedCounter";
            this.lblGamesPlayedCounter.Size = new System.Drawing.Size(166, 64);
            this.lblGamesPlayedCounter.TabIndex = 10;
            this.lblGamesPlayedCounter.Text = "0";
            this.lblGamesPlayedCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.DarkCyan;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Location = new System.Drawing.Point(739, 464);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmRockPaperScissors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(814, 487);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblGamesPlayedCounter);
            this.Controls.Add(this.lblGamesPlayed);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.grpPlayerChoice);
            this.Controls.Add(this.lblEnemyWinsCounter);
            this.Controls.Add(this.lblPlayerWins);
            this.Controls.Add(this.lblPLayerWinCounter);
            this.Controls.Add(this.lblEnemyWins);
            this.Controls.Add(this.imgPlayer);
            this.Controls.Add(this.imgOpponent);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmRockPaperScissors";
            this.Text = "Rock Paper Scissors";
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOpponent)).EndInit();
            this.grpPlayerChoice.ResumeLayout(false);
            this.grpPlayerChoice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgOpponent;
        private System.Windows.Forms.PictureBox imgPlayer;
        private System.Windows.Forms.Label lblEnemyWins;
        private System.Windows.Forms.Label lblPLayerWinCounter;
        private System.Windows.Forms.Label lblPlayerWins;
        private System.Windows.Forms.Label lblEnemyWinsCounter;
        private System.Windows.Forms.GroupBox grpPlayerChoice;
        private System.Windows.Forms.RadioButton radScissors;
        private System.Windows.Forms.RadioButton radPaper;
        private System.Windows.Forms.RadioButton radRock;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblGamesPlayed;
        private System.Windows.Forms.Label lblGamesPlayedCounter;
        private System.Windows.Forms.Button btnReset;
    }
}

