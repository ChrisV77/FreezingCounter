using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreezingCounter
{
    public partial class Form1 : Form
    {
        DateTime startMeasureTime;
        DateTime endMeasureTime;
        double measureDuration; 
        DateTime freezeStart;
        DateTime freezeEnd;
        TimeSpan freezeEpoch;
        double freezeDuration;
        bool freezeCountRunning;
        bool duringFreezingEpoch;

        Keys current_keyCode;
        Keys last_keyCode;

        public Form1()
        {
            InitializeComponent();
            last_keyCode = Keys.P;          // initialise as letter 'P', not used so safe
            freezeCountRunning = false;
            duringFreezingEpoch = false;
            labelInstructions.Text = "Keyboard, press:\nS=start\nE=end\n<spacebar>=while freezing";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // get the keyboard input
            current_keyCode = e.KeyCode;

            // keystroke "S": start freeze counting
            if (current_keyCode == Keys.S && !freezeCountRunning)
            {
                startMeasureTime = DateTime.Now;
                measureDuration = 0;
                labelStartStop.Text = String.Format("Started {0:hh:mm:ss}", startMeasureTime);
                labelMeasureDuration.Text = String.Format(" {0:F2}", measureDuration);
                freezeCountRunning = true;
                freezeDuration = 0;         // reset freeze total time
                labelFreezingDuration.Text = String.Format("{0:F2}", freezeDuration);
            }

            // keystroke "E": end freeze counting
            if (current_keyCode == Keys.E && freezeCountRunning)
            {
                endMeasureTime = DateTime.Now;
                labelStartStop.Text = String.Format("Started {0:hh:mm:ss}", endMeasureTime);
                measureDuration = (endMeasureTime - startMeasureTime).TotalSeconds;
                labelMeasureDuration.Text = String.Format("{0:F2}", measureDuration);
                labelTotalFreezing.Text = String.Format("{0:F1}", (100 * freezeDuration / measureDuration));
                freezeCountRunning = false;

            }

            // keystroke "spacebar": freezing
            if (e.KeyCode == Keys.Space && freezeCountRunning && !duringFreezingEpoch)
            {
                freezeStart = DateTime.Now;
                duringFreezingEpoch = true;
            }

            // keep the last keyStroke
            last_keyCode = current_keyCode;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (last_keyCode == Keys.Space && freezeCountRunning && duringFreezingEpoch)
            {
                freezeEnd = DateTime.Now;
                freezeEpoch = freezeEnd - freezeStart;
                freezeDuration += freezeEpoch.TotalSeconds;
                labelFreezingDuration.Text = freezeDuration.ToString();
                labelFreezingDuration.Text = String.Format("{0:F2}", freezeDuration);
                labelMeasureDuration.Text = String.Format("{0:F2}", (freezeEnd - startMeasureTime).TotalSeconds);
                duringFreezingEpoch = false;

            }
        }

    }
}
