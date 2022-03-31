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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imgOpponent = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOpponent)).BeginInit();
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
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(703, 57);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(703, 80);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(703, 103);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 8;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
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
            this.imgOpponent.InitialImage = ((System.Drawing.Image)(resources.GetObject("imgOpponent.InitialImage")));
            this.imgOpponent.Location = new System.Drawing.Point(12, 12);
            this.imgOpponent.Name = "imgOpponent";
            this.imgOpponent.Size = new System.Drawing.Size(302, 310);
            this.imgOpponent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgOpponent.TabIndex = 0;
            this.imgOpponent.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgOpponent;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblEnemyWins;
        private System.Windows.Forms.Label lblPLayerWinCounter;
        private System.Windows.Forms.Label lblPlayerWins;
        private System.Windows.Forms.Label lblEnemyWinsCounter;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}

