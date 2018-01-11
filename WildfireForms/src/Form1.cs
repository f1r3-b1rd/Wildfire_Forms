using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace WildfireForms
{
    public partial class Form1 : Form
    {
        private int speedModifier = 0;
        private Wildfire fire = new Wildfire();
        private bool isRunning = false;
        Thread fireThread;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isRunning)
            {
                fire.runner = this;
                if (!int.TryParse(plantProbability.Text, out fire.plantProbability))
                {
                    MessageBox.Show("Please make sure the Plant Probability is an integer.", "Error");
                    return;
                }
                if (!int.TryParse(fireProbability.Text, out fire.fireProbability))
                {
                    MessageBox.Show("Please make sure the Fire Probability is an integer.", "Error");
                    return;
                }
                if (!int.TryParse(growthRate.Text, out fire.growthRate))
                {
                    MessageBox.Show("Please make sure the Growth Rate is an integer.", "Error");
                    return;
                }
                if (!int.TryParse(burnRate.Text, out fire.burnRate))
                {
                    MessageBox.Show("Please make sure the Burn Rate is an integer.", "Error");
                    return;
                }

                // MessageBox.Show("" + fire.plantProbability);


                fireThread = new Thread(new ThreadStart(fire.Begin));
                fireThread.Start();
                isRunning = true;
                this.startButton.Text = "Stop";
            }
            else
            {
                fireThread.Abort();
                isRunning = false;
                this.startButton.Text = "Start";
            }
        }

        private void speedTrackBar_Scroll(object sender, EventArgs e)
        {
            speedModifier = speedTrackBar.Value;
            fire.speedModifier = speedModifier;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            fire.Reset();
        }

        private void Form1_Close(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
