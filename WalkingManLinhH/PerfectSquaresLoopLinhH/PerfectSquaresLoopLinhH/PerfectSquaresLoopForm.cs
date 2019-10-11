using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerfectSquaresLoopLinhH
{
    public partial class frmPerfectSquaresLoop : Form
    {
        public frmPerfectSquaresLoop()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            // declare local variables
            int endingValue;
            int value;
            Double squareRootAsDouble;
            int squareRootAsInteger;

            // set the initial values
            value = 0;

            // clear all items from the list box
            this.lstPerfectSquares.Items.Clear();

            // get the user's end value selection from the number up-down box
            endingValue = Convert.ToInt32(this.nudEndValue.Value);

            // continue stating any perfect squares between the min and user's selected value
            while (value <= endingValue)
            {
                // increment the value by 1
                value = value + 1;

                // take the square root of the value
                squareRootAsDouble = Math.Sqrt(value);

                // convert the double to an integer
                squareRootAsInteger = Convert.ToInt32(squareRootAsDouble);

                // the only way for both the decimal and the integer to be equal is if the value was a perfect square
                if (squareRootAsInteger == squareRootAsDouble)
                {
                    this.lstPerfectSquares.Items.Add(value + " is a perfect square");

                    // refresh form
                    this.Refresh();

                }
            }


        }
    }
}
