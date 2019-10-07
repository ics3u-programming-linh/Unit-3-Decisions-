namespace ChocolateBoxesLinhH
{
    partial class frmChocolateBoxes
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
            this.lblSold = new System.Windows.Forms.Label();
            this.txtBoxesSold = new System.Windows.Forms.TextBox();
            this.btnReward = new System.Windows.Forms.Button();
            this.lblReward = new System.Windows.Forms.Label();
            this.lblPrize = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSold
            // 
            this.lblSold.AutoSize = true;
            this.lblSold.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSold.Location = new System.Drawing.Point(71, 117);
            this.lblSold.Name = "lblSold";
            this.lblSold.Size = new System.Drawing.Size(431, 34);
            this.lblSold.TabIndex = 0;
            this.lblSold.Text = "Enter the number of boxes sold:";
            // 
            // txtBoxesSold
            // 
            this.txtBoxesSold.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxesSold.Location = new System.Drawing.Point(508, 121);
            this.txtBoxesSold.Name = "txtBoxesSold";
            this.txtBoxesSold.Size = new System.Drawing.Size(152, 31);
            this.txtBoxesSold.TabIndex = 1;
            // 
            // btnReward
            // 
            this.btnReward.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReward.Location = new System.Drawing.Point(284, 202);
            this.btnReward.Name = "btnReward";
            this.btnReward.Size = new System.Drawing.Size(144, 44);
            this.btnReward.TabIndex = 2;
            this.btnReward.Text = "Get Reward";
            this.btnReward.UseVisualStyleBackColor = true;
            this.btnReward.Click += new System.EventHandler(this.BtnReward_Click);
            // 
            // lblReward
            // 
            this.lblReward.AutoSize = true;
            this.lblReward.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReward.Location = new System.Drawing.Point(136, 322);
            this.lblReward.Name = "lblReward";
            this.lblReward.Size = new System.Drawing.Size(160, 25);
            this.lblReward.TabIndex = 3;
            this.lblReward.Text = "The reward is a";
            // 
            // lblPrize
            // 
            this.lblPrize.AutoSize = true;
            this.lblPrize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrize.Location = new System.Drawing.Point(302, 322);
            this.lblPrize.Name = "lblPrize";
            this.lblPrize.Size = new System.Drawing.Size(105, 25);
            this.lblPrize.TabIndex = 4;
            this.lblPrize.Text = "REWARD";
            // 
            // frmChocolateBoxes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPrize);
            this.Controls.Add(this.lblReward);
            this.Controls.Add(this.btnReward);
            this.Controls.Add(this.txtBoxesSold);
            this.Controls.Add(this.lblSold);
            this.Name = "frmChocolateBoxes";
            this.Text = "Chocolate Boxes by Linh H";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSold;
        private System.Windows.Forms.TextBox txtBoxesSold;
        private System.Windows.Forms.Button btnReward;
        private System.Windows.Forms.Label lblReward;
        private System.Windows.Forms.Label lblPrize;
    }
}

