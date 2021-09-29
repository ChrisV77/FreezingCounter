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
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // get the keyboard input
            current_keyCode = e.KeyCode;
            labelKeyInput.Text = current_keyCode.ToString();

            // keystroke "S": start freeze counting
            if (current_keyCode == Keys.S && !freezeCountRunning && last_keyCode != Keys.S)
            {
                startMeasureTime = DateTime.Now;
                measureDuration = 0;
                labelStartStop.Text = "started freezing measurement";
                labelMeasureDuration.Text = measureDuration.ToString();
                freezeCountRunning = true;
                freezeDuration = 0;         // reset freeze total time
                labelFreezingDuration.Text = freezeDuration.ToString();
            }

            // keystroke "E": end freeze counting
            if (current_keyCode == Keys.E && freezeCountRunning && last_keyCode != Keys.E)
            {
                endMeasureTime = DateTime.Now;
                labelStartStop.Text = "ended, duration (sec) = ";
                measureDuration = (endMeasureTime - startMeasureTime).TotalSeconds;
                labelTotalFreezing.Text = (100 * freezeDuration / measureDuration).ToString();
                freezeCountRunning = false;

            }

            // keystroke "spacebar": freezing
            if (e.KeyCode == Keys.Space && freezeCountRunning && !duringFreezingEpoch)
            {
                freezeStart = DateTime.Now;
                labelFreezingDuration.Text = freezeDuration.ToString();
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
                labelMeasureDuration.Text = (freezeEnd - startMeasureTime).TotalSeconds.ToString();
                duringFreezingEpoch = false;

            }
        }

    }
}
