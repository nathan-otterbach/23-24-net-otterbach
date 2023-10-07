namespace Roboter_Sim
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

        int pictureBoxStartPosition = 10;
        int pictureBoxEndPosition;
        int width;
        bool movingRight = false;

        public Form1()
        {
            InitializeComponent();
            width = this.ClientSize.Width;
            this.Width = width;

            // Calculate the end position for the PictureBox
            pictureBoxEndPosition = width - pictureBox1.Width - 10;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize the traffic light state.
            pictureBox1.BackColor = Color.Red;
        }

        // stop
        private void button1_Click(object sender, EventArgs e)
        {
            // Stop the timer.
            timer1.Enabled = false;
            timer2.Enabled = false;
            pictureBox1.BackColor = Color.Red;
            currentLightState = TrafficLightState.Red;

            // Stop moving the PictureBox and reset its position
            movingRight = false;
            pictureBox1.Left = pictureBoxStartPosition;
        }

        // start
        private void button2_Click(object sender, EventArgs e)
        {
            // Start the timer and set the initial state.
            timer1.Enabled = true;
            timer2.Enabled = true;
            pictureBox1.BackColor = Color.Red;

            // Start moving the PictureBox to the right
            movingRight = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Transition to the next traffic light state.
            ChangeToNextState();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (movingRight)
            {
                // Move the PictureBox to the right
                pictureBox1.Left += 10;

                // Check if it has reached the end position
                if (pictureBox1.Left >= pictureBoxEndPosition)
                {
                    // Stop moving to the right and start moving back to the left
                    movingRight = false;
                }
            }
            else
            {
                // Move the PictureBox back to the left (starting position)
                pictureBox1.Left -= 10;

                // Check if it has reached the starting position
                if (pictureBox1.Left <= pictureBoxStartPosition)
                {
                    // Stop moving to the left and start moving to the right
                    movingRight = true;
                }
            }
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