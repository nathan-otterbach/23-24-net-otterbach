using System;
using System.Windows.Forms;

namespace Ampel_Sim
{
    enum TrafficLightState
    {
        Red,
        Yellow,
        Green
    }

    public partial class Form1 : Form
    {
        private TrafficLightState currentLightState = TrafficLightState.Red;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize the traffic light state.
            pictureBox1.BackColor = Color.Red;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Stop the timer.
            timer1.Enabled = false;
            pictureBox1.BackColor = Color.Red;
            currentLightState = TrafficLightState.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Start the timer and set the initial state.
            timer1.Enabled = true;
            pictureBox1.BackColor = Color.Red;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Transition to the next traffic light state.
            ChangeToNextState();
        }

        private void ChangeToNextState()
        {
            switch (currentLightState)
            {
                case TrafficLightState.Red:
                    pictureBox1.BackColor = Color.Yellow;
                    currentLightState = TrafficLightState.Yellow;
                    break;
                case TrafficLightState.Yellow:
                    pictureBox1.BackColor = Color.Green;
                    currentLightState = TrafficLightState.Green;
                    break;
                case TrafficLightState.Green:
                    pictureBox1.BackColor = Color.Red;
                    currentLightState = TrafficLightState.Red;
                    break;
            }
        }
    }
}