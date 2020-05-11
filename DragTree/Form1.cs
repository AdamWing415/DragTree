using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace DragTree
{
    public partial class Form1 : Form
    {
        //variable for active row of lights
        int row = 1;

        //stopwatch for reaaction time
        Stopwatch reactionWatch = new Stopwatch();
        public Form1()
        {
            InitializeComponent();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            //resets backcolour on all lights
            topYellow.BackColor = Color.DimGray;
            midYellow.BackColor = Color.DimGray;
            bottomYellow.BackColor = Color.DimGray;

            green.BackColor = Color.DimGray;

            //resets time label
            timeLabel.Text = "0.000";

            //resets row
            row = 1;

            //resets stopwatch
            reactionWatch.Reset();
        }

        private void lightTimer_Tick(object sender, EventArgs e)
        {
            //goes row by row to activate lights
            if (row == 1)
            {
                topYellow.BackColor = Color.Goldenrod;
                row++;
            }
            else if (row == 2)
            {
                midYellow.BackColor = Color.Goldenrod;
                row++;
            }
            else if (row == 3)
            {
                bottomYellow.BackColor = Color.Goldenrod;
                row++;
            }
            else if (row == 4)
            {
                green.BackColor = Color.Green;
                //starts stopwatch and stops the timer
                reactionWatch.Start();
                lightTimer.Enabled = false;
            }
        }

        private void startbutton_Click(object sender, EventArgs e)
        {
            //strats the timer
            lightTimer.Enabled = true;
        }

        private void GOButton_Click(object sender, EventArgs e)
        {
            //stops the stopwatch
            reactionWatch.Stop();

            //records teh timespan
            TimeSpan elapsed = reactionWatch.Elapsed;

            //checks for false start and displays accordingly
            if (elapsed.TotalMilliseconds > 0)
            {
                //displays reaction time
                timeLabel.Text = elapsed.ToString(@"s\:fff");
            }
            else
            {
                timeLabel.Text = "FALSE START";
            }
        }
    }
}
