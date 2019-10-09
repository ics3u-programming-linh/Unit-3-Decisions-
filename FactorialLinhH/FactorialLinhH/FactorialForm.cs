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
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            // declare local variables
            double factorialAnswer;
            double factorialNumber;
            int factorialCounter;

            // clear the items from the listbox
            this.lstFactorialNumbers.Items.Clear();

            // initialize the final answer to 1
            
            // get the number from the user
            factorialNumber = Convert.ToDouble(this.txtNumber.Text);

            // set the counter to 0

            // multiply the counter by the next incremented number until it reaches the user's number
            do
            {
                // increment the counter by 1

                // list the counter number in the listbox for the user to see

                // multiply the counter by the answer
            } while ();

            // convert the factorialAnswer to a String and insert it into the label
            this.lblFactorialAnswer.Text = this.txtNumber.Text + "! = " + Convert.ToString(factorialAnswer);
        }
    }
}
