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
        int correctGuess;
        Random randomNumberGenerator = new Random();
        const int MIN_NUM = 1;
        const int MAX_NUM = 10;
        public frmGuessNumber()
        {
            InitializeComponent();

            // hide the labels
            picMark.Hide();
            lblAnswer.Hide();

            correctGuess = randomNumberGenerator.Next(MIN_NUM, MAX_NUM + 1);
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            // declare variables
            int guessNumber;

            // get the number from user's input from textbox
            guessNumber = int.Parse(txtGuess.Text);

            // assign the random number to the label
            lblAnswer.Text = Convert.ToString(randomNumberGenerator);

            // If... user gets the correct/wrong number display a label, picture and an image
            if (guessNumber == correctGuess)
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
