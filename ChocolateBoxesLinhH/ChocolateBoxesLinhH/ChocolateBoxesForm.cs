/*
 * Created by: Linh Ho
 * Created on: October 7th, 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #19 - Chocolate Boxes
 * This program determines what kind of prize user gets, after
 * they enter the amount of chocolate boxes they have sold.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChocolateBoxesLinhH
{
    public partial class frmChocolateBoxes : Form
    {
        // declare constants and variables
        const int BIGPRIZE = 20;
        const int HONOUR = 10;

        public frmChocolateBoxes()
        {
            InitializeComponent();
            // hide the text that displays the prize
            lblPrize.Hide();
            lblReward.Hide();
            
        }

        private void BtnReward_Click(object sender, EventArgs e)
        {
            // declare variables
            int soldBoxes;

            // Allow user to enter numbers in the textbox
            soldBoxes = int.Parse(txtBoxesSold.Text);

            if (soldBoxes > BIGPRIZE)
            {
                lblReward.Show();
                lblPrize.Show();
                lblPrize.Text = "big prize!";
            }
            else
            {
                if (soldBoxes < HONOUR)
                {
                    lblReward.Show();
                    lblReward.Text = "The reward is an Honourable mention!";
 
                }
                else
                {
                    lblReward.Show();
                    lblPrize.Show();
                    lblPrize.Text = "small prize!";
                }

            }
        }
    }
}
