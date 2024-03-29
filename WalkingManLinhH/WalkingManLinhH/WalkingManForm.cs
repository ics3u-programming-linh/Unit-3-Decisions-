﻿/*
 * Created by: Linh Ho
 * Created on: October 10th, 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #21 - Walking Man
 * This program displays of a man walking 
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
// add the following library to use the sleep timer
using System.Threading;

namespace WalkingManLinhH
{
    public partial class frmWalkingMan : Form
    {
        public frmWalkingMan()
        {
            InitializeComponent();
        }

        private void BtnWalk_Click(object sender, EventArgs e)
        {
            // declare local variables and constants
            const byte MAX_FRAMES = 10;
            int pictureFrameCounter = 1; 

            // continue this loop while the frame counter has not reached the max number of frames we have to display 
            while (pictureFrameCounter < MAX_FRAMES + 1)
            {
                if (pictureFrameCounter == 1)
                {
                    this.picMan.Image = Properties.Resources.walk1;
                }
                else if (pictureFrameCounter == 2)
                {
                    this.picMan.Image = Properties.Resources.walk2;
                }
                else if (pictureFrameCounter == 3)
                {
                    this.picMan.Image = Properties.Resources.walk3;
                }
                else if (pictureFrameCounter == 4)
                {
                    this.picMan.Image = Properties.Resources.walk4;
                }
                else if (pictureFrameCounter == 5)
                {
                    this.picMan.Image = Properties.Resources.walk5;
                }
                else if (pictureFrameCounter == 6)
                {
                    this.picMan.Image = Properties.Resources.walk6;
                }
                else if (pictureFrameCounter == 7)
                {
                    this.picMan.Image = Properties.Resources.walk7;
                }
                else if (pictureFrameCounter == 8)
                {
                    this.picMan.Image = Properties.Resources.walk8;
                }
                else if (pictureFrameCounter == 9)
                {
                    this.picMan.Image = Properties.Resources.walk9;
                }
                else if (pictureFrameCounter == 10)
                {
                    this.picMan.Image = Properties.Resources.walk10;
                }

                // Increment the counter
                pictureFrameCounter = pictureFrameCounter + 1;

                // refresh the form
                this.Refresh();

                // pause the loop for 100 milliseconds
                Thread.Sleep(100);
            }
        }

        private void PicMan_Click(object sender, EventArgs e)
        {

        }
    }
}
