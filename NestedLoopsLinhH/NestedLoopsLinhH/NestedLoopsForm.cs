using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NestedLoopsLinhH
{
    public partial class frmNestedLoops : Form
    {
        public frmNestedLoops()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            // declare local variables
            int capitalCounter;
            int lowerCounter;

            string capital;
            string lowercase;

            // clear listbox
            this.lstAlphabets.Items.Clear();

            // loop throught the CAPITAL alphabets from 65 to 90
            for (capitalCounter = 65; capitalCounter <= 90; capitalCounter++)
            {
                // for each of the lower alphabets, loop through 97 to 122
                for (lowerCounter = 97; lowerCounter <= 122; lowerCounter++)
                {
                    // convert the lower and capital counter to unicode letter
                    capital = Char.ConvertFromUtf32(capitalCounter);
                    lowercase = Char.ConvertFromUtf32(lowerCounter);

                    // display in the listbox
                    this.lstAlphabets.Items.Add(capitalCounter + " -> " + lowerCounter);
                }
            }
        }
    }
}
