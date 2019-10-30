/*
 * Created by: Linh Ho
 * Created on: October 22 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #27 - Control Objects
 * This program...changes the colours of a button and label
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

namespace ForEachControlLinhH
{
    public partial class frmForEachControl : Form
    {
        public frmForEachControl()
        {
            InitializeComponent();
        }

        private void BtnColour_Click(object sender, EventArgs e)
        {
            // loop through each object on the form and make it blue
            foreach (Control aControlObject in this.Controls)
            {
                aControlObject.BackColor = Color.Blue;
            }
        }

        private void LblColour_Click(object sender, EventArgs e)
        {
            // loop through each object on the form and make it red
            foreach (Control aControlObject in this.Controls)
            {
                aControlObject.BackColor = Color.Red;

                //  if the object is a label, make it brown
                if (aControlObject.GetType() == typeof(Label))
                {
                    aControlObject.BackColor = Color.Brown;
                }
            }

        }
    }
}
