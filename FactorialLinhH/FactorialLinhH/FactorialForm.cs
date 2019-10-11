/*
 * Created by: Linh Ho
 * Created on: October 10th, 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #20 - Factorial Do While
 * This program...allows the user to enter a number which calculates and displays
 * factorial number answers...
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

namespace FactorialLinhH
{
    public partial class frmFactorial : Form
    {
        public frmFactorial()
        {
            InitializeComponent();
            lblAnswer.Hide();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            // declare local variables
            Double factorialAnswer;
            Double factorialNumber;
            int factorialCounter;

            // clear the items from the listbox
            this.lstFactorial.Items.Clear();

            // initialize the final answer to 1
            factorialAnswer = 1;

            // get the number from the user
            factorialNumber = Convert.ToDouble(this.txtNumber.Text);

            // set the counter to 0
            factorialCounter = 0;

            // multiply the counter by the next incremented number until it reaches the user's number
            do
            {
                // increment the counter by 1
                factorialCounter = factorialCounter + 1;

                // list the counter number in the listbox for the user to see
                lstFactorial.Items.Add(factorialCounter);

                // multiply the counter by the answer
                factorialAnswer = factorialAnswer * factorialCounter;

            } while (factorialCounter < factorialNumber);

            // convert the factorialAnswer to a String and insert it into the label
            this.lblAnswer.Text = this.txtNumber.Text + "! = " + Convert.ToString(factorialAnswer);

            // show the label answer
            lblAnswer.Show();
        }
    }
}
