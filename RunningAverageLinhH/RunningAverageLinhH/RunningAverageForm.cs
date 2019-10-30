using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunningAverageLinhH
{
    public partial class frmRunningAverage : Form
    {
        // declare the constants and variables
        double sum = 0;
        double numbersByNumbers = 0;

        public frmRunningAverage()
        {
            InitializeComponent();
        }

        private void BtnAverage_Click(object sender, EventArgs e)
        {
            // declare local variables
            double userValue;
            double average;
            
            // get the number from the textbox 
            userValue = double.Parse(txtNumber.Text);

            // increment the number
            numbersByNumbers++;

            // calculate the average
            sum = sum + userValue;
            average = sum / numbersByNumbers;

            // display the average of the running
            lblAverageAnswer.Text = Convert.ToString(average);



        }
    }
}
