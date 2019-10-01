/*
 * Created by: Linh Ho
 * Created on: Oct 1st, 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #16 - Guessing Number
 * This program...asks user to input a number, if the user guesses it right or wrong, 
 * it displays a sound, text and image.
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

namespace GuessNumberLinhH
{
    public partial class frmGuessNumber : Form
    {
        public frmGuessNumber()
        {
            InitializeComponent();

            // hide the labels
            picMark.Hide();
            lblAnswer.Hide();
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            // declare constants and variables
            const int NUMBER = 5;
            int guessNumber;

            // get the number from user's input from textbox
            guessNumber = int.Parse(txtGuess.Text);

            if (guessNumber == NUMBER)
            {
                lblAnswer.Show();
                picMark.Show();
                lblAnswer.Text = "CORRECT!";
                picMark.Image = Properties.Resources.checkmark;
            }
            else
            {
                lblAnswer.Show();
                picMark.Show();
                lblAnswer.Text = "WRONG!";
                picMark.Image = Properties.Resources.wrongCheckmark;
            }
                

            


        }
    }
}
