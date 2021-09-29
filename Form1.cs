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
        DateTime freezeStart;
        DateTime freezeEnd;
        int freezeDuration;
        bool FreezeCountRunning;

        Keys current_keyCode;
        Keys last_keyCode;

        public Form1()
        {
            InitializeComponent();
            last_keyCode = Keys.P;          // initialise as letter 'P', not used so safe
            FreezeCountRunning = false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // get the keyboard input
            current_keyCode = e.KeyCode;
            labelKeyInput.Text = current_keyCode.ToString();

            // keystroke "S": start freeze counting
            if (current_keyCode == Keys.S && !FreezeCountRunning && last_keyCode != Keys.S)
            {
                startMeasureTime = DateTime.Now;
                labelStartStop.Text = "started freezing measurement";
                FreezeCountRunning = true;
            }

            // keystroke "E": end freeze counting
            if (current_keyCode == Keys.E && FreezeCountRunning && last_keyCode != Keys.E)
            {
                endMeasureTime = DateTime.Now;
                labelStartStop.Text = "ended, duration (sec) = ";
                int testDuration = (endMeasureTime - startMeasureTime).Milliseconds;
                labelStartStop.Text += testDuration.ToString();
                labelStartStop.Text += " msec";
                FreezeCountRunning = false;

                labelTotalFreezing.Text = (100 * freezeDuration / testDuration).ToString();
            }

            // keystroke "spacebar": freezing
            if (e.KeyCode == Keys.Space && FreezeCountRunning)
            {
                freezeStart = DateTime.Now;
            }

            // keep the last keyStroke
            last_keyCode = current_keyCode;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (last_keyCode == Keys.Space && FreezeCountRunning)
            {
                freezeEnd = DateTime.Now;
                freezeDuration = (freezeEnd - freezeStart).Milliseconds;
                labelFreezing.Text = freezeDuration.ToString();
            }
        }

    }
}
