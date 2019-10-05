namespace RockPaperScissorsLinhH
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
            this.grbPlayerChoice = new System.Windows.Forms.GroupBox();
            this.radPlayerScissors = new System.Windows.Forms.RadioButton();
            this.radPlayerPaper = new System.Windows.Forms.RadioButton();
            this.radPlayerRock = new System.Windows.Forms.RadioButton();
            this.grbComputerChoice = new System.Windows.Forms.GroupBox();
            this.radComputerScissors = new System.Windows.Forms.RadioButton();
            this.radComputerPaper = new System.Windows.Forms.RadioButton();
            this.radComputerRock = new System.Windows.Forms.RadioButton();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblOutcome = new System.Windows.Forms.Label();
            this.grbPlayerChoice.SuspendLayout();
            this.grbComputerChoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbPlayerChoice
            // 
            this.grbPlayerChoice.Controls.Add(this.radPlayerScissors);
            this.grbPlayerChoice.Controls.Add(this.radPlayerPaper);
            this.grbPlayerChoice.Controls.Add(this.radPlayerRock);
            this.grbPlayerChoice.Location = new System.Drawing.Point(76, 35);
            this.grbPlayerChoice.Name = "grbPlayerChoice";
            this.grbPlayerChoice.Size = new System.Drawing.Size(197, 177);
            this.grbPlayerChoice.TabIndex = 0;
            this.grbPlayerChoice.TabStop = false;
            this.grbPlayerChoice.Text = "Player\'s Choice";
            this.grbPlayerChoice.Enter += new System.EventHandler(this.GrbPlayerChoice_Enter);
            // 
            // radPlayerScissors
            // 
            this.radPlayerScissors.AutoSize = true;
            this.radPlayerScissors.Location = new System.Drawing.Point(19, 130);
            this.radPlayerScissors.Name = "radPlayerScissors";
            this.radPlayerScissors.Size = new System.Drawing.Size(64, 17);
            this.radPlayerScissors.TabIndex = 4;
            this.radPlayerScissors.TabStop = true;
            this.radPlayerScissors.Text = "Scissors";
            this.radPlayerScissors.UseVisualStyleBackColor = true;
            // 
            // radPlayerPaper
            // 
            this.radPlayerPaper.AutoSize = true;
            this.radPlayerPaper.Location = new System.Drawing.Point(19, 78);
            this.radPlayerPaper.Name = "radPlayerPaper";
            this.radPlayerPaper.Size = new System.Drawing.Size(53, 17);
            this.radPlayerPaper.TabIndex = 3;
            this.radPlayerPaper.TabStop = true;
            this.radPlayerPaper.Text = "Paper";
            this.radPlayerPaper.UseVisualStyleBackColor = true;
            // 
            // radPlayerRock
            // 
            this.radPlayerRock.AutoSize = true;
            this.radPlayerRock.Location = new System.Drawing.Point(19, 29);
            this.radPlayerRock.Name = "radPlayerRock";
            this.radPlayerRock.Size = new System.Drawing.Size(51, 17);
            this.radPlayerRock.TabIndex = 2;
            this.radPlayerRock.TabStop = true;
            this.radPlayerRock.Text = "Rock";
            this.radPlayerRock.UseVisualStyleBackColor = true;
            // 
            // grbComputerChoice
            // 
            this.grbComputerChoice.Controls.Add(this.radComputerScissors);
            this.grbComputerChoice.Controls.Add(this.radComputerPaper);
            this.grbComputerChoice.Controls.Add(this.radComputerRock);
            this.grbComputerChoice.Location = new System.Drawing.Point(73, 235);
            this.grbComputerChoice.Name = "grbComputerChoice";
            this.grbComputerChoice.Size = new System.Drawing.Size(200, 190);
            this.grbComputerChoice.TabIndex = 1;
            this.grbComputerChoice.TabStop = false;
            this.grbComputerChoice.Text = "Computer\'s Choice";
            // 
            // radComputerScissors
            // 
            this.radComputerScissors.AutoSize = true;
            this.radComputerScissors.Location = new System.Drawing.Point(22, 142);
            this.radComputerScissors.Name = "radComputerScissors";
            this.radComputerScissors.Size = new System.Drawing.Size(64, 17);
            this.radComputerScissors.TabIndex = 7;
            this.radComputerScissors.TabStop = true;
            this.radComputerScissors.Text = "Scissors";
            this.radComputerScissors.UseVisualStyleBackColor = true;
            // 
            // radComputerPaper
            // 
            this.radComputerPaper.AutoSize = true;
            this.radComputerPaper.Location = new System.Drawing.Point(22, 93);
            this.radComputerPaper.Name = "radComputerPaper";
            this.radComputerPaper.Size = new System.Drawing.Size(53, 17);
            this.radComputerPaper.TabIndex = 6;
            this.radComputerPaper.TabStop = true;
            this.radComputerPaper.Text = "Paper";
            this.radComputerPaper.UseVisualStyleBackColor = true;
            // 
            // radComputerRock
            // 
            this.radComputerRock.AutoSize = true;
            this.radComputerRock.Location = new System.Drawing.Point(22, 39);
            this.radComputerRock.Name = "radComputerRock";
            this.radComputerRock.Size = new System.Drawing.Size(51, 17);
            this.radComputerRock.TabIndex = 5;
            this.radComputerRock.TabStop = true;
            this.radComputerRock.Text = "Rock";
            this.radComputerRock.UseVisualStyleBackColor = true;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(373, 189);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(126, 49);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // lblOutcome
            // 
            this.lblOutcome.AutoSize = true;
            this.lblOutcome.Location = new System.Drawing.Point(373, 274);
            this.lblOutcome.Name = "lblOutcome";
            this.lblOutcome.Size = new System.Drawing.Size(50, 13);
            this.lblOutcome.TabIndex = 3;
            this.lblOutcome.Text = "Outcome";
            // 
            // frmRockPaperScissors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOutcome);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.grbComputerChoice);
            this.Controls.Add(this.grbPlayerChoice);
            this.Name = "frmRockPaperScissors";
            this.Text = "Rock Paper Scissors by Linh H";
            this.grbPlayerChoice.ResumeLayout(false);
            this.grbPlayerChoice.PerformLayout();
            this.grbComputerChoice.ResumeLayout(false);
            this.grbComputerChoice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPlayerChoice;
        private System.Windows.Forms.RadioButton radPlayerScissors;
        private System.Windows.Forms.RadioButton radPlayerPaper;
        private System.Windows.Forms.RadioButton radPlayerRock;
        private System.Windows.Forms.GroupBox grbComputerChoice;
        private System.Windows.Forms.RadioButton radComputerScissors;
        private System.Windows.Forms.RadioButton radComputerPaper;
        private System.Windows.Forms.RadioButton radComputerRock;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblOutcome;
    }
}

