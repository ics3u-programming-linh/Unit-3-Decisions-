/*
 * Created by: First Last
 * Created on: Day-Month-Year
 * Created for: ICS3U Programming
 * Daily Assignment – Day #18 - Rock, Paper, Scissors
 * This program allows user three of the following options, rock, paper or scissors
 * then when they press on a button, the computer randomizes and selects an option and it will determine who wins.
 * it will show a text whether user wins, lose or tied to the computer
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

namespace RockPaperScissorsLinhH
{
    public partial class frmRockPaperScissors : Form

    {   // declare global variables and constants
        const int MIN_VALUE = 1;
        const int MAX_VALUE = 3;
        Random randomNumberGenerator;

        public frmRockPaperScissors()
        {
            InitializeComponent();

            // create the random Number generator object 
            randomNumberGenerator = new Random();

            // hide label
            lblOutcome.Hide();
        }

        private void GrbPlayerChoice_Enter(object sender, EventArgs e)
        {

        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            // declare local variables and constants
            int playerChoice, computerChoice;
            const int ROCK = 1;
            const int PAPER = 2;
            const int SCISSORS = 3;

            // get the user's selection, if there is no selection set it to 0
            if (radPlayerRock.Checked == true)
            {
                playerChoice = ROCK;
            }
            else if (radPlayerPaper.Checked == true)
            {
                playerChoice = PAPER;
            }
            else if (radPlayerScissors.Checked == true)
            {
                playerChoice = SCISSORS;
            }
            else
            {
                playerChoice = 0;
            }

            // randomly generate a number between 1 and 3, representing ROCK, PAPER or SCISSORS
            computerChoice = randomNumberGenerator.Next(MIN_VALUE, MAX_VALUE + 1);

            //Show the outcome label
            this.lblOutcome.Show();

            // set the radio button for the computer's choice
            if (computerChoice == ROCK)
            {
                this.radComputerRock.Checked = true;
            }
            else if (computerChoice == PAPER)
            {
                this.radComputerPaper.Checked = true;
            }
            else
            {
                this.radComputerScissors.Checked = true;
            }

            // compare the user and the computer's choice and determine the winner by displaying it as a text

            if (computerChoice == ROCK)
            {

                if (playerChoice == SCISSORS)
                {
                    // display user lose
                    this.lblOutcome.Text = "You lose!";
                }
                else if (playerChoice == PAPER)
                {
                        // display user lose
                        this.lblOutcome.Text = "You win!";
                }
                else if (playerChoice == ROCK)
                {
                        // display user tied
                        this.lblOutcome.Text = "Tied!";
                }
            }

                else if (computerChoice == PAPER)
                {
                    if (playerChoice == SCISSORS)
                    {
                        // display user wins
                        this.lblOutcome.Text = "You Win!";
                    }
                    else if (playerChoice == PAPER)
                    {
                        // display user lose
                        this.lblOutcome.Text = "You tied!";
                    }
                    else if (playerChoice == ROCK)
                    {
                        // display user lose
                        this.lblOutcome.Text = "You lose!";
                    }
                }
                else if (computerChoice == SCISSORS)
                {
                    if (playerChoice == ROCK)
                    {
                        // display user wins
                        this.lblOutcome.Text = "You Win!";
                    }
                    else if (playerChoice == SCISSORS)
                    {
                        // display user tied
                        this.lblOutcome.Text = "You tied!";
                    }
                    else if (playerChoice == PAPER)
                    {
                        // display user lose
                        this.lblOutcome.Text = "You lose!";
                    }
                    else if (playerChoice == ROCK)
                    {
                        // display user wins
                        this.lblOutcome.Text = "You Win!";
                    }
                }
            }
        }
    }

