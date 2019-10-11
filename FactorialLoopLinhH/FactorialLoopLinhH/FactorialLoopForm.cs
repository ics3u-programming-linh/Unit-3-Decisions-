/*
 * Created by: Linh Ho
 * Created on: October 10th, 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #20 - Factorial Do While
 * This program...allows the user to enter a number which calculates and displays
 * factorial number answers on a loop
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

namespace FactorialLoopLinhH
{
    public partial class frmFactorialLoop : Form
    {
        public frmFactorialLoop()
        {
            InitializeComponent();
            lblFactorialAnswer.Hide();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            // declare local variables
            Double factorialAnswer;
            Double factorialNumber;
            int factorialCounter;

            // clear the items from the listbox
            this.lstFactorials.Items.Clear();

            // initialize the final answer to 1
            factorialAnswer = 1;

            // get the number from the user
            factorialNumber = Convert.ToDouble(this.txtNumber.Text);

            // Get the number from user
            factorialNumber = Convert.ToDouble(this.txtNumber.Text);

            for (factorialCounter = 1; factorialCounter <= factorialNumber; factorialCounter++)
            {
                // list the counter number in the listbox for the user to see
                this.lstFactorials.Items.Add(factorialCounter);

                // multiply the counter by the answer
                factorialAnswer = factorialAnswer * factorialCounter;
            }

            // Convert the factorialAnswer to a String and insert it inthe label to display the answer
            this.lblFactorialAnswer.Text = this.txtNumber.Text + "! =" + Convert.ToString(factorialAnswer);

            // show the text
            lblFactorialAnswer.Show();
        }
    }
}

