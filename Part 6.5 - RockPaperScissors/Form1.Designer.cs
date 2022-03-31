namespace Part_6._5___RockPaperScissors
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblEnemyWins = new System.Windows.Forms.Label();
            this.lblPLayerWinCounter = new System.Windows.Forms.Label();
            this.lblPlayerWins = new System.Windows.Forms.Label();
            this.lblEnemyWinsCounter = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imgOpponent = new System.Windows.Forms.PictureBox();
            this.grpPlayerChoice = new System.Windows.Forms.GroupBox();
            this.radRock = new System.Windows.Forms.RadioButton();
            this.radPaper = new System.Windows.Forms.RadioButton();
            this.radScissors = new System.Windows.Forms.RadioButton();
            this.btnPlay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOpponent)).BeginInit();
            this.grpPlayerChoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEnemyWins
            // 
            this.lblEnemyWins.Location = new System.Drawing.Point(12, 325);
            this.lblEnemyWins.Name = "lblEnemyWins";
            this.lblEnemyWins.Size = new System.Drawing.Size(302, 35);
            this.lblEnemyWins.TabIndex = 2;
            this.lblEnemyWins.Text = "Enemy Wins";
            this.lblEnemyWins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPLayerWinCounter
            // 
            this.lblPLayerWinCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPLayerWinCounter.Location = new System.Drawing.Point(379, 366);
            this.lblPLayerWinCounter.Name = "lblPLayerWinCounter";
            this.lblPLayerWinCounter.Size = new System.Drawing.Size(302, 81);
            this.lblPLayerWinCounter.TabIndex = 3;
            this.lblPLayerWinCounter.Text = "0";
            this.lblPLayerWinCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayerWins
            // 
            this.lblPlayerWins.Location = new System.Drawing.Point(379, 325);
            this.lblPlayerWins.Name = "lblPlayerWins";
            this.lblPlayerWins.Size = new System.Drawing.Size(302, 41);
            this.lblPlayerWins.TabIndex = 4;
            this.lblPlayerWins.Text = "Player Wins";
            this.lblPlayerWins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEnemyWinsCounter
            // 
            this.lblEnemyWinsCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemyWinsCounter.Location = new System.Drawing.Point(12, 360);
            this.lblEnemyWinsCounter.Name = "lblEnemyWinsCounter";
            this.lblEnemyWinsCounter.Size = new System.Drawing.Size(302, 81);
            this.lblEnemyWinsCounter.TabIndex = 5;
            this.lblEnemyWinsCounter.Text = "0";
            this.lblEnemyWinsCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(379, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(318, 310);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // imgOpponent
            // 
            this.imgOpponent.ErrorImage = ((System.Drawing.Image)(resources.GetObject("imgOpponent.ErrorImage")));
            this.imgOpponent.Image = ((System.Drawing.Image)(resources.GetObject("imgOpponent.Image")));
            this.imgOpponent.InitialImage = ((System.Drawing.Image)(resources.GetObject("imgOpponent.InitialImage")));
            this.imgOpponent.Location = new System.Drawing.Point(12, 12);
            this.imgOpponent.Name = "imgOpponent";
            this.imgOpponent.Size = new System.Drawing.Size(302, 310);
            this.imgOpponent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgOpponent.TabIndex = 0;
            this.imgOpponent.TabStop = false;
            // 
            // grpPlayerChoice
            // 
            this.grpPlayerChoice.Controls.Add(this.radScissors);
            this.grpPlayerChoice.Controls.Add(this.radPaper);
            this.grpPlayerChoice.Controls.Add(this.radRock);
            this.grpPlayerChoice.Location = new System.Drawing.Point(703, 92);
            this.grpPlayerChoice.Name = "grpPlayerChoice";
            this.grpPlayerChoice.Size = new System.Drawing.Size(99, 100);
            this.grpPlayerChoice.TabIndex = 6;
            this.grpPlayerChoice.TabStop = false;
            this.grpPlayerChoice.Text = "Player Choice";
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
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(703, 211);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(99, 23);
            this.btnPlay.TabIndex = 7;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 450);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.grpPlayerChoice);
            this.Controls.Add(this.lblEnemyWinsCounter);
            this.Controls.Add(this.lblPlayerWins);
            this.Controls.Add(this.lblPLayerWinCounter);
            this.Controls.Add(this.lblEnemyWins);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.imgOpponent);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOpponent)).EndInit();
            this.grpPlayerChoice.ResumeLayout(false);
            this.grpPlayerChoice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgOpponent;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblEnemyWins;
        private System.Windows.Forms.Label lblPLayerWinCounter;
        private System.Windows.Forms.Label lblPlayerWins;
        private System.Windows.Forms.Label lblEnemyWinsCounter;
        private System.Windows.Forms.GroupBox grpPlayerChoice;
        private System.Windows.Forms.RadioButton radScissors;
        private System.Windows.Forms.RadioButton radPaper;
        private System.Windows.Forms.RadioButton radRock;
        private System.Windows.Forms.Button btnPlay;
    }
}

