namespace ForEachControlLinhH
{
    partial class frmForEachControl
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
            this.btnColour = new System.Windows.Forms.Button();
            this.lblColour = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnColour
            // 
            this.btnColour.Location = new System.Drawing.Point(298, 135);
            this.btnColour.Name = "btnColour";
            this.btnColour.Size = new System.Drawing.Size(146, 29);
            this.btnColour.TabIndex = 0;
            this.btnColour.Text = "Change Colour!";
            this.btnColour.UseVisualStyleBackColor = true;
            this.btnColour.Click += new System.EventHandler(this.BtnColour_Click);
            // 
            // lblColour
            // 
            this.lblColour.AutoSize = true;
            this.lblColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColour.Location = new System.Drawing.Point(293, 238);
            this.lblColour.Name = "lblColour";
            this.lblColour.Size = new System.Drawing.Size(162, 25);
            this.lblColour.TabIndex = 1;
            this.lblColour.Text = "Change Colour!";
            this.lblColour.Click += new System.EventHandler(this.LblColour_Click);
            // 
            // frmForEachControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblColour);
            this.Controls.Add(this.btnColour);
            this.Name = "frmForEachControl";
            this.Text = "For Each... with Control Objects";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnColour;
        private System.Windows.Forms.Label lblColour;
    }
}

