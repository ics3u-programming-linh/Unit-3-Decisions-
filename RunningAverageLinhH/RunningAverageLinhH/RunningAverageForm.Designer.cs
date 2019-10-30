namespace RunningAverageLinhH
{
    partial class frmRunningAverage
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
            this.lblNumber = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.btnAverage = new System.Windows.Forms.Button();
            this.lblExit = new System.Windows.Forms.Label();
            this.lblAverageAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(185, 137);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(147, 13);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "Enter a number from 0 to 100:";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(388, 129);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 1;
            // 
            // btnAverage
            // 
            this.btnAverage.Location = new System.Drawing.Point(188, 208);
            this.btnAverage.Name = "btnAverage";
            this.btnAverage.Size = new System.Drawing.Size(144, 44);
            this.btnAverage.TabIndex = 2;
            this.btnAverage.Text = "Calculate Average";
            this.btnAverage.UseVisualStyleBackColor = true;
            this.btnAverage.Click += new System.EventHandler(this.BtnAverage_Click);
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Location = new System.Drawing.Point(188, 175);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(81, 13);
            this.lblExit.TabIndex = 3;
            this.lblExit.Text = "(Enter -1 to exit)";
            // 
            // lblAverageAnswer
            // 
            this.lblAverageAnswer.AutoSize = true;
            this.lblAverageAnswer.Location = new System.Drawing.Point(191, 281);
            this.lblAverageAnswer.Name = "lblAverageAnswer";
            this.lblAverageAnswer.Size = new System.Drawing.Size(35, 13);
            this.lblAverageAnswer.TabIndex = 4;
            this.lblAverageAnswer.Text = "label1";
            // 
            // frmRunningAverage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAverageAnswer);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.btnAverage);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.lblNumber);
            this.Name = "frmRunningAverage";
            this.Text = "Running Average by Linh H";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Button btnAverage;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label lblAverageAnswer;
    }
}

