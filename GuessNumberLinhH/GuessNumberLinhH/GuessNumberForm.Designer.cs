namespace GuessNumberLinhH
{
    partial class frmGuessNumber
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
            this.lblInteger = new System.Windows.Forms.Label();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.picMark = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMark)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInteger
            // 
            this.lblInteger.AutoSize = true;
            this.lblInteger.Location = new System.Drawing.Point(151, 158);
            this.lblInteger.Name = "lblInteger";
            this.lblInteger.Size = new System.Drawing.Size(179, 13);
            this.lblInteger.TabIndex = 0;
            this.lblInteger.Text = "Guess an integer between 1 and 10:";
            // 
            // txtGuess
            // 
            this.txtGuess.Location = new System.Drawing.Point(350, 151);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(100, 20);
            this.txtGuess.TabIndex = 1;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(182, 232);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(350, 253);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(25, 13);
            this.lblAnswer.TabIndex = 3;
            this.lblAnswer.Text = "???";
            // 
            // picMark
            // 
            this.picMark.Image = global::GuessNumberLinhH.Properties.Resources.wrongCheckmark;
            this.picMark.Location = new System.Drawing.Point(519, 132);
            this.picMark.Name = "picMark";
            this.picMark.Size = new System.Drawing.Size(195, 170);
            this.picMark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMark.TabIndex = 4;
            this.picMark.TabStop = false;
            // 
            // frmGuessNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picMark);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.lblInteger);
            this.Name = "frmGuessNumber";
            this.Text = "Guess My Number by Linh H";
            ((System.ComponentModel.ISupportInitialize)(this.picMark)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInteger;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.PictureBox picMark;
    }
}

